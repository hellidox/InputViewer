﻿using System;
using StrikeCore;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UI.Extensions;

public class PlayerSelectionMenu : BaseMenu
{
	public bool \u02BC\u02BF\u02B4\u02BE\u02B2\u02B6\u02B7\u02B5\u02BD\u02BC\u02B6
	{
		get
		{
			return this.\u02BE\u02BA\u02BD\u02B5\u02BE\u02C0\u02B7\u02B3\u02BA\u02B4\u02BD == PlayerSelectionMenu.\u02C1\u02C1\u02B7\u02BD\u02BC\u02B7\u02C0\u02B3\u02BE\u02B7\u02BB.Ready;
		}
	}

	private void \u02BA\u02B5\u02B2\u02BF\u02B4\u02C1\u02BC\u02B3\u02BA\u02B8\u02C0()
	{
		if (this.\u02BC\u02BE\u02C1\u02B8\u02BE\u02C1\u02BE\u02BF\u02BC\u02BC\u02BA)
		{
			\u02B3\u02B7\u02B4\u02BE\u02BE\u02C1\u02BE\u02BB\u02B2\u02B9\u02BA.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B8\u02B8\u02B2\u02B3\u02BA\u02B2\u02BB\u02C1\u02B5\u02C0\u02BB(this.controllingPlayer.playerProfile);
		}
		if (this.\u02C1\u02B3\u02BE\u02B4\u02C0\u02BC\u02BD\u02C1\u02B4\u02C0\u02BC)
		{
			this.controllingPlayer.playerProfile.\u02BE\u02B5\u02BD\u02B3\u02B3\u02C1\u02BC\u02BC\u02BE\u02B6\u02B7(this.\u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF, this.\u02B5\u02BD\u02C0\u02C1\u02BF\u02BF\u02B7\u02BF\u02B6\u02C1\u02BA);
			this.playerStatsMenu.\u02B5\u02BF\u02B4\u02B2\u02C0\u02BE\u02BF\u02C1\u02C0\u02BD\u02B6();
			return;
		}
		this.\u02BE\u02BA\u02BD\u02B5\u02BE\u02C0\u02B7\u02B3\u02BA\u02B4\u02BD = PlayerSelectionMenu.\u02C1\u02C1\u02B7\u02BD\u02BC\u02B7\u02C0\u02B3\u02BE\u02B7\u02BB.Ready;
		this.\u02BE\u02B9\u02BC\u02BA\u02B3\u02BD\u02C1\u02B5\u02B3\u02C1\u02C0();
		if (this.\u02BC\u02BE\u02C1\u02B8\u02BE\u02C1\u02BE\u02BF\u02BC\u02BC\u02BA)
		{
			\u02B3\u02B7\u02B4\u02BE\u02BE\u02C1\u02BE\u02BB\u02B2\u02B9\u02BA.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02C1\u02BB\u02B4\u02BD\u02B8\u02BA\u02B7\u02BC\u02B9\u02B9\u02BC();
		}
	}

	protected override void \u02B9\u02B8\u02C0\u02B7\u02BA\u02B3\u02BB\u02C0\u02B3\u02C1\u02B8()
	{
		TextMeshProUGUI[] array;
		switch (this.\u02BE\u02BA\u02BD\u02B5\u02BE\u02C0\u02B7\u02B3\u02BA\u02B4\u02BD)
		{
		case PlayerSelectionMenu.\u02C1\u02C1\u02B7\u02BD\u02BC\u02B7\u02C0\u02B3\u02BE\u02B7\u02BB.Confirm:
			array = this.confirmTexts;
			break;
		case PlayerSelectionMenu.\u02C1\u02C1\u02B7\u02BD\u02BC\u02B7\u02C0\u02B3\u02BE\u02B7\u02BB.Instrument:
			array = this.instrumentTexts;
			break;
		case PlayerSelectionMenu.\u02C1\u02C1\u02B7\u02BD\u02BC\u02B7\u02C0\u02B3\u02BE\u02B7\u02BB.Difficulty:
			array = this.difficultyTexts;
			break;
		case PlayerSelectionMenu.\u02C1\u02C1\u02B7\u02BD\u02BC\u02B7\u02C0\u02B3\u02BE\u02B7\u02BB.Modifiers:
			array = this.modifierTexts;
			break;
		default:
			array = null;
			break;
		}
		TextMeshProUGUI[] array2 = array;
		for (int i = 0; i < array2.Length; i++)
		{
			array2[i].color = ((i == this.\u02B3\u02BF\u02BB\u02BB\u02B5\u02B7\u02B8\u02BE\u02B7\u02B3\u02B3) ? this.highlightColor : this.defaultColor);
		}
		if (this.\u02BE\u02BA\u02BD\u02B5\u02BE\u02C0\u02B7\u02B3\u02BA\u02B4\u02BD == PlayerSelectionMenu.\u02C1\u02C1\u02B7\u02BD\u02BC\u02B7\u02C0\u02B3\u02BE\u02B7\u02BB.Instrument)
		{
			int num = this.\u02BB\u02B3\u02C0\u02BC\u02BF\u02BD\u02B9\u02B2\u02BC\u02BE\u02B7;
			for (int j = 0; j < this.\u02C0\u02B8\u02B3\u02B7\u02B3\u02BA\u02BB\u02B4\u02B4\u02BF\u02B5; j++)
			{
				this.instrumentTexts[j].text = LanguageManager.instance.GetString(this.\u02B8\u02BE\u02C1\u02BE\u02B2\u02C0\u02B6\u02C0\u02B5\u02B8\u02B5[num]);
				if (this.\u02C1\u02B6\u02C1\u02B2\u02B3\u02BE\u02BD\u02BF\u02B8\u02BF\u02C0[num] == Instrument.None)
				{
					this.difficultyIcons[j].gameObject.SetActive(false);
					this.instrumentTexts[j].rectTransform.localPosition = Vector2.zero;
				}
				else
				{
					DifficultyDisplay difficultyDisplay = this.difficultyIcons[j];
					difficultyDisplay.\u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF = this.\u02C1\u02B6\u02C1\u02B2\u02B3\u02BE\u02BD\u02BF\u02B8\u02BF\u02C0[num];
					difficultyDisplay.\u02B8\u02BF\u02B2\u02C1\u02B4\u02BE\u02C1\u02B4\u02BB\u02B3\u02BC(this.\u02BF\u02B6\u02BE\u02C1\u02C1\u02B9\u02BA\u02B5\u02BB\u02B3\u02BD[num], true, false);
					difficultyDisplay.gameObject.SetActive(true);
					this.instrumentTexts[j].rectTransform.localPosition = new Vector2(47.5f, 0f);
				}
				num++;
			}
			for (int k = this.\u02C0\u02B8\u02B3\u02B7\u02B3\u02BA\u02BB\u02B4\u02B4\u02BF\u02B5; k < this.instrumentTexts.Length; k++)
			{
				this.instrumentTexts[k].text = string.Empty;
				this.difficultyIcons[k].gameObject.SetActive(false);
			}
			return;
		}
		if (this.\u02BE\u02BA\u02BD\u02B5\u02BE\u02C0\u02B7\u02B3\u02BA\u02B4\u02BD != PlayerSelectionMenu.\u02C1\u02C1\u02B7\u02BD\u02BC\u02B7\u02C0\u02B3\u02BE\u02B7\u02BB.Modifiers)
		{
			return;
		}
		int num2 = this.\u02BB\u02B3\u02C0\u02BC\u02BF\u02BD\u02B9\u02B2\u02BC\u02BE\u02B7;
		for (int l = 0; l < this.\u02C0\u02B8\u02B3\u02B7\u02B3\u02BA\u02BB\u02B4\u02B4\u02BF\u02B5; l++)
		{
			string text;
			if (num2 == 0)
			{
				this.modifierEnabledIcons[l].enabled = false;
				text = LanguageManager.instance.GetString("Ready");
			}
			else
			{
				Modifier modifier = (this.\u02B6\u02B9\u02B7\u02B6\u02B9\u02B2\u02BE\u02BE\u02BE\u02B2\u02B5 ? this.\u02BF\u02BE\u02B7\u02B6\u02BA\u02B2\u02B6\u02B7\u02BF\u02B3\u02BD[num2 - 1] : this.\u02C0\u02C1\u02B8\u02B4\u02B4\u02B6\u02B6\u02BF\u02B2\u02BF\u02BA[num2 - 1]);
				text = LanguageManager.instance.GetString(PlayerSelectionMenu.\u02BF\u02C0\u02B5\u02B6\u02B6\u02B3\u02BD\u02B6\u02B3\u02B7\u02B4(modifier, this.\u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF));
				this.modifierEnabledIcons[l].enabled = this.controllingPlayer.playerProfile.HasModifier(modifier);
			}
			this.modifierTexts[l].text = text;
			num2++;
		}
	}

	private void \u02B5\u02B3\u02BD\u02B5\u02B4\u02BF\u02B7\u02BE\u02C1\u02B7\u02B7()
	{
		bool flag = this.\u02BA\u02B4\u02B8\u02BA\u02C1\u02B7\u02BF\u02BD\u02B5\u02BE\u02BA.charts.\u02B3\u02B2\u02B6\u02BA\u02B2\u02BC\u02C0\u02BA\u02B9\u02BE\u02B8(this.\u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF, this.\u02B5\u02BD\u02C0\u02C1\u02BF\u02BF\u02B7\u02BF\u02B6\u02C1\u02BA);
		this.\u02B8\u02B2\u02C0\u02B6\u02B2\u02B2\u02BB\u02B5\u02B4\u02B8\u02BD = false;
		this.\u02BB\u02BE\u02B6\u02BC\u02B6\u02B4\u02BC\u02B7\u02C1\u02B7\u02B8 = false;
		this.buttonsGroup.SetActive(true);
		if (!flag)
		{
			this.headerDifficultyIcon.gameObject.SetActive(false);
			this.difficultyHeaderText.rectTransform.localPosition = new Vector2(0f, 230f);
			this.difficultyHeaderText.text = LanguageManager.instance.GetString("No Part");
			this.difficultyHeaderText.alignment = TextAlignmentOptions.Midline;
			this.notSupported.text = LanguageManager.instance.GetString("playernotsupported");
			this.controllingPlayer.playerProfile.\u02BE\u02B5\u02BD\u02B3\u02B3\u02C1\u02BC\u02BC\u02BE\u02B6\u02B7(Instrument.None, Difficulty.Expert);
		}
		else
		{
			this.difficultyHeaderText.text = LanguageManager.instance.GetString(this.\u02B5\u02BD\u02C0\u02C1\u02BF\u02BF\u02B7\u02BF\u02B6\u02C1\u02BA.ToString());
			this.difficultyHeaderText.rectTransform.localPosition = new Vector2(80f, 230f);
			this.difficultyHeaderText.alignment = TextAlignmentOptions.Left;
			this.headerDifficultyIcon.\u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF = this.\u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF;
			this.headerDifficultyIcon.\u02B8\u02BF\u02B2\u02C1\u02B4\u02BE\u02C1\u02B4\u02BB\u02B3\u02BC((int)this.\u02BA\u02B4\u02B8\u02BA\u02C1\u02B7\u02BF\u02BD\u02B5\u02BE\u02BA.\u02BF\u02B5\u02BD\u02B2\u02B5\u02BE\u02B5\u02B8\u02B4\u02BF\u02BC(this.\u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF), true, false);
			this.headerDifficultyIcon.gameObject.SetActive(true);
			if ((this.controllingPlayer.playerProfile.noteModifier & (Modifier.DrunkMode | Modifier.AutoStrum)) > Modifier.Unknown)
			{
				this.notSupported.text = LanguageManager.instance.GetString("ScoreDisabledModifier");
			}
			else
			{
				this.notSupported.text = "";
			}
		}
		this.confirmTexts[0].text = LanguageManager.instance.GetString("Ready");
		this.confirmTexts[1].text = LanguageManager.instance.GetString("Instrument");
		this.confirmTexts[2].text = LanguageManager.instance.GetString("Difficulty");
		this.confirmTexts[3].text = LanguageManager.instance.GetString("Modifiers");
		this.modifierGroup.\u02C1\u02BD\u02B6\u02B4\u02B9\u02B9\u02B9\u02B7\u02BC\u02BD\u02B9 = 77f;
		this.\u02C0\u02B8\u02B3\u02B7\u02B3\u02BA\u02BB\u02B4\u02B4\u02BF\u02B5 = 4;
	}

	private void \u02B3\u02C1\u02B5\u02BD\u02B5\u02C1\u02BB\u02B5\u02C0\u02BF\u02B6()
	{
		string text = this.\u02B8\u02BE\u02C1\u02BE\u02B2\u02C0\u02B6\u02C0\u02B5\u02B8\u02B5[this.\u02B3\u02BF\u02BB\u02BB\u02B5\u02B7\u02B8\u02BE\u02B7\u02B3\u02B3];
		if (!(text == "Expert"))
		{
			if (!(text == "Hard"))
			{
				if (!(text == "Medium"))
				{
					if (!(text == "Easy"))
					{
						if (text == "Change Instrument")
						{
							this.\u02B8\u02B2\u02C0\u02B6\u02B2\u02B2\u02BB\u02B5\u02B4\u02B8\u02BD = true;
							this.\u02BE\u02B7\u02B2\u02B3\u02B5\u02B7\u02B7\u02B9\u02B3\u02BF\u02BC(PlayerSelectionMenu.\u02C1\u02C1\u02B7\u02BD\u02BC\u02B7\u02C0\u02B3\u02BE\u02B7\u02BB.Instrument);
							return;
						}
					}
					else
					{
						this.\u02B5\u02BD\u02C0\u02C1\u02BF\u02BF\u02B7\u02BF\u02B6\u02C1\u02BA = Difficulty.Easy;
					}
				}
				else
				{
					this.\u02B5\u02BD\u02C0\u02C1\u02BF\u02BF\u02B7\u02BF\u02B6\u02C1\u02BA = Difficulty.Medium;
				}
			}
			else
			{
				this.\u02B5\u02BD\u02C0\u02C1\u02BF\u02BF\u02B7\u02BF\u02B6\u02C1\u02BA = Difficulty.Hard;
			}
		}
		else
		{
			this.\u02B5\u02BD\u02C0\u02C1\u02BF\u02BF\u02B7\u02BF\u02B6\u02C1\u02BA = Difficulty.Expert;
		}
		this.controllingPlayer.playerProfile.\u02BF\u02B8\u02BD\u02BA\u02BE\u02BD\u02B4\u02BB\u02BC\u02B2\u02BE = this.\u02B5\u02BD\u02C0\u02C1\u02BF\u02BF\u02B7\u02BF\u02B6\u02C1\u02BA;
		this.\u02BE\u02B7\u02B2\u02B3\u02B5\u02B7\u02B7\u02B9\u02B3\u02BF\u02BC(this.\u02BB\u02BE\u02B6\u02BC\u02B6\u02B4\u02BC\u02B7\u02C1\u02B7\u02B8 ? PlayerSelectionMenu.\u02C1\u02C1\u02B7\u02BD\u02BC\u02B7\u02C0\u02B3\u02BE\u02B7\u02BB.Modifiers : PlayerSelectionMenu.\u02C1\u02C1\u02B7\u02BD\u02BC\u02B7\u02C0\u02B3\u02BE\u02B7\u02BB.Confirm);
	}

	private void \u02BE\u02B9\u02BC\u02BA\u02B3\u02BD\u02C1\u02B5\u02B3\u02C1\u02C0()
	{
		this.buttonsGroup.SetActive(this.\u02BE\u02BA\u02BD\u02B5\u02BE\u02C0\u02B7\u02B3\u02BA\u02B4\u02BD != PlayerSelectionMenu.\u02C1\u02C1\u02B7\u02BD\u02BC\u02B7\u02C0\u02B3\u02BE\u02B7\u02BB.Ready);
		this.ReadyHeader.SetActive(this.\u02BE\u02BA\u02BD\u02B5\u02BE\u02C0\u02B7\u02B3\u02BA\u02B4\u02BD == PlayerSelectionMenu.\u02C1\u02C1\u02B7\u02BD\u02BC\u02B7\u02C0\u02B3\u02BE\u02B7\u02BB.Ready);
	}

