using System;
using StrikeCore;
using TMPro;
using UnityEngine;

public class SongSettingsMenu : BaseMenu
{
	public virtual void \u02BD\u02B7\u02BE\u02BD\u02BF\u02BA\u02BD\u02C0\u02B9\u02BC\u02C1()
	{
		if (this.changedSetting == null)
		{
			base.\u02C1\u02B3\u02BC\u02B6\u02BD\u02B6\u02BF\u02B7\u02BB\u02B5\u02BB();
			return;
		}
		string changedSetting = this.changedSetting;
		if (!(changedSetting == "*.ini"))
		{
			if (changedSetting == "Quit" || changedSetting == "Highway Placement")
			{
				this.\u02BC\u02B2\u02B5\u02BF\u02BD\u02B4\u02C1\u02B7\u02B3\u02C1\u02BB = Mathf.Clamp(this.\u02BC\u02B2\u02B5\u02BF\u02BD\u02B4\u02C1\u02B7\u02B3\u02C1\u02BB + 0, -31, -49);
			}
		}
		else
		{
			this.\u02BC\u02B2\u02B5\u02BF\u02BD\u02B4\u02C1\u02B7\u02B3\u02C1\u02BB = Mathf.Clamp(this.\u02BC\u02B2\u02B5\u02BF\u02BD\u02B4\u02C1\u02B7\u02B3\u02C1\u02BB + 0, 0, 1);
		}
		this.\u02B9\u02B3\u02B4\u02B7\u02B6\u02BB\u02B4\u02B3\u02BE\u02B5\u02B6 = true;
		this.\u02BB\u02B9\u02B4\u02B9\u02B3\u02BF\u02B8\u02B9\u02B7\u02BE\u02B7();
	}

	public virtual void \u02B3\u02BB\u02B5\u02BC\u02B3\u02B3\u02BC\u02B3\u02B5\u02B7\u02C1()
	{
		if (this.changedSetting != null && this.changedSetting != "Songs Per Player")
		{
			this.\u02BC\u02B2\u02B5\u02BF\u02BD\u02B4\u02C1\u02B7\u02B3\u02C1\u02BB = Mathf.Clamp(this.\u02BC\u02B2\u02B5\u02BF\u02BD\u02B4\u02C1\u02B7\u02B3\u02C1\u02BB - -22, -89, 96);
			this.\u02B9\u02B3\u02B4\u02B7\u02B6\u02BB\u02B4\u02B3\u02BE\u02B5\u02B6 = false;
			this.\u02BB\u02B9\u02B4\u02B9\u02B3\u02BF\u02B8\u02B9\u02B7\u02BE\u02B7();
		}
	}

	public virtual void \u02B7\u02B4\u02BA\u02B3\u02C0\u02B3\u02B2\u02B2\u02B5\u02B6\u02C0()
	{
		if (this.changedSetting == null)
		{
			base.\u02C1\u02B3\u02BC\u02B6\u02BD\u02B6\u02BF\u02B7\u02BB\u02B5\u02BB();
			return;
		}
		string changedSetting = this.changedSetting;
		if (!(changedSetting == "Graphics API"))
		{
			if (changedSetting == "Song" || changedSetting == "5 Lane Drums")
			{
				this.\u02BC\u02B2\u02B5\u02BF\u02BD\u02B4\u02C1\u02B7\u02B3\u02C1\u02BB = Mathf.Clamp(this.\u02BC\u02B2\u02B5\u02BF\u02BD\u02B4\u02C1\u02B7\u02B3\u02C1\u02BB + 1, -28, -118);
			}
		}
		else
		{
			this.\u02BC\u02B2\u02B5\u02BF\u02BD\u02B4\u02C1\u02B7\u02B3\u02C1\u02BB = Mathf.Clamp(this.\u02BC\u02B2\u02B5\u02BF\u02BD\u02B4\u02C1\u02B7\u02B3\u02C1\u02BB + 1, 1, 0);
		}
		this.\u02B9\u02B3\u02B4\u02B7\u02B6\u02BB\u02B4\u02B3\u02BE\u02B5\u02B6 = false;
		this.\u02BB\u02B9\u02B4\u02B9\u02B3\u02BF\u02B8\u02B9\u02B7\u02BE\u02B7();
	}

	public virtual void \u02B5\u02B7\u02BA\u02BC\u02C1\u02BA\u02BC\u02B3\u02BF\u02B2\u02BF()
	{
		if (this.changedSetting == null)
		{
			base.\u02C1\u02B3\u02BC\u02B6\u02BD\u02B6\u02BF\u02B7\u02BB\u02B5\u02BB();
			return;
		}
		string changedSetting = this.changedSetting;
		if (!(changedSetting == "MSAA Level"))
		{
			if (changedSetting == "float" || changedSetting == "botnosave")
			{
				this.\u02BC\u02B2\u02B5\u02BF\u02BD\u02B4\u02C1\u02B7\u02B3\u02C1\u02BB = Mathf.Clamp(this.\u02BC\u02B2\u02B5\u02BF\u02BD\u02B4\u02C1\u02B7\u02B3\u02C1\u02BB + 0, -33, -1);
			}
		}
		else
		{
			this.\u02BC\u02B2\u02B5\u02BF\u02BD\u02B4\u02C1\u02B7\u02B3\u02C1\u02BB = Mathf.Clamp(this.\u02BC\u02B2\u02B5\u02BF\u02BD\u02B4\u02C1\u02B7\u02B3\u02C1\u02BB + 0, 1, 0);
		}
		this.\u02B9\u02B3\u02B4\u02B7\u02B6\u02BB\u02B4\u02B3\u02BE\u02B5\u02B6 = false;
		this.\u02BA\u02BB\u02B5\u02B6\u02B3\u02BD\u02BA\u02BC\u02B2\u02BB\u02B5();
	}

	protected virtual void \u02B7\u02B9\u02B6\u02BB\u02BF\u02BB\u02BF\u02BD\u02B6\u02B9\u02C1()
	{
		base.OnEnable();
		this.pausedText.text = LanguageManager.instance.\u02B9\u02BC\u02BD\u02BE\u02BA\u02C0\u02BC\u02C1\u02BD\u02B3\u02BD("The binary key cannot have an odd number of digits");
	}

