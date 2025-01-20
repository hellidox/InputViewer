using System;
using UnityEngine;

public class DrumSongOptionsMenu : BaseMenu
{
	public void \u02C1\u02B8\u02BB\u02BF\u02BC\u02BF\u02C1\u02BB\u02B3\u02BF\u02BD()
	{
		this.\u02B5\u02B6\u02B8\u02BC\u02BF\u02BF\u02BC\u02B5\u02C0\u02BB\u02C0(0, false);
		base.gameObject.SetActive(false);
	}

	protected virtual void \u02B5\u02B9\u02B7\u02B7\u02B6\u02B5\u02BC\u02BA\u02B4\u02B2\u02B4()
	{
		string[] menuStrings = this.menuStrings;
		if (this.setlistMenu.isActiveAndEnabled && \u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02B4\u02BE\u02B5\u02B6\u02BB\u02B4\u02B6\u02B9\u02B5\u02B7\u02BD.Count > 0)
		{
			this.menuStrings = this.setlistMenuStrings;
		}
		else
		{
			this.menuStrings = this.songlistMenuStrings;
		}
		if (this.menuStrings != menuStrings)
		{
			this.\u02BA\u02BD\u02B3\u02BC\u02B8\u02BB\u02B8\u02BA\u02B5\u02C0\u02C0();
			this.\u02B2\u02BD\u02B6\u02BE\u02B4\u02BE\u02B9\u02B6\u02BD\u02B4\u02B7();
		}
		base.Update();
	}

	protected override void Update()
	{
		string[] menuStrings = this.menuStrings;
		if (this.setlistMenu.isActiveAndEnabled && \u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02B4\u02BE\u02B5\u02B6\u02BB\u02B4\u02B6\u02B9\u02B5\u02B7\u02BD.Count > 0)
		{
			this.menuStrings = this.setlistMenuStrings;
		}
		else
		{
			this.menuStrings = this.songlistMenuStrings;
		}
		if (this.menuStrings != menuStrings)
		{
			this.\u02BA\u02BD\u02B3\u02BC\u02B8\u02BB\u02B8\u02BA\u02B5\u02C0\u02C0();
			this.\u02B2\u02BD\u02B6\u02BE\u02B4\u02BE\u02B9\u02B6\u02BD\u02B4\u02B7();
		}
		base.Update();
	}

