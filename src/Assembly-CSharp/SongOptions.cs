using System;
using System.IO;
using System.Text.RegularExpressions;
using StrikeCore;
using TMPro;
using UnityEngine;

public class SongOptions : BaseMenu
{
	public virtual void \u02B2\u02C0\u02B4\u02B7\u02B8\u02B5\u02B5\u02B4\u02B7\u02C1\u02BC()
	{
		if (this.\u02BD\u02BD\u02B8\u02BE\u02B4\u02BC\u02BD\u02C1\u02BB\u02C0\u02BE == this.\u02B8\u02BD\u02BE\u02C1\u02BE\u02C0\u02B7\u02B5\u02C0\u02B7\u02BC.Length)
		{
			this.\u02BD\u02BD\u02B8\u02BE\u02B4\u02BC\u02BD\u02C1\u02BB\u02C0\u02BE = 0;
		}
		if (this.\u02B8\u02BD\u02BE\u02C1\u02BE\u02C0\u02B7\u02B5\u02C0\u02B7\u02BC[this.\u02BD\u02BD\u02B8\u02BE\u02B4\u02BC\u02BD\u02C1\u02BB\u02C0\u02BE] == -101)
		{
			this.\u02BD\u02BD\u02B8\u02BE\u02B4\u02BC\u02BD\u02C1\u02BB\u02C0\u02BE++;
			return;
		}
		this.\u02BD\u02BD\u02B8\u02BE\u02B4\u02BC\u02BD\u02C1\u02BB\u02C0\u02BE = 1;
	}

	public override void \u02B3\u02BC\u02BA\u02C0\u02C0\u02B8\u02B2\u02B4\u02B3\u02C1\u02B8()
	{
		this.\u02BD\u02BD\u02B8\u02BE\u02B4\u02BC\u02BD\u02C1\u02BB\u02C0\u02BE = 0;
		this.allowMultiLanguage = true;
		if (this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 == null)
		{
			if (this.\u02C0\u02C1\u02BE\u02BF\u02B2\u02BC\u02C0\u02B4\u02B3\u02BD\u02C0 == 0)
			{
				this.\u02B6\u02B5\u02B7\u02BD\u02B4\u02BA\u02B6\u02B9\u02B2\u02B3\u02B4 = base.\u02BF\u02B6\u02B5\u02BF\u02BD\u02BF\u02B4\u02B3\u02B8\u02BE\u02BC;
				this.\u02B5\u02B6\u02B8\u02BC\u02BF\u02BF\u02BC\u02B5\u02C0\u02BB\u02C0(0, true);
				base.gameObject.SetActive(false);
				return;
			}
			if (this.\u02C0\u02C1\u02BE\u02BF\u02B2\u02BC\u02C0\u02B4\u02B3\u02BD\u02C0 == 4)
			{
				this.\u02BE\u02B7\u02B2\u02B3\u02B5\u02B7\u02B7\u02B9\u02B3\u02BF\u02BC(this.setlistOptions);
				return;
			}
			if (this.\u02C0\u02C1\u02BE\u02BF\u02B2\u02BC\u02C0\u02B4\u02B3\u02BD\u02C0 == 2)
			{
				this.\u02BE\u02B7\u02B2\u02B3\u02B5\u02B7\u02B7\u02B9\u02B3\u02BF\u02BC(GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BD\u02B9\u02B7\u02B5\u02BF\u02BC\u02BF\u02BA\u02BE\u02B6\u02B4 ? this.mainOptionsPractice : this.mainOptions);
				base.\u02B5\u02B6\u02B8\u02BC\u02BF\u02BF\u02BC\u02B5\u02C0\u02BB\u02C0("Setlist");
				this.\u02C0\u02C1\u02BE\u02BF\u02B2\u02BC\u02C0\u02B4\u02B3\u02BD\u02C0 = 0;
				return;
			}
		}
		else
		{
			this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = null;
			this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 = null;
			this.\u02B9\u02B8\u02C0\u02B7\u02BA\u02B3\u02BB\u02C0\u02B3\u02C1\u02B8();
		}
	}

	public override void \u02BB\u02B3\u02BF\u02BC\u02C1\u02BC\u02BC\u02C1\u02C0\u02B5\u02BA()
	{
		if (this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 == "Song Speed")
		{
			this.\u02B4\u02B8\u02C0\u02BC\u02C1\u02C1\u02B7\u02B2\u02B2\u02B4\u02B9();
		}
	}

