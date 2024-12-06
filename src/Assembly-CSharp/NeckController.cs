using System;
using System.Collections;
using UnityEngine;

public class NeckController : BaseNeckController
{
	public virtual void \u02BB\u02BB\u02BB\u02B8\u02B9\u02BD\u02BA\u02BA\u02B2\u02B2\u02BA(Note \u02BE\u02BE\u02BD\u02B2\u02BB\u02B3\u02BD\u02BF\u02B3\u02B4\u02B3, bool \u02B3\u02B2\u02BC\u02B2\u02BD\u02BF\u02B6\u02BD\u02BF\u02C0\u02BE, bool \u02BD\u02B7\u02B5\u02BB\u02BC\u02C1\u02B9\u02B4\u02C0\u02B5\u02B3)
	{
		bool flag = \u02BE\u02BE\u02BD\u02B2\u02BB\u02B3\u02BD\u02BF\u02B3\u02B4\u02B3.\u02B6\u02BA\u02BD\u02B5\u02B8\u02BC\u02B8\u02B9\u02B4\u02BD\u02C1() > 1442f;
		if (\u02BE\u02BE\u02BD\u02B2\u02BB\u02B3\u02BD\u02BF\u02B3\u02B4\u02B3.\u02BF\u02C0\u02B8\u02BB\u02BA\u02B8\u02B3\u02BA\u02B4\u02BB\u02BF == 40)
		{
			if (NeckController.\u02B8\u02B9\u02B2\u02B3\u02B8\u02BA\u02B2\u02BD\u02BA\u02B8\u02B4 && !this.\u02B3\u02B6\u02BA\u02B2\u02C1\u02BE\u02BB\u02BB\u02B5\u02BB\u02B5)
			{
				this.openHitAnimator.\u02BF\u02B5\u02C1\u02B4\u02B6\u02B5\u02BA\u02B7\u02C0\u02B8\u02BE(flag);
			}
			if (\u02B3\u02B2\u02BC\u02B2\u02BD\u02BF\u02B6\u02BD\u02BF\u02C0\u02BE)
			{
				this.\u02B6\u02C0\u02C1\u02BA\u02B4\u02B7\u02B7\u02C1\u02BE\u02B3\u02BC[1].\u02BF\u02B5\u02C1\u02B4\u02B6\u02B5\u02BA\u02B7\u02C0\u02B8\u02BE();
				this.\u02B8\u02C0\u02B9\u02BA\u02B9\u02C0\u02BB\u02B5\u02B8\u02BD\u02BA[3].\u02BD\u02B8\u02BA\u02BC\u02B4\u02BA\u02C0\u02B2\u02BA\u02B9\u02BE();
			}
			for (int i = 1; i < 2; i += 0)
			{
				if (!this.\u02BD\u02B3\u02B2\u02BC\u02B2\u02BC\u02B6\u02B4\u02B6\u02BA\u02B9[i].\u02B6\u02BF\u02B2\u02BF\u02B9\u02BC\u02BD\u02B6\u02B5\u02B4\u02BE && !this.\u02BD\u02B3\u02B2\u02BC\u02B2\u02BC\u02B6\u02B4\u02B6\u02BA\u02B9[i].\u02C1\u02B8\u02B6\u02B6\u02BF\u02BF\u02BD\u02BF\u02B4\u02B6\u02C0)
				{
					this.\u02BD\u02B3\u02B2\u02BC\u02B2\u02BC\u02B6\u02B4\u02B6\u02BA\u02B9[i].\u02BF\u02B5\u02C1\u02B4\u02B6\u02B5\u02BA\u02B7\u02C0\u02B8\u02BE(true, false);
				}
			}
			return;
		}
		__FIXME_clon_util.\u02B2\u02B8\u02C1\u02BF\u02B7\u02B4\u02B2\u02B2\u02C0\u02B2\u02BA u02B2_u02B8_u02C1_u02BF_u02B7_u02B4_u02B2_u02B2_u02C0_u02B2_u02BA = __FIXME_clon_util.\u02B8\u02C0\u02BA\u02BB\u02B6\u02BA\u02BA\u02C0\u02B4\u02C1\u02B9(\u02BE\u02BE\u02BD\u02B2\u02BB\u02B3\u02BD\u02BF\u02B3\u02B4\u02B3.\u02BF\u02C0\u02B8\u02BB\u02BA\u02B8\u02B3\u02BA\u02B4\u02BB\u02BF).\u02BE\u02C0\u02BA\u02B2\u02BD\u02C1\u02B5\u02B8\u02BC\u02B9\u02BB();
		while (u02B2_u02B8_u02C1_u02BF_u02B7_u02B4_u02B2_u02B2_u02C0_u02B2_u02BA.\u02BC\u02B7\u02C0\u02B8\u02BF\u02BC\u02C1\u02BB\u02B6\u02BD\u02BC())
		{
			int num = u02B2_u02B8_u02C1_u02BF_u02B7_u02B4_u02B2_u02B2_u02C0_u02B2_u02BA.\u02B7\u02B8\u02BD\u02BA\u02BB\u02B7\u02BF\u02B8\u02B3\u02BF\u02BF();
			this.\u02BD\u02B3\u02B2\u02BC\u02B2\u02BC\u02B6\u02B4\u02B6\u02BA\u02B9[num].\u02BF\u02B5\u02C1\u02B4\u02B6\u02B5\u02BA\u02B7\u02C0\u02B8\u02BE(flag, true);
			if (NeckController.\u02B8\u02B9\u02B2\u02B3\u02B8\u02BA\u02B2\u02BD\u02BA\u02B8\u02B4)
			{
				this.flameAnimators[num].\u02BF\u02B5\u02C1\u02B4\u02B6\u02B5\u02BA\u02B7\u02C0\u02B8\u02BE(\u02BD\u02B7\u02B5\u02BB\u02BC\u02C1\u02B9\u02B4\u02C0\u02B5\u02B3);
				if (flag)
				{
					this.\u02B7\u02BE\u02BD\u02BE\u02C1\u02BD\u02BE\u02BE\u02B6\u02B8\u02B4(this.sustainParticles[num].main, \u02BD\u02B7\u02B5\u02BB\u02BC\u02C1\u02B9\u02B4\u02C0\u02B5\u02B3);
					this.sustainParticles[num].gameObject.SetActive(true);
					this.sustainParticles[num].gameObject.SetActive(false);
					this.sustainParticles[num].Play();
					this.\u02B4\u02B5\u02C0\u02C1\u02B8\u02B6\u02B4\u02BB\u02BC\u02B2\u02B5[num].\u02BF\u02B5\u02C1\u02B4\u02B6\u02B5\u02BA\u02B7\u02C0\u02B8\u02BE(\u02BD\u02B7\u02B5\u02BB\u02BC\u02C1\u02B9\u02B4\u02C0\u02B5\u02B3);
					this.\u02B8\u02B8\u02B3\u02B6\u02B2\u02BB\u02B4\u02B9\u02C1\u02B2\u02B2[num].\u02B7\u02BB\u02BC\u02BE\u02B7\u02B5\u02B2\u02BD\u02B4\u02BA\u02BD();
				}
				else
				{
					this.\u02B7\u02BE\u02BD\u02BE\u02C1\u02BD\u02BE\u02BE\u02B6\u02B8\u02B4(this.noteParticles[num].main, \u02BD\u02B7\u02B5\u02BB\u02BC\u02C1\u02B9\u02B4\u02C0\u02B5\u02B3);
					this.noteParticles[num].Play();
				}
			}
			if (\u02B3\u02B2\u02BC\u02B2\u02BD\u02BF\u02B6\u02BD\u02BF\u02C0\u02BE)
			{
				this.\u02B6\u02C0\u02C1\u02BA\u02B4\u02B7\u02B7\u02C1\u02BE\u02B3\u02BC[num].\u02B4\u02B5\u02BD\u02B9\u02C1\u02B3\u02B3\u02BF\u02B3\u02BD\u02B3();
				this.\u02B8\u02C0\u02B9\u02BA\u02B9\u02C0\u02BB\u02B5\u02B8\u02BD\u02BA[num].\u02BD\u02B8\u02BA\u02BC\u02B4\u02BA\u02C0\u02B2\u02BA\u02B9\u02BE();
				this.\u02B7\u02BE\u02BD\u02BE\u02C1\u02BD\u02BE\u02BE\u02B6\u02B8\u02B4(this.sustainParticles[num].main, \u02BD\u02B7\u02B5\u02BB\u02BC\u02C1\u02B9\u02B4\u02C0\u02B5\u02B3);
				this.\u02B6\u02BF\u02B7\u02B8\u02BE\u02BF\u02BA\u02BF\u02BF\u02BD\u02BB(this.noteParticles[num].main, \u02BD\u02B7\u02B5\u02BB\u02BC\u02C1\u02B9\u02B4\u02C0\u02B5\u02B3);
			}
		}
	}