	public virtual void \u02B8\u02C1\u02B2\u02C0\u02B8\u02B6\u02C1\u02B4\u02B9\u02B8\u02BF()
	{
		base.\u02B7\u02B6\u02BC\u02BC\u02B3\u02BA\u02BE\u02C0\u02BF\u02B9\u02C1();
		bool flag = false;
		string text = base.\u02B2\u02BF\u02BF\u02BE\u02BD\u02B8\u02BE\u02C0\u02B3\u02B3\u02C0;
		uint num = PrivateImplementationDetails.ComputeStringHash(text);
		if (num <= 3U)
		{
			if (num <= 132U)
			{
				if (num != 13U)
				{
					if (num != 184U)
					{
						goto IL_0248;
					}
					if (!(text == "No"))
					{
						goto IL_0248;
					}
					this.songSelect.\u02BD\u02BA\u02B2\u02C0\u02BC\u02B9\u02B7\u02B9\u02B9\u02B5\u02BF();
					flag = false;
					goto IL_024E;
				}
				else
				{
					if (!(text == "sort_filter"))
					{
						goto IL_0248;
					}
					this.songSelect.\u02BD\u02B6\u02C0\u02BC\u02BA\u02BA\u02B4\u02BE\u02C1\u02B8\u02BB();
					flag = false;
					goto IL_024E;
				}
			}
			else if (num != 134U)
			{
				if (num != 127U)
				{
					if (num != 4294967130U)
					{
						goto IL_0248;
					}
					if (!(text == "Controller Poll Rate"))
					{
						goto IL_0248;
					}
				}
				else
				{
					if (!(text == ""))
					{
						goto IL_0248;
					}
					this.songSelect.\u02BA\u02C1\u02B4\u02BB\u02BC\u02BF\u02BF\u02C1\u02B3\u02C0\u02B3(true);
					goto IL_024E;
				}
			}
			else
			{
				if (!(text == "rhythm"))
				{
					goto IL_0248;
				}
				this.songSelect.\u02C0\u02C0\u02BA\u02BD\u02B8\u02B7\u02B8\u02B5\u02C1\u02B2\u02B9(true);
				goto IL_024E;
			}
		}
		else if (num <= 38U)
		{
			if (num != 4294967258U)
			{
				if (num != 147U)
				{
					if (num != 4294967114U)
					{
						goto IL_0248;
					}
					if (!(text == "-i"))
					{
						goto IL_0248;
					}
					this.songSelect.\u02BC\u02B7\u02BF\u02BD\u02B4\u02BE\u02C0\u02B4\u02BE\u02B7\u02B9();
					goto IL_024E;
				}
				else
				{
					if (!(text == "song"))
					{
						goto IL_0248;
					}
					this.songSelect.\u02BF\u02BA\u02BE\u02BC\u02B4\u02C0\u02B3\u02BC\u02B6\u02B3\u02C0();
					goto IL_024E;
				}
			}
			else
			{
				if (!(text == "SavingText"))
				{
					goto IL_0248;
				}
				this.songSelect.\u02BF\u02BA\u02B2\u02BA\u02B2\u02B9\u02B8\u02BA\u02B6\u02BB\u02C1(false);
				goto IL_024E;
			}
		}
		else if (num != 69U)
		{
			if (num != 4294967263U)
			{
				if (num != 4294967193U)
				{
					goto IL_0248;
				}
				if (!(text == "Server Tickrate"))
				{
					goto IL_0248;
				}
				this.\u02BE\u02BE\u02BA\u02B8\u02B2\u02B4\u02BF\u02B3\u02B3\u02BE\u02B8.\u02B4\u02B3\u02B5\u02B8\u02C0\u02B4\u02B4\u02BF\u02BA\u02BB\u02BC.\u02B8\u02BE\u02BD\u02BB\u02B2\u02B6\u02B3\u02BB\u02BB\u02C0\u02B8(this.\u02BE\u02BE\u02BA\u02B8\u02B2\u02B4\u02BF\u02B3\u02B3\u02BE\u02B8);
				this.\u02BE\u02BE\u02BA\u02B8\u02B2\u02B4\u02BF\u02B3\u02B3\u02BE\u02B8.\u02B4\u02B3\u02B5\u02B8\u02C0\u02B4\u02B4\u02BF\u02BA\u02BB\u02BC.\u02BC\u02BE\u02BE\u02B7\u02B9\u02BC\u02C1\u02BD\u02C1\u02BF\u02BD();
				flag = false;
				goto IL_024E;
			}
			else if (!(text == "ProgressEnd"))
			{
				goto IL_0248;
			}
		}
		else
		{
			if (!(text == "notes.mid"))
			{
				goto IL_0248;
			}
			this.songSelect.\u02B5\u02BD\u02BB\u02BA\u02BD\u02C1\u02BC\u02BF\u02BF\u02B9\u02B9();
			goto IL_024E;
		}
		this.songSelect.GreenLongPressed();
		goto IL_024E;
		IL_0248:
		throw new NotImplementedException();
		IL_024E:
		if (flag)
		{
			base.gameObject.SetActive(true);
		}
	}