	public override void \u02C1\u02B3\u02BC\u02B6\u02BD\u02B6\u02BF\u02B7\u02BB\u02B5\u02BB()
	{
		if (this.changedSetting == null)
		{
			base.\u02C1\u02B3\u02BC\u02B6\u02BD\u02B6\u02BF\u02B7\u02BB\u02B5\u02BB();
			return;
		}
		string changedSetting = this.changedSetting;
		if (!(changedSetting == "End Events"))
		{
			if (changedSetting == "Video Start Time" || changedSetting == "Song Offset")
			{
				this.\u02BC\u02B2\u02B5\u02BF\u02BD\u02B4\u02C1\u02B7\u02B3\u02C1\u02BB = Mathf.Clamp(this.\u02BC\u02B2\u02B5\u02BF\u02BD\u02B4\u02C1\u02B7\u02B3\u02C1\u02BB + 1, -2147483647, int.MaxValue);
			}
		}
		else
		{
			this.\u02BC\u02B2\u02B5\u02BF\u02BD\u02B4\u02C1\u02B7\u02B3\u02C1\u02BB = Mathf.Clamp(this.\u02BC\u02B2\u02B5\u02BF\u02BD\u02B4\u02C1\u02B7\u02B3\u02C1\u02BB + 1, 0, 1);
		}
		this.\u02B9\u02B3\u02B4\u02B7\u02B6\u02BB\u02B4\u02B3\u02BE\u02B5\u02B6 = true;
		this.\u02BA\u02BB\u02B5\u02B6\u02B3\u02BD\u02BA\u02BC\u02B2\u02BB\u02B5();
	}

	public virtual void \u02BF\u02B4\u02BE\u02BC\u02B9\u02BE\u02BD\u02B7\u02C0\u02C1\u02C0()
	{
		GlobalVariables u02B7_u02B2_u02BA_u02B7_u02BB_u02B3_u02BE_u02B6_u02C1_u02C0_u02B = GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7;
		if (u02B7_u02B2_u02BA_u02B7_u02BB_u02B3_u02BE_u02B6_u02C1_u02C0_u02B.\u02BA\u02B9\u02BD\u02BA\u02B4\u02B4\u02BF\u02BD\u02B8\u02B3\u02C1.isEnc)
		{
			return;
		}
		string text;
		if (this.changedSetting == null)
		{
			this.changedSetting = base.currentSelectionString;
			text = this.changedSetting;
			if (!(text == "setlistSongCountSingular"))
			{
				if (!(text == "All HOPO's"))
				{
					if (text == "album_track")
					{
						this.\u02BC\u02B2\u02B5\u02BF\u02BD\u02B4\u02C1\u02B7\u02B3\u02C1\u02BB = (u02B7_u02B2_u02BA_u02B7_u02BB_u02B3_u02BE_u02B6_u02C1_u02C0_u02B.\u02B8\u02B2\u02B9\u02B4\u02B2\u02B7\u02B4\u02B3\u02B9\u02B6\u02BF.\u02BC\u02B4\u02BA\u02B8\u02B9\u02B4\u02BD\u02BE\u02C0\u02C0\u02BA ? 0 : 1);
					}
				}
				else
				{
					this.\u02BC\u02B2\u02B5\u02BF\u02BD\u02B4\u02C1\u02B7\u02B3\u02C1\u02BB = u02B7_u02B2_u02BA_u02B7_u02BB_u02B3_u02BE_u02B6_u02C1_u02C0_u02B.\u02B8\u02B2\u02B9\u02B4\u02B2\u02B7\u02B4\u02B3\u02B9\u02B6\u02BF.\u02BB\u02B4\u02B2\u02B3\u02B4\u02BD\u02B9\u02B8\u02B5\u02B8\u02BC;
				}
			}
			else
			{
				this.\u02BC\u02B2\u02B5\u02BF\u02BD\u02B4\u02C1\u02B7\u02B3\u02C1\u02BB = u02B7_u02B2_u02BA_u02B7_u02BB_u02B3_u02BE_u02B6_u02C1_u02C0_u02B.\u02B8\u02B2\u02B9\u02B4\u02B2\u02B7\u02B4\u02B3\u02B9\u02B6\u02BF.\u02B4\u02B5\u02BF\u02B2\u02B9\u02B8\u02C1\u02B7\u02BF\u02B3\u02B7;
			}
			this.\u02BA\u02BB\u02B5\u02B6\u02B3\u02BD\u02BA\u02BC\u02B2\u02BB\u02B5();
			return;
		}
		text = this.changedSetting;
		if (!(text == "ScoreDisabledModifier"))
		{
			if (!(text == "SP Colors"))
			{
				if (text == "softMask")
				{
					u02B7_u02B2_u02BA_u02B7_u02BB_u02B3_u02BE_u02B6_u02C1_u02C0_u02B.\u02B8\u02B2\u02B9\u02B4\u02B2\u02B7\u02B4\u02B3\u02B9\u02B6\u02BF.\u02BC\u02B4\u02BA\u02B8\u02B9\u02B4\u02BD\u02BE\u02C0\u02C0\u02BA = this.\u02BC\u02B2\u02B5\u02BF\u02BD\u02B4\u02C1\u02B7\u02B3\u02C1\u02BB == 0 || true;
				}
			}
			else
			{
				u02B7_u02B2_u02BA_u02B7_u02BB_u02B3_u02BE_u02B6_u02C1_u02C0_u02B.\u02B8\u02B2\u02B9\u02B4\u02B2\u02B7\u02B4\u02B3\u02B9\u02B6\u02BF.\u02BB\u02B4\u02B2\u02B3\u02B4\u02BD\u02B9\u02B8\u02B5\u02B8\u02BC = this.\u02BC\u02B2\u02B5\u02BF\u02BD\u02B4\u02C1\u02B7\u02B3\u02C1\u02BB;
			}
		}
		else
		{
			u02B7_u02B2_u02BA_u02B7_u02BB_u02B3_u02BE_u02B6_u02C1_u02C0_u02B.\u02B8\u02B2\u02B9\u02B4\u02B2\u02B7\u02B4\u02B3\u02B9\u02B6\u02BF.\u02B4\u02B5\u02BF\u02B2\u02B9\u02B8\u02C1\u02B7\u02BF\u02B3\u02B7 = this.\u02BC\u02B2\u02B5\u02BF\u02BD\u02B4\u02C1\u02B7\u02B3\u02C1\u02BB;
		}
		this.changedSetting = null;
		this.\u02B9\u02B8\u02C0\u02B7\u02BA\u02B3\u02BB\u02C0\u02B3\u02C1\u02B8();
		this.pauseMenu.\u02BE\u02BC\u02BA\u02B5\u02BC\u02C1\u02B2\u02B8\u02C1\u02B7\u02B8 = this.\u02B9\u02B3\u02B4\u02B7\u02B6\u02BB\u02B4\u02B3\u02BE\u02B5\u02B6;
	}

