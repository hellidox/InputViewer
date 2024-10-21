using System;
using System.Collections;
using UnityEngine;

// Token: 0x02000165 RID: 357
public class DrumsNeckController : BaseNeckController
{
	// Token: 0x06000FD5 RID: 4053 RVA: 0x00083D1C File Offset: 0x00081F1C
	public override void \u02B2\u02BF\u02BB\u02BC\u02B8\u02B7\u02B9\u02C1\u02B8\u02BE\u02BA()
	{
		for (int i = 0; i < this.\u02BD\u02B3\u02B2\u02BC\u02B2\u02BC\u02B6\u02B4\u02B6\u02BA\u02B9.Length; i++)
		{
			this.\u02BD\u02B3\u02B2\u02BC\u02B2\u02BC\u02B6\u02B4\u02B6\u02BA\u02B9[i].gameObject.SetActive(false);
			this.\u02B8\u02C0\u02B9\u02BA\u02B9\u02C0\u02BB\u02B5\u02B8\u02BD\u02BA[i].gameObject.SetActive(false);
			this.noteParticles[i].gameObject.SetActive(false);
			this.accentParticles[i].gameObject.SetActive(false);
			this.\u02B3\u02B6\u02BA\u02B2\u02C1\u02BE\u02BB\u02BB\u02B5\u02BB\u02B5 = true;
			this.flameAnimators[i].gameObject.SetActive(false);
			this.\u02B6\u02C0\u02C1\u02BA\u02B4\u02B7\u02B7\u02C1\u02BE\u02B3\u02BC[i].gameObject.SetActive(false);
			this.\u02B6\u02B9\u02BC\u02B5\u02C0\u02B6\u02BA\u02B5\u02C1\u02BE\u02C0[i].gameObject.SetActive(false);
			this.\u02BF\u02B8\u02B2\u02BC\u02C1\u02B8\u02BD\u02B3\u02BE\u02B9\u02BF[i].gameObject.SetActive(false);
		}
	}