	public virtual void \u02BF\u02B4\u02BE\u02BC\u02B9\u02BE\u02BD\u02B7\u02C0\u02C1\u02C0()
	{
		base.\u02B7\u02B6\u02BC\u02BC\u02B3\u02BA\u02BE\u02C0\u02BF\u02B9\u02C1();
		bool flag = false;
		string text = base.\u02B2\u02BF\u02BF\u02BE\u02BD\u02B8\u02BE\u02C0\u02B3\u02B3\u02C0;
		uint num = PrivateImplementationDetails.ComputeStringHash(text);
		if (num <= 4294967235U)
		{
			if (num <= 179U)
			{
				if (num != 76U)
				{
					if (num != 42U)
					{
						goto IL_0248;
					}
					if (!(text == ""))
					{
						goto IL_0248;
					}
					this.songSelect.\u02BD\u02BA\u02B2\u02C0\u02BC\u02B9\u02B7\u02B9\u02B9\u02B5\u02BF();
					flag = true;
					goto IL_024E;
				}
				else
				{
					if (!(text == "Random Song (Section)"))
					{
						goto IL_0248;
					}
					this.songSelect.\u02BD\u02B6\u02C0\u02BC\u02BA\u02BA\u02B4\u02BE\u02C1\u02B8\u02BB();
					flag = false;
					goto IL_024E;
				}
			}
			else if (num != 136U)
			{
				if (num != 102U)
				{
					if (num != 102U)
					{
						goto IL_0248;
					}
					if (!(text == "diff_drums"))
					{
						goto IL_0248;
					}
				}
				else
				{
					if (!(text == "<noparse>"))
					{
						goto IL_0248;
					}
					this.songSelect.\u02BA\u02C1\u02B4\u02BB\u02BC\u02BF\u02BF\u02C1\u02B3\u02C0\u02B3(false);
					goto IL_024E;
				}
			}
			else
			{
				if (!(text == "diff_coopghl"))
				{
					goto IL_0248;
				}
				this.songSelect.\u02C0\u02C0\u02BA\u02BD\u02B8\u02B7\u02B8\u02B5\u02C1\u02B2\u02B9(false);
				goto IL_024E;
			}
		}
		else if (num <= 4294967172U)
		{
			if (num != 4294967113U)
			{
				if (num != 4294967249U)
				{
					if (num != 130U)
					{
						goto IL_0248;
					}
					if (!(text == "album"))
					{
						goto IL_0248;
					}
					this.songSelect.\u02BC\u02B7\u02BF\u02BD\u02B4\u02BE\u02C0\u02B4\u02BE\u02B7\u02B9();
					goto IL_024E;
				}
				else
				{
					if (!(text == "isEOL"))
					{
						goto IL_0248;
					}
					this.songSelect.\u02BF\u02BA\u02BE\u02BC\u02B4\u02C0\u02B3\u02BC\u02B6\u02B3\u02C0();
					goto IL_024E;
				}
			}
			else
			{
				if (!(text == "NoteLayerFadeable"))
				{
					goto IL_0248;
				}
				this.songSelect.\u02BF\u02BA\u02B2\u02BA\u02B2\u02B9\u02B8\u02BA\u02B6\u02BB\u02C1(false);
				goto IL_024E;
			}
		}
		else if (num != 4294967198U)
		{
			if (num != 88U)
			{
				if (num != 57U)
				{
					goto IL_0248;
				}
				if (!(text == "RAM: {0} MBs"))
				{
					goto IL_0248;
				}
				this.\u02BE\u02BE\u02BA\u02B8\u02B2\u02B4\u02BF\u02B3\u02B3\u02BE\u02B8.\u02B4\u02B3\u02B5\u02B8\u02C0\u02B4\u02B4\u02BF\u02BA\u02BB\u02BC.\u02B8\u02BE\u02BD\u02BB\u02B2\u02B6\u02B3\u02BB\u02BB\u02C0\u02B8(this.\u02BE\u02BE\u02BA\u02B8\u02B2\u02B4\u02BF\u02B3\u02B3\u02BE\u02B8);
				this.\u02BE\u02BE\u02BA\u02B8\u02B2\u02B4\u02BF\u02B3\u02B3\u02BE\u02B8.\u02B4\u02B3\u02B5\u02B8\u02C0\u02B4\u02B4\u02BF\u02BA\u02BB\u02BC.\u02BC\u02BE\u02BE\u02B7\u02B9\u02BC\u02C1\u02BD\u02C1\u02BF\u02BD();
				flag = false;
				goto IL_024E;
			}
			else if (!(text == "playlist_track"))
			{
				goto IL_0248;
			}
		}
		else
		{
			if (!(text == "size too small"))
			{
				goto IL_0248;
			}
			this.songSelect.\u02B5\u02BD\u02BB\u02BA\u02BD\u02C1\u02BC\u02BF\u02BF\u02B9\u02B9();
			goto IL_024E;
		}
		this.songSelect.GreenLongPressed();
		goto IL_024E;
		IL_0248:
		throw new NotImplementedException();
		IL_024E:
		if (flag)
		{
			base.gameObject.SetActive(false);
		}
	}