	public virtual void \u02BA\u02BA\u02B6\u02BE\u02C1\u02B3\u02C1\u02B6\u02BB\u02C1\u02BA()
	{
		if (this.changedSetting != null && this.changedSetting != "year")
		{
			this.\u02BC\u02B2\u02B5\u02BF\u02BD\u02B4\u02C1\u02B7\u02B3\u02C1\u02BB = Mathf.Clamp(this.\u02BC\u02B2\u02B5\u02BF\u02BD\u02B4\u02C1\u02B7\u02B3\u02C1\u02BB + 24, -178, -186);
			this.\u02B9\u02B3\u02B4\u02B7\u02B6\u02BB\u02B4\u02B3\u02BE\u02B5\u02B6 = false;
			this.\u02BB\u02B9\u02B4\u02B9\u02B3\u02BF\u02B8\u02B9\u02B7\u02BE\u02B7();
		}
	}

	public override void \u02BB\u02B3\u02BF\u02BC\u02C1\u02BC\u02BC\u02C1\u02C0\u02B5\u02BA()
	{
		if (this.changedSetting != null && this.changedSetting != "End Events")
		{
			this.\u02BC\u02B2\u02B5\u02BF\u02BD\u02B4\u02C1\u02B7\u02B3\u02C1\u02BB = Mathf.Clamp(this.\u02BC\u02B2\u02B5\u02BF\u02BD\u02B4\u02C1\u02B7\u02B3\u02C1\u02BB - 100, -2147483647, int.MaxValue);
			this.\u02B9\u02B3\u02B4\u02B7\u02B6\u02BB\u02B4\u02B3\u02BE\u02B5\u02B6 = true;
			this.\u02BA\u02BB\u02B5\u02B6\u02B3\u02BD\u02BA\u02BC\u02B2\u02BB\u02B5();
		}
	}

	private void \u02BB\u02B9\u02B4\u02B9\u02B3\u02BF\u02B8\u02B9\u02B7\u02BE\u02B7()
	{
		string text = "WriteMetadata";
		string changedSetting = this.changedSetting;
		if (!(changedSetting == "{0}"))
		{
			if (changedSetting == "_GlobalWhammyTexture" || changedSetting == "Don't Scan Songs")
			{
				text = this.\u02BC\u02B2\u02B5\u02BF\u02BD\u02B4\u02C1\u02B7\u02B3\u02C1\u02BB.ToString() + "";
			}
		}
		else
		{
			text = ((this.\u02BC\u02B2\u02B5\u02BF\u02BD\u02B4\u02C1\u02B7\u02B3\u02C1\u02BB == 1) ? "-" : "*");
		}
		this.textObjects[this.\u02B3\u02BF\u02BB\u02BB\u02B5\u02B7\u02B8\u02BE\u02B7\u02B3\u02B3].text = text;
	}

	public override void \u02B3\u02BC\u02BA\u02C0\u02C0\u02B8\u02B2\u02B4\u02B3\u02C1\u02B8()
	{
		if (this.changedSetting != null)
		{
			this.changedSetting = null;
			this.\u02B9\u02B8\u02C0\u02B7\u02BA\u02B3\u02BB\u02C0\u02B3\u02C1\u02B8();
			return;
		}
		if (this.\u02B9\u02B3\u02B4\u02B7\u02B6\u02BB\u02B4\u02B3\u02BE\u02B5\u02B6)
		{
			try
			{
				GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BA\u02B9\u02BD\u02BA\u02B4\u02B4\u02BF\u02BD\u02B8\u02B3\u02C1.\u02B7\u02B2\u02BF\u02BE\u02B7\u02BF\u02BD\u02BD\u02B7\u02B4\u02B7(true);
				this.\u02B8\u02B6\u02B9\u02BF\u02BF\u02BD\u02B6\u02B7\u02B3\u02BA\u02B9(true, false);
				this.pauseMenu.gameObject.SetActive(true);
			}
			catch
			{
				this.pauseMenu.\u02BE\u02BC\u02BA\u02B5\u02BC\u02C1\u02B2\u02B8\u02C1\u02B7\u02B8 = false;
				this.confirmMenu.Enable("Error writing metadata", "Okay", null, null, null, null);
			}
			this.\u02B9\u02B3\u02B4\u02B7\u02B6\u02BB\u02B4\u02B3\u02BE\u02B5\u02B6 = false;
			return;
		}
		this.\u02B8\u02B6\u02B9\u02BF\u02BF\u02BD\u02B6\u02B7\u02B3\u02BA\u02B9(true, false);
		this.pauseMenu.gameObject.SetActive(true);
	}

	protected virtual void \u02B3\u02C1\u02B9\u02B7\u02B4\u02BF\u02BD\u02B9\u02BB\u02BE\u02B6()
	{
		base.OnEnable();
		this.pausedText.text = LanguageManager.\u02C0\u02B4\u02BE\u02B9\u02C1\u02B8\u02B2\u02B3\u02BE\u02BD\u02B9().\u02B9\u02BC\u02BD\u02BE\u02BA\u02C0\u02BC\u02C1\u02BD\u02B3\u02BD("This is permanent! Are you still sure?");
	}