	public virtual void \u02C0\u02B8\u02BD\u02B8\u02BB\u02BC\u02BE\u02B2\u02B2\u02B3\u02B5()
	{
		this.\u02BD\u02BD\u02B8\u02BE\u02B4\u02BC\u02BD\u02C1\u02BB\u02C0\u02BE = 1;
		this.allowMultiLanguage = false;
		if (this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 != null)
		{
			this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = null;
			this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 = null;
			this.\u02B9\u02B8\u02C0\u02B7\u02BA\u02B3\u02BB\u02C0\u02B3\u02C1\u02B8();
			return;
		}
		if (this.\u02C0\u02C1\u02BE\u02BF\u02B2\u02BC\u02C0\u02B4\u02B3\u02BD\u02C0 == 6)
		{
			this.confirmMenu.\u02C0\u02B7\u02B3\u02B8\u02B2\u02B9\u02B2\u02BC\u02BE\u02B8\u02BD("{0:n0}", "Solid Solo!", "Drums", new ConfirmationMenu.\u02BF\u02B3\u02BF\u02BF\u02C0\u02B2\u02BE\u02B8\u02B6\u02BD\u02B7(this.\u02BC\u02BE\u02B8\u02BA\u02C0\u02B5\u02C0\u02BE\u02BF\u02BC\u02BA), null, null);
			return;
		}
		if (this.\u02C0\u02C1\u02BE\u02BF\u02B2\u02BC\u02C0\u02B4\u02B3\u02BD\u02C0 != 6)
		{
			string text = base.\u02B2\u02BF\u02BF\u02BE\u02BD\u02B8\u02BE\u02C0\u02B3\u02B3\u02C0;
			uint num = PrivateImplementationDetails.ComputeStringHash(text);
			if (num <= 4294967228U)
			{
				if (num <= 176U)
				{
					if (num <= 13U)
					{
						if (num != 4294967262U)
						{
							if (num != 191U)
							{
								if (num != 3U)
								{
									goto IL_0844;
								}
								if (!(text == "Show Remote Player Names"))
								{
									goto IL_0844;
								}
							}
							else
							{
								if (!(text == "Test Velocity"))
								{
									goto IL_0844;
								}
								this.\u02B7\u02B2\u02BA\u02B7\u02BE\u02B8\u02BE\u02BB\u02B5\u02C1\u02BB();
								return;
							}
						}
						else
						{
							if (!(text == "Difficulty"))
							{
								goto IL_0844;
							}
							this.allowMultiLanguage = false;
							this.\u02BE\u02B7\u02B2\u02B3\u02B5\u02B7\u02B7\u02B9\u02B3\u02BF\u02BC(\u02B5\u02B5\u02BA\u02B3\u02BC\u02BA\u02C0\u02B7\u02B6\u02BC\u02B9.\u02B3\u02B7\u02BE\u02B8\u02C1\u02BA\u02B5\u02B8\u02B2\u02B5\u02C0());
							if (this.menuStrings == null || this.menuStrings.Length == 0)
							{
								this.confirmMenu.\u02C0\u02B7\u02B3\u02B8\u02B2\u02B9\u02B2\u02BC\u02BE\u02B8\u02BD("GHLBass", "6 Fret Bass Guitar", null, null, null, null);
								this.\u02BE\u02B7\u02B2\u02B3\u02B5\u02B7\u02B7\u02B9\u02B3\u02BF\u02BC(this.setlistOptions);
								return;
							}
							this.\u02C0\u02C1\u02BE\u02BF\u02B2\u02BC\u02C0\u02B4\u02B3\u02BD\u02C0 = 8;
							return;
						}
					}
					else if (num <= 4294967242U)
					{
						if (num != 4294967283U)
						{
							if (num != 125U)
							{
								goto IL_0844;
							}
							if (!(text == "No Part"))
							{
								goto IL_0844;
							}
							this.\u02C0\u02B3\u02BE\u02C1\u02B2\u02B2\u02BB\u02BD\u02B8\u02C1\u02B2(Instrument.Rhythm);
							return;
						}
						else
						{
							if (!(text == "settings"))
							{
								goto IL_0844;
							}
							if (\u02B5\u02B5\u02BA\u02B3\u02BC\u02BA\u02C0\u02B7\u02B6\u02BC\u02B9.\u02BC\u02BD\u02BE\u02BB\u02B2\u02B8\u02C0\u02B6\u02BA\u02B9\u02B7 == null)
							{
								this.\u02B3\u02BB\u02BF\u02C0\u02BB\u02B6\u02B5\u02B9\u02B8\u02BE\u02B9 = true;
								this.\u02BA\u02BE\u02B9\u02B8\u02B3\u02BB\u02BB\u02C0\u02BF\u02C0\u02BE = false;
								this.\u02B5\u02B7\u02C0\u02B6\u02BF\u02B6\u02BC\u02BE\u02B6\u02B8\u02B2();
								return;
							}
							if (\u02B5\u02B5\u02BA\u02B3\u02BC\u02BA\u02C0\u02B7\u02B6\u02BC\u02B9.\u02C1\u02BC\u02B7\u02B8\u02B9\u02B4\u02BC\u02B9\u02B5\u02B8\u02B7(\u02B5\u02B5\u02BA\u02B3\u02BC\u02BA\u02C0\u02B7\u02B6\u02BC\u02B9.\u02BC\u02BD\u02BE\u02BB\u02B2\u02B8\u02C0\u02B6\u02BA\u02B9\u02B7) && \u02B5\u02B5\u02BA\u02B3\u02BC\u02BA\u02C0\u02B7\u02B6\u02BC\u02B9.\u02B5\u02BC\u02B8\u02B9\u02B3\u02B6\u02C1\u02BA\u02C0\u02B9\u02BA != null)
							{
								this.confirmMenu.\u02B7\u02B3\u02BC\u02BE\u02BF\u02B7\u02B4\u02C0\u02B9\u02BC\u02BF("Ready", "", "Display", new ConfirmationMenu.\u02BF\u02B3\u02BF\u02BF\u02C0\u02B2\u02BE\u02B8\u02B6\u02BD\u02B7(this.\u02BB\u02BF\u02B5\u02BD\u02B4\u02B8\u02B9\u02BD\u02B8\u02C1\u02B7), null, null);
								return;
							}
							this.\u02BB\u02BF\u02B5\u02BD\u02B4\u02B8\u02B9\u02BD\u02B8\u02C1\u02B7();
							return;
						}
					}
					else if (num != 4294967294U)
					{
						if (num != 94U)
						{
							goto IL_0844;
						}
						if (!(text == ""))
						{
							goto IL_0844;
						}
						this.\u02C0\u02B3\u02BE\u02C1\u02B2\u02B2\u02BB\u02BD\u02B8\u02C1\u02B2(Instrument.Bass);
						return;
					}
					else
					{
						if (!(text == " + "))
						{
							goto IL_0844;
						}
						this.\u02BE\u02B5\u02B5\u02C0\u02BA\u02BB\u02B8\u02B3\u02B8\u02B4\u02B3((Instrument)18);
						return;
					}
				}
				else if (num <= 2U)
				{
					if (num != 4294967245U)
					{
						if (num != 13U)
						{
							if (num != 94U)
							{
								goto IL_0844;
							}
							if (!(text == "explorer.exe"))
							{
								goto IL_0844;
							}
							this.\u02C0\u02B3\u02BE\u02C1\u02B2\u02B2\u02BB\u02BD\u02B8\u02C1\u02B2((Instrument)86);
							return;
						}
						else
						{
							if (!(text == "Set B Position"))
							{
								goto IL_0844;
							}
							this.\u02BE\u02B5\u02B5\u02C0\u02BA\u02BB\u02B8\u02B3\u02B8\u02B4\u02B3(Instrument.Rhythm);
							return;
						}
					}
					else
					{
						if (!(text == ""))
						{
							goto IL_0844;
						}
						\u02B5\u02B5\u02BA\u02B3\u02BC\u02BA\u02C0\u02B7\u02B6\u02BC\u02B9.\u02BC\u02BD\u02BE\u02BB\u02B2\u02B8\u02C0\u02B6\u02BA\u02B9\u02B7 = \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02BE\u02C0\u02B6\u02B9\u02B7\u02BE\u02B9\u02B6\u02B9\u02BF\u02B2().\u02BB\u02B9\u02BB\u02B8\u02B3\u02B2\u02B5\u02B6\u02B4\u02B2\u02B4("section ");
						\u02B5\u02B5\u02BA\u02B3\u02BC\u02BA\u02C0\u02B7\u02B6\u02BC\u02B9.\u02B5\u02BC\u02B8\u02B9\u02B3\u02B6\u02C1\u02BA\u02C0\u02B9\u02BA = null;
						\u02B5\u02B5\u02BA\u02B3\u02BC\u02BA\u02C0\u02B7\u02B6\u02BC\u02B9.\u02B7\u02BA\u02B6\u02C1\u02BD\u02B2\u02B5\u02B7\u02B5\u02B2\u02B8 = false;
						object obj = \u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02BE\u02B3\u02BE\u02BF\u02B3\u02C1\u02B3\u02BF\u02BE\u02B3\u02B7(this.songSelect.\u02BF\u02B6\u02B5\u02BF\u02BD\u02BF\u02B4\u02B3\u02B8\u02BE\u02BC);
						if (obj is \u02C1\u02BD\u02B8\u02B2\u02B3\u02BA\u02B8\u02B8\u02C0\u02B6\u02B8)
						{
							\u02C1\u02BD\u02B8\u02B2\u02B3\u02BA\u02B8\u02B8\u02C0\u02B6\u02B8 u02C1_u02BD_u02B8_u02B2_u02B3_u02BA_u02B8_u02B8_u02C0_u02B6_u02B = (\u02C1\u02BD\u02B8\u02B2\u02B3\u02BA\u02B8\u02B8\u02C0\u02B6\u02B8)obj;
							if (u02C1_u02BD_u02B8_u02B2_u02B3_u02BA_u02B8_u02B8_u02C0_u02B6_u02B == null || u02C1_u02BD_u02B8_u02B2_u02B3_u02BA_u02B8_u02B8_u02C0_u02B6_u02B.\u02B5\u02B5\u02B6\u02B8\u02B5\u02BF\u02BF\u02B6\u02BB\u02BA\u02B5 == null || u02C1_u02BD_u02B8_u02B2_u02B3_u02BA_u02B8_u02B8_u02C0_u02B6_u02B.\u02B5\u02B5\u02B6\u02B8\u02B5\u02BF\u02BF\u02B6\u02BB\u02BA\u02B5.Count == 0)
							{
								return;
							}
							for (int i = 1; i < u02C1_u02BD_u02B8_u02B2_u02B3_u02BA_u02B8_u02B8_u02C0_u02B6_u02B.\u02B5\u02B5\u02B6\u02B8\u02B5\u02BF\u02BF\u02B6\u02BB\u02BA\u02B5.Count; i++)
							{
								this.setlistMenu.\u02BA\u02B4\u02B2\u02BB\u02B9\u02BC\u02B9\u02B8\u02C1\u02B5\u02BE(u02C1_u02BD_u02B8_u02B2_u02B3_u02BA_u02B8_u02B8_u02C0_u02B6_u02B.\u02B5\u02B5\u02B6\u02B8\u02B5\u02BF\u02BF\u02B6\u02BB\u02BA\u02B5[i], SettingsController.\u02B3\u02B7\u02B4\u02BA\u02B3\u02B9\u02B7\u02BE\u02B2\u02B7\u02BE.CurrentValue, "");
							}
						}
						else
						{
							this.setlistMenu.\u02B5\u02B9\u02BE\u02C1\u02C1\u02C0\u02B7\u02BB\u02B2\u02C1\u02BF((SongEntry)obj, SettingsController.\u02B3\u02B7\u02B4\u02BA\u02B3\u02B9\u02B7\u02BE\u02B2\u02B7\u02BE.CurrentValue, "Double Strum Prevention");
						}
						this.\u02B8\u02B6\u02B9\u02BF\u02BF\u02BD\u02B6\u02B7\u02B3\u02BA\u02B9(true, true);
						return;
					}
				}
				else if (num <= 189U)
				{
					if (num != 4294967251U)
					{
						if (num != 4294967154U)
						{
							goto IL_0844;
						}
						if (!(text == "songSpeed"))
						{
							goto IL_0844;
						}
						this.\u02BE\u02B5\u02B5\u02C0\u02BA\u02BB\u02B8\u02B3\u02B8\u02B4\u02B3(Instrument.Keys);
						return;
					}
					else
					{
						if (!(text == "Highways/"))
						{
							goto IL_0844;
						}
						this.\u02BE\u02B5\u02B5\u02C0\u02BA\u02BB\u02B8\u02B3\u02B8\u02B4\u02B3(Instrument.Band);
						return;
					}
				}
				else if (num != 4294967122U)
				{
					if (num != 132U)
					{
						goto IL_0844;
					}
					if (!(text == "Enable"))
					{
						goto IL_0844;
					}
					this.\u02C0\u02B3\u02BE\u02C1\u02B2\u02B2\u02BB\u02BD\u02B8\u02C1\u02B2(Instrument.Guitar);
					return;
				}
				else
				{
					if (!(text == "Leave Server"))
					{
						goto IL_0844;
					}
					this.\u02B3\u02BB\u02BF\u02C0\u02BB\u02B6\u02B5\u02B9\u02B8\u02BE\u02B9 = (this.\u02BA\u02BE\u02B9\u02B8\u02B3\u02BB\u02BB\u02C0\u02BF\u02C0\u02BE = false);
					this.\u02B5\u02B7\u02C0\u02B6\u02BF\u02B6\u02BC\u02BE\u02B6\u02B8\u02B2();
					return;
				}
			}
			else if (num <= 148U)
			{
				if (num <= 4294967111U)
				{
					if (num != 4294967274U)
					{
						if (num != 4294967252U)
						{
							if (num != 119U)
							{
								goto IL_0844;
							}
							if (!(text == "Maximum Speed"))
							{
								goto IL_0844;
							}
							this.confirmMenu.\u02B7\u02B3\u02BC\u02BE\u02BF\u02B7\u02B4\u02C0\u02B9\u02BC\u02BF("Kick", "Looking for a band...", "CALIBRATION", null, null, null);
							return;
						}
						else
						{
							if (!(text == "Random Song (Section)"))
							{
								goto IL_0844;
							}
							if (!this.setlistMenu.isActiveAndEnabled)
							{
								this.\u02BE\u02B7\u02B2\u02B3\u02B5\u02B7\u02B7\u02B9\u02B3\u02BF\u02BC(this.setlistOptions);
								return;
							}
							if (CHNetManager.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B4\u02BA\u02B8\u02B6\u02BB\u02B5\u02B2\u02B8\u02B6\u02BB\u02BB)
							{
								this.\u02BE\u02B7\u02B2\u02B3\u02B5\u02B7\u02B7\u02B9\u02B3\u02BF\u02BC(this.setlistOptionsOnline);
								return;
							}
							this.\u02BE\u02B7\u02B2\u02B3\u02B5\u02B7\u02B7\u02B9\u02B3\u02BF\u02BC(this.setlistOptionsActive);
							return;
						}
					}
					else
					{
						if (!(text == "ModChart Full"))
						{
							goto IL_0844;
						}
						this.confirmMenu.\u02B7\u02B3\u02BC\u02BE\u02BF\u02B7\u02B4\u02C0\u02B9\u02BC\u02BF("MIDI Profiles", "Editor", "#", new ConfirmationMenu.\u02BF\u02B3\u02BF\u02BF\u02C0\u02B2\u02BE\u02B8\u02B6\u02BD\u02B7(this.\u02B7\u02BA\u02BD\u02BA\u02B7\u02BE\u02C1\u02B9\u02B5\u02BF\u02B2), null, null);
						return;
					}
				}
				else if (num <= 137U)
				{
					if (num != 4294967172U)
					{
						if (num != 4294967103U)
						{
							goto IL_0844;
						}
						if (!(text == " cannot find next node called "))
						{
							goto IL_0844;
						}
						this.\u02B7\u02B9\u02B3\u02B3\u02BC\u02C1\u02BC\u02BA\u02B3\u02B8\u02B6();
						return;
					}
					else if (!(text == "settings"))
					{
						goto IL_0844;
					}
				}
				else if (num != 4294967200U)
				{
					if (num != 4294967130U)
					{
						goto IL_0844;
					}
					if (!(text == ""))
					{
						goto IL_0844;
					}
					this.\u02BE\u02B5\u02B5\u02C0\u02BA\u02BB\u02B8\u02B3\u02B8\u02B4\u02B3(Instrument.Bass);
					return;
				}
				else
				{
					if (!(text == "Are you sure you want to quit?"))
					{
						goto IL_0844;
					}
					this.\u02BE\u02B7\u02B2\u02B3\u02B5\u02B7\u02B7\u02B9\u02B3\u02BF\u02BC(this.instrumentScoresOptions);
					return;
				}
			}
			else if (num <= 4294967098U)
			{
				if (num != 56U)
				{
					if (num != 4294967197U)
					{
						if (num != 4294967270U)
						{
							goto IL_0844;
						}
						if (!(text == "_endofsong"))
						{
							goto IL_0844;
						}
						this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.\u02B3\u02B7\u02B4\u02BA\u02B3\u02B9\u02B7\u02BE\u02B2\u02B7\u02BE;
						goto IL_0844;
					}
					else
					{
						if (!(text == "Medium"))
						{
							goto IL_0844;
						}
						if (CHNetManager.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02C1\u02BB\u02B7\u02B6\u02B9\u02B5\u02BC\u02B2\u02BB\u02B2\u02BD() && \u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02B4\u02BE\u02B5\u02B6\u02BB\u02B4\u02B6\u02B9\u02B5\u02B7\u02BD.Count > 1)
						{
							\u02B3\u02B7\u02B4\u02BE\u02BE\u02C1\u02BE\u02BB\u02B2\u02B9\u02BA.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BE\u02B3\u02B7\u02BA\u02BE\u02B8\u02B4\u02B7\u02BF\u02B9\u02C0(\u02C0\u02C0\u02BD\u02B6\u02BA\u02BF\u02B3\u02BE\u02BC\u02B8\u02B4.Stats);
						}
						else
						{
							this.songSelect.\u02BD\u02B7\u02B2\u02BE\u02B7\u02BD\u02C1\u02BE\u02C1\u02B9\u02B7();
						}
						this.\u02B8\u02B6\u02B9\u02BF\u02BF\u02BD\u02B6\u02B7\u02B3\u02BA\u02B9(false, false);
						return;
					}
				}
				else
				{
					if (!(text == "Dynamics"))
					{
						goto IL_0844;
					}
					this.allowMultiLanguage = false;
					this.\u02BE\u02B7\u02B2\u02B3\u02B5\u02B7\u02B7\u02B9\u02B3\u02BF\u02BC(\u02B5\u02B5\u02BA\u02B3\u02BC\u02BA\u02C0\u02B7\u02B6\u02BC\u02B9.\u02B3\u02B7\u02BE\u02B8\u02C1\u02BA\u02B5\u02B8\u02B2\u02B5\u02C0());
					if (this.menuStrings == null || this.menuStrings.Length == 0)
					{
						this.confirmMenu.\u02C0\u02B7\u02B3\u02B8\u02B2\u02B9\u02B2\u02BC\u02BE\u02B8\u02BD("part", "diff_coopghl", null, null, null, null);
						this.\u02B8\u02B5\u02B7\u02B7\u02B2\u02B6\u02BE\u02B3\u02B8\u02BD\u02BE(this.setlistOptions);
						return;
					}
					this.\u02C0\u02C1\u02BE\u02BF\u02B2\u02BC\u02C0\u02B4\u02B3\u02BD\u02C0 = 5;
					return;
				}
			}
			else if (num <= 4294967154U)
			{
				if (num != 4294967152U)
				{
					if (num != 29U)
					{
						goto IL_0844;
					}
					if (!(text == "></noparse>"))
					{
						goto IL_0844;
					}
					this.\u02C0\u02B3\u02BE\u02C1\u02B2\u02B2\u02BB\u02BD\u02B8\u02C1\u02B2((Instrument)39);
					return;
				}
				else
				{
					if (!(text == "ScoreDisabledPause"))
					{
						goto IL_0844;
					}
					this.confirmMenu.\u02B5\u02B8\u02C0\u02B7\u02BF\u02B7\u02B5\u02BD\u02C1\u02B8\u02B7("", "song", "Band", null, null, null);
					return;
				}
			}
			else if (num != 28U)
			{
				if (num != 88U)
				{
					goto IL_0844;
				}
				if (!(text == ""))
				{
					goto IL_0844;
				}
				this.\u02BE\u02B5\u02B5\u02C0\u02BA\u02BB\u02B8\u02B3\u02B8\u02B4\u02B3(Instrument.Bass);
				return;
			}
			else
			{
				if (!(text == "song"))
				{
					goto IL_0844;
				}
				if (CHNetManager.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B4\u02BA\u02B8\u02B6\u02BB\u02B5\u02B2\u02B8\u02B6\u02BB\u02BB)
				{
					(\u02B3\u02B7\u02B4\u02BE\u02BE\u02C1\u02BE\u02BB\u02B2\u02B9\u02BA.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B7\u02B7\u02B3\u02B2\u02BD\u02B4\u02BC\u02C1\u02B8\u02C0\u02BA as \u02B8\u02B4\u02B4\u02BE\u02B5\u02B6\u02B7\u02B7\u02BC\u02B5\u02B7).\u02B6\u02B4\u02BE\u02C1\u02BA\u02BA\u02B5\u02BA\u02B4\u02B3\u02BA(false);
					return;
				}
				this.setlistMenu.\u02B8\u02BA\u02B8\u02B4\u02B9\u02B5\u02B5\u02C1\u02B6\u02B7\u02B5(false);
				this.\u02B8\u02B5\u02B7\u02B7\u02B2\u02B6\u02BE\u02B3\u02B8\u02BD\u02BE(this.setlistOptions);
				return;
			}
			this.\u02B9\u02B9\u02BD\u02B2\u02B7\u02B4\u02C1\u02B7\u02BB\u02B2\u02B6();
			return;
			IL_0844:
			this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 = base.\u02B2\u02BF\u02BF\u02BE\u02BD\u02B8\u02BE\u02C0\u02B3\u02B3\u02C0;
			this.\u02B4\u02B8\u02C0\u02BC\u02C1\u02C1\u02B7\u02B2\u02B2\u02B4\u02B9();
			return;
		}
		if (\u02B5\u02B5\u02BA\u02B3\u02BC\u02BA\u02C0\u02B7\u02B6\u02BC\u02B9.\u02BA\u02B9\u02B8\u02B9\u02BD\u02B8\u02B4\u02B9\u02B8\u02BE\u02B7(base.\u02B2\u02BF\u02BF\u02BE\u02BD\u02B8\u02BE\u02C0\u02B3\u02B3\u02C0))
		{
			this.setlistMenu.\u02B8\u02BE\u02B3\u02B7\u02B2\u02B2\u02B5\u02B7\u02BB\u02BF\u02B3();
			this.\u02B8\u02B5\u02B7\u02B7\u02B2\u02B6\u02BE\u02B3\u02B8\u02BD\u02BE(this.setlistOptionsActive);
			return;
		}
		this.confirmMenu.\u02B5\u02B8\u02C0\u02B7\u02BF\u02B7\u02B5\u02BD\u02C1\u02B8\u02B7("_GlobalWhammyTexture", "Difficulty", null, null, null, null);
		this.\u02BE\u02B7\u02B2\u02B3\u02B5\u02B7\u02B7\u02B9\u02B3\u02BF\u02BC(this.setlistOptions);
	}

