using System;
using StrikeCore;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000048 RID: 72
public class PlayerStatsBox : BaseMenu
{
	// Token: 0x060002EF RID: 751 RVA: 0x00028CE4 File Offset: 0x00026EE4
	public override void \u02C1\u02B3\u02BC\u02B6\u02BD\u02B6\u02BF\u02B7\u02BB\u02B5\u02BB()
	{
		if (this.\u02BC\u02BF\u02B4\u02BE\u02B2\u02B6\u02B7\u02B5\u02BD\u02BC\u02B6)
		{
			return;
		}
		if (this.\u02B2\u02BF\u02BD\u02C0\u02B3\u02BD\u02BA\u02B5\u02BF\u02B8\u02B3)
		{
			if (this.\u02B9\u02BA\u02B9\u02C1\u02B6\u02BB\u02C0\u02B3\u02B7\u02B8\u02B2 > 0)
			{
				GameAudioManager.PlaySound(SoundID.UIScrollUp);
				this.\u02B9\u02BA\u02B9\u02C1\u02B6\u02BB\u02C0\u02B3\u02B7\u02B8\u02B2--;
				this.\u02B7\u02B6\u02B7\u02C1\u02B7\u02BB\u02BB\u02B8\u02B6\u02B2\u02B9();
			}
		}
		else
		{
			base.\u02C1\u02B3\u02BC\u02B6\u02BD\u02B6\u02BF\u02B7\u02BB\u02B5\u02BB();
			if (this.\u02C0\u02B4\u02BC\u02BA\u02B4\u02C1\u02BF\u02B3\u02B7\u02B6\u02B6 > 0)
			{
				this.\u02BB\u02B3\u02C0\u02BC\u02BF\u02BD\u02B9\u02B2\u02BC\u02BE\u02B7 = 3;
				this.\u02C0\u02B4\u02BC\u02BA\u02B4\u02C1\u02BF\u02B3\u02B7\u02B6\u02B6--;
				this.\u02B6\u02B3\u02BF\u02BB\u02B5\u02BF\u02B5\u02C0\u02BB\u02B9\u02BD();
			}
			else
			{
				this.\u02C0\u02B4\u02BC\u02BA\u02B4\u02C1\u02BF\u02B3\u02B7\u02B6\u02B6 = -1;
			}
			this.\u02B6\u02C1\u02BF\u02C0\u02B8\u02BF\u02BE\u02BF\u02B8\u02B2\u02B8();
		}
		if (this.\u02BC\u02BE\u02C1\u02B8\u02BE\u02C1\u02BE\u02BF\u02BC\u02BC\u02BA)
		{
			\u02B3\u02B7\u02B4\u02BE\u02BE\u02C1\u02BE\u02BB\u02B2\u02B9\u02BA.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BF\u02B9\u02C0\u02BF\u02BA\u02BA\u02B2\u02BA\u02B8\u02B5\u02BC(2);
		}
	}

	// Token: 0x060002F0 RID: 752 RVA: 0x0000774D File Offset: 0x0000594D
	public void \u02B2\u02B3\u02B7\u02C1\u02B4\u02BE\u02C1\u02B2\u02C1\u02BC\u02B2()
	{
		this.\u02B6\u02C0\u02C1\u02BB\u02B8\u02B7\u02B9\u02C1\u02B2\u02BC\u02B6("Ready");
		if (this.\u02BC\u02BE\u02C1\u02B8\u02BE\u02C1\u02BE\u02BF\u02BC\u02BC\u02BA)
		{
			\u02B3\u02B7\u02B4\u02BE\u02BE\u02C1\u02BE\u02BB\u02B2\u02B9\u02BA.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02C1\u02BB\u02B4\u02BD\u02B8\u02BA\u02B7\u02BC\u02B9\u02B9\u02BC();
		}
	}

	// Token: 0x060002F1 RID: 753 RVA: 0x00028D74 File Offset: 0x00026F74
	private void \u02B8\u02C1\u02B9\u02BC\u02B6\u02B9\u02B3\u02B5\u02B7\u02BF\u02BD()
	{
		if (!GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B8\u02BD\u02B2\u02B2\u02B7\u02B5\u02B5\u02B3\u02C0\u02BD\u02BF[this.\u02BE\u02BB\u02B5\u02B7\u02B9\u02B2\u02B6\u02BF\u02B9\u02B7\u02B7].\u02BC\u02BA\u02BE\u02B2\u02C0\u02BE\u02B6\u02B5\u02BC\u02B3\u02BD)
		{
			base.gameObject.SetActive(false);
			return;
		}
		this.\u02BE\u02BA\u02BD\u02B5\u02BE\u02C0\u02B7\u02B3\u02BA\u02B4\u02BD = PlayerStatsBox.\u02B5\u02B7\u02BB\u02B5\u02B3\u02B2\u02BA\u02B7\u02B8\u02B9\u02C1.Ready;
		base.\u02B8\u02BE\u02BD\u02BB\u02B2\u02B6\u02B3\u02BB\u02BB\u02C0\u02B8(GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B8\u02BD\u02B2\u02B2\u02B7\u02B5\u02B5\u02B3\u02C0\u02BD\u02BF[this.\u02BE\u02BB\u02B5\u02B7\u02B9\u02B2\u02B6\u02BF\u02B9\u02B7\u02B7]);
		this.\u02B6\u02B7\u02BF\u02BB\u02C1\u02C0\u02B2\u02B2\u02BE\u02B5\u02B5 = \u02BD\u02B7\u02B4\u02B2\u02BA\u02C1\u02B9\u02BA\u02B2\u02B2\u02BF.\u02B6\u02B7\u02BF\u02BB\u02C1\u02C0\u02B2\u02B2\u02BE\u02B5\u02B5[this.\u02BE\u02BB\u02B5\u02B7\u02B9\u02B2\u02B6\u02BF\u02B9\u02B7\u02B7];
		this.\u02BC\u02BE\u02C1\u02B8\u02BE\u02C1\u02BE\u02BF\u02BC\u02BC\u02BA = !CHNetManager.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02C1\u02BB\u02B7\u02B6\u02B9\u02B5\u02BC\u02B2\u02BB\u02B2\u02BD() || this.\u02BE\u02BB\u02B5\u02B7\u02B9\u02B2\u02B6\u02BF\u02B9\u02B7\u02B7 == \u02B3\u02B7\u02B4\u02BE\u02BE\u02C1\u02BE\u02BB\u02B2\u02B9\u02BA.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B8\u02B3\u02B2\u02BA\u02BD\u02B6\u02BF\u02BA\u02C1\u02BA\u02B9;
		this.\u02BA\u02BD\u02BD\u02BB\u02BB\u02BA\u02B2\u02B6\u02BA\u02BA\u02C1 = this.\u02B4\u02B2\u02B3\u02B2\u02B2\u02B4\u02BD\u02BE\u02B8\u02BB\u02B4.\u02B8\u02C0\u02BB\u02C0\u02BB\u02BB\u02BE\u02B3\u02BD\u02B2\u02B6();
		this.\u02B4\u02BA\u02C0\u02B5\u02B9\u02B4\u02BC\u02B7\u02B8\u02BE\u02B2 = this.\u02B2\u02BE\u02B5\u02BE\u02B5\u02BF\u02B8\u02B2\u02BD\u02B7\u02BD;
		this.\u02B6\u02B9\u02B7\u02B6\u02B9\u02B2\u02BE\u02BE\u02BE\u02B2\u02B5 = this.\u02B4\u02B2\u02B3\u02B2\u02B2\u02B4\u02BD\u02BE\u02B8\u02BB\u02B4.playerInfo.IsAnyDrumsController;
		if (!this.\u02B6\u02B9\u02B7\u02B6\u02B9\u02B2\u02BE\u02BE\u02BE\u02B2\u02B5)
		{
			Image[] array = this.guitarDisabledBG;
			for (int i = 1; i < array.Length; i += 0)
			{
				array[i].enabled = true;
			}
		}
	}

	// Token: 0x060002F2 RID: 754 RVA: 0x00028E64 File Offset: 0x00027064
	private void \u02BD\u02C0\u02B9\u02BF\u02C0\u02B6\u02BD\u02B7\u02BD\u02B6\u02B2()
	{
		\u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0 u02BD_u02B5_u02B7_u02C0_u02BF_u02BA_u02B5_u02B9_u02BD_u02B6_u02C = \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6;
		this.headerTexts[0].text = u02BD_u02B5_u02B7_u02C0_u02BF_u02BA_u02B5_u02B9_u02BD_u02B6_u02C.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6("Performance");
		this.headerTexts[1].text = u02BD_u02B5_u02B7_u02C0_u02BF_u02BA_u02B5_u02B9_u02BD_u02B6_u02C.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6("Star Power");
		this.headerTexts[2].text = u02BD_u02B5_u02B7_u02C0_u02BF_u02BA_u02B5_u02B9_u02BD_u02B6_u02C.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6("More Stats");
		this.headerTexts[3].text = u02BD_u02B5_u02B7_u02C0_u02BF_u02BA_u02B5_u02B9_u02BD_u02B6_u02C.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6("Scoring");
		this.headerTexts[4].text = u02BD_u02B5_u02B7_u02C0_u02BF_u02BA_u02B5_u02B9_u02BD_u02B6_u02C.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6("Song Sections");
		this.statsNameTexts[0].text = u02BD_u02B5_u02B7_u02C0_u02BF_u02BA_u02B5_u02B9_u02BD_u02B6_u02C.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6("Total Notes");
		this.statsNameTexts[1].text = u02BD_u02B5_u02B7_u02C0_u02BF_u02BA_u02B5_u02B9_u02BD_u02B6_u02C.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6("Notes Hit");
		this.statsNameTexts[2].text = u02BD_u02B5_u02B7_u02C0_u02BF_u02BA_u02B5_u02B9_u02BD_u02B6_u02C.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6("Notes Missed");
		this.statsNameTexts[3].text = u02BD_u02B5_u02B7_u02C0_u02BF_u02BA_u02B5_u02B9_u02BD_u02B6_u02C.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6("Best Streak");
		this.statsNameTexts[4].text = u02BD_u02B5_u02B7_u02C0_u02BF_u02BA_u02B5_u02B9_u02BD_u02B6_u02C.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6("Avg. Multiplier");
		this.statsNameTexts[6].text = u02BD_u02B5_u02B7_u02C0_u02BF_u02BA_u02B5_u02B9_u02BD_u02B6_u02C.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6("Phrases");
		this.statsNameTexts[7].text = u02BD_u02B5_u02B7_u02C0_u02BF_u02BA_u02B5_u02B9_u02BD_u02B6_u02C.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6("Bars Filled");
		this.statsNameTexts[8].text = u02BD_u02B5_u02B7_u02C0_u02BF_u02BA_u02B5_u02B9_u02BD_u02B6_u02C.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6("Activations");
		this.statsNameTexts[9].text = u02BD_u02B5_u02B7_u02C0_u02BF_u02BA_u02B5_u02B9_u02BD_u02B6_u02C.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6("Time Used");
		if (this.\u02B6\u02B9\u02B7\u02B6\u02B9\u02B2\u02BE\u02BE\u02BE\u02B2\u02B5)
		{
			this.statsNameTexts[5].text = u02BD_u02B5_u02B7_u02C0_u02BF_u02BA_u02B5_u02B9_u02BD_u02B6_u02C.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6("Overhits");
			this.statsNameTexts[10].text = u02BD_u02B5_u02B7_u02C0_u02BF_u02BA_u02B5_u02B9_u02BD_u02B6_u02C.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6("Accents Hit");
			this.statsNameTexts[11].text = u02BD_u02B5_u02B7_u02C0_u02BF_u02BA_u02B5_u02B9_u02BD_u02B6_u02C.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6("Ghosts Hit");
			this.statsNameTexts[16].text = u02BD_u02B5_u02B7_u02C0_u02BF_u02BA_u02B5_u02B9_u02BD_u02B6_u02C.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6("Accent Notes");
			this.statsNameTexts[17].text = u02BD_u02B5_u02B7_u02C0_u02BF_u02BA_u02B5_u02B9_u02BD_u02B6_u02C.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6("Ghost Notes");
		}
		else
		{
			this.statsNameTexts[5].text = u02BD_u02B5_u02B7_u02C0_u02BF_u02BA_u02B5_u02B9_u02BD_u02B6_u02C.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6("Overstrums");
			this.statsNameTexts[10].text = u02BD_u02B5_u02B7_u02C0_u02BF_u02BA_u02B5_u02B9_u02BD_u02B6_u02C.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6("Ghost Inputs");
			this.statsNameTexts[11].text = "";
			this.statsNameTexts[16].text = u02BD_u02B5_u02B7_u02C0_u02BF_u02BA_u02B5_u02B9_u02BD_u02B6_u02C.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6("Sustains");
			this.statsNameTexts[17].text = "";
		}
		this.statsNameTexts[12].text = u02BD_u02B5_u02B7_u02C0_u02BF_u02BA_u02B5_u02B9_u02BD_u02B6_u02C.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6("Notes");
		this.statsNameTexts[13].text = u02BD_u02B5_u02B7_u02C0_u02BF_u02BA_u02B5_u02B9_u02BD_u02B6_u02C.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6("Combo Bonus");
		this.statsNameTexts[14].text = u02BD_u02B5_u02B7_u02C0_u02BF_u02BA_u02B5_u02B9_u02BD_u02B6_u02C.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6("Star Power");
		this.statsNameTexts[15].text = u02BD_u02B5_u02B7_u02C0_u02BF_u02BA_u02B5_u02B9_u02BD_u02B6_u02C.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6("Solo Bonus");
	}