	private void \u02B3\u02BC\u02BA\u02C0\u02B3\u02B6\u02B3\u02B7\u02B8\u02B5\u02B4(int \u02BD\u02BA\u02C0\u02BC\u02B6\u02B4\u02B5\u02BD\u02B4\u02C0\u02B8)
	{
		foreach (ModifierFlowElement modifierFlowElement in this.modifierElements)
		{
			if (!modifierFlowElement.gameObject.activeSelf)
			{
				modifierFlowElement.\u02B8\u02C0\u02B3\u02B2\u02B3\u02B7\u02C0\u02BE\u02C1\u02B4\u02B6(\u02BD\u02BA\u02C0\u02BC\u02B6\u02B4\u02B5\u02BD\u02B4\u02C0\u02B8, this.\u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF);
				return;
			}
		}
	}

	private void \u02B9\u02BB\u02BD\u02B7\u02C0\u02BF\u02C0\u02BF\u02B8\u02C1\u02BC()
	{
		string text = this.\u02B8\u02BE\u02C1\u02BE\u02B2\u02C0\u02B6\u02C0\u02B5\u02B8\u02B5[base.\u02BF\u02B6\u02B5\u02BF\u02BD\u02BF\u02B4\u02B3\u02B8\u02BE\u02BC];
		uint num = PrivateImplementationDetails.ComputeStringHash(text);
		if (num <= 1934333424U)
		{
			if (num <= 1613443821U)
			{
				if (num != 5829013U)
				{
					if (num != 1422873973U)
					{
						if (num == 1613443821U)
						{
							if (text == "Keys")
							{
								this.\u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF = Instrument.Keys;
							}
						}
					}
					else if (text == "Rhythm Guitar")
					{
						this.\u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF = Instrument.Rhythm;
					}
				}
				else if (text == "6 Fret Bass Guitar")
				{
					this.\u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF = Instrument.GHLBass;
				}
			}
			else if (num != 1647809847U)
			{
				if (num != 1859600033U)
				{
					if (num == 1934333424U)
					{
						if (text == "Guitar Coop")
						{
							this.\u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF = Instrument.GuitarCoop;
						}
					}
				}
				else if (text == "Pro Drums")
				{
					this.\u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF = Instrument.ProDrums;
				}
			}
			else if (text == "Lead Guitar")
			{
				this.\u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF = Instrument.Guitar;
			}
		}
		else if (num <= 2242673754U)
		{
			if (num != 2024374535U)
			{
				if (num != 2027408576U)
				{
					if (num == 2242673754U)
					{
						if (text == "Drums")
						{
							this.\u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF = Instrument.Drums;
						}
					}
				}
				else if (text == "Bass Guitar")
				{
					this.\u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF = Instrument.Bass;
				}
			}
			else if (text == "No Part")
			{
				this.\u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF = Instrument.None;
			}
		}
		else if (num != 2274653628U)
		{
			if (num != 2590799002U)
			{
				if (num == 3964368817U)
				{
					if (text == "6 Fret Guitar Coop")
					{
						this.\u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF = Instrument.GHLGuitarCoop;
					}
				}
			}
			else if (text == "6 Fret Lead Guitar")
			{
				this.\u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF = Instrument.GHLGuitar;
			}
		}
		else if (text == "6 Fret Rhythm Guitar")
		{
			this.\u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF = Instrument.GHLRhythm;
		}
		this.\u02B6\u02B9\u02B7\u02B6\u02B9\u02B2\u02BE\u02BE\u02BE\u02B2\u02B5 = this.\u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF == Instrument.Drums || this.\u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF == Instrument.ProDrums;
		this.controllingPlayer.playerProfile.\u02B9\u02BC\u02BA\u02BD\u02B7\u02B9\u02B9\u02BE\u02B6\u02C1\u02B9 = this.\u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF;
		if (this.\u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF == Instrument.None)
		{
			this.\u02B8\u02B2\u02C0\u02B6\u02B2\u02B2\u02BB\u02B5\u02B4\u02B8\u02BD = false;
			this.\u02BB\u02BE\u02B6\u02BC\u02B6\u02B4\u02BC\u02B7\u02C1\u02B7\u02B8 = false;
		}
		this.\u02BE\u02B7\u02B2\u02B3\u02B5\u02B7\u02B7\u02B9\u02B3\u02BF\u02BC(this.\u02B8\u02B2\u02C0\u02B6\u02B2\u02B2\u02BB\u02B5\u02B4\u02B8\u02BD ? PlayerSelectionMenu.\u02C1\u02C1\u02B7\u02BD\u02BC\u02B7\u02C0\u02B3\u02BE\u02B7\u02BB.Difficulty : PlayerSelectionMenu.\u02C1\u02C1\u02B7\u02BD\u02BC\u02B7\u02C0\u02B3\u02BE\u02B7\u02BB.Confirm);
	}

	public override void \u02C1\u02B3\u02BC\u02B6\u02BD\u02B6\u02BF\u02B7\u02BB\u02B5\u02BB()
	{
		if (this.\u02BE\u02BA\u02BD\u02B5\u02BE\u02C0\u02B7\u02B3\u02BA\u02B4\u02BD == PlayerSelectionMenu.\u02C1\u02C1\u02B7\u02BD\u02BC\u02B7\u02C0\u02B3\u02BE\u02B7\u02BB.Ready)
		{
			return;
		}
		base.\u02C1\u02B3\u02BC\u02B6\u02BD\u02B6\u02BF\u02B7\u02BB\u02B5\u02BB();
		if (this.\u02BC\u02BE\u02C1\u02B8\u02BE\u02C1\u02BE\u02BF\u02BC\u02BC\u02BA)
		{
			\u02B3\u02B7\u02B4\u02BE\u02BE\u02C1\u02BE\u02BB\u02B2\u02B9\u02BA.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BF\u02B9\u02C0\u02BF\u02BA\u02BA\u02B2\u02BA\u02B8\u02B5\u02BC(2);
		}
	}

	private int \u02B2\u02BC\u02B3\u02BD\u02B4\u02B6\u02B4\u02BA\u02BF\u02BF\u02C0(Difficulty \u02B5\u02BD\u02C0\u02C1\u02BF\u02BF\u02B7\u02BF\u02B6\u02C1\u02BA)
	{
		string text = \u02B5\u02BD\u02C0\u02C1\u02BF\u02BF\u02B7\u02BF\u02B6\u02C1\u02BA.ToString();
		for (int i = 0; i < this.difficultyTexts.Length; i++)
		{
			if (this.difficultyTexts[i].text == text)
			{
				return i;
			}
		}
		return 0;
	}

	private void \u02C0\u02BE\u02BC\u02B3\u02B8\u02B4\u02C0\u02B3\u02B9\u02BA\u02BA()
	{
		this.\u02B8\u02B2\u02C0\u02B6\u02B2\u02B2\u02BB\u02B5\u02B4\u02B8\u02BD = false;
		if (this.\u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF != Instrument.None)
		{
			if (this.\u02BA\u02B4\u02B8\u02BA\u02C1\u02B7\u02BF\u02BD\u02B5\u02BE\u02BA.charts.\u02B3\u02B2\u02B6\u02BA\u02B2\u02BC\u02C0\u02BA\u02B9\u02BE\u02B8(this.\u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF, Difficulty.Expert))
			{
				this.\u02BF\u02B5\u02B3\u02BC\u02B5\u02BC\u02BD\u02C1\u02B2\u02C0\u02B6("Expert");
			}
			if (this.\u02BA\u02B4\u02B8\u02BA\u02C1\u02B7\u02BF\u02BD\u02B5\u02BE\u02BA.charts.\u02B3\u02B2\u02B6\u02BA\u02B2\u02BC\u02C0\u02BA\u02B9\u02BE\u02B8(this.\u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF, Difficulty.Hard))
			{
				this.\u02BF\u02B5\u02B3\u02BC\u02B5\u02BC\u02BD\u02C1\u02B2\u02C0\u02B6("Hard");
			}
			if (this.\u02BA\u02B4\u02B8\u02BA\u02C1\u02B7\u02BF\u02BD\u02B5\u02BE\u02BA.charts.\u02B3\u02B2\u02B6\u02BA\u02B2\u02BC\u02C0\u02BA\u02B9\u02BE\u02B8(this.\u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF, Difficulty.Medium))
			{
				this.\u02BF\u02B5\u02B3\u02BC\u02B5\u02BC\u02BD\u02C1\u02B2\u02C0\u02B6("Medium");
			}
			if (this.\u02BA\u02B4\u02B8\u02BA\u02C1\u02B7\u02BF\u02BD\u02B5\u02BE\u02BA.charts.\u02B3\u02B2\u02B6\u02BA\u02B2\u02BC\u02C0\u02BA\u02B9\u02BE\u02B8(this.\u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF, Difficulty.Easy))
			{
				this.\u02BF\u02B5\u02B3\u02BC\u02B5\u02BC\u02BD\u02C1\u02B2\u02C0\u02B6("Easy");
			}
		}
		if ((int)this.controllingPlayer.playerProfile.difficulty <= this.\u02C0\u02B8\u02B3\u02B7\u02B3\u02BA\u02BB\u02B4\u02B4\u02BF\u02B5)
		{
			this.\u02B5\u02B6\u02B8\u02BC\u02BF\u02BF\u02BC\u02B5\u02C0\u02BB\u02C0(this.\u02B2\u02BC\u02B3\u02BD\u02B4\u02B6\u02B4\u02BA\u02BF\u02BF\u02C0(this.controllingPlayer.playerProfile.difficulty), true);
		}
		for (int i = this.\u02C0\u02B8\u02B3\u02B7\u02B3\u02BA\u02BB\u02B4\u02B4\u02BF\u02B5; i < this.difficultyTexts.Length; i++)
		{
			this.difficultyTexts[i].text = string.Empty;
		}
		if (this.\u02C0\u02B8\u02B3\u02B7\u02B3\u02BA\u02BB\u02B4\u02B4\u02BF\u02B5 == 0)
		{
			this.\u02BF\u02B5\u02B3\u02BC\u02B5\u02BC\u02BD\u02C1\u02B2\u02C0\u02B6("Change Instrument");
			this.\u02BF\u02B5\u02B3\u02BC\u02B5\u02BC\u02BD\u02C1\u02B2\u02C0\u02B6("Go Back");
			this.noDifficultyText.text = LanguageManager.instance.GetString("nodifficulty");
			return;
		}
		this.noDifficultyText.text = string.Empty;
	}

	private void \u02BA\u02C1\u02B7\u02B8\u02C0\u02BF\u02BF\u02B2\u02B5\u02C1\u02B8(string \u02BF\u02B4\u02C1\u02BC\u02BC\u02B2\u02BC\u02BB\u02BA\u02B2\u02B6)
	{
		this.difficultyTexts[this.\u02C0\u02B8\u02B3\u02B7\u02B3\u02BA\u02BB\u02B4\u02B4\u02BF\u02B5].text = LanguageManager.instance.\u02B9\u02BC\u02BD\u02BE\u02BA\u02C0\u02BC\u02C1\u02BD\u02B3\u02BD(\u02BF\u02B4\u02C1\u02BC\u02BC\u02B2\u02BC\u02BB\u02BA\u02B2\u02B6);
		string[] u02B8_u02BE_u02C1_u02BE_u02B2_u02C0_u02B6_u02C0_u02B5_u02B8_u02B = this.\u02B8\u02BE\u02C1\u02BE\u02B2\u02C0\u02B6\u02C0\u02B5\u02B8\u02B5;
		int u02C0_u02B8_u02B3_u02B7_u02B3_u02BA_u02BB_u02B4_u02B4_u02BF_u02B = this.\u02C0\u02B8\u02B3\u02B7\u02B3\u02BA\u02BB\u02B4\u02B4\u02BF\u02B5;
		this.\u02C0\u02B8\u02B3\u02B7\u02B3\u02BA\u02BB\u02B4\u02B4\u02BF\u02B5 = u02C0_u02B8_u02B3_u02B7_u02B3_u02BA_u02BB_u02B4_u02B4_u02BF_u02B + 1;
		u02B8_u02BE_u02C1_u02BE_u02B2_u02C0_u02B6_u02C0_u02B5_u02B8_u02B[u02C0_u02B8_u02B3_u02B7_u02B3_u02BA_u02BB_u02B4_u02B4_u02BF_u02B] = \u02BF\u02B4\u02C1\u02BC\u02BC\u02B2\u02BC\u02BB\u02BA\u02B2\u02B6;
	}

	private void \u02B6\u02BD\u02BF\u02C1\u02B5\u02BD\u02B2\u02B2\u02C1\u02B7\u02BD()
	{
		this.\u02B8\u02B2\u02C0\u02B6\u02B2\u02B2\u02BB\u02B5\u02B4\u02B8\u02BD = true;
		if (this.\u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF != Instrument.None)
		{
			if (this.\u02BA\u02B4\u02B8\u02BA\u02C1\u02B7\u02BF\u02BD\u02B5\u02BE\u02BA.charts.\u02B3\u02B2\u02B6\u02BA\u02B2\u02BC\u02C0\u02BA\u02B9\u02BE\u02B8(this.\u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF, Difficulty.Medium))
			{
				this.\u02BF\u02B5\u02B3\u02BC\u02B5\u02BC\u02BD\u02C1\u02B2\u02C0\u02B6("Lead Guitar");
			}
			if (this.\u02BA\u02B4\u02B8\u02BA\u02C1\u02B7\u02BF\u02BD\u02B5\u02BE\u02BA.charts.\u02B3\u02B2\u02B6\u02BA\u02B2\u02BC\u02C0\u02BA\u02B9\u02BE\u02B8(this.\u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF, (Difficulty)7))
			{
				this.\u02BA\u02C1\u02B7\u02B8\u02C0\u02BF\u02BF\u02B2\u02B5\u02C1\u02B8("OK");
			}
			if (this.\u02BA\u02B4\u02B8\u02BA\u02C1\u02B7\u02BF\u02BD\u02B5\u02BE\u02BA.charts.\u02B3\u02B2\u02B6\u02BA\u02B2\u02BC\u02C0\u02BA\u02B9\u02BE\u02B8(this.\u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF, Difficulty.Medium))
			{
				this.\u02BA\u02C1\u02B7\u02B8\u02C0\u02BF\u02BF\u02B2\u02B5\u02C1\u02B8("hasProDrums");
			}
			if (this.\u02BA\u02B4\u02B8\u02BA\u02C1\u02B7\u02BF\u02BD\u02B5\u02BE\u02BA.charts.\u02B3\u02B2\u02B6\u02BA\u02B2\u02BC\u02C0\u02BA\u02B9\u02BE\u02B8(this.\u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF, Difficulty.Medium))
			{
				this.\u02BF\u02B5\u02B3\u02BC\u02B5\u02BC\u02BD\u02C1\u02B2\u02C0\u02B6("GameColors_");
			}
		}
		if ((int)this.controllingPlayer.playerProfile.difficulty <= this.\u02C0\u02B8\u02B3\u02B7\u02B3\u02BA\u02BB\u02B4\u02B4\u02BF\u02B5)
		{
			this.\u02B5\u02B6\u02B8\u02BC\u02BF\u02BF\u02BC\u02B5\u02C0\u02BB\u02C0(this.\u02B2\u02BC\u02B3\u02BD\u02B4\u02B6\u02B4\u02BA\u02BF\u02BF\u02C0(this.controllingPlayer.playerProfile.difficulty), true);
		}
		for (int i = this.\u02C0\u02B8\u02B3\u02B7\u02B3\u02BA\u02BB\u02B4\u02B4\u02BF\u02B5; i < this.difficultyTexts.Length; i += 0)
		{
			this.difficultyTexts[i].text = string.Empty;
		}
		if (this.\u02C0\u02B8\u02B3\u02B7\u02B3\u02BA\u02BB\u02B4\u02B4\u02BF\u02B5 == 0)
		{
			this.\u02BF\u02B5\u02B3\u02BC\u02B5\u02BC\u02BD\u02C1\u02B2\u02C0\u02B6("Tom1");
			this.\u02BF\u02B5\u02B3\u02BC\u02B5\u02BC\u02BD\u02C1\u02B2\u02C0\u02B6("Songs Per Player");
			this.noDifficultyText.text = LanguageManager.\u02BE\u02C0\u02B6\u02B9\u02B7\u02BE\u02B9\u02B6\u02B9\u02BF\u02B2().GetString("Hit Percent");
			return;
		}
		this.noDifficultyText.text = string.Empty;
	}