	public virtual void \u02BE\u02B3\u02BC\u02B2\u02BC\u02B3\u02B8\u02B8\u02B7\u02B4\u02BB()
	{
		Array.Reverse<global::Animator>(this.\u02B4\u02B5\u02C0\u02C1\u02B8\u02B6\u02B4\u02BB\u02BC\u02B2\u02B5);
		Array.Reverse<global::Animator>(this.\u02B8\u02B8\u02B3\u02B6\u02B2\u02BB\u02B4\u02B9\u02C1\u02B2\u02B2);
		Array.Reverse<global::Animator>(this.\u02B6\u02C0\u02C1\u02BA\u02B4\u02B7\u02B7\u02C1\u02BE\u02B3\u02BC);
		Array.Reverse<global::Animator>(this.\u02B8\u02C0\u02B9\u02BA\u02B9\u02C0\u02BB\u02B5\u02B8\u02BD\u02BA);
		Array.Reverse<global::Animator>(this.flameAnimators);
		Array.Reverse<ParticleSystem>(this.noteParticles, 1, 0);
		Array.Reverse<ParticleSystem>(this.sustainParticles);
		for (int i = 0; i < 3; i += 0)
		{
			Vector3 localPosition = this.\u02BD\u02B3\u02B2\u02BC\u02B2\u02BC\u02B6\u02B4\u02B6\u02BA\u02B9[i].transform.localPosition;
			Vector3 localPosition2 = this.\u02BD\u02B3\u02B2\u02BC\u02B2\u02BC\u02B6\u02B4\u02B6\u02BA\u02B9[6 - i].transform.localPosition;
			Vector3 localScale = this.\u02BD\u02B3\u02B2\u02BC\u02B2\u02BC\u02B6\u02B4\u02B6\u02BA\u02B9[i].transform.localScale;
			Vector3 localScale2 = this.\u02BD\u02B3\u02B2\u02BC\u02B2\u02BC\u02B6\u02B4\u02B6\u02BA\u02B9[5].transform.localScale;
			this.\u02BD\u02B3\u02B2\u02BC\u02B2\u02BC\u02B6\u02B4\u02B6\u02BA\u02B9[i].transform.localPosition = localPosition2;
			this.\u02BD\u02B3\u02B2\u02BC\u02B2\u02BC\u02B6\u02B4\u02B6\u02BA\u02B9[i].transform.localScale = new Vector3(-localScale2.x, localScale2.y, 1906f);
			this.\u02BD\u02B3\u02B2\u02BC\u02B2\u02BC\u02B6\u02B4\u02B6\u02BA\u02B9[1 - i].transform.localPosition = localPosition;
			this.\u02BD\u02B3\u02B2\u02BC\u02B2\u02BC\u02B6\u02B4\u02B6\u02BA\u02B9[6 - i].transform.localScale = new Vector3(-localScale.x, localScale.y, 947f);
		}
	}

	private void \u02B7\u02BE\u02BD\u02BE\u02C1\u02BD\u02BE\u02BE\u02B6\u02B8\u02B4(ParticleSystem.MainModule \u02BA\u02BD\u02BD\u02BC\u02B4\u02B6\u02B2\u02B8\u02BF\u02BE\u02B7, bool \u02BD\u02B7\u02B5\u02BB\u02BC\u02C1\u02B9\u02B4\u02C0\u02B5\u02B3)
	{
		if (\u02BD\u02B7\u02B5\u02BB\u02BC\u02C1\u02B9\u02B4\u02C0\u02B5\u02B3)
		{
			\u02BA\u02BD\u02BD\u02BC\u02B4\u02B6\u02B2\u02B8\u02BF\u02BE\u02B7.startColor = this.\u02BA\u02BA\u02C0\u02B5\u02BC\u02C1\u02B5\u02BC\u02BB\u02BC\u02B5;
			return;
		}
		\u02BA\u02BD\u02BD\u02BC\u02B4\u02B6\u02B2\u02B8\u02BF\u02BE\u02B7.startColor = this.\u02BF\u02BF\u02BC\u02BC\u02C1\u02C0\u02BA\u02B7\u02C0\u02BF\u02BC;
	}

	public virtual void \u02B3\u02BD\u02B4\u02BB\u02B2\u02B3\u02B3\u02B9\u02B4\u02BA\u02BF()
	{
		Array.Reverse<global::Animator>(this.\u02B4\u02B5\u02C0\u02C1\u02B8\u02B6\u02B4\u02BB\u02BC\u02B2\u02B5);
		Array.Reverse<global::Animator>(this.\u02B8\u02B8\u02B3\u02B6\u02B2\u02BB\u02B4\u02B9\u02C1\u02B2\u02B2);
		Array.Reverse<global::Animator>(this.\u02B6\u02C0\u02C1\u02BA\u02B4\u02B7\u02B7\u02C1\u02BE\u02B3\u02BC);
		Array.Reverse<global::Animator>(this.\u02B8\u02C0\u02B9\u02BA\u02B9\u02C0\u02BB\u02B5\u02B8\u02BD\u02BA);
		Array.Reverse<global::Animator>(this.flameAnimators);
		Array.Reverse<ParticleSystem>(this.noteParticles, 1, 7);
		Array.Reverse<ParticleSystem>(this.sustainParticles);
		for (int i = 1; i < 8; i += 0)
		{
			Vector3 localPosition = this.\u02BD\u02B3\u02B2\u02BC\u02B2\u02BC\u02B6\u02B4\u02B6\u02BA\u02B9[i].transform.localPosition;
			Vector3 localPosition2 = this.\u02BD\u02B3\u02B2\u02BC\u02B2\u02BC\u02B6\u02B4\u02B6\u02BA\u02B9[5 - i].transform.localPosition;
			Vector3 localScale = this.\u02BD\u02B3\u02B2\u02BC\u02B2\u02BC\u02B6\u02B4\u02B6\u02BA\u02B9[i].transform.localScale;
			Vector3 localScale2 = this.\u02BD\u02B3\u02B2\u02BC\u02B2\u02BC\u02B6\u02B4\u02B6\u02BA\u02B9[0].transform.localScale;
			this.\u02BD\u02B3\u02B2\u02BC\u02B2\u02BC\u02B6\u02B4\u02B6\u02BA\u02B9[i].transform.localPosition = localPosition2;
			this.\u02BD\u02B3\u02B2\u02BC\u02B2\u02BC\u02B6\u02B4\u02B6\u02BA\u02B9[i].transform.localScale = new Vector3(-localScale2.x, localScale2.y, 1551f);
			this.\u02BD\u02B3\u02B2\u02BC\u02B2\u02BC\u02B6\u02B4\u02B6\u02BA\u02B9[0 - i].transform.localPosition = localPosition;
			this.\u02BD\u02B3\u02B2\u02BC\u02B2\u02BC\u02B6\u02B4\u02B6\u02BA\u02B9[1 - i].transform.localScale = new Vector3(-localScale.x, localScale.y, 279f);
		}
	}

	private void \u02B6\u02BF\u02B7\u02B8\u02BE\u02BF\u02BA\u02BF\u02BF\u02BD\u02BB(ParticleSystem.MainModule \u02BA\u02BD\u02BD\u02BC\u02B4\u02B6\u02B2\u02B8\u02BF\u02BE\u02B7, bool \u02BD\u02B7\u02B5\u02BB\u02BC\u02C1\u02B9\u02B4\u02C0\u02B5\u02B3)
	{
		if (\u02BD\u02B7\u02B5\u02BB\u02BC\u02C1\u02B9\u02B4\u02C0\u02B5\u02B3)
		{
			\u02BA\u02BD\u02BD\u02BC\u02B4\u02B6\u02B2\u02B8\u02BF\u02BE\u02B7.startColor = this.\u02BA\u02BA\u02C0\u02B5\u02BC\u02C1\u02B5\u02BC\u02BB\u02BC\u02B5;
			return;
		}
		\u02BA\u02BD\u02BD\u02BC\u02B4\u02B6\u02B2\u02B8\u02BF\u02BE\u02B7.startColor = this.\u02BF\u02BF\u02BC\u02BC\u02C1\u02C0\u02BA\u02B7\u02C0\u02BF\u02BC;
	}