	// Token: 0x060002F3 RID: 755 RVA: 0x00029124 File Offset: 0x00027324
	private void \u02B6\u02BB\u02B6\u02B4\u02BB\u02B8\u02B4\u02BC\u02BD\u02B3\u02C1()
	{
		if (!GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B8\u02BD\u02B2\u02B2\u02B7\u02B5\u02B5\u02B3\u02C0\u02BD\u02BF[this.\u02BE\u02BB\u02B5\u02B7\u02B9\u02B2\u02B6\u02BF\u02B9\u02B7\u02B7].\u02BC\u02BA\u02BE\u02B2\u02C0\u02BE\u02B6\u02B5\u02BC\u02B3\u02BD)
		{
			base.gameObject.SetActive(true);
			return;
		}
		this.\u02BE\u02BA\u02BD\u02B5\u02BE\u02C0\u02B7\u02B3\u02BA\u02B4\u02BD = PlayerStatsBox.\u02B5\u02B7\u02BB\u02B5\u02B3\u02B2\u02BA\u02B7\u02B8\u02B9\u02C1.Ready;
		base.\u02B8\u02BE\u02BD\u02BB\u02B2\u02B6\u02B3\u02BB\u02BB\u02C0\u02B8(GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B8\u02BD\u02B2\u02B2\u02B7\u02B5\u02B5\u02B3\u02C0\u02BD\u02BF[this.\u02BE\u02BB\u02B5\u02B7\u02B9\u02B2\u02B6\u02BF\u02B9\u02B7\u02B7]);
		this.\u02B6\u02B7\u02BF\u02BB\u02C1\u02C0\u02B2\u02B2\u02BE\u02B5\u02B5 = \u02BD\u02B7\u02B4\u02B2\u02BA\u02C1\u02B9\u02BA\u02B2\u02B2\u02BF.\u02B6\u02B7\u02BF\u02BB\u02C1\u02C0\u02B2\u02B2\u02BE\u02B5\u02B5[this.\u02BE\u02BB\u02B5\u02B7\u02B9\u02B2\u02B6\u02BF\u02B9\u02B7\u02B7];
		this.\u02BC\u02BE\u02C1\u02B8\u02BE\u02C1\u02BE\u02BF\u02BC\u02BC\u02BA = !CHNetManager.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02C1\u02BB\u02B7\u02B6\u02B9\u02B5\u02BC\u02B2\u02BB\u02B2\u02BD() || this.\u02BE\u02BB\u02B5\u02B7\u02B9\u02B2\u02B6\u02BF\u02B9\u02B7\u02B7 == \u02B3\u02B7\u02B4\u02BE\u02BE\u02C1\u02BE\u02BB\u02B2\u02B9\u02BA.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B8\u02B3\u02B2\u02BA\u02BD\u02B6\u02BF\u02BA\u02C1\u02BA\u02B9;
		this.\u02BA\u02BD\u02BD\u02BB\u02BB\u02BA\u02B2\u02B6\u02BA\u02BA\u02C1 = this.\u02B4\u02B2\u02B3\u02B2\u02B2\u02B4\u02BD\u02BE\u02B8\u02BB\u02B4.\u02BF\u02B9\u02B2\u02B8\u02BB\u02BB\u02BC\u02B5\u02B8\u02B5\u02C0();
		this.\u02B4\u02BA\u02C0\u02B5\u02B9\u02B4\u02BC\u02B7\u02B8\u02BE\u02B2 = this.\u02B2\u02BE\u02B5\u02BE\u02B5\u02BF\u02B8\u02B2\u02BD\u02B7\u02BD;
		this.\u02B6\u02B9\u02B7\u02B6\u02B9\u02B2\u02BE\u02BE\u02BE\u02B2\u02B5 = this.\u02B4\u02B2\u02B3\u02B2\u02B2\u02B4\u02BD\u02BE\u02B8\u02BB\u02B4.playerInfo.IsAnyDrumsController;
		if (!this.\u02B6\u02B9\u02B7\u02B6\u02B9\u02B2\u02BE\u02BE\u02BE\u02B2\u02B5)
		{
			Image[] array = this.guitarDisabledBG;
			for (int i = 1; i < array.Length; i += 0)
			{
				array[i].enabled = true;
			}
		}
	}