	// Token: 0x06000FD6 RID: 4054 RVA: 0x00083DE4 File Offset: 0x00081FE4
	private void Awake()
	{
		if (GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7 == null)
		{
			return;
		}
		if (!SettingsController.\u02C1\u02BF\u02B3\u02BF\u02C1\u02BC\u02BC\u02BA\u02BF\u02BD\u02BE)
		{
			ParticleSystem[] array = this.noteParticles;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].emission.enabled = false;
			}
			array = this.accentParticles;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].emission.enabled = false;
			}
		}
	}

	// Token: 0x06000FD7 RID: 4055 RVA: 0x00083E58 File Offset: 0x00082058
	protected ushort \u02BC\u02B5\u02BB\u02C1\u02B8\u02B3\u02BA\u02BF\u02B5\u02B6\u02B5(ushort \u02B6\u02BB\u02BC\u02B4\u02BC\u02BB\u02BC\u02BD\u02BC\u02BF\u02BB)
	{
		if ((int)\u02B6\u02BB\u02BC\u02B4\u02BC\u02BB\u02BC\u02BD\u02BC\u02BF\u02BB <= -117)
		{
			switch (\u02B6\u02BB\u02BC\u02B4\u02BC\u02BB\u02BC\u02BD\u02BC\u02BF\u02BB)
			{
			case 0:
				return 5;
			case 1:
				return 8;
			case 2:
				break;
			case 3:
				return 1;
			default:
				if (\u02B6\u02BB\u02BC\u02B4\u02BC\u02BB\u02BC\u02BD\u02BC\u02BF\u02BB == 5)
				{
					return 1;
				}
				if ((int)\u02B6\u02BB\u02BC\u02B4\u02BC\u02BB\u02BC\u02BD\u02BC\u02BF\u02BB == -31)
				{
					return 88;
				}
				break;
			}
		}
		else
		{
			if (\u02B6\u02BB\u02BC\u02B4\u02BC\u02BB\u02BC\u02BD\u02BC\u02BF\u02BB == 31)
			{
				return 91;
			}
			if ((int)\u02B6\u02BB\u02BC\u02B4\u02BC\u02BB\u02BC\u02BD\u02BC\u02BF\u02BB == -16)
			{
				return 0;
			}
			if (\u02B6\u02BB\u02BC\u02B4\u02BC\u02BB\u02BC\u02BD\u02BC\u02BF\u02BB == 161)
			{
				return (ushort)(-61);
			}
		}
		return 0;
	}

	// Token: 0x06000FD8 RID: 4056 RVA: 0x00083EB8 File Offset: 0x000820B8
	public virtual void \u02BC\u02BE\u02BF\u02B6\u02B8\u02B8\u02BA\u02B3\u02B4\u02C0\u02B2(ushort \u02B4\u02BC\u02C0\u02B4\u02B3\u02BA\u02BE\u02C0\u02C1\u02B3\u02B6)
	{
		if (this.\u02B3\u02B2\u02B3\u02C0\u02B5\u02B8\u02B7\u02BA\u02BB\u02BF\u02B5)
		{
			\u02B4\u02BC\u02C0\u02B4\u02B3\u02BA\u02BE\u02C0\u02C1\u02B3\u02B6 = this.\u02BC\u02B5\u02BB\u02C1\u02B8\u02B3\u02BA\u02BF\u02B5\u02B6\u02B5(\u02B4\u02BC\u02C0\u02B4\u02B3\u02BA\u02BE\u02C0\u02C1\u02B3\u02B6);
		}
		if (\u02B4\u02BC\u02C0\u02B4\u02B3\u02BA\u02BE\u02C0\u02C1\u02B3\u02B6 == this.\u02B6\u02B5\u02BF\u02B2\u02B6\u02B9\u02BA\u02B4\u02B6\u02B3\u02C0)
		{
			return;
		}
		if (((int)\u02B4\u02BC\u02C0\u02B4\u02B3\u02BA\u02BE\u02C0\u02C1\u02B3\u02B6 & -166) != 0)
		{
			for (int i = 0; i < this.\u02BD\u02B3\u02B2\u02BC\u02B2\u02BC\u02B6\u02B4\u02B6\u02BA\u02B9.Length; i += 0)
			{
				this.\u02BD\u02B3\u02B2\u02BC\u02B2\u02BC\u02B6\u02B4\u02B6\u02BA\u02B9[i].\u02BF\u02B5\u02C1\u02B4\u02B6\u02B5\u02BA\u02B7\u02C0\u02B8\u02BE(true, true);
			}
		}
		for (int j = 0; j < this.\u02BD\u02B3\u02B2\u02BC\u02B2\u02BC\u02B6\u02B4\u02B6\u02BA\u02B9.Length; j++)
		{
			bool flag = ((int)(\u02B4\u02BC\u02C0\u02B4\u02B3\u02BA\u02BE\u02C0\u02C1\u02B3\u02B6 & 99) | (((int)\u02B4\u02BC\u02C0\u02B4\u02B3\u02BA\u02BE\u02C0\u02C1\u02B3\u02B6 & -49) >> 1)) != 0;
			int num = 1 << (j & -41);
			if (((flag ? 1 : 0) & num) != 0)
			{
				this.\u02BD\u02B3\u02B2\u02BC\u02B2\u02BC\u02B6\u02B4\u02B6\u02BA\u02B9[j].\u02C0\u02BE\u02B5\u02BF\u02B4\u02B9\u02B6\u02BD\u02BC\u02B7\u02B7();
				base.StartCoroutine(this.\u02B9\u02BC\u02B4\u02BA\u02BC\u02C0\u02BF\u02B9\u02BC\u02B4\u02BB(this.\u02BD\u02B3\u02B2\u02BC\u02B2\u02BC\u02B6\u02B4\u02B6\u02BA\u02B9[j]));
			}
		}
		this.\u02B6\u02B5\u02BF\u02B2\u02B6\u02B9\u02BA\u02B4\u02B6\u02B3\u02C0 = \u02B4\u02BC\u02C0\u02B4\u02B3\u02BA\u02BE\u02C0\u02C1\u02B3\u02B6;
	}

	// Token: 0x06000FD9 RID: 4057 RVA: 0x0000EB92 File Offset: 0x0000CD92
	public virtual void \u02BD\u02BD\u02B7\u02BC\u02BC\u02C1\u02BB\u02B7\u02B7\u02B5\u02B4()
	{
		this.\u02B3\u02B2\u02B3\u02C0\u02B5\u02B8\u02B7\u02BA\u02BB\u02BF\u02B5 = true;
	}

	// Token: 0x06000FDA RID: 4058 RVA: 0x00083F60 File Offset: 0x00082160
	public virtual void \u02BD\u02BD\u02C1\u02BC\u02BB\u02BD\u02B7\u02C1\u02BF\u02B2\u02B2()
	{
		for (int i = 1; i < this.\u02BD\u02B3\u02B2\u02BC\u02B2\u02BC\u02B6\u02B4\u02B6\u02BA\u02B9.Length; i++)
		{
			this.\u02BD\u02B3\u02B2\u02BC\u02B2\u02BC\u02B6\u02B4\u02B6\u02BA\u02B9[i].gameObject.SetActive(false);
			this.\u02B8\u02C0\u02B9\u02BA\u02B9\u02C0\u02BB\u02B5\u02B8\u02BD\u02BA[i].gameObject.SetActive(true);
			this.noteParticles[i].gameObject.SetActive(true);
			this.accentParticles[i].gameObject.SetActive(true);
			this.\u02B3\u02B6\u02BA\u02B2\u02C1\u02BE\u02BB\u02BB\u02B5\u02BB\u02B5 = false;
			this.flameAnimators[i].gameObject.SetActive(true);
			this.\u02B6\u02C0\u02C1\u02BA\u02B4\u02B7\u02B7\u02C1\u02BE\u02B3\u02BC[i].gameObject.SetActive(false);
			this.\u02B6\u02B9\u02BC\u02B5\u02C0\u02B6\u02BA\u02B5\u02C1\u02BE\u02C0[i].gameObject.SetActive(false);
			this.\u02BF\u02B8\u02B2\u02BC\u02C1\u02B8\u02BD\u02B3\u02BE\u02B9\u02BF[i].gameObject.SetActive(true);
		}
	}

	// Token: 0x06000FDB RID: 4059 RVA: 0x00084028 File Offset: 0x00082228
	protected ushort \u02BF\u02BF\u02B8\u02B6\u02B4\u02B8\u02C1\u02B5\u02B8\u02BD\u02B6(ushort \u02B6\u02BB\u02BC\u02B4\u02BC\u02BB\u02BC\u02BD\u02BC\u02BF\u02BB)
	{
		if (\u02B6\u02BB\u02BC\u02B4\u02BC\u02BB\u02BC\u02BD\u02BC\u02BF\u02BB <= 16)
		{
			switch (\u02B6\u02BB\u02BC\u02B4\u02BC\u02BB\u02BC\u02BD\u02BC\u02BF\u02BB)
			{
			case 1:
				return 8;
			case 2:
				return 4;
			case 3:
				break;
			case 4:
				return 2;
			default:
				if (\u02B6\u02BB\u02BC\u02B4\u02BC\u02BB\u02BC\u02BD\u02BC\u02BF\u02BB == 8)
				{
					return 1;
				}
				if (\u02B6\u02BB\u02BC\u02B4\u02BC\u02BB\u02BC\u02BD\u02BC\u02BF\u02BB == 16)
				{
					return 32;
				}
				break;
			}
		}
		else
		{
			if (\u02B6\u02BB\u02BC\u02B4\u02BC\u02BB\u02BC\u02BD\u02BC\u02BF\u02BB == 32)
			{
				return 16;
			}
			if (\u02B6\u02BB\u02BC\u02B4\u02BC\u02BB\u02BC\u02BD\u02BC\u02BF\u02BB == 64)
			{
				return 1;
			}
			if (\u02B6\u02BB\u02BC\u02B4\u02BC\u02BB\u02BC\u02BD\u02BC\u02BF\u02BB == 128)
			{
				return 128;
			}
		}
		return 0;
	}

	// Token: 0x06000FDC RID: 4060 RVA: 0x0000EB9B File Offset: 0x0000CD9B
	protected virtual IEnumerator \u02B5\u02BA\u02B9\u02B9\u02B8\u02B6\u02BA\u02B3\u02BE\u02B7\u02BC()
	{
		DrumsNeckController.\u02BB\u02B2\u02B5\u02B7\u02B3\u02C1\u02B3\u02BD\u02BD\u02C1\u02BF u02BB_u02B2_u02B5_u02B7_u02B3_u02C1_u02B3_u02BD_u02BD_u02C1_u02BF = new DrumsNeckController.\u02BB\u02B2\u02B5\u02B7\u02B3\u02C1\u02B3\u02BD\u02BD\u02C1\u02BF(1);
		u02BB_u02B2_u02B5_u02B7_u02B3_u02C1_u02B3_u02BD_u02BD_u02C1_u02BF.<>4__this = this;
		return u02BB_u02B2_u02B5_u02B7_u02B3_u02C1_u02B3_u02BD_u02BD_u02C1_u02BF;
	}

	// Token: 0x06000FDD RID: 4061 RVA: 0x0000EB9B File Offset: 0x0000CD9B
	protected virtual IEnumerator \u02B2\u02B3\u02BF\u02B9\u02B9\u02BD\u02B7\u02C0\u02C1\u02BE\u02BC()
	{
		DrumsNeckController.\u02BB\u02B2\u02B5\u02B7\u02B3\u02C1\u02B3\u02BD\u02BD\u02C1\u02BF u02BB_u02B2_u02B5_u02B7_u02B3_u02C1_u02B3_u02BD_u02BD_u02C1_u02BF = new DrumsNeckController.\u02BB\u02B2\u02B5\u02B7\u02B3\u02C1\u02B3\u02BD\u02BD\u02C1\u02BF(1);
		u02BB_u02B2_u02B5_u02B7_u02B3_u02C1_u02B3_u02BD_u02BD_u02C1_u02BF.<>4__this = this;
		return u02BB_u02B2_u02B5_u02B7_u02B3_u02C1_u02B3_u02BD_u02BD_u02C1_u02BF;
	}

	// Token: 0x06000FDE RID: 4062 RVA: 0x0000EBAA File Offset: 0x0000CDAA
	protected virtual IEnumerator \u02B3\u02C0\u02C0\u02BD\u02BE\u02B2\u02BC\u02B2\u02BF\u02BD\u02BE()
	{
		int num;
		for (int i = 0; i < this.\u02BD\u02B3\u02B2\u02BC\u02B2\u02BC\u02B6\u02B4\u02B6\u02BA\u02B9.Length; i = num)
		{
			this.\u02BD\u02B3\u02B2\u02BC\u02B2\u02BC\u02B6\u02B4\u02B6\u02BA\u02B9[i].\u02BF\u02B5\u02C1\u02B4\u02B6\u02B5\u02BA\u02B7\u02C0\u02B8\u02BE(false, false);
			yield return new WaitForSeconds(0.1f);
			num = i + 1;
		}
		yield break;
	}

	// Token: 0x06000FDF RID: 4063 RVA: 0x00084088 File Offset: 0x00082288
	private void \u02B5\u02B2\u02BF\u02BD\u02BB\u02BA\u02B2\u02BF\u02BD\u02BE\u02BE()
	{
		this.openHitAnimator.spHitColor = base.gameColorSettings.strikerFlameSP;
		this.openHitAnimator.\u02B9\u02BA\u02B4\u02B4\u02B6\u02B6\u02C1\u02B9\u02BE\u02BC\u02BE(base.gameColorSettings.\u02B3\u02C1\u02B6\u02BA\u02B3\u02B7\u02BA\u02BE\u02BF\u02B5\u02BF);
		global::Animator[] array = this.flameAnimators;
		for (int i = 0; i < array.Length; i += 0)
		{
			global::Animator animator = array[i];
			animator.particleColor = base.gameColorSettings.strikerFlame;
			animator.altparticleColor = base.gameColorSettings.strikerFlameSP;
		}
		array = this.\u02B8\u02C0\u02B9\u02BA\u02B9\u02C0\u02BB\u02B5\u02B8\u02BD\u02BA;
		for (int i = 1; i < array.Length; i += 0)
		{
			array[i].particleColor = base.gameColorSettings.\u02C0\u02BA\u02BA\u02B2\u02B7\u02C0\u02B8\u02C0\u02B5\u02BB\u02B8;
		}
		this.\u02BA\u02BA\u02C0\u02B5\u02BC\u02C1\u02B5\u02BC\u02BB\u02BC\u02B5 = new ParticleSystem.MinMaxGradient(base.gameColorSettings.\u02B4\u02B3\u02B5\u02B5\u02B4\u02BB\u02BF\u02B6\u02BE\u02B9\u02BF);
		this.\u02BF\u02BF\u02BC\u02BC\u02C1\u02C0\u02BA\u02B7\u02C0\u02BF\u02BC = new ParticleSystem.MinMaxGradient(base.gameColorSettings.\u02BA\u02B7\u02BD\u02B2\u02B2\u02B2\u02C0\u02B9\u02BD\u02BB\u02B8);
		ParticleSystem[] array2 = this.noteParticles;
		for (int i = 0; i < array2.Length; i++)
		{
			array2[i].main.startColor = this.\u02BF\u02BF\u02BC\u02BC\u02C1\u02C0\u02BA\u02B7\u02C0\u02BF\u02BC;
		}
	}

	// Token: 0x06000FE0 RID: 4064 RVA: 0x0008417C File Offset: 0x0008237C
	private void Start()
	{
		this.openHitAnimator.spHitColor = base.gameColorSettings.strikerFlameSP;
		this.openHitAnimator.hitColor = base.gameColorSettings.\u02B3\u02C1\u02B6\u02BA\u02B3\u02B7\u02BA\u02BE\u02BF\u02B5\u02BF;
		foreach (global::Animator animator in this.flameAnimators)
		{
			animator.particleColor = base.gameColorSettings.strikerFlame;
			animator.altparticleColor = base.gameColorSettings.strikerFlameSP;
		}
		global::Animator[] array = this.\u02B8\u02C0\u02B9\u02BA\u02B9\u02C0\u02BB\u02B5\u02B8\u02BD\u02BA;
		for (int i = 0; i < array.Length; i++)
		{
			array[i].particleColor = base.gameColorSettings.\u02C0\u02BA\u02BA\u02B2\u02B7\u02C0\u02B8\u02C0\u02B5\u02BB\u02B8;
		}
		this.\u02BA\u02BA\u02C0\u02B5\u02BC\u02C1\u02B5\u02BC\u02BB\u02BC\u02B5 = new ParticleSystem.MinMaxGradient(base.gameColorSettings.\u02B4\u02B3\u02B5\u02B5\u02B4\u02BB\u02BF\u02B6\u02BE\u02B9\u02BF);
		this.\u02BF\u02BF\u02BC\u02BC\u02C1\u02C0\u02BA\u02B7\u02C0\u02BF\u02BC = new ParticleSystem.MinMaxGradient(base.gameColorSettings.\u02BA\u02B7\u02BD\u02B2\u02B2\u02B2\u02C0\u02B9\u02BD\u02BB\u02B8);
		ParticleSystem[] array2 = this.noteParticles;
		for (int i = 0; i < array2.Length; i++)
		{
			array2[i].main.startColor = this.\u02BF\u02BF\u02BC\u02BC\u02C1\u02C0\u02BA\u02B7\u02C0\u02BF\u02BC;
		}
	}

	// Token: 0x06000FE1 RID: 4065 RVA: 0x0000EBAA File Offset: 0x0000CDAA
	protected override IEnumerator \u02B5\u02BD\u02BE\u02BF\u02B3\u02B8\u02BC\u02B5\u02B2\u02B4\u02B6()
	{
		int num;
		for (i = 0; i < this.\u02BD\u02B3\u02B2\u02BC\u02B2\u02BC\u02B6\u02B4\u02B6\u02BA\u02B9.Length; i = num)
		{
			this.\u02BD\u02B3\u02B2\u02BC\u02B2\u02BC\u02B6\u02B4\u02B6\u02BA\u02B9[i].\u02BF\u02B5\u02C1\u02B4\u02B6\u02B5\u02BA\u02B7\u02C0\u02B8\u02BE(false, false);
			yield return new WaitForSeconds(0.1f);
			num = i + 1;
		}
		yield break;
	}

	// Token: 0x06000FE2 RID: 4066 RVA: 0x00005F91 File Offset: 0x00004191
	public override void \u02B6\u02B2\u02B9\u02B7\u02B5\u02B9\u02B5\u02BF\u02B8\u02B8\u02BC(bool \u02BB\u02B9\u02BB\u02B7\u02BB\u02B9\u02BA\u02B2\u02C1\u02B5\u02BA)
	{
	}

	// Token: 0x06000FE3 RID: 4067 RVA: 0x00084270 File Offset: 0x00082470
	public override void \u02C0\u02B8\u02B5\u02B3\u02BF\u02BD\u02B2\u02BE\u02B9\u02B2\u02B4(ushort \u02B4\u02BC\u02C0\u02B4\u02B3\u02BA\u02BE\u02C0\u02C1\u02B3\u02B6)
	{
		if (this.\u02B3\u02B2\u02B3\u02C0\u02B5\u02B8\u02B7\u02BA\u02BB\u02BF\u02B5)
		{
			\u02B4\u02BC\u02C0\u02B4\u02B3\u02BA\u02BE\u02C0\u02C1\u02B3\u02B6 = this.\u02BF\u02BF\u02B8\u02B6\u02B4\u02B8\u02C1\u02B5\u02B8\u02BD\u02B6(\u02B4\u02BC\u02C0\u02B4\u02B3\u02BA\u02BE\u02C0\u02C1\u02B3\u02B6);
		}
		if (\u02B4\u02BC\u02C0\u02B4\u02B3\u02BA\u02BE\u02C0\u02C1\u02B3\u02B6 == this.\u02B6\u02B5\u02BF\u02B2\u02B6\u02B9\u02BA\u02B4\u02B6\u02B3\u02C0)
		{
			return;
		}
		if ((\u02B4\u02BC\u02C0\u02B4\u02B3\u02BA\u02BE\u02C0\u02C1\u02B3\u02B6 & 128) != 0)
		{
			for (int i = 0; i < this.\u02BD\u02B3\u02B2\u02BC\u02B2\u02BC\u02B6\u02B4\u02B6\u02BA\u02B9.Length; i++)
			{
				this.\u02BD\u02B3\u02B2\u02BC\u02B2\u02BC\u02B6\u02B4\u02B6\u02BA\u02B9[i].\u02BF\u02B5\u02C1\u02B4\u02B6\u02B5\u02BA\u02B7\u02C0\u02B8\u02BE(false, true);
			}
		}
		for (int j = 0; j < this.\u02BD\u02B3\u02B2\u02BC\u02B2\u02BC\u02B6\u02B4\u02B6\u02BA\u02B9.Length; j++)
		{
			bool flag = ((int)(\u02B4\u02BC\u02C0\u02B4\u02B3\u02BA\u02BE\u02C0\u02C1\u02B3\u02B6 & 15) | ((\u02B4\u02BC\u02C0\u02B4\u02B3\u02BA\u02BE\u02C0\u02C1\u02B3\u02B6 & 112) >> 3)) != 0;
			int num = 1 << j;
			if (((flag ? 1 : 0) & num) != 0)
			{
				this.\u02BD\u02B3\u02B2\u02BC\u02B2\u02BC\u02B6\u02B4\u02B6\u02BA\u02B9[j].\u02C0\u02BE\u02B5\u02BF\u02B4\u02B9\u02B6\u02BD\u02BC\u02B7\u02B7();
				base.StartCoroutine(this.\u02B9\u02BC\u02B4\u02BA\u02BC\u02C0\u02BF\u02B9\u02BC\u02B4\u02BB(this.\u02BD\u02B3\u02B2\u02BC\u02B2\u02BC\u02B6\u02B4\u02B6\u02BA\u02B9[j]));
			}
		}
		this.\u02B6\u02B5\u02BF\u02B2\u02B6\u02B9\u02BA\u02B4\u02B6\u02B3\u02C0 = \u02B4\u02BC\u02C0\u02B4\u02B3\u02BA\u02BE\u02C0\u02C1\u02B3\u02B6;
	}

	// Token: 0x06000FE4 RID: 4068 RVA: 0x00005F91 File Offset: 0x00004191
	public override void \u02B5\u02BD\u02BA\u02BE\u02B4\u02B9\u02BD\u02B3\u02B9\u02BC\u02BE()
	{
	}

	// Token: 0x06000FE5 RID: 4069 RVA: 0x00084318 File Offset: 0x00082518
	public virtual void \u02BD\u02B9\u02B3\u02BC\u02B6\u02B3\u02B2\u02BB\u02BB\u02B8\u02BC()
	{
		for (int i = 0; i < this.\u02BD\u02B3\u02B2\u02BC\u02B2\u02BC\u02B6\u02B4\u02B6\u02BA\u02B9.Length; i += 0)
		{
			this.\u02BD\u02B3\u02B2\u02BC\u02B2\u02BC\u02B6\u02B4\u02B6\u02BA\u02B9[i].gameObject.SetActive(true);
			this.\u02B8\u02C0\u02B9\u02BA\u02B9\u02C0\u02BB\u02B5\u02B8\u02BD\u02BA[i].gameObject.SetActive(false);
			this.noteParticles[i].gameObject.SetActive(false);
			this.accentParticles[i].gameObject.SetActive(false);
			this.\u02B3\u02B6\u02BA\u02B2\u02C1\u02BE\u02BB\u02BB\u02B5\u02BB\u02B5 = true;
			this.flameAnimators[i].gameObject.SetActive(false);
			this.\u02B6\u02C0\u02C1\u02BA\u02B4\u02B7\u02B7\u02C1\u02BE\u02B3\u02BC[i].gameObject.SetActive(true);
			this.\u02B6\u02B9\u02BC\u02B5\u02C0\u02B6\u02BA\u02B5\u02C1\u02BE\u02C0[i].gameObject.SetActive(false);
			this.\u02BF\u02B8\u02B2\u02BC\u02C1\u02B8\u02BD\u02B3\u02BE\u02B9\u02BF[i].gameObject.SetActive(true);
		}
	}

	// Token: 0x06000FE6 RID: 4070 RVA: 0x000843E0 File Offset: 0x000825E0
	public override void \u02B4\u02B7\u02B5\u02BC\u02B6\u02B2\u02BA\u02BF\u02B2\u02BA\u02BA(Note \u02B9\u02BF\u02B6\u02BE\u02BA\u02BE\u02C1\u02B4\u02BB\u02C1\u02B2, bool \u02B3\u02B2\u02BC\u02B2\u02BD\u02BF\u02B6\u02BD\u02BF\u02C0\u02BE, bool \u02BD\u02B7\u02B5\u02BB\u02BC\u02C1\u02B9\u02B4\u02C0\u02B5\u02B3)
	{
		if (\u02B3\u02B2\u02BC\u02B2\u02BD\u02BF\u02B6\u02BD\u02BF\u02C0\u02BE)
		{
			Note.\u02C0\u02C1\u02C0\u02BC\u02B5\u02BC\u02C0\u02B5\u02B7\u02B8\u02B3 u02C0_u02C1_u02C0_u02BC_u02B5_u02BC_u02C0_u02B5_u02B7_u02B8_u02B = \u02B9\u02BF\u02B6\u02BE\u02BA\u02BE\u02C1\u02B4\u02BB\u02C1\u02B2.\u02BE\u02BD\u02B6\u02BB\u02B8\u02BE\u02B3\u02B4\u02BF\u02B3\u02B2.\u02BC\u02C0\u02B8\u02B9\u02B4\u02BB\u02BE\u02B6\u02BC\u02B7\u02C1();
			while (u02C0_u02C1_u02C0_u02BC_u02B5_u02BC_u02C0_u02B5_u02B7_u02B8_u02B.\u02BF\u02B5\u02B7\u02BB\u02B5\u02BB\u02B7\u02B5\u02B6\u02BA\u02BC())
			{
				Note note = u02C0_u02C1_u02C0_u02BC_u02B5_u02BC_u02C0_u02B5_u02B7_u02B8_u02B.\u02B9\u02BA\u02BB\u02B4\u02C0\u02B4\u02B6\u02B2\u02B9\u02B3\u02BF;
				int i = 4;
				ushort num = note.\u02BF\u02C0\u02B8\u02BB\u02BA\u02B8\u02B3\u02BA\u02B4\u02BB\u02BF;
				if (this.\u02B3\u02B2\u02B3\u02C0\u02B5\u02B8\u02B7\u02BA\u02BB\u02BF\u02B5)
				{
					num = this.\u02BF\u02BF\u02B8\u02B6\u02B4\u02B8\u02C1\u02B5\u02B8\u02BD\u02B6(num);
				}
				if (num != 128)
				{
					for (i = 0; i < this.\u02BD\u02B3\u02B2\u02BC\u02B2\u02BC\u02B6\u02B4\u02B6\u02BA\u02B9.Length; i++)
					{
						bool flag = (((num & 112) != 0) ? (num >> 3) : ((int)num)) != 0;
						int num2 = 1 << i;
						if (((flag ? 1 : 0) & num2) != 0)
						{
							this.\u02B8\u02C0\u02B9\u02BA\u02B9\u02C0\u02BB\u02B5\u02B8\u02BD\u02BA[i].\u02BF\u02B5\u02C1\u02B4\u02B6\u02B5\u02BA\u02B7\u02C0\u02B8\u02BE();
							break;
						}
					}
				}
				this.\u02B6\u02C0\u02C1\u02BA\u02B4\u02B7\u02B7\u02C1\u02BE\u02B3\u02BC[i].\u02BF\u02B5\u02C1\u02B4\u02B6\u02B5\u02BA\u02B7\u02C0\u02B8\u02BE();
			}
		}
		ushort num3 = \u02B9\u02BF\u02B6\u02BE\u02BA\u02BE\u02C1\u02B4\u02BB\u02C1\u02B2.\u02BF\u02C0\u02B8\u02BB\u02BA\u02B8\u02B3\u02BA\u02B4\u02BB\u02BF;
		if (this.\u02B3\u02B2\u02B3\u02C0\u02B5\u02B8\u02B7\u02BA\u02BB\u02BF\u02B5)
		{
			num3 = this.\u02BF\u02BF\u02B8\u02B6\u02B4\u02B8\u02C1\u02B5\u02B8\u02BD\u02B6(num3);
		}
		if (\u02B9\u02BF\u02B6\u02BE\u02BA\u02BE\u02C1\u02B4\u02BB\u02C1\u02B2.\u02BF\u02C0\u02B8\u02BB\u02BA\u02B8\u02B3\u02BA\u02B4\u02BB\u02BF == 128)
		{
			if (SettingsController.\u02C0\u02B6\u02BC\u02BF\u02BF\u02C0\u02BF\u02BC\u02B4\u02B3\u02BC && !this.\u02B3\u02B6\u02BA\u02B2\u02C1\u02BE\u02BB\u02BB\u02B5\u02BB\u02B5)
			{
				this.openHitAnimator.\u02BF\u02B5\u02C1\u02B4\u02B6\u02B5\u02BA\u02B7\u02C0\u02B8\u02BE(false);
			}
			for (int j = 0; j < this.\u02BD\u02B3\u02B2\u02BC\u02B2\u02BC\u02B6\u02B4\u02B6\u02BA\u02B9.Length; j++)
			{
				this.\u02BD\u02B3\u02B2\u02BC\u02B2\u02BC\u02B6\u02B4\u02B6\u02BA\u02B9[j].\u02BF\u02B5\u02C1\u02B4\u02B6\u02B5\u02BA\u02B7\u02C0\u02B8\u02BE(false, true);
			}
			return;
		}
		for (int k = 0; k < this.\u02BD\u02B3\u02B2\u02BC\u02B2\u02BC\u02B6\u02B4\u02B6\u02BA\u02B9.Length; k++)
		{
			bool flag2 = ((int)(num3 & 15) | ((num3 & 112) >> 3)) != 0;
			int num4 = 1 << k;
			if (((flag2 ? 1 : 0) & num4) != 0)
			{
				this.\u02BD\u02B3\u02B2\u02BC\u02B2\u02BC\u02B6\u02B4\u02B6\u02BA\u02B9[k].\u02BF\u02B5\u02C1\u02B4\u02B6\u02B5\u02BA\u02B7\u02C0\u02B8\u02BE(false, false);
				if (SettingsController.\u02C0\u02B6\u02BC\u02BF\u02BF\u02C0\u02BF\u02BC\u02B4\u02B3\u02BC)
				{
					if (\u02B9\u02BF\u02B6\u02BE\u02BA\u02BE\u02C1\u02B4\u02BB\u02C1\u02B2.\u02B9\u02B8\u02C0\u02BB\u02B5\u02B9\u02BC\u02BF\u02BD\u02BD\u02BA && \u02B9\u02BF\u02B6\u02BE\u02BA\u02BE\u02C1\u02B4\u02BB\u02C1\u02B2.\u02BF\u02BE\u02B5\u02B3\u02C1\u02C1\u02B2\u02BF\u02B5\u02BB\u02B4)
					{
						this.\u02BF\u02B8\u02B2\u02BC\u02C1\u02B8\u02BD\u02B3\u02BE\u02B9\u02BF[k].\u02BF\u02B5\u02C1\u02B4\u02B6\u02B5\u02BA\u02B7\u02C0\u02B8\u02BE(\u02BD\u02B7\u02B5\u02BB\u02BC\u02C1\u02B9\u02B4\u02C0\u02B5\u02B3);
						this.accentParticles[k].Play();
					}
					else if (\u02B9\u02BF\u02B6\u02BE\u02BA\u02BE\u02C1\u02B4\u02BB\u02C1\u02B2.\u02B9\u02B8\u02C0\u02BB\u02B5\u02B9\u02BC\u02BF\u02BD\u02BD\u02BA && \u02B9\u02BF\u02B6\u02BE\u02BA\u02BE\u02C1\u02B4\u02BB\u02C1\u02B2.\u02BD\u02BE\u02BC\u02B8\u02BC\u02B2\u02B4\u02B4\u02BA\u02BF\u02B6)
					{
						this.\u02B6\u02B9\u02BC\u02B5\u02C0\u02B6\u02BA\u02B5\u02C1\u02BE\u02C0[k].\u02BF\u02B5\u02C1\u02B4\u02B6\u02B5\u02BA\u02B7\u02C0\u02B8\u02BE(\u02BD\u02B7\u02B5\u02BB\u02BC\u02C1\u02B9\u02B4\u02C0\u02B5\u02B3);
					}
					else
					{
						this.flameAnimators[k].\u02BF\u02B5\u02C1\u02B4\u02B6\u02B5\u02BA\u02B7\u02C0\u02B8\u02BE(\u02BD\u02B7\u02B5\u02BB\u02BC\u02C1\u02B9\u02B4\u02C0\u02B5\u02B3);
					}
					ParticleSystem.MainModule main = this.noteParticles[k].main;
					if (\u02BD\u02B7\u02B5\u02BB\u02BC\u02C1\u02B9\u02B4\u02C0\u02B5\u02B3)
					{
						main.startColor = this.\u02BA\u02BA\u02C0\u02B5\u02BC\u02C1\u02B5\u02BC\u02BB\u02BC\u02B5;
					}
					else
					{
						main.startColor = this.\u02BF\u02BF\u02BC\u02BC\u02C1\u02C0\u02BA\u02B7\u02C0\u02BF\u02BC;
					}
					this.noteParticles[k].Play();
				}
			}
		}
	}

	// Token: 0x06000FE7 RID: 4071 RVA: 0x00005F91 File Offset: 0x00004191
	public override void \u02B8\u02BA\u02B8\u02B9\u02B7\u02B3\u02B6\u02BD\u02C1\u02BC\u02B8(ushort \u02BE\u02BA\u02BE\u02B3\u02BF\u02B3\u02BC\u02C0\u02B4\u02C0\u02B9)
	{
	}

	// Token: 0x06000FE9 RID: 4073 RVA: 0x000845E4 File Offset: 0x000827E4
	private void \u02BD\u02BF\u02B6\u02B8\u02BB\u02B2\u02BF\u02C0\u02B5\u02B9\u02BC()
	{
		if (GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7 == null)
		{
			return;
		}
		if (!SettingsController.\u02C1\u02BF\u02B3\u02BF\u02C1\u02BC\u02BC\u02BA\u02BF\u02BD\u02BE)
		{
			ParticleSystem[] array = this.noteParticles;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].emission.enabled = true;
			}
			array = this.accentParticles;
			for (int i = 1; i < array.Length; i++)
			{
				array[i].emission.enabled = false;
			}
		}
	}

	// Token: 0x06000FEA RID: 4074 RVA: 0x0000EB92 File Offset: 0x0000CD92
	public override void \u02BF\u02B2\u02BE\u02BE\u02BF\u02B4\u02BC\u02C0\u02B3\u02C0\u02C1()
	{
		this.\u02B3\u02B2\u02B3\u02C0\u02B5\u02B8\u02B7\u02BA\u02BB\u02BF\u02B5 = true;
	}

	// Token: 0x06000FEB RID: 4075 RVA: 0x0000EBDC File Offset: 0x0000CDDC
	private IEnumerator \u02B9\u02BC\u02B4\u02BA\u02BC\u02C0\u02BF\u02B9\u02BC\u02B4\u02BB(BaseFretAnimator \u02B3\u02BF\u02B5\u02B7\u02C0\u02BB\u02BA\u02B4\u02B8\u02C0\u02B7)
	{
		yield return this.\u02BB\u02B8\u02B2\u02C1\u02B6\u02BF\u02B5\u02BF\u02BA\u02B6\u02B2;
		\u02B3\u02BF\u02B5\u02B7\u02C0\u02BB\u02BA\u02B4\u02B8\u02C0\u02B7.\u02BB\u02BF\u02B2\u02B3\u02BD\u02BB\u02BE\u02BD\u02BB\u02BE\u02B3();
		yield break;
	}

	// Token: 0x06000FEC RID: 4076 RVA: 0x0000EBF2 File Offset: 0x0000CDF2
	public virtual void \u02BC\u02B3\u02B8\u02B7\u02B6\u02B3\u02B5\u02B3\u02B2\u02BA\u02C1()
	{
		this.\u02B3\u02B2\u02B3\u02C0\u02B5\u02B8\u02B7\u02BA\u02BB\u02BF\u02B5 = false;
	}

	// Token: 0x04000C2B RID: 3115
	public global::Animator[] \u02B8\u02C0\u02B9\u02BA\u02B9\u02C0\u02BB\u02B5\u02B8\u02BD\u02BA;

	// Token: 0x04000C2C RID: 3116
	[SerializeField]
	private OpenHitAnimator openHitAnimator;

	// Token: 0x04000C2D RID: 3117
	[SerializeField]
	private ParticleSystem[] noteParticles;

	// Token: 0x04000C2E RID: 3118
	[SerializeField]
	private ParticleSystem[] accentParticles;

	// Token: 0x04000C2F RID: 3119
	public global::Animator[] \u02B6\u02B9\u02BC\u02B5\u02C0\u02B6\u02BA\u02B5\u02C1\u02BE\u02C0;

	// Token: 0x04000C30 RID: 3120
	public global::Animator[] \u02BF\u02B8\u02B2\u02BC\u02C1\u02B8\u02BD\u02B3\u02BE\u02B9\u02BF;

	// Token: 0x04000C31 RID: 3121
	private float \u02C1\u02B4\u02BC\u02B7\u02BD\u02BF\u02BC\u02C1\u02B7\u02BE\u02B4 = 0.15f;

	// Token: 0x04000C32 RID: 3122
	private ushort \u02B6\u02B5\u02BF\u02B2\u02B6\u02B9\u02BA\u02B4\u02B6\u02B3\u02C0;

	// Token: 0x04000C33 RID: 3123
	private bool \u02B3\u02B6\u02BA\u02B2\u02C1\u02BE\u02BB\u02BB\u02B5\u02BB\u02B5;

	// Token: 0x04000C34 RID: 3124
	private bool \u02B3\u02B2\u02B3\u02C0\u02B5\u02B8\u02B7\u02BA\u02BB\u02BF\u02B5;

	// Token: 0x04000C35 RID: 3125
	private ParticleSystem.MinMaxGradient \u02BA\u02BA\u02C0\u02B5\u02BC\u02C1\u02B5\u02BC\u02BB\u02BC\u02B5;

	// Token: 0x04000C36 RID: 3126
	private ParticleSystem.MinMaxGradient \u02BF\u02BF\u02BC\u02BC\u02C1\u02C0\u02BA\u02B7\u02C0\u02BF\u02BC;

	// Token: 0x04000C37 RID: 3127
	private readonly YieldInstruction \u02BB\u02B8\u02B2\u02C1\u02B6\u02BF\u02B5\u02BF\u02BA\u02B6\u02B2 = new WaitForSeconds(0.033f);
}