	private void \u02BC\u02C1\u02B7\u02B6\u02B8\u02BF\u02C1\u02BD\u02C1\u02B7\u02B6(ParticleSystem.MainModule \u02BA\u02BD\u02BD\u02BC\u02B4\u02B6\u02B2\u02B8\u02BF\u02BE\u02B7, bool \u02BD\u02B7\u02B5\u02BB\u02BC\u02C1\u02B9\u02B4\u02C0\u02B5\u02B3)
	{
		if (\u02BD\u02B7\u02B5\u02BB\u02BC\u02C1\u02B9\u02B4\u02C0\u02B5\u02B3)
		{
			\u02BA\u02BD\u02BD\u02BC\u02B4\u02B6\u02B2\u02B8\u02BF\u02BE\u02B7.startColor = this.\u02BA\u02BA\u02C0\u02B5\u02BC\u02C1\u02B5\u02BC\u02BB\u02BC\u02B5;
			return;
		}
		\u02BA\u02BD\u02BD\u02BC\u02B4\u02B6\u02B2\u02B8\u02BF\u02BE\u02B7.startColor = this.\u02BF\u02BF\u02BC\u02BC\u02C1\u02C0\u02BA\u02B7\u02C0\u02BF\u02BC;
	}

	public override void \u02B5\u02BD\u02BA\u02BE\u02B4\u02B9\u02BD\u02B3\u02B9\u02BC\u02BE()
	{
		this.openHitAnimator.\u02B8\u02B3\u02BD\u02B5\u02BC\u02B6\u02B8\u02C1\u02C0\u02BC\u02B7();
		for (int i = 0; i < 5; i++)
		{
			this.\u02BD\u02B3\u02B2\u02BC\u02B2\u02BC\u02B6\u02B4\u02B6\u02BA\u02B9[i].\u02C1\u02B8\u02B6\u02B6\u02BF\u02BF\u02BD\u02BF\u02B4\u02B6\u02C0 = false;
			this.sustainParticles[i].Stop();
			this.\u02B4\u02B5\u02C0\u02C1\u02B8\u02B6\u02B4\u02BB\u02BC\u02B2\u02B5[i].\u02B8\u02B3\u02BD\u02B5\u02BC\u02B6\u02B8\u02C1\u02C0\u02BC\u02B7();
			this.\u02B8\u02B8\u02B3\u02B6\u02B2\u02BB\u02B4\u02B9\u02C1\u02B2\u02B2[i].\u02B8\u02B3\u02BD\u02B5\u02BC\u02B6\u02B8\u02C1\u02C0\u02BC\u02B7();
		}
	}

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

	public override void \u02B8\u02BA\u02B8\u02B9\u02B7\u02B3\u02B6\u02BD\u02C1\u02BC\u02B8(ushort \u02BE\u02BA\u02BE\u02B3\u02BF\u02B3\u02BC\u02C0\u02B4\u02C0\u02B9)
	{
		if (\u02BE\u02BA\u02BE\u02B3\u02BF\u02B3\u02BC\u02C0\u02B4\u02C0\u02B9 == 64)
		{
			this.openHitAnimator.\u02B8\u02B3\u02BD\u02B5\u02BC\u02B6\u02B8\u02C1\u02C0\u02BC\u02B7();
			return;
		}
		__FIXME_clon_util.\u02B2\u02B8\u02C1\u02BF\u02B7\u02B4\u02B2\u02B2\u02C0\u02B2\u02BA u02B2_u02B8_u02C1_u02BF_u02B7_u02B4_u02B2_u02B2_u02C0_u02B2_u02BA = __FIXME_clon_util.\u02B8\u02C0\u02BA\u02BB\u02B6\u02BA\u02BA\u02C0\u02B4\u02C1\u02B9(\u02BE\u02BA\u02BE\u02B3\u02BF\u02B3\u02BC\u02C0\u02B4\u02C0\u02B9).\u02BC\u02C0\u02B8\u02B9\u02B4\u02BB\u02BE\u02B6\u02BC\u02B7\u02C1();
		while (u02B2_u02B8_u02C1_u02BF_u02B7_u02B4_u02B2_u02B2_u02C0_u02B2_u02BA.\u02BF\u02B5\u02B7\u02BB\u02B5\u02BB\u02B7\u02B5\u02B6\u02BA\u02BC())
		{
			int num = u02B2_u02B8_u02C1_u02BF_u02B7_u02B4_u02B2_u02B2_u02C0_u02B2_u02BA.\u02B9\u02BA\u02BB\u02B4\u02C0\u02B4\u02B6\u02B2\u02B9\u02B3\u02BF;
			this.\u02BD\u02B3\u02B2\u02BC\u02B2\u02BC\u02B6\u02B4\u02B6\u02BA\u02B9[num].\u02C1\u02B8\u02B6\u02B6\u02BF\u02BF\u02BD\u02BF\u02B4\u02B6\u02C0 = false;
			this.sustainParticles[num].Stop();
			this.\u02B4\u02B5\u02C0\u02C1\u02B8\u02B6\u02B4\u02BB\u02BC\u02B2\u02B5[num].\u02B8\u02B3\u02BD\u02B5\u02BC\u02B6\u02B8\u02C1\u02C0\u02BC\u02B7();
			this.\u02B8\u02B8\u02B3\u02B6\u02B2\u02BB\u02B4\u02B9\u02C1\u02B2\u02B2[num].\u02B8\u02B3\u02BD\u02B5\u02BC\u02B6\u02B8\u02C1\u02C0\u02BC\u02B7();
		}
	}

	private void Start()
	{
		Color guitarNoteGreen = base.gameColorSettings.guitarNoteGreen;
		Color guitarNoteRed = base.gameColorSettings.guitarNoteRed;
		Color guitarNoteYellow = base.gameColorSettings.guitarNoteYellow;
		Color guitarNoteBlue = base.gameColorSettings.guitarNoteBlue;
		Color guitarNoteOrange = base.gameColorSettings.guitarNoteOrange;
		this.nc = new Color[] { guitarNoteGreen, guitarNoteRed, guitarNoteYellow, guitarNoteBlue, guitarNoteOrange };
		this.openHitAnimator.spHitColor = base.gameColorSettings.strikerFlameSP;
		this.openHitAnimator.hitColor = base.gameColorSettings.openHitColor;
		int num = 0;
		foreach (global::Animator animator in this.flameAnimators)
		{
			if (Time.deltaTime == 1f)
			{
				animator.particleColor = base.gameColorSettings.strikerFlame;
			}
			else
			{
				animator.particleColor = this.nc[num];
			}
			num++;
			animator.altparticleColor = base.gameColorSettings.strikerFlameSP;
		}
		foreach (global::Animator animator2 in this.\u02B4\u02B5\u02C0\u02C1\u02B8\u02B6\u02B4\u02BB\u02BC\u02B2\u02B5)
		{
			animator2.particleColor = base.gameColorSettings.\u02C0\u02BA\u02C0\u02BD\u02BC\u02B9\u02BE\u02C1\u02B7\u02B8\u02BF;
			animator2.altparticleColor = base.gameColorSettings.\u02B2\u02BF\u02B6\u02BA\u02BF\u02B3\u02B3\u02B8\u02BC\u02B9\u02B7;
		}
		global::Animator[] u02B8_u02C0_u02B9_u02BA_u02B9_u02C0_u02BB_u02B5_u02B8_u02BD_u02BA = this.\u02B8\u02C0\u02B9\u02BA\u02B9\u02C0\u02BB\u02B5\u02B8\u02BD\u02BA;
		for (int j = 0; j < u02B8_u02C0_u02B9_u02BA_u02B9_u02C0_u02BB_u02B5_u02B8_u02BD_u02BA.Length; j++)
		{
			u02B8_u02C0_u02B9_u02BA_u02B9_u02C0_u02BB_u02B5_u02B8_u02BD_u02BA[j].particleColor = base.gameColorSettings.\u02C0\u02C1\u02B9\u02C0\u02B3\u02B4\u02B7\u02B6\u02B5\u02B3\u02B8;
		}
		this.\u02BA\u02BA\u02C0\u02B5\u02BC\u02C1\u02B5\u02BC\u02BB\u02BC\u02B5 = new ParticleSystem.MinMaxGradient(base.gameColorSettings.\u02B4\u02B3\u02B5\u02B5\u02B4\u02BB\u02BF\u02B6\u02BE\u02B9\u02BF);
		this.\u02BF\u02BF\u02BC\u02BC\u02C1\u02C0\u02BA\u02B7\u02C0\u02BF\u02BC = new ParticleSystem.MinMaxGradient(base.gameColorSettings.\u02BA\u02B7\u02BD\u02B2\u02B2\u02B2\u02C0\u02B9\u02BD\u02BB\u02B8);
		ParticleSystem[] array2 = this.noteParticles;
		for (int k = 0; k < array2.Length; k++)
		{
			this.__p = array2[k].main;
			this.__p.startColor = this.\u02BF\u02BF\u02BC\u02BC\u02C1\u02C0\u02BA\u02B7\u02C0\u02BF\u02BC;
		}
		array2 = this.sustainParticles;
		for (int l = 0; l < array2.Length; l++)
		{
			this.__p = array2[l].main;
			this.__p.startColor = this.\u02BF\u02BF\u02BC\u02BC\u02C1\u02C0\u02BA\u02B7\u02C0\u02BF\u02BC;
		}
		NeckController.\u02B8\u02B9\u02B2\u02B3\u02B8\u02BA\u02B2\u02BD\u02BA\u02B8\u02B4 = SettingsController.\u02C0\u02B6\u02BC\u02BF\u02BF\u02C0\u02BF\u02BC\u02B4\u02B3\u02BC;
	}