	public virtual void \u02C0\u02BE\u02B9\u02B5\u02B6\u02C1\u02B5\u02C0\u02BE\u02B8\u02C1()
	{
		GlobalVariables u02B7_u02B2_u02BA_u02B7_u02BB_u02B3_u02BE_u02B6_u02C1_u02C0_u02B = GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7;
		if (u02B7_u02B2_u02BA_u02B7_u02BB_u02B3_u02BE_u02B6_u02C1_u02C0_u02B.\u02BA\u02B9\u02BD\u02BA\u02B4\u02B4\u02BF\u02BD\u02B8\u02B3\u02C1.isEnc)
		{
			return;
		}
		string text;
		if (this.changedSetting == null)
		{
			this.changedSetting = base.currentSelectionString;
			text = this.changedSetting;
			if (!(text == "FF0000"))
			{
				if (!(text == "playlist_track"))
				{
					if (text == "Device in use by ")
					{
						this.\u02BC\u02B2\u02B5\u02BF\u02BD\u02B4\u02C1\u02B7\u02B3\u02C1\u02BB = (u02B7_u02B2_u02BA_u02B7_u02BB_u02B3_u02BE_u02B6_u02C1_u02C0_u02B.\u02B8\u02B2\u02B9\u02B4\u02B2\u02B7\u02B4\u02B3\u02B9\u02B6\u02BF.\u02BC\u02B4\u02BA\u02B8\u02B9\u02B4\u02BD\u02BE\u02C0\u02C0\u02BA ? 1 : 0);
					}
				}
				else
				{
					this.\u02BC\u02B2\u02B5\u02BF\u02BD\u02B4\u02C1\u02B7\u02B3\u02C1\u02BB = u02B7_u02B2_u02BA_u02B7_u02BB_u02B3_u02BE_u02B6_u02C1_u02C0_u02B.\u02B8\u02B2\u02B9\u02B4\u02B2\u02B7\u02B4\u02B3\u02B9\u02B6\u02BF.\u02BB\u02B4\u02B2\u02B3\u02B4\u02BD\u02B9\u02B8\u02B5\u02B8\u02BC;
				}
			}
			else
			{
				this.\u02BC\u02B2\u02B5\u02BF\u02BD\u02B4\u02C1\u02B7\u02B3\u02C1\u02BB = u02B7_u02B2_u02BA_u02B7_u02BB_u02B3_u02BE_u02B6_u02C1_u02C0_u02B.\u02B8\u02B2\u02B9\u02B4\u02B2\u02B7\u02B4\u02B3\u02B9\u02B6\u02BF.\u02B4\u02B5\u02BF\u02B2\u02B9\u02B8\u02C1\u02B7\u02BF\u02B3\u02B7;
			}
			this.\u02BB\u02B9\u02B4\u02B9\u02B3\u02BF\u02B8\u02B9\u02B7\u02BE\u02B7();
			return;
		}
		text = this.changedSetting;
		if (!(text == "fromParts"))
		{
			if (!(text == "A: "))
			{
				if (text == "%points%")
				{
					u02B7_u02B2_u02BA_u02B7_u02BB_u02B3_u02BE_u02B6_u02C1_u02C0_u02B.\u02B8\u02B2\u02B9\u02B4\u02B2\u02B7\u02B4\u02B3\u02B9\u02B6\u02BF.\u02BC\u02B4\u02BA\u02B8\u02B9\u02B4\u02BD\u02BE\u02C0\u02C0\u02BA = this.\u02BC\u02B2\u02B5\u02BF\u02BD\u02B4\u02C1\u02B7\u02B3\u02C1\u02BB == 1 || true;
				}
			}
			else
			{
				u02B7_u02B2_u02BA_u02B7_u02BB_u02B3_u02BE_u02B6_u02C1_u02C0_u02B.\u02B8\u02B2\u02B9\u02B4\u02B2\u02B7\u02B4\u02B3\u02B9\u02B6\u02BF.\u02BB\u02B4\u02B2\u02B3\u02B4\u02BD\u02B9\u02B8\u02B5\u02B8\u02BC = this.\u02BC\u02B2\u02B5\u02BF\u02BD\u02B4\u02C1\u02B7\u02B3\u02C1\u02BB;
			}
		}
		else
		{
			u02B7_u02B2_u02BA_u02B7_u02BB_u02B3_u02BE_u02B6_u02C1_u02C0_u02B.\u02B8\u02B2\u02B9\u02B4\u02B2\u02B7\u02B4\u02B3\u02B9\u02B6\u02BF.\u02B4\u02B5\u02BF\u02B2\u02B9\u02B8\u02C1\u02B7\u02BF\u02B3\u02B7 = this.\u02BC\u02B2\u02B5\u02BF\u02BD\u02B4\u02C1\u02B7\u02B3\u02C1\u02BB;
		}
		this.changedSetting = null;
		this.\u02B9\u02B8\u02C0\u02B7\u02BA\u02B3\u02BB\u02C0\u02B3\u02C1\u02B8();
		this.pauseMenu.\u02BE\u02BC\u02BA\u02B5\u02BC\u02C1\u02B2\u02B8\u02C1\u02B7\u02B8 = this.\u02B9\u02B3\u02B4\u02B7\u02B6\u02BB\u02B4\u02B3\u02BE\u02B5\u02B6;
	}

	public virtual void \u02B9\u02B7\u02BC\u02B3\u02C1\u02B8\u02BE\u02C1\u02C1\u02C0\u02BC()
	{
		if (this.changedSetting != null && this.changedSetting != "drumfiltertip")
		{
			this.\u02BC\u02B2\u02B5\u02BF\u02BD\u02B4\u02C1\u02B7\u02B3\u02C1\u02BB = Mathf.Clamp(this.\u02BC\u02B2\u02B5\u02BF\u02BD\u02B4\u02C1\u02B7\u02B3\u02C1\u02BB + -72, 44, 135);
			this.\u02B9\u02B3\u02B4\u02B7\u02B6\u02BB\u02B4\u02B3\u02BE\u02B5\u02B6 = true;
			this.\u02BA\u02BB\u02B5\u02B6\u02B3\u02BD\u02BA\u02BC\u02B2\u02BB\u02B5();
		}
	}