	protected virtual void \u02C1\u02B8\u02B5\u02BD\u02BD\u02C0\u02BB\u02B4\u02BD\u02B8\u02B3()
	{
		string[] menuStrings = this.menuStrings;
		if (this.setlistMenu.isActiveAndEnabled && \u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02B4\u02BE\u02B5\u02B6\u02BB\u02B4\u02B6\u02B9\u02B5\u02B7\u02BD.Count > 1)
		{
			this.menuStrings = this.setlistMenuStrings;
		}
		else
		{
			this.menuStrings = this.songlistMenuStrings;
		}
		if (this.menuStrings != menuStrings)
		{
			this.\u02BA\u02BD\u02B3\u02BC\u02B8\u02BB\u02B8\u02BA\u02B5\u02C0\u02C0();
			this.\u02B2\u02BD\u02B6\u02BE\u02B4\u02BE\u02B9\u02B6\u02BD\u02B4\u02B7();
		}
		base.Update();
	}

	public virtual void \u02B5\u02B4\u02BE\u02B6\u02BC\u02BC\u02C0\u02BC\u02B5\u02BC\u02BF()
	{
		base.gameObject.SetActive(false);
	}

	public void \u02C0\u02B7\u02B3\u02B8\u02B2\u02B9\u02B2\u02BC\u02BE\u02B8\u02BD()
	{
		this.\u02B5\u02B6\u02B8\u02BC\u02BF\u02BF\u02BC\u02B5\u02C0\u02BB\u02C0(0, true);
		base.gameObject.SetActive(true);
	}