	public override void \u02B7\u02BA\u02C0\u02B8\u02BE\u02BA\u02BD\u02B4\u02BB\u02B3\u02B6()
	{
		if (this.\u02BE\u02BA\u02BD\u02B5\u02BE\u02C0\u02B7\u02B3\u02BA\u02B4\u02BD == PlayerSelectionMenu.\u02C1\u02C1\u02B7\u02BD\u02BC\u02B7\u02C0\u02B3\u02BE\u02B7\u02BB.Ready)
		{
			return;
		}
		base.\u02B7\u02BA\u02C0\u02B8\u02BE\u02BA\u02BD\u02B4\u02BB\u02B3\u02B6();
		if (this.\u02BC\u02BE\u02C1\u02B8\u02BE\u02C1\u02BE\u02BF\u02BC\u02BC\u02BA)
		{
			\u02B3\u02B7\u02B4\u02BE\u02BE\u02C1\u02BE\u02BB\u02B2\u02B9\u02BA.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BF\u02B9\u02C0\u02BF\u02BA\u02BA\u02B2\u02BA\u02B8\u02B5\u02BC(3);
		}
	}

	private void \u02BE\u02B7\u02B2\u02B3\u02B5\u02B7\u02B7\u02B9\u02B3\u02BF\u02BC(PlayerSelectionMenu.\u02C1\u02C1\u02B7\u02BD\u02BC\u02B7\u02C0\u02B3\u02BE\u02B7\u02BB \u02BA\u02B2\u02B9\u02BD\u02BA\u02B4\u02B5\u02BB\u02BB\u02BC\u02C1)
	{
		this.\u02B7\u02BE\u02B6\u02B6\u02BF\u02BE\u02B6\u02B2\u02C1\u02B4\u02B8(false);
		this.\u02BE\u02BA\u02BD\u02B5\u02BE\u02C0\u02B7\u02B3\u02BA\u02B4\u02BD = \u02BA\u02B2\u02B9\u02BD\u02BA\u02B4\u02B5\u02BB\u02BB\u02BC\u02C1;
		this.\u02B7\u02BE\u02B6\u02B6\u02BF\u02BE\u02B6\u02B2\u02C1\u02B4\u02B8(true);
		this.\u02BB\u02B3\u02C0\u02BC\u02BF\u02BD\u02B9\u02B2\u02BC\u02BE\u02B7 = 0;
		this.\u02B6\u02B9\u02B6\u02B4\u02BF\u02B4\u02C1\u02BF\u02BC\u02B8\u02B6 = 0;
		this.\u02B3\u02BF\u02BB\u02BB\u02B5\u02B7\u02B8\u02BE\u02B7\u02B3\u02B3 = 0;
		this.\u02C0\u02B8\u02B3\u02B7\u02B3\u02BA\u02BB\u02B4\u02B4\u02BF\u02B5 = 0;
		this.\u02BF\u02B7\u02BF\u02BF\u02B4\u02B2\u02BF\u02B7\u02BA\u02BA\u02B2();
		switch (this.\u02BE\u02BA\u02BD\u02B5\u02BE\u02C0\u02B7\u02B3\u02BA\u02B4\u02BD)
		{
		case PlayerSelectionMenu.\u02C1\u02C1\u02B7\u02BD\u02BC\u02B7\u02C0\u02B3\u02BE\u02B7\u02BB.Confirm:
			this.\u02B5\u02B3\u02BD\u02B5\u02B4\u02BF\u02B7\u02BE\u02C1\u02B7\u02B7();
			break;
		case PlayerSelectionMenu.\u02C1\u02C1\u02B7\u02BD\u02BC\u02B7\u02C0\u02B3\u02BE\u02B7\u02BB.Instrument:
			this.\u02B7\u02BA\u02C0\u02B9\u02B2\u02C1\u02BB\u02BD\u02BC\u02BA\u02BE();
			break;
		case PlayerSelectionMenu.\u02C1\u02C1\u02B7\u02BD\u02BC\u02B7\u02C0\u02B3\u02BE\u02B7\u02BB.Difficulty:
			this.\u02C0\u02BE\u02BC\u02B3\u02B8\u02B4\u02C0\u02B3\u02B9\u02BA\u02BA();
			break;
		case PlayerSelectionMenu.\u02C1\u02C1\u02B7\u02BD\u02BC\u02B7\u02C0\u02B3\u02BE\u02B7\u02BB.Modifiers:
			this.\u02B7\u02B8\u02C1\u02B3\u02BF\u02C0\u02C1\u02B2\u02BF\u02BF\u02B7();
			break;
		}
		this.\u02B9\u02B8\u02C0\u02B7\u02BA\u02B3\u02BB\u02C0\u02B3\u02C1\u02B8();
	}

	public static string \u02BF\u02C0\u02B5\u02B6\u02B6\u02B3\u02BD\u02B6\u02B3\u02B7\u02B4(Modifier \u02BD\u02BA\u02C0\u02BC\u02B6\u02B4\u02B5\u02BD\u02B4\u02C0\u02B8, Instrument \u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF)
	{
		if (\u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF == Instrument.Drums || \u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF == Instrument.ProDrums)
		{
			if (\u02BD\u02BA\u02C0\u02BC\u02B6\u02B4\u02B5\u02BD\u02B4\u02C0\u02B8 <= Modifier.AllHOPOs)
			{
				if (\u02BD\u02BA\u02C0\u02BC\u02B6\u02B4\u02B5\u02BD\u02B4\u02C0\u02B8 == Modifier.AllStrums)
				{
					return "2x Kick";
				}
				if (\u02BD\u02BA\u02C0\u02BC\u02B6\u02B4\u02B5\u02BD\u02B4\u02C0\u02B8 == Modifier.AllHOPOs)
				{
					return "No Kick";
				}
			}
			else
			{
				if (\u02BD\u02BA\u02C0\u02BC\u02B6\u02B4\u02B5\u02BD\u02B4\u02C0\u02B8 == Modifier.AllTaps)
				{
					return "All Kicks";
				}
				if (\u02BD\u02BA\u02C0\u02BC\u02B6\u02B4\u02B5\u02BD\u02B4\u02C0\u02B8 == Modifier.AllOpens)
				{
					return "Deadly Dynamics";
				}
			}
		}
		if (\u02BD\u02BA\u02C0\u02BC\u02B6\u02B4\u02B5\u02BD\u02B4\u02C0\u02B8 <= Modifier.ModLite)
		{
			if (\u02BD\u02BA\u02C0\u02BC\u02B6\u02B4\u02B5\u02BD\u02B4\u02C0\u02B8 <= Modifier.Shuffle)
			{
				if (\u02BD\u02BA\u02C0\u02BC\u02B6\u02B4\u02B5\u02BD\u02B4\u02C0\u02B8 <= Modifier.AllOpens)
				{
					switch (\u02BD\u02BA\u02C0\u02BC\u02B6\u02B4\u02B5\u02BD\u02B4\u02C0\u02B8)
					{
					case Modifier.Unknown:
						return "Gamepad Mode";
					case Modifier.None:
						return "No Modifiers";
					case Modifier.AllStrums:
						return "All Strums";
					case Modifier.None | Modifier.AllStrums:
					case Modifier.None | Modifier.AllHOPOs:
					case Modifier.AllStrums | Modifier.AllHOPOs:
					case Modifier.None | Modifier.AllStrums | Modifier.AllHOPOs:
						break;
					case Modifier.AllHOPOs:
						return "All HOPOs";
					case Modifier.AllTaps:
						return "All Taps";
					default:
						if (\u02BD\u02BA\u02C0\u02BC\u02B6\u02B4\u02B5\u02BD\u02B4\u02C0\u02B8 == Modifier.AllOpens)
						{
							return "All Opens";
						}
						break;
					}
				}
				else
				{
					if (\u02BD\u02BA\u02C0\u02BC\u02B6\u02B4\u02B5\u02BD\u02B4\u02C0\u02B8 == Modifier.MirrorMode)
					{
						return "Mirror Mode";
					}
					if (\u02BD\u02BA\u02C0\u02BC\u02B6\u02B4\u02B5\u02BD\u02B4\u02C0\u02B8 == Modifier.Shuffle)
					{
						return "Note Shuffle";
					}
				}
			}
			else if (\u02BD\u02BA\u02C0\u02BC\u02B6\u02B4\u02B5\u02BD\u02B4\u02C0\u02B8 <= Modifier.LightsOut)
			{
				if (\u02BD\u02BA\u02C0\u02BC\u02B6\u02B4\u02B5\u02BD\u02B4\u02C0\u02B8 == Modifier.HOPOsToTaps)
				{
					return "HOPOs To Taps";
				}
				if (\u02BD\u02BA\u02C0\u02BC\u02B6\u02B4\u02B5\u02BD\u02B4\u02C0\u02B8 == Modifier.LightsOut)
				{
					return "Lights Out";
				}
			}
			else
			{
				if (\u02BD\u02BA\u02C0\u02BC\u02B6\u02B4\u02B5\u02BD\u02B4\u02C0\u02B8 == Modifier.ModFull)
				{
					return "ModChart Full";
				}
				if (\u02BD\u02BA\u02C0\u02BC\u02B6\u02B4\u02B5\u02BD\u02B4\u02C0\u02B8 == Modifier.ModLite)
				{
					return "ModChart Lite";
				}
			}
		}
		else if (\u02BD\u02BA\u02C0\u02BC\u02B6\u02B4\u02B5\u02BD\u02B4\u02C0\u02B8 <= Modifier.AutoStrum)
		{
			if (\u02BD\u02BA\u02C0\u02BC\u02B6\u02B4\u02B5\u02BD\u02B4\u02C0\u02B8 <= Modifier.PrecisionMode)
			{
				if (\u02BD\u02BA\u02C0\u02BC\u02B6\u02B4\u02B5\u02BD\u02B4\u02C0\u02B8 == Modifier.ModPrep)
				{
					return "ModChart Prep";
				}
				if (\u02BD\u02BA\u02C0\u02BC\u02B6\u02B4\u02B5\u02BD\u02B4\u02C0\u02B8 == Modifier.PrecisionMode)
				{
					return "Precision Mode";
				}
			}
			else
			{
				if (\u02BD\u02BA\u02C0\u02BC\u02B6\u02B4\u02B5\u02BD\u02B4\u02C0\u02B8 == Modifier.DrunkMode)
				{
					return "Drunk Mode";
				}
				if (\u02BD\u02BA\u02C0\u02BC\u02B6\u02B4\u02B5\u02BD\u02B4\u02C0\u02B8 == Modifier.AutoStrum)
				{
					return "Auto Strum";
				}
			}
		}
		else if (\u02BD\u02BA\u02C0\u02BC\u02B6\u02B4\u02B5\u02BD\u02B4\u02C0\u02B8 <= Modifier.DroplessSustains)
		{
			if (\u02BD\u02BA\u02C0\u02BC\u02B6\u02B4\u02B5\u02BD\u02B4\u02C0\u02B8 == Modifier.BrutalMode)
			{
				return "Brutal Mode";
			}
			if (\u02BD\u02BA\u02C0\u02BC\u02B6\u02B4\u02B5\u02BD\u02B4\u02C0\u02B8 == Modifier.DroplessSustains)
			{
				return "Dropless Sustains";
			}
		}
		else
		{
			if (\u02BD\u02BA\u02C0\u02BC\u02B6\u02B4\u02B5\u02BD\u02B4\u02C0\u02B8 == Modifier.StrumlessHopos)
			{
				return "Strumless HOPOs";
			}
			if (\u02BD\u02BA\u02C0\u02BC\u02B6\u02B4\u02B5\u02BD\u02B4\u02C0\u02B8 == Modifier.DoubleNotes)
			{
				return "Double Notes";
			}
			if (\u02BD\u02BA\u02C0\u02BC\u02B6\u02B4\u02B5\u02BD\u02B4\u02C0\u02B8 == Modifier.NoFretGhosting)
			{
				return "No Ghosting";
			}
		}
		return "Unknown";
	}

	private void \u02B3\u02B4\u02BE\u02B2\u02B7\u02BE\u02B7\u02B5\u02B9\u02B6\u02BB()
	{
		string text = this.\u02B8\u02BE\u02C1\u02BE\u02B2\u02C0\u02B6\u02C0\u02B5\u02B8\u02B5[this.\u02B3\u02BF\u02BB\u02BB\u02B5\u02B7\u02B8\u02BE\u02B7\u02B3\u02B3];
		if (!(text == "gh3_sudden_death"))
		{
			if (!(text == "6 Fret Bass Guitar"))
			{
				if (!(text == "_uElectricityColor"))
				{
					if (!(text == "Current Section:"))
					{
						if (text == "Pause on Focus Lost")
						{
							this.\u02B8\u02B2\u02C0\u02B6\u02B2\u02B2\u02BB\u02B5\u02B4\u02B8\u02BD = true;
							this.\u02B6\u02B3\u02B9\u02B5\u02BE\u02C0\u02B3\u02C1\u02B9\u02B3\u02BA(PlayerSelectionMenu.\u02C1\u02C1\u02B7\u02BD\u02BC\u02B7\u02C0\u02B3\u02BE\u02B7\u02BB.Instrument);
							return;
						}
					}
					else
					{
						this.\u02B5\u02BD\u02C0\u02C1\u02BF\u02BF\u02B7\u02BF\u02B6\u02C1\u02BA = Difficulty.Medium;
					}
				}
				else
				{
					this.\u02B5\u02BD\u02C0\u02C1\u02BF\u02BF\u02B7\u02BF\u02B6\u02C1\u02BA = Difficulty.Medium;
				}
			}
			else
			{
				this.\u02B5\u02BD\u02C0\u02C1\u02BF\u02BF\u02B7\u02BF\u02B6\u02C1\u02BA = (Difficulty)8;
			}
		}
		else
		{
			this.\u02B5\u02BD\u02C0\u02C1\u02BF\u02BF\u02B7\u02BF\u02B6\u02C1\u02BA = Difficulty.Hard;
		}
		this.controllingPlayer.playerProfile.\u02BF\u02B8\u02BD\u02BA\u02BE\u02BD\u02B4\u02BB\u02BC\u02B2\u02BE = this.\u02B5\u02BD\u02C0\u02C1\u02BF\u02BF\u02B7\u02BF\u02B6\u02C1\u02BA;
		this.\u02BE\u02B7\u02B2\u02B3\u02B5\u02B7\u02B7\u02B9\u02B3\u02BF\u02BC(this.\u02BB\u02BE\u02B6\u02BC\u02B6\u02B4\u02BC\u02B7\u02C1\u02B7\u02B8 ? PlayerSelectionMenu.\u02C1\u02C1\u02B7\u02BD\u02BC\u02B7\u02C0\u02B3\u02BE\u02B7\u02BB.Difficulty : PlayerSelectionMenu.\u02C1\u02C1\u02B7\u02BD\u02BC\u02B7\u02C0\u02B3\u02BE\u02B7\u02BB.Instrument);
	}