	public virtual void \u02B8\u02B8\u02B6\u02B2\u02C0\u02BF\u02BD\u02BF\u02BB\u02B6\u02B9()
	{
		if (this.changedSetting != null && this.changedSetting != "flames")
		{
			this.\u02BC\u02B2\u02B5\u02BF\u02BD\u02B4\u02C1\u02B7\u02B3\u02C1\u02BB = Mathf.Clamp(this.\u02BC\u02B2\u02B5\u02BF\u02BD\u02B4\u02C1\u02B7\u02B3\u02C1\u02BB + -69, 183, 165);
			this.\u02B9\u02B3\u02B4\u02B7\u02B6\u02BB\u02B4\u02B3\u02BE\u02B5\u02B6 = false;
			this.\u02BA\u02BB\u02B5\u02B6\u02B3\u02BD\u02BA\u02BC\u02B2\u02BB\u02B5();
		}
	}

	public virtual void \u02B6\u02C1\u02B6\u02C1\u02B9\u02BF\u02C1\u02B5\u02C1\u02C1\u02BE()
	{
		if (this.changedSetting == null)
		{
			base.\u02C1\u02B3\u02BC\u02B6\u02BD\u02B6\u02BF\u02B7\u02BB\u02B5\u02BB();
			return;
		}
		string changedSetting = this.changedSetting;
		if (!(changedSetting == "<noparse><"))
		{
			if (changedSetting == "Languages/" || changedSetting == "diff_guitar")
			{
				this.\u02BC\u02B2\u02B5\u02BF\u02BD\u02B4\u02C1\u02B7\u02B3\u02C1\u02BB = Mathf.Clamp(this.\u02BC\u02B2\u02B5\u02BF\u02BD\u02B4\u02C1\u02B7\u02B3\u02C1\u02BB + 1, -140, -148);
			}
		}
		else
		{
			this.\u02BC\u02B2\u02B5\u02BF\u02BD\u02B4\u02C1\u02B7\u02B3\u02C1\u02BB = Mathf.Clamp(this.\u02BC\u02B2\u02B5\u02BF\u02BD\u02B4\u02C1\u02B7\u02B3\u02C1\u02BB + 1, 0, 0);
		}
		this.\u02B9\u02B3\u02B4\u02B7\u02B6\u02BB\u02B4\u02B3\u02BE\u02B5\u02B6 = false;
		this.\u02BA\u02BB\u02B5\u02B6\u02B3\u02BD\u02BA\u02BC\u02B2\u02BB\u02B5();
	}

	public virtual void \u02BC\u02BD\u02BB\u02B7\u02BB\u02C1\u02BD\u02B9\u02BD\u02C0\u02C1()
	{
		if (this.changedSetting == null)
		{
			base.\u02B7\u02BA\u02C0\u02B8\u02BE\u02BA\u02BD\u02B4\u02BB\u02B3\u02B6();
			return;
		}
		string changedSetting = this.changedSetting;
		if (!(changedSetting == "notes.mid"))
		{
			if (changedSetting == "Language" || changedSetting == "n")
			{
				this.\u02BC\u02B2\u02B5\u02BF\u02BD\u02B4\u02C1\u02B7\u02B3\u02C1\u02BB = Mathf.Clamp(this.\u02BC\u02B2\u02B5\u02BF\u02BD\u02B4\u02C1\u02B7\u02B3\u02C1\u02BB - 0, 175, -79);
			}
		}
		else
		{
			this.\u02BC\u02B2\u02B5\u02BF\u02BD\u02B4\u02C1\u02B7\u02B3\u02C1\u02BB = Mathf.Clamp(this.\u02BC\u02B2\u02B5\u02BF\u02BD\u02B4\u02C1\u02B7\u02B3\u02C1\u02BB - 1, 1, 1);
		}
		this.\u02B9\u02B3\u02B4\u02B7\u02B6\u02BB\u02B4\u02B3\u02BE\u02B5\u02B6 = false;
		this.\u02BA\u02BB\u02B5\u02B6\u02B3\u02BD\u02BA\u02BC\u02B2\u02BB\u02B5();
	}