	public override void PlayFret(Note \u02BE\u02BE\u02BD\u02B2\u02BB\u02B3\u02BD\u02BF\u02B3\u02B4\u02B3, bool \u02B3\u02B2\u02BC\u02B2\u02BD\u02BF\u02B6\u02BD\u02BF\u02C0\u02BE, bool \u02BD\u02B7\u02B5\u02BB\u02BC\u02C1\u02B9\u02B4\u02C0\u02B5\u02B3)
	{
		bool flag = \u02BE\u02BE\u02BD\u02B2\u02BB\u02B3\u02BD\u02BF\u02B3\u02B4\u02B3.\u02BB\u02BE\u02BA\u02B8\u02BE\u02B9\u02BF\u02B3\u02B4\u02B8\u02BD > 0f;
		if (\u02BE\u02BE\u02BD\u02B2\u02BB\u02B3\u02BD\u02BF\u02B3\u02B4\u02B3.\u02BF\u02C0\u02B8\u02BB\u02BA\u02B8\u02B3\u02BA\u02B4\u02BB\u02BF == 64)
		{
			if (NeckController.\u02B8\u02B9\u02B2\u02B3\u02B8\u02BA\u02B2\u02BD\u02BA\u02B8\u02B4 && !this.\u02B3\u02B6\u02BA\u02B2\u02C1\u02BE\u02BB\u02BB\u02B5\u02BB\u02B5)
			{
				this.openHitAnimator.\u02BF\u02B5\u02C1\u02B4\u02B6\u02B5\u02BA\u02B7\u02C0\u02B8\u02BE(flag);
			}
			if (\u02B3\u02B2\u02BC\u02B2\u02BD\u02BF\u02B6\u02BD\u02BF\u02C0\u02BE)
			{
				this.\u02B6\u02C0\u02C1\u02BA\u02B4\u02B7\u02B7\u02C1\u02BE\u02B3\u02BC[2].\u02BF\u02B5\u02C1\u02B4\u02B6\u02B5\u02BA\u02B7\u02C0\u02B8\u02BE();
				this.\u02B8\u02C0\u02B9\u02BA\u02B9\u02C0\u02BB\u02B5\u02B8\u02BD\u02BA[2].\u02BF\u02B5\u02C1\u02B4\u02B6\u02B5\u02BA\u02B7\u02C0\u02B8\u02BE();
			}
			for (int i = 0; i < 5; i++)
			{
				if (!this.\u02BD\u02B3\u02B2\u02BC\u02B2\u02BC\u02B6\u02B4\u02B6\u02BA\u02B9[i].\u02B6\u02BF\u02B2\u02BF\u02B9\u02BC\u02BD\u02B6\u02B5\u02B4\u02BE && !this.\u02BD\u02B3\u02B2\u02BC\u02B2\u02BC\u02B6\u02B4\u02B6\u02BA\u02B9[i].\u02C1\u02B8\u02B6\u02B6\u02BF\u02BF\u02BD\u02BF\u02B4\u02B6\u02C0)
				{
					this.\u02BD\u02B3\u02B2\u02BC\u02B2\u02BC\u02B6\u02B4\u02B6\u02BA\u02B9[i].\u02BF\u02B5\u02C1\u02B4\u02B6\u02B5\u02BA\u02B7\u02C0\u02B8\u02BE(false, true);
				}
			}
			return;
		}
		__FIXME_clon_util.\u02B2\u02B8\u02C1\u02BF\u02B7\u02B4\u02B2\u02B2\u02C0\u02B2\u02BA u02B2_u02B8_u02C1_u02BF_u02B7_u02B4_u02B2_u02B2_u02C0_u02B2_u02BA = __FIXME_clon_util.\u02B8\u02C0\u02BA\u02BB\u02B6\u02BA\u02BA\u02C0\u02B4\u02C1\u02B9(\u02BE\u02BE\u02BD\u02B2\u02BB\u02B3\u02BD\u02BF\u02B3\u02B4\u02B3.\u02BF\u02C0\u02B8\u02BB\u02BA\u02B8\u02B3\u02BA\u02B4\u02BB\u02BF).\u02BC\u02C0\u02B8\u02B9\u02B4\u02BB\u02BE\u02B6\u02BC\u02B7\u02C1();
		while (u02B2_u02B8_u02C1_u02BF_u02B7_u02B4_u02B2_u02B2_u02C0_u02B2_u02BA.\u02BF\u02B5\u02B7\u02BB\u02B5\u02BB\u02B7\u02B5\u02B6\u02BA\u02BC())
		{
			int num = u02B2_u02B8_u02C1_u02BF_u02B7_u02B4_u02B2_u02B2_u02C0_u02B2_u02BA.\u02B9\u02BA\u02BB\u02B4\u02C0\u02B4\u02B6\u02B2\u02B9\u02B3\u02BF;
			this.\u02BD\u02B3\u02B2\u02BC\u02B2\u02BC\u02B6\u02B4\u02B6\u02BA\u02B9[num].\u02BF\u02B5\u02C1\u02B4\u02B6\u02B5\u02BA\u02B7\u02C0\u02B8\u02BE(flag, false);
			if (NeckController.\u02B8\u02B9\u02B2\u02B3\u02B8\u02BA\u02B2\u02BD\u02BA\u02B8\u02B4)
			{
				this.flameAnimators[num].\u02BF\u02B5\u02C1\u02B4\u02B6\u02B5\u02BA\u02B7\u02C0\u02B8\u02BE(\u02BD\u02B7\u02B5\u02BB\u02BC\u02C1\u02B9\u02B4\u02C0\u02B5\u02B3);
				if (flag)
				{
					this.\u02B7\u02BE\u02BD\u02BE\u02C1\u02BD\u02BE\u02BE\u02B6\u02B8\u02B4(this.sustainParticles[num].main, \u02BD\u02B7\u02B5\u02BB\u02BC\u02C1\u02B9\u02B4\u02C0\u02B5\u02B3);
					this.sustainParticles[num].gameObject.SetActive(false);
					this.sustainParticles[num].gameObject.SetActive(true);
					this.sustainParticles[num].Play();
					this.\u02B4\u02B5\u02C0\u02C1\u02B8\u02B6\u02B4\u02BB\u02BC\u02B2\u02B5[num].\u02BF\u02B5\u02C1\u02B4\u02B6\u02B5\u02BA\u02B7\u02C0\u02B8\u02BE(\u02BD\u02B7\u02B5\u02BB\u02BC\u02C1\u02B9\u02B4\u02C0\u02B5\u02B3);
					this.\u02B8\u02B8\u02B3\u02B6\u02B2\u02BB\u02B4\u02B9\u02C1\u02B2\u02B2[num].\u02BF\u02B5\u02C1\u02B4\u02B6\u02B5\u02BA\u02B7\u02C0\u02B8\u02BE();
				}
				else
				{
					this.\u02B7\u02BE\u02BD\u02BE\u02C1\u02BD\u02BE\u02BE\u02B6\u02B8\u02B4(this.noteParticles[num].main, \u02BD\u02B7\u02B5\u02BB\u02BC\u02C1\u02B9\u02B4\u02C0\u02B5\u02B3);
					this.noteParticles[num].Play();
				}
			}
			if (\u02B3\u02B2\u02BC\u02B2\u02BD\u02BF\u02B6\u02BD\u02BF\u02C0\u02BE)
			{
				this.\u02B6\u02C0\u02C1\u02BA\u02B4\u02B7\u02B7\u02C1\u02BE\u02B3\u02BC[num].\u02BF\u02B5\u02C1\u02B4\u02B6\u02B5\u02BA\u02B7\u02C0\u02B8\u02BE();
				this.\u02B8\u02C0\u02B9\u02BA\u02B9\u02C0\u02BB\u02B5\u02B8\u02BD\u02BA[num].\u02BF\u02B5\u02C1\u02B4\u02B6\u02B5\u02BA\u02B7\u02C0\u02B8\u02BE();
				this.\u02B7\u02BE\u02BD\u02BE\u02C1\u02BD\u02BE\u02BE\u02B6\u02B8\u02B4(this.sustainParticles[num].main, \u02BD\u02B7\u02B5\u02BB\u02BC\u02C1\u02B9\u02B4\u02C0\u02B5\u02B3);
				this.\u02B7\u02BE\u02BD\u02BE\u02C1\u02BD\u02BE\u02BE\u02B6\u02B8\u02B4(this.noteParticles[num].main, \u02BD\u02B7\u02B5\u02BB\u02BC\u02C1\u02B9\u02B4\u02C0\u02B5\u02B3);
			}
		}
	}

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
			array = this.sustainParticles;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].emission.enabled = false;
			}
		}
	}

	public override void \u02C0\u02B8\u02B5\u02B3\u02BF\u02BD\u02B2\u02BE\u02B9\u02B2\u02B4(ushort \u02B4\u02BC\u02C0\u02B4\u02B3\u02BA\u02BE\u02C0\u02C1\u02B3\u02B6)
	{
		if (\u02B4\u02BC\u02C0\u02B4\u02B3\u02BA\u02BE\u02C0\u02C1\u02B3\u02B6 == this.\u02B6\u02B5\u02BF\u02B2\u02B6\u02B9\u02BA\u02B4\u02B6\u02B3\u02C0)
		{
			return;
		}
		for (int i = 0; i < 5; i++)
		{
			int num = 1 << i;
			if (((int)\u02B4\u02BC\u02C0\u02B4\u02B3\u02BA\u02BE\u02C0\u02C1\u02B3\u02B6 & num) != 0)
			{
				this.\u02BD\u02B3\u02B2\u02BC\u02B2\u02BC\u02B6\u02B4\u02B6\u02BA\u02B9[i].\u02C0\u02BE\u02B5\u02BF\u02B4\u02B9\u02B6\u02BD\u02BC\u02B7\u02B7();
			}
			else if (this.\u02BD\u02B3\u02B2\u02BC\u02B2\u02BC\u02B6\u02B4\u02B6\u02BA\u02B9[i].\u02B6\u02BF\u02B2\u02BF\u02B9\u02BC\u02BD\u02B6\u02B5\u02B4\u02BE)
			{
				this.\u02BD\u02B3\u02B2\u02BC\u02B2\u02BC\u02B6\u02B4\u02B6\u02BA\u02B9[i].\u02BB\u02BF\u02B2\u02B3\u02BD\u02BB\u02BE\u02BD\u02BB\u02BE\u02B3();
			}
		}
		this.\u02B6\u02B5\u02BF\u02B2\u02B6\u02B9\u02BA\u02B4\u02B6\u02B3\u02C0 = \u02B4\u02BC\u02C0\u02B4\u02B3\u02BA\u02BE\u02C0\u02C1\u02B3\u02B6;
	}

	public virtual void \u02BE\u02BA\u02BC\u02BA\u02B5\u02B7\u02C0\u02BC\u02BA\u02C1\u02BC(Note \u02BE\u02BE\u02BD\u02B2\u02BB\u02B3\u02BD\u02BF\u02B3\u02B4\u02B3, bool \u02B3\u02B2\u02BC\u02B2\u02BD\u02BF\u02B6\u02BD\u02BF\u02C0\u02BE, bool \u02BD\u02B7\u02B5\u02BB\u02BC\u02C1\u02B9\u02B4\u02C0\u02B5\u02B3)
	{
		bool flag = \u02BE\u02BE\u02BD\u02B2\u02BB\u02B3\u02BD\u02BF\u02B3\u02B4\u02B3.\u02BB\u02BE\u02BA\u02B8\u02BE\u02B9\u02BF\u02B3\u02B4\u02B8\u02BD > 1287f;
		if ((int)\u02BE\u02BE\u02BD\u02B2\u02BB\u02B3\u02BD\u02BF\u02B3\u02B4\u02B3.\u02BF\u02C0\u02B8\u02BB\u02BA\u02B8\u02B3\u02BA\u02B4\u02BB\u02BF == -74)
		{
			if (NeckController.\u02B8\u02B9\u02B2\u02B3\u02B8\u02BA\u02B2\u02BD\u02BA\u02B8\u02B4 && !this.\u02B3\u02B6\u02BA\u02B2\u02C1\u02BE\u02BB\u02BB\u02B5\u02BB\u02B5)
			{
				this.openHitAnimator.\u02B8\u02BC\u02BD\u02B5\u02B8\u02BA\u02B7\u02B3\u02C1\u02B8\u02B2(flag);
			}
			if (\u02B3\u02B2\u02BC\u02B2\u02BD\u02BF\u02B6\u02BD\u02BF\u02C0\u02BE)
			{
				this.\u02B6\u02C0\u02C1\u02BA\u02B4\u02B7\u02B7\u02C1\u02BE\u02B3\u02BC[7].\u02BF\u02B5\u02C1\u02B4\u02B6\u02B5\u02BA\u02B7\u02C0\u02B8\u02BE();
				this.\u02B8\u02C0\u02B9\u02BA\u02B9\u02C0\u02BB\u02B5\u02B8\u02BD\u02BA[6].\u02B4\u02B5\u02BD\u02B9\u02C1\u02B3\u02B3\u02BF\u02B3\u02BD\u02B3();
			}
			for (int i = 1; i < 7; i++)
			{
				if (!this.\u02BD\u02B3\u02B2\u02BC\u02B2\u02BC\u02B6\u02B4\u02B6\u02BA\u02B9[i].\u02B6\u02BF\u02B2\u02BF\u02B9\u02BC\u02BD\u02B6\u02B5\u02B4\u02BE && !this.\u02BD\u02B3\u02B2\u02BC\u02B2\u02BC\u02B6\u02B4\u02B6\u02BA\u02B9[i].\u02C1\u02B8\u02B6\u02B6\u02BF\u02BF\u02BD\u02BF\u02B4\u02B6\u02C0)
				{
					this.\u02BD\u02B3\u02B2\u02BC\u02B2\u02BC\u02B6\u02B4\u02B6\u02BA\u02B9[i].\u02BF\u02B5\u02C1\u02B4\u02B6\u02B5\u02BA\u02B7\u02C0\u02B8\u02BE(true, true);
				}
			}
			return;
		}
		__FIXME_clon_util.\u02B2\u02B8\u02C1\u02BF\u02B7\u02B4\u02B2\u02B2\u02C0\u02B2\u02BA u02B2_u02B8_u02C1_u02BF_u02B7_u02B4_u02B2_u02B2_u02C0_u02B2_u02BA = __FIXME_clon_util.\u02B8\u02C0\u02BA\u02BB\u02B6\u02BA\u02BA\u02C0\u02B4\u02C1\u02B9(\u02BE\u02BE\u02BD\u02B2\u02BB\u02B3\u02BD\u02BF\u02B3\u02B4\u02B3.\u02BF\u02C0\u02B8\u02BB\u02BA\u02B8\u02B3\u02BA\u02B4\u02BB\u02BF).\u02BC\u02C0\u02B8\u02B9\u02B4\u02BB\u02BE\u02B6\u02BC\u02B7\u02C1();
		while (u02B2_u02B8_u02C1_u02BF_u02B7_u02B4_u02B2_u02B2_u02C0_u02B2_u02BA.\u02C1\u02B3\u02BB\u02BF\u02B2\u02B6\u02BE\u02BC\u02C1\u02BE\u02B6())
		{
			int num = u02B2_u02B8_u02C1_u02BF_u02B7_u02B4_u02B2_u02B2_u02C0_u02B2_u02BA.\u02B7\u02B8\u02BD\u02BA\u02BB\u02B7\u02BF\u02B8\u02B3\u02BF\u02BF();
			this.\u02BD\u02B3\u02B2\u02BC\u02B2\u02BC\u02B6\u02B4\u02B6\u02BA\u02B9[num].\u02BF\u02B5\u02C1\u02B4\u02B6\u02B5\u02BA\u02B7\u02C0\u02B8\u02BE(flag, true);
			if (NeckController.\u02B8\u02B9\u02B2\u02B3\u02B8\u02BA\u02B2\u02BD\u02BA\u02B8\u02B4)
			{
				this.flameAnimators[num].\u02BF\u02B5\u02C1\u02B4\u02B6\u02B5\u02BA\u02B7\u02C0\u02B8\u02BE(\u02BD\u02B7\u02B5\u02BB\u02BC\u02C1\u02B9\u02B4\u02C0\u02B5\u02B3);
				if (flag)
				{
					this.\u02B6\u02BF\u02B7\u02B8\u02BE\u02BF\u02BA\u02BF\u02BF\u02BD\u02BB(this.sustainParticles[num].main, \u02BD\u02B7\u02B5\u02BB\u02BC\u02C1\u02B9\u02B4\u02C0\u02B5\u02B3);
					this.sustainParticles[num].gameObject.SetActive(false);
					this.sustainParticles[num].gameObject.SetActive(false);
					this.sustainParticles[num].Play();
					this.\u02B4\u02B5\u02C0\u02C1\u02B8\u02B6\u02B4\u02BB\u02BC\u02B2\u02B5[num].\u02BF\u02B5\u02C1\u02B4\u02B6\u02B5\u02BA\u02B7\u02C0\u02B8\u02BE(\u02BD\u02B7\u02B5\u02BB\u02BC\u02C1\u02B9\u02B4\u02C0\u02B5\u02B3);
					this.\u02B8\u02B8\u02B3\u02B6\u02B2\u02BB\u02B4\u02B9\u02C1\u02B2\u02B2[num].\u02BD\u02B8\u02BA\u02BC\u02B4\u02BA\u02C0\u02B2\u02BA\u02B9\u02BE();
				}
				else
				{
					this.\u02B7\u02BE\u02BD\u02BE\u02C1\u02BD\u02BE\u02BE\u02B6\u02B8\u02B4(this.noteParticles[num].main, \u02BD\u02B7\u02B5\u02BB\u02BC\u02C1\u02B9\u02B4\u02C0\u02B5\u02B3);
					this.noteParticles[num].Play();
				}
			}
			if (\u02B3\u02B2\u02BC\u02B2\u02BD\u02BF\u02B6\u02BD\u02BF\u02C0\u02BE)
			{
				this.\u02B6\u02C0\u02C1\u02BA\u02B4\u02B7\u02B7\u02C1\u02BE\u02B3\u02BC[num].\u02BF\u02B5\u02C1\u02B4\u02B6\u02B5\u02BA\u02B7\u02C0\u02B8\u02BE();
				this.\u02B8\u02C0\u02B9\u02BA\u02B9\u02C0\u02BB\u02B5\u02B8\u02BD\u02BA[num].\u02B7\u02BB\u02BC\u02BE\u02B7\u02B5\u02B2\u02BD\u02B4\u02BA\u02BD();
				this.\u02B6\u02BF\u02B7\u02B8\u02BE\u02BF\u02BA\u02BF\u02BF\u02BD\u02BB(this.sustainParticles[num].main, \u02BD\u02B7\u02B5\u02BB\u02BC\u02C1\u02B9\u02B4\u02C0\u02B5\u02B3);
				this.\u02B6\u02BF\u02B7\u02B8\u02BE\u02BF\u02BA\u02BF\u02BF\u02BD\u02BB(this.noteParticles[num].main, \u02BD\u02B7\u02B5\u02BB\u02BC\u02C1\u02B9\u02B4\u02C0\u02B5\u02B3);
			}
		}
	}

	public override void \u02B6\u02B2\u02B9\u02B7\u02B5\u02B9\u02B5\u02BF\u02B8\u02B8\u02BC(bool \u02BB\u02B9\u02BB\u02B7\u02BB\u02B9\u02BA\u02B2\u02C1\u02B5\u02BA)
	{
		for (int i = 0; i < 5; i++)
		{
			this.\u02B7\u02BE\u02BD\u02BE\u02C1\u02BD\u02BE\u02BE\u02B6\u02B8\u02B4(this.sustainParticles[i].main, \u02BB\u02B9\u02BB\u02B7\u02BB\u02B9\u02BA\u02B2\u02C1\u02B5\u02BA);
			this.\u02B7\u02BE\u02BD\u02BE\u02C1\u02BD\u02BE\u02BE\u02B6\u02B8\u02B4(this.noteParticles[i].main, \u02BB\u02B9\u02BB\u02B7\u02BB\u02B9\u02BA\u02B2\u02C1\u02B5\u02BA);
			this.\u02B4\u02B5\u02C0\u02C1\u02B8\u02B6\u02B4\u02BB\u02BC\u02B2\u02B5[i].\u02BB\u02C1\u02B3\u02C0\u02B4\u02B2\u02B4\u02C0\u02BF\u02B2\u02B3(\u02BB\u02B9\u02BB\u02B7\u02BB\u02B9\u02BA\u02B2\u02C1\u02B5\u02BA);
		}
	}

	public override void \u02BF\u02B2\u02BE\u02BE\u02BF\u02B4\u02BC\u02C0\u02B3\u02C0\u02C1()
	{
		Array.Reverse<global::Animator>(this.\u02B4\u02B5\u02C0\u02C1\u02B8\u02B6\u02B4\u02BB\u02BC\u02B2\u02B5);
		Array.Reverse<global::Animator>(this.\u02B8\u02B8\u02B3\u02B6\u02B2\u02BB\u02B4\u02B9\u02C1\u02B2\u02B2);
		Array.Reverse<global::Animator>(this.\u02B6\u02C0\u02C1\u02BA\u02B4\u02B7\u02B7\u02C1\u02BE\u02B3\u02BC);
		Array.Reverse<global::Animator>(this.\u02B8\u02C0\u02B9\u02BA\u02B9\u02C0\u02BB\u02B5\u02B8\u02BD\u02BA);
		Array.Reverse<global::Animator>(this.flameAnimators);
		Array.Reverse<ParticleSystem>(this.noteParticles, 0, 5);
		Array.Reverse<ParticleSystem>(this.sustainParticles);
		for (int i = 0; i < 2; i++)
		{
			Vector3 localPosition = this.\u02BD\u02B3\u02B2\u02BC\u02B2\u02BC\u02B6\u02B4\u02B6\u02BA\u02B9[i].transform.localPosition;
			Vector3 localPosition2 = this.\u02BD\u02B3\u02B2\u02BC\u02B2\u02BC\u02B6\u02B4\u02B6\u02BA\u02B9[4 - i].transform.localPosition;
			Vector3 localScale = this.\u02BD\u02B3\u02B2\u02BC\u02B2\u02BC\u02B6\u02B4\u02B6\u02BA\u02B9[i].transform.localScale;
			Vector3 localScale2 = this.\u02BD\u02B3\u02B2\u02BC\u02B2\u02BC\u02B6\u02B4\u02B6\u02BA\u02B9[3].transform.localScale;
			this.\u02BD\u02B3\u02B2\u02BC\u02B2\u02BC\u02B6\u02B4\u02B6\u02BA\u02B9[i].transform.localPosition = localPosition2;
			this.\u02BD\u02B3\u02B2\u02BC\u02B2\u02BC\u02B6\u02B4\u02B6\u02BA\u02B9[i].transform.localScale = new Vector3(-localScale2.x, localScale2.y, 1f);
			this.\u02BD\u02B3\u02B2\u02BC\u02B2\u02BC\u02B6\u02B4\u02B6\u02BA\u02B9[4 - i].transform.localPosition = localPosition;
			this.\u02BD\u02B3\u02B2\u02BC\u02B2\u02BC\u02B6\u02B4\u02B6\u02BA\u02B9[4 - i].transform.localScale = new Vector3(-localScale.x, localScale.y, 1f);
		}
	}

	protected virtual IEnumerator \u02BD\u02C0\u02BA\u02C0\u02C0\u02B9\u02BF\u02BE\u02B7\u02BA\u02B8()
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

	public virtual void \u02B3\u02B8\u02B2\u02B4\u02B9\u02B9\u02BB\u02BD\u02B7\u02BF\u02B6()
	{
		this.openHitAnimator.\u02B4\u02BB\u02B2\u02B4\u02B8\u02BB\u02C0\u02B5\u02B7\u02BC\u02B2();
		for (int i = 0; i < 3; i += 0)
		{
			this.\u02BD\u02B3\u02B2\u02BC\u02B2\u02BC\u02B6\u02B4\u02B6\u02BA\u02B9[i].\u02C1\u02B8\u02B6\u02B6\u02BF\u02BF\u02BD\u02BF\u02B4\u02B6\u02C0 = false;
			this.sustainParticles[i].Stop();
			this.\u02B4\u02B5\u02C0\u02C1\u02B8\u02B6\u02B4\u02BB\u02BC\u02B2\u02B5[i].\u02B8\u02B3\u02BD\u02B5\u02BC\u02B6\u02B8\u02C1\u02C0\u02BC\u02B7();
			this.\u02B8\u02B8\u02B3\u02B6\u02B2\u02BB\u02B4\u02B9\u02C1\u02B2\u02B2[i].\u02BC\u02BD\u02BD\u02B8\u02BC\u02C1\u02B7\u02B4\u02B4\u02C1\u02B3();
		}
	}

	public NeckController()
	{
		this.\u02C1\u02B4\u02BC\u02B7\u02BD\u02BF\u02BC\u02C1\u02B7\u02BE\u02B4 = 0.15f;
	}

	private void \u02C0\u02BC\u02BC\u02BD\u02B8\u02BD\u02BE\u02B6\u02BE\u02BB\u02BB()
	{
		this.openHitAnimator.\u02BB\u02BC\u02BD\u02B9\u02B3\u02B3\u02BB\u02BD\u02BE\u02B8\u02B6(base.gameColorSettings.strikerFlameSP);
		this.openHitAnimator.\u02B5\u02BB\u02B2\u02BC\u02B4\u02BC\u02B5\u02BA\u02BF\u02B3\u02B4(base.gameColorSettings.openHitColor);
		global::Animator[] array = this.flameAnimators;
		for (int i = 0; i < array.Length; i += 0)
		{
			global::Animator animator = array[i];
			animator.particleColor = base.gameColorSettings.strikerFlame;
			animator.altparticleColor = base.gameColorSettings.strikerFlameSP;
		}
		array = this.\u02B4\u02B5\u02C0\u02C1\u02B8\u02B6\u02B4\u02BB\u02BC\u02B2\u02B5;
		for (int i = 0; i < array.Length; i += 0)
		{
			global::Animator animator2 = array[i];
			animator2.particleColor = base.gameColorSettings.\u02C0\u02BA\u02C0\u02BD\u02BC\u02B9\u02BE\u02C1\u02B7\u02B8\u02BF;
			animator2.altparticleColor = base.gameColorSettings.\u02B2\u02BF\u02B6\u02BA\u02BF\u02B3\u02B3\u02B8\u02BC\u02B9\u02B7;
		}
		array = this.\u02B8\u02C0\u02B9\u02BA\u02B9\u02C0\u02BB\u02B5\u02B8\u02BD\u02BA;
		for (int i = 0; i < array.Length; i++)
		{
			array[i].particleColor = base.gameColorSettings.\u02C0\u02C1\u02B9\u02C0\u02B3\u02B4\u02B7\u02B6\u02B5\u02B3\u02B8;
		}
		this.\u02BA\u02BA\u02C0\u02B5\u02BC\u02C1\u02B5\u02BC\u02BB\u02BC\u02B5 = new ParticleSystem.MinMaxGradient(base.gameColorSettings.\u02B4\u02B3\u02B5\u02B5\u02B4\u02BB\u02BF\u02B6\u02BE\u02B9\u02BF);
		this.\u02BF\u02BF\u02BC\u02BC\u02C1\u02C0\u02BA\u02B7\u02C0\u02BF\u02BC = new ParticleSystem.MinMaxGradient(base.gameColorSettings.\u02BA\u02B7\u02BD\u02B2\u02B2\u02B2\u02C0\u02B9\u02BD\u02BB\u02B8);
		ParticleSystem[] array2 = this.noteParticles;
		for (int i = 1; i < array2.Length; i += 0)
		{
			array2[i].main.startColor = this.\u02BF\u02BF\u02BC\u02BC\u02C1\u02C0\u02BA\u02B7\u02C0\u02BF\u02BC;
		}
		array2 = this.sustainParticles;
		for (int i = 1; i < array2.Length; i += 0)
		{
			array2[i].main.startColor = this.\u02BF\u02BF\u02BC\u02BC\u02C1\u02C0\u02BA\u02B7\u02C0\u02BF\u02BC;
		}
		NeckController.\u02B8\u02B9\u02B2\u02B3\u02B8\u02BA\u02B2\u02BD\u02BA\u02B8\u02B4 = SettingsController.\u02C0\u02B6\u02BC\u02BF\u02BF\u02C0\u02BF\u02BC\u02B4\u02B3\u02BC;
	}

	public virtual void \u02B8\u02BF\u02B6\u02BA\u02C1\u02C0\u02B7\u02B4\u02BD\u02C0\u02C1(ushort \u02B4\u02BC\u02C0\u02B4\u02B3\u02BA\u02BE\u02C0\u02C1\u02B3\u02B6)
	{
		if (\u02B4\u02BC\u02C0\u02B4\u02B3\u02BA\u02BE\u02C0\u02C1\u02B3\u02B6 == this.\u02B6\u02B5\u02BF\u02B2\u02B6\u02B9\u02BA\u02B4\u02B6\u02B3\u02C0)
		{
			return;
		}
		for (int i = 1; i < 0; i += 0)
		{
			int num = 0 << (i & -67);
			if (((int)\u02B4\u02BC\u02C0\u02B4\u02B3\u02BA\u02BE\u02C0\u02C1\u02B3\u02B6 & num) != 0)
			{
				this.\u02BD\u02B3\u02B2\u02BC\u02B2\u02BC\u02B6\u02B4\u02B6\u02BA\u02B9[i].\u02C0\u02BE\u02B5\u02BF\u02B4\u02B9\u02B6\u02BD\u02BC\u02B7\u02B7();
			}
			else if (this.\u02BD\u02B3\u02B2\u02BC\u02B2\u02BC\u02B6\u02B4\u02B6\u02BA\u02B9[i].\u02B6\u02BF\u02B2\u02BF\u02B9\u02BC\u02BD\u02B6\u02B5\u02B4\u02BE)
			{
				this.\u02BD\u02B3\u02B2\u02BC\u02B2\u02BC\u02B6\u02B4\u02B6\u02BA\u02B9[i].\u02BB\u02BF\u02B2\u02B3\u02BD\u02BB\u02BE\u02BD\u02BB\u02BE\u02B3();
			}
		}
		this.\u02B6\u02B5\u02BF\u02B2\u02B6\u02B9\u02BA\u02B4\u02B6\u02B3\u02C0 = \u02B4\u02BC\u02C0\u02B4\u02B3\u02BA\u02BE\u02C0\u02C1\u02B3\u02B6;
	}

	public virtual void \u02BD\u02B9\u02B9\u02BA\u02B7\u02BB\u02BF\u02BC\u02B2\u02BE\u02BB()
	{
		this.openHitAnimator.\u02B8\u02B3\u02BD\u02B5\u02BC\u02B6\u02B8\u02C1\u02C0\u02BC\u02B7();
		for (int i = 1; i < 8; i++)
		{
			this.\u02BD\u02B3\u02B2\u02BC\u02B2\u02BC\u02B6\u02B4\u02B6\u02BA\u02B9[i].\u02C1\u02B8\u02B6\u02B6\u02BF\u02BF\u02BD\u02BF\u02B4\u02B6\u02C0 = true;
			this.sustainParticles[i].Stop();
			this.\u02B4\u02B5\u02C0\u02C1\u02B8\u02B6\u02B4\u02BB\u02BC\u02B2\u02B5[i].\u02B6\u02BC\u02BB\u02BE\u02B4\u02B3\u02B3\u02C1\u02B3\u02BE\u02C0();
			this.\u02B8\u02B8\u02B3\u02B6\u02B2\u02BB\u02B4\u02B9\u02C1\u02B2\u02B2[i].\u02B6\u02BC\u02BB\u02BE\u02B4\u02B3\u02B3\u02C1\u02B3\u02BE\u02C0();
		}
	}

	public override void \u02B2\u02BF\u02BB\u02BC\u02B8\u02B7\u02B9\u02C1\u02B8\u02BE\u02BA()
	{
		for (int i = 0; i < this.\u02BD\u02B3\u02B2\u02BC\u02B2\u02BC\u02B6\u02B4\u02B6\u02BA\u02B9.Length; i++)
		{
			this.\u02BD\u02B3\u02B2\u02BC\u02B2\u02BC\u02B6\u02B4\u02B6\u02BA\u02B9[i].gameObject.SetActive(false);
			this.\u02B4\u02B5\u02C0\u02C1\u02B8\u02B6\u02B4\u02BB\u02BC\u02B2\u02B5[i].gameObject.SetActive(false);
			this.\u02B8\u02B8\u02B3\u02B6\u02B2\u02BB\u02B4\u02B9\u02C1\u02B2\u02B2[i].gameObject.SetActive(false);
			this.\u02B8\u02C0\u02B9\u02BA\u02B9\u02C0\u02BB\u02B5\u02B8\u02BD\u02BA[i].gameObject.SetActive(false);
			this.noteParticles[i].gameObject.SetActive(false);
			this.sustainParticles[i].gameObject.SetActive(false);
			this.\u02B3\u02B6\u02BA\u02B2\u02C1\u02BE\u02BB\u02BB\u02B5\u02BB\u02B5 = true;
			this.flameAnimators[i].gameObject.SetActive(false);
			this.\u02B6\u02C0\u02C1\u02BA\u02B4\u02B7\u02B7\u02C1\u02BE\u02B3\u02BC[i].gameObject.SetActive(false);
		}
	}

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

	protected virtual IEnumerator \u02B7\u02B2\u02B8\u02BA\u02BE\u02BF\u02B9\u02C1\u02BC\u02BF\u02B8()
	{
		NeckController.\u02C0\u02BB\u02BA\u02C0\u02B5\u02BC\u02BD\u02B9\u02BB\u02B7\u02B8 u02C0_u02BB_u02BA_u02C0_u02B5_u02BC_u02BD_u02B9_u02BB_u02B7_u02B = new NeckController.\u02C0\u02BB\u02BA\u02C0\u02B5\u02BC\u02BD\u02B9\u02BB\u02B7\u02B8(1);
		u02C0_u02BB_u02BA_u02C0_u02B5_u02BC_u02BD_u02B9_u02BB_u02B7_u02B.<>4__this = this;
		return u02C0_u02BB_u02BA_u02C0_u02B5_u02BC_u02BD_u02B9_u02BB_u02B7_u02B;
	}

	private void \u02B4\u02BF\u02B6\u02BB\u02B2\u02B6\u02C1\u02B3\u02BC\u02B7\u02BE()
	{
		this.openHitAnimator.\u02B2\u02C1\u02C0\u02B8\u02B2\u02B5\u02C0\u02B2\u02B3\u02C1\u02B8(base.gameColorSettings.strikerFlameSP);
		this.openHitAnimator.\u02B3\u02B6\u02B8\u02B5\u02BB\u02B5\u02BA\u02B2\u02BA\u02B9\u02B6(base.gameColorSettings.openHitColor);
		global::Animator[] array = this.flameAnimators;
		for (int i = 1; i < array.Length; i += 0)
		{
			global::Animator animator = array[i];
			animator.particleColor = base.gameColorSettings.strikerFlame;
			animator.altparticleColor = base.gameColorSettings.strikerFlameSP;
		}
		array = this.\u02B4\u02B5\u02C0\u02C1\u02B8\u02B6\u02B4\u02BB\u02BC\u02B2\u02B5;
		for (int i = 1; i < array.Length; i += 0)
		{
			global::Animator animator2 = array[i];
			animator2.particleColor = base.gameColorSettings.\u02C0\u02BA\u02C0\u02BD\u02BC\u02B9\u02BE\u02C1\u02B7\u02B8\u02BF;
			animator2.altparticleColor = base.gameColorSettings.\u02B2\u02BF\u02B6\u02BA\u02BF\u02B3\u02B3\u02B8\u02BC\u02B9\u02B7;
		}
		array = this.\u02B8\u02C0\u02B9\u02BA\u02B9\u02C0\u02BB\u02B5\u02B8\u02BD\u02BA;
		for (int i = 0; i < array.Length; i += 0)
		{
			array[i].particleColor = base.gameColorSettings.\u02C0\u02C1\u02B9\u02C0\u02B3\u02B4\u02B7\u02B6\u02B5\u02B3\u02B8;
		}
		this.\u02BA\u02BA\u02C0\u02B5\u02BC\u02C1\u02B5\u02BC\u02BB\u02BC\u02B5 = new ParticleSystem.MinMaxGradient(base.gameColorSettings.\u02B4\u02B3\u02B5\u02B5\u02B4\u02BB\u02BF\u02B6\u02BE\u02B9\u02BF);
		this.\u02BF\u02BF\u02BC\u02BC\u02C1\u02C0\u02BA\u02B7\u02C0\u02BF\u02BC = new ParticleSystem.MinMaxGradient(base.gameColorSettings.\u02BA\u02B7\u02BD\u02B2\u02B2\u02B2\u02C0\u02B9\u02BD\u02BB\u02B8);
		ParticleSystem[] array2 = this.noteParticles;
		for (int i = 1; i < array2.Length; i += 0)
		{
			array2[i].main.startColor = this.\u02BF\u02BF\u02BC\u02BC\u02C1\u02C0\u02BA\u02B7\u02C0\u02BF\u02BC;
		}
		array2 = this.sustainParticles;
		for (int i = 1; i < array2.Length; i++)
		{
			array2[i].main.startColor = this.\u02BF\u02BF\u02BC\u02BC\u02C1\u02C0\u02BA\u02B7\u02C0\u02BF\u02BC;
		}
		NeckController.\u02B8\u02B9\u02B2\u02B3\u02B8\u02BA\u02B2\u02BD\u02BA\u02B8\u02B4 = SettingsController.\u02C0\u02B6\u02BC\u02BF\u02BF\u02C0\u02BF\u02BC\u02B4\u02B3\u02BC;
	}

	private void \u02B5\u02BD\u02BD\u02BE\u02B9\u02BD\u02B2\u02C1\u02C1\u02B3\u02B6()
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
			array = this.sustainParticles;
			for (int i = 0; i < array.Length; i += 0)
			{
				array[i].emission.enabled = true;
			}
		}
	}

	private void Update()
	{
		if (!GlobalHelper.perFretFlameColors)
		{
			if (!this.colorsReset)
			{
				this.colorsReset = true;
				global::Animator[] flameAnimators = this.flameAnimators;
				for (int i = 0; i < flameAnimators.Length; i++)
				{
					flameAnimators[i].particleColor = base.gameColorSettings.strikerFlame;
				}
			}
			return;
		}
		this.colorsReset = false;
		this.ticker += Time.deltaTime;
		if (this.ticker > 0.7f)
		{
			this.ticker -= 0.7f;
			global::Animator[] flameAnimators2 = this.flameAnimators;
			for (int j = 0; j < flameAnimators2.Length; j++)
			{
				Color color = this.nc[j];
				float colorIntensity = GlobalHelper.colorIntensity;
				if (colorIntensity <= -1f)
				{
					color = Color.black;
				}
				else if (colorIntensity > 0f)
				{
					float maxColorComponent = color.maxColorComponent;
					if (maxColorComponent > 0f)
					{
						color = Color.Lerp(color, color * (1f / maxColorComponent), colorIntensity);
					}
				}
				else
				{
					color *= 1f + colorIntensity;
				}
				color.a = 1f;
				flameAnimators2[j].particleColor = color;
			}
		}
	}

	public global::Animator[] \u02B4\u02B5\u02C0\u02C1\u02B8\u02B6\u02B4\u02BB\u02BC\u02B2\u02B5;

	public global::Animator[] \u02B8\u02B8\u02B3\u02B6\u02B2\u02BB\u02B4\u02B9\u02C1\u02B2\u02B2;

	public global::Animator[] \u02B8\u02C0\u02B9\u02BA\u02B9\u02C0\u02BB\u02B5\u02B8\u02BD\u02BA;

	[SerializeField]
	private OpenHitAnimator openHitAnimator;

	[SerializeField]
	private ParticleSystem[] noteParticles;

	[SerializeField]
	private ParticleSystem[] sustainParticles;

	private float \u02C1\u02B4\u02BC\u02B7\u02BD\u02BF\u02BC\u02C1\u02B7\u02BE\u02B4;

	private ushort \u02B6\u02B5\u02BF\u02B2\u02B6\u02B9\u02BA\u02B4\u02B6\u02B3\u02C0;

	private bool \u02B3\u02B6\u02BA\u02B2\u02C1\u02BE\u02BB\u02BB\u02B5\u02BB\u02B5;

	private ParticleSystem.MinMaxGradient \u02BA\u02BA\u02C0\u02B5\u02BC\u02C1\u02B5\u02BC\u02BB\u02BC\u02B5;

	private ParticleSystem.MinMaxGradient \u02BF\u02BF\u02BC\u02BC\u02C1\u02C0\u02BA\u02B7\u02C0\u02BF\u02BC;

	private static bool \u02B8\u02B9\u02B2\u02B3\u02B8\u02BA\u02B2\u02BD\u02BA\u02B8\u02B4 = true;

	private ParticleSystem.MainModule __p;

	private Color[] nc;

	private float ticker;

	private bool colorsReset;
}