	protected virtual void \u02B8\u02B2\u02BB\u02BF\u02BF\u02BF\u02C0\u02BE\u02BD\u02B9\u02B8()
	{
		if (!GlobalVariables.instance.playerList[this.\u02BE\u02BB\u02B5\u02B7\u02B9\u02B2\u02B6\u02BF\u02B9\u02B7\u02B7].\u02BC\u02BA\u02BE\u02B2\u02C0\u02BE\u02B6\u02B5\u02BC\u02B3\u02BD || GlobalVariables.instance.playerList[this.\u02BE\u02BB\u02B5\u02B7\u02B9\u02B2\u02B6\u02BF\u02B9\u02B7\u02B7].playerProfile == null)
		{
			base.gameObject.SetActive(false);
			return;
		}
		base.OnEnable();
		base.\u02B8\u02BE\u02BD\u02BB\u02B2\u02B6\u02B3\u02BB\u02BB\u02C0\u02B8(GlobalVariables.instance.playerList[this.\u02BE\u02BB\u02B5\u02B7\u02B9\u02B2\u02B6\u02BF\u02B9\u02B7\u02B7]);
		this.playerName.text = (this.controllingPlayer.\u02C0\u02B5\u02B2\u02B2\u02BB\u02B8\u02B8\u02BD\u02B9\u02BD\u02C1() ? ("video" + this.controllingPlayer.playerProfile.playerName.CurrentValueNoTags + "hasMedium") : this.controllingPlayer.playerProfile.playerName.CurrentValue);
		if (this.controllingPlayer.\u02B8\u02C0\u02BB\u02C0\u02BB\u02BB\u02BE\u02B3\u02BD\u02B2\u02B6())
		{
			this.playerName.color = Color.green;
		}
		else if (this.controllingPlayer.\u02C0\u02B5\u02B2\u02B2\u02BB\u02B8\u02B8\u02BD\u02B9\u02BD\u02C1())
		{
			this.playerName.color = Color.cyan;
		}
		else
		{
			this.playerName.color = Color.white;
		}
		this.\u02B6\u02B2\u02BF\u02B9\u02B9\u02BD\u02B8\u02BF\u02B4\u02B6\u02B7 = this.controllingPlayer.\u02BF\u02B2\u02B3\u02BC\u02BA\u02B6\u02B7\u02BE\u02BB\u02B9\u02C1();
		this.\u02B5\u02B4\u02B4\u02BC\u02B4\u02BC\u02B3\u02BD\u02B9\u02BC\u02C0 = this.controllingPlayer.playerProfile.IsGamepadMode();
		if (this.controllingPlayer.playerProfile.instrument == Instrument.None)
		{
			this.controllingPlayer.playerProfile.instrument = \u02B9\u02BA\u02BF\u02BB\u02B2\u02B9\u02BB\u02B9\u02B9\u02B5\u02B8.\u02B2\u02BE\u02B4\u02BC\u02B4\u02B5\u02BE\u02B6\u02B8\u02B9\u02B2(this.\u02B6\u02B2\u02BF\u02B9\u02B9\u02BD\u02B8\u02BF\u02B4\u02B6\u02B7);
		}
		this.\u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF = this.controllingPlayer.playerProfile.instrument;
		this.\u02B5\u02BD\u02C0\u02C1\u02BF\u02BF\u02B7\u02BF\u02B6\u02C1\u02BA = this.controllingPlayer.playerProfile.difficulty;
		this.\u02C1\u02B3\u02BE\u02B4\u02C0\u02BC\u02BD\u02C1\u02B4\u02C0\u02BC = SceneManager.GetActiveScene().name == "Audio Latency" && GlobalVariables.instance.\u02B7\u02B7\u02B9\u02B6\u02B6\u02B8\u02C1\u02BA\u02BA\u02C0\u02B8;
		this.\u02BC\u02BE\u02C1\u02B8\u02BE\u02C1\u02BE\u02BF\u02BC\u02BC\u02BA = CHNetManager.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02C1\u02BB\u02B7\u02B6\u02B9\u02B5\u02BC\u02B2\u02BB\u02B2\u02BD() && this.\u02BE\u02BB\u02B5\u02B7\u02B9\u02B2\u02B6\u02BF\u02B9\u02B7\u02B7 == \u02B3\u02B7\u02B4\u02BE\u02BE\u02C1\u02BE\u02BB\u02B2\u02B9\u02BA.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B8\u02B3\u02B2\u02BA\u02BD\u02B6\u02BF\u02BA\u02C1\u02BA\u02B9;
		this.\u02B6\u02B9\u02B7\u02B6\u02B9\u02B2\u02BE\u02BE\u02BE\u02B2\u02B5 = this.controllingPlayer.playerProfile.IsAnyDrumsController;
		this.\u02B5\u02B2\u02B4\u02B8\u02B6\u02BF\u02B4\u02B4\u02B9\u02BB\u02BC();
		this.headerTexts[1].text = LanguageManager.\u02BE\u02C0\u02B6\u02B9\u02B7\u02BE\u02B9\u02B6\u02B9\u02BF\u02B2().GetString("Please wait while we prepare some files.");
		this.headerTexts[0].text = LanguageManager.\u02BE\u02C0\u02B6\u02B9\u02B7\u02BE\u02B9\u02B6\u02B9\u02BF\u02B2().GetString("SongPath ");
		this.headerTexts[4].text = LanguageManager.\u02B2\u02BE\u02BA\u02B7\u02B4\u02BA\u02BD\u02BE\u02B7\u02B8\u02BE().\u02B9\u02BC\u02BD\u02BE\u02BA\u02C0\u02BC\u02C1\u02BD\u02B3\u02BD("");
		this.headerTexts[5].text = LanguageManager.\u02BE\u02C0\u02B6\u02B9\u02B7\u02BE\u02B9\u02B6\u02B9\u02BF\u02B2().\u02BB\u02B9\u02BB\u02B8\u02B3\u02B2\u02B5\u02B6\u02B4\u02B2\u02B4("vocals");
		if (this.\u02C1\u02B3\u02BE\u02B4\u02C0\u02BC\u02BD\u02C1\u02B4\u02C0\u02BC)
		{
			this.\u02BA\u02B4\u02B8\u02BA\u02C1\u02B7\u02BF\u02BD\u02B5\u02BE\u02BA = \u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02B4\u02BE\u02B5\u02B6\u02BB\u02B4\u02B6\u02B9\u02B5\u02B7\u02BD[GlobalVariables.instance.\u02B5\u02B8\u02B8\u02B6\u02BC\u02BC\u02B6\u02BA\u02B7\u02BE\u02B7 + 0];
		}
		else
		{
			this.\u02BA\u02B4\u02B8\u02BA\u02C1\u02B7\u02BF\u02BD\u02B5\u02BE\u02BA = GlobalVariables.instance.\u02BA\u02B9\u02BD\u02BA\u02B4\u02B4\u02BF\u02BD\u02B8\u02B3\u02C1;
		}
		if (!this.controllingPlayer.playerProfile.selectedInstrumentForSession)
		{
			this.\u02B6\u02B3\u02B9\u02B5\u02BE\u02C0\u02B3\u02C1\u02B9\u02B3\u02BA(PlayerSelectionMenu.\u02C1\u02C1\u02B7\u02BD\u02BC\u02B7\u02C0\u02B3\u02BE\u02B7\u02BB.Instrument);
			this.\u02B8\u02B2\u02C0\u02B6\u02B2\u02B2\u02BB\u02B5\u02B4\u02B8\u02BD = false;
			this.\u02BB\u02BE\u02B6\u02BC\u02B6\u02B4\u02BC\u02B7\u02C1\u02B7\u02B8 = false;
			this.controllingPlayer.playerProfile.selectedInstrumentForSession = false;
		}
		else
		{
			this.\u02BE\u02B7\u02B2\u02B3\u02B5\u02B7\u02B7\u02B9\u02B3\u02BF\u02BC(PlayerSelectionMenu.\u02C1\u02C1\u02B7\u02BD\u02BC\u02B7\u02C0\u02B3\u02BE\u02B7\u02BB.Instrument);
		}
		this.ReadyHeader.SetActive(true);
		this.ReadyText.text = LanguageManager.instance.\u02B5\u02BA\u02BE\u02B9\u02BD\u02B3\u02BB\u02B6\u02B8\u02BD\u02C0("' not found");
	}

	private void \u02B7\u02BE\u02B6\u02B6\u02BF\u02BE\u02B6\u02B2\u02C1\u02B4\u02B8(bool \u02B8\u02B2\u02B7\u02BB\u02BA\u02C0\u02BF\u02C1\u02B2\u02B6\u02BC)
	{
		GameObject[] array;
		switch (this.\u02BE\u02BA\u02BD\u02B5\u02BE\u02C0\u02B7\u02B3\u02BA\u02B4\u02BD)
		{
		case PlayerSelectionMenu.\u02C1\u02C1\u02B7\u02BD\u02BC\u02B7\u02C0\u02B3\u02BE\u02B7\u02BB.Confirm:
			array = this.confirmPageObjects;
			break;
		case PlayerSelectionMenu.\u02C1\u02C1\u02B7\u02BD\u02BC\u02B7\u02C0\u02B3\u02BE\u02B7\u02BB.Instrument:
			array = this.instrumentPageObjects;
			break;
		case PlayerSelectionMenu.\u02C1\u02C1\u02B7\u02BD\u02BC\u02B7\u02C0\u02B3\u02BE\u02B7\u02BB.Difficulty:
			array = this.difficultyPageObjects;
			break;
		case PlayerSelectionMenu.\u02C1\u02C1\u02B7\u02BD\u02BC\u02B7\u02C0\u02B3\u02BE\u02B7\u02BB.Modifiers:
			array = this.modifierPageObjects;
			break;
		case PlayerSelectionMenu.\u02C1\u02C1\u02B7\u02BD\u02BC\u02B7\u02C0\u02B3\u02BE\u02B7\u02BB.Ready:
			array = this.confirmPageObjects;
			break;
		default:
			array = null;
			break;
		}
		GameObject[] array2 = array;
		if (array2 == null)
		{
			return;
		}
		array = array2;
		for (int i = 0; i < array.Length; i++)
		{
			array[i].SetActive(\u02B8\u02B2\u02B7\u02BB\u02BA\u02C0\u02BF\u02C1\u02B2\u02B6\u02BC);
		}
	}

	private void \u02B7\u02BA\u02C0\u02B9\u02B2\u02C1\u02BB\u02BD\u02BC\u02BA\u02BE()
	{
		DifficultyDisplay[] array = this.difficultyIcons;
		for (int i = 0; i < array.Length; i++)
		{
			array[i].gameObject.SetActive(false);
		}
		this.\u02B4\u02B2\u02B7\u02B2\u02BF\u02BD\u02B7\u02BB\u02BB\u02BD\u02B8 = 0;
		switch (this.\u02B6\u02B2\u02BF\u02B9\u02B9\u02BD\u02B8\u02BF\u02B4\u02B6\u02B7)
		{
		case ControllerType.Guitar:
			this.\u02C1\u02B4\u02B8\u02B3\u02B3\u02BF\u02B8\u02B7\u02BB\u02B2\u02BE("Lead Guitar", this.\u02BA\u02B4\u02B8\u02BA\u02C1\u02B7\u02BF\u02BD\u02B5\u02BE\u02BA.GuitarIntensity, Instrument.Guitar);
			this.\u02C1\u02B4\u02B8\u02B3\u02B3\u02BF\u02B8\u02B7\u02BB\u02B2\u02BE("Bass Guitar", this.\u02BA\u02B4\u02B8\u02BA\u02C1\u02B7\u02BF\u02BD\u02B5\u02BE\u02BA.BassIntensity, Instrument.Bass);
			this.\u02C1\u02B4\u02B8\u02B3\u02B3\u02BF\u02B8\u02B7\u02BB\u02B2\u02BE("Rhythm Guitar", this.\u02BA\u02B4\u02B8\u02BA\u02C1\u02B7\u02BF\u02BD\u02B5\u02BE\u02BA.RhythmIntensity, Instrument.Rhythm);
			this.\u02C1\u02B4\u02B8\u02B3\u02B3\u02BF\u02B8\u02B7\u02BB\u02B2\u02BE("Guitar Coop", this.\u02BA\u02B4\u02B8\u02BA\u02C1\u02B7\u02BF\u02BD\u02B5\u02BE\u02BA.GuitarCoopIntensity, Instrument.GuitarCoop);
			this.\u02C1\u02B4\u02B8\u02B3\u02B3\u02BF\u02B8\u02B7\u02BB\u02B2\u02BE("Keys", this.\u02BA\u02B4\u02B8\u02BA\u02C1\u02B7\u02BF\u02BD\u02B5\u02BE\u02BA.KeysIntensity, Instrument.Keys);
			break;
		case ControllerType.GHLGuitar:
			this.\u02C1\u02B4\u02B8\u02B3\u02B3\u02BF\u02B8\u02B7\u02BB\u02B2\u02BE("6 Fret Lead Guitar", this.\u02BA\u02B4\u02B8\u02BA\u02C1\u02B7\u02BF\u02BD\u02B5\u02BE\u02BA.GHLGuitarIntensity, Instrument.GHLGuitar);
			this.\u02C1\u02B4\u02B8\u02B3\u02B3\u02BF\u02B8\u02B7\u02BB\u02B2\u02BE("6 Fret Bass Guitar", this.\u02BA\u02B4\u02B8\u02BA\u02C1\u02B7\u02BF\u02BD\u02B5\u02BE\u02BA.GHLBassIntensity, Instrument.GHLBass);
			this.\u02C1\u02B4\u02B8\u02B3\u02B3\u02BF\u02B8\u02B7\u02BB\u02B2\u02BE("6 Fret Guitar Coop", this.\u02BA\u02B4\u02B8\u02BA\u02C1\u02B7\u02BF\u02BD\u02B5\u02BE\u02BA.GHLGuitarCoopIntensity, Instrument.GHLGuitarCoop);
			this.\u02C1\u02B4\u02B8\u02B3\u02B3\u02BF\u02B8\u02B7\u02BB\u02B2\u02BE("6 Fret Rhythm Guitar", this.\u02BA\u02B4\u02B8\u02BA\u02C1\u02B7\u02BF\u02BD\u02B5\u02BE\u02BA.GHLRhythmIntensity, Instrument.GHLRhythm);
			this.\u02C1\u02B4\u02B8\u02B3\u02B3\u02BF\u02B8\u02B7\u02BB\u02B2\u02BE("Lead Guitar", this.\u02BA\u02B4\u02B8\u02BA\u02C1\u02B7\u02BF\u02BD\u02B5\u02BE\u02BA.GuitarIntensity, Instrument.Guitar);
			this.\u02C1\u02B4\u02B8\u02B3\u02B3\u02BF\u02B8\u02B7\u02BB\u02B2\u02BE("Bass Guitar", this.\u02BA\u02B4\u02B8\u02BA\u02C1\u02B7\u02BF\u02BD\u02B5\u02BE\u02BA.BassIntensity, Instrument.Bass);
			this.\u02C1\u02B4\u02B8\u02B3\u02B3\u02BF\u02B8\u02B7\u02BB\u02B2\u02BE("Rhythm Guitar", this.\u02BA\u02B4\u02B8\u02BA\u02C1\u02B7\u02BF\u02BD\u02B5\u02BE\u02BA.RhythmIntensity, Instrument.Rhythm);
			this.\u02C1\u02B4\u02B8\u02B3\u02B3\u02BF\u02B8\u02B7\u02BB\u02B2\u02BE("Guitar Coop", this.\u02BA\u02B4\u02B8\u02BA\u02C1\u02B7\u02BF\u02BD\u02B5\u02BE\u02BA.GuitarCoopIntensity, Instrument.GuitarCoop);
			this.\u02C1\u02B4\u02B8\u02B3\u02B3\u02BF\u02B8\u02B7\u02BB\u02B2\u02BE("Keys", this.\u02BA\u02B4\u02B8\u02BA\u02C1\u02B7\u02BF\u02BD\u02B5\u02BE\u02BA.KeysIntensity, Instrument.Keys);
			break;
		case ControllerType.Drums:
		case ControllerType.FiveLaneDrums:
			this.\u02C1\u02B4\u02B8\u02B3\u02B3\u02BF\u02B8\u02B7\u02BB\u02B2\u02BE("Pro Drums", this.\u02BA\u02B4\u02B8\u02BA\u02C1\u02B7\u02BF\u02BD\u02B5\u02BE\u02BA.ProDrumsIntensity, Instrument.ProDrums);
			this.\u02C1\u02B4\u02B8\u02B3\u02B3\u02BF\u02B8\u02B7\u02BB\u02B2\u02BE("Drums", this.\u02BA\u02B4\u02B8\u02BA\u02C1\u02B7\u02BF\u02BD\u02B5\u02BE\u02BA.DrumsIntensity, Instrument.Drums);
			break;
		}
		if (this.\u02B4\u02B2\u02B7\u02B2\u02BF\u02BD\u02B7\u02BB\u02BB\u02BD\u02B8 == 0)
		{
			this.\u02C1\u02B4\u02B8\u02B3\u02B3\u02BF\u02B8\u02B7\u02BB\u02B2\u02BE("No Part", 0, Instrument.None);
		}
		this.\u02C0\u02B8\u02B3\u02B7\u02B3\u02BA\u02BB\u02B4\u02B4\u02BF\u02B5 = Numerics.Clamp<int>(this.\u02B4\u02B2\u02B7\u02B2\u02BF\u02BD\u02B7\u02BB\u02BB\u02BD\u02B8, 0, this.instrumentTexts.Length);
		this.\u02B6\u02B9\u02B6\u02B4\u02BF\u02B4\u02C1\u02BF\u02BC\u02B8\u02B6 = Numerics.Clamp<int>(this.\u02B4\u02B2\u02B7\u02B2\u02BF\u02BD\u02B7\u02BB\u02BB\u02BD\u02B8 - this.instrumentTexts.Length, 0, int.MaxValue);
	}

