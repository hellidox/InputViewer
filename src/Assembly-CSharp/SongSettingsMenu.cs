using System;
using StrikeCore;
using TMPro;
using UnityEngine;

// Token: 0x02000105 RID: 261
public class SongSettingsMenu : BaseMenu
{
	// Token: 0x06000AED RID: 2797 RVA: 0x00060994 File Offset: 0x0005EB94
	public virtual void \u02BD\u02B7\u02BE\u02BD\u02BF\u02BA\u02BD\u02C0\u02B9\u02BC\u02C1()
	{
		if (this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 == null)
		{
			base.\u02C1\u02B3\u02BC\u02B6\u02BD\u02B6\u02BF\u02B7\u02BB\u02B5\u02BB();
			return;
		}
		string u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B = this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3;
		if (!(u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "*.ini"))
		{
			if (u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "Quit" || u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "Highway Placement")
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

	// Token: 0x06000AEE RID: 2798 RVA: 0x00060A24 File Offset: 0x0005EC24
	public virtual void \u02B3\u02BB\u02B5\u02BC\u02B3\u02B3\u02BC\u02B3\u02B5\u02B7\u02C1()
	{
		if (this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 != null && this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 != "Songs Per Player")
		{
			this.\u02BC\u02B2\u02B5\u02BF\u02BD\u02B4\u02C1\u02B7\u02B3\u02C1\u02BB = Mathf.Clamp(this.\u02BC\u02B2\u02B5\u02BF\u02BD\u02B4\u02C1\u02B7\u02B3\u02C1\u02BB - -22, -89, 96);
			this.\u02B9\u02B3\u02B4\u02B7\u02B6\u02BB\u02B4\u02B3\u02BE\u02B5\u02B6 = false;
			this.\u02BB\u02B9\u02B4\u02B9\u02B3\u02BF\u02B8\u02B9\u02B7\u02BE\u02B7();
		}
	}

	// Token: 0x06000AEF RID: 2799 RVA: 0x00060A78 File Offset: 0x0005EC78
	public virtual void \u02B7\u02B4\u02BA\u02B3\u02C0\u02B3\u02B2\u02B2\u02B5\u02B6\u02C0()
	{
		if (this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 == null)
		{
			base.\u02C1\u02B3\u02BC\u02B6\u02BD\u02B6\u02BF\u02B7\u02BB\u02B5\u02BB();
			return;
		}
		string u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B = this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3;
		if (!(u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "Graphics API"))
		{
			if (u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "Song" || u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "5 Lane Drums")
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

	// Token: 0x06000AF0 RID: 2800 RVA: 0x00060B08 File Offset: 0x0005ED08
	public virtual void \u02B5\u02B7\u02BA\u02BC\u02C1\u02BA\u02BC\u02B3\u02BF\u02B2\u02BF()
	{
		if (this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 == null)
		{
			base.\u02C1\u02B3\u02BC\u02B6\u02BD\u02B6\u02BF\u02B7\u02BB\u02B5\u02BB();
			return;
		}
		string u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B = this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3;
		if (!(u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "MSAA Level"))
		{
			if (u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "float" || u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "botnosave")
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

	// Token: 0x06000AF1 RID: 2801 RVA: 0x0000B7BA File Offset: 0x000099BA
	protected virtual void \u02B7\u02B9\u02B6\u02BB\u02BF\u02BB\u02BF\u02BD\u02B6\u02B9\u02C1()
	{
		base.OnEnable();
		this.pausedText.text = \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02B9\u02BC\u02BD\u02BE\u02BA\u02C0\u02BC\u02C1\u02BD\u02B3\u02BD("The binary key cannot have an odd number of digits");
	}

	// Token: 0x06000AF2 RID: 2802 RVA: 0x00060B98 File Offset: 0x0005ED98
	public override void \u02C1\u02B3\u02BC\u02B6\u02BD\u02B6\u02BF\u02B7\u02BB\u02B5\u02BB()
	{
		if (this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 == null)
		{
			base.\u02C1\u02B3\u02BC\u02B6\u02BD\u02B6\u02BF\u02B7\u02BB\u02B5\u02BB();
			return;
		}
		string u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B = this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3;
		if (!(u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "End Events"))
		{
			if (u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "Video Start Time" || u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "Song Offset")
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

	// Token: 0x06000AF3 RID: 2803 RVA: 0x00060C28 File Offset: 0x0005EE28
	public virtual void \u02BF\u02B4\u02BE\u02BC\u02B9\u02BE\u02BD\u02B7\u02C0\u02C1\u02C0()
	{
		GlobalVariables u02B7_u02B2_u02BA_u02B7_u02BB_u02B3_u02BE_u02B6_u02C1_u02C0_u02B = GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7;
		if (u02B7_u02B2_u02BA_u02B7_u02BB_u02B3_u02BE_u02B6_u02C1_u02C0_u02B.\u02BA\u02B9\u02BD\u02BA\u02B4\u02B4\u02BF\u02BD\u02B8\u02B3\u02C1.isEnc)
		{
			return;
		}
		string text;
		if (this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 == null)
		{
			this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 = base.\u02B2\u02BF\u02BF\u02BE\u02BD\u02B8\u02BE\u02C0\u02B3\u02B3\u02C0;
			text = this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3;
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
		text = this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3;
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
		this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 = null;
		this.\u02B9\u02B8\u02C0\u02B7\u02BA\u02B3\u02BB\u02C0\u02B3\u02C1\u02B8();
		this.pauseMenu.\u02BE\u02BC\u02BA\u02B5\u02BC\u02C1\u02B2\u02B8\u02C1\u02B7\u02B8 = this.\u02B9\u02B3\u02B4\u02B7\u02B6\u02BB\u02B4\u02B3\u02BE\u02B5\u02B6;
	}

	// Token: 0x06000AF5 RID: 2805 RVA: 0x00060D60 File Offset: 0x0005EF60
	public virtual void \u02BA\u02BA\u02B6\u02BE\u02C1\u02B3\u02C1\u02B6\u02BB\u02C1\u02BA()
	{
		if (this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 != null && this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 != "year")
		{
			this.\u02BC\u02B2\u02B5\u02BF\u02BD\u02B4\u02C1\u02B7\u02B3\u02C1\u02BB = Mathf.Clamp(this.\u02BC\u02B2\u02B5\u02BF\u02BD\u02B4\u02C1\u02B7\u02B3\u02C1\u02BB + 24, -178, -186);
			this.\u02B9\u02B3\u02B4\u02B7\u02B6\u02BB\u02B4\u02B3\u02BE\u02B5\u02B6 = false;
			this.\u02BB\u02B9\u02B4\u02B9\u02B3\u02BF\u02B8\u02B9\u02B7\u02BE\u02B7();
		}
	}

	// Token: 0x06000AF6 RID: 2806 RVA: 0x00060DB4 File Offset: 0x0005EFB4
	public override void \u02BB\u02B3\u02BF\u02BC\u02C1\u02BC\u02BC\u02C1\u02C0\u02B5\u02BA()
	{
		if (this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 != null && this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 != "End Events")
		{
			this.\u02BC\u02B2\u02B5\u02BF\u02BD\u02B4\u02C1\u02B7\u02B3\u02C1\u02BB = Mathf.Clamp(this.\u02BC\u02B2\u02B5\u02BF\u02BD\u02B4\u02C1\u02B7\u02B3\u02C1\u02BB - 100, -2147483647, int.MaxValue);
			this.\u02B9\u02B3\u02B4\u02B7\u02B6\u02BB\u02B4\u02B3\u02BE\u02B5\u02B6 = true;
			this.\u02BA\u02BB\u02B5\u02B6\u02B3\u02BD\u02BA\u02BC\u02B2\u02BB\u02B5();
		}
	}

	// Token: 0x06000AF7 RID: 2807 RVA: 0x00060E08 File Offset: 0x0005F008
	private void \u02BB\u02B9\u02B4\u02B9\u02B3\u02BF\u02B8\u02B9\u02B7\u02BE\u02B7()
	{
		string text = "WriteMetadata";
		string u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B = this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3;
		if (!(u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "{0}"))
		{
			if (u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "_GlobalWhammyTexture" || u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "Don't Scan Songs")
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

	// Token: 0x06000AF8 RID: 2808 RVA: 0x00060E8C File Offset: 0x0005F08C
	public override void \u02B3\u02BC\u02BA\u02C0\u02C0\u02B8\u02B2\u02B4\u02B3\u02C1\u02B8()
	{
		if (this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 != null)
		{
			this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 = null;
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
				this.confirmMenu.\u02C0\u02B7\u02B3\u02B8\u02B2\u02B9\u02B2\u02BC\u02BE\u02B8\u02BD("Error writing metadata", "Okay", null, null, null, null);
			}
			this.\u02B9\u02B3\u02B4\u02B7\u02B6\u02BB\u02B4\u02B3\u02BE\u02B5\u02B6 = false;
			return;
		}
		this.\u02B8\u02B6\u02B9\u02BF\u02BF\u02BD\u02B6\u02B7\u02B3\u02BA\u02B9(true, false);
		this.pauseMenu.gameObject.SetActive(true);
	}

	// Token: 0x06000AF9 RID: 2809 RVA: 0x0000B7DC File Offset: 0x000099DC
	protected virtual void \u02B3\u02C1\u02B9\u02B7\u02B4\u02BF\u02BD\u02B9\u02BB\u02BE\u02B6()
	{
		base.OnEnable();
		this.pausedText.text = \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C0\u02B4\u02BE\u02B9\u02C1\u02B8\u02B2\u02B3\u02BE\u02BD\u02B9().\u02B9\u02BC\u02BD\u02BE\u02BA\u02C0\u02BC\u02C1\u02BD\u02B3\u02BD("This is permanent! Are you still sure?");
	}

	// Token: 0x06000AFA RID: 2810 RVA: 0x00060F3C File Offset: 0x0005F13C
	public virtual void \u02C0\u02BE\u02B9\u02B5\u02B6\u02C1\u02B5\u02C0\u02BE\u02B8\u02C1()
	{
		GlobalVariables u02B7_u02B2_u02BA_u02B7_u02BB_u02B3_u02BE_u02B6_u02C1_u02C0_u02B = GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7;
		if (u02B7_u02B2_u02BA_u02B7_u02BB_u02B3_u02BE_u02B6_u02C1_u02C0_u02B.\u02BA\u02B9\u02BD\u02BA\u02B4\u02B4\u02BF\u02BD\u02B8\u02B3\u02C1.isEnc)
		{
			return;
		}
		string text;
		if (this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 == null)
		{
			this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 = base.\u02B2\u02BF\u02BF\u02BE\u02BD\u02B8\u02BE\u02C0\u02B3\u02B3\u02C0;
			text = this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3;
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
		text = this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3;
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
		this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 = null;
		this.\u02B9\u02B8\u02C0\u02B7\u02BA\u02B3\u02BB\u02C0\u02B3\u02C1\u02B8();
		this.pauseMenu.\u02BE\u02BC\u02BA\u02B5\u02BC\u02C1\u02B2\u02B8\u02C1\u02B7\u02B8 = this.\u02B9\u02B3\u02B4\u02B7\u02B6\u02BB\u02B4\u02B3\u02BE\u02B5\u02B6;
	}

	// Token: 0x06000AFB RID: 2811 RVA: 0x00061074 File Offset: 0x0005F274
	public virtual void \u02B9\u02B7\u02BC\u02B3\u02C1\u02B8\u02BE\u02C1\u02C1\u02C0\u02BC()
	{
		if (this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 != null && this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 != "drumfiltertip")
		{
			this.\u02BC\u02B2\u02B5\u02BF\u02BD\u02B4\u02C1\u02B7\u02B3\u02C1\u02BB = Mathf.Clamp(this.\u02BC\u02B2\u02B5\u02BF\u02BD\u02B4\u02C1\u02B7\u02B3\u02C1\u02BB + -72, 44, 135);
			this.\u02B9\u02B3\u02B4\u02B7\u02B6\u02BB\u02B4\u02B3\u02BE\u02B5\u02B6 = true;
			this.\u02BA\u02BB\u02B5\u02B6\u02B3\u02BD\u02BA\u02BC\u02B2\u02BB\u02B5();
		}
	}

	// Token: 0x06000AFC RID: 2812 RVA: 0x000610C8 File Offset: 0x0005F2C8
	public virtual void \u02B8\u02B8\u02B6\u02B2\u02C0\u02BF\u02BD\u02BF\u02BB\u02B6\u02B9()
	{
		if (this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 != null && this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 != "flames")
		{
			this.\u02BC\u02B2\u02B5\u02BF\u02BD\u02B4\u02C1\u02B7\u02B3\u02C1\u02BB = Mathf.Clamp(this.\u02BC\u02B2\u02B5\u02BF\u02BD\u02B4\u02C1\u02B7\u02B3\u02C1\u02BB + -69, 183, 165);
			this.\u02B9\u02B3\u02B4\u02B7\u02B6\u02BB\u02B4\u02B3\u02BE\u02B5\u02B6 = false;
			this.\u02BA\u02BB\u02B5\u02B6\u02B3\u02BD\u02BA\u02BC\u02B2\u02BB\u02B5();
		}
	}

	// Token: 0x06000AFD RID: 2813 RVA: 0x0006111C File Offset: 0x0005F31C
	public virtual void \u02B6\u02C1\u02B6\u02C1\u02B9\u02BF\u02C1\u02B5\u02C1\u02C1\u02BE()
	{
		if (this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 == null)
		{
			base.\u02C1\u02B3\u02BC\u02B6\u02BD\u02B6\u02BF\u02B7\u02BB\u02B5\u02BB();
			return;
		}
		string u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B = this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3;
		if (!(u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "<noparse><"))
		{
			if (u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "Languages/" || u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "diff_guitar")
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

	// Token: 0x06000AFE RID: 2814 RVA: 0x000611AC File Offset: 0x0005F3AC
	public virtual void \u02BC\u02BD\u02BB\u02B7\u02BB\u02C1\u02BD\u02B9\u02BD\u02C0\u02C1()
	{
		if (this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 == null)
		{
			base.\u02B7\u02BA\u02C0\u02B8\u02BE\u02BA\u02BD\u02B4\u02BB\u02B3\u02B6();
			return;
		}
		string u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B = this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3;
		if (!(u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "notes.mid"))
		{
			if (u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "Language" || u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "n")
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

	// Token: 0x06000AFF RID: 2815 RVA: 0x0006123C File Offset: 0x0005F43C
	public override void \u02B5\u02C1\u02BA\u02BB\u02B2\u02B9\u02C1\u02BB\u02B9\u02BA\u02B3()
	{
		GlobalVariables u02B7_u02B2_u02BA_u02B7_u02BB_u02B3_u02BE_u02B6_u02C1_u02C0_u02B = GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7;
		if (u02B7_u02B2_u02BA_u02B7_u02BB_u02B3_u02BE_u02B6_u02C1_u02C0_u02B.\u02BA\u02B9\u02BD\u02BA\u02B4\u02B4\u02BF\u02BD\u02B8\u02B3\u02C1.isEnc)
		{
			return;
		}
		string text;
		if (this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 == null)
		{
			this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 = base.\u02B2\u02BF\u02BF\u02BE\u02BD\u02B8\u02BE\u02C0\u02B3\u02B3\u02C0;
			text = this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3;
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
		text = this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3;
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
		this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 = null;
		this.\u02B9\u02B8\u02C0\u02B7\u02BA\u02B3\u02BB\u02C0\u02B3\u02C1\u02B8();
		this.pauseMenu.\u02BE\u02BC\u02BA\u02B5\u02BC\u02C1\u02B2\u02B8\u02C1\u02B7\u02B8 = this.\u02B9\u02B3\u02B4\u02B7\u02B6\u02BB\u02B4\u02B3\u02BE\u02B5\u02B6;
	}

	// Token: 0x06000B00 RID: 2816 RVA: 0x00061374 File Offset: 0x0005F574
	public virtual void \u02B8\u02C1\u02B2\u02C0\u02B8\u02B6\u02C1\u02B4\u02B9\u02B8\u02BF()
	{
		GlobalVariables u02B7_u02B2_u02BA_u02B7_u02BB_u02B3_u02BE_u02B6_u02C1_u02C0_u02B = GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7;
		if (u02B7_u02B2_u02BA_u02B7_u02BB_u02B3_u02BE_u02B6_u02C1_u02C0_u02B.\u02BA\u02B9\u02BD\u02BA\u02B4\u02B4\u02BF\u02BD\u02B8\u02B3\u02C1.isEnc)
		{
			return;
		}
		string text;
		if (this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 == null)
		{
			this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 = base.\u02B2\u02BF\u02BF\u02BE\u02BD\u02B8\u02BE\u02C0\u02B3\u02B3\u02C0;
			text = this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3;
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
		text = this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3;
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
		this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 = null;
		this.\u02B9\u02B8\u02C0\u02B7\u02BA\u02B3\u02BB\u02C0\u02B3\u02C1\u02B8();
		this.pauseMenu.\u02BE\u02BC\u02BA\u02B5\u02BC\u02C1\u02B2\u02B8\u02C1\u02B7\u02B8 = this.\u02B9\u02B3\u02B4\u02B7\u02B6\u02BB\u02B4\u02B3\u02BE\u02B5\u02B6;
	}

	// Token: 0x06000B01 RID: 2817 RVA: 0x000614AC File Offset: 0x0005F6AC
	public override void \u02BD\u02B9\u02BE\u02BB\u02B9\u02BA\u02B5\u02BC\u02BE\u02C1\u02B2()
	{
		if (this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 != null && this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 != "End Events")
		{
			this.\u02BC\u02B2\u02B5\u02BF\u02BD\u02B4\u02C1\u02B7\u02B3\u02C1\u02BB = Mathf.Clamp(this.\u02BC\u02B2\u02B5\u02BF\u02BD\u02B4\u02C1\u02B7\u02B3\u02C1\u02BB + 100, -2147483647, int.MaxValue);
			this.\u02B9\u02B3\u02B4\u02B7\u02B6\u02BB\u02B4\u02B3\u02BE\u02B5\u02B6 = true;
			this.\u02BA\u02BB\u02B5\u02B6\u02B3\u02BD\u02BA\u02BC\u02B2\u02BB\u02B5();
		}
	}

	// Token: 0x06000B02 RID: 2818 RVA: 0x00061500 File Offset: 0x0005F700
	public virtual void \u02BF\u02BE\u02BB\u02C0\u02B4\u02B6\u02BA\u02B4\u02BC\u02BC\u02BB()
	{
		if (this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 == null)
		{
			base.\u02B7\u02BA\u02C0\u02B8\u02BE\u02BA\u02BD\u02B4\u02BB\u02B3\u02B6();
			return;
		}
		string u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B = this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3;
		if (!(u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == ""))
		{
			if (u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "Warning: These folders contain notes after the end event. End events will be disabled for these folders." || u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "HOPOs To Taps")
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

	// Token: 0x06000B03 RID: 2819 RVA: 0x0000B7FE File Offset: 0x000099FE
	protected override void OnEnable()
	{
		base.OnEnable();
		this.pausedText.text = \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6("SONG SETTINGS");
	}

	// Token: 0x06000B04 RID: 2820 RVA: 0x0000B820 File Offset: 0x00009A20
	protected override void Update()
	{
		if (this.confirmMenu.\u02BF\u02C1\u02B2\u02C1\u02B4\u02B8\u02BF\u02C1\u02C1\u02B9\u02B8)
		{
			return;
		}
		base.Update();
	}

	// Token: 0x06000B05 RID: 2821 RVA: 0x00061590 File Offset: 0x0005F790
	public override void \u02B7\u02BA\u02C0\u02B8\u02BE\u02BA\u02BD\u02B4\u02BB\u02B3\u02B6()
	{
		if (this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 == null)
		{
			base.\u02B7\u02BA\u02C0\u02B8\u02BE\u02BA\u02BD\u02B4\u02BB\u02B3\u02B6();
			return;
		}
		string u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B = this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3;
		if (!(u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "End Events"))
		{
			if (u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "Video Start Time" || u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "Song Offset")
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

	// Token: 0x06000B06 RID: 2822 RVA: 0x00061620 File Offset: 0x0005F820
	public virtual void \u02BA\u02BD\u02B9\u02B9\u02B8\u02BC\u02B2\u02B4\u02B5\u02C0\u02B2()
	{
		if (this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 == null)
		{
			base.\u02C1\u02B3\u02BC\u02B6\u02BD\u02B6\u02BF\u02B7\u02BB\u02B5\u02BB();
			return;
		}
		string u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B = this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3;
		if (!(u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "scoredata.bin"))
		{
			if (u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "Velocity" || u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "Are you sure you want to practice?")
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

	// Token: 0x06000B07 RID: 2823 RVA: 0x000616B0 File Offset: 0x0005F8B0
	private void \u02BA\u02BB\u02B5\u02B6\u02B3\u02BD\u02BA\u02BC\u02B2\u02BB\u02B5()
	{
		string text = "";
		string u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B = this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3;
		if (!(u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "End Events"))
		{
			if (u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "Video Start Time" || u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "Song Offset")
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

	// Token: 0x06000B08 RID: 2824 RVA: 0x0000B820 File Offset: 0x00009A20
	protected virtual void \u02C0\u02BE\u02B7\u02BF\u02B9\u02BB\u02C1\u02B2\u02B9\u02B7\u02B5()
	{
		if (this.confirmMenu.\u02BF\u02C1\u02B2\u02C1\u02B4\u02B8\u02BF\u02C1\u02C1\u02B9\u02B8)
		{
			return;
		}
		base.Update();
	}

	// Token: 0x06000B09 RID: 2825 RVA: 0x00061734 File Offset: 0x0005F934
	private void \u02C1\u02BE\u02BE\u02BA\u02C0\u02B7\u02B3\u02BC\u02B6\u02BC\u02BF()
	{
		string text = "year";
		string u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B = this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3;
		if (!(u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "No players were loaded. This may be caused by trying to load instruments/difficulties that do not exist in the chart file."))
		{
			if (u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "Test Velocity" || u02BE_u02BA_u02B2_u02BB_u02BA_u02B3_u02B2_u02B2_u02B6_u02BF_u02B == "Song Speed")
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

	// Token: 0x0400080D RID: 2061
	[SerializeField]
	private PauseMenu pauseMenu;

	// Token: 0x0400080E RID: 2062
	[SerializeField]
	private ConfirmationMenu confirmMenu;

	// Token: 0x0400080F RID: 2063
	protected GameSetting \u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC;

	// Token: 0x04000810 RID: 2064
	[SerializeField]
	private TextMeshProUGUI pausedText;

	// Token: 0x04000811 RID: 2065
	private int \u02BC\u02B2\u02B5\u02BF\u02BD\u02B4\u02C1\u02B7\u02B3\u02C1\u02BB;

	// Token: 0x04000812 RID: 2066
	private bool \u02B9\u02B3\u02B4\u02B7\u02B6\u02BB\u02B4\u02B3\u02BE\u02B5\u02B6;
}
