using System;
using StrikeCore;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020000F7 RID: 247
public abstract class BaseSettingMenu : BaseMenu
{
	// Token: 0x060009E5 RID: 2533 RVA: 0x000567B4 File Offset: 0x000549B4
	protected virtual void Awake()
	{
		this.\u02BD\u02B5\u02BC\u02B8\u02B2\u02C0\u02B7\u02B8\u02B9\u02C0\u02B9 = base.GetComponent<ScrollRect>();
		this.\u02BF\u02B2\u02BF\u02C0\u02BA\u02BB\u02B2\u02C0\u02B3\u02BA\u02BD = base.GetComponentInChildren<Scrollbar>();
		if (this.\u02BD\u02B5\u02BC\u02B8\u02B2\u02C0\u02B7\u02B8\u02B9\u02C0\u02B9 != null && this.\u02BF\u02B2\u02BF\u02C0\u02BA\u02BB\u02B2\u02C0\u02B3\u02BA\u02BD != null)
		{
			this.\u02BD\u02B5\u02BC\u02B8\u02B2\u02C0\u02B7\u02B8\u02B9\u02C0\u02B9.content.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, (float)(this.menuStrings.Length + 2) * 80f);
			this.\u02BF\u02B2\u02BF\u02C0\u02BA\u02BB\u02B2\u02C0\u02B3\u02BA\u02BD.size = 7f / (float)this.menuStrings.Length;
		}
	}

	// Token: 0x060009E6 RID: 2534 RVA: 0x0000AD69 File Offset: 0x00008F69
	protected override void OnEnable()
	{
		base.OnEnable();
		this.\u02BA\u02B8\u02B4\u02BA\u02BD\u02BA\u02B7\u02C1\u02B8\u02B8\u02BC();
	}

	// Token: 0x060009E7 RID: 2535
	protected abstract void \u02BA\u02B8\u02B4\u02BA\u02BD\u02BA\u02B7\u02C1\u02B8\u02B8\u02BC();

	// Token: 0x060009E8 RID: 2536
	protected abstract void \u02B5\u02B8\u02B6\u02B4\u02BB\u02B4\u02BF\u02BE\u02B5\u02BE\u02C1();

	// Token: 0x060009E9 RID: 2537
	protected abstract void \u02BA\u02BB\u02B5\u02B6\u02B3\u02BD\u02BA\u02BC\u02B2\u02BB\u02B5();

	// Token: 0x060009EA RID: 2538
	public abstract void \u02B4\u02BF\u02B6\u02B3\u02B7\u02BA\u02B9\u02B9\u02BD\u02BD\u02B4();

	// Token: 0x060009EB RID: 2539 RVA: 0x00056834 File Offset: 0x00054A34
	public override void \u02B3\u02BC\u02BA\u02C0\u02C0\u02B8\u02B2\u02B4\u02B3\u02C1\u02B8()
	{
		if (this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 != null)
		{
			this.\u02B5\u02B8\u02B6\u02B4\u02BB\u02B4\u02BF\u02BE\u02B5\u02BE\u02C1();
			this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 = null;
			this.\u02B9\u02B8\u02C0\u02B7\u02BA\u02B3\u02BB\u02C0\u02B3\u02C1\u02B8();
		}
		else
		{
			this.\u02C1\u02BB\u02BD\u02B3\u02B9\u02BC\u02BD\u02BF\u02BF\u02B3\u02B3();
			this.\u02B8\u02B6\u02B9\u02BF\u02BF\u02BD\u02B6\u02B7\u02B3\u02BA\u02B9(false, !this.\u02BD\u02C0\u02B2\u02B2\u02BD\u02BD\u02C0\u02B7\u02B4\u02B3\u02C0);
			this.\u02C1\u02B6\u02B7\u02BC\u02B3\u02BE\u02B3\u02C1\u02B4\u02B2\u02BC.enabled = true;
			this.\u02C1\u02B6\u02B7\u02BC\u02B3\u02BE\u02B3\u02C1\u02B4\u02B2\u02BC.gameObject.SetActive(true);
		}
		this.backgroundObjects[base.\u02BF\u02B6\u02B5\u02BF\u02BD\u02BF\u02B4\u02B3\u02B8\u02BE\u02BC].sprite = this.\u02BD\u02BD\u02B6\u02C1\u02B6\u02BD\u02BA\u02B8\u02BE\u02BF\u02B9;
	}

	// Token: 0x060009EC RID: 2540 RVA: 0x0000AD77 File Offset: 0x00008F77
	public override void \u02BA\u02BC\u02C1\u02BE\u02B6\u02B4\u02B9\u02B2\u02B3\u02BD\u02B4()
	{
		if (this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC == null)
		{
			return;
		}
		this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC.Reset();
		this.\u02BA\u02BB\u02B5\u02B6\u02B3\u02BD\u02BA\u02BC\u02B2\u02BB\u02B5();
	}

	// Token: 0x060009ED RID: 2541 RVA: 0x000568AC File Offset: 0x00054AAC
	public override void \u02C1\u02B3\u02BC\u02B6\u02BD\u02B6\u02BF\u02B7\u02BB\u02B5\u02BB()
	{
		if (this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 == null)
		{
			this.\u02BC\u02B7\u02C0\u02B6\u02C1\u02B9\u02BB\u02B2\u02BD\u02B3\u02B8 = true;
			this.\u02BE\u02B4\u02BD\u02B6\u02B5\u02B7\u02BB\u02BE\u02B3\u02B5\u02B9(this.\u02B7\u02BE\u02BD\u02BF\u02B7\u02BE\u02B4\u02B4\u02BA\u02B9\u02C1);
			this.\u02B4\u02B7\u02B3\u02BF\u02B4\u02BF\u02B9\u02C1\u02B6\u02B2\u02C0 = true;
		}
		else
		{
			GameSetting u02B7_u02B6_u02B7_u02B8_u02B7_u02B6_u02B5_u02BD_u02C1_u02B9_u02BC = this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC;
			if (u02B7_u02B6_u02B7_u02B8_u02B7_u02B6_u02B5_u02BD_u02C1_u02B9_u02BC != null)
			{
				u02B7_u02B6_u02B7_u02B8_u02B7_u02B6_u02B5_u02BD_u02C1_u02B9_u02BC.Increment();
			}
			this.\u02BA\u02BB\u02B5\u02B6\u02B3\u02BD\u02BA\u02BC\u02B2\u02BB\u02B5();
		}
		if (this.backgroundObjects[this.\u02B3\u02BF\u02BB\u02BB\u02B5\u02B7\u02B8\u02BE\u02B7\u02B3\u02B3] == null && this.\u02B3\u02BF\u02BB\u02BB\u02B5\u02B7\u02B8\u02BE\u02B7\u02B3\u02B3 != 0)
		{
			this.\u02B7\u02BE\u02BD\u02BF\u02B7\u02BE\u02B4\u02B4\u02BA\u02B9\u02C1 = false;
			this.\u02C1\u02B3\u02BC\u02B6\u02BD\u02B6\u02BF\u02B7\u02BB\u02B5\u02BB();
		}
		base.\u02B2\u02BA\u02B2\u02BC\u02BE\u02B5\u02B4\u02C0\u02BC\u02B6\u02BD();
		this.\u02B7\u02BE\u02BD\u02BF\u02B7\u02BE\u02B4\u02B4\u02BA\u02B9\u02C1 = true;
	}

	// Token: 0x060009EE RID: 2542 RVA: 0x0005692C File Offset: 0x00054B2C
	public override void \u02B7\u02BA\u02C0\u02B8\u02BE\u02BA\u02BD\u02B4\u02BB\u02B3\u02B6()
	{
		if (this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 == null)
		{
			this.\u02B7\u02C0\u02BB\u02B6\u02B3\u02C0\u02B9\u02BF\u02B5\u02C0\u02B6 = true;
			this.\u02B7\u02C1\u02BA\u02BA\u02B2\u02B5\u02B7\u02BD\u02BC\u02C1\u02BE(this.\u02B7\u02BE\u02BD\u02BF\u02B7\u02BE\u02B4\u02B4\u02BA\u02B9\u02C1);
			this.\u02C0\u02C1\u02B6\u02BF\u02BF\u02B2\u02B5\u02C0\u02BB\u02BA\u02C1 = true;
		}
		else
		{
			GameSetting u02B7_u02B6_u02B7_u02B8_u02B7_u02B6_u02B5_u02BD_u02C1_u02B9_u02BC = this.\u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC;
			if (u02B7_u02B6_u02B7_u02B8_u02B7_u02B6_u02B5_u02BD_u02C1_u02B9_u02BC != null)
			{
				u02B7_u02B6_u02B7_u02B8_u02B7_u02B6_u02B5_u02BD_u02C1_u02B9_u02BC.Decrement();
			}
			this.\u02BA\u02BB\u02B5\u02B6\u02B3\u02BD\u02BA\u02BC\u02B2\u02BB\u02B5();
		}
		if (this.backgroundObjects[this.\u02B3\u02BF\u02BB\u02BB\u02B5\u02B7\u02B8\u02BE\u02B7\u02B3\u02B3] == null)
		{
			this.\u02B7\u02BE\u02BD\u02BF\u02B7\u02BE\u02B4\u02B4\u02BA\u02B9\u02C1 = false;
			this.\u02B7\u02BA\u02C0\u02B8\u02BE\u02BA\u02BD\u02B4\u02BB\u02B3\u02B6();
		}
		base.\u02B2\u02BA\u02B2\u02BC\u02BE\u02B5\u02B4\u02C0\u02BC\u02B6\u02BD();
		this.\u02B7\u02BE\u02BD\u02BF\u02B7\u02BE\u02B4\u02B4\u02BA\u02B9\u02C1 = true;
	}

	// Token: 0x060009EF RID: 2543 RVA: 0x000569A4 File Offset: 0x00054BA4
	protected override void Update()
	{
		base.Update();
		if (this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3 != null)
		{
			if (Input.GetKeyDown(KeyCode.End))
			{
				GameSetting gameSetting = this.\u02B9\u02B5\u02B5\u02B7\u02BE\u02BF\u02B6\u02B5\u02BB\u02B9\u02C1(this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3);
				if (gameSetting != null)
				{
					gameSetting.CurrentValue = gameSetting.MaxValue;
					this.\u02BA\u02B4\u02BC\u02BA\u02B7\u02B7\u02B7\u02BE\u02B7\u02C1\u02C0("");
				}
			}
			if (Input.GetKeyDown(KeyCode.Home))
			{
				GameSetting gameSetting2 = this.\u02B9\u02B5\u02B5\u02B7\u02BE\u02BF\u02B6\u02B5\u02BB\u02B9\u02C1(this.\u02BE\u02BA\u02B2\u02BB\u02BA\u02B3\u02B2\u02B2\u02B6\u02BF\u02B3);
				if (gameSetting2 != null)
				{
					gameSetting2.CurrentValue = gameSetting2.MinValue;
					this.\u02BA\u02B4\u02BC\u02BA\u02B7\u02B7\u02B7\u02BE\u02B7\u02C1\u02C0("");
				}
			}
		}
	}

	// Token: 0x060009F0 RID: 2544
	protected abstract GameSetting \u02B9\u02B5\u02B5\u02B7\u02BE\u02BF\u02B6\u02B5\u02BB\u02B9\u02C1(string \u02B6\u02BF\u02C1\u02C0\u02BA\u02B5\u02B3\u02B6\u02B8\u02B9\u02C1);

	// Token: 0x060009F1 RID: 2545
	public abstract void \u02BA\u02B4\u02BC\u02BA\u02B7\u02B7\u02B7\u02BE\u02B7\u02C1\u02C0(string \u02B6\u02BF\u02C1\u02C0\u02BA\u02B5\u02B3\u02B6\u02B8\u02B9\u02C1 = "");

	// Token: 0x060009F2 RID: 2546 RVA: 0x0000AD93 File Offset: 0x00008F93
	public void \u02B7\u02B9\u02BE\u02B8\u02B8\u02BB\u02B2\u02BB\u02B3\u02BC\u02BE(int \u02B8\u02BE\u02BE\u02B4\u02B3\u02B2\u02BF\u02BB\u02B4\u02BE\u02B5, GameSetting \u02BA\u02BB\u02B6\u02B6\u02BF\u02B6\u02BA\u02B9\u02B9\u02BB\u02B7)
	{
		this.\u02B7\u02BA\u02B7\u02C0\u02B9\u02BA\u02B2\u02BF\u02B4\u02BC\u02B4[\u02B8\u02BE\u02BE\u02B4\u02B3\u02B2\u02BF\u02BB\u02B4\u02BE\u02B5].value = (\u02BA\u02BB\u02B6\u02B6\u02BF\u02B6\u02BA\u02B9\u02B9\u02BB\u02B7.GetBoolValue ? 1f : 0f);
		this.\u02B2\u02B6\u02BB\u02B7\u02BE\u02B4\u02B9\u02BF\u02C1\u02BE\u02B5[\u02B8\u02BE\u02BE\u02B4\u02B3\u02B2\u02BF\u02BB\u02B4\u02BE\u02B5].enabled = \u02BA\u02BB\u02B6\u02B6\u02BF\u02B6\u02BA\u02B9\u02B9\u02BB\u02B7.GetBoolValue;
	}

	// Token: 0x060009F3 RID: 2547 RVA: 0x0000ADC9 File Offset: 0x00008FC9
	public void \u02B7\u02B9\u02BE\u02B8\u02B8\u02BB\u02B2\u02BB\u02B3\u02BC\u02BE(int \u02B8\u02BE\u02BE\u02B4\u02B3\u02B2\u02BF\u02BB\u02B4\u02BE\u02B5, bool \u02B6\u02B2\u02B5\u02BB\u02C1\u02BB\u02BA\u02B4\u02BF\u02BA\u02B5)
	{
		this.\u02B7\u02BA\u02B7\u02C0\u02B9\u02BA\u02B2\u02BF\u02B4\u02BC\u02B4[\u02B8\u02BE\u02BE\u02B4\u02B3\u02B2\u02BF\u02BB\u02B4\u02BE\u02B5].value = (\u02B6\u02B2\u02B5\u02BB\u02C1\u02BB\u02BA\u02B4\u02BF\u02BA\u02B5 ? 1f : 0f);
		this.\u02B2\u02B6\u02BB\u02B7\u02BE\u02B4\u02B9\u02BF\u02C1\u02BE\u02B5[\u02B8\u02BE\u02BE\u02B4\u02B3\u02B2\u02BF\u02BB\u02B4\u02BE\u02B5].enabled = \u02B6\u02B2\u02B5\u02BB\u02C1\u02BB\u02BA\u02B4\u02BF\u02BA\u02B5;
	}

	// Token: 0x060009F4 RID: 2548 RVA: 0x0000ADF5 File Offset: 0x00008FF5
	public void \u02BA\u02BC\u02C1\u02BE\u02B4\u02B3\u02BA\u02BC\u02BB\u02C1\u02BB(int \u02B8\u02BE\u02BE\u02B4\u02B3\u02B2\u02BF\u02BB\u02B4\u02BE\u02B5, GameSetting \u02BA\u02BB\u02B6\u02B6\u02BF\u02B6\u02BA\u02B9\u02B9\u02BB\u02B7)
	{
		this.\u02BA\u02B5\u02C1\u02B4\u02B4\u02BF\u02BE\u02C0\u02B9\u02B3\u02B5[\u02B8\u02BE\u02BE\u02B4\u02B3\u02B2\u02BF\u02BB\u02B4\u02BE\u02B5].value = (float)Math.Min(\u02BA\u02BB\u02B6\u02B6\u02BF\u02B6\u02BA\u02B9\u02B9\u02BB\u02B7.CurrentValue, (int)this.\u02BA\u02B5\u02C1\u02B4\u02B4\u02BF\u02BE\u02C0\u02B9\u02B3\u02B5[\u02B8\u02BE\u02BE\u02B4\u02B3\u02B2\u02BF\u02BB\u02B4\u02BE\u02B5].maxValue);
		this.\u02C0\u02B9\u02C0\u02B2\u02B5\u02BA\u02BD\u02BF\u02B2\u02B7\u02B3[\u02B8\u02BE\u02BE\u02B4\u02B3\u02B2\u02BF\u02BB\u02B4\u02BE\u02B5].text = \u02BA\u02BB\u02B6\u02B6\u02BF\u02B6\u02BA\u02B9\u02B9\u02BB\u02B7.GetIntString;
	}

	// Token: 0x04000781 RID: 1921
	[SerializeField]
	protected BaseMenu optionsMenu;

	// Token: 0x04000782 RID: 1922
	public BaseMenu \u02C1\u02B6\u02B7\u02BC\u02B3\u02BE\u02B3\u02C1\u02B4\u02B2\u02BC;

	// Token: 0x04000783 RID: 1923
	protected GameSetting \u02B7\u02B6\u02B7\u02B8\u02B7\u02B6\u02B5\u02BD\u02C1\u02B9\u02BC;

	// Token: 0x04000784 RID: 1924
	[HideInInspector]
	public bool \u02B6\u02BE\u02C0\u02BE\u02B3\u02B6\u02C1\u02BD\u02BA\u02C0\u02C1;

	// Token: 0x04000785 RID: 1925
	public Image \u02BB\u02C1\u02BD\u02BC\u02BE\u02BA\u02BA\u02B5\u02B9\u02BD\u02BA;

	// Token: 0x04000786 RID: 1926
	public TextMeshProUGUI[] \u02B7\u02BE\u02BA\u02B4\u02BB\u02B2\u02B6\u02BA\u02C0\u02B3\u02B9;

	// Token: 0x04000787 RID: 1927
	public Slider[] \u02B7\u02BA\u02B7\u02C0\u02B9\u02BA\u02B2\u02BF\u02B4\u02BC\u02B4;

	// Token: 0x04000788 RID: 1928
	public Image[] \u02B2\u02B6\u02BB\u02B7\u02BE\u02B4\u02B9\u02BF\u02C1\u02BE\u02B5;

	// Token: 0x04000789 RID: 1929
	public Slider[] \u02BA\u02B5\u02C1\u02B4\u02B4\u02BF\u02BE\u02C0\u02B9\u02B3\u02B5;

	// Token: 0x0400078A RID: 1930
	public TextMeshProUGUI[] \u02C0\u02B9\u02C0\u02B2\u02B5\u02BA\u02BD\u02BF\u02B2\u02B7\u02B3;

	// Token: 0x0400078B RID: 1931
	public Sprite \u02BD\u02BD\u02B6\u02C1\u02B6\u02BD\u02BA\u02B8\u02BE\u02BF\u02B9;

	// Token: 0x0400078C RID: 1932
	public Sprite \u02B4\u02BA\u02B4\u02B2\u02B9\u02BF\u02BB\u02BE\u02B2\u02B9\u02B9;

	// Token: 0x0400078D RID: 1933
	protected bool \u02BD\u02C0\u02B2\u02B2\u02BD\u02BD\u02C0\u02B7\u02B4\u02B3\u02C0;

	// Token: 0x0400078E RID: 1934
	private bool \u02B7\u02BE\u02BD\u02BF\u02B7\u02BE\u02B4\u02B4\u02BA\u02B9\u02C1;
}