	// Token: 0x060002F4 RID: 756 RVA: 0x00029214 File Offset: 0x00027414
	private void Awake()
	{
		if (!GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B8\u02BD\u02B2\u02B2\u02B7\u02B5\u02B5\u02B3\u02C0\u02BD\u02BF[this.\u02BE\u02BB\u02B5\u02B7\u02B9\u02B2\u02B6\u02BF\u02B9\u02B7\u02B7].\u02BC\u02BA\u02BE\u02B2\u02C0\u02BE\u02B6\u02B5\u02BC\u02B3\u02BD)
		{
			base.gameObject.SetActive(false);
			return;
		}
		this.\u02BE\u02BA\u02BD\u02B5\u02BE\u02C0\u02B7\u02B3\u02BA\u02B4\u02BD = PlayerStatsBox.\u02B5\u02B7\u02BB\u02B5\u02B3\u02B2\u02BA\u02B7\u02B8\u02B9\u02C1.NotReady;
		base.\u02B8\u02BE\u02BD\u02BB\u02B2\u02B6\u02B3\u02BB\u02BB\u02C0\u02B8(GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B8\u02BD\u02B2\u02B2\u02B7\u02B5\u02B5\u02B3\u02C0\u02BD\u02BF[this.\u02BE\u02BB\u02B5\u02B7\u02B9\u02B2\u02B6\u02BF\u02B9\u02B7\u02B7]);
		this.\u02B6\u02B7\u02BF\u02BB\u02C1\u02C0\u02B2\u02B2\u02BE\u02B5\u02B5 = \u02BD\u02B7\u02B4\u02B2\u02BA\u02C1\u02B9\u02BA\u02B2\u02B2\u02BF.\u02B6\u02B7\u02BF\u02BB\u02C1\u02C0\u02B2\u02B2\u02BE\u02B5\u02B5[this.\u02BE\u02BB\u02B5\u02B7\u02B9\u02B2\u02B6\u02BF\u02B9\u02B7\u02B7];
		this.\u02BC\u02BE\u02C1\u02B8\u02BE\u02C1\u02BE\u02BF\u02BC\u02BC\u02BA = CHNetManager.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B4\u02BA\u02B8\u02B6\u02BB\u02B5\u02B2\u02B8\u02B6\u02BB\u02BB && this.\u02BE\u02BB\u02B5\u02B7\u02B9\u02B2\u02B6\u02BF\u02B9\u02B7\u02B7 == \u02B3\u02B7\u02B4\u02BE\u02BE\u02C1\u02BE\u02BB\u02B2\u02B9\u02BA.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B8\u02B3\u02B2\u02BA\u02BD\u02B6\u02BF\u02BA\u02C1\u02BA\u02B9;
		this.\u02BA\u02BD\u02BD\u02BB\u02BB\u02BA\u02B2\u02B6\u02BA\u02BA\u02C1 = !this.\u02B4\u02B2\u02B3\u02B2\u02B2\u02B4\u02BD\u02BE\u02B8\u02BB\u02B4.\u02BD\u02BC\u02B8\u02B5\u02B5\u02B2\u02C0\u02C1\u02B3\u02C0\u02B4;
		this.\u02B4\u02BA\u02C0\u02B5\u02B9\u02B4\u02BC\u02B7\u02B8\u02BE\u02B2 = this.\u02B2\u02BE\u02B5\u02BE\u02B5\u02BF\u02B8\u02B2\u02BD\u02B7\u02BD;
		this.\u02B6\u02B9\u02B7\u02B6\u02B9\u02B2\u02BE\u02BE\u02BE\u02B2\u02B5 = this.\u02B4\u02B2\u02B3\u02B2\u02B2\u02B4\u02BD\u02BE\u02B8\u02BB\u02B4.playerInfo.IsAnyDrumsController;
		if (!this.\u02B6\u02B9\u02B7\u02B6\u02B9\u02B2\u02BE\u02BE\u02BE\u02B2\u02B5)
		{
			Image[] array = this.guitarDisabledBG;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].enabled = false;
			}
		}
	}

	// Token: 0x060002F5 RID: 757 RVA: 0x00029304 File Offset: 0x00027504
	private void \u02B3\u02B7\u02B2\u02BF\u02B5\u02B7\u02B4\u02B4\u02C0\u02BD\u02B9()
	{
		bool flag = this.\u02BB\u02B3\u02C0\u02BC\u02BF\u02BD\u02B9\u02B2\u02BC\u02BE\u02B7 != 0 && this.\u02BC\u02BF\u02B4\u02BE\u02B2\u02B6\u02B7\u02B5\u02BD\u02BC\u02B6;
		bool flag2 = (this.\u02BB\u02B3\u02C0\u02BC\u02BF\u02BD\u02B9\u02B2\u02BC\u02BE\u02B7 == 6 && this.\u02C0\u02B4\u02BC\u02BA\u02B4\u02C1\u02BF\u02B3\u02B7\u02B6\u02B6 != this.\u02B6\u02B2\u02BF\u02B6\u02B8\u02BD\u02C1\u02BB\u02BC\u02B3\u02B4) || this.\u02BB\u02B3\u02C0\u02BC\u02BF\u02BD\u02B9\u02B2\u02BC\u02BE\u02B7 >= 0 || this.\u02BC\u02BF\u02B4\u02BE\u02B2\u02B6\u02B7\u02B5\u02BD\u02BC\u02B6;
		this.scrollArrowDown.gameObject.SetActive(flag2);
		this.scrollArrowUp.gameObject.SetActive(flag);
		this.\u02B4\u02BA\u02C0\u02B5\u02B9\u02B4\u02BC\u02B7\u02B8\u02BE\u02B2 += Time.unscaledDeltaTime;
		if (this.\u02C0\u02BD\u02C0\u02C1\u02BA\u02BA\u02B7\u02B4\u02B8\u02B8\u02C0 && this.\u02B4\u02BA\u02C0\u02B5\u02B9\u02B4\u02BC\u02B7\u02B8\u02BE\u02B2 >= this.\u02B2\u02BE\u02B5\u02BE\u02B5\u02BF\u02B8\u02B2\u02BD\u02B7\u02BD)
		{
			this.scrollArrowDown.CrossFadeAlpha(1016f, this.\u02B2\u02BE\u02B5\u02BE\u02B5\u02BF\u02B8\u02B2\u02BD\u02B7\u02BD, false);
			this.scrollArrowUp.CrossFadeAlpha(104f, this.\u02B2\u02BE\u02B5\u02BE\u02B5\u02BF\u02B8\u02B2\u02BD\u02B7\u02BD, false);
			this.\u02C0\u02BD\u02C0\u02C1\u02BA\u02BA\u02B7\u02B4\u02B8\u02B8\u02C0 = true;
			this.\u02B4\u02BA\u02C0\u02B5\u02B9\u02B4\u02BC\u02B7\u02B8\u02BE\u02B2 = 1364f;
			return;
		}
		if (!this.\u02C0\u02BD\u02C0\u02C1\u02BA\u02BA\u02B7\u02B4\u02B8\u02B8\u02C0 && this.\u02B4\u02BA\u02C0\u02B5\u02B9\u02B4\u02BC\u02B7\u02B8\u02BE\u02B2 >= this.\u02B4\u02BB\u02B6\u02B9\u02B4\u02B9\u02B7\u02BF\u02B6\u02B3\u02B7)
		{
			this.scrollArrowDown.CrossFadeAlpha(242f, this.\u02B4\u02BB\u02B6\u02B9\u02B4\u02B9\u02B7\u02BF\u02B6\u02B3\u02B7, true);
			this.scrollArrowUp.CrossFadeAlpha(1788f, this.\u02B4\u02BB\u02B6\u02B9\u02B4\u02B9\u02B7\u02BF\u02B6\u02B3\u02B7, false);
			this.\u02C0\u02BD\u02C0\u02C1\u02BA\u02BA\u02B7\u02B4\u02B8\u02B8\u02C0 = true;
			this.\u02B4\u02BA\u02C0\u02B5\u02B9\u02B4\u02BC\u02B7\u02B8\u02BE\u02B2 = 1638f;
		}
	}

	// Token: 0x060002F6 RID: 758 RVA: 0x00029438 File Offset: 0x00027638
	private void \u02B6\u02B3\u02BF\u02BB\u02B5\u02BF\u02B5\u02C0\u02BB\u02B9\u02BD()
	{
		int num = this.\u02C0\u02B4\u02BC\u02BA\u02B4\u02C1\u02BF\u02B3\u02B7\u02B6\u02B6;
		for (int i = 0; i < this.\u02B7\u02B7\u02B4\u02B2\u02BF\u02C0\u02BE\u02B6\u02C0\u02B8\u02B5; i++)
		{
			int numberOfHitNotes = this.\u02B6\u02B7\u02BF\u02BB\u02C1\u02C0\u02B2\u02B2\u02BE\u02B5\u02B5.sectionNotesInfo[num].numberOfHitNotes;
			int numberOfTotalNotes = this.\u02B6\u02B7\u02BF\u02BB\u02C1\u02C0\u02B2\u02B2\u02BE\u02B5\u02B5.sectionNotesInfo[num].numberOfTotalNotes;
			int num2 = (int)((float)numberOfHitNotes / (float)numberOfTotalNotes * 100f);
			this.\u02B3\u02BE\u02B5\u02BF\u02C1\u02BC\u02B7\u02B5\u02BC\u02BB\u02BB[i].\u02B7\u02BE\u02B7\u02B2\u02B9\u02C1\u02BA\u02BD\u02B6\u02B7\u02B6(\u02BD\u02B7\u02B4\u02B2\u02BA\u02C1\u02B9\u02BA\u02B2\u02B2\u02BF.\u02BB\u02B3\u02C0\u02B9\u02B7\u02B4\u02BD\u02B7\u02BF\u02B9\u02C0[num], true);
			this.\u02B6\u02B9\u02C1\u02BA\u02B8\u02BD\u02BF\u02BC\u02B9\u02BB\u02B3[i].text = ((numberOfTotalNotes == 0) ? "N/A" : string.Format("{0}%", num2));
			this.\u02B6\u02B6\u02B3\u02B5\u02BE\u02B5\u02BD\u02C0\u02B3\u02C1\u02B9[i].text = ((numberOfTotalNotes == 0) ? "" : string.Format("{0:N0}", numberOfTotalNotes - numberOfHitNotes));
			num++;
		}
		for (int j = this.\u02B7\u02B7\u02B4\u02B2\u02BF\u02C0\u02BE\u02B6\u02C0\u02B8\u02B5; j < this.\u02B3\u02BE\u02B5\u02BF\u02C1\u02BC\u02B7\u02B5\u02BC\u02BB\u02BB.Length; j++)
		{
			this.\u02B3\u02BE\u02B5\u02BF\u02C1\u02BC\u02B7\u02B5\u02BC\u02BB\u02BB[j].\u02B7\u02BE\u02B7\u02B2\u02B9\u02C1\u02BA\u02BD\u02B6\u02B7\u02B6("", true);
			this.\u02BB\u02BD\u02C1\u02C0\u02C1\u02BF\u02B5\u02B6\u02BF\u02C1\u02C1[j].enabled = false;
			this.\u02B6\u02B6\u02B3\u02B5\u02BE\u02B5\u02BD\u02C0\u02B3\u02C1\u02B9[j].text = "";
			this.\u02B6\u02B9\u02C1\u02BA\u02B8\u02BD\u02BF\u02BC\u02B9\u02BB\u02B3[j].text = "";
		}
		bool flag = this.\u02C0\u02B4\u02BC\u02BA\u02B4\u02C1\u02BF\u02B3\u02B7\u02B6\u02B6 % 2 == 0;
		for (int k = 0; k < this.\u02BB\u02BD\u02C1\u02C0\u02C1\u02BF\u02B5\u02B6\u02BF\u02C1\u02C1.Length; k++)
		{
			this.\u02BB\u02BD\u02C1\u02C0\u02C1\u02BF\u02B5\u02B6\u02BF\u02C1\u02C1[k].enabled = k % 2 == (flag ? 1 : 0);
		}
	}

	// Token: 0x060002F7 RID: 759 RVA: 0x000295B4 File Offset: 0x000277B4
	protected override void Update()
	{
		this.\u02BE\u02B2\u02BA\u02BF\u02BE\u02B8\u02B9\u02BF\u02C0\u02BE\u02B4();
		if (CHNetManager.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B4\u02BA\u02B8\u02B6\u02BB\u02B5\u02B2\u02B8\u02B6\u02BB\u02BB && this.\u02C0\u02B8\u02B7\u02BE\u02BC\u02C1\u02B2\u02BF\u02BA\u02B5\u02B4 < 2f)
		{
			this.\u02C0\u02B8\u02B7\u02BE\u02BC\u02C1\u02B2\u02BF\u02BA\u02B5\u02B4 += Time.deltaTime;
			return;
		}
		if (this.\u02BA\u02BD\u02BD\u02BB\u02BB\u02BA\u02B2\u02B6\u02BA\u02BA\u02C1 && this.\u02BB\u02B7\u02B7\u02B5\u02B2\u02BA\u02B9\u02C1\u02B2\u02BF\u02BD && !this.drumsOptionsMenu.\u02BF\u02C1\u02B2\u02C1\u02B4\u02B8\u02BF\u02C1\u02C1\u02B9\u02B8)
		{
			base.Update();
		}
		this.\u02B4\u02BE\u02B5\u02B5\u02BF\u02B8\u02BC\u02B4\u02BE\u02B8\u02C1();
	}

	// Token: 0x060002F8 RID: 760 RVA: 0x0002961C File Offset: 0x0002781C
	private void \u02B9\u02B5\u02BA\u02BF\u02BF\u02BF\u02B7\u02B9\u02BD\u02B6\u02BF()
	{
		Instrument instrument = this.\u02B4\u02B2\u02B3\u02B2\u02B2\u02B4\u02BD\u02BE\u02B8\u02BB\u02B4.playerInfo.instrument;
		if (instrument == Instrument.None)
		{
			this.\u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF.gameObject.SetActive(false);
			this.\u02BA\u02B7\u02B5\u02BA\u02B9\u02B3\u02C1\u02B2\u02BB\u02B4\u02B4.gameObject.SetActive(true);
			this.\u02BA\u02B7\u02B5\u02BA\u02B9\u02B3\u02C1\u02B2\u02BB\u02B4\u02B4.text = \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6("No Part");
		}
		else
		{
			this.\u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF.sprite = this.\u02B2\u02B7\u02B7\u02BE\u02C1\u02BB\u02B8\u02B6\u02B5\u02B5\u02B9[(int)instrument];
			this.\u02BA\u02B7\u02B5\u02BA\u02B9\u02B3\u02C1\u02B2\u02BB\u02B4\u02B4.gameObject.SetActive(false);
		}
		this.\u02BB\u02C0\u02B6\u02B5\u02BE\u02B9\u02BC\u02B9\u02B7\u02BB\u02BD.text = (this.\u02B4\u02B2\u02B3\u02B2\u02B2\u02B4\u02BD\u02BE\u02B8\u02BB\u02B4.\u02C0\u02B5\u02B2\u02B2\u02BB\u02B8\u02B8\u02BD\u02B9\u02BD\u02C1() ? ("<color=#00FFFF>" + this.\u02B4\u02B2\u02B3\u02B2\u02B2\u02B4\u02BD\u02BE\u02B8\u02BB\u02B4.playerInfo.playerName.CurrentValueNoTags + "</color>") : this.\u02B4\u02B2\u02B3\u02B2\u02B2\u02B4\u02BD\u02BE\u02B8\u02BB\u02B4.playerInfo.playerName.CurrentValue);
		if (this.\u02B4\u02B2\u02B3\u02B2\u02B2\u02B4\u02BD\u02BE\u02B8\u02BB\u02B4.\u02BD\u02BC\u02B8\u02B5\u02B5\u02B2\u02C0\u02C1\u02B3\u02C0\u02B4)
		{
			this.\u02BB\u02C0\u02B6\u02B5\u02BE\u02B9\u02BC\u02B9\u02B7\u02BB\u02BD.color = Color.green;
		}
		else if (this.\u02B4\u02B2\u02B3\u02B2\u02B2\u02B4\u02BD\u02BE\u02B8\u02BB\u02B4.\u02C0\u02B5\u02B2\u02B2\u02BB\u02B8\u02B8\u02BD\u02B9\u02BD\u02C1())
		{
			this.\u02BB\u02C0\u02B6\u02B5\u02BE\u02B9\u02BC\u02B9\u02B7\u02BB\u02BD.color = Color.cyan;
		}
		this.\u02B5\u02BD\u02C0\u02C1\u02BF\u02BF\u02B7\u02BF\u02B6\u02C1\u02BA.text = ((instrument != Instrument.None) ? this.\u02B4\u02B2\u02B3\u02B2\u02B2\u02B4\u02BD\u02BE\u02B8\u02BB\u02B4.playerInfo.difficulty.ToString() : "");
		this.\u02BC\u02BC\u02C1\u02B4\u02BF\u02B8\u02BF\u02B2\u02BA\u02B3\u02B5.text = string.Format("{0:n0}", this.\u02B6\u02B7\u02BF\u02BB\u02C1\u02C0\u02B2\u02B2\u02BE\u02B5\u02B5.TotalScore);
		if (this.\u02B6\u02B7\u02BF\u02BB\u02C1\u02C0\u02B2\u02B2\u02BE\u02B5\u02B5.IsFC)
		{
			this.\u02B2\u02B3\u02C0\u02BB\u02BF\u02BD\u02B4\u02B3\u02B5\u02B3\u02B9.enabled = true;
			this.\u02BD\u02B7\u02B2\u02BA\u02BF\u02B7\u02BF\u02B7\u02BF\u02BD\u02B9.text = "";
		}
		else
		{
			this.\u02BD\u02B7\u02B2\u02BA\u02BF\u02B7\u02BF\u02B7\u02BF\u02BD\u02B9.text = ((instrument != Instrument.None) ? this.\u02B6\u02B7\u02BF\u02BB\u02C1\u02C0\u02B2\u02B2\u02BE\u02B5\u02B5.AccuracyString : (this.\u02BD\u02B7\u02B2\u02BA\u02BF\u02B7\u02BF\u02B7\u02BF\u02BD\u02B9.text = ""));
		}
		for (int i = 6 - this.\u02B6\u02B7\u02BF\u02BB\u02C1\u02C0\u02B2\u02B2\u02BE\u02B5\u02B5.stars; i >= 0; i--)
		{
			global::UnityEngine.Object.Destroy(this.\u02B4\u02C0\u02BB\u02B6\u02B5\u02B6\u02BE\u02B2\u02B8\u02BE\u02B9[i]);
		}
	}

	// Token: 0x060002F9 RID: 761 RVA: 0x00029804 File Offset: 0x00027A04
	protected override void OnEnable()
	{
		float num = (float)Mathf.Clamp(this.\u02BB\u02B3\u02C0\u02BC\u02BF\u02BD\u02B9\u02B2\u02BC\u02BE\u02B7, 0, 3) * this.scrollPageAmount;
		num += (float)Mathf.Clamp(this.\u02BB\u02B3\u02C0\u02BC\u02BF\u02BD\u02B9\u02B2\u02BC\u02BE\u02B7 - 3, 0, int.MaxValue);
		this.scrollTransform.localPosition = new Vector2(0f, num);
		base.OnEnable();
	}

	// Token: 0x060002FA RID: 762 RVA: 0x00029860 File Offset: 0x00027A60
	private void \u02B7\u02B6\u02B7\u02C1\u02B7\u02BB\u02BB\u02B8\u02B6\u02B2\u02B9()
	{
		for (int i = 0; i < this.menuOptions.Length; i++)
		{
			this.menuOptions[i].color = ((i == this.\u02B9\u02BA\u02B9\u02C1\u02B6\u02BB\u02C0\u02B3\u02B7\u02B8\u02B2) ? this.highlightColor : this.defaultColor);
		}
		this.selectionTransform.localPosition = new Vector2(0f, (float)(25 - this.\u02B9\u02BA\u02B9\u02C1\u02B6\u02BB\u02C0\u02B3\u02B7\u02B8\u02B2 * 50));
	}

	// Token: 0x17000029 RID: 41
	// (get) Token: 0x060002FB RID: 763 RVA: 0x0000776C File Offset: 0x0000596C
	public bool \u02BC\u02BF\u02B4\u02BE\u02B2\u02B6\u02B7\u02B5\u02BD\u02BC\u02B6
	{
		get
		{
			return this.\u02BE\u02BA\u02BD\u02B5\u02BE\u02C0\u02B7\u02B3\u02BA\u02B4\u02BD == PlayerStatsBox.\u02B5\u02B7\u02BB\u02B5\u02B3\u02B2\u02BA\u02B7\u02B8\u02B9\u02C1.Ready;
		}
	}

	// Token: 0x060002FC RID: 764 RVA: 0x000298CC File Offset: 0x00027ACC
	public override void \u02B5\u02C1\u02BA\u02BB\u02B2\u02B9\u02C1\u02BB\u02B9\u02BA\u02B3()
	{
		if (this.\u02BE\u02BA\u02BD\u02B5\u02BE\u02C0\u02B7\u02B3\u02BA\u02B4\u02BD == PlayerStatsBox.\u02B5\u02B7\u02BB\u02B5\u02B3\u02B2\u02BA\u02B7\u02B8\u02B9\u02C1.Ready)
		{
			return;
		}
		base.\u02B5\u02C1\u02BA\u02BB\u02B2\u02B9\u02C1\u02BB\u02B9\u02BA\u02B3();
		if (this.\u02B2\u02BF\u02BD\u02C0\u02B3\u02BD\u02BA\u02B5\u02BF\u02B8\u02B3)
		{
			if (this.\u02BE\u02BA\u02BD\u02B5\u02BE\u02C0\u02B7\u02B3\u02BA\u02B4\u02BD == PlayerStatsBox.\u02B5\u02B7\u02BB\u02B5\u02B3\u02B2\u02BA\u02B7\u02B8\u02B9\u02C1.Quitting)
			{
				if (this.\u02B9\u02BA\u02B9\u02C1\u02B6\u02BB\u02C0\u02B3\u02B7\u02B8\u02B2 == 0)
				{
					if (CHNetManager.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B4\u02BA\u02B8\u02B6\u02BB\u02B5\u02B2\u02B8\u02B6\u02BB\u02BB)
					{
						if (this.\u02BC\u02BE\u02C1\u02B8\u02BE\u02C1\u02BE\u02BF\u02BC\u02BC\u02BA)
						{
							\u02B3\u02B7\u02B4\u02BE\u02BE\u02C1\u02BE\u02BB\u02B2\u02B9\u02BA.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02C1\u02B9\u02B2\u02C1\u02BC\u02B2\u02B8\u02BC\u02BF\u02B9\u02BE();
							return;
						}
					}
					else
					{
						GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B9\u02B4\u02BC\u02B8\u02B7\u02C0\u02BB\u02B9\u02B9\u02B5\u02C0 = true;
						FadeBehaviour.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BB\u02B2\u02BF\u02B4\u02BA\u02B3\u02C1\u02B7\u02B6\u02B5\u02BE("Main Menu", 0f);
					}
				}
				else
				{
					this.\u02B9\u02B7\u02B3\u02BD\u02B3\u02B6\u02B9\u02B3\u02BF\u02B8\u02B7();
				}
			}
			else if (this.\u02BE\u02BA\u02BD\u02B5\u02BE\u02C0\u02B7\u02B3\u02BA\u02B4\u02BD == PlayerStatsBox.\u02B5\u02B7\u02BB\u02B5\u02B3\u02B2\u02BA\u02B7\u02B8\u02B9\u02C1.Readying)
			{
				int u02B9_u02BA_u02B9_u02C1_u02B6_u02BB_u02C0_u02B3_u02B7_u02B8_u02B = this.\u02B9\u02BA\u02B9\u02C1\u02B6\u02BB\u02C0\u02B3\u02B7\u02B8\u02B2;
				if (u02B9_u02BA_u02B9_u02C1_u02B6_u02BB_u02C0_u02B3_u02B7_u02B8_u02B != 0)
				{
					if (u02B9_u02BA_u02B9_u02C1_u02B6_u02BB_u02C0_u02B3_u02B7_u02B8_u02B == 1)
					{
						this.\u02B2\u02B3\u02B7\u02C1\u02B4\u02BE\u02C1\u02B2\u02C1\u02BC\u02B2();
					}
				}
				else
				{
					this.\u02BB\u02B7\u02B7\u02B5\u02B2\u02BA\u02B9\u02C1\u02B2\u02BF\u02BD = false;
					this.statsMenu.SetActive(false);
					this.playerSelectionMenu.gameObject.SetActive(true);
				}
			}
		}
		else if (GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B7\u02B7\u02B9\u02B6\u02B6\u02B8\u02C1\u02BA\u02BA\u02C0\u02B8)
		{
			this.\u02C0\u02B9\u02BB\u02BC\u02BF\u02B5\u02C0\u02B3\u02B5\u02BD\u02BC(false);
		}
		else
		{
			this.\u02B2\u02B3\u02B7\u02C1\u02B4\u02BE\u02C1\u02B2\u02C1\u02BC\u02B2();
		}
		if (this.\u02BC\u02BE\u02C1\u02B8\u02BE\u02C1\u02BE\u02BF\u02BC\u02BC\u02BA)
		{
			\u02B3\u02B7\u02B4\u02BE\u02BE\u02C1\u02BE\u02BB\u02B2\u02B9\u02BA.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BF\u02B9\u02C0\u02BF\u02BA\u02BA\u02B2\u02BA\u02B8\u02B5\u02BC(0);
		}
	}

	// Token: 0x060002FD RID: 765 RVA: 0x000299C4 File Offset: 0x00027BC4
	private void \u02C0\u02B9\u02BB\u02BC\u02BF\u02B5\u02C0\u02B3\u02B5\u02BD\u02BC(bool \u02BF\u02BB\u02B8\u02B8\u02B4\u02B4\u02B6\u02C0\u02BD\u02B7\u02C1)
	{
		if (CHNetManager.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B4\u02BA\u02B8\u02B6\u02BB\u02B5\u02B2\u02B8\u02B6\u02BB\u02BB && this.\u02BE\u02BA\u02BD\u02B5\u02BE\u02C0\u02B7\u02B3\u02BA\u02B4\u02BD == PlayerStatsBox.\u02B5\u02B7\u02BB\u02B5\u02B3\u02B2\u02BA\u02B7\u02B8\u02B9\u02C1.Ready && !\u02BF\u02BB\u02B8\u02B8\u02B4\u02B4\u02B6\u02C0\u02BD\u02B7\u02C1)
		{
			return;
		}
		\u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0 u02BD_u02B5_u02B7_u02C0_u02BF_u02BA_u02B5_u02B9_u02BD_u02B6_u02C = \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6;
		this.menuOptions[0].text = u02BD_u02B5_u02B7_u02C0_u02BF_u02BA_u02B5_u02B9_u02BD_u02B6_u02C.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6("Yes");
		this.menuOptions[1].text = u02BD_u02B5_u02B7_u02C0_u02BF_u02BA_u02B5_u02B9_u02BD_u02B6_u02C.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6("No");
		this.notSupportedText.text = "";
		this.menuObject.SetActive(true);
		this.\u02B9\u02BA\u02B9\u02C1\u02B6\u02BB\u02C0\u02B3\u02B7\u02B8\u02B2 = 0;
		this.\u02B2\u02BF\u02BD\u02C0\u02B3\u02BD\u02BA\u02B5\u02BF\u02B8\u02B3 = true;
		if (\u02BF\u02BB\u02B8\u02B8\u02B4\u02B4\u02B6\u02C0\u02BD\u02B7\u02C1)
		{
			this.menuText.text = u02BD_u02B5_u02B7_u02C0_u02BF_u02BA_u02B5_u02B9_u02BD_u02B6_u02C.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6("Are you sure you want to quit?");
			this.\u02BE\u02BA\u02BD\u02B5\u02BE\u02C0\u02B7\u02B3\u02BA\u02B4\u02BD = PlayerStatsBox.\u02B5\u02B7\u02BB\u02B5\u02B3\u02B2\u02BA\u02B7\u02B8\u02B9\u02C1.Quitting;
			this.\u02BC\u02BA\u02BC\u02B6\u02BA\u02B5\u02B6\u02BB\u02C1\u02BF\u02B7 = 1;
		}
		else
		{
			this.menuText.text = \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6("playerchange");
			this.\u02BE\u02BA\u02BD\u02B5\u02BE\u02C0\u02B7\u02B3\u02BA\u02B4\u02BD = PlayerStatsBox.\u02B5\u02B7\u02BB\u02B5\u02B3\u02B2\u02BA\u02B7\u02B8\u02B9\u02C1.Readying;
			this.\u02B9\u02BA\u02B9\u02C1\u02B6\u02BB\u02C0\u02B3\u02B7\u02B8\u02B2 = 0;
			this.\u02BC\u02BA\u02BC\u02B6\u02BA\u02B5\u02B6\u02BB\u02C1\u02BF\u02B7 = 1;
			if (!\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02B4\u02BE\u02B5\u02B6\u02BB\u02B4\u02B6\u02B9\u02B5\u02B7\u02BD[GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B5\u02B8\u02B8\u02B6\u02BC\u02BC\u02B6\u02BA\u02B7\u02BE\u02B7 + 1].charts.\u02B3\u02B2\u02B6\u02BA\u02B2\u02BC\u02C0\u02BA\u02B9\u02BE\u02B8(this.\u02B4\u02B2\u02B3\u02B2\u02B2\u02B4\u02BD\u02BE\u02B8\u02BB\u02B4.playerInfo.instrument, this.\u02B4\u02B2\u02B3\u02B2\u02B2\u02B4\u02BD\u02BE\u02B8\u02BB\u02B4.playerInfo.difficulty))
			{
				this.\u02B9\u02BA\u02B9\u02C1\u02B6\u02BB\u02C0\u02B3\u02B7\u02B8\u02B2 = 0;
				this.notSupportedText.text = u02BD_u02B5_u02B7_u02C0_u02BF_u02BA_u02B5_u02B9_u02BD_u02B6_u02C.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6("playernotsupported");
			}
		}
		this.\u02B7\u02B6\u02B7\u02C1\u02B7\u02BB\u02BB\u02B8\u02B6\u02B2\u02B9();
	}

	// Token: 0x060002FE RID: 766 RVA: 0x00007777 File Offset: 0x00005977
	private void \u02B9\u02B7\u02B3\u02BD\u02B3\u02B6\u02B9\u02B3\u02BF\u02B8\u02B7()
	{
		this.menuObject.SetActive(false);
		this.\u02B2\u02BF\u02BD\u02C0\u02B3\u02BD\u02BA\u02B5\u02BF\u02B8\u02B3 = false;
	}

	// Token: 0x060002FF RID: 767 RVA: 0x00029B0C File Offset: 0x00027D0C
	private void \u02BA\u02B4\u02B2\u02BD\u02B4\u02C0\u02BF\u02BD\u02BA\u02BB\u02B9()
	{
		int i = 0;
		if (this.\u02B4\u02B2\u02B3\u02B2\u02B2\u02B4\u02BD\u02BE\u02B8\u02BB\u02B4.playerInfo.IsGamepadMode())
		{
			i += 0;
			global::UnityEngine.Object.Instantiate<GameObject>(this.modifierElement, this.modifierGroupTransform).GetComponent<ModifierFlowElement>().\u02B7\u02B3\u02B3\u02BF\u02C0\u02BE\u02B6\u02B3\u02B2\u02B7\u02BC(1, this.\u02B4\u02B2\u02B3\u02B2\u02B2\u02B4\u02BD\u02BE\u02B8\u02BB\u02B4.playerInfo.instrument);
		}
		while (i <= 93)
		{
			if (this.\u02B4\u02B2\u02B3\u02B2\u02B2\u02B4\u02BD\u02BE\u02B8\u02BB\u02B4.playerInfo.HasModifier((Modifier)i))
			{
				global::UnityEngine.Object.Instantiate<GameObject>(this.modifierElement, this.modifierGroupTransform).GetComponent<ModifierFlowElement>().\u02B2\u02BA\u02B7\u02B4\u02B6\u02BD\u02B7\u02B4\u02BC\u02C0\u02B3(i, this.\u02B4\u02B2\u02B3\u02B2\u02B2\u02B4\u02BD\u02BE\u02B8\u02BB\u02B4.playerInfo.instrument);
			}
			i *= 1;
		}
	}

	// Token: 0x06000300 RID: 768 RVA: 0x00029BAC File Offset: 0x00027DAC
	public void \u02B6\u02C0\u02C1\u02BB\u02B8\u02B7\u02B9\u02C1\u02B2\u02BC\u02B6(string \u02BB\u02B2\u02BD\u02B9\u02B9\u02B6\u02C0\u02B5\u02B8\u02BA\u02BF)
	{
		this.\u02BB\u02B3\u02C0\u02BC\u02BF\u02BD\u02B9\u02B2\u02BC\u02BE\u02B7 = 4;
		this.\u02BB\u02B7\u02B7\u02B5\u02B2\u02BA\u02B9\u02C1\u02B2\u02BF\u02BD = false;
		this.finishText.text = \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6(\u02BB\u02B2\u02BD\u02B9\u02B9\u02B6\u02C0\u02B5\u02B8\u02BA\u02BF);
		this.menuObject.SetActive(false);
		if (\u02BB\u02B2\u02BD\u02B9\u02B9\u02B6\u02C0\u02B5\u02B8\u02BA\u02BF == "Ready")
		{
			this.\u02BE\u02BA\u02BD\u02B5\u02BE\u02C0\u02B7\u02B3\u02BA\u02B4\u02BD = PlayerStatsBox.\u02B5\u02B7\u02BB\u02B5\u02B3\u02B2\u02BA\u02B7\u02B8\u02B9\u02C1.Ready;
		}
		this.\u02B2\u02BF\u02BD\u02C0\u02B3\u02BD\u02BA\u02B5\u02BF\u02B8\u02B3 = false;
		this.\u02B6\u02C1\u02BF\u02C0\u02B8\u02BF\u02BE\u02BF\u02B8\u02B2\u02B8();
	}

	// Token: 0x06000301 RID: 769 RVA: 0x00029C0C File Offset: 0x00027E0C
	private void \u02B7\u02B7\u02BC\u02B4\u02BD\u02BE\u02C0\u02B8\u02B3\u02B2\u02B2()
	{
		if (this.\u02B7\u02BF\u02BD\u02B7\u02B4\u02B9\u02B2\u02C1\u02BA\u02B3\u02BE)
		{
			float num = (Time.realtimeSinceStartup - this.\u02B5\u02B4\u02BE\u02BC\u02B3\u02B5\u02B4\u02BE\u02C0\u02B7\u02BD) / this.scrollTime;
			if (num > 822f)
			{
				num = 695f;
				this.\u02B7\u02BF\u02BD\u02B7\u02B4\u02B9\u02B2\u02C1\u02BA\u02B3\u02BE = false;
				this.\u02BB\u02B7\u02B7\u02B5\u02B2\u02BA\u02B9\u02C1\u02B2\u02BF\u02BD = true;
			}
			this.scrollTransform.localPosition = Vector3.Lerp(this.\u02C0\u02BB\u02BE\u02BF\u02B6\u02B9\u02B3\u02B5\u02C0\u02BB\u02BA, this.\u02BE\u02BD\u02B4\u02B4\u02B9\u02BF\u02BE\u02B9\u02B6\u02BB\u02BA, num);
		}
	}

	// Token: 0x06000302 RID: 770 RVA: 0x00029C70 File Offset: 0x00027E70
	private void \u02B5\u02B8\u02BD\u02BA\u02BF\u02BB\u02B5\u02B4\u02BE\u02BA\u02B3()
	{
		\u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0 u02BD_u02B5_u02B7_u02C0_u02BF_u02BA_u02B5_u02B9_u02BD_u02B6_u02C = \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C0\u02B4\u02BE\u02B9\u02C1\u02B8\u02B2\u02B3\u02BE\u02BD\u02B9();
		this.headerTexts[0].text = u02BD_u02B5_u02B7_u02C0_u02BF_u02BA_u02B5_u02B9_u02BD_u02B6_u02C.\u02BB\u02B9\u02BB\u02B8\u02B3\u02B2\u02B5\u02B6\u02B4\u02B2\u02B4("Menu Music");
		this.headerTexts[0].text = u02BD_u02B5_u02B7_u02C0_u02BF_u02BA_u02B5_u02B9_u02BD_u02B6_u02C.\u02B5\u02BA\u02BE\u02B9\u02BD\u02B3\u02BB\u02B6\u02B8\u02BD\u02C0("sp_awarded");
		this.headerTexts[2].text = u02BD_u02B5_u02B7_u02C0_u02BF_u02BA_u02B5_u02B9_u02BD_u02B6_u02C.\u02B9\u02BC\u02BD\u02BE\u02BA\u02C0\u02BC\u02C1\u02BD\u02B3\u02BD("Quick Setup");
		this.headerTexts[4].text = u02BD_u02B5_u02B7_u02C0_u02BF_u02BA_u02B5_u02B9_u02BD_u02B6_u02C.\u02BB\u02B9\u02BB\u02B8\u02B3\u02B2\u02B5\u02B6\u02B4\u02B2\u02B4("song");
		this.headerTexts[3].text = u02BD_u02B5_u02B7_u02C0_u02BF_u02BA_u02B5_u02B9_u02BD_u02B6_u02C.\u02B5\u02BA\u02BE\u02B9\u02BD\u02B3\u02BB\u02B6\u02B8\u02BD\u02C0("");
		this.statsNameTexts[1].text = u02BD_u02B5_u02B7_u02C0_u02BF_u02BA_u02B5_u02B9_u02BD_u02B6_u02C.\u02B9\u02BC\u02BD\u02BE\u02BA\u02C0\u02BC\u02C1\u02BD\u02B3\u02BD("Change visible instrument scores");
		this.statsNameTexts[0].text = u02BD_u02B5_u02B7_u02C0_u02BF_u02BA_u02B5_u02B9_u02BD_u02B6_u02C.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6("Medium");
		this.statsNameTexts[2].text = u02BD_u02B5_u02B7_u02C0_u02BF_u02BA_u02B5_u02B9_u02BD_u02B6_u02C.\u02BB\u02B9\u02BB\u02B8\u02B3\u02B2\u02B5\u02B6\u02B4\u02B2\u02B4("General");
		this.statsNameTexts[5].text = u02BD_u02B5_u02B7_u02C0_u02BF_u02BA_u02B5_u02B9_u02BD_u02B6_u02C.\u02B9\u02BC\u02BD\u02BE\u02BA\u02C0\u02BC\u02C1\u02BD\u02B3\u02BD("Save Playlist");
		this.statsNameTexts[6].text = u02BD_u02B5_u02B7_u02C0_u02BF_u02BA_u02B5_u02B9_u02BD_u02B6_u02C.\u02B5\u02BA\u02BE\u02B9\u02BD\u02B3\u02BB\u02B6\u02B8\u02BD\u02C0("Kick Pad");
		this.statsNameTexts[7].text = u02BD_u02B5_u02B7_u02C0_u02BF_u02BA_u02B5_u02B9_u02BD_u02B6_u02C.\u02B5\u02BA\u02BE\u02B9\u02BD\u02B3\u02BB\u02B6\u02B8\u02BD\u02C0("lyric ");
		this.statsNameTexts[6].text = u02BD_u02B5_u02B7_u02C0_u02BF_u02BA_u02B5_u02B9_u02BD_u02B6_u02C.\u02B5\u02BA\u02BE\u02B9\u02BD\u02B3\u02BB\u02B6\u02B8\u02BD\u02C0("Speed");
		this.statsNameTexts[2].text = u02BD_u02B5_u02B7_u02C0_u02BF_u02BA_u02B5_u02B9_u02BD_u02B6_u02C.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6("");
		this.statsNameTexts[21].text = u02BD_u02B5_u02B7_u02C0_u02BF_u02BA_u02B5_u02B9_u02BD_u02B6_u02C.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6("Drum Pad Scrolling");
		if (this.\u02B6\u02B9\u02B7\u02B6\u02B9\u02B2\u02BE\u02BE\u02BE\u02B2\u02B5)
		{
			this.statsNameTexts[2].text = u02BD_u02B5_u02B7_u02C0_u02BF_u02BA_u02B5_u02B9_u02BD_u02B6_u02C.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6("Scan Songs");
			this.statsNameTexts[83].text = u02BD_u02B5_u02B7_u02C0_u02BF_u02BA_u02B5_u02B9_u02BD_u02B6_u02C.\u02B5\u02BA\u02BE\u02B9\u02BD\u02B3\u02BB\u02B6\u02B8\u02BD\u02C0("soloend");
			this.statsNameTexts[-127].text = u02BD_u02B5_u02B7_u02C0_u02BF_u02BA_u02B5_u02B9_u02BD_u02B6_u02C.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6("scoredata.bin");
			this.statsNameTexts[93].text = u02BD_u02B5_u02B7_u02C0_u02BF_u02BA_u02B5_u02B9_u02BD_u02B6_u02C.\u02B9\u02BC\u02BD\u02BE\u02BA\u02C0\u02BC\u02C1\u02BD\u02B3\u02BD("diff_keys");
			this.statsNameTexts[1].text = u02BD_u02B5_u02B7_u02C0_u02BF_u02BA_u02B5_u02B9_u02BD_u02B6_u02C.\u02BB\u02B9\u02BB\u02B8\u02B3\u02B2\u02B5\u02B6\u02B4\u02B2\u02B4("Are you sure?");
		}
		else
		{
			this.statsNameTexts[3].text = u02BD_u02B5_u02B7_u02C0_u02BF_u02BA_u02B5_u02B9_u02BD_u02B6_u02C.\u02BB\u02B9\u02BB\u02B8\u02B3\u02B2\u02B5\u02B6\u02B4\u02B2\u02B4("Default");
			this.statsNameTexts[125].text = u02BD_u02B5_u02B7_u02C0_u02BF_u02BA_u02B5_u02B9_u02BD_u02B6_u02C.\u02B9\u02BC\u02BD\u02BE\u02BA\u02C0\u02BC\u02C1\u02BD\u02B3\u02BD("HOPO's to Taps");
			this.statsNameTexts[-124].text = "artist";
			this.statsNameTexts[35].text = u02BD_u02B5_u02B7_u02C0_u02BF_u02BA_u02B5_u02B9_u02BD_u02B6_u02C.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6("Quit");
			this.statsNameTexts[13].text = "Video Start Time";
		}
		this.statsNameTexts[48].text = u02BD_u02B5_u02B7_u02C0_u02BF_u02BA_u02B5_u02B9_u02BD_u02B6_u02C.\u02B9\u02BC\u02BD\u02BE\u02BA\u02C0\u02BC\u02C1\u02BD\u02B3\u02BD(" - ");
		this.statsNameTexts[-34].text = u02BD_u02B5_u02B7_u02C0_u02BF_u02BA_u02B5_u02B9_u02BD_u02B6_u02C.\u02B9\u02BC\u02BD\u02BE\u02BA\u02C0\u02BC\u02C1\u02BD\u02B3\u02BD("hasProDrums");
		this.statsNameTexts[108].text = u02BD_u02B5_u02B7_u02C0_u02BF_u02BA_u02B5_u02B9_u02BD_u02B6_u02C.\u02B9\u02BC\u02BD\u02BE\u02BA\u02C0\u02BC\u02C1\u02BD\u02B3\u02BD("Background Video");
		this.statsNameTexts[-18].text = u02BD_u02B5_u02B7_u02C0_u02BF_u02BA_u02B5_u02B9_u02BD_u02B6_u02C.\u02B9\u02BC\u02BD\u02BE\u02BA\u02C0\u02BC\u02C1\u02BD\u02B3\u02BD("Artist - Album");
	}

	// Token: 0x06000303 RID: 771 RVA: 0x00029F30 File Offset: 0x00028130
	public virtual void \u02B8\u02B3\u02B9\u02BD\u02BF\u02BE\u02BE\u02B2\u02BB\u02BE\u02C0()
	{
		this.\u02BA\u02B8\u02B2\u02C1\u02BF\u02C0\u02BD\u02C0\u02B4\u02B4\u02B2 = false;
		if (CHNetManager.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02C1\u02BB\u02B7\u02B6\u02B9\u02B5\u02BC\u02B2\u02BB\u02B2\u02BD() && this.\u02BE\u02BA\u02BD\u02B5\u02BE\u02C0\u02B7\u02B3\u02BA\u02B4\u02BD == PlayerStatsBox.\u02B5\u02B7\u02BB\u02B5\u02B3\u02B2\u02BA\u02B7\u02B8\u02B9\u02C1.Ready)
		{
			return;
		}
		if (this.\u02B2\u02BF\u02BD\u02C0\u02B3\u02BD\u02BA\u02B5\u02BF\u02B8\u02B3)
		{
			this.\u02B9\u02B7\u02B3\u02BD\u02B3\u02B6\u02B9\u02B3\u02BF\u02B8\u02B7();
			BassAudioManager.Instance.PlaySoundExternal((SoundID)(-104));
		}
		else if (GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BC\u02B6\u02BA\u02BF\u02B2\u02C1\u02B3\u02B5\u02B2\u02B5\u02B6)
		{
			this.\u02C0\u02B9\u02BB\u02BC\u02BF\u02B5\u02C0\u02B3\u02B5\u02BD\u02BC(false);
		}
		if (this.\u02BC\u02BE\u02C1\u02B8\u02BE\u02C1\u02BE\u02BF\u02BC\u02BC\u02BA)
		{
			\u02B3\u02B7\u02B4\u02BE\u02BE\u02C1\u02BE\u02BB\u02B2\u02B9\u02BA.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BF\u02B9\u02C0\u02BF\u02BA\u02BA\u02B2\u02BA\u02B8\u02B5\u02BC(0);
		}
	}

	// Token: 0x06000304 RID: 772 RVA: 0x00029F9C File Offset: 0x0002819C
	protected virtual void \u02B4\u02BA\u02BE\u02BB\u02B5\u02BB\u02C1\u02B2\u02B4\u02B2\u02BF()
	{
		this.scrollTransform.localPosition = Vector2.zero;
		this.\u02B6\u02B9\u02B6\u02B4\u02BF\u02B4\u02C1\u02BF\u02BC\u02B8\u02B6 = 5;
		this.\u02BB\u02B7\u02B7\u02B5\u02B2\u02BA\u02B9\u02C1\u02B2\u02BF\u02BD = true;
		this.\u02B9\u02B5\u02BA\u02BF\u02BF\u02BF\u02B7\u02B9\u02BD\u02B6\u02BF();
		this.\u02B5\u02B8\u02BD\u02BA\u02BF\u02BB\u02B5\u02B4\u02BE\u02BA\u02B3();
		this.\u02BB\u02B3\u02BC\u02B7\u02B8\u02B7\u02BB\u02BF\u02BA\u02B8\u02B8();
		this.\u02B4\u02C1\u02BE\u02B9\u02B2\u02B8\u02B4\u02B3\u02BB\u02B6\u02B4();
		int num = \u02BD\u02B7\u02B4\u02B2\u02BA\u02C1\u02B9\u02BA\u02B2\u02B2\u02BF.\u02BB\u02B3\u02C0\u02B9\u02B7\u02B4\u02BD\u02B7\u02BF\u02B9\u02C0.Length;
		this.\u02B7\u02B7\u02B4\u02B2\u02BF\u02C0\u02BE\u02B6\u02C0\u02B8\u02B5 = Mathf.Clamp(num, 1, this.\u02B3\u02BE\u02B5\u02BF\u02C1\u02BC\u02B7\u02B5\u02BC\u02BB\u02BB.Length);
		this.\u02B6\u02B2\u02BF\u02B6\u02B8\u02BD\u02C1\u02BB\u02BC\u02B3\u02B4 = ((num > this.\u02B7\u02B7\u02B4\u02B2\u02BF\u02C0\u02BE\u02B6\u02C0\u02B8\u02B5) ? (num - this.\u02B7\u02B7\u02B4\u02B2\u02BF\u02C0\u02BE\u02B6\u02C0\u02B8\u02B5) : 1);
	}

	// Token: 0x06000305 RID: 773 RVA: 0x0002A01C File Offset: 0x0002821C
	protected override void Start()
	{
		this.scrollTransform.localPosition = Vector2.zero;
		this.\u02B6\u02B9\u02B6\u02B4\u02BF\u02B4\u02C1\u02BF\u02BC\u02B8\u02B6 = 3;
		this.\u02BB\u02B7\u02B7\u02B5\u02B2\u02BA\u02B9\u02C1\u02B2\u02BF\u02BD = true;
		this.\u02B9\u02B5\u02BA\u02BF\u02BF\u02BF\u02B7\u02B9\u02BD\u02B6\u02BF();
		this.\u02BD\u02C0\u02B9\u02BF\u02C0\u02B6\u02BD\u02B7\u02BD\u02B6\u02B2();
		this.\u02BB\u02B3\u02BC\u02B7\u02B8\u02B7\u02BB\u02BF\u02BA\u02B8\u02B8();
		this.\u02B4\u02C1\u02BE\u02B9\u02B2\u02B8\u02B4\u02B3\u02BB\u02B6\u02B4();
		int num = \u02BD\u02B7\u02B4\u02B2\u02BA\u02C1\u02B9\u02BA\u02B2\u02B2\u02BF.\u02BB\u02B3\u02C0\u02B9\u02B7\u02B4\u02BD\u02B7\u02BF\u02B9\u02C0.Length;
		this.\u02B7\u02B7\u02B4\u02B2\u02BF\u02C0\u02BE\u02B6\u02C0\u02B8\u02B5 = Mathf.Clamp(num, 1, this.\u02B3\u02BE\u02B5\u02BF\u02C1\u02BC\u02B7\u02B5\u02BC\u02BB\u02BB.Length);
		this.\u02B6\u02B2\u02BF\u02B6\u02B8\u02BD\u02C1\u02BB\u02BC\u02B3\u02B4 = ((num > this.\u02B7\u02B7\u02B4\u02B2\u02BF\u02C0\u02BE\u02B6\u02C0\u02B8\u02B5) ? (num - this.\u02B7\u02B7\u02B4\u02B2\u02BF\u02C0\u02BE\u02B6\u02C0\u02B8\u02B5) : 0);
	}

	// Token: 0x06000306 RID: 774 RVA: 0x0002A09C File Offset: 0x0002829C
	private void \u02B8\u02BA\u02BC\u02B4\u02B4\u02B9\u02BA\u02BC\u02B3\u02BD\u02BE()
	{
		int i = 1;
		if (this.\u02B4\u02B2\u02B3\u02B2\u02B2\u02B4\u02BD\u02BE\u02B8\u02BB\u02B4.playerInfo.IsGamepadMode())
		{
			i++;
			global::UnityEngine.Object.Instantiate<GameObject>(this.modifierElement, this.modifierGroupTransform).GetComponent<ModifierFlowElement>().\u02BC\u02B4\u02B8\u02B2\u02B7\u02B7\u02BB\u02BF\u02BB\u02B6\u02BC(1, this.\u02B4\u02B2\u02B3\u02B2\u02B2\u02B4\u02BD\u02BE\u02B8\u02BB\u02B4.playerInfo.instrument);
		}
		while (i <= -26)
		{
			if (this.\u02B4\u02B2\u02B3\u02B2\u02B2\u02B4\u02BD\u02BE\u02B8\u02BB\u02B4.playerInfo.HasModifier((Modifier)i))
			{
				global::UnityEngine.Object.Instantiate<GameObject>(this.modifierElement, this.modifierGroupTransform).GetComponent<ModifierFlowElement>().\u02C0\u02B8\u02BC\u02BF\u02B5\u02BC\u02BA\u02B3\u02BF\u02BA\u02B4(i, this.\u02B4\u02B2\u02B3\u02B2\u02B2\u02B4\u02BD\u02BE\u02B8\u02BB\u02B4.playerInfo.instrument);
			}
			i *= 3;
		}
	}

	// Token: 0x06000307 RID: 775 RVA: 0x0002A13C File Offset: 0x0002833C
	private void \u02BE\u02B2\u02BA\u02BF\u02BE\u02B8\u02B9\u02BF\u02C0\u02BE\u02B4()
	{
		bool flag = this.\u02BB\u02B3\u02C0\u02BC\u02BF\u02BD\u02B9\u02B2\u02BC\u02BE\u02B7 != 0 && !this.\u02BC\u02BF\u02B4\u02BE\u02B2\u02B6\u02B7\u02B5\u02BD\u02BC\u02B6;
		bool flag2 = (this.\u02BB\u02B3\u02C0\u02BC\u02BF\u02BD\u02B9\u02B2\u02BC\u02BE\u02B7 == 3 && this.\u02C0\u02B4\u02BC\u02BA\u02B4\u02C1\u02BF\u02B3\u02B7\u02B6\u02B6 != this.\u02B6\u02B2\u02BF\u02B6\u02B8\u02BD\u02C1\u02BB\u02BC\u02B3\u02B4) || (this.\u02BB\u02B3\u02C0\u02BC\u02BF\u02BD\u02B9\u02B2\u02BC\u02BE\u02B7 < 3 && !this.\u02BC\u02BF\u02B4\u02BE\u02B2\u02B6\u02B7\u02B5\u02BD\u02BC\u02B6);
		this.scrollArrowDown.gameObject.SetActive(flag2);
		this.scrollArrowUp.gameObject.SetActive(flag);
		this.\u02B4\u02BA\u02C0\u02B5\u02B9\u02B4\u02BC\u02B7\u02B8\u02BE\u02B2 += Time.unscaledDeltaTime;
		if (this.\u02C0\u02BD\u02C0\u02C1\u02BA\u02BA\u02B7\u02B4\u02B8\u02B8\u02C0 && this.\u02B4\u02BA\u02C0\u02B5\u02B9\u02B4\u02BC\u02B7\u02B8\u02BE\u02B2 >= this.\u02B2\u02BE\u02B5\u02BE\u02B5\u02BF\u02B8\u02B2\u02BD\u02B7\u02BD)
		{
			this.scrollArrowDown.CrossFadeAlpha(0.85f, this.\u02B2\u02BE\u02B5\u02BE\u02B5\u02BF\u02B8\u02B2\u02BD\u02B7\u02BD, true);
			this.scrollArrowUp.CrossFadeAlpha(0.85f, this.\u02B2\u02BE\u02B5\u02BE\u02B5\u02BF\u02B8\u02B2\u02BD\u02B7\u02BD, true);
			this.\u02C0\u02BD\u02C0\u02C1\u02BA\u02BA\u02B7\u02B4\u02B8\u02B8\u02C0 = false;
			this.\u02B4\u02BA\u02C0\u02B5\u02B9\u02B4\u02BC\u02B7\u02B8\u02BE\u02B2 = 0f;
			return;
		}
		if (!this.\u02C0\u02BD\u02C0\u02C1\u02BA\u02BA\u02B7\u02B4\u02B8\u02B8\u02C0 && this.\u02B4\u02BA\u02C0\u02B5\u02B9\u02B4\u02BC\u02B7\u02B8\u02BE\u02B2 >= this.\u02B4\u02BB\u02B6\u02B9\u02B4\u02B9\u02B7\u02BF\u02B6\u02B3\u02B7)
		{
			this.scrollArrowDown.CrossFadeAlpha(0.25f, this.\u02B4\u02BB\u02B6\u02B9\u02B4\u02B9\u02B7\u02BF\u02B6\u02B3\u02B7, true);
			this.scrollArrowUp.CrossFadeAlpha(0.25f, this.\u02B4\u02BB\u02B6\u02B9\u02B4\u02B9\u02B7\u02BF\u02B6\u02B3\u02B7, true);
			this.\u02C0\u02BD\u02C0\u02C1\u02BA\u02BA\u02B7\u02B4\u02B8\u02B8\u02C0 = true;
			this.\u02B4\u02BA\u02C0\u02B5\u02B9\u02B4\u02BC\u02B7\u02B8\u02BE\u02B2 = 0f;
		}
	}

	// Token: 0x06000308 RID: 776 RVA: 0x0002A270 File Offset: 0x00028470
	private void \u02B6\u02C1\u02BF\u02C0\u02B8\u02BF\u02BE\u02BF\u02B8\u02B2\u02B8()
	{
		if (this.\u02BB\u02B3\u02C0\u02BC\u02BF\u02BD\u02B9\u02B2\u02BC\u02BE\u02B7 == this.\u02B9\u02B5\u02B4\u02B9\u02BF\u02B6\u02B5\u02C1\u02BB\u02B3\u02B3)
		{
			return;
		}
		this.\u02B5\u02B4\u02BE\u02BC\u02B3\u02B5\u02B4\u02BE\u02C0\u02B7\u02BD = Time.realtimeSinceStartup;
		this.\u02C0\u02BB\u02BE\u02BF\u02B6\u02B9\u02B3\u02B5\u02C0\u02BB\u02BA = this.scrollTransform.localPosition;
		this.\u02B7\u02BF\u02BD\u02B7\u02B4\u02B9\u02B2\u02C1\u02BA\u02B3\u02BE = true;
		this.\u02B9\u02B5\u02B4\u02B9\u02BF\u02B6\u02B5\u02C1\u02BB\u02B3\u02B3 = this.\u02BB\u02B3\u02C0\u02BC\u02BF\u02BD\u02B9\u02B2\u02BC\u02BE\u02B7;
		this.\u02BB\u02B7\u02B7\u02B5\u02B2\u02BA\u02B9\u02C1\u02B2\u02BF\u02BD = false;
		this.\u02BE\u02BD\u02B4\u02B4\u02B9\u02BF\u02BE\u02B9\u02B6\u02BB\u02BA.y = (float)this.\u02BB\u02B3\u02C0\u02BC\u02BF\u02BD\u02B9\u02B2\u02BC\u02BE\u02B7 * this.scrollPageAmount;
	}

	// Token: 0x06000309 RID: 777 RVA: 0x0000778C File Offset: 0x0000598C
	public virtual void \u02C0\u02B6\u02B8\u02B4\u02BA\u02BB\u02BC\u02BD\u02BC\u02BE\u02B2(byte \u02C0\u02B4\u02B4\u02BC\u02BD\u02B2\u02C1\u02C0\u02C1\u02B4\u02C1)
	{
		if (this.playerSelectionMenu.\u02BF\u02C1\u02B2\u02C1\u02B4\u02B8\u02BF\u02C1\u02C1\u02B9\u02B8)
		{
			this.playerSelectionMenu.\u02BF\u02B6\u02BB\u02B4\u02B9\u02BD\u02B9\u02BE\u02BE\u02BE\u02B4(\u02C0\u02B4\u02B4\u02BC\u02BD\u02B2\u02C1\u02C0\u02C1\u02B4\u02C1);
			return;
		}
		base.\u02BF\u02B6\u02BB\u02B4\u02B9\u02BD\u02B9\u02BE\u02BE\u02BE\u02B4(\u02C0\u02B4\u02B4\u02BC\u02BD\u02B2\u02C1\u02C0\u02C1\u02B4\u02C1);
	}

	// Token: 0x0600030A RID: 778 RVA: 0x0002A2DC File Offset: 0x000284DC
	private void \u02B4\u02BE\u02B5\u02B5\u02BF\u02B8\u02BC\u02B4\u02BE\u02B8\u02C1()
	{
		if (this.\u02B7\u02BF\u02BD\u02B7\u02B4\u02B9\u02B2\u02C1\u02BA\u02B3\u02BE)
		{
			float num = (Time.realtimeSinceStartup - this.\u02B5\u02B4\u02BE\u02BC\u02B3\u02B5\u02B4\u02BE\u02C0\u02B7\u02BD) / this.scrollTime;
			if (num > 1f)
			{
				num = 1f;
				this.\u02B7\u02BF\u02BD\u02B7\u02B4\u02B9\u02B2\u02C1\u02BA\u02B3\u02BE = false;
				this.\u02BB\u02B7\u02B7\u02B5\u02B2\u02BA\u02B9\u02C1\u02B2\u02BF\u02BD = true;
			}
			this.scrollTransform.localPosition = Vector3.Lerp(this.\u02C0\u02BB\u02BE\u02BF\u02B6\u02B9\u02B3\u02B5\u02C0\u02BB\u02BA, this.\u02BE\u02BD\u02B4\u02B4\u02B9\u02BF\u02BE\u02B9\u02B6\u02BB\u02BA, num);
		}
	}

	// Token: 0x0600030B RID: 779 RVA: 0x000077AF File Offset: 0x000059AF
	public override void \u02B8\u02B9\u02C0\u02BA\u02C0\u02C0\u02B7\u02BE\u02B5\u02B2\u02B7(byte \u02C0\u02B4\u02B4\u02BC\u02BD\u02B2\u02C1\u02C0\u02C1\u02B4\u02C1)
	{
		if (this.playerSelectionMenu.\u02BF\u02C1\u02B2\u02C1\u02B4\u02B8\u02BF\u02C1\u02C1\u02B9\u02B8)
		{
			this.playerSelectionMenu.\u02B8\u02B9\u02C0\u02BA\u02C0\u02C0\u02B7\u02BE\u02B5\u02B2\u02B7(\u02C0\u02B4\u02B4\u02BC\u02BD\u02B2\u02C1\u02C0\u02C1\u02B4\u02C1);
			return;
		}
		base.\u02B8\u02B9\u02C0\u02BA\u02C0\u02C0\u02B7\u02BE\u02B5\u02B2\u02B7(\u02C0\u02B4\u02B4\u02BC\u02BD\u02B2\u02C1\u02C0\u02C1\u02B4\u02C1);
	}

	// Token: 0x0600030C RID: 780 RVA: 0x0002A340 File Offset: 0x00028540
	public virtual void \u02BF\u02C0\u02C1\u02BD\u02B4\u02B7\u02BD\u02B3\u02B3\u02BD\u02C0()
	{
		this.\u02BA\u02B8\u02B2\u02C1\u02BF\u02C0\u02BD\u02C0\u02B4\u02B4\u02B2 = false;
		if (CHNetManager.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B4\u02BA\u02B8\u02B6\u02BB\u02B5\u02B2\u02B8\u02B6\u02BB\u02BB && this.\u02BE\u02BA\u02BD\u02B5\u02BE\u02C0\u02B7\u02B3\u02BA\u02B4\u02BD == PlayerStatsBox.\u02B5\u02B7\u02BB\u02B5\u02B3\u02B2\u02BA\u02B7\u02B8\u02B9\u02C1.Ready)
		{
			return;
		}
		if (this.\u02B2\u02BF\u02BD\u02C0\u02B3\u02BD\u02BA\u02B5\u02BF\u02B8\u02B3)
		{
			this.\u02B9\u02B7\u02B3\u02BD\u02B3\u02B6\u02B9\u02B3\u02BF\u02B8\u02B7();
			BassAudioManager.Instance.PlaySoundExternal((SoundID)77);
		}
		else if (GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BC\u02B6\u02BA\u02BF\u02B2\u02C1\u02B3\u02B5\u02B2\u02B5\u02B6)
		{
			this.\u02C0\u02B9\u02BB\u02BC\u02BF\u02B5\u02C0\u02B3\u02B5\u02BD\u02BC(true);
		}
		if (this.\u02BC\u02BE\u02C1\u02B8\u02BE\u02C1\u02BE\u02BF\u02BC\u02BC\u02BA)
		{
			\u02B3\u02B7\u02B4\u02BE\u02BE\u02C1\u02BE\u02BB\u02B2\u02B9\u02BA.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BF\u02B9\u02C0\u02BF\u02BA\u02BA\u02B2\u02BA\u02B8\u02B5\u02BC(1);
		}
	}

	// Token: 0x0600030D RID: 781 RVA: 0x000077D2 File Offset: 0x000059D2
	public void \u02B5\u02BF\u02B4\u02B2\u02C0\u02BE\u02BF\u02C1\u02C0\u02BD\u02B6()
	{
		this.\u02B2\u02B3\u02B7\u02C1\u02B4\u02BE\u02C1\u02B2\u02C1\u02BC\u02B2();
		this.statsMenu.SetActive(true);
		this.playerSelectionMenu.gameObject.SetActive(false);
	}

	// Token: 0x0600030E RID: 782 RVA: 0x0002A3AC File Offset: 0x000285AC
	public override void \u02B3\u02BC\u02BA\u02C0\u02C0\u02B8\u02B2\u02B4\u02B3\u02C1\u02B8()
	{
		this.\u02BA\u02B8\u02B2\u02C1\u02BF\u02C0\u02BD\u02C0\u02B4\u02B4\u02B2 = true;
		if (CHNetManager.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B4\u02BA\u02B8\u02B6\u02BB\u02B5\u02B2\u02B8\u02B6\u02BB\u02BB && this.\u02BE\u02BA\u02BD\u02B5\u02BE\u02C0\u02B7\u02B3\u02BA\u02B4\u02BD == PlayerStatsBox.\u02B5\u02B7\u02BB\u02B5\u02B3\u02B2\u02BA\u02B7\u02B8\u02B9\u02C1.Ready)
		{
			return;
		}
		if (this.\u02B2\u02BF\u02BD\u02C0\u02B3\u02BD\u02BA\u02B5\u02BF\u02B8\u02B3)
		{
			this.\u02B9\u02B7\u02B3\u02BD\u02B3\u02B6\u02B9\u02B3\u02BF\u02B8\u02B7();
			BassAudioManager.Instance.PlaySoundExternal(SoundID.UICancel);
		}
		else if (GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BC\u02B6\u02BA\u02BF\u02B2\u02C1\u02B3\u02B5\u02B2\u02B5\u02B6)
		{
			this.\u02C0\u02B9\u02BB\u02BC\u02BF\u02B5\u02C0\u02B3\u02B5\u02BD\u02BC(true);
		}
		if (this.\u02BC\u02BE\u02C1\u02B8\u02BE\u02C1\u02BE\u02BF\u02BC\u02BC\u02BA)
		{
			\u02B3\u02B7\u02B4\u02BE\u02BE\u02C1\u02BE\u02BB\u02B2\u02B9\u02BA.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BF\u02B9\u02C0\u02BF\u02BA\u02BA\u02B2\u02BA\u02B8\u02B5\u02BC(1);
		}
	}

	// Token: 0x06000310 RID: 784 RVA: 0x0002A418 File Offset: 0x00028618
	public virtual void \u02BC\u02C0\u02B9\u02BF\u02C1\u02C0\u02B5\u02B7\u02BD\u02BD\u02B6()
	{
		if (this.\u02BC\u02BF\u02B4\u02BE\u02B2\u02B6\u02B7\u02B5\u02BD\u02BC\u02B6)
		{
			return;
		}
		if (this.\u02B2\u02BF\u02BD\u02C0\u02B3\u02BD\u02BA\u02B5\u02BF\u02B8\u02B3)
		{
			if (this.\u02B9\u02BA\u02B9\u02C1\u02B6\u02BB\u02C0\u02B3\u02B7\u02B8\u02B2 > 0)
			{
				GameAudioManager.PlaySound((SoundID)(-116));
				this.\u02B9\u02BA\u02B9\u02C1\u02B6\u02BB\u02C0\u02B3\u02B7\u02B8\u02B2--;
				this.\u02B7\u02B6\u02B7\u02C1\u02B7\u02BB\u02BB\u02B8\u02B6\u02B2\u02B9();
			}
		}
		else
		{
			base.\u02C1\u02B3\u02BC\u02B6\u02BD\u02B6\u02BF\u02B7\u02BB\u02B5\u02BB();
			if (this.\u02C0\u02B4\u02BC\u02BA\u02B4\u02C1\u02BF\u02B3\u02B7\u02B6\u02B6 > 0)
			{
				this.\u02BB\u02B3\u02C0\u02BC\u02BF\u02BD\u02B9\u02B2\u02BC\u02BE\u02B7 = 0;
				this.\u02C0\u02B4\u02BC\u02BA\u02B4\u02C1\u02BF\u02B3\u02B7\u02B6\u02B6 -= 0;
				this.\u02B6\u02B3\u02BF\u02BB\u02B5\u02BF\u02B5\u02C0\u02BB\u02B9\u02BD();
			}
			else
			{
				this.\u02C0\u02B4\u02BC\u02BA\u02B4\u02C1\u02BF\u02B3\u02B7\u02B6\u02B6 = -1;
			}
			this.\u02B6\u02C1\u02BF\u02C0\u02B8\u02BF\u02BE\u02BF\u02B8\u02B2\u02B8();
		}
		if (this.\u02BC\u02BE\u02C1\u02B8\u02BE\u02C1\u02BE\u02BF\u02BC\u02BC\u02BA)
		{
			\u02B3\u02B7\u02B4\u02BE\u02BE\u02C1\u02BE\u02BB\u02B2\u02B9\u02BA.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BF\u02B9\u02C0\u02BF\u02BA\u02BA\u02B2\u02BA\u02B8\u02B5\u02BC(1);
		}
	}

	// Token: 0x06000311 RID: 785 RVA: 0x0002A4A8 File Offset: 0x000286A8
	private void \u02B4\u02C1\u02BE\u02B9\u02B2\u02B8\u02B4\u02B3\u02BB\u02B6\u02B4()
	{
		int i = 1;
		if (this.\u02B4\u02B2\u02B3\u02B2\u02B2\u02B4\u02BD\u02BE\u02B8\u02BB\u02B4.playerInfo.IsGamepadMode())
		{
			i++;
			global::UnityEngine.Object.Instantiate<GameObject>(this.modifierElement, this.modifierGroupTransform).GetComponent<ModifierFlowElement>().\u02B8\u02C0\u02B3\u02B2\u02B3\u02B7\u02C0\u02BE\u02C1\u02B4\u02B6(0, this.\u02B4\u02B2\u02B3\u02B2\u02B2\u02B4\u02BD\u02BE\u02B8\u02BB\u02B4.playerInfo.instrument);
		}
		while (i <= 524288)
		{
			if (this.\u02B4\u02B2\u02B3\u02B2\u02B2\u02B4\u02BD\u02BE\u02B8\u02BB\u02B4.playerInfo.HasModifier((Modifier)i))
			{
				global::UnityEngine.Object.Instantiate<GameObject>(this.modifierElement, this.modifierGroupTransform).GetComponent<ModifierFlowElement>().\u02B8\u02C0\u02B3\u02B2\u02B3\u02B7\u02C0\u02BE\u02C1\u02B4\u02B6(i, this.\u02B4\u02B2\u02B3\u02B2\u02B2\u02B4\u02BD\u02BE\u02B8\u02BB\u02B4.playerInfo.instrument);
			}
			i *= 2;
		}
	}

	// Token: 0x06000312 RID: 786 RVA: 0x0002A548 File Offset: 0x00028748
	private void \u02BB\u02B3\u02BC\u02B7\u02B8\u02B7\u02BB\u02BF\u02BA\u02B8\u02B8()
	{
		this.statsValueTexts[0].text = string.Format("{0:N0}", this.\u02B6\u02B7\u02BF\u02BB\u02C1\u02C0\u02B2\u02B2\u02BE\u02B5\u02B5.totalNotes);
		this.statsValueTexts[1].text = string.Format("{0:N0}", this.\u02B6\u02B7\u02BF\u02BB\u02C1\u02C0\u02B2\u02B2\u02BE\u02B5\u02B5.notesHit);
		this.statsValueTexts[2].text = string.Format("{0:N0}", this.\u02B6\u02B7\u02BF\u02BB\u02C1\u02C0\u02B2\u02B2\u02BE\u02B5\u02B5.totalNotes - this.\u02B6\u02B7\u02BF\u02BB\u02C1\u02C0\u02B2\u02B2\u02BE\u02B5\u02B5.notesHit);
		this.statsValueTexts[3].text = string.Format("{0:N0}", this.\u02B6\u02B7\u02BF\u02BB\u02C1\u02C0\u02B2\u02B2\u02BE\u02B5\u02B5.combo);
		this.statsValueTexts[4].text = string.Format("{0:N3}x", __FIXME_clon_util.\u02B4\u02BD\u02B2\u02B2\u02B5\u02B4\u02BB\u02B8\u02B6\u02BE\u02BB(this.\u02B6\u02B7\u02BF\u02BB\u02C1\u02C0\u02B2\u02B2\u02BE\u02B5\u02B5.AvgMultiplier, 3));
		this.statsValueTexts[5].text = string.Format("{0:N0}", this.\u02B6\u02B7\u02BF\u02BB\u02C1\u02C0\u02B2\u02B2\u02BE\u02B5\u02B5.overstrums);
		this.statsValueTexts[6].text = string.Format("{0:N0}/{1:N0}", this.\u02B6\u02B7\u02BF\u02BB\u02C1\u02C0\u02B2\u02B2\u02BE\u02B5\u02B5.starPowersHit, this.\u02B6\u02B7\u02BF\u02BB\u02C1\u02C0\u02B2\u02B2\u02BE\u02B5\u02B5.totalStarPowers);
		this.statsValueTexts[7].text = string.Format("{0:N2}", __FIXME_clon_util.\u02B4\u02BD\u02B2\u02B2\u02B5\u02B4\u02BB\u02B8\u02B6\u02BE\u02BB((float)this.\u02B6\u02B7\u02BF\u02BB\u02C1\u02C0\u02B2\u02B2\u02BE\u02B5\u02B5.starPowerAccrued / 100f, 2));
		this.statsValueTexts[8].text = string.Format("{0:N0}", this.\u02B6\u02B7\u02BF\u02BB\u02C1\u02C0\u02B2\u02B2\u02BE\u02B5\u02B5.activations);
		this.statsValueTexts[9].text = string.Format("{0:N2}s", (float)this.\u02B6\u02B7\u02BF\u02BB\u02C1\u02C0\u02B2\u02B2\u02BE\u02B5\u02B5.timeInSP / 100f);
		if (this.\u02B6\u02B9\u02B7\u02B6\u02B9\u02B2\u02BE\u02BE\u02BE\u02B2\u02B5)
		{
			this.statsValueTexts[10].text = string.Format("{0:N0}/{1:N0}", this.\u02B6\u02B7\u02BF\u02BB\u02C1\u02C0\u02B2\u02B2\u02BE\u02B5\u02B5.accentNotes, this.\u02B6\u02B7\u02BF\u02BB\u02C1\u02C0\u02B2\u02B2\u02BE\u02B5\u02B5.accentNotesTotal);
			this.statsValueTexts[11].text = string.Format("{0:N0}/{1:N0}", this.\u02B6\u02B7\u02BF\u02BB\u02C1\u02C0\u02B2\u02B2\u02BE\u02B5\u02B5.ghostNotes, this.\u02B6\u02B7\u02BF\u02BB\u02C1\u02C0\u02B2\u02B2\u02BE\u02B5\u02B5.ghostNotesTotal);
			this.statsValueTexts[16].text = string.Format("{0:N0}", this.\u02B6\u02B7\u02BF\u02BB\u02C1\u02C0\u02B2\u02B2\u02BE\u02B5\u02B5.accentNotes * 50);
			this.statsValueTexts[17].text = string.Format("{0:N0}", this.\u02B6\u02B7\u02BF\u02BB\u02C1\u02C0\u02B2\u02B2\u02BE\u02B5\u02B5.ghostNotes * 50);
		}
		else
		{
			this.statsValueTexts[10].text = string.Format("{0:N0}", this.\u02B6\u02B7\u02BF\u02BB\u02C1\u02C0\u02B2\u02B2\u02BE\u02B5\u02B5.fretsBetweenNotes);
			this.statsValueTexts[11].text = "";
			this.statsValueTexts[16].text = string.Format("{0:N0}", this.\u02B6\u02B7\u02BF\u02BB\u02C1\u02C0\u02B2\u02B2\u02BE\u02B5\u02B5.sustainScore);
			this.statsValueTexts[17].text = "";
		}
		this.statsValueTexts[12].text = string.Format("{0:N0}", this.\u02B6\u02B7\u02BF\u02BB\u02C1\u02C0\u02B2\u02B2\u02BE\u02B5\u02B5.noteScore);
		this.statsValueTexts[13].text = string.Format("{0:N0}", this.\u02B6\u02B7\u02BF\u02BB\u02C1\u02C0\u02B2\u02B2\u02BE\u02B5\u02B5.comboScore);
		this.statsValueTexts[14].text = string.Format("{0:N0}", this.\u02B6\u02B7\u02BF\u02BB\u02C1\u02C0\u02B2\u02B2\u02BE\u02B5\u02B5.starPowerScore);
		this.statsValueTexts[15].text = string.Format("{0:N0}", this.\u02B6\u02B7\u02BF\u02BB\u02C1\u02C0\u02B2\u02B2\u02BE\u02B5\u02B5.soloScore);
	}

	// Token: 0x06000313 RID: 787 RVA: 0x0002A8FC File Offset: 0x00028AFC
	public override void \u02B7\u02BA\u02C0\u02B8\u02BE\u02BA\u02BD\u02B4\u02BB\u02B3\u02B6()
	{
		if (this.\u02BC\u02BF\u02B4\u02BE\u02B2\u02B6\u02B7\u02B5\u02BD\u02BC\u02B6)
		{
			return;
		}
		if (this.\u02B2\u02BF\u02BD\u02C0\u02B3\u02BD\u02BA\u02B5\u02BF\u02B8\u02B3)
		{
			if (this.\u02B9\u02BA\u02B9\u02C1\u02B6\u02BB\u02C0\u02B3\u02B7\u02B8\u02B2 < this.\u02BC\u02BA\u02BC\u02B6\u02BA\u02B5\u02B6\u02BB\u02C1\u02BF\u02B7)
			{
				GameAudioManager.PlaySound(SoundID.UIScrollDown);
				this.\u02B9\u02BA\u02B9\u02C1\u02B6\u02BB\u02C0\u02B3\u02B7\u02B8\u02B2++;
				this.\u02B7\u02B6\u02B7\u02C1\u02B7\u02BB\u02BB\u02B8\u02B6\u02B2\u02B9();
			}
		}
		else
		{
			base.\u02B7\u02BA\u02C0\u02B8\u02BE\u02BA\u02BD\u02B4\u02BB\u02B3\u02B6();
			if (this.\u02BB\u02B3\u02C0\u02BC\u02BF\u02BD\u02B9\u02B2\u02BC\u02BE\u02B7 == 3 && this.\u02C0\u02B4\u02BC\u02BA\u02B4\u02C1\u02BF\u02B3\u02B7\u02B6\u02B6 < this.\u02B6\u02B2\u02BF\u02B6\u02B8\u02BD\u02C1\u02BB\u02BC\u02B3\u02B4)
			{
				this.\u02C0\u02B4\u02BC\u02BA\u02B4\u02C1\u02BF\u02B3\u02B7\u02B6\u02B6++;
				this.\u02B6\u02B3\u02BF\u02BB\u02B5\u02BF\u02B5\u02C0\u02BB\u02B9\u02BD();
				if (this.\u02C0\u02B4\u02BC\u02BA\u02B4\u02C1\u02BF\u02B3\u02B7\u02B6\u02B6 > 0 && this.\u02C0\u02B4\u02BC\u02BA\u02B4\u02C1\u02BF\u02B3\u02B7\u02B6\u02B6 <= this.\u02B6\u02B2\u02BF\u02B6\u02B8\u02BD\u02C1\u02BB\u02BC\u02B3\u02B4)
				{
					GameAudioManager.PlaySound(SoundID.UIScrollUp);
				}
			}
			this.\u02B6\u02C1\u02BF\u02C0\u02B8\u02BF\u02BE\u02BF\u02B8\u02B2\u02B8();
		}
		if (this.\u02BC\u02BE\u02C1\u02B8\u02BE\u02C1\u02BE\u02BF\u02BC\u02BC\u02BA)
		{
			\u02B3\u02B7\u02B4\u02BE\u02BE\u02C1\u02BE\u02BB\u02B2\u02B9\u02BA.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BF\u02B9\u02C0\u02BF\u02BA\u02BA\u02B2\u02BA\u02B8\u02B5\u02BC(3);
		}
	}

	// Token: 0x040001FD RID: 509
	public TextMeshProUGUI \u02BB\u02C0\u02B6\u02B5\u02BE\u02B9\u02BC\u02B9\u02B7\u02BB\u02BD;

	// Token: 0x040001FE RID: 510
	public TextMeshProUGUI \u02BA\u02B7\u02B5\u02BA\u02B9\u02B3\u02C1\u02B2\u02BB\u02B4\u02B4;

	// Token: 0x040001FF RID: 511
	public TextMeshProUGUI \u02B5\u02BD\u02C0\u02C1\u02BF\u02BF\u02B7\u02BF\u02B6\u02C1\u02BA;

	// Token: 0x04000200 RID: 512
	public TextMeshProUGUI \u02BD\u02B7\u02B2\u02BA\u02BF\u02B7\u02BF\u02B7\u02BF\u02BD\u02B9;

	// Token: 0x04000201 RID: 513
	public TextMeshProUGUI \u02BC\u02BC\u02C1\u02B4\u02BF\u02B8\u02BF\u02B2\u02BA\u02B3\u02B5;

	// Token: 0x04000202 RID: 514
	public GameObject[] \u02B4\u02C0\u02BB\u02B6\u02B5\u02B6\u02BE\u02B2\u02B8\u02BE\u02B9;

	// Token: 0x04000203 RID: 515
	public Image \u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF;

	// Token: 0x04000204 RID: 516
	public Image \u02B2\u02B3\u02C0\u02BB\u02BF\u02BD\u02B4\u02B3\u02B5\u02B3\u02B9;

	// Token: 0x04000205 RID: 517
	public Sprite[] \u02B2\u02B7\u02B7\u02BE\u02C1\u02BB\u02B8\u02B6\u02B5\u02B5\u02B9;

	// Token: 0x04000206 RID: 518
	[Header("Header Texts")]
	[SerializeField]
	private TextMeshProUGUI[] headerTexts;

	// Token: 0x04000207 RID: 519
	[Header("Stats Texts")]
	[SerializeField]
	private TextMeshProUGUI[] statsNameTexts;

	// Token: 0x04000208 RID: 520
	[SerializeField]
	private TextMeshProUGUI[] statsValueTexts;

	// Token: 0x04000209 RID: 521
	[Header("Menu Objects")]
	[SerializeField]
	private GameObject modifierElement;

	// Token: 0x0400020A RID: 522
	[SerializeField]
	private Transform scrollTransform;

	// Token: 0x0400020B RID: 523
	[SerializeField]
	private Transform modifierGroupTransform;

	// Token: 0x0400020C RID: 524
	[SerializeField]
	private DrumEndOfSongOptionsMenu drumsOptionsMenu;

	// Token: 0x0400020D RID: 525
	[SerializeField]
	private TextMeshProUGUI finishText;

	// Token: 0x0400020E RID: 526
	[SerializeField]
	private TextMeshProUGUI menuText;

	// Token: 0x0400020F RID: 527
	[SerializeField]
	private TextMeshProUGUI notSupportedText;

	// Token: 0x04000210 RID: 528
	[SerializeField]
	private TextMeshProUGUI[] menuOptions;

	// Token: 0x04000211 RID: 529
	[SerializeField]
	private GameObject menuObject;

	// Token: 0x04000212 RID: 530
	[SerializeField]
	private PlayerSelectionMenu playerSelectionMenu;

	// Token: 0x04000213 RID: 531
	[SerializeField]
	private GameObject statsMenu;

	// Token: 0x04000214 RID: 532
	public int \u02BE\u02BB\u02B5\u02B7\u02B9\u02B2\u02B6\u02BF\u02B9\u02B7\u02B7;

	// Token: 0x04000215 RID: 533
	[SerializeField]
	private float scrollPageAmount;

	// Token: 0x04000216 RID: 534
	[SerializeField]
	private float scrollTime;

	// Token: 0x04000217 RID: 535
	private float \u02B5\u02B4\u02BE\u02BC\u02B3\u02B5\u02B4\u02BE\u02C0\u02B7\u02BD;

	// Token: 0x04000218 RID: 536
	private float \u02C0\u02B8\u02B7\u02BE\u02BC\u02C1\u02B2\u02BF\u02BA\u02B5\u02B4;

	// Token: 0x04000219 RID: 537
	private bool \u02B7\u02BF\u02BD\u02B7\u02B4\u02B9\u02B2\u02C1\u02BA\u02B3\u02BE;

	// Token: 0x0400021A RID: 538
	private bool \u02B6\u02B9\u02B7\u02B6\u02B9\u02B2\u02BE\u02BE\u02BE\u02B2\u02B5;

	// Token: 0x0400021B RID: 539
	private bool \u02BB\u02B7\u02B7\u02B5\u02B2\u02BA\u02B9\u02C1\u02B2\u02BF\u02BD;

	// Token: 0x0400021C RID: 540
	private bool \u02B2\u02BF\u02BD\u02C0\u02B3\u02BD\u02BA\u02B5\u02BF\u02B8\u02B3;

	// Token: 0x0400021D RID: 541
	private bool \u02BC\u02BE\u02C1\u02B8\u02BE\u02C1\u02BE\u02BF\u02BC\u02BC\u02BA;

	// Token: 0x0400021E RID: 542
	private bool \u02BA\u02BD\u02BD\u02BB\u02BB\u02BA\u02B2\u02B6\u02BA\u02BA\u02C1;

	// Token: 0x0400021F RID: 543
	private Vector3 \u02BE\u02BD\u02B4\u02B4\u02B9\u02BF\u02BE\u02B9\u02B6\u02BB\u02BA;

	// Token: 0x04000220 RID: 544
	private Vector3 \u02C0\u02BB\u02BE\u02BF\u02B6\u02B9\u02B3\u02B5\u02C0\u02BB\u02BA;

	// Token: 0x04000221 RID: 545
	private int \u02B9\u02B5\u02B4\u02B9\u02BF\u02B6\u02B5\u02C1\u02BB\u02B3\u02B3;

	// Token: 0x04000222 RID: 546
	private int \u02C0\u02B4\u02BC\u02BA\u02B4\u02C1\u02BF\u02B3\u02B7\u02B6\u02B6 = -1;

	// Token: 0x04000223 RID: 547
	private int \u02B6\u02B2\u02BF\u02B6\u02B8\u02BD\u02C1\u02BB\u02BC\u02B3\u02B4;

	// Token: 0x04000224 RID: 548
	private int \u02B7\u02B7\u02B4\u02B2\u02BF\u02C0\u02BE\u02B6\u02C0\u02B8\u02B5;

	// Token: 0x04000225 RID: 549
	private int \u02B9\u02BA\u02B9\u02C1\u02B6\u02BB\u02C0\u02B3\u02B7\u02B8\u02B2;

	// Token: 0x04000226 RID: 550
	private int \u02BC\u02BA\u02BC\u02B6\u02BA\u02B5\u02B6\u02BB\u02C1\u02BF\u02B7;

	// Token: 0x04000227 RID: 551
	private PlayerStats \u02B6\u02B7\u02BF\u02BB\u02C1\u02C0\u02B2\u02B2\u02BE\u02B5\u02B5;

	// Token: 0x04000228 RID: 552
	public Image[] \u02BB\u02BD\u02C1\u02C0\u02C1\u02BF\u02B5\u02B6\u02BF\u02C1\u02C1;

	// Token: 0x04000229 RID: 553
	public ScrollingText[] \u02B3\u02BE\u02B5\u02BF\u02C1\u02BC\u02B7\u02B5\u02BC\u02BB\u02BB;

	// Token: 0x0400022A RID: 554
	public TextMeshProUGUI[] \u02B6\u02B9\u02C1\u02BA\u02B8\u02BD\u02BF\u02BC\u02B9\u02BB\u02B3;

	// Token: 0x0400022B RID: 555
	public TextMeshProUGUI[] \u02B6\u02B6\u02B3\u02B5\u02BE\u02B5\u02BD\u02C0\u02B3\u02C1\u02B9;

	// Token: 0x0400022C RID: 556
	[SerializeField]
	private Image[] guitarDisabledBG;

	// Token: 0x0400022D RID: 557
	private PlayerStatsBox.\u02B5\u02B7\u02BB\u02B5\u02B3\u02B2\u02BA\u02B7\u02B8\u02B9\u02C1 \u02BE\u02BA\u02BD\u02B5\u02BE\u02C0\u02B7\u02B3\u02BA\u02B4\u02BD;

	// Token: 0x0400022E RID: 558
	private float \u02B2\u02BE\u02B5\u02BE\u02B5\u02BF\u02B8\u02B2\u02BD\u02B7\u02BD = 0.35f;

	// Token: 0x0400022F RID: 559
	private float \u02B4\u02BB\u02B6\u02B9\u02B4\u02B9\u02B7\u02BF\u02B6\u02B3\u02B7 = 0.5f;

	// Token: 0x04000230 RID: 560
	private bool \u02C0\u02BD\u02C0\u02C1\u02BA\u02BA\u02B7\u02B4\u02B8\u02B8\u02C0 = true;

	// Token: 0x04000231 RID: 561
	private float \u02B4\u02BA\u02C0\u02B5\u02B9\u02B4\u02BC\u02B7\u02B8\u02BE\u02B2;

	// Token: 0x04000232 RID: 562
	[SerializeField]
	private Image scrollArrowUp;

	// Token: 0x04000233 RID: 563
	[SerializeField]
	private Image scrollArrowDown;

	// Token: 0x02000049 RID: 73
	public enum \u02B5\u02B7\u02BB\u02B5\u02B3\u02B2\u02BA\u02B7\u02B8\u02B9\u02C1
	{
		// Token: 0x04000235 RID: 565
		Ready,
		// Token: 0x04000236 RID: 566
		Quitting,
		// Token: 0x04000237 RID: 567
		Readying,
		// Token: 0x04000238 RID: 568
		ChangingPlayer,
		// Token: 0x04000239 RID: 569
		NotReady
	}
}