	public override void ConfirmPressed()
	{
		base.\u02B7\u02B6\u02BC\u02BC\u02B3\u02BA\u02BE\u02C0\u02BF\u02B9\u02C1();
		bool flag = true;
		string text = base.\u02B2\u02BF\u02BF\u02BE\u02BD\u02B8\u02BE\u02C0\u02B3\u02B3\u02C0;
		uint num = PrivateImplementationDetails.ComputeStringHash(text);
		if (num <= 1426972151U)
		{
			if (num <= 961181185U)
			{
				if (num != 532079470U)
				{
					if (num != 961181185U)
					{
						goto IL_0248;
					}
					if (!(text == "drumsectiontip"))
					{
						goto IL_0248;
					}
					this.songSelect.\u02BD\u02BA\u02B2\u02C0\u02BC\u02B9\u02B7\u02B9\u02B9\u02B5\u02BF();
					flag = false;
					goto IL_024E;
				}
				else
				{
					if (!(text == "drumsorttip"))
					{
						goto IL_0248;
					}
					this.songSelect.\u02BD\u02B6\u02C0\u02BC\u02BA\u02BA\u02B4\u02BE\u02C1\u02B8\u02BB();
					flag = false;
					goto IL_024E;
				}
			}
			else if (num != 1037782193U)
			{
				if (num != 1258121262U)
				{
					if (num != 1426972151U)
					{
						goto IL_0248;
					}
					if (!(text == "drumsonglistGreenHoldTip"))
					{
						goto IL_0248;
					}
				}
				else
				{
					if (!(text == "drumsectionholdtip"))
					{
						goto IL_0248;
					}
					this.songSelect.\u02BA\u02C1\u02B4\u02BB\u02BC\u02BF\u02BF\u02C1\u02B3\u02C0\u02B3(true);
					goto IL_024E;
				}
			}
			else
			{
				if (!(text == "drumsortholdtip"))
				{
					goto IL_0248;
				}
				this.songSelect.\u02C0\u02C0\u02BA\u02BD\u02B8\u02B7\u02B8\u02B5\u02C1\u02B2\u02B9(true);
				goto IL_024E;
			}
		}
		else if (num <= 2759761090U)
		{
			if (num != 1466090344U)
			{
				if (num != 1514967749U)
				{
					if (num != 2759761090U)
					{
						goto IL_0248;
					}
					if (!(text == "drumsongoptions"))
					{
						goto IL_0248;
					}
					this.songSelect.\u02BC\u02B7\u02BF\u02BD\u02B4\u02BE\u02C0\u02B4\u02BE\u02B7\u02B9();
					goto IL_024E;
				}
				else
				{
					if (!(text == "drumblueholdtip"))
					{
						goto IL_0248;
					}
					this.songSelect.\u02BF\u02BA\u02BE\u02BC\u02B4\u02C0\u02B3\u02BC\u02B6\u02B3\u02C0();
					goto IL_024E;
				}
			}
			else
			{
				if (!(text == "drumfiltertip"))
				{
					goto IL_0248;
				}
				this.songSelect.\u02BF\u02BA\u02B2\u02BA\u02B2\u02B9\u02B8\u02BA\u02B6\u02BB\u02C1(true);
				goto IL_024E;
			}
		}
		else if (num != 2937505674U)
		{
			if (num != 3032086596U)
			{
				if (num != 3468287437U)
				{
					goto IL_0248;
				}
				if (!(text == "drumplayerprofile"))
				{
					goto IL_0248;
				}
				this.\u02BE\u02BE\u02BA\u02B8\u02B2\u02B4\u02BF\u02B3\u02B3\u02BE\u02B8.\u02B4\u02B3\u02B5\u02B8\u02C0\u02B4\u02B4\u02BF\u02BA\u02BB\u02BC.\u02B8\u02BE\u02BD\u02BB\u02B2\u02B6\u02B3\u02BB\u02BB\u02C0\u02B8(this.\u02BE\u02BE\u02BA\u02B8\u02B2\u02B4\u02BF\u02B3\u02B3\u02BE\u02B8);
				this.\u02BE\u02BE\u02BA\u02B8\u02B2\u02B4\u02BF\u02B3\u02B3\u02BE\u02B8.\u02B4\u02B3\u02B5\u02B8\u02C0\u02B4\u02B4\u02BF\u02BA\u02BB\u02BC.\u02BC\u02BE\u02BE\u02B7\u02B9\u02BC\u02C1\u02BD\u02C1\u02BF\u02BD();
				flag = false;
				goto IL_024E;
			}
			else if (!(text == "drumsetlistGreenHoldTip"))
			{
				goto IL_0248;
			}
		}
		else
		{
			if (!(text == "drumbluetip"))
			{
				goto IL_0248;
			}
			this.songSelect.\u02B5\u02BD\u02BB\u02BA\u02BD\u02C1\u02BC\u02BF\u02BF\u02B9\u02B9();
			goto IL_024E;
		}
		this.songSelect.GreenLongPressed();
		goto IL_024E;
		IL_0248:
		throw new NotImplementedException();
		IL_024E:
		if (flag)
		{
			base.gameObject.SetActive(false);
		}
	}