	private void \u02C1\u02B4\u02B8\u02B3\u02B3\u02BF\u02B8\u02B7\u02BB\u02B2\u02BE(string \u02BF\u02B4\u02C1\u02BC\u02BC\u02B2\u02BC\u02BB\u02BA\u02B2\u02B6, sbyte \u02B5\u02BD\u02C0\u02C1\u02BF\u02BF\u02B7\u02BF\u02B6\u02C1\u02BA, Instrument \u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF)
	{
		if (\u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF != Instrument.None && !this.\u02BA\u02B4\u02B8\u02BA\u02C1\u02B7\u02BF\u02BD\u02B5\u02BE\u02BA.charts.\u02BF\u02BB\u02C0\u02BB\u02B2\u02B6\u02B5\u02B8\u02B8\u02B2\u02BB(\u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF))
		{
			return;
		}
		this.\u02B8\u02BE\u02C1\u02BE\u02B2\u02C0\u02B6\u02C0\u02B5\u02B8\u02B5[this.\u02B4\u02B2\u02B7\u02B2\u02BF\u02BD\u02B7\u02BB\u02BB\u02BD\u02B8] = \u02BF\u02B4\u02C1\u02BC\u02BC\u02B2\u02BC\u02BB\u02BA\u02B2\u02B6;
		this.\u02BF\u02B6\u02BE\u02C1\u02C1\u02B9\u02BA\u02B5\u02BB\u02B3\u02BD[this.\u02B4\u02B2\u02B7\u02B2\u02BF\u02BD\u02B7\u02BB\u02BB\u02BD\u02B8] = (int)\u02B5\u02BD\u02C0\u02C1\u02BF\u02BF\u02B7\u02BF\u02B6\u02C1\u02BA;
		this.\u02C1\u02B6\u02C1\u02B2\u02B3\u02BE\u02BD\u02BF\u02B8\u02BF\u02C0[this.\u02B4\u02B2\u02B7\u02B2\u02BF\u02BD\u02B7\u02BB\u02BB\u02BD\u02B8] = \u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF;
		this.\u02B4\u02B2\u02B7\u02B2\u02BF\u02BD\u02B7\u02BB\u02BB\u02BD\u02B8++;
	}

	private void \u02B3\u02B8\u02C0\u02B9\u02B6\u02B7\u02B8\u02BD\u02B8\u02BA\u02B3()
	{
		switch (this.\u02B3\u02BF\u02BB\u02BB\u02B5\u02B7\u02B8\u02BE\u02B7\u02B3\u02B3)
		{
		case 0:
			if (this.\u02BC\u02BE\u02C1\u02B8\u02BE\u02C1\u02BE\u02BF\u02BC\u02BC\u02BA || !CHNetManager.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02C1\u02BB\u02B7\u02B6\u02B9\u02B5\u02BC\u02B2\u02BB\u02B2\u02BD())
			{
				if (!this.\u02BA\u02B4\u02B8\u02BA\u02C1\u02B7\u02BF\u02BD\u02B5\u02BE\u02BA.charts.\u02B3\u02B2\u02B6\u02BA\u02B2\u02BC\u02C0\u02BA\u02B9\u02BE\u02B8(this.\u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF, this.\u02B5\u02BD\u02C0\u02C1\u02BF\u02BF\u02B7\u02BF\u02B6\u02C1\u02BA))
				{
					this.controllingPlayer.playerProfile.\u02BA\u02BD\u02BF\u02C1\u02B3\u02B9\u02B6\u02B7\u02BD\u02C1\u02BC(Instrument.None, Difficulty.Hard);
				}
				else
				{
					this.controllingPlayer.playerProfile.\u02B6\u02C0\u02BE\u02BE\u02BE\u02C0\u02B2\u02BA\u02BC\u02BF\u02BD(this.\u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF, this.\u02B5\u02BD\u02C0\u02C1\u02BF\u02BF\u02B7\u02BF\u02B6\u02C1\u02BA);
				}
			}
			this.\u02BA\u02B5\u02B2\u02BF\u02B4\u02C1\u02BC\u02B3\u02BA\u02B8\u02C0();
			return;
		case 1:
			this.\u02B3\u02B2\u02BF\u02C1\u02B5\u02B4\u02BF\u02C1\u02BA\u02B5\u02BE = false;
			this.\u02B6\u02B3\u02B9\u02B5\u02BE\u02C0\u02B3\u02C1\u02B9\u02B3\u02BA(PlayerSelectionMenu.\u02C1\u02C1\u02B7\u02BD\u02BC\u02B7\u02C0\u02B3\u02BE\u02B7\u02BB.Instrument);
			this.\u02B9\u02B8\u02C0\u02B7\u02BA\u02B3\u02BB\u02C0\u02B3\u02C1\u02B8();
			return;
		case 2:
			this.\u02B6\u02B3\u02B9\u02B5\u02BE\u02C0\u02B3\u02C1\u02B9\u02B3\u02BA((PlayerSelectionMenu.\u02C1\u02C1\u02B7\u02BD\u02BC\u02B7\u02C0\u02B3\u02BE\u02B7\u02BB)6);
			return;
		case 3:
			this.\u02BE\u02B7\u02B2\u02B3\u02B5\u02B7\u02B7\u02B9\u02B3\u02BF\u02BC(PlayerSelectionMenu.\u02C1\u02C1\u02B7\u02BD\u02BC\u02B7\u02C0\u02B3\u02BE\u02B7\u02BB.Confirm);
			return;
		default:
			return;
		}
	}

	private void \u02B4\u02BB\u02B4\u02BC\u02BB\u02B7\u02BC\u02BA\u02BF\u02BF\u02B6()
	{
		bool flag = this.\u02BA\u02B4\u02B8\u02BA\u02C1\u02B7\u02BF\u02BD\u02B5\u02BE\u02BA.charts.\u02B3\u02B2\u02B6\u02BA\u02B2\u02BC\u02C0\u02BA\u02B9\u02BE\u02B8(this.\u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF, this.\u02B5\u02BD\u02C0\u02C1\u02BF\u02BF\u02B7\u02BF\u02B6\u02C1\u02BA);
		this.\u02B8\u02B2\u02C0\u02B6\u02B2\u02B2\u02BB\u02B5\u02B4\u02B8\u02BD = true;
		this.\u02BB\u02BE\u02B6\u02BC\u02B6\u02B4\u02BC\u02B7\u02C1\u02B7\u02B8 = false;
		this.buttonsGroup.SetActive(false);
		if (!flag)
		{
			this.headerDifficultyIcon.gameObject.SetActive(false);
			this.difficultyHeaderText.rectTransform.localPosition = new Vector2(599f, 210f);
			this.difficultyHeaderText.text = LanguageManager.\u02BA\u02B9\u02C1\u02B9\u02B2\u02BD\u02B2\u02BC\u02B7\u02BA\u02B8().GetString("Note Animation FPS");
			this.difficultyHeaderText.alignment = (TextAlignmentOptions)141;
			this.notSupported.text = LanguageManager.\u02B2\u02BE\u02BA\u02B7\u02B4\u02BA\u02BD\u02BE\u02B7\u02B8\u02BE().\u02B5\u02BA\u02BE\u02B9\u02BD\u02B3\u02BB\u02B6\u02B8\u02BD\u02C0("-force-d3d11");
			this.controllingPlayer.playerProfile.\u02BA\u02BD\u02BF\u02C1\u02B3\u02B9\u02B6\u02B7\u02BD\u02C1\u02BC(Instrument.None, (Difficulty)7);
		}
		else
		{
			this.difficultyHeaderText.text = LanguageManager.instance.GetString(this.\u02B5\u02BD\u02C0\u02C1\u02BF\u02BF\u02B7\u02BF\u02B6\u02C1\u02BA.ToString());
			this.difficultyHeaderText.rectTransform.localPosition = new Vector2(1802f, 1843f);
			this.difficultyHeaderText.alignment = (TextAlignmentOptions)(-63);
			this.headerDifficultyIcon.\u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF = this.\u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF;
			this.headerDifficultyIcon.\u02B3\u02BB\u02B3\u02B8\u02B2\u02B8\u02B8\u02B6\u02BA\u02B7\u02BE((int)this.\u02BA\u02B4\u02B8\u02BA\u02C1\u02B7\u02BF\u02BD\u02B5\u02BE\u02BA.\u02BF\u02B5\u02BD\u02B2\u02B5\u02BE\u02B5\u02B8\u02B4\u02BF\u02BC(this.\u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF), false, false);
			this.headerDifficultyIcon.gameObject.SetActive(true);
			if ((this.controllingPlayer.playerProfile.noteModifier & ~Modifier.AllHOPOs) > Modifier.Unknown)
			{
				this.notSupported.text = LanguageManager.instance.GetString("songcache.bin");
			}
			else
			{
				this.notSupported.text = "Settings";
			}
		}
		this.confirmTexts[0].text = LanguageManager.instance.\u02B5\u02BA\u02BE\u02B9\u02BD\u02B3\u02BB\u02B6\u02B8\u02BD\u02C0("write! {0}");
		this.confirmTexts[0].text = LanguageManager.instance.\u02B9\u02BC\u02BD\u02BE\u02BA\u02C0\u02BC\u02C1\u02BD\u02B3\u02BD("Guest");
		this.confirmTexts[2].text = LanguageManager.\u02BA\u02B9\u02C1\u02B9\u02B2\u02BD\u02B2\u02BC\u02B7\u02BA\u02B8().GetString("soloend");
		this.confirmTexts[6].text = LanguageManager.\u02B2\u02BE\u02BA\u02B7\u02B4\u02BA\u02BD\u02BE\u02B7\u02B8\u02BE().\u02BB\u02B9\u02BB\u02B8\u02B3\u02B2\u02B5\u02B6\u02B4\u02B2\u02B4("Double Notes");
		this.modifierGroup.\u02C1\u02BD\u02B6\u02B4\u02B9\u02B9\u02B9\u02B7\u02BC\u02BD\u02B9 = 503f;
		this.\u02C0\u02B8\u02B3\u02B7\u02B3\u02BA\u02BB\u02B4\u02B4\u02BF\u02B5 = 6;
	}

	private void \u02B6\u02B3\u02B9\u02B5\u02BE\u02C0\u02B3\u02C1\u02B9\u02B3\u02BA(PlayerSelectionMenu.\u02C1\u02C1\u02B7\u02BD\u02BC\u02B7\u02C0\u02B3\u02BE\u02B7\u02BB \u02BA\u02B2\u02B9\u02BD\u02BA\u02B4\u02B5\u02BB\u02BB\u02BC\u02C1)
	{
		this.\u02B7\u02BE\u02B6\u02B6\u02BF\u02BE\u02B6\u02B2\u02C1\u02B4\u02B8(true);
		this.\u02BE\u02BA\u02BD\u02B5\u02BE\u02C0\u02B7\u02B3\u02BA\u02B4\u02BD = \u02BA\u02B2\u02B9\u02BD\u02BA\u02B4\u02B5\u02BB\u02BB\u02BC\u02C1;
		this.\u02B7\u02BE\u02B6\u02B6\u02BF\u02BE\u02B6\u02B2\u02C1\u02B4\u02B8(false);
		this.\u02BB\u02B3\u02C0\u02BC\u02BF\u02BD\u02B9\u02B2\u02BC\u02BE\u02B7 = 1;
		this.\u02B6\u02B9\u02B6\u02B4\u02BF\u02B4\u02C1\u02BF\u02BC\u02B8\u02B6 = 1;
		this.\u02B3\u02BF\u02BB\u02BB\u02B5\u02B7\u02B8\u02BE\u02B7\u02B3\u02B3 = 0;
		this.\u02C0\u02B8\u02B3\u02B7\u02B3\u02BA\u02BB\u02B4\u02B4\u02BF\u02B5 = 1;
		this.\u02BF\u02B7\u02BF\u02BF\u02B4\u02B2\u02BF\u02B7\u02BA\u02BA\u02B2();
		switch (this.\u02BE\u02BA\u02BD\u02B5\u02BE\u02C0\u02B7\u02B3\u02BA\u02B4\u02BD)
		{
		case PlayerSelectionMenu.\u02C1\u02C1\u02B7\u02BD\u02BC\u02B7\u02C0\u02B3\u02BE\u02B7\u02BB.Confirm:
			this.\u02B4\u02BB\u02B4\u02BC\u02BB\u02B7\u02BC\u02BA\u02BF\u02BF\u02B6();
			break;
		case PlayerSelectionMenu.\u02C1\u02C1\u02B7\u02BD\u02BC\u02B7\u02C0\u02B3\u02BE\u02B7\u02BB.Instrument:
			this.\u02BA\u02BA\u02B4\u02BC\u02BE\u02B9\u02BF\u02B4\u02BF\u02B6\u02B3();
			break;
		case PlayerSelectionMenu.\u02C1\u02C1\u02B7\u02BD\u02BC\u02B7\u02C0\u02B3\u02BE\u02B7\u02BB.Difficulty:
			this.\u02C0\u02BE\u02BC\u02B3\u02B8\u02B4\u02C0\u02B3\u02B9\u02BA\u02BA();
			break;
		case PlayerSelectionMenu.\u02C1\u02C1\u02B7\u02BD\u02BC\u02B7\u02C0\u02B3\u02BE\u02B7\u02BB.Modifiers:
			this.\u02B7\u02B8\u02C1\u02B3\u02BF\u02C0\u02C1\u02B2\u02BF\u02BF\u02B7();
			break;
		}
		this.\u02B9\u02B8\u02C0\u02B7\u02BA\u02B3\u02BB\u02C0\u02B3\u02C1\u02B8();
	}