	protected virtual void \u02B3\u02C1\u02B9\u02B7\u02B4\u02BF\u02BD\u02B9\u02BB\u02BE\u02B6()
	{
		base.OnEnable();
		this.\u02B8\u02B5\u02B7\u02B7\u02B2\u02B6\u02BE\u02B3\u02B8\u02BD\u02BE(GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BD\u02B9\u02B7\u02B5\u02BF\u02BC\u02BF\u02BA\u02BE\u02B6\u02B4 ? this.mainOptionsPractice : this.mainOptions);
		base.\u02B7\u02B6\u02BC\u02BC\u02B3\u02BA\u02BE\u02C0\u02BF\u02B9\u02C1();
		if ((!this.\u02B4\u02BA\u02BC\u02BF\u02B3\u02BD\u02BE\u02C1\u02BC\u02C1\u02B6 && Application.platform == RuntimePlatform.OSXPlayer) || Application.platform == RuntimePlatform.OSXEditor)
		{
			for (int i = 1; i < this.mainOptions.Length; i += 0)
			{
				if (this.mainOptions[i] == ".jpeg")
				{
					this.mainOptions[i] = "%";
					break;
				}
			}
			for (int j = 1; j < this.mainOptionsPractice.Length; j += 0)
			{
				if (this.mainOptions[j] == "Yes")
				{
					this.mainOptions[j] = "Yes";
					break;
				}
			}
			this.\u02B4\u02BA\u02BC\u02BF\u02B3\u02BD\u02BE\u02C1\u02BC\u02C1\u02B6 = true;
		}
	}

	private void \u02BB\u02BF\u02B5\u02BD\u02B4\u02B8\u02B9\u02BD\u02B8\u02C1\u02B7()
	{
		if (\u02B5\u02B5\u02BA\u02B3\u02BC\u02BA\u02C0\u02B7\u02B6\u02BC\u02B9.\u02B3\u02B5\u02C0\u02B2\u02BB\u02BD\u02BE\u02BB\u02BA\u02B7\u02B7(\u02B5\u02B5\u02BA\u02B3\u02BC\u02BA\u02C0\u02B7\u02B6\u02BC\u02B9.\u02BC\u02BD\u02BE\u02BB\u02B2\u02B8\u02C0\u02B6\u02BA\u02B9\u02B7))
		{
			this.confirmMenu.\u02C0\u02B7\u02B3\u02B8\u02B2\u02B9\u02B2\u02BC\u02BE\u02B8\u02BD("Setlist was saved", "Continue", null, null, null, null);
		}
		else
		{
			this.confirmMenu.\u02C0\u02B7\u02B3\u02B8\u02B2\u02B9\u02B2\u02BC\u02BE\u02B8\u02BD("Problem saving setlist", "Continue", null, null, null, null);
		}
		base.\u02B7\u02B6\u02BC\u02BC\u02B3\u02BA\u02BE\u02C0\u02BF\u02B9\u02C1();
	}

	protected override void OnEnable()
	{
		base.OnEnable();
		this.\u02BE\u02B7\u02B2\u02B3\u02B5\u02B7\u02B7\u02B9\u02B3\u02BF\u02BC(GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BD\u02B9\u02B7\u02B5\u02BF\u02BC\u02BF\u02BA\u02BE\u02B6\u02B4 ? this.mainOptionsPractice : this.mainOptions);
		base.\u02B7\u02B6\u02BC\u02BC\u02B3\u02BA\u02BE\u02C0\u02BF\u02B9\u02C1();
		if ((!this.\u02B4\u02BA\u02BC\u02BF\u02B3\u02BD\u02BE\u02C1\u02BC\u02C1\u02B6 && Application.platform == RuntimePlatform.OSXPlayer) || Application.platform == RuntimePlatform.OSXEditor)
		{
			for (int i = 0; i < this.mainOptions.Length; i++)
			{
				if (this.mainOptions[i] == "Show in File Explorer")
				{
					this.mainOptions[i] = "Show in Finder";
					break;
				}
			}
			for (int j = 0; j < this.mainOptionsPractice.Length; j++)
			{
				if (this.mainOptions[j] == "Show in File Explorer")
				{
					this.mainOptions[j] = "Show in Finder";
					break;
				}
			}
			this.\u02B4\u02BA\u02BC\u02BF\u02B3\u02BD\u02BE\u02C1\u02BC\u02C1\u02B6 = true;
		}
	}

	private void \u02B9\u02B9\u02BD\u02B2\u02B7\u02B4\u02C1\u02B7\u02BB\u02B2\u02B6()
	{
		__FIXME_clon_util.\u02BA\u02BB\u02B7\u02B4\u02B2\u02BC\u02B4\u02B2\u02B9\u02B3\u02BD(this.songSelect.\u02BD\u02B6\u02BD\u02C0\u02C1\u02BE\u02BF\u02BB\u02BD\u02B8\u02BD.isEnc ? Path.GetDirectoryName(this.songSelect.\u02BD\u02B6\u02BD\u02C0\u02C1\u02BE\u02BF\u02BB\u02BD\u02B8\u02BD.folderPath) : this.songSelect.\u02BD\u02B6\u02BD\u02C0\u02C1\u02BE\u02BF\u02BB\u02BD\u02B8\u02BD.folderPath);
		this.\u02B3\u02BC\u02BA\u02C0\u02C0\u02B8\u02B2\u02B4\u02B3\u02C1\u02B8();
		this.\u02B3\u02BC\u02BA\u02C0\u02C0\u02B8\u02B2\u02B4\u02B3\u02C1\u02B8();
		base.\u02B7\u02B6\u02BC\u02BC\u02B3\u02BA\u02BE\u02C0\u02BF\u02B9\u02C1();
	}

	public virtual void \u02BA\u02B4\u02B9\u02B8\u02B2\u02C0\u02B4\u02B8\u02BF\u02BA\u02B2()
	{
		if (this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC != null)
		{
			this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC.Reset();
			this.\u02C0\u02BC\u02C0\u02BF\u02C1\u02B9\u02BD\u02B9\u02B2\u02BC\u02BA();
			return;
		}
		if (this.\u02BD\u02BD\u02B8\u02BE\u02B4\u02BC\u02BD\u02C1\u02BB\u02C0\u02BE == this.\u02B8\u02BD\u02BE\u02C1\u02BE\u02C0\u02B7\u02B5\u02C0\u02B7\u02BC.Length)
		{
			this.\u02BD\u02BD\u02B8\u02BE\u02B4\u02BC\u02BD\u02C1\u02BB\u02C0\u02BE = 1;
		}
		if (this.\u02B8\u02BD\u02BE\u02C1\u02BE\u02C0\u02B7\u02B5\u02C0\u02B7\u02BC[this.\u02BD\u02BD\u02B8\u02BE\u02B4\u02BC\u02BD\u02C1\u02BB\u02C0\u02BE] == 91)
		{
			this.\u02BD\u02BD\u02B8\u02BE\u02B4\u02BC\u02BD\u02C1\u02BB\u02C0\u02BE += 0;
		}
		else
		{
			this.\u02BD\u02BD\u02B8\u02BE\u02B4\u02BC\u02BD\u02C1\u02BB\u02C0\u02BE = 0;
		}
		if (this.\u02BD\u02BD\u02B8\u02BE\u02B4\u02BC\u02BD\u02C1\u02BB\u02C0\u02BE == 4)
		{
			this.\u02B8\u02B5\u02B7\u02B7\u02B2\u02B6\u02BE\u02B3\u02B8\u02BD\u02BE(this.extraOptions);
		}
		if (this.\u02BD\u02BD\u02B8\u02BE\u02B4\u02BC\u02BD\u02C1\u02BB\u02C0\u02BE == -10)
		{
			this.\u02BE\u02B7\u02B2\u02B3\u02B5\u02B7\u02B7\u02B9\u02B3\u02BF\u02BC(this.extraOptions2);
		}
		if (this.\u02BD\u02BD\u02B8\u02BE\u02B4\u02BC\u02BD\u02C1\u02BB\u02C0\u02BE == this.\u02B8\u02BD\u02BE\u02C1\u02BE\u02C0\u02B7\u02B5\u02C0\u02B7\u02BC.Length)
		{
			this.\u02B8\u02B5\u02B7\u02B7\u02B2\u02B6\u02BE\u02B3\u02B8\u02BD\u02BE(this.extraOptions3);
		}
	}

	private void \u02B4\u02B8\u02C0\u02BC\u02C1\u02C1\u02B7\u02B2\u02B2\u02B4\u02B9()
	{
		if (this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 == "Song Speed")
		{
			this.textObjects[this.\u02B3\u02BF\u02BB\u02BB\u02B5\u02B7\u02B8\u02BE\u02B7\u02B3\u02B3].text = this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC.GetPercentString;
			this.songSelect.\u02B3\u02C1\u02C0\u02B2\u02B9\u02BB\u02B6\u02B6\u02B4\u02C0\u02BB();
		}
		base.\u02B7\u02B6\u02BC\u02BC\u02B3\u02BA\u02BE\u02C0\u02BF\u02B9\u02C1();
	}

	private void \u02B4\u02BA\u02B9\u02BB\u02BE\u02BE\u02BC\u02BD\u02BC\u02BF\u02BE()
	{
		this.confirmMenu.\u02B7\u02B3\u02BC\u02BE\u02BF\u02B7\u02B4\u02C0\u02B9\u02BC\u02BF("Default Search By Current Sort", "album", "<uppercase>", new ConfirmationMenu.\u02BF\u02B3\u02BF\u02BF\u02C0\u02B2\u02BE\u02B8\u02B6\u02BD\u02B7(this.\u02C0\u02BC\u02C1\u02B3\u02B9\u02B2\u02B9\u02BB\u02B3\u02B7\u02B9), null, null);
	}

	public virtual void \u02B7\u02B9\u02B8\u02C0\u02BC\u02B9\u02BC\u02B3\u02B9\u02C0\u02B3()
	{
		if (this.\u02BD\u02BD\u02B8\u02BE\u02B4\u02BC\u02BD\u02C1\u02BB\u02C0\u02BE == this.\u02B8\u02BD\u02BE\u02C1\u02BE\u02C0\u02B7\u02B5\u02C0\u02B7\u02BC.Length)
		{
			this.\u02BD\u02BD\u02B8\u02BE\u02B4\u02BC\u02BD\u02C1\u02BB\u02C0\u02BE = 1;
		}
		if (this.\u02B8\u02BD\u02BE\u02C1\u02BE\u02C0\u02B7\u02B5\u02C0\u02B7\u02BC[this.\u02BD\u02BD\u02B8\u02BE\u02B4\u02BC\u02BD\u02C1\u02BB\u02C0\u02BE] == -106)
		{
			this.\u02BD\u02BD\u02B8\u02BE\u02B4\u02BC\u02BD\u02C1\u02BB\u02C0\u02BE++;
			return;
		}
		this.\u02BD\u02BD\u02B8\u02BE\u02B4\u02BC\u02BD\u02C1\u02BB\u02C0\u02BE = 1;
	}