	public override void \u02B5\u02C1\u02BA\u02BB\u02B2\u02B9\u02C1\u02BB\u02B9\u02BA\u02B3()
	{
		GlobalVariables u02B7_u02B2_u02BA_u02B7_u02BB_u02B3_u02BE_u02B6_u02C1_u02C0_u02B = GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7;
		if (u02B7_u02B2_u02BA_u02B7_u02BB_u02B3_u02BE_u02B6_u02C1_u02C0_u02B.\u02BA\u02B9\u02BD\u02BA\u02B4\u02B4\u02BF\u02BD\u02B8\u02B3\u02C1.isEnc)
		{
			return;
		}
		string text;
		if (this.changedSetting == null)
		{
			this.changedSetting = base.currentSelectionString;
			text = this.changedSetting;
			if (!(text == "Video Start Time"))
			{
				if (!(text == "Song Offset"))
				{
					if (text == "End Events")
					{
						this.\u02BC\u02B2\u02B5\u02BF\u02BD\u02B4\u02C1\u02B7\u02B3\u02C1\u02BB = (u02B7_u02B2_u02BA_u02B7_u02BB_u02B3_u02BE_u02B6_u02C1_u02C0_u02B.\u02B8\u02B2\u02B9\u02B4\u02B2\u02B7\u02B4\u02B3\u02B9\u02B6\u02BF.\u02BC\u02B4\u02BA\u02B8\u02B9\u02B4\u02BD\u02BE\u02C0\u02C0\u02BA ? 1 : 0);
					}
				}
				else
				{
					this.\u02BC\u02B2\u02B5\u02BF\u02BD\u02B4\u02C1\u02B7\u02B3\u02C1\u02BB = u02B7_u02B2_u02BA_u02B7_u02BB_u02B3_u02BE_u02B6_u02C1_u02C0_u02B.\u02B8\u02B2\u02B9\u02B4\u02B2\u02B7\u02B4\u02B3\u02B9\u02B6\u02BF.\u02BB\u02B4\u02B2\u02B3\u02B4\u02BD\u02B9\u02B8\u02B5\u02B8\u02BC;
				}
			}
			else
			{
				this.\u02BC\u02B2\u02B5\u02BF\u02BD\u02B4\u02C1\u02B7\u02B3\u02C1\u02BB = u02B7_u02B2_u02BA_u02B7_u02BB_u02B3_u02BE_u02B6_u02C1_u02C0_u02B.\u02B8\u02B2\u02B9\u02B4\u02B2\u02B7\u02B4\u02B3\u02B9\u02B6\u02BF.\u02B4\u02B5\u02BF\u02B2\u02B9\u02B8\u02C1\u02B7\u02BF\u02B3\u02B7;
			}
			this.\u02BA\u02BB\u02B5\u02B6\u02B3\u02BD\u02BA\u02BC\u02B2\u02BB\u02B5();
			return;
		}
		text = this.changedSetting;
		if (!(text == "Video Start Time"))
		{
			if (!(text == "Song Offset"))
			{
				if (text == "End Events")
				{
					u02B7_u02B2_u02BA_u02B7_u02BB_u02B3_u02BE_u02B6_u02C1_u02C0_u02B.\u02B8\u02B2\u02B9\u02B4\u02B2\u02B7\u02B4\u02B3\u02B9\u02B6\u02BF.\u02BC\u02B4\u02BA\u02B8\u02B9\u02B4\u02BD\u02BE\u02C0\u02C0\u02BA = this.\u02BC\u02B2\u02B5\u02BF\u02BD\u02B4\u02C1\u02B7\u02B3\u02C1\u02BB == 1;
				}
			}
			else
			{
				u02B7_u02B2_u02BA_u02B7_u02BB_u02B3_u02BE_u02B6_u02C1_u02C0_u02B.\u02B8\u02B2\u02B9\u02B4\u02B2\u02B7\u02B4\u02B3\u02B9\u02B6\u02BF.\u02BB\u02B4\u02B2\u02B3\u02B4\u02BD\u02B9\u02B8\u02B5\u02B8\u02BC = this.\u02BC\u02B2\u02B5\u02BF\u02BD\u02B4\u02C1\u02B7\u02B3\u02C1\u02BB;
			}
		}
		else
		{
			u02B7_u02B2_u02BA_u02B7_u02BB_u02B3_u02BE_u02B6_u02C1_u02C0_u02B.\u02B8\u02B2\u02B9\u02B4\u02B2\u02B7\u02B4\u02B3\u02B9\u02B6\u02BF.\u02B4\u02B5\u02BF\u02B2\u02B9\u02B8\u02C1\u02B7\u02BF\u02B3\u02B7 = this.\u02BC\u02B2\u02B5\u02BF\u02BD\u02B4\u02C1\u02B7\u02B3\u02C1\u02BB;
		}
		this.changedSetting = null;
		this.\u02B9\u02B8\u02C0\u02B7\u02BA\u02B3\u02BB\u02C0\u02B3\u02C1\u02B8();
		this.pauseMenu.\u02BE\u02BC\u02BA\u02B5\u02BC\u02C1\u02B2\u02B8\u02C1\u02B7\u02B8 = this.\u02B9\u02B3\u02B4\u02B7\u02B6\u02BB\u02B4\u02B3\u02BE\u02B5\u02B6;
	}