	public override void \u02BA\u02BD\u02B3\u02BC\u02B8\u02BB\u02B8\u02BA\u02B5\u02C0\u02C0()
	{
	}

	private void \u02B5\u02B2\u02B4\u02B8\u02B6\u02BF\u02B4\u02B4\u02B9\u02BB\u02BC()
	{
		bool flag = !this.\u02B5\u02B4\u02B4\u02BC\u02B4\u02BC\u02B3\u02BD\u02B9\u02BC\u02C0 && this.controllingPlayer.playerProfile.noteModifier == Modifier.None;
		foreach (ModifierFlowElement modifierFlowElement in this.modifierElements)
		{
			if (modifierFlowElement.gameObject.activeSelf)
			{
				modifierFlowElement.gameObject.SetActive(false);
			}
		}
		if (this.\u02B5\u02B4\u02B4\u02BC\u02B4\u02BC\u02B3\u02BD\u02B9\u02BC\u02C0)
		{
			this.\u02B3\u02BC\u02BA\u02C0\u02B3\u02B6\u02B3\u02B7\u02B8\u02B5\u02B4(0);
		}
		Helper.UintPair this2 = Helper.NewUintPair((uint)this.controllingPlayer.playerProfile.noteModifier).GetThis();
		while (this2.MoreThanOneBitSet())
		{
			int num = (int)this2.xor;
			if (num != 1 || flag)
			{
				this.\u02B3\u02BC\u02BA\u02C0\u02B3\u02B6\u02B3\u02B7\u02B8\u02B5\u02B4(num);
			}
		}
	}

	private void \u02BE\u02B4\u02B8\u02B7\u02BA\u02BE\u02B3\u02BD\u02B6\u02B2\u02C1()
	{
		switch (this.\u02B3\u02BF\u02BB\u02BB\u02B5\u02B7\u02B8\u02BE\u02B7\u02B3\u02B3)
		{
		case 0:
			if (this.\u02BC\u02BE\u02C1\u02B8\u02BE\u02C1\u02BE\u02BF\u02BC\u02BC\u02BA || !CHNetManager.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B4\u02BA\u02B8\u02B6\u02BB\u02B5\u02B2\u02B8\u02B6\u02BB\u02BB)
			{
				if (!this.\u02BA\u02B4\u02B8\u02BA\u02C1\u02B7\u02BF\u02BD\u02B5\u02BE\u02BA.charts.\u02B3\u02B2\u02B6\u02BA\u02B2\u02BC\u02C0\u02BA\u02B9\u02BE\u02B8(this.\u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF, this.\u02B5\u02BD\u02C0\u02C1\u02BF\u02BF\u02B7\u02BF\u02B6\u02C1\u02BA))
				{
					this.controllingPlayer.playerProfile.\u02BE\u02B5\u02BD\u02B3\u02B3\u02C1\u02BC\u02BC\u02BE\u02B6\u02B7(Instrument.None, Difficulty.Expert);
				}
				else
				{
					this.controllingPlayer.playerProfile.\u02BE\u02B5\u02BD\u02B3\u02B3\u02C1\u02BC\u02BC\u02BE\u02B6\u02B7(this.\u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF, this.\u02B5\u02BD\u02C0\u02C1\u02BF\u02BF\u02B7\u02BF\u02B6\u02C1\u02BA);
				}
			}
			this.\u02BA\u02B5\u02B2\u02BF\u02B4\u02C1\u02BC\u02B3\u02BA\u02B8\u02C0();
			return;
		case 1:
			this.\u02B3\u02B2\u02BF\u02C1\u02B5\u02B4\u02BF\u02C1\u02BA\u02B5\u02BE = false;
			this.\u02BE\u02B7\u02B2\u02B3\u02B5\u02B7\u02B7\u02B9\u02B3\u02BF\u02BC(PlayerSelectionMenu.\u02C1\u02C1\u02B7\u02BD\u02BC\u02B7\u02C0\u02B3\u02BE\u02B7\u02BB.Instrument);
			this.\u02B9\u02B8\u02C0\u02B7\u02BA\u02B3\u02BB\u02C0\u02B3\u02C1\u02B8();
			return;
		case 2:
			this.\u02BE\u02B7\u02B2\u02B3\u02B5\u02B7\u02B7\u02B9\u02B3\u02BF\u02BC(PlayerSelectionMenu.\u02C1\u02C1\u02B7\u02BD\u02BC\u02B7\u02C0\u02B3\u02BE\u02B7\u02BB.Difficulty);
			return;
		case 3:
			this.\u02BE\u02B7\u02B2\u02B3\u02B5\u02B7\u02B7\u02B9\u02B3\u02BF\u02BC(PlayerSelectionMenu.\u02C1\u02C1\u02B7\u02BD\u02BC\u02B7\u02C0\u02B3\u02BE\u02B7\u02BB.Modifiers);
			return;
		default:
			return;
		}
	}

	private void \u02BA\u02BA\u02B4\u02BC\u02BE\u02B9\u02BF\u02B4\u02BF\u02B6\u02B3()
	{
		DifficultyDisplay[] array = this.difficultyIcons;
		for (int i = 1; i < array.Length; i += 0)
		{
			array[i].gameObject.SetActive(false);
		}
		this.\u02B4\u02B2\u02B7\u02B2\u02BF\u02BD\u02B7\u02BB\u02BB\u02BD\u02B8 = 0;
		switch (this.\u02B6\u02B2\u02BF\u02B9\u02B9\u02BD\u02B8\u02BF\u02B4\u02B6\u02B7)
		{
		case ControllerType.Guitar:
			this.\u02C1\u02B4\u02B8\u02B3\u02B3\u02BF\u02B8\u02B7\u02BB\u02B2\u02BE("You're\nLoser !", this.\u02BA\u02B4\u02B8\u02BA\u02C1\u02B7\u02BF\u02BD\u02B5\u02BE\u02BA.GuitarIntensity, Instrument.Bass);
			this.\u02C1\u02B4\u02B8\u02B3\u02B3\u02BF\u02B8\u02B7\u02BB\u02B2\u02BE("Game Manager", this.\u02BA\u02B4\u02B8\u02BA\u02C1\u02B7\u02BF\u02BD\u02B5\u02BE\u02BA.BassIntensity, Instrument.Bass);
			this.\u02C1\u02B4\u02B8\u02B3\u02B3\u02BF\u02B8\u02B7\u02BB\u02B2\u02BE("track", this.\u02BA\u02B4\u02B8\u02BA\u02C1\u02B7\u02BF\u02BD\u02B5\u02BE\u02BA.RhythmIntensity, Instrument.Rhythm);
			this.\u02C1\u02B4\u02B8\u02B3\u02B3\u02BF\u02B8\u02B7\u02BB\u02B2\u02BE("Get rid of it", this.\u02BA\u02B4\u02B8\u02BA\u02C1\u02B7\u02BF\u02BD\u02B5\u02BE\u02BA.GuitarCoopIntensity, Instrument.GHLBass);
			this.\u02C1\u02B4\u02B8\u02B3\u02B3\u02BF\u02B8\u02B7\u02BB\u02B2\u02BE("Cancel", this.\u02BA\u02B4\u02B8\u02BA\u02C1\u02B7\u02BF\u02BD\u02B5\u02BE\u02BA.KeysIntensity, Instrument.Guitar);
			break;
		case ControllerType.GHLGuitar:
			this.\u02C1\u02B4\u02B8\u02B3\u02B3\u02BF\u02B8\u02B7\u02BB\u02B2\u02BE("songName", this.\u02BA\u02B4\u02B8\u02BA\u02C1\u02B7\u02BF\u02BD\u02B5\u02BE\u02BA.GHLGuitarIntensity, Instrument.Bass);
			this.\u02C1\u02B4\u02B8\u02B3\u02B3\u02BF\u02B8\u02B7\u02BB\u02B2\u02BE("Queue {0} {1}", this.\u02BA\u02B4\u02B8\u02BA\u02C1\u02B7\u02BF\u02BD\u02B5\u02BE\u02BA.GHLBassIntensity, Instrument.Keys);
			this.\u02C1\u02B4\u02B8\u02B3\u02B3\u02BF\u02B8\u02B7\u02BB\u02B2\u02BE("", this.\u02BA\u02B4\u02B8\u02BA\u02C1\u02B7\u02BF\u02BD\u02B5\u02BE\u02BA.GHLGuitarCoopIntensity, (Instrument)(-115));
			this.\u02C1\u02B4\u02B8\u02B3\u02B3\u02BF\u02B8\u02B7\u02BB\u02B2\u02BE("Score", this.\u02BA\u02B4\u02B8\u02BA\u02C1\u02B7\u02BF\u02BD\u02B5\u02BE\u02BA.GHLRhythmIntensity, (Instrument)109);
			this.\u02C1\u02B4\u02B8\u02B3\u02B3\u02BF\u02B8\u02B7\u02BB\u02B2\u02BE("Whammy SFX", this.\u02BA\u02B4\u02B8\u02BA\u02C1\u02B7\u02BF\u02BD\u02B5\u02BE\u02BA.GuitarIntensity, Instrument.Bass);
			this.\u02C1\u02B4\u02B8\u02B3\u02B3\u02BF\u02B8\u02B7\u02BB\u02B2\u02BE("Audio Offset", this.\u02BA\u02B4\u02B8\u02BA\u02C1\u02B7\u02BF\u02BD\u02B5\u02BE\u02BA.BassIntensity, Instrument.Guitar);
			this.\u02C1\u02B4\u02B8\u02B3\u02B3\u02BF\u02B8\u02B7\u02BB\u02B2\u02BE("Language: '", this.\u02BA\u02B4\u02B8\u02BA\u02C1\u02B7\u02BF\u02BD\u02B5\u02BE\u02BA.RhythmIntensity, Instrument.Band);
			this.\u02C1\u02B4\u02B8\u02B3\u02B3\u02BF\u02B8\u02B7\u02BB\u02B2\u02BE("song", this.\u02BA\u02B4\u02B8\u02BA\u02C1\u02B7\u02BF\u02BD\u02B5\u02BE\u02BA.GuitarCoopIntensity, Instrument.Band);
			this.\u02C1\u02B4\u02B8\u02B3\u02B3\u02BF\u02B8\u02B7\u02BB\u02B2\u02BE("All HOPOs", this.\u02BA\u02B4\u02B8\u02BA\u02C1\u02B7\u02BF\u02BD\u02B5\u02BE\u02BA.\u02BD\u02B6\u02BB\u02B4\u02BF\u02B5\u02B7\u02B4\u02B6\u02BF\u02BF(), Instrument.Band);
			break;
		case ControllerType.Drums:
		case ControllerType.FiveLaneDrums:
			this.\u02C1\u02B4\u02B8\u02B3\u02B3\u02BF\u02B8\u02B7\u02BB\u02B2\u02BE("song", this.\u02BA\u02B4\u02B8\u02BA\u02C1\u02B7\u02BF\u02BD\u02B5\u02BE\u02BA.ProDrumsIntensity, (Instrument)40);
			this.\u02C1\u02B4\u02B8\u02B3\u02B3\u02BF\u02B8\u02B7\u02BB\u02B2\u02BE("FreestyleDrums", this.\u02BA\u02B4\u02B8\u02BA\u02C1\u02B7\u02BF\u02BD\u02B5\u02BE\u02BA.DrumsIntensity, Instrument.GHLGuitar);
			break;
		}
		if (this.\u02B4\u02B2\u02B7\u02B2\u02BF\u02BD\u02B7\u02BB\u02BB\u02BD\u02B8 == 0)
		{
			this.\u02C1\u02B4\u02B8\u02B3\u02B3\u02BF\u02B8\u02B7\u02BB\u02B2\u02BE("Show Accuracy", 1, Instrument.None);
		}
		this.\u02C0\u02B8\u02B3\u02B7\u02B3\u02BA\u02BB\u02B4\u02B4\u02BF\u02B5 = Numerics.Clamp<int>(this.\u02B4\u02B2\u02B7\u02B2\u02BF\u02BD\u02B7\u02BB\u02BB\u02BD\u02B8, 0, this.instrumentTexts.Length);
		this.\u02B6\u02B9\u02B6\u02B4\u02BF\u02B4\u02C1\u02BF\u02BC\u02B8\u02B6 = Numerics.Clamp<int>(this.\u02B4\u02B2\u02B7\u02B2\u02BF\u02BD\u02B7\u02BB\u02BB\u02BD\u02B8 - this.instrumentTexts.Length, 1, 81);
	}

	private void \u02C0\u02BD\u02C1\u02BC\u02BC\u02C1\u02C0\u02B3\u02B7\u02B8\u02B3()
	{
		int num = this.\u02BB\u02B3\u02C0\u02BC\u02BF\u02BD\u02B9\u02B2\u02BC\u02BE\u02B7 + this.\u02B3\u02BF\u02BB\u02BB\u02B5\u02B7\u02B8\u02BE\u02B7\u02B3\u02B3;
		if (num == 0)
		{
			this.\u02BE\u02B7\u02B2\u02B3\u02B5\u02B7\u02B7\u02B9\u02B3\u02BF\u02BC(PlayerSelectionMenu.\u02C1\u02C1\u02B7\u02BD\u02BC\u02B7\u02C0\u02B3\u02BE\u02B7\u02BB.Confirm);
			return;
		}
		num--;
		Modifier modifier = (this.\u02B6\u02B9\u02B7\u02B6\u02B9\u02B2\u02BE\u02BE\u02BE\u02B2\u02B5 ? this.\u02BF\u02BE\u02B7\u02B6\u02BA\u02B2\u02B6\u02B7\u02BF\u02B3\u02BD[num] : this.\u02C0\u02C1\u02B8\u02B4\u02B4\u02B6\u02B6\u02BF\u02B2\u02BF\u02BA[num]);
		this.controllingPlayer.playerProfile.ToggleModifier(modifier);
		this.\u02B5\u02B2\u02B4\u02B8\u02B6\u02BF\u02B4\u02B4\u02B9\u02BB\u02BC();
		this.\u02B9\u02B8\u02C0\u02B7\u02BA\u02B3\u02BB\u02C0\u02B3\u02C1\u02B8();
	}