	private void \u02BA\u02BC\u02BA\u02B8\u02B6\u02C0\u02B4\u02BB\u02B8\u02B3\u02BF()
	{
		string folderPath = \u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02BD\u02BD\u02B6\u02B3\u02B2\u02B6\u02BB\u02BF\u02BE\u02B6\u02B4[this.songSelect.\u02BF\u02B6\u02B5\u02BF\u02BD\u02BF\u02B4\u02B3\u02B8\u02BE\u02BC].folderPath;
		bool flag = false;
		if (BassAudioManager.Instance.\u02C0\u02B4\u02B5\u02B4\u02BA\u02B2\u02BB\u02BB\u02BB\u02B8\u02B8)
		{
			BassAudioManager.Instance.\u02BD\u02C1\u02B5\u02B5\u02B7\u02C0\u02BE\u02B4\u02BF\u02B7\u02BF();
		}
		try
		{
			Directory.Delete(folderPath, false);
		}
		catch
		{
			flag = true;
		}
		\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02BD\u02BD\u02B6\u02B3\u02B2\u02B6\u02BB\u02BF\u02BE\u02B6\u02B4.RemoveAt(this.songSelect.\u02BF\u02B6\u02B5\u02BF\u02BD\u02BF\u02B4\u02B3\u02B8\u02BE\u02BC);
		\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02B3\u02B8\u02B2\u02BF\u02C0\u02B6\u02C1\u02BD\u02B3\u02B8\u02B9(\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02C1\u02BA\u02BE\u02C1\u02B5\u02BB\u02B9\u02B4\u02B2\u02C1\u02BF, false);
		this.songSelect.\u02BA\u02BD\u02B3\u02BC\u02B8\u02BB\u02B8\u02BA\u02B5\u02C0\u02C0();
		if (\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02BD\u02BD\u02B6\u02B3\u02B2\u02B6\u02BB\u02BF\u02BE\u02B6\u02B4.Count == 0)
		{
			\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02BD\u02BD\u02B6\u02B3\u02B2\u02B6\u02BB\u02BF\u02BE\u02B6\u02B4.Clear();
			this.songSelect.\u02B3\u02BC\u02BA\u02C0\u02C0\u02B8\u02B2\u02B4\u02B3\u02C1\u02B8();
		}
		else if (this.songSelect.\u02BF\u02B6\u02B5\u02BF\u02BD\u02BF\u02B4\u02B3\u02B8\u02BE\u02BC >= \u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02BD\u02BD\u02B6\u02B3\u02B2\u02B6\u02BB\u02BF\u02BE\u02B6\u02B4.Count)
		{
			this.songSelect.\u02B5\u02B6\u02B8\u02BC\u02BF\u02BF\u02BC\u02B5\u02C0\u02BB\u02C0(1, true);
		}
		else
		{
			this.songSelect.\u02B5\u02B6\u02B8\u02BC\u02BF\u02BF\u02BC\u02B5\u02C0\u02BB\u02C0(this.songSelect.\u02BF\u02B6\u02B5\u02BF\u02BD\u02BF\u02B4\u02B3\u02B8\u02BE\u02BC, true);
		}
		base.gameObject.SetActive(true);
		if (flag)
		{
			this.confirmMenu.\u02B7\u02B3\u02BC\u02BE\u02BF\u02B7\u02B4\u02C0\u02B9\u02BC\u02BF("Clone Hero", "song", null, null, null, null);
		}
		base.\u02B7\u02B6\u02BC\u02BC\u02B3\u02BA\u02BE\u02C0\u02BF\u02B9\u02C1();
	}

	private void \u02B7\u02C0\u02BF\u02BD\u02B3\u02B4\u02B8\u02BB\u02B9\u02B8\u02BE()
	{
		bool flag = false;
		foreach (char c in Input.inputString)
		{
			if (c == '\b')
			{
				if (this.textObjects[0].text.Length > 0)
				{
					this.textObjects[0].text = this.textObjects[0].text.Substring(0, this.textObjects[0].text.Length - 1);
				}
			}
			else
			{
				if (c == '\n' || c == '\r')
				{
					flag = true;
					break;
				}
				if ((this.textObjects[0].text.Length != 0 || c != ' ') && this.textObjects[0].text.Length != 15)
				{
					TextMeshProUGUI textMeshProUGUI = this.textObjects[0];
					textMeshProUGUI.text += c.ToString();
					this.textObjects[0].text = Regex.Replace(this.textObjects[0].text, "[^\\u0020-\\u007E]", string.Empty);
					if (string.IsNullOrEmpty(this.textObjects[0].text))
					{
						this.textObjects[0].text = "";
					}
				}
			}
		}
		bool flag2 = false;
		bool flag3 = false;
		foreach (\u02C1\u02BB\u02BD\u02B7\u02BD\u02BB\u02BE\u02B5\u02B7\u02C0\u02B6 u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B in GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B8\u02BD\u02B2\u02B2\u02B7\u02B5\u02B5\u02B3\u02C0\u02BD\u02BF)
		{
			if (u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B != null && u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.rewiredPlayer != null && !u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.\u02BD\u02BC\u02B8\u02B5\u02B5\u02B2\u02C0\u02C1\u02B3\u02C0\u02B4)
			{
				if (u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.rewiredPlayer.GetButtonDown(0))
				{
					flag2 = true;
					break;
				}
				if (u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.rewiredPlayer.GetButtonDown(1))
				{
					flag3 = true;
					break;
				}
			}
		}
		if (Input.GetKeyUp(KeyCode.Return) || Input.GetKeyUp(KeyCode.KeypadEnter) || flag)
		{
			flag2 = true;
		}
		if (Input.GetKeyUp(KeyCode.Escape))
		{
			flag3 = true;
		}
		if (!flag2)
		{
			if (flag3)
			{
				this.\u02B3\u02BB\u02BF\u02C0\u02BB\u02B6\u02B5\u02B9\u02B8\u02BE\u02B9 = false;
				this.\u02BE\u02B7\u02B2\u02B3\u02B5\u02B7\u02B7\u02B9\u02B3\u02BF\u02BC(this.setlistOptionsActive);
				base.\u02B5\u02B6\u02B8\u02BC\u02BF\u02BF\u02BC\u02B5\u02C0\u02BB\u02C0(this.\u02BA\u02BE\u02B9\u02B8\u02B3\u02BB\u02BB\u02C0\u02BF\u02C0\u02BE ? "Rename Setlist" : "Save Playlist");
				\u02C1\u02BB\u02BD\u02B7\u02BD\u02BB\u02BE\u02B5\u02B7\u02C0\u02B6.\u02B2\u02B9\u02B6\u02B2\u02C0\u02BA\u02BF\u02B8\u02B5\u02B3\u02B6(true);
			}
			return;
		}
		if (this.textObjects[0].text.Length == 0)
		{
			return;
		}
		string text = this.textObjects[0].text.Trim();
		if (this.\u02BA\u02BE\u02B9\u02B8\u02B3\u02BB\u02BB\u02C0\u02BF\u02C0\u02BE)
		{
			\u02B5\u02B5\u02BA\u02B3\u02BC\u02BA\u02C0\u02B7\u02B6\u02BC\u02B9.\u02B4\u02B4\u02C0\u02BD\u02BB\u02BB\u02C0\u02B5\u02B9\u02B5\u02B5(text);
		}
		else
		{
			\u02B5\u02B5\u02BA\u02B3\u02BC\u02BA\u02C0\u02B7\u02B6\u02BC\u02B9.\u02BC\u02BD\u02BE\u02BB\u02B2\u02B8\u02C0\u02B6\u02BA\u02B9\u02B7 = text;
			if (\u02B5\u02B5\u02BA\u02B3\u02BC\u02BA\u02C0\u02B7\u02B6\u02BC\u02B9.\u02C1\u02BC\u02B7\u02B8\u02B9\u02B4\u02BC\u02B9\u02B5\u02B8\u02B7(\u02B5\u02B5\u02BA\u02B3\u02BC\u02BA\u02C0\u02B7\u02B6\u02BC\u02B9.\u02BC\u02BD\u02BE\u02BB\u02B2\u02B8\u02C0\u02B6\u02BA\u02B9\u02B7))
			{
				this.confirmMenu.\u02C0\u02B7\u02B3\u02B8\u02B2\u02B9\u02B2\u02BC\u02BE\u02B8\u02BD("A setlist with that name already exists", "Overwrite", "Cancel", new ConfirmationMenu.\u02BF\u02B3\u02BF\u02BF\u02C0\u02B2\u02BE\u02B8\u02B6\u02BD\u02B7(this.\u02BB\u02BF\u02B5\u02BD\u02B4\u02B8\u02B9\u02BD\u02B8\u02C1\u02B7), null, null);
			}
			else
			{
				this.\u02BB\u02BF\u02B5\u02BD\u02B4\u02B8\u02B9\u02BD\u02B8\u02C1\u02B7();
			}
		}
		this.setlistMenu.\u02BC\u02BF\u02B3\u02BB\u02B4\u02BD\u02BF\u02B3\u02B4\u02B8\u02B8();
		this.\u02B3\u02BB\u02BF\u02C0\u02BB\u02B6\u02B5\u02B9\u02B8\u02BE\u02B9 = false;
		this.\u02BE\u02B7\u02B2\u02B3\u02B5\u02B7\u02B7\u02B9\u02B3\u02BF\u02BC(this.setlistOptionsActive);
		base.\u02B5\u02B6\u02B8\u02BC\u02BF\u02BF\u02BC\u02B5\u02C0\u02BB\u02C0(this.\u02BA\u02BE\u02B9\u02B8\u02B3\u02BB\u02BB\u02C0\u02BF\u02C0\u02BE ? "Rename Setlist" : "Save Playlist");
		\u02C1\u02BB\u02BD\u02B7\u02BD\u02BB\u02BE\u02B5\u02B7\u02C0\u02B6.\u02B2\u02B9\u02B6\u02B2\u02C0\u02BA\u02BF\u02B8\u02B5\u02B3\u02B6(true);
	}

	private void \u02B8\u02B5\u02B7\u02B7\u02B2\u02B6\u02BE\u02B3\u02B8\u02BD\u02BE(string[] \u02BC\u02C0\u02B2\u02B5\u02BE\u02B7\u02C1\u02B4\u02B7\u02BD\u02C0)
	{
		if (\u02BC\u02C0\u02B2\u02B5\u02BE\u02B7\u02C1\u02B4\u02B7\u02BD\u02C0 == this.menuStrings)
		{
			this.\u02B5\u02B6\u02B8\u02BC\u02BF\u02BF\u02BC\u02B5\u02C0\u02BB\u02C0(this.\u02B6\u02B5\u02B7\u02BD\u02B4\u02BA\u02B6\u02B9\u02B2\u02B3\u02B4, true);
			this.\u02B6\u02B5\u02B7\u02BD\u02B4\u02BA\u02B6\u02B9\u02B2\u02B3\u02B4 = -1;
			return;
		}
		this.menuStrings = \u02BC\u02C0\u02B2\u02B5\u02BE\u02B7\u02C1\u02B4\u02B7\u02BD\u02C0;
		if (\u02BC\u02C0\u02B2\u02B5\u02BE\u02B7\u02C1\u02B4\u02B7\u02BD\u02C0 == this.mainOptions || \u02BC\u02C0\u02B2\u02B5\u02BE\u02B7\u02C1\u02B4\u02B7\u02BD\u02C0 == this.mainOptionsPractice)
		{
			this.\u02C0\u02C1\u02BE\u02BF\u02B2\u02BC\u02C0\u02B4\u02B3\u02BD\u02C0 = 1;
		}
		if (\u02BC\u02C0\u02B2\u02B5\u02BE\u02B7\u02C1\u02B4\u02B7\u02BD\u02C0 == this.setlistOptions || \u02BC\u02C0\u02B2\u02B5\u02BE\u02B7\u02C1\u02B4\u02B7\u02BD\u02C0 == this.setlistOptionsActive)
		{
			this.\u02C0\u02C1\u02BE\u02BF\u02B2\u02BC\u02C0\u02B4\u02B3\u02BD\u02C0 = 6;
		}
		this.\u02BA\u02BD\u02B3\u02BC\u02B8\u02BB\u02B8\u02BA\u02B5\u02C0\u02C0();
		this.\u02B5\u02B6\u02B8\u02BC\u02BF\u02BF\u02BC\u02B5\u02C0\u02BB\u02C0(0, false);
		base.\u02B7\u02B6\u02BC\u02BC\u02B3\u02BA\u02BE\u02C0\u02BF\u02B9\u02C1();
	}

	public virtual void \u02B5\u02C0\u02B9\u02B3\u02B8\u02BB\u02B6\u02B4\u02C0\u02BB\u02BA()
	{
		if (this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 == ".ini")
		{
			this.\u02C0\u02BC\u02C0\u02BF\u02C1\u02B9\u02BD\u02B9\u02B2\u02BC\u02BA();
		}
	}