	protected virtual void \u02BD\u02B8\u02BD\u02B5\u02B6\u02B3\u02BF\u02B3\u02C1\u02B8\u02C1()
	{
		string[] menuStrings = this.menuStrings;
		if (this.setlistMenu.isActiveAndEnabled && \u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02B4\u02BE\u02B5\u02B6\u02BB\u02B4\u02B6\u02B9\u02B5\u02B7\u02BD.Count > 0)
		{
			this.menuStrings = this.setlistMenuStrings;
		}
		else
		{
			this.menuStrings = this.songlistMenuStrings;
		}
		if (this.menuStrings != menuStrings)
		{
			this.\u02BA\u02BD\u02B3\u02BC\u02B8\u02BB\u02B8\u02BA\u02B5\u02C0\u02C0();
			this.\u02B2\u02BD\u02B6\u02BE\u02B4\u02BE\u02B9\u02B6\u02BD\u02B4\u02B7();
		}
		base.Update();
	}

	public void \u02B5\u02C0\u02C0\u02B2\u02B6\u02B4\u02BB\u02BF\u02BF\u02BC\u02B2()
	{
		this.\u02B5\u02B6\u02B8\u02BC\u02BF\u02BF\u02BC\u02B5\u02C0\u02BB\u02C0(1, false);
		base.gameObject.SetActive(false);
	}

	public override void \u02B3\u02BC\u02BA\u02C0\u02C0\u02B8\u02B2\u02B4\u02B3\u02C1\u02B8()
	{
		base.gameObject.SetActive(false);
	}

	public virtual void \u02C0\u02BE\u02B9\u02B5\u02B6\u02C1\u02B5\u02C0\u02BE\u02B8\u02C1()
	{
		base.\u02B7\u02B6\u02BC\u02BC\u02B3\u02BA\u02BE\u02C0\u02BF\u02B9\u02C1();
		bool flag = true;
		string text = base.\u02B2\u02BF\u02BF\u02BE\u02BD\u02B8\u02BE\u02C0\u02B3\u02B3\u02C0;
		uint num = PrivateImplementationDetails.ComputeStringHash(text);
		if (num <= 4294967197U)
		{
			if (num <= 117U)
			{
				if (num != 105U)
				{
					if (num != 4294967163U)
					{
						goto IL_0248;
					}
					if (!(text == ""))
					{
						goto IL_0248;
					}
					this.songSelect.\u02BD\u02BA\u02B2\u02C0\u02BC\u02B9\u02B7\u02B9\u02B9\u02B5\u02BF();
					flag = true;
					goto IL_024E;
				}
				else
				{
					if (!(text == "native"))
					{
						goto IL_0248;
					}
					this.songSelect.\u02BD\u02B6\u02C0\u02BC\u02BA\u02BA\u02B4\u02BE\u02C1\u02B8\u02BB();
					flag = true;
					goto IL_024E;
				}
			}
			else if (num != 29U)
			{
				if (num != 136U)
				{
					if (num != 4294967120U)
					{
						goto IL_0248;
					}
					if (!(text == "Show in File Explorer"))
					{
						goto IL_0248;
					}
				}
				else
				{
					if (!(text == " + "))
					{
						goto IL_0248;
					}
					this.songSelect.\u02BA\u02C1\u02B4\u02BB\u02BC\u02BF\u02BF\u02C1\u02B3\u02C0\u02B3(true);
					goto IL_024E;
				}
			}
			else
			{
				if (!(text == "Set A Position"))
				{
					goto IL_0248;
				}
				this.songSelect.\u02C0\u02C0\u02BA\u02BD\u02B8\u02B7\u02B8\u02B5\u02C1\u02B2\u02B9(false);
				goto IL_024E;
			}
		}
		else if (num <= 145U)
		{
			if (num != 4294967219U)
			{
				if (num != 176U)
				{
					if (num != 4294967256U)
					{
						goto IL_0248;
					}
					if (!(text == ""))
					{
						goto IL_0248;
					}
					this.songSelect.\u02BC\u02B7\u02BF\u02BD\u02B4\u02BE\u02C0\u02B4\u02BE\u02B7\u02B9();
					goto IL_024E;
				}
				else
				{
					if (!(text == "' not found"))
					{
						goto IL_0248;
					}
					this.songSelect.\u02BF\u02BA\u02BE\u02BC\u02B4\u02C0\u02B3\u02BC\u02B6\u02B3\u02C0();
					goto IL_024E;
				}
			}
			else
			{
				if (!(text == "Change Instrument"))
				{
					goto IL_0248;
				}
				this.songSelect.\u02BF\u02BA\u02B2\u02BA\u02B2\u02B9\u02B8\u02BA\u02B6\u02BB\u02C1(true);
				goto IL_024E;
			}
		}
		else if (num != 4294967227U)
		{
			if (num != 4294967284U)
			{
				if (num != 67U)
				{
					goto IL_0248;
				}
				if (!(text == " "))
				{
					goto IL_0248;
				}
				this.\u02BE\u02BE\u02BA\u02B8\u02B2\u02B4\u02BF\u02B3\u02B3\u02BE\u02B8.\u02B4\u02B3\u02B5\u02B8\u02C0\u02B4\u02B4\u02BF\u02BA\u02BB\u02BC.\u02B8\u02BE\u02BD\u02BB\u02B2\u02B6\u02B3\u02BB\u02BB\u02C0\u02B8(this.\u02BE\u02BE\u02BA\u02B8\u02B2\u02B4\u02BF\u02B3\u02B3\u02BE\u02B8);
				this.\u02BE\u02BE\u02BA\u02B8\u02B2\u02B4\u02BF\u02B3\u02B3\u02BE\u02B8.\u02B4\u02B3\u02B5\u02B8\u02C0\u02B4\u02B4\u02BF\u02BA\u02BB\u02BC.\u02BC\u02BE\u02BE\u02B7\u02B9\u02BC\u02C1\u02BD\u02C1\u02BF\u02BD();
				flag = true;
				goto IL_024E;
			}
			else if (!(text == "song"))
			{
				goto IL_0248;
			}
		}
		else
		{
			if (!(text == "notes"))
			{
				goto IL_0248;
			}
			this.songSelect.\u02B5\u02BD\u02BB\u02BA\u02BD\u02C1\u02BC\u02BF\u02BF\u02B9\u02B9();
			goto IL_024E;
		}
		this.songSelect.GreenLongPressed();
		goto IL_024E;
		IL_0248:
		throw new NotImplementedException();
		IL_024E:
		if (flag)
		{
			base.gameObject.SetActive(true);
		}
	}