	public override void \u02B3\u02BC\u02BA\u02C0\u02C0\u02B8\u02B2\u02B4\u02B3\u02C1\u02B8()
	{
		if (this.\u02BE\u02BA\u02BD\u02B5\u02BE\u02C0\u02B7\u02B3\u02BA\u02B4\u02BD == PlayerSelectionMenu.\u02C1\u02C1\u02B7\u02BD\u02BC\u02B7\u02C0\u02B3\u02BE\u02B7\u02BB.Ready && CHNetManager.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B4\u02BA\u02B8\u02B6\u02BB\u02B5\u02B2\u02B8\u02B6\u02BB\u02BB)
		{
			return;
		}
		base.\u02B3\u02BC\u02BA\u02C0\u02C0\u02B8\u02B2\u02B4\u02B3\u02C1\u02B8();
		switch (this.\u02BE\u02BA\u02BD\u02B5\u02BE\u02C0\u02B7\u02B3\u02BA\u02B4\u02BD)
		{
		case PlayerSelectionMenu.\u02C1\u02C1\u02B7\u02BD\u02BC\u02B7\u02C0\u02B3\u02BE\u02B7\u02BB.Confirm:
			if (CHNetManager.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B4\u02BA\u02B8\u02B6\u02BB\u02B5\u02B2\u02B8\u02B6\u02BB\u02BB || this.\u02C1\u02B3\u02BE\u02B4\u02C0\u02BC\u02BD\u02C1\u02B4\u02C0\u02BC)
			{
				return;
			}
			this.playerSelectionCanvas.\u02C0\u02B5\u02B9\u02BA\u02B3\u02C1\u02BC\u02B8\u02BB\u02BC\u02B6();
			break;
		case PlayerSelectionMenu.\u02C1\u02C1\u02B7\u02BD\u02BC\u02B7\u02C0\u02B3\u02BE\u02B7\u02BB.Instrument:
			if (!this.\u02B3\u02B2\u02BF\u02C1\u02B5\u02B4\u02BF\u02C1\u02BA\u02B5\u02BE)
			{
				this.\u02BE\u02B7\u02B2\u02B3\u02B5\u02B7\u02B7\u02B9\u02B3\u02BF\u02BC(PlayerSelectionMenu.\u02C1\u02C1\u02B7\u02BD\u02BC\u02B7\u02C0\u02B3\u02BE\u02B7\u02BB.Confirm);
			}
			break;
		case PlayerSelectionMenu.\u02C1\u02C1\u02B7\u02BD\u02BC\u02B7\u02C0\u02B3\u02BE\u02B7\u02BB.Difficulty:
		case PlayerSelectionMenu.\u02C1\u02C1\u02B7\u02BD\u02BC\u02B7\u02C0\u02B3\u02BE\u02B7\u02BB.Modifiers:
			this.\u02BE\u02B7\u02B2\u02B3\u02B5\u02B7\u02B7\u02B9\u02B3\u02BF\u02BC(PlayerSelectionMenu.\u02C1\u02C1\u02B7\u02BD\u02BC\u02B7\u02C0\u02B3\u02BE\u02B7\u02BB.Confirm);
			break;
		case PlayerSelectionMenu.\u02C1\u02C1\u02B7\u02BD\u02BC\u02B7\u02C0\u02B3\u02BE\u02B7\u02BB.Ready:
			this.\u02BE\u02B7\u02B2\u02B3\u02B5\u02B7\u02B7\u02B9\u02B3\u02BF\u02BC(PlayerSelectionMenu.\u02C1\u02C1\u02B7\u02BD\u02BC\u02B7\u02C0\u02B3\u02BE\u02B7\u02BB.Confirm);
			this.\u02BE\u02B9\u02BC\u02BA\u02B3\u02BD\u02C1\u02B5\u02B3\u02C1\u02C0();
			break;
		}
		if (this.\u02BC\u02BE\u02C1\u02B8\u02BE\u02C1\u02BE\u02BF\u02BC\u02BC\u02BA)
		{
			\u02B3\u02B7\u02B4\u02BE\u02BE\u02C1\u02BE\u02BB\u02B2\u02B9\u02BA.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BF\u02B9\u02C0\u02BF\u02BA\u02BA\u02B2\u02BA\u02B8\u02B5\u02BC(1);
		}
	}

	protected override void OnEnable()
	{
		if (!GlobalVariables.instance.playerList[this.\u02BE\u02BB\u02B5\u02B7\u02B9\u02B2\u02B6\u02BF\u02B9\u02B7\u02B7].\u02BC\u02BA\u02BE\u02B2\u02C0\u02BE\u02B6\u02B5\u02BC\u02B3\u02BD || GlobalVariables.instance.playerList[this.\u02BE\u02BB\u02B5\u02B7\u02B9\u02B2\u02B6\u02BF\u02B9\u02B7\u02B7].playerProfile == null)
		{
			base.gameObject.SetActive(false);
			return;
		}
		base.OnEnable();
		base.\u02B8\u02BE\u02BD\u02BB\u02B2\u02B6\u02B3\u02BB\u02BB\u02C0\u02B8(GlobalVariables.instance.playerList[this.\u02BE\u02BB\u02B5\u02B7\u02B9\u02B2\u02B6\u02BF\u02B9\u02B7\u02B7]);
		this.playerName.text = (this.controllingPlayer.\u02C0\u02B5\u02B2\u02B2\u02BB\u02B8\u02B8\u02BD\u02B9\u02BD\u02C1() ? ("<color=#00FFFF>" + this.controllingPlayer.playerProfile.playerName.CurrentValueNoTags + "</color>") : this.controllingPlayer.playerProfile.playerName.CurrentValue);
		if (this.controllingPlayer.\u02BD\u02BC\u02B8\u02B5\u02B5\u02B2\u02C0\u02C1\u02B3\u02C0\u02B4)
		{
			this.playerName.color = Color.green;
		}
		else if (this.controllingPlayer.\u02C0\u02B5\u02B2\u02B2\u02BB\u02B8\u02B8\u02BD\u02B9\u02BD\u02C1())
		{
			this.playerName.color = Color.cyan;
		}
		else
		{
			this.playerName.color = Color.white;
		}
		this.\u02B6\u02B2\u02BF\u02B9\u02B9\u02BD\u02B8\u02BF\u02B4\u02B6\u02B7 = this.controllingPlayer.\u02B6\u02B9\u02B7\u02B9\u02B6\u02C1\u02B2\u02BD\u02BF\u02BF\u02BD;
		this.\u02B5\u02B4\u02B4\u02BC\u02B4\u02BC\u02B3\u02BD\u02B9\u02BC\u02C0 = this.controllingPlayer.playerProfile.IsGamepadMode();
		if (this.controllingPlayer.playerProfile.instrument == Instrument.None)
		{
			this.controllingPlayer.playerProfile.instrument = \u02B9\u02BA\u02BF\u02BB\u02B2\u02B9\u02BB\u02B9\u02B9\u02B5\u02B8.\u02B2\u02B8\u02B3\u02BC\u02B7\u02B8\u02C1\u02B6\u02BE\u02B2\u02B7(this.\u02B6\u02B2\u02BF\u02B9\u02B9\u02BD\u02B8\u02BF\u02B4\u02B6\u02B7);
		}
		this.\u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF = this.controllingPlayer.playerProfile.instrument;
		this.\u02B5\u02BD\u02C0\u02C1\u02BF\u02BF\u02B7\u02BF\u02B6\u02C1\u02BA = this.controllingPlayer.playerProfile.difficulty;
		this.\u02C1\u02B3\u02BE\u02B4\u02C0\u02BC\u02BD\u02C1\u02B4\u02C0\u02BC = SceneManager.GetActiveScene().name == "EndOfSong" && GlobalVariables.instance.\u02B7\u02B7\u02B9\u02B6\u02B6\u02B8\u02C1\u02BA\u02BA\u02C0\u02B8;
		this.\u02BC\u02BE\u02C1\u02B8\u02BE\u02C1\u02BE\u02BF\u02BC\u02BC\u02BA = CHNetManager.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B4\u02BA\u02B8\u02B6\u02BB\u02B5\u02B2\u02B8\u02B6\u02BB\u02BB && this.\u02BE\u02BB\u02B5\u02B7\u02B9\u02B2\u02B6\u02BF\u02B9\u02B7\u02B7 == \u02B3\u02B7\u02B4\u02BE\u02BE\u02C1\u02BE\u02BB\u02B2\u02B9\u02BA.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B8\u02B3\u02B2\u02BA\u02BD\u02B6\u02BF\u02BA\u02C1\u02BA\u02B9;
		this.\u02B6\u02B9\u02B7\u02B6\u02B9\u02B2\u02BE\u02BE\u02BE\u02B2\u02B5 = this.controllingPlayer.playerProfile.IsAnyDrumsController;
		this.\u02B5\u02B2\u02B4\u02B8\u02B6\u02BF\u02B4\u02B4\u02B9\u02BB\u02BC();
		this.headerTexts[0].text = LanguageManager.instance.GetString("Modifiers");
		this.headerTexts[1].text = LanguageManager.instance.GetString("Choose Instrument");
		this.headerTexts[2].text = LanguageManager.instance.GetString("Choose Difficulty");
		this.headerTexts[3].text = LanguageManager.instance.GetString("Choose Modifiers");
		if (this.\u02C1\u02B3\u02BE\u02B4\u02C0\u02BC\u02BD\u02C1\u02B4\u02C0\u02BC)
		{
			this.\u02BA\u02B4\u02B8\u02BA\u02C1\u02B7\u02BF\u02BD\u02B5\u02BE\u02BA = \u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02B4\u02BE\u02B5\u02B6\u02BB\u02B4\u02B6\u02B9\u02B5\u02B7\u02BD[GlobalVariables.instance.\u02B5\u02B8\u02B8\u02B6\u02BC\u02BC\u02B6\u02BA\u02B7\u02BE\u02B7 + 1];
		}
		else
		{
			this.\u02BA\u02B4\u02B8\u02BA\u02C1\u02B7\u02BF\u02BD\u02B5\u02BE\u02BA = GlobalVariables.instance.\u02BA\u02B9\u02BD\u02BA\u02B4\u02B4\u02BF\u02BD\u02B8\u02B3\u02C1;
		}
		if (!this.controllingPlayer.playerProfile.selectedInstrumentForSession)
		{
			this.\u02BE\u02B7\u02B2\u02B3\u02B5\u02B7\u02B7\u02B9\u02B3\u02BF\u02BC(PlayerSelectionMenu.\u02C1\u02C1\u02B7\u02BD\u02BC\u02B7\u02C0\u02B3\u02BE\u02B7\u02BB.Instrument);
			this.\u02B8\u02B2\u02C0\u02B6\u02B2\u02B2\u02BB\u02B5\u02B4\u02B8\u02BD = true;
			this.\u02BB\u02BE\u02B6\u02BC\u02B6\u02B4\u02BC\u02B7\u02C1\u02B7\u02B8 = true;
			this.controllingPlayer.playerProfile.selectedInstrumentForSession = true;
		}
		else
		{
			this.\u02BE\u02B7\u02B2\u02B3\u02B5\u02B7\u02B7\u02B9\u02B3\u02BF\u02BC(PlayerSelectionMenu.\u02C1\u02C1\u02B7\u02BD\u02BC\u02B7\u02C0\u02B3\u02BE\u02B7\u02BB.Confirm);
		}
		this.ReadyHeader.SetActive(false);
		this.ReadyText.text = LanguageManager.instance.GetString("Ready");
	}

	private void \u02B7\u02B8\u02C1\u02B3\u02BF\u02C0\u02C1\u02B2\u02BF\u02BF\u02B7()
	{
		this.\u02BB\u02BE\u02B6\u02BC\u02B6\u02B4\u02BC\u02B7\u02C1\u02B7\u02B8 = false;
		this.\u02C0\u02B8\u02B3\u02B7\u02B3\u02BA\u02BB\u02B4\u02B4\u02BF\u02B5 = this.modifierTexts.Length;
		this.\u02B6\u02B9\u02B6\u02B4\u02BF\u02B4\u02C1\u02BF\u02BC\u02B8\u02B6 += Mathf.Clamp((this.\u02B6\u02B9\u02B7\u02B6\u02B9\u02B2\u02BE\u02BE\u02BE\u02B2\u02B5 ? this.\u02BF\u02BE\u02B7\u02B6\u02BA\u02B2\u02B6\u02B7\u02BF\u02B3\u02BD.Length : this.\u02C0\u02C1\u02B8\u02B4\u02B4\u02B6\u02B6\u02BF\u02B2\u02BF\u02BA.Length) + 1 - this.\u02C0\u02B8\u02B3\u02B7\u02B3\u02BA\u02BB\u02B4\u02B4\u02BF\u02B5, 0, int.MaxValue);
		this.modifierGroup.\u02C1\u02BD\u02B6\u02B4\u02B9\u02B9\u02B9\u02B7\u02BC\u02BD\u02B9 = 125f;
		this.\u02B9\u02B8\u02C0\u02B7\u02BA\u02B3\u02BB\u02C0\u02B3\u02C1\u02B8();
	}

	public override void ConfirmPressed()
	{
		if (this.\u02BE\u02BA\u02BD\u02B5\u02BE\u02C0\u02B7\u02B3\u02BA\u02B4\u02BD == PlayerSelectionMenu.\u02C1\u02C1\u02B7\u02BD\u02BC\u02B7\u02C0\u02B3\u02BE\u02B7\u02BB.Ready)
		{
			return;
		}
		base.ConfirmPressed();
		switch (this.\u02BE\u02BA\u02BD\u02B5\u02BE\u02C0\u02B7\u02B3\u02BA\u02B4\u02BD)
		{
		case PlayerSelectionMenu.\u02C1\u02C1\u02B7\u02BD\u02BC\u02B7\u02C0\u02B3\u02BE\u02B7\u02BB.Confirm:
			this.\u02BE\u02B4\u02B8\u02B7\u02BA\u02BE\u02B3\u02BD\u02B6\u02B2\u02C1();
			break;
		case PlayerSelectionMenu.\u02C1\u02C1\u02B7\u02BD\u02BC\u02B7\u02C0\u02B3\u02BE\u02B7\u02BB.Instrument:
			this.\u02B9\u02BB\u02BD\u02B7\u02C0\u02BF\u02C0\u02BF\u02B8\u02C1\u02BC();
			break;
		case PlayerSelectionMenu.\u02C1\u02C1\u02B7\u02BD\u02BC\u02B7\u02C0\u02B3\u02BE\u02B7\u02BB.Difficulty:
			this.\u02B3\u02C1\u02B5\u02BD\u02B5\u02C1\u02BB\u02B5\u02C0\u02BF\u02B6();
			break;
		case PlayerSelectionMenu.\u02C1\u02C1\u02B7\u02BD\u02BC\u02B7\u02C0\u02B3\u02BE\u02B7\u02BB.Modifiers:
			this.\u02C0\u02BD\u02C1\u02BC\u02BC\u02C1\u02C0\u02B3\u02B7\u02B8\u02B3();
			break;
		}
		if (this.\u02BC\u02BE\u02C1\u02B8\u02BE\u02C1\u02BE\u02BF\u02BC\u02BC\u02BA)
		{
			\u02B3\u02B7\u02B4\u02BE\u02BE\u02C1\u02BE\u02BB\u02B2\u02B9\u02BA.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BF\u02B9\u02C0\u02BF\u02BA\u02BA\u02B2\u02BA\u02B8\u02B5\u02BC(0);
		}
	}

	private void \u02BF\u02B5\u02B3\u02BC\u02B5\u02BC\u02BD\u02C1\u02B2\u02C0\u02B6(string \u02BF\u02B4\u02C1\u02BC\u02BC\u02B2\u02BC\u02BB\u02BA\u02B2\u02B6)
	{
		this.difficultyTexts[this.\u02C0\u02B8\u02B3\u02B7\u02B3\u02BA\u02BB\u02B4\u02B4\u02BF\u02B5].text = LanguageManager.instance.GetString(\u02BF\u02B4\u02C1\u02BC\u02BC\u02B2\u02BC\u02BB\u02BA\u02B2\u02B6);
		string[] u02B8_u02BE_u02C1_u02BE_u02B2_u02C0_u02B6_u02C0_u02B5_u02B8_u02B = this.\u02B8\u02BE\u02C1\u02BE\u02B2\u02C0\u02B6\u02C0\u02B5\u02B8\u02B5;
		int u02C0_u02B8_u02B3_u02B7_u02B3_u02BA_u02BB_u02B4_u02B4_u02BF_u02B = this.\u02C0\u02B8\u02B3\u02B7\u02B3\u02BA\u02BB\u02B4\u02B4\u02BF\u02B5;
		this.\u02C0\u02B8\u02B3\u02B7\u02B3\u02BA\u02BB\u02B4\u02B4\u02BF\u02B5 = u02C0_u02B8_u02B3_u02B7_u02B3_u02BA_u02BB_u02B4_u02B4_u02BF_u02B + 1;
		u02B8_u02BE_u02C1_u02BE_u02B2_u02C0_u02B6_u02C0_u02B5_u02B8_u02B[u02C0_u02B8_u02B3_u02B7_u02B3_u02BA_u02BB_u02B4_u02B4_u02BF_u02B] = \u02BF\u02B4\u02C1\u02BC\u02BC\u02B2\u02BC\u02BB\u02BA\u02B2\u02B6;
	}