	private void \u02B7\u02B9\u02B3\u02B3\u02BC\u02C1\u02BC\u02BA\u02B3\u02B8\u02B6()
	{
		int num = \u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02BF\u02B8\u02B3\u02B8\u02B9\u02C0\u02C0\u02B7\u02B7\u02BC\u02C0(this.songSelect.\u02BF\u02B6\u02B5\u02BF\u02BD\u02BF\u02B4\u02B3\u02B8\u02BE\u02BC);
		this.songSelect.\u02BA\u02BD\u02B3\u02BC\u02B8\u02BB\u02B8\u02BA\u02B5\u02C0\u02C0();
		this.songSelect.\u02B5\u02B6\u02B8\u02BC\u02BF\u02BF\u02BC\u02B5\u02C0\u02BB\u02C0(num, false);
		this.\u02B3\u02BC\u02BA\u02C0\u02C0\u02B8\u02B2\u02B4\u02B3\u02C1\u02B8();
		base.\u02B7\u02B6\u02BC\u02BC\u02B3\u02BA\u02BE\u02C0\u02BF\u02B9\u02C1();
	}

	public virtual void \u02BB\u02B3\u02BB\u02B7\u02C1\u02B7\u02B2\u02B8\u02B7\u02BB\u02BF()
	{
		if (this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 == "Enabled")
		{
			this.\u02B4\u02B8\u02C0\u02BC\u02C1\u02C1\u02B7\u02B2\u02B2\u02B4\u02B9();
		}
	}

	protected override void Update()
	{
		if (this.confirmMenu.\u02BF\u02C1\u02B2\u02C1\u02B4\u02B8\u02BF\u02C1\u02C1\u02B9\u02B8)
		{
			return;
		}
		if (this.\u02B3\u02BB\u02BF\u02C0\u02BB\u02B6\u02B5\u02B9\u02B8\u02BE\u02B9)
		{
			this.\u02B7\u02C0\u02BF\u02BD\u02B3\u02B4\u02B8\u02BB\u02B9\u02B8\u02BE();
			return;
		}
		base.Update();
	}

	private void \u02BE\u02B5\u02B5\u02C0\u02BA\u02BB\u02B8\u02B3\u02B8\u02B4\u02B3(Instrument \u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF)
	{
		GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BA\u02C0\u02B4\u02B6\u02BE\u02B4\u02BA\u02BF\u02B5\u02BD\u02B2 = true;
		this.songSelect.\u02C0\u02BE\u02B5\u02B2\u02B7\u02B7\u02C0\u02BD\u02BA\u02B3\u02BB = new Instrument?(\u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF);
	}

	private void \u02C0\u02BC\u02C1\u02B3\u02B9\u02B2\u02B9\u02BB\u02B3\u02B7\u02B9()
	{
		string folderPath = \u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02BD\u02BD\u02B6\u02B3\u02B2\u02B6\u02BB\u02BF\u02BE\u02B6\u02B4[this.songSelect.\u02BF\u02B6\u02B5\u02BF\u02BD\u02BF\u02B4\u02B3\u02B8\u02BE\u02BC].folderPath;
		bool flag = false;
		if (BassAudioManager.Instance.\u02C0\u02B4\u02B5\u02B4\u02BA\u02B2\u02BB\u02BB\u02BB\u02B8\u02B8)
		{
			BassAudioManager.Instance.\u02BD\u02C1\u02B5\u02B5\u02B7\u02C0\u02BE\u02B4\u02BF\u02B7\u02BF();
		}
		try
		{
			Directory.Delete(folderPath, true);
		}
		catch
		{
			flag = true;
		}
		\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02BD\u02BD\u02B6\u02B3\u02B2\u02B6\u02BB\u02BF\u02BE\u02B6\u02B4.RemoveAt(this.songSelect.\u02BF\u02B6\u02B5\u02BF\u02BD\u02BF\u02B4\u02B3\u02B8\u02BE\u02BC);
		\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02B3\u02B8\u02B2\u02BF\u02C0\u02B6\u02C1\u02BD\u02B3\u02B8\u02B9(\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02C1\u02BA\u02BE\u02C1\u02B5\u02BB\u02B9\u02B4\u02B2\u02C1\u02BF, false);
		this.songSelect.\u02BA\u02BD\u02B3\u02BC\u02B8\u02BB\u02B8\u02BA\u02B5\u02C0\u02C0();
		if (\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02BD\u02BD\u02B6\u02B3\u02B2\u02B6\u02BB\u02BF\u02BE\u02B6\u02B4.Count == 1)
		{
			\u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02BD\u02BD\u02B6\u02B3\u02B2\u02B6\u02BB\u02BF\u02BE\u02B6\u02B4.Clear();
			this.songSelect.\u02B3\u02BC\u02BA\u02C0\u02C0\u02B8\u02B2\u02B4\u02B3\u02C1\u02B8();
		}
		else if (this.songSelect.\u02BF\u02B6\u02B5\u02BF\u02BD\u02BF\u02B4\u02B3\u02B8\u02BE\u02BC >= \u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02BD\u02BD\u02B6\u02B3\u02B2\u02B6\u02BB\u02BF\u02BE\u02B6\u02B4.Count)
		{
			this.songSelect.\u02B5\u02B6\u02B8\u02BC\u02BF\u02BF\u02BC\u02B5\u02C0\u02BB\u02C0(1, true);
		}
		else
		{
			this.songSelect.\u02B5\u02B6\u02B8\u02BC\u02BF\u02BF\u02BC\u02B5\u02C0\u02BB\u02C0(this.songSelect.\u02BF\u02B6\u02B5\u02BF\u02BD\u02BF\u02B4\u02B3\u02B8\u02BE\u02BC, true);
		}
		base.gameObject.SetActive(false);
		if (flag)
		{
			this.confirmMenu.\u02C0\u02B7\u02B3\u02B8\u02B2\u02B9\u02B2\u02BC\u02BE\u02B8\u02BD("There was an error deleting the file", "Continue", null, null, null, null);
		}
		base.\u02B7\u02B6\u02BC\u02BC\u02B3\u02BA\u02BE\u02C0\u02BF\u02B9\u02C1();
	}

	public override void \u02BA\u02B4\u02BC\u02B6\u02BC\u02B7\u02BD\u02B3\u02BA\u02BE\u02C0()
	{
		if (this.\u02BD\u02BD\u02B8\u02BE\u02B4\u02BC\u02BD\u02C1\u02BB\u02C0\u02BE == this.\u02B8\u02BD\u02BE\u02C1\u02BE\u02C0\u02B7\u02B5\u02C0\u02B7\u02BC.Length)
		{
			this.\u02BD\u02BD\u02B8\u02BE\u02B4\u02BC\u02BD\u02C1\u02BB\u02C0\u02BE = 0;
		}
		if (this.\u02B8\u02BD\u02BE\u02C1\u02BE\u02C0\u02B7\u02B5\u02C0\u02B7\u02BC[this.\u02BD\u02BD\u02B8\u02BE\u02B4\u02BC\u02BD\u02C1\u02BB\u02C0\u02BE] == 29)
		{
			this.\u02BD\u02BD\u02B8\u02BE\u02B4\u02BC\u02BD\u02C1\u02BB\u02C0\u02BE++;
			return;
		}
		this.\u02BD\u02BD\u02B8\u02BE\u02B4\u02BC\u02BD\u02C1\u02BB\u02C0\u02BE = 0;
	}