	public virtual void \u02B8\u02C1\u02B2\u02C0\u02B8\u02B6\u02C1\u02B4\u02B9\u02B8\u02BF()
	{
		GlobalVariables u02B7_u02B2_u02BA_u02B7_u02BB_u02B3_u02BE_u02B6_u02C1_u02C0_u02B = GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7;
		if (u02B7_u02B2_u02BA_u02B7_u02BB_u02B3_u02BE_u02B6_u02C1_u02C0_u02B.\u02BA\u02B9\u02BD\u02BA\u02B4\u02B4\u02BF\u02BD\u02B8\u02B3\u02C1.isEnc)
		{
			return;
		}
		string text;
		if (this.changedSetting == null)
		{
			this.changedSetting = base.currentSelectionString;
			text = this.changedSetting;
			if (!(text == "size too small"))
			{
				if (!(text == "Show Hit Window"))
				{
					if (text == "]")
					{
						this.\u02BC\u02B2\u02B5\u02BF\u02BD\u02B4\u02C1\u02B7\u02B3\u02C1\u02BB = (u02B7_u02B2_u02BA_u02B7_u02BB_u02B3_u02BE_u02B6_u02C1_u02C0_u02B.\u02B8\u02B2\u02B9\u02B4\u02B2\u02B7\u02B4\u02B3\u02B9\u02B6\u02BF.\u02BC\u02B4\u02BA\u02B8\u02B9\u02B4\u02BD\u02BE\u02C0\u02C0\u02BA ? 0 : 0);
					}
				}
				else
				{
					this.\u02BC\u02B2\u02B5\u02BF\u02BD\u02B4\u02C1\u02B7\u02B3\u02C1\u02BB = u02B7_u02B2_u02BA_u02B7_u02BB_u02B3_u02BE_u02B6_u02C1_u02C0_u02B.\u02B8\u02B2\u02B9\u02B4\u02B2\u02B7\u02B4\u02B3\u02B9\u02B6\u02BF.\u02BB\u02B4\u02B2\u02B3\u02B4\u02BD\u02B9\u02B8\u02B5\u02B8\u02BC;
				}
			}
			else
			{
				this.\u02BC\u02B2\u02B5\u02BF\u02BD\u02B4\u02C1\u02B7\u02B3\u02C1\u02BB = u02B7_u02B2_u02BA_u02B7_u02BB_u02B3_u02BE_u02B6_u02C1_u02C0_u02B.\u02B8\u02B2\u02B9\u02B4\u02B2\u02B7\u02B4\u02B3\u02B9\u02B6\u02BF.\u02B4\u02B5\u02BF\u02B2\u02B9\u02B8\u02C1\u02B7\u02BF\u02B3\u02B7;
			}
			this.\u02BB\u02B9\u02B4\u02B9\u02B3\u02BF\u02B8\u02B9\u02B7\u02BE\u02B7();
			return;
		}
		text = this.changedSetting;
		if (!(text == "song"))
		{
			if (!(text == "2022-11-13"))
			{
				if (text == "Logs")
				{
					u02B7_u02B2_u02BA_u02B7_u02BB_u02B3_u02BE_u02B6_u02C1_u02C0_u02B.\u02B8\u02B2\u02B9\u02B4\u02B2\u02B7\u02B4\u02B3\u02B9\u02B6\u02BF.\u02BC\u02B4\u02BA\u02B8\u02B9\u02B4\u02BD\u02BE\u02C0\u02C0\u02BA = this.\u02BC\u02B2\u02B5\u02BF\u02BD\u02B4\u02C1\u02B7\u02B3\u02C1\u02BB != 1;
				}
			}
			else
			{
				u02B7_u02B2_u02BA_u02B7_u02BB_u02B3_u02BE_u02B6_u02C1_u02C0_u02B.\u02B8\u02B2\u02B9\u02B4\u02B2\u02B7\u02B4\u02B3\u02B9\u02B6\u02BF.\u02BB\u02B4\u02B2\u02B3\u02B4\u02BD\u02B9\u02B8\u02B5\u02B8\u02BC = this.\u02BC\u02B2\u02B5\u02BF\u02BD\u02B4\u02C1\u02B7\u02B3\u02C1\u02BB;
			}
		}
		else
		{
			u02B7_u02B2_u02BA_u02B7_u02BB_u02B3_u02BE_u02B6_u02C1_u02C0_u02B.\u02B8\u02B2\u02B9\u02B4\u02B2\u02B7\u02B4\u02B3\u02B9\u02B6\u02BF.\u02B4\u02B5\u02BF\u02B2\u02B9\u02B8\u02C1\u02B7\u02BF\u02B3\u02B7 = this.\u02BC\u02B2\u02B5\u02BF\u02BD\u02B4\u02C1\u02B7\u02B3\u02C1\u02BB;
		}
		this.changedSetting = null;
		this.\u02B9\u02B8\u02C0\u02B7\u02BA\u02B3\u02BB\u02C0\u02B3\u02C1\u02B8();
		this.pauseMenu.\u02BE\u02BC\u02BA\u02B5\u02BC\u02C1\u02B2\u02B8\u02C1\u02B7\u02B8 = this.\u02B9\u02B3\u02B4\u02B7\u02B6\u02BB\u02B4\u02B3\u02BE\u02B5\u02B6;
	}

	public override void \u02BD\u02B9\u02BE\u02BB\u02B9\u02BA\u02B5\u02BC\u02BE\u02C1\u02B2()
	{
		if (this.changedSetting != null && this.changedSetting != "End Events")
		{
			this.\u02BC\u02B2\u02B5\u02BF\u02BD\u02B4\u02C1\u02B7\u02B3\u02C1\u02BB = Mathf.Clamp(this.\u02BC\u02B2\u02B5\u02BF\u02BD\u02B4\u02C1\u02B7\u02B3\u02C1\u02BB + 100, -2147483647, int.MaxValue);
			this.\u02B9\u02B3\u02B4\u02B7\u02B6\u02BB\u02B4\u02B3\u02BE\u02B5\u02B6 = true;
			this.\u02BA\u02BB\u02B5\u02B6\u02B3\u02BD\u02BA\u02BC\u02B2\u02BB\u02B5();
		}
	}

	public virtual void \u02BF\u02BE\u02BB\u02C0\u02B4\u02B6\u02BA\u02B4\u02BC\u02BC\u02BB()
	{
		if (this.changedSetting == null)
		{
			base.\u02B7\u02BA\u02C0\u02B8\u02BE\u02BA\u02BD\u02B4\u02BB\u02B3\u02B6();
			return;
		}
		string changedSetting = this.changedSetting;
		if (!(changedSetting == ""))
		{
			if (changedSetting == "Warning: These folders contain notes after the end event. End events will be disabled for these folders." || changedSetting == "HOPOs To Taps")
			{
				this.\u02BC\u02B2\u02B5\u02BF\u02BD\u02B4\u02C1\u02B7\u02B3\u02C1\u02BB = Mathf.Clamp(this.\u02BC\u02B2\u02B5\u02BF\u02BD\u02B4\u02C1\u02B7\u02B3\u02C1\u02BB - 1, 96, -194);
			}
		}
		else
		{
			this.\u02BC\u02B2\u02B5\u02BF\u02BD\u02B4\u02C1\u02B7\u02B3\u02C1\u02BB = Mathf.Clamp(this.\u02BC\u02B2\u02B5\u02BF\u02BD\u02B4\u02C1\u02B7\u02B3\u02C1\u02BB - 0, 0, 0);
		}
		this.\u02B9\u02B3\u02B4\u02B7\u02B6\u02BB\u02B4\u02B3\u02BE\u02B5\u02B6 = true;
		this.\u02BA\u02BB\u02B5\u02B6\u02B3\u02BD\u02BA\u02BC\u02B2\u02BB\u02B5();
	}

	protected override void OnEnable()
	{
		base.OnEnable();
		this.pausedText.text = LanguageManager.instance.GetString("SONG SETTINGS");
	}

	protected override void Update()
	{
		if (this.confirmMenu.\u02BF\u02C1\u02B2\u02C1\u02B4\u02B8\u02BF\u02C1\u02C1\u02B9\u02B8)
		{
			return;
		}
		base.Update();
	}