	public virtual void \u02B4\u02B9\u02B4\u02BD\u02B3\u02B5\u02B9\u02B8\u02BA\u02BA\u02B2()
	{
		float num = 543f;
		float num2 = 657f;
		Transform transform = null;
		switch (this.\u02BE\u02BA\u02BD\u02B5\u02BE\u02C0\u02B7\u02B3\u02BA\u02B4\u02BD)
		{
		case PlayerSelectionMenu.\u02C1\u02C1\u02B7\u02BD\u02BC\u02B7\u02C0\u02B3\u02BE\u02B7\u02BB.Confirm:
			num = 1390f;
			num2 = 158f;
			transform = this.confirmSelection;
			break;
		case PlayerSelectionMenu.\u02C1\u02C1\u02B7\u02BD\u02BC\u02B7\u02C0\u02B3\u02BE\u02B7\u02BB.Instrument:
			num = 799f;
			num2 = 446f;
			transform = this.instrumentSelection;
			break;
		case PlayerSelectionMenu.\u02C1\u02C1\u02B7\u02BD\u02BC\u02B7\u02C0\u02B3\u02BE\u02B7\u02BB.Difficulty:
			num = 768f;
			num2 = 702f;
			transform = this.difficultySelection;
			break;
		case PlayerSelectionMenu.\u02C1\u02C1\u02B7\u02BD\u02BC\u02B7\u02C0\u02B3\u02BE\u02B7\u02BB.Modifiers:
			num = 566f;
			num2 = 686f;
			transform = this.modifierSelection;
			break;
		}
		transform.localPosition = new Vector2(1290f, num - num2 * (float)this.\u02B3\u02BF\u02BB\u02BB\u02B5\u02B7\u02B8\u02BE\u02B7\u02B3\u02B3);
	}

	public void \u02BA\u02BD\u02BD\u02C1\u02BC\u02B4\u02B2\u02BE\u02B6\u02BD\u02B5()
	{
		this.\u02BE\u02BA\u02BD\u02B5\u02BE\u02C0\u02B7\u02B3\u02BA\u02B4\u02BD = PlayerSelectionMenu.\u02C1\u02C1\u02B7\u02BD\u02BC\u02B7\u02C0\u02B3\u02BE\u02B7\u02BB.Ready;
		this.controllingPlayer.playerProfile.\u02BE\u02B5\u02BD\u02B3\u02B3\u02C1\u02BC\u02BC\u02BE\u02B6\u02B7(this.\u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF, this.\u02B5\u02BD\u02C0\u02C1\u02BF\u02BF\u02B7\u02BF\u02B6\u02C1\u02BA);
		this.\u02BE\u02B9\u02BC\u02BA\u02B3\u02BD\u02C1\u02B5\u02B3\u02C1\u02C0();
	}

	protected override void Update()
	{
		if (!this.controllingPlayer.\u02BC\u02BA\u02BE\u02B2\u02C0\u02BE\u02B6\u02B5\u02BC\u02B3\u02BD || this.controllingPlayer.playerProfile == null)
		{
			base.gameObject.SetActive(false);
			return;
		}
		if (this.\u02B5\u02B4\u02B4\u02BC\u02B4\u02BC\u02B3\u02BD\u02B9\u02BC\u02C0)
		{
			if (!this.controllingPlayer.playerProfile.IsGamepadMode())
			{
				this.\u02B5\u02B4\u02B4\u02BC\u02B4\u02BC\u02B3\u02BD\u02B9\u02BC\u02C0 = false;
				this.\u02B5\u02B2\u02B4\u02B8\u02B6\u02BF\u02B4\u02B4\u02B9\u02BB\u02BC();
			}
		}
		else if (this.controllingPlayer.playerProfile.IsGamepadMode())
		{
			this.\u02B5\u02B4\u02B4\u02BC\u02B4\u02BC\u02B3\u02BD\u02B9\u02BC\u02C0 = true;
			this.\u02B5\u02B2\u02B4\u02B8\u02B6\u02BF\u02B4\u02B4\u02B9\u02BB\u02BC();
		}
		if (this.\u02B6\u02B2\u02BF\u02B9\u02B9\u02BD\u02B8\u02BF\u02B4\u02B6\u02B7 != this.controllingPlayer.\u02B6\u02B9\u02B7\u02B9\u02B6\u02C1\u02B2\u02BD\u02BF\u02BF\u02BD)
		{
			this.\u02B6\u02B2\u02BF\u02B9\u02B9\u02BD\u02B8\u02BF\u02B4\u02B6\u02B7 = this.controllingPlayer.\u02B6\u02B9\u02B7\u02B9\u02B6\u02C1\u02B2\u02BD\u02BF\u02BF\u02BD;
			this.\u02B3\u02B2\u02BF\u02C1\u02B5\u02B4\u02BF\u02C1\u02BA\u02B5\u02BE = true;
			this.\u02B5\u02B2\u02B4\u02B8\u02B6\u02BF\u02B4\u02B4\u02B9\u02BB\u02BC();
			this.\u02BE\u02B7\u02B2\u02B3\u02B5\u02B7\u02B7\u02B9\u02B3\u02BF\u02BC(PlayerSelectionMenu.\u02C1\u02C1\u02B7\u02BD\u02BC\u02B7\u02C0\u02B3\u02BE\u02B7\u02BB.Instrument);
		}
		base.Update();
	}

	public override void \u02BF\u02B7\u02BF\u02BF\u02B4\u02B2\u02BF\u02B7\u02BA\u02BA\u02B2()
	{
		float num = 0f;
		float num2 = 0f;
		Transform transform = null;
		switch (this.\u02BE\u02BA\u02BD\u02B5\u02BE\u02C0\u02B7\u02B3\u02BA\u02B4\u02BD)
		{
		case PlayerSelectionMenu.\u02C1\u02C1\u02B7\u02BD\u02BC\u02B7\u02C0\u02B3\u02BE\u02B7\u02BB.Confirm:
			num = 80f;
			num2 = 50f;
			transform = this.confirmSelection;
			break;
		case PlayerSelectionMenu.\u02C1\u02C1\u02B7\u02BD\u02BC\u02B7\u02C0\u02B3\u02BE\u02B7\u02BB.Instrument:
			num = 155f;
			num2 = 60f;
			transform = this.instrumentSelection;
			break;
		case PlayerSelectionMenu.\u02C1\u02C1\u02B7\u02BD\u02BC\u02B7\u02C0\u02B3\u02BE\u02B7\u02BB.Difficulty:
			num = 155f;
			num2 = 60f;
			transform = this.difficultySelection;
			break;
		case PlayerSelectionMenu.\u02C1\u02C1\u02B7\u02BD\u02BC\u02B7\u02C0\u02B3\u02BE\u02B7\u02BB.Modifiers:
			num = 140f;
			num2 = 40f;
			transform = this.modifierSelection;
			break;
		}
		transform.localPosition = new Vector2(0f, num - num2 * (float)this.\u02B3\u02BF\u02BB\u02BB\u02B5\u02B7\u02B8\u02BE\u02B7\u02B3\u02B3);
	}

	private void \u02B5\u02B4\u02B8\u02B8\u02B3\u02B5\u02B5\u02B2\u02B6\u02BB\u02B4()
	{
		int num = this.\u02BB\u02B3\u02C0\u02BC\u02BF\u02BD\u02B9\u02B2\u02BC\u02BE\u02B7 + this.\u02B3\u02BF\u02BB\u02BB\u02B5\u02B7\u02B8\u02BE\u02B7\u02B3\u02B3;
		if (num == 0)
		{
			this.\u02BE\u02B7\u02B2\u02B3\u02B5\u02B7\u02B7\u02B9\u02B3\u02BF\u02BC(PlayerSelectionMenu.\u02C1\u02C1\u02B7\u02BD\u02BC\u02B7\u02C0\u02B3\u02BE\u02B7\u02BB.Confirm);
			return;
		}
		num--;
		Modifier modifier = (this.\u02B6\u02B9\u02B7\u02B6\u02B9\u02B2\u02BE\u02BE\u02BE\u02B2\u02B5 ? this.\u02BF\u02BE\u02B7\u02B6\u02BA\u02B2\u02B6\u02B7\u02BF\u02B3\u02BD[num] : this.\u02C0\u02C1\u02B8\u02B4\u02B4\u02B6\u02B6\u02BF\u02B2\u02BF\u02BA[num]);
		this.controllingPlayer.playerProfile.ToggleModifier(modifier);
		this.\u02B5\u02B2\u02B4\u02B8\u02B6\u02BF\u02B4\u02B4\u02B9\u02BB\u02BC();
		this.\u02B9\u02B8\u02C0\u02B7\u02BA\u02B3\u02BB\u02C0\u02B3\u02C1\u02B8();
	}

	private void \u02BC\u02BF\u02BE\u02BC\u02B8\u02B3\u02B4\u02BC\u02B3\u02BF\u02C1(int \u02BD\u02BA\u02C0\u02BC\u02B6\u02B4\u02B5\u02BD\u02B4\u02C0\u02B8)
	{
		foreach (ModifierFlowElement modifierFlowElement in this.modifierElements)
		{
			if (!modifierFlowElement.gameObject.activeSelf)
			{
				modifierFlowElement.\u02B3\u02BB\u02B2\u02BA\u02BC\u02BB\u02C1\u02BB\u02B7\u02BD\u02B4(\u02BD\u02BA\u02C0\u02BC\u02B6\u02B4\u02B5\u02BD\u02B4\u02C0\u02B8, this.\u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF);
				return;
			}
		}
	}

	private PlayerSelectionMenu.\u02C1\u02C1\u02B7\u02BD\u02BC\u02B7\u02C0\u02B3\u02BE\u02B7\u02BB \u02BE\u02BA\u02BD\u02B5\u02BE\u02C0\u02B7\u02B3\u02BA\u02B4\u02BD;

	[SerializeField]
	private TextMeshProUGUI playerName;

	public int \u02BE\u02BB\u02B5\u02B7\u02B9\u02B2\u02B6\u02BF\u02B9\u02B7\u02B7;

	[SerializeField]
	private GameObject[] confirmPageObjects;

	[SerializeField]
	private GameObject[] instrumentPageObjects;

	[SerializeField]
	private GameObject[] difficultyPageObjects;

	[SerializeField]
	private GameObject[] modifierPageObjects;

	[SerializeField]
	private GameObject buttonsGroup;

	[SerializeField]
	private GameObject ReadyHeader;

	[SerializeField]
	private TextMeshProUGUI ReadyText;

	[SerializeField]
	private TextMeshProUGUI noDifficultyText;

	[SerializeField]
	private ModifierFlowElement[] modifierElements;

	[SerializeField]
	private TextMeshProUGUI[] confirmTexts;

	[SerializeField]
	private TextMeshProUGUI[] instrumentTexts;

	[SerializeField]
	private TextMeshProUGUI[] difficultyTexts;

	[SerializeField]
	private TextMeshProUGUI[] modifierTexts;

	[SerializeField]
	private TextMeshProUGUI[] headerTexts;

	[SerializeField]
	private FlowLayoutGroup modifierGroup;

	[SerializeField]
	private TextMeshProUGUI difficultyHeaderText;

	[SerializeField]
	private TextMeshProUGUI notSupported;

	[SerializeField]
	private DifficultyDisplay headerDifficultyIcon;

	[SerializeField]
	private PlayerSelectionCanvas playerSelectionCanvas;

	[SerializeField]
	private PlayerStatsBox playerStatsMenu;

	[SerializeField]
	private DifficultyDisplay[] difficultyIcons;

	[SerializeField]
	private Image[] modifierEnabledIcons;

	private ControllerType \u02B6\u02B2\u02BF\u02B9\u02B9\u02BD\u02B8\u02BF\u02B4\u02B6\u02B7;

	private bool \u02B5\u02B4\u02B4\u02BC\u02B4\u02BC\u02B3\u02BD\u02B9\u02BC\u02C0;

	private bool \u02B8\u02B2\u02C0\u02B6\u02B2\u02B2\u02BB\u02B5\u02B4\u02B8\u02BD;

	private bool \u02BB\u02BE\u02B6\u02BC\u02B6\u02B4\u02BC\u02B7\u02C1\u02B7\u02B8;

	[SerializeField]
	private Transform confirmSelection;

	[SerializeField]
	private Transform instrumentSelection;

	[SerializeField]
	private Transform difficultySelection;

	[SerializeField]
	private Transform modifierSelection;

	private string[] \u02B8\u02BE\u02C1\u02BE\u02B2\u02C0\u02B6\u02C0\u02B5\u02B8\u02B5 = new string[9];

	private int[] \u02BF\u02B6\u02BE\u02C1\u02C1\u02B9\u02BA\u02B5\u02BB\u02B3\u02BD = new int[9];

	private Instrument[] \u02C1\u02B6\u02C1\u02B2\u02B3\u02BE\u02BD\u02BF\u02B8\u02BF\u02C0 = new Instrument[9];

	private int \u02B4\u02B2\u02B7\u02B2\u02BF\u02BD\u02B7\u02BB\u02BB\u02BD\u02B8;

	private SongEntry \u02BA\u02B4\u02B8\u02BA\u02C1\u02B7\u02BF\u02BD\u02B5\u02BE\u02BA;

	private Instrument \u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF;

	private Difficulty \u02B5\u02BD\u02C0\u02C1\u02BF\u02BF\u02B7\u02BF\u02B6\u02C1\u02BA;

	private bool \u02B6\u02B9\u02B7\u02B6\u02B9\u02B2\u02BE\u02BE\u02BE\u02B2\u02B5;

	private bool \u02C1\u02B3\u02BE\u02B4\u02C0\u02BC\u02BD\u02C1\u02B4\u02C0\u02BC;

	private bool \u02BC\u02BE\u02C1\u02B8\u02BE\u02C1\u02BE\u02BF\u02BC\u02BC\u02BA;

	private bool \u02B3\u02B2\u02BF\u02C1\u02B5\u02B4\u02BF\u02C1\u02BA\u02B5\u02BE;

	private Modifier[] \u02C0\u02C1\u02B8\u02B4\u02B4\u02B6\u02B6\u02BF\u02B2\u02BF\u02BA = new Modifier[]
	{
		Modifier.None,
		Modifier.PrecisionMode,
		Modifier.DrunkMode,
		Modifier.BrutalMode,
		Modifier.DroplessSustains,
		Modifier.StrumlessHopos,
		Modifier.DoubleNotes,
		Modifier.NoFretGhosting,
		Modifier.AllStrums,
		Modifier.AllHOPOs,
		Modifier.AllTaps,
		Modifier.AllOpens,
		Modifier.HOPOsToTaps,
		Modifier.MirrorMode,
		Modifier.Shuffle,
		Modifier.AutoStrum,
		Modifier.LightsOut,
		Modifier.ModFull,
		Modifier.ModLite,
		Modifier.ModPrep
	};

	private Modifier[] \u02BF\u02BE\u02B7\u02B6\u02BA\u02B2\u02B6\u02B7\u02BF\u02B3\u02BD = new Modifier[]
	{
		Modifier.None,
		Modifier.AllStrums,
		Modifier.PrecisionMode,
		Modifier.BrutalMode,
		Modifier.AllOpens,
		Modifier.AllHOPOs,
		Modifier.AllTaps,
		Modifier.MirrorMode,
		Modifier.Shuffle,
		Modifier.LightsOut,
		Modifier.ModFull,
		Modifier.ModLite,
		Modifier.ModPrep
	};

	private enum \u02C1\u02C1\u02B7\u02BD\u02BC\u02B7\u02C0\u02B3\u02BE\u02B7\u02BB
	{
		Confirm,
		Instrument,
		Difficulty,
		Modifiers,
		Ready
	}
}