	public override void \u02B5\u02C1\u02BA\u02BB\u02B2\u02B9\u02C1\u02BB\u02B9\u02BA\u02B3()
	{
		this.\u02BD\u02BD\u02B8\u02BE\u02B4\u02BC\u02BD\u02C1\u02BB\u02C0\u02BE = 0;
		this.allowMultiLanguage = true;
		if (this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 != null)
		{
			this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = null;
			this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 = null;
			this.\u02B9\u02B8\u02C0\u02B7\u02BA\u02B3\u02BB\u02C0\u02B3\u02C1\u02B8();
			return;
		}
		if (this.\u02C0\u02C1\u02BE\u02BF\u02B2\u02BC\u02C0\u02B4\u02B3\u02BD\u02C0 == 3)
		{
			this.confirmMenu.\u02C0\u02B7\u02B3\u02B8\u02B2\u02B9\u02B2\u02BC\u02BE\u02B8\u02BD("setlistDeleteDialog", "Yes", "No", new ConfirmationMenu.\u02BF\u02B3\u02BF\u02BF\u02C0\u02B2\u02BE\u02B8\u02B6\u02BD\u02B7(this.\u02BC\u02BE\u02B8\u02BA\u02C0\u02B5\u02C0\u02BE\u02BF\u02BC\u02BA), null, null);
			return;
		}
		if (this.\u02C0\u02C1\u02BE\u02BF\u02B2\u02BC\u02C0\u02B4\u02B3\u02BD\u02C0 != 4)
		{
			string text = base.\u02B2\u02BF\u02BF\u02BE\u02BD\u02B8\u02BE\u02C0\u02B3\u02B3\u02C0;
			uint num = PrivateImplementationDetails.ComputeStringHash(text);
			if (num <= 2242673754U)
			{
				if (num <= 1422873973U)
				{
					if (num <= 600350426U)
					{
						if (num != 142991090U)
						{
							if (num != 351440407U)
							{
								if (num != 600350426U)
								{
									goto IL_0844;
								}
								if (!(text == "Show in File Explorer"))
								{
									goto IL_0844;
								}
							}
							else
							{
								if (!(text == "Random Song"))
								{
									goto IL_0844;
								}
								this.\u02B7\u02B2\u02BA\u02B7\u02BE\u02B8\u02BE\u02BB\u02B5\u02C1\u02BB();
								return;
							}
						}
						else
						{
							if (!(text == "Delete Setlist"))
							{
								goto IL_0844;
							}
							this.allowMultiLanguage = false;
							this.\u02BE\u02B7\u02B2\u02B3\u02B5\u02B7\u02B7\u02B9\u02B3\u02BF\u02BC(\u02B5\u02B5\u02BA\u02B3\u02BC\u02BA\u02C0\u02B7\u02B6\u02BC\u02B9.\u02B3\u02B7\u02BE\u02B8\u02C1\u02BA\u02B5\u02B8\u02B2\u02B5\u02C0());
							if (this.menuStrings == null || this.menuStrings.Length == 0)
							{
								this.confirmMenu.\u02C0\u02B7\u02B3\u02B8\u02B2\u02B9\u02B2\u02BC\u02BE\u02B8\u02BD("setlistNoSavedDialog", "Continue", null, null, null, null);
								this.\u02BE\u02B7\u02B2\u02B3\u02B5\u02B7\u02B7\u02B9\u02B3\u02BF\u02BC(this.setlistOptions);
								return;
							}
							this.\u02C0\u02C1\u02BE\u02BF\u02B2\u02BC\u02C0\u02B4\u02B3\u02BD\u02C0 = 3;
							return;
						}
					}
					else if (num <= 1085873417U)
					{
						if (num != 911050688U)
						{
							if (num != 1085873417U)
							{
								goto IL_0844;
							}
							if (!(text == "6-fret Guitar"))
							{
								goto IL_0844;
							}
							this.\u02C0\u02B3\u02BE\u02C1\u02B2\u02B2\u02BB\u02BD\u02B8\u02C1\u02B2(Instrument.GHLGuitar);
							return;
						}
						else
						{
							if (!(text == "Save Setlist"))
							{
								goto IL_0844;
							}
							if (\u02B5\u02B5\u02BA\u02B3\u02BC\u02BA\u02C0\u02B7\u02B6\u02BC\u02B9.\u02BC\u02BD\u02BE\u02BB\u02B2\u02B8\u02C0\u02B6\u02BA\u02B9\u02B7 == null)
							{
								this.\u02B3\u02BB\u02BF\u02C0\u02BB\u02B6\u02B5\u02B9\u02B8\u02BE\u02B9 = true;
								this.\u02BA\u02BE\u02B9\u02B8\u02B3\u02BB\u02BB\u02C0\u02BF\u02C0\u02BE = false;
								this.\u02B5\u02B7\u02C0\u02B6\u02BF\u02B6\u02BC\u02BE\u02B6\u02B8\u02B2();
								return;
							}
							if (\u02B5\u02B5\u02BA\u02B3\u02BC\u02BA\u02C0\u02B7\u02B6\u02BC\u02B9.\u02C1\u02BC\u02B7\u02B8\u02B9\u02B4\u02BC\u02B9\u02B5\u02B8\u02B7(\u02B5\u02B5\u02BA\u02B3\u02BC\u02BA\u02C0\u02B7\u02B6\u02BC\u02B9.\u02BC\u02BD\u02BE\u02BB\u02B2\u02B8\u02C0\u02B6\u02BA\u02B9\u02B7) && \u02B5\u02B5\u02BA\u02B3\u02BC\u02BA\u02C0\u02B7\u02B6\u02BC\u02B9.\u02B5\u02BC\u02B8\u02B9\u02B3\u02B6\u02C1\u02BA\u02C0\u02B9\u02BA != null)
							{
								this.confirmMenu.\u02C0\u02B7\u02B3\u02B8\u02B2\u02B9\u02B2\u02BC\u02BE\u02B8\u02BD("A setlist with that name already exists", "Overwrite", "Cancel", new ConfirmationMenu.\u02BF\u02B3\u02BF\u02BF\u02C0\u02B2\u02BE\u02B8\u02B6\u02BD\u02B7(this.\u02BB\u02BF\u02B5\u02BD\u02B4\u02B8\u02B9\u02BD\u02B8\u02C1\u02B7), null, null);
								return;
							}
							this.\u02BB\u02BF\u02B5\u02BD\u02B4\u02B8\u02B9\u02BD\u02B8\u02C1\u02B7();
							return;
						}
					}
					else if (num != 1302297434U)
					{
						if (num != 1422873973U)
						{
							goto IL_0844;
						}
						if (!(text == "Rhythm Guitar"))
						{
							goto IL_0844;
						}
						this.\u02C0\u02B3\u02BE\u02C1\u02B2\u02B2\u02BB\u02BD\u02B8\u02C1\u02B2(Instrument.Rhythm);
						return;
					}
					else
					{
						if (!(text == "6-fret Guitar Coop"))
						{
							goto IL_0844;
						}
						this.\u02C0\u02B3\u02BE\u02C1\u02B2\u02B2\u02BB\u02BD\u02B8\u02C1\u02B2(Instrument.GHLGuitarCoop);
						return;
					}
				}
				else if (num <= 1859600033U)
				{
					if (num != 1569119161U)
					{
						if (num != 1613443821U)
						{
							if (num != 1859600033U)
							{
								goto IL_0844;
							}
							if (!(text == "Pro Drums"))
							{
								goto IL_0844;
							}
							this.\u02C0\u02B3\u02BE\u02C1\u02B2\u02B2\u02BB\u02BD\u02B8\u02C1\u02B2(Instrument.ProDrums);
							return;
						}
						else
						{
							if (!(text == "Keys"))
							{
								goto IL_0844;
							}
							this.\u02C0\u02B3\u02BE\u02C1\u02B2\u02B2\u02BB\u02BD\u02B8\u02C1\u02B2(Instrument.Keys);
							return;
						}
					}
					else
					{
						if (!(text == "Create Setlist"))
						{
							goto IL_0844;
						}
						\u02B5\u02B5\u02BA\u02B3\u02BC\u02BA\u02C0\u02B7\u02B6\u02BC\u02B9.\u02BC\u02BD\u02BE\u02BB\u02B2\u02B8\u02C0\u02B6\u02BA\u02B9\u02B7 = \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6("New Setlist");
						\u02B5\u02B5\u02BA\u02B3\u02BC\u02BA\u02C0\u02B7\u02B6\u02BC\u02B9.\u02B5\u02BC\u02B8\u02B9\u02B3\u02B6\u02C1\u02BA\u02C0\u02B9\u02BA = null;
						\u02B5\u02B5\u02BA\u02B3\u02BC\u02BA\u02C0\u02B7\u02B6\u02BC\u02B9.\u02B7\u02BA\u02B6\u02C1\u02BD\u02B2\u02B5\u02B7\u02B5\u02B2\u02B8 = false;
						object obj = \u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02BE\u02B3\u02BE\u02BF\u02B3\u02C1\u02B3\u02BF\u02BE\u02B3\u02B7(this.songSelect.\u02BF\u02B6\u02B5\u02BF\u02BD\u02BF\u02B4\u02B3\u02B8\u02BE\u02BC);
						if (obj is \u02C1\u02BD\u02B8\u02B2\u02B3\u02BA\u02B8\u02B8\u02C0\u02B6\u02B8)
						{
							\u02C1\u02BD\u02B8\u02B2\u02B3\u02BA\u02B8\u02B8\u02C0\u02B6\u02B8 u02C1_u02BD_u02B8_u02B2_u02B3_u02BA_u02B8_u02B8_u02C0_u02B6_u02B = (\u02C1\u02BD\u02B8\u02B2\u02B3\u02BA\u02B8\u02B8\u02C0\u02B6\u02B8)obj;
							if (u02C1_u02BD_u02B8_u02B2_u02B3_u02BA_u02B8_u02B8_u02C0_u02B6_u02B == null || u02C1_u02BD_u02B8_u02B2_u02B3_u02BA_u02B8_u02B8_u02C0_u02B6_u02B.\u02B5\u02B5\u02B6\u02B8\u02B5\u02BF\u02BF\u02B6\u02BB\u02BA\u02B5 == null || u02C1_u02BD_u02B8_u02B2_u02B3_u02BA_u02B8_u02B8_u02C0_u02B6_u02B.\u02B5\u02B5\u02B6\u02B8\u02B5\u02BF\u02BF\u02B6\u02BB\u02BA\u02B5.Count == 0)
							{
								return;
							}
							for (int i = 0; i < u02C1_u02BD_u02B8_u02B2_u02B3_u02BA_u02B8_u02B8_u02C0_u02B6_u02B.\u02B5\u02B5\u02B6\u02B8\u02B5\u02BF\u02BF\u02B6\u02BB\u02BA\u02B5.Count; i++)
							{
								this.setlistMenu.\u02BA\u02B4\u02B2\u02BB\u02B9\u02BC\u02B9\u02B8\u02C1\u02B5\u02BE(u02C1_u02BD_u02B8_u02B2_u02B3_u02BA_u02B8_u02B8_u02C0_u02B6_u02B.\u02B5\u02B5\u02B6\u02B8\u02B5\u02BF\u02BF\u02B6\u02BB\u02BA\u02B5[i], SettingsController.\u02B3\u02B7\u02B4\u02BA\u02B3\u02B9\u02B7\u02BE\u02B2\u02B7\u02BE.CurrentValue, "");
							}
						}
						else
						{
							this.setlistMenu.\u02BA\u02B4\u02B2\u02BB\u02B9\u02BC\u02B9\u02B8\u02C1\u02B5\u02BE((SongEntry)obj, SettingsController.\u02B3\u02B7\u02B4\u02BA\u02B3\u02B9\u02B7\u02BE\u02B2\u02B7\u02BE.CurrentValue, "");
						}
						this.\u02B8\u02B6\u02B9\u02BF\u02BF\u02BD\u02B6\u02B7\u02B3\u02BA\u02B9(true, false);
						return;
					}
				}
				else if (num <= 1934646368U)
				{
					if (num != 1934333424U)
					{
						if (num != 1934646368U)
						{
							goto IL_0844;
						}
						if (!(text == "6-fret Bass"))
						{
							goto IL_0844;
						}
						this.\u02C0\u02B3\u02BE\u02C1\u02B2\u02B2\u02BB\u02BD\u02B8\u02C1\u02B2(Instrument.GHLBass);
						return;
					}
					else
					{
						if (!(text == "Guitar Coop"))
						{
							goto IL_0844;
						}
						this.\u02C0\u02B3\u02BE\u02C1\u02B2\u02B2\u02BB\u02BD\u02B8\u02C1\u02B2(Instrument.GuitarCoop);
						return;
					}
				}
				else if (num != 1939545255U)
				{
					if (num != 2242673754U)
					{
						goto IL_0844;
					}
					if (!(text == "Drums"))
					{
						goto IL_0844;
					}
					this.\u02C0\u02B3\u02BE\u02C1\u02B2\u02B2\u02BB\u02BD\u02B8\u02C1\u02B2(Instrument.Drums);
					return;
				}
				else
				{
					if (!(text == "Rename Setlist"))
					{
						goto IL_0844;
					}
					this.\u02B3\u02BB\u02BF\u02C0\u02BB\u02B6\u02B5\u02B9\u02B8\u02BE\u02B9 = (this.\u02BA\u02BE\u02B9\u02B8\u02B3\u02BB\u02BB\u02C0\u02BF\u02C0\u02BE = true);
					this.\u02B5\u02B7\u02C0\u02B6\u02BF\u02B6\u02BC\u02BE\u02B6\u02B8\u02B2();
					return;
				}
			}
			else if (num <= 3132903066U)
			{
				if (num <= 2685117737U)
				{
					if (num != 2287133007U)
					{
						if (num != 2636738313U)
						{
							if (num != 2685117737U)
							{
								goto IL_0844;
							}
							if (!(text == "Enable Lanes"))
							{
								goto IL_0844;
							}
							this.confirmMenu.\u02C0\u02B7\u02B3\u02B8\u02B2\u02B9\u02B2\u02BC\u02BE\u02B8\u02BD("Yo dawg, I heard you like lanes so this activates lanes!", "Enable", "Cancel", null, null, null);
							return;
						}
						else
						{
							if (!(text == "Setlist Options"))
							{
								goto IL_0844;
							}
							if (!this.setlistMenu.isActiveAndEnabled)
							{
								this.\u02BE\u02B7\u02B2\u02B3\u02B5\u02B7\u02B7\u02B9\u02B3\u02BF\u02BC(this.setlistOptions);
								return;
							}
							if (CHNetManager.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B4\u02BA\u02B8\u02B6\u02BB\u02B5\u02B2\u02B8\u02B6\u02BB\u02BB)
							{
								this.\u02BE\u02B7\u02B2\u02B3\u02B5\u02B7\u02B7\u02B9\u02B3\u02BF\u02BC(this.setlistOptionsOnline);
								return;
							}
							this.\u02BE\u02B7\u02B2\u02B3\u02B5\u02B7\u02B7\u02B9\u02B3\u02BF\u02BC(this.setlistOptionsActive);
							return;
						}
					}
					else
					{
						if (!(text == "Delete Song"))
						{
							goto IL_0844;
						}
						this.confirmMenu.\u02C0\u02B7\u02B3\u02B8\u02B2\u02B9\u02B2\u02BC\u02BE\u02B8\u02BD("Are you sure you want to delete this song?", "Yes", "No", new ConfirmationMenu.\u02BF\u02B3\u02BF\u02BF\u02C0\u02B2\u02BE\u02B8\u02B6\u02BD\u02B7(this.\u02B3\u02BD\u02C0\u02BD\u02BC\u02BE\u02BD\u02B6\u02BB\u02B8\u02B2), null, null);
						return;
					}
				}
				else if (num <= 2877564881U)
				{
					if (num != 2839816873U)
					{
						if (num != 2877564881U)
						{
							goto IL_0844;
						}
						if (!(text == "Random Song (Section)"))
						{
							goto IL_0844;
						}
						this.\u02BF\u02BF\u02B5\u02BF\u02B5\u02BC\u02B4\u02B3\u02B3\u02BF\u02C0();
						return;
					}
					else if (!(text == "Show in Finder"))
					{
						goto IL_0844;
					}
				}
				else if (num != 2983606543U)
				{
					if (num != 3132903066U)
					{
						goto IL_0844;
					}
					if (!(text == "Bass"))
					{
						goto IL_0844;
					}
					this.\u02C0\u02B3\u02BE\u02C1\u02B2\u02B2\u02BB\u02BD\u02B8\u02C1\u02B2(Instrument.Bass);
					return;
				}
				else
				{
					if (!(text == "Change visible instrument scores"))
					{
						goto IL_0844;
					}
					this.\u02BE\u02B7\u02B2\u02B3\u02B5\u02B7\u02B7\u02B9\u02B3\u02BF\u02BC(this.instrumentScoresOptions);
					return;
				}
			}
			else if (num <= 3558350423U)
			{
				if (num != 3249228965U)
				{
					if (num != 3509721975U)
					{
						if (num != 3558350423U)
						{
							goto IL_0844;
						}
						if (!(text == "Song Speed"))
						{
							goto IL_0844;
						}
						this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC = SettingsController.\u02B3\u02B7\u02B4\u02BA\u02B3\u02B9\u02B7\u02BE\u02B2\u02B7\u02BE;
						goto IL_0844;
					}
					else
					{
						if (!(text == "Play Setlist"))
						{
							goto IL_0844;
						}
						if (CHNetManager.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B4\u02BA\u02B8\u02B6\u02BB\u02B5\u02B2\u02B8\u02B6\u02BB\u02BB && \u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02B4\u02BE\u02B5\u02B6\u02BB\u02B4\u02B6\u02B9\u02B5\u02B7\u02BD.Count > 0)
						{
							\u02B3\u02B7\u02B4\u02BE\u02BE\u02C1\u02BE\u02BB\u02B2\u02B9\u02BA.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BE\u02B3\u02B7\u02BA\u02BE\u02B8\u02B4\u02B7\u02BF\u02B9\u02C0(\u02C0\u02C0\u02BD\u02B6\u02BA\u02BF\u02B3\u02BE\u02BC\u02B8\u02B4.Instrument);
						}
						else
						{
							this.songSelect.\u02BD\u02B7\u02B2\u02BE\u02B7\u02BD\u02C1\u02BE\u02C1\u02B9\u02B7();
						}
						this.\u02B8\u02B6\u02B9\u02BF\u02BF\u02BD\u02B6\u02B7\u02B3\u02BA\u02B9(true, false);
						return;
					}
				}
				else
				{
					if (!(text == "Load Setlist"))
					{
						goto IL_0844;
					}
					this.allowMultiLanguage = false;
					this.\u02BE\u02B7\u02B2\u02B3\u02B5\u02B7\u02B7\u02B9\u02B3\u02BF\u02BC(\u02B5\u02B5\u02BA\u02B3\u02BC\u02BA\u02C0\u02B7\u02B6\u02BC\u02B9.\u02B3\u02B7\u02BE\u02B8\u02C1\u02BA\u02B5\u02B8\u02B2\u02B5\u02C0());
					if (this.menuStrings == null || this.menuStrings.Length == 0)
					{
						this.confirmMenu.\u02C0\u02B7\u02B3\u02B8\u02B2\u02B9\u02B2\u02BC\u02BE\u02B8\u02BD("setlistNoSavedDialog", "Continue", null, null, null, null);
						this.\u02BE\u02B7\u02B2\u02B3\u02B5\u02B7\u02B7\u02B9\u02B3\u02BF\u02BC(this.setlistOptions);
						return;
					}
					this.\u02C0\u02C1\u02BE\u02BF\u02B2\u02BC\u02C0\u02B4\u02B3\u02BD\u02C0 = 4;
					return;
				}
			}
			else if (num <= 3922183783U)
			{
				if (num != 3703297810U)
				{
					if (num != 3922183783U)
					{
						goto IL_0844;
					}
					if (!(text == "6-fret Rhythm"))
					{
						goto IL_0844;
					}
					this.\u02C0\u02B3\u02BE\u02C1\u02B2\u02B2\u02BB\u02BD\u02B8\u02C1\u02B2(Instrument.GHLRhythm);
					return;
				}
				else
				{
					if (!(text == "Ultra Greatness Mode"))
					{
						goto IL_0844;
					}
					this.confirmMenu.\u02C0\u02B7\u02B3\u02B8\u02B2\u02B9\u02B2\u02BC\u02BE\u02B8\u02BD("This mode is so secret, no one knows what it does!", "Enable", "Cancel", null, null, null);
					return;
				}
			}
			else if (num != 4003674922U)
			{
				if (num != 4114373679U)
				{
					goto IL_0844;
				}
				if (!(text == "Guitar"))
				{
					goto IL_0844;
				}
				this.\u02C0\u02B3\u02BE\u02C1\u02B2\u02B2\u02BB\u02BD\u02B8\u02C1\u02B2(Instrument.Guitar);
				return;
			}
			else
			{
				if (!(text == "Clear Setlist"))
				{
					goto IL_0844;
				}
				if (CHNetManager.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B4\u02BA\u02B8\u02B6\u02BB\u02B5\u02B2\u02B8\u02B6\u02BB\u02BB)
				{
					(\u02B3\u02B7\u02B4\u02BE\u02BE\u02C1\u02BE\u02BB\u02B2\u02B9\u02BA.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B7\u02B7\u02B3\u02B2\u02BD\u02B4\u02BC\u02C1\u02B8\u02C0\u02BA as \u02B8\u02B4\u02B4\u02BE\u02B5\u02B6\u02B7\u02B7\u02BC\u02B5\u02B7).\u02C1\u02B5\u02BB\u02B9\u02B3\u02BE\u02B4\u02B7\u02B9\u02B8\u02BE(true);
					return;
				}
				this.setlistMenu.\u02B8\u02BA\u02B8\u02B4\u02B9\u02B5\u02B5\u02C1\u02B6\u02B7\u02B5(true);
				this.\u02BE\u02B7\u02B2\u02B3\u02B5\u02B7\u02B7\u02B9\u02B3\u02BF\u02BC(this.setlistOptions);
				return;
			}
			this.\u02B9\u02B9\u02BD\u02B2\u02B7\u02B4\u02C1\u02B7\u02BB\u02B2\u02B6();
			return;
			IL_0844:
			this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 = base.\u02B2\u02BF\u02BF\u02BE\u02BD\u02B8\u02BE\u02C0\u02B3\u02B3\u02C0;
			this.\u02B4\u02B8\u02C0\u02BC\u02C1\u02C1\u02B7\u02B2\u02B2\u02B4\u02B9();
			return;
		}
		if (\u02B5\u02B5\u02BA\u02B3\u02BC\u02BA\u02C0\u02B7\u02B6\u02BC\u02B9.\u02BA\u02B9\u02B8\u02B9\u02BD\u02B8\u02B4\u02B9\u02B8\u02BE\u02B7(base.\u02B2\u02BF\u02BF\u02BE\u02BD\u02B8\u02BE\u02C0\u02B3\u02B3\u02C0))
		{
			this.setlistMenu.\u02BF\u02BC\u02C1\u02BC\u02B4\u02C0\u02B5\u02BE\u02BD\u02B9\u02B6();
			this.\u02BE\u02B7\u02B2\u02B3\u02B5\u02B7\u02B7\u02B9\u02B3\u02BF\u02BC(this.setlistOptionsActive);
			return;
		}
		this.confirmMenu.\u02C0\u02B7\u02B3\u02B8\u02B2\u02B9\u02B2\u02BC\u02BE\u02B8\u02BD("setlistErrorDialog", "Continue", null, null, null, null);
		this.\u02BE\u02B7\u02B2\u02B3\u02B5\u02B7\u02B7\u02B9\u02B3\u02BF\u02BC(this.setlistOptions);
	}