	public virtual void \u02BD\u02B3\u02B9\u02BD\u02B3\u02BE\u02B4\u02B9\u02BB\u02BE\u02B9()
	{
		base.\u02B7\u02B6\u02BC\u02BC\u02B3\u02BA\u02BE\u02C0\u02BF\u02B9\u02C1();
		bool flag = true;
		string text = base.\u02B2\u02BF\u02BF\u02BE\u02BD\u02B8\u02BE\u02C0\u02B3\u02B3\u02C0;
		uint num = PrivateImplementationDetails.ComputeStringHash(text);
		if (num <= 163U)
		{
			if (num <= 4294967145U)
			{
				if (num != 4294967229U)
				{
					if (num != 138U)
					{
						goto IL_0248;
					}
					if (!(text == "Menu Music"))
					{
						goto IL_0248;
					}
					this.songSelect.\u02BD\u02BA\u02B2\u02C0\u02BC\u02B9\u02B7\u02B9\u02B9\u02B5\u02BF();
					flag = true;
					goto IL_024E;
				}
				else
				{
					if (!(text == "diff_coop"))
					{
						goto IL_0248;
					}
					this.songSelect.\u02BD\u02B6\u02C0\u02BC\u02BA\u02BA\u02B4\u02BE\u02C1\u02B8\u02BB();
					flag = true;
					goto IL_024E;
				}
			}
			else if (num != 137U)
			{
				if (num != 82U)
				{
					if (num != 4294967273U)
					{
						goto IL_0248;
					}
					if (!(text == "Highways"))
					{
						goto IL_0248;
					}
				}
				else
				{
					if (!(text == "song"))
					{
						goto IL_0248;
					}
					this.songSelect.\u02BA\u02C1\u02B4\u02BB\u02BC\u02BF\u02BF\u02C1\u02B3\u02C0\u02B3(false);
					goto IL_024E;
				}
			}
			else
			{
				if (!(text == "Create Profile"))
				{
					goto IL_0248;
				}
				this.songSelect.\u02C0\u02C0\u02BA\u02BD\u02B8\u02B7\u02B8\u02B5\u02C1\u02B2\u02B9(true);
				goto IL_024E;
			}
		}
		else if (num <= 85U)
		{
			if (num != 4294967263U)
			{
				if (num != 129U)
				{
					if (num != 101U)
					{
						goto IL_0248;
					}
					if (!(text == ""))
					{
						goto IL_0248;
					}
					this.songSelect.\u02BC\u02B7\u02BF\u02BD\u02B4\u02BE\u02C0\u02B4\u02BE\u02B7\u02B9();
					goto IL_024E;
				}
				else
				{
					if (!(text == "WRITING BADSONGS.TXT..."))
					{
						goto IL_0248;
					}
					this.songSelect.\u02BF\u02BA\u02BE\u02BC\u02B4\u02C0\u02B3\u02BC\u02B6\u02B3\u02C0();
					goto IL_024E;
				}
			}
			else
			{
				if (!(text == ""))
				{
					goto IL_0248;
				}
				this.songSelect.\u02BF\u02BA\u02B2\u02BA\u02B2\u02B9\u02B8\u02BA\u02B6\u02BB\u02C1(false);
				goto IL_024E;
			}
		}
		else if (num != 180U)
		{
			if (num != 118U)
			{
				if (num != 4294967249U)
				{
					goto IL_0248;
				}
				if (!(text == "Green Cymbal"))
				{
					goto IL_0248;
				}
				this.\u02BE\u02BE\u02BA\u02B8\u02B2\u02B4\u02BF\u02B3\u02B3\u02BE\u02B8.\u02B4\u02B3\u02B5\u02B8\u02C0\u02B4\u02B4\u02BF\u02BA\u02BB\u02BC.\u02B8\u02BE\u02BD\u02BB\u02B2\u02B6\u02B3\u02BB\u02BB\u02C0\u02B8(this.\u02BE\u02BE\u02BA\u02B8\u02B2\u02B4\u02BF\u02B3\u02B3\u02BE\u02B8);
				this.\u02BE\u02BE\u02BA\u02B8\u02B2\u02B4\u02BF\u02B3\u02B3\u02BE\u02B8.\u02B4\u02B3\u02B5\u02B8\u02C0\u02B4\u02B4\u02BF\u02BA\u02BB\u02BC.\u02BC\u02BE\u02BE\u02B7\u02B9\u02BC\u02C1\u02BD\u02C1\u02BF\u02BD();
				flag = false;
				goto IL_024E;
			}
			else if (!(text == "(10)"))
			{
				goto IL_0248;
			}
		}
		else
		{
			if (!(text == ""))
			{
				goto IL_0248;
			}
			this.songSelect.\u02B5\u02BD\u02BB\u02BA\u02BD\u02C1\u02BC\u02BF\u02BF\u02B9\u02B9();
			goto IL_024E;
		}
		this.songSelect.GreenLongPressed();
		goto IL_024E;
		IL_0248:
		throw new NotImplementedException();
		IL_024E:
		if (flag)
		{
			base.gameObject.SetActive(true);
		}
	}

	[SerializeField]
	private SongSelect songSelect;

	[SerializeField]
	private SetlistMenu setlistMenu;

	[SerializeField]
	private string[] songlistMenuStrings;

	[SerializeField]
	private string[] setlistMenuStrings;
}