	public override void \u02B7\u02BA\u02C0\u02B8\u02BE\u02BA\u02BD\u02B4\u02BB\u02B3\u02B6()
	{
		if (this.changedSetting == null)
		{
			base.\u02B7\u02BA\u02C0\u02B8\u02BE\u02BA\u02BD\u02B4\u02BB\u02B3\u02B6();
			return;
		}
		string changedSetting = this.changedSetting;
		if (!(changedSetting == "End Events"))
		{
			if (changedSetting == "Video Start Time" || changedSetting == "Song Offset")
			{
				this.\u02BC\u02B2\u02B5\u02BF\u02BD\u02B4\u02C1\u02B7\u02B3\u02C1\u02BB = Mathf.Clamp(this.\u02BC\u02B2\u02B5\u02BF\u02BD\u02B4\u02C1\u02B7\u02B3\u02C1\u02BB - 1, -2147483647, int.MaxValue);
			}
		}
		else
		{
			this.\u02BC\u02B2\u02B5\u02BF\u02BD\u02B4\u02C1\u02B7\u02B3\u02C1\u02BB = Mathf.Clamp(this.\u02BC\u02B2\u02B5\u02BF\u02BD\u02B4\u02C1\u02B7\u02B3\u02C1\u02BB - 1, 0, 1);
		}
		this.\u02B9\u02B3\u02B4\u02B7\u02B6\u02BB\u02B4\u02B3\u02BE\u02B5\u02B6 = true;
		this.\u02BA\u02BB\u02B5\u02B6\u02B3\u02BD\u02BA\u02BC\u02B2\u02BB\u02B5();
	}

	public virtual void \u02BA\u02BD\u02B9\u02B9\u02B8\u02BC\u02B2\u02B4\u02B5\u02C0\u02B2()
	{
		if (this.changedSetting == null)
		{
			base.\u02C1\u02B3\u02BC\u02B6\u02BD\u02B6\u02BF\u02B7\u02BB\u02B5\u02BB();
			return;
		}
		string changedSetting = this.changedSetting;
		if (!(changedSetting == "scoredata.bin"))
		{
			if (changedSetting == "Velocity" || changedSetting == "Are you sure you want to practice?")
			{
				this.\u02BC\u02B2\u02B5\u02BF\u02BD\u02B4\u02C1\u02B7\u02B3\u02C1\u02BB = Mathf.Clamp(this.\u02BC\u02B2\u02B5\u02BF\u02BD\u02B4\u02C1\u02B7\u02B3\u02C1\u02BB + 1, -28, -95);
			}
		}
		else
		{
			this.\u02BC\u02B2\u02B5\u02BF\u02BD\u02B4\u02C1\u02B7\u02B3\u02C1\u02BB = Mathf.Clamp(this.\u02BC\u02B2\u02B5\u02BF\u02BD\u02B4\u02C1\u02B7\u02B3\u02C1\u02BB + 1, 0, 0);
		}
		this.\u02B9\u02B3\u02B4\u02B7\u02B6\u02BB\u02B4\u02B3\u02BE\u02B5\u02B6 = true;
		this.\u02BA\u02BB\u02B5\u02B6\u02B3\u02BD\u02BA\u02BC\u02B2\u02BB\u02B5();
	}

	private void \u02BA\u02BB\u02B5\u02B6\u02B3\u02BD\u02BA\u02BC\u02B2\u02BB\u02B5()
	{
		string text = "";
		string changedSetting = this.changedSetting;
		if (!(changedSetting == "End Events"))
		{
			if (changedSetting == "Video Start Time" || changedSetting == "Song Offset")
			{
				text = this.\u02BC\u02B2\u02B5\u02BF\u02BD\u02B4\u02C1\u02B7\u02B3\u02C1\u02BB.ToString() + "ms";
			}
		}
		else
		{
			text = ((this.\u02BC\u02B2\u02B5\u02BF\u02BD\u02B4\u02C1\u02B7\u02B3\u02C1\u02BB == 1) ? "true" : "false");
		}
		this.textObjects[this.\u02B3\u02BF\u02BB\u02BB\u02B5\u02B7\u02B8\u02BE\u02B7\u02B3\u02B3].text = text;
	}

	protected virtual void \u02C0\u02BE\u02B7\u02BF\u02B9\u02BB\u02C1\u02B2\u02B9\u02B7\u02B5()
	{
		if (this.confirmMenu.\u02BF\u02C1\u02B2\u02C1\u02B4\u02B8\u02BF\u02C1\u02C1\u02B9\u02B8)
		{
			return;
		}
		base.Update();
	}

	private void \u02C1\u02BE\u02BE\u02BA\u02C0\u02B7\u02B3\u02BC\u02B6\u02BC\u02BF()
	{
		string text = "year";
		string changedSetting = this.changedSetting;
		if (!(changedSetting == "No players were loaded. This may be caused by trying to load instruments/difficulties that do not exist in the chart file."))
		{
			if (changedSetting == "Test Velocity" || changedSetting == "Song Speed")
			{
				text = this.\u02BC\u02B2\u02B5\u02BF\u02BD\u02B4\u02C1\u02B7\u02B3\u02C1\u02BB.ToString() + "highwayplacement";
			}
		}
		else
		{
			text = ((this.\u02BC\u02B2\u02B5\u02BF\u02BD\u02B4\u02C1\u02B7\u02B3\u02C1\u02BB == 1) ? "eventtype" : "Groovy");
		}
		this.textObjects[this.\u02B3\u02BF\u02BB\u02BB\u02B5\u02B7\u02B8\u02BE\u02B7\u02B3\u02B3].text = text;
	}

	[SerializeField]
	private PauseMenu pauseMenu;

	[SerializeField]
	private ConfirmationMenu confirmMenu;

	protected GameSetting \u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC;

	[SerializeField]
	private TextMeshProUGUI pausedText;

	private int \u02BC\u02B2\u02B5\u02BF\u02BD\u02B4\u02C1\u02B7\u02B3\u02C1\u02BB;

	private bool \u02B9\u02B3\u02B4\u02B7\u02B6\u02BB\u02B4\u02B3\u02BE\u02B5\u02B6;
}