	private void \u02C0\u02BC\u02C0\u02BF\u02C1\u02B9\u02BD\u02B9\u02B2\u02BC\u02BA()
	{
		if (this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 == "Audio")
		{
			this.textObjects[this.\u02B3\u02BF\u02BB\u02BB\u02B5\u02B7\u02B8\u02BE\u02B7\u02B3\u02B3].text = this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC.GetPercentString;
			this.songSelect.\u02B3\u02C1\u02C0\u02B2\u02B9\u02BB\u02B6\u02B6\u02B4\u02C0\u02BB();
		}
		base.\u02B7\u02B6\u02BC\u02BC\u02B3\u02BA\u02BE\u02C0\u02BF\u02B9\u02C1();
	}

	private void \u02B3\u02BD\u02C0\u02BD\u02BC\u02BE\u02BD\u02B6\u02BB\u02B8\u02B2()
	{
		this.confirmMenu.\u02C0\u02B7\u02B3\u02B8\u02B2\u02B9\u02B2\u02BC\u02BE\u02B8\u02BD("This is permanent! Are you still sure?", "Get rid of it", "Cancel", new ConfirmationMenu.\u02BF\u02B3\u02BF\u02BF\u02C0\u02B2\u02BE\u02B8\u02B6\u02BD\u02B7(this.\u02C0\u02BC\u02C1\u02B3\u02B9\u02B2\u02B9\u02BB\u02B3\u02B7\u02B9), null, null);
	}

	private void \u02BE\u02B7\u02B2\u02B3\u02B5\u02B7\u02B7\u02B9\u02B3\u02BF\u02BC(string[] \u02BC\u02C0\u02B2\u02B5\u02BE\u02B7\u02C1\u02B4\u02B7\u02BD\u02C0)
	{
		if (\u02BC\u02C0\u02B2\u02B5\u02BE\u02B7\u02C1\u02B4\u02B7\u02BD\u02C0 == this.menuStrings)
		{
			this.\u02B5\u02B6\u02B8\u02BC\u02BF\u02BF\u02BC\u02B5\u02C0\u02BB\u02C0(this.\u02B6\u02B5\u02B7\u02BD\u02B4\u02BA\u02B6\u02B9\u02B2\u02B3\u02B4, true);
			this.\u02B6\u02B5\u02B7\u02BD\u02B4\u02BA\u02B6\u02B9\u02B2\u02B3\u02B4 = -1;
			return;
		}
		this.menuStrings = \u02BC\u02C0\u02B2\u02B5\u02BE\u02B7\u02C1\u02B4\u02B7\u02BD\u02C0;
		if (\u02BC\u02C0\u02B2\u02B5\u02BE\u02B7\u02C1\u02B4\u02B7\u02BD\u02C0 == this.mainOptions || \u02BC\u02C0\u02B2\u02B5\u02BE\u02B7\u02C1\u02B4\u02B7\u02BD\u02C0 == this.mainOptionsPractice)
		{
			this.\u02C0\u02C1\u02BE\u02BF\u02B2\u02BC\u02C0\u02B4\u02B3\u02BD\u02C0 = 0;
		}
		if (\u02BC\u02C0\u02B2\u02B5\u02BE\u02B7\u02C1\u02B4\u02B7\u02BD\u02C0 == this.setlistOptions || \u02BC\u02C0\u02B2\u02B5\u02BE\u02B7\u02C1\u02B4\u02B7\u02BD\u02C0 == this.setlistOptionsActive)
		{
			this.\u02C0\u02C1\u02BE\u02BF\u02B2\u02BC\u02C0\u02B4\u02B3\u02BD\u02C0 = 2;
		}
		this.\u02BA\u02BD\u02B3\u02BC\u02B8\u02BB\u02B8\u02BA\u02B5\u02C0\u02C0();
		this.\u02B5\u02B6\u02B8\u02BC\u02BF\u02BF\u02BC\u02B5\u02C0\u02BB\u02C0(0, true);
		base.\u02B7\u02B6\u02BC\u02BC\u02B3\u02BA\u02BE\u02C0\u02BF\u02B9\u02C1();
	}

	public override void \u02BA\u02BC\u02C1\u02BE\u02B6\u02B4\u02B9\u02B2\u02B3\u02BD\u02B4()
	{
		if (this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC != null)
		{
			this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC.Reset();
			this.\u02B4\u02B8\u02C0\u02BC\u02C1\u02C1\u02B7\u02B2\u02B2\u02B4\u02B9();
			return;
		}
		if (this.\u02BD\u02BD\u02B8\u02BE\u02B4\u02BC\u02BD\u02C1\u02BB\u02C0\u02BE == this.\u02B8\u02BD\u02BE\u02C1\u02BE\u02C0\u02B7\u02B5\u02C0\u02B7\u02BC.Length)
		{
			this.\u02BD\u02BD\u02B8\u02BE\u02B4\u02BC\u02BD\u02C1\u02BB\u02C0\u02BE = 0;
		}
		if (this.\u02B8\u02BD\u02BE\u02C1\u02BE\u02C0\u02B7\u02B5\u02C0\u02B7\u02BC[this.\u02BD\u02BD\u02B8\u02BE\u02B4\u02BC\u02BD\u02C1\u02BB\u02C0\u02BE] == 23)
		{
			this.\u02BD\u02BD\u02B8\u02BE\u02B4\u02BC\u02BD\u02C1\u02BB\u02C0\u02BE++;
		}
		else
		{
			this.\u02BD\u02BD\u02B8\u02BE\u02B4\u02BC\u02BD\u02C1\u02BB\u02C0\u02BE = 0;
		}
		if (this.\u02BD\u02BD\u02B8\u02BE\u02B4\u02BC\u02BD\u02C1\u02BB\u02C0\u02BE == 5)
		{
			this.\u02BE\u02B7\u02B2\u02B3\u02B5\u02B7\u02B7\u02B9\u02B3\u02BF\u02BC(this.extraOptions);
		}
		if (this.\u02BD\u02BD\u02B8\u02BE\u02B4\u02BC\u02BD\u02C1\u02BB\u02C0\u02BE == 10)
		{
			this.\u02BE\u02B7\u02B2\u02B3\u02B5\u02B7\u02B7\u02B9\u02B3\u02BF\u02BC(this.extraOptions2);
		}
		if (this.\u02BD\u02BD\u02B8\u02BE\u02B4\u02BC\u02BD\u02C1\u02BB\u02C0\u02BE == this.\u02B8\u02BD\u02BE\u02C1\u02BE\u02C0\u02B7\u02B5\u02C0\u02B7\u02BC.Length)
		{
			this.\u02BE\u02B7\u02B2\u02B3\u02B5\u02B7\u02B7\u02B9\u02B3\u02BF\u02BC(this.extraOptions3);
		}
	}

	public override void \u02BD\u02B9\u02BE\u02BB\u02B9\u02BA\u02B5\u02BC\u02BE\u02C1\u02B2()
	{
		if (this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 == "Song Speed")
		{
			this.\u02B4\u02B8\u02C0\u02BC\u02C1\u02C1\u02B7\u02B2\u02B2\u02B4\u02B9();
		}
	}

	protected virtual void \u02BB\u02B7\u02C0\u02B3\u02C1\u02BD\u02B9\u02B2\u02B4\u02BE\u02B6()
	{
		if (this.confirmMenu.\u02BF\u02C1\u02B2\u02C1\u02B4\u02B8\u02BF\u02C1\u02C1\u02B9\u02B8)
		{
			return;
		}
		if (this.\u02B3\u02BB\u02BF\u02C0\u02BB\u02B6\u02B5\u02B9\u02B8\u02BE\u02B9)
		{
			this.\u02B7\u02C0\u02BF\u02BD\u02B3\u02B4\u02B8\u02BB\u02B9\u02B8\u02BE();
			return;
		}
		base.Update();
	}

	public override void \u02C0\u02BD\u02BD\u02B4\u02B5\u02B4\u02B6\u02B8\u02BD\u02B8\u02BB()
	{
		if (this.\u02BD\u02BD\u02B8\u02BE\u02B4\u02BC\u02BD\u02C1\u02BB\u02C0\u02BE == this.\u02B8\u02BD\u02BE\u02C1\u02BE\u02C0\u02B7\u02B5\u02C0\u02B7\u02BC.Length)
		{
			this.\u02BD\u02BD\u02B8\u02BE\u02B4\u02BC\u02BD\u02C1\u02BB\u02C0\u02BE = 0;
		}
		if (this.\u02B8\u02BD\u02BE\u02C1\u02BE\u02C0\u02B7\u02B5\u02C0\u02B7\u02BC[this.\u02BD\u02BD\u02B8\u02BE\u02B4\u02BC\u02BD\u02C1\u02BB\u02C0\u02BE] == 33)
		{
			this.\u02BD\u02BD\u02B8\u02BE\u02B4\u02BC\u02BD\u02C1\u02BB\u02C0\u02BE++;
			return;
		}
		this.\u02BD\u02BD\u02B8\u02BE\u02B4\u02BC\u02BD\u02C1\u02BB\u02C0\u02BE = 0;
	}

	public virtual void \u02B8\u02BF\u02C1\u02B7\u02B7\u02B7\u02B4\u02B2\u02B2\u02BE\u02BF()
	{
		if (this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC != null)
		{
			this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC.Reset();
			this.\u02B4\u02B8\u02C0\u02BC\u02C1\u02C1\u02B7\u02B2\u02B2\u02B4\u02B9();
			return;
		}
		if (this.\u02BD\u02BD\u02B8\u02BE\u02B4\u02BC\u02BD\u02C1\u02BB\u02C0\u02BE == this.\u02B8\u02BD\u02BE\u02C1\u02BE\u02C0\u02B7\u02B5\u02C0\u02B7\u02BC.Length)
		{
			this.\u02BD\u02BD\u02B8\u02BE\u02B4\u02BC\u02BD\u02C1\u02BB\u02C0\u02BE = 1;
		}
		if (this.\u02B8\u02BD\u02BE\u02C1\u02BE\u02C0\u02B7\u02B5\u02C0\u02B7\u02BC[this.\u02BD\u02BD\u02B8\u02BE\u02B4\u02BC\u02BD\u02C1\u02BB\u02C0\u02BE] == 33)
		{
			this.\u02BD\u02BD\u02B8\u02BE\u02B4\u02BC\u02BD\u02C1\u02BB\u02C0\u02BE++;
		}
		else
		{
			this.\u02BD\u02BD\u02B8\u02BE\u02B4\u02BC\u02BD\u02C1\u02BB\u02C0\u02BE = 0;
		}
		if (this.\u02BD\u02BD\u02B8\u02BE\u02B4\u02BC\u02BD\u02C1\u02BB\u02C0\u02BE == 1)
		{
			this.\u02BE\u02B7\u02B2\u02B3\u02B5\u02B7\u02B7\u02B9\u02B3\u02BF\u02BC(this.extraOptions);
		}
		if (this.\u02BD\u02BD\u02B8\u02BE\u02B4\u02BC\u02BD\u02C1\u02BB\u02C0\u02BE == 3)
		{
			this.\u02BE\u02B7\u02B2\u02B3\u02B5\u02B7\u02B7\u02B9\u02B3\u02BF\u02BC(this.extraOptions2);
		}
		if (this.\u02BD\u02BD\u02B8\u02BE\u02B4\u02BC\u02BD\u02C1\u02BB\u02C0\u02BE == this.\u02B8\u02BD\u02BE\u02C1\u02BE\u02C0\u02B7\u02B5\u02C0\u02B7\u02BC.Length)
		{
			this.\u02BE\u02B7\u02B2\u02B3\u02B5\u02B7\u02B7\u02B9\u02B3\u02BF\u02BC(this.extraOptions3);
		}
	}

	private void \u02B7\u02BA\u02BD\u02BA\u02B7\u02BE\u02C1\u02B9\u02B5\u02BF\u02B2()
	{
		this.confirmMenu.\u02C0\u02B7\u02B3\u02B8\u02B2\u02B9\u02B2\u02BC\u02BE\u02B8\u02BD("Intensity - Pro Drums", "Please wait while the song is loaded.", "'>", new ConfirmationMenu.\u02BF\u02B3\u02BF\u02BF\u02C0\u02B2\u02BE\u02B8\u02B6\u02BD\u02B7(this.\u02C0\u02BC\u02C1\u02B3\u02B9\u02B2\u02B9\u02BB\u02B3\u02B7\u02B9), null, null);
	}

	public override void \u02C1\u02B3\u02BC\u02B6\u02BD\u02B6\u02BF\u02B7\u02BB\u02B5\u02BB()
	{
		this.\u02BD\u02BD\u02B8\u02BE\u02B4\u02BC\u02BD\u02C1\u02BB\u02C0\u02BE = 0;
		if (this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 == null)
		{
			base.\u02C1\u02B3\u02BC\u02B6\u02BD\u02B6\u02BF\u02B7\u02BB\u02B5\u02BB();
			return;
		}
		this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC.Increment();
		this.\u02B4\u02B8\u02C0\u02BC\u02C1\u02C1\u02B7\u02B2\u02B2\u02B4\u02B9();
	}

	public virtual void \u02BE\u02C0\u02C0\u02BB\u02B2\u02BD\u02BA\u02BE\u02BC\u02B9\u02BE()
	{
		if (this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 == "Song")
		{
			this.\u02C0\u02BC\u02C0\u02BF\u02C1\u02B9\u02BD\u02B9\u02B2\u02BC\u02BA();
		}
	}

	private void \u02B7\u02B2\u02BA\u02B7\u02BE\u02B8\u02BE\u02BB\u02B5\u02C1\u02BB()
	{
		int num = \u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02BB\u02B2\u02BA\u02BE\u02BD\u02BC\u02B7\u02B8\u02BD\u02C0\u02BF();
		if (num == -1)
		{
			return;
		}
		this.songSelect.\u02BA\u02BD\u02B3\u02BC\u02B8\u02BB\u02B8\u02BA\u02B5\u02C0\u02C0();
		this.songSelect.\u02B5\u02B6\u02B8\u02BC\u02BF\u02BF\u02BC\u02B5\u02C0\u02BB\u02C0(num, true);
		this.\u02B3\u02BC\u02BA\u02C0\u02C0\u02B8\u02B2\u02B4\u02B3\u02C1\u02B8();
		base.\u02B7\u02B6\u02BC\u02BC\u02B3\u02BA\u02BE\u02C0\u02BF\u02B9\u02C1();
	}

	private void \u02BF\u02BF\u02B5\u02BF\u02B5\u02BC\u02B4\u02B3\u02B3\u02BF\u02C0()
	{
		int num = \u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02BF\u02B8\u02B3\u02B8\u02B9\u02C0\u02C0\u02B7\u02B7\u02BC\u02C0(this.songSelect.\u02BF\u02B6\u02B5\u02BF\u02BD\u02BF\u02B4\u02B3\u02B8\u02BE\u02BC);
		this.songSelect.\u02BA\u02BD\u02B3\u02BC\u02B8\u02BB\u02B8\u02BA\u02B5\u02C0\u02C0();
		this.songSelect.\u02B5\u02B6\u02B8\u02BC\u02BF\u02BF\u02BC\u02B5\u02C0\u02BB\u02C0(num, true);
		this.\u02B3\u02BC\u02BA\u02C0\u02C0\u02B8\u02B2\u02B4\u02B3\u02C1\u02B8();
		base.\u02B7\u02B6\u02BC\u02BC\u02B3\u02BA\u02BE\u02C0\u02BF\u02B9\u02C1();
	}

	private void \u02C0\u02B3\u02BE\u02C1\u02B2\u02B2\u02BB\u02BD\u02B8\u02C1\u02B2(Instrument \u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF)
	{
		GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BA\u02C0\u02B4\u02B6\u02BE\u02B4\u02BA\u02BF\u02B5\u02BD\u02B2 = true;
		this.songSelect.\u02C0\u02BE\u02B5\u02B2\u02B7\u02B7\u02C0\u02BD\u02BA\u02B3\u02BB = new Instrument?(\u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF);
	}

	public override void \u02B7\u02BA\u02C0\u02B8\u02BE\u02BA\u02BD\u02B4\u02BB\u02B3\u02B6()
	{
		this.\u02BD\u02BD\u02B8\u02BE\u02B4\u02BC\u02BD\u02C1\u02BB\u02C0\u02BE = 0;
		if (this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 == null)
		{
			base.\u02B7\u02BA\u02C0\u02B8\u02BE\u02BA\u02BD\u02B4\u02BB\u02B3\u02B6();
			return;
		}
		this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC.Decrement();
		this.\u02B4\u02B8\u02C0\u02BC\u02C1\u02C1\u02B7\u02B2\u02B2\u02B4\u02B9();
	}

	private void \u02BC\u02BE\u02B8\u02BA\u02C0\u02B5\u02C0\u02BE\u02BF\u02BC\u02BA()
	{
		\u02B5\u02B5\u02BA\u02B3\u02BC\u02BA\u02C0\u02B7\u02B6\u02BC\u02B9.\u02BC\u02BE\u02B8\u02BA\u02C0\u02B5\u02C0\u02BE\u02BF\u02BC\u02BA(base.\u02B2\u02BF\u02BF\u02BE\u02BD\u02B8\u02BE\u02C0\u02B3\u02B3\u02C0);
		this.\u02BE\u02B7\u02B2\u02B3\u02B5\u02B7\u02B7\u02B9\u02B3\u02BF\u02BC(this.setlistOptions);
		\u02B5\u02B5\u02BA\u02B3\u02BC\u02BA\u02C0\u02B7\u02B6\u02BC\u02B9.\u02BC\u02BD\u02BE\u02BB\u02B2\u02B8\u02C0\u02B6\u02BA\u02B9\u02B7 = null;
		base.\u02B7\u02B6\u02BC\u02BC\u02B3\u02BA\u02BE\u02C0\u02BF\u02B9\u02C1();
	}

	private void \u02B5\u02B7\u02C0\u02B6\u02BF\u02B6\u02BC\u02BE\u02B6\u02B8\u02B2()
	{
		this.menuStrings = new string[0];
		this.\u02BA\u02BD\u02B3\u02BC\u02B8\u02BB\u02B8\u02BA\u02B5\u02C0\u02C0();
		this.\u02BF\u02B7\u02BF\u02BF\u02B4\u02B2\u02BF\u02B7\u02BA\u02BA\u02B2();
		base.\u02BA\u02B9\u02C1\u02C1\u02BF\u02C1\u02BC\u02BA\u02B3\u02BB\u02C0();
		this.\u02B9\u02B8\u02C0\u02B7\u02BA\u02B3\u02BB\u02C0\u02B3\u02C1\u02B8();
		this.textObjects[0].text = \u02B5\u02B5\u02BA\u02B3\u02BC\u02BA\u02C0\u02B7\u02B6\u02BC\u02B9.\u02BC\u02BD\u02BE\u02BB\u02B2\u02B8\u02C0\u02B6\u02BA\u02B9\u02B7;
		if (this.textObjects[0].text == null)
		{
			this.textObjects[0].text = "";
		}
		this.textObjects[1].text = \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6("Type the setlist name");
		this.textObjects[2].text = \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6("Press Enter to confirm");
		this.textObjects[3].text = \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6("Press Escape to cancel");
		this.setlistMenu.\u02B2\u02B8\u02BC\u02BB\u02B4\u02BE\u02BD\u02C1\u02B2\u02B6\u02B9();
		\u02C1\u02BB\u02BD\u02B7\u02BD\u02BB\u02BE\u02B5\u02B7\u02C0\u02B6.\u02B2\u02B9\u02B6\u02B2\u02C0\u02BA\u02BF\u02B8\u02B5\u02B3\u02B6(false);
	}

	[SerializeField]
	private SongSelect songSelect;

	[SerializeField]
	private ConfirmationMenu confirmMenu;

	[SerializeField]
	private SetlistMenu setlistMenu;

	[SerializeField]
	private string[] mainOptions;

	[SerializeField]
	private string[] mainOptionsPractice;

	[SerializeField]
	private string[] setlistOptions;

	[SerializeField]
	private string[] setlistOptionsActive;

	[SerializeField]
	private string[] setlistOptionsOnline;

	[SerializeField]
	private string[] instrumentScoresOptions;

	[SerializeField]
	private string[] extraOptions;

	[SerializeField]
	private string[] extraOptions2;

	[SerializeField]
	private string[] extraOptions3;

	private int \u02C0\u02C1\u02BE\u02BF\u02B2\u02BC\u02C0\u02B4\u02B3\u02BD\u02C0;

	private int \u02BD\u02BD\u02B8\u02BE\u02B4\u02BC\u02BD\u02C1\u02BB\u02C0\u02BE;

	private int \u02B6\u02B5\u02B7\u02BD\u02B4\u02BA\u02B6\u02B9\u02B2\u02B3\u02B4;

	private bool \u02B3\u02BB\u02BF\u02C0\u02BB\u02B6\u02B5\u02B9\u02B8\u02BE\u02B9;

	private bool \u02BA\u02BE\u02B9\u02B8\u02B3\u02BB\u02BB\u02C0\u02BF\u02C0\u02BE;

	private bool \u02B4\u02BA\u02BC\u02BF\u02B3\u02BD\u02BE\u02C1\u02BC\u02C1\u02B6;

	protected GameSetting \u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC;

	private int[] \u02B8\u02BD\u02BE\u02C1\u02BE\u02C0\u02B7\u02B5\u02C0\u02B7\u02BC = new int[]
	{
		3, 4, 3, 3, 3, 3, 3, 3, 3, 3,
		3, 3, 3, 3, 3, 3, 3, 3, 3, 3,
		3, 3, 3
	};
}
