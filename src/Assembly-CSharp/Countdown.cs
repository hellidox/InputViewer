using System;
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020001E0 RID: 480
public class Countdown : MonoBehaviour
{
	// Token: 0x06001532 RID: 5426 RVA: 0x00011261 File Offset: 0x0000F461
	private IEnumerator \u02B9\u02BF\u02B8\u02BE\u02B7\u02B6\u02C0\u02B2\u02BA\u02BA\u02BE()
	{
		Countdown.\u02C1\u02B2\u02BC\u02B8\u02B8\u02BC\u02B8\u02B8\u02B4\u02BB\u02B8 u02C1_u02B2_u02BC_u02B8_u02B8_u02BC_u02B8_u02B8_u02B4_u02BB_u02B = new Countdown.\u02C1\u02B2\u02BC\u02B8\u02B8\u02BC\u02B8\u02B8\u02B4\u02BB\u02B8(1);
		u02C1_u02B2_u02BC_u02B8_u02B8_u02BC_u02B8_u02B8_u02B4_u02BB_u02B.<>4__this = this;
		return u02C1_u02B2_u02BC_u02B8_u02B8_u02BC_u02B8_u02B8_u02B4_u02BB_u02B;
	}

	// Token: 0x06001533 RID: 5427 RVA: 0x00011270 File Offset: 0x0000F470
	private IEnumerator \u02B4\u02B8\u02B4\u02C1\u02B8\u02B8\u02B4\u02BB\u02C1\u02B3\u02BF()
	{
		int lastMeasure = 0;
		int lastSecond = -1;
		Note lastNote = null;
		for (;;)
		{
			if (this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD.\u02B2\u02BB\u02BA\u02B9\u02BA\u02B2\u02B7\u02BE\u02BB\u02BA\u02B9 >= (double)this.player.\u02B3\u02BC\u02B8\u02B9\u02BE\u02BC\u02BC\u02B8\u02BD\u02C1\u02BD.\u02B2\u02B8\u02B7\u02BD\u02B5\u02B7\u02B6\u02B2\u02BF\u02BD\u02C0 + 0.20000000298023224)
			{
				Note note = this.player.\u02B9\u02BF\u02B4\u02C1\u02C0\u02B7\u02B6\u02B9\u02BC\u02BD\u02B3;
				if (note == null)
				{
					break;
				}
				if (note != lastNote)
				{
					lastNote = note;
					if ((double)note.\u02B2\u02B8\u02BA\u02BA\u02BC\u02B7\u02B5\u02B5\u02B6\u02B5\u02C1 >= this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD.\u02B2\u02BB\u02BA\u02B9\u02BA\u02B2\u02B7\u02BE\u02BB\u02BA\u02B9 + 10.0)
					{
						int noteMeasure = this.\u02B3\u02BC\u02B3\u02B6\u02BD\u02B6\u02B4\u02B5\u02B6\u02B7\u02BB.\u02BD\u02BD\u02BC\u02B4\u02B5\u02C0\u02C0\u02BA\u02B7\u02B4\u02B8(this.player.\u02B9\u02BF\u02B4\u02C1\u02C0\u02B7\u02B6\u02B9\u02BC\u02BD\u02B3);
						double startTime = (double)this.player.\u02B3\u02BC\u02B8\u02B9\u02BE\u02BC\u02BC\u02B8\u02BD\u02C1\u02BD.\u02B2\u02B8\u02B7\u02BD\u02B5\u02B7\u02B6\u02B2\u02BF\u02BD\u02C0;
						double endTime = (double)note.\u02B2\u02B8\u02BA\u02BA\u02BC\u02B7\u02B5\u02B5\u02B6\u02B5\u02C1;
						double timeDif = endTime - startTime;
						this.\u02B5\u02C1\u02B7\u02BA\u02B9\u02BC\u02C1\u02B8\u02BE\u02B6\u02B7 = true;
						this.fill.enabled = true;
						this.timerText.enabled = true;
						this.timerImage.enabled = true;
						while (this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD.\u02B2\u02BB\u02BA\u02B9\u02BA\u02B2\u02B7\u02BE\u02BB\u02BA\u02B9 < endTime)
						{
							int num = (int)(endTime - this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD.\u02B2\u02BB\u02BA\u02B9\u02BA\u02B2\u02B7\u02BE\u02BB\u02BA\u02B9);
							if (this.\u02B6\u02C0\u02BC\u02BE\u02B2\u02B6\u02B8\u02B9\u02B2\u02B9\u02B2)
							{
								if (lastMeasure != this.\u02B3\u02BC\u02B3\u02B6\u02BD\u02B6\u02B4\u02B5\u02B6\u02B7\u02BB.\u02BF\u02B2\u02BC\u02B5\u02C1\u02B8\u02BA\u02B9\u02B7\u02B7\u02B9)
								{
									lastMeasure = this.\u02B3\u02BC\u02B3\u02B6\u02BD\u02B6\u02B4\u02B5\u02B6\u02B7\u02BB.\u02BF\u02B2\u02BC\u02B5\u02C1\u02B8\u02BA\u02B9\u02B7\u02B7\u02B9;
									this.timerText.text = (noteMeasure - lastMeasure).ToString();
								}
							}
							else if (num != lastSecond)
							{
								lastSecond = num;
								this.timerText.text = lastSecond.ToString();
							}
							this.fill.fillAmount = 1f - (float)((this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD.\u02B2\u02BB\u02BA\u02B9\u02BA\u02B2\u02B7\u02BE\u02BB\u02BA\u02B9 - startTime) / timeDif);
							if (num <= 2)
							{
								this.\u02B6\u02B6\u02B6\u02B2\u02BC\u02B6\u02B9\u02BE\u02BA\u02BA\u02B5.a = (float)(endTime - this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD.\u02B2\u02BB\u02BA\u02B9\u02BA\u02B2\u02B7\u02BE\u02BB\u02BA\u02B9) - 2f;
								this.timerImage.color = this.\u02B6\u02B6\u02B6\u02B2\u02BC\u02B6\u02B9\u02BE\u02BA\u02BA\u02B5;
								this.timerText.color = this.\u02B6\u02B6\u02B6\u02B2\u02BC\u02B6\u02B9\u02BE\u02BA\u02BA\u02B5;
								this.fill.color = this.\u02B6\u02B6\u02B6\u02B2\u02BC\u02B6\u02B9\u02BE\u02BA\u02BA\u02B5;
							}
							if (num <= 1)
							{
								break;
							}
							yield return null;
						}
						this.\u02B5\u02C1\u02B7\u02BA\u02B9\u02BC\u02C1\u02B8\u02BE\u02B6\u02B7 = false;
						this.timerImage.enabled = false;
						this.timerText.enabled = false;
						this.fill.enabled = false;
						this.\u02B6\u02B6\u02B6\u02B2\u02BC\u02B6\u02B9\u02BE\u02BA\u02BA\u02B5.a = 1f;
						this.timerImage.color = this.\u02B6\u02B6\u02B6\u02B2\u02BC\u02B6\u02B9\u02BE\u02BA\u02BA\u02B5;
						this.timerText.color = this.\u02B6\u02B6\u02B6\u02B2\u02BC\u02B6\u02B9\u02BE\u02BA\u02BA\u02B5;
						this.fill.color = this.\u02B6\u02B6\u02B6\u02B2\u02BC\u02B6\u02B9\u02BE\u02BA\u02BA\u02B5;
						continue;
					}
				}
				yield return null;
			}
			else
			{
				yield return null;
			}
		}
		base.gameObject.SetActive(false);
		yield break;
		yield break;
	}

	// Token: 0x06001534 RID: 5428 RVA: 0x00011270 File Offset: 0x0000F470
	private IEnumerator \u02B8\u02BA\u02BD\u02B9\u02BB\u02B3\u02C1\u02B5\u02C0\u02B4\u02C1()
	{
		lastMeasure = 0;
		lastSecond = -1;
		lastNote = null;
		for (;;)
		{
			if (this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD.\u02B2\u02BB\u02BA\u02B9\u02BA\u02B2\u02B7\u02BE\u02BB\u02BA\u02B9 >= (double)this.player.\u02B3\u02BC\u02B8\u02B9\u02BE\u02BC\u02BC\u02B8\u02BD\u02C1\u02BD.\u02B2\u02B8\u02B7\u02BD\u02B5\u02B7\u02B6\u02B2\u02BF\u02BD\u02C0 + 0.20000000298023224)
			{
				Note note = this.player.\u02B9\u02BF\u02B4\u02C1\u02C0\u02B7\u02B6\u02B9\u02BC\u02BD\u02B3;
				if (note == null)
				{
					break;
				}
				if (note != lastNote)
				{
					lastNote = note;
					if ((double)note.\u02B2\u02B8\u02BA\u02BA\u02BC\u02B7\u02B5\u02B5\u02B6\u02B5\u02C1 >= this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD.\u02B2\u02BB\u02BA\u02B9\u02BA\u02B2\u02B7\u02BE\u02BB\u02BA\u02B9 + 10.0)
					{
						noteMeasure = this.\u02B3\u02BC\u02B3\u02B6\u02BD\u02B6\u02B4\u02B5\u02B6\u02B7\u02BB.\u02BD\u02BD\u02BC\u02B4\u02B5\u02C0\u02C0\u02BA\u02B7\u02B4\u02B8(this.player.\u02B9\u02BF\u02B4\u02C1\u02C0\u02B7\u02B6\u02B9\u02BC\u02BD\u02B3);
						startTime = (double)this.player.\u02B3\u02BC\u02B8\u02B9\u02BE\u02BC\u02BC\u02B8\u02BD\u02C1\u02BD.\u02B2\u02B8\u02B7\u02BD\u02B5\u02B7\u02B6\u02B2\u02BF\u02BD\u02C0;
						endTime = (double)note.\u02B2\u02B8\u02BA\u02BA\u02BC\u02B7\u02B5\u02B5\u02B6\u02B5\u02C1;
						timeDif = endTime - startTime;
						this.\u02B5\u02C1\u02B7\u02BA\u02B9\u02BC\u02C1\u02B8\u02BE\u02B6\u02B7 = true;
						this.fill.enabled = true;
						this.timerText.enabled = true;
						this.timerImage.enabled = true;
						while (this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD.\u02B2\u02BB\u02BA\u02B9\u02BA\u02B2\u02B7\u02BE\u02BB\u02BA\u02B9 < endTime)
						{
							int num = (int)(endTime - this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD.\u02B2\u02BB\u02BA\u02B9\u02BA\u02B2\u02B7\u02BE\u02BB\u02BA\u02B9);
							if (this.\u02B6\u02C0\u02BC\u02BE\u02B2\u02B6\u02B8\u02B9\u02B2\u02B9\u02B2)
							{
								if (lastMeasure != this.\u02B3\u02BC\u02B3\u02B6\u02BD\u02B6\u02B4\u02B5\u02B6\u02B7\u02BB.\u02BF\u02B2\u02BC\u02B5\u02C1\u02B8\u02BA\u02B9\u02B7\u02B7\u02B9)
								{
									lastMeasure = this.\u02B3\u02BC\u02B3\u02B6\u02BD\u02B6\u02B4\u02B5\u02B6\u02B7\u02BB.\u02BF\u02B2\u02BC\u02B5\u02C1\u02B8\u02BA\u02B9\u02B7\u02B7\u02B9;
									this.timerText.text = (noteMeasure - lastMeasure).ToString();
								}
							}
							else if (num != lastSecond)
							{
								lastSecond = num;
								this.timerText.text = lastSecond.ToString();
							}
							this.fill.fillAmount = 1f - (float)((this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD.\u02B2\u02BB\u02BA\u02B9\u02BA\u02B2\u02B7\u02BE\u02BB\u02BA\u02B9 - startTime) / timeDif);
							if (num <= 2)
							{
								this.\u02B6\u02B6\u02B6\u02B2\u02BC\u02B6\u02B9\u02BE\u02BA\u02BA\u02B5.a = (float)(endTime - this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD.\u02B2\u02BB\u02BA\u02B9\u02BA\u02B2\u02B7\u02BE\u02BB\u02BA\u02B9) - 2f;
								this.timerImage.color = this.\u02B6\u02B6\u02B6\u02B2\u02BC\u02B6\u02B9\u02BE\u02BA\u02BA\u02B5;
								this.timerText.color = this.\u02B6\u02B6\u02B6\u02B2\u02BC\u02B6\u02B9\u02BE\u02BA\u02BA\u02B5;
								this.fill.color = this.\u02B6\u02B6\u02B6\u02B2\u02BC\u02B6\u02B9\u02BE\u02BA\u02BA\u02B5;
							}
							if (num <= 1)
							{
								break;
							}
							yield return null;
						}
						this.\u02B5\u02C1\u02B7\u02BA\u02B9\u02BC\u02C1\u02B8\u02BE\u02B6\u02B7 = false;
						this.timerImage.enabled = false;
						this.timerText.enabled = false;
						this.fill.enabled = false;
						this.\u02B6\u02B6\u02B6\u02B2\u02BC\u02B6\u02B9\u02BE\u02BA\u02BA\u02B5.a = 1f;
						this.timerImage.color = this.\u02B6\u02B6\u02B6\u02B2\u02BC\u02B6\u02B9\u02BE\u02BA\u02BA\u02B5;
						this.timerText.color = this.\u02B6\u02B6\u02B6\u02B2\u02BC\u02B6\u02B9\u02BE\u02BA\u02BA\u02B5;
						this.fill.color = this.\u02B6\u02B6\u02B6\u02B2\u02BC\u02B6\u02B9\u02BE\u02BA\u02BA\u02B5;
						continue;
					}
				}
				yield return null;
			}
			else
			{
				yield return null;
			}
		}
		base.gameObject.SetActive(false);
		yield break;
		yield break;
	}

	// Token: 0x06001536 RID: 5430 RVA: 0x00011261 File Offset: 0x0000F461
	private IEnumerator \u02BA\u02B9\u02B8\u02BE\u02BD\u02B9\u02BA\u02BF\u02BF\u02BA\u02B3()
	{
		Countdown.\u02C1\u02B2\u02BC\u02B8\u02B8\u02BC\u02B8\u02B8\u02B4\u02BB\u02B8 u02C1_u02B2_u02BC_u02B8_u02B8_u02BC_u02B8_u02B8_u02B4_u02BB_u02B = new Countdown.\u02C1\u02B2\u02BC\u02B8\u02B8\u02BC\u02B8\u02B8\u02B4\u02BB\u02B8(1);
		u02C1_u02B2_u02BC_u02B8_u02B8_u02BC_u02B8_u02B8_u02B4_u02BB_u02B.<>4__this = this;
		return u02C1_u02B2_u02BC_u02B8_u02B8_u02BC_u02B8_u02B8_u02B4_u02BB_u02B;
	}

	// Token: 0x06001537 RID: 5431 RVA: 0x000A6288 File Offset: 0x000A4488
	private void \u02B4\u02BA\u02BE\u02BB\u02B5\u02BB\u02C1\u02B2\u02B4\u02B2\u02BF()
	{
		if (GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BD\u02B9\u02B7\u02B5\u02BF\u02BC\u02BF\u02BA\u02BE\u02B6\u02B4)
		{
			base.gameObject.SetActive(true);
			return;
		}
		this.timerImage.enabled = false;
		this.timerText.enabled = true;
		this.fill.enabled = false;
		this.\u02B6\u02C0\u02BC\u02BE\u02B2\u02B6\u02B8\u02B9\u02B2\u02B9\u02B2 = SettingsController.\u02B6\u02C0\u02BC\u02BE\u02B2\u02B6\u02B8\u02B9\u02B2\u02B9\u02B2;
		this.\u02B3\u02BC\u02B3\u02B6\u02BD\u02B6\u02B4\u02B5\u02B6\u02B7\u02BB = this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD.\u02B5\u02B9\u02C1\u02C0\u02B7\u02BD\u02BE\u02B2\u02C1\u02B2\u02B6;
		base.StartCoroutine(this.\u02B9\u02BF\u02B8\u02BE\u02B7\u02B6\u02C0\u02B2\u02BA\u02BA\u02BE());
	}

	// Token: 0x06001538 RID: 5432 RVA: 0x000A6300 File Offset: 0x000A4500
	private void \u02BF\u02BA\u02B5\u02B8\u02B5\u02BF\u02B2\u02BF\u02B3\u02BC\u02BA()
	{
		if (GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BD\u02B9\u02B7\u02B5\u02BF\u02BC\u02BF\u02BA\u02BE\u02B6\u02B4)
		{
			base.gameObject.SetActive(false);
			return;
		}
		this.timerImage.enabled = true;
		this.timerText.enabled = true;
		this.fill.enabled = false;
		this.\u02B6\u02C0\u02BC\u02BE\u02B2\u02B6\u02B8\u02B9\u02B2\u02B9\u02B2 = SettingsController.\u02B6\u02C0\u02BC\u02BE\u02B2\u02B6\u02B8\u02B9\u02B2\u02B9\u02B2;
		this.\u02B3\u02BC\u02B3\u02B6\u02BD\u02B6\u02B4\u02B5\u02B6\u02B7\u02BB = this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD.\u02B5\u02B9\u02C1\u02C0\u02B7\u02BD\u02BE\u02B2\u02C1\u02B2\u02B6;
		base.StartCoroutine(this.\u02BD\u02B2\u02B5\u02BB\u02C0\u02B4\u02BA\u02B2\u02B3\u02BC\u02B4());
	}

	// Token: 0x06001539 RID: 5433 RVA: 0x00011270 File Offset: 0x0000F470
	private IEnumerator \u02BF\u02B5\u02B7\u02B5\u02B5\u02B3\u02BD\u02BD\u02C0\u02B8\u02B6()
	{
		lastMeasure = 0;
		lastSecond = -1;
		lastNote = null;
		for (;;)
		{
			if (this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD.\u02B2\u02BB\u02BA\u02B9\u02BA\u02B2\u02B7\u02BE\u02BB\u02BA\u02B9 >= (double)this.player.\u02B3\u02BC\u02B8\u02B9\u02BE\u02BC\u02BC\u02B8\u02BD\u02C1\u02BD.\u02B2\u02B8\u02B7\u02BD\u02B5\u02B7\u02B6\u02B2\u02BF\u02BD\u02C0 + 0.20000000298023224)
			{
				Note note = this.player.\u02B9\u02BF\u02B4\u02C1\u02C0\u02B7\u02B6\u02B9\u02BC\u02BD\u02B3;
				if (note == null)
				{
					break;
				}
				if (note != lastNote)
				{
					lastNote = note;
					if ((double)note.\u02B2\u02B8\u02BA\u02BA\u02BC\u02B7\u02B5\u02B5\u02B6\u02B5\u02C1 >= this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD.\u02B2\u02BB\u02BA\u02B9\u02BA\u02B2\u02B7\u02BE\u02BB\u02BA\u02B9 + 10.0)
					{
						noteMeasure = this.\u02B3\u02BC\u02B3\u02B6\u02BD\u02B6\u02B4\u02B5\u02B6\u02B7\u02BB.\u02BD\u02BD\u02BC\u02B4\u02B5\u02C0\u02C0\u02BA\u02B7\u02B4\u02B8(this.player.\u02B9\u02BF\u02B4\u02C1\u02C0\u02B7\u02B6\u02B9\u02BC\u02BD\u02B3);
						startTime = (double)this.player.\u02B3\u02BC\u02B8\u02B9\u02BE\u02BC\u02BC\u02B8\u02BD\u02C1\u02BD.\u02B2\u02B8\u02B7\u02BD\u02B5\u02B7\u02B6\u02B2\u02BF\u02BD\u02C0;
						endTime = (double)note.\u02B2\u02B8\u02BA\u02BA\u02BC\u02B7\u02B5\u02B5\u02B6\u02B5\u02C1;
						timeDif = endTime - startTime;
						this.\u02B5\u02C1\u02B7\u02BA\u02B9\u02BC\u02C1\u02B8\u02BE\u02B6\u02B7 = true;
						this.fill.enabled = true;
						this.timerText.enabled = true;
						this.timerImage.enabled = true;
						while (this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD.\u02B2\u02BB\u02BA\u02B9\u02BA\u02B2\u02B7\u02BE\u02BB\u02BA\u02B9 < endTime)
						{
							int num = (int)(endTime - this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD.\u02B2\u02BB\u02BA\u02B9\u02BA\u02B2\u02B7\u02BE\u02BB\u02BA\u02B9);
							if (this.\u02B6\u02C0\u02BC\u02BE\u02B2\u02B6\u02B8\u02B9\u02B2\u02B9\u02B2)
							{
								if (lastMeasure != this.\u02B3\u02BC\u02B3\u02B6\u02BD\u02B6\u02B4\u02B5\u02B6\u02B7\u02BB.\u02BF\u02B2\u02BC\u02B5\u02C1\u02B8\u02BA\u02B9\u02B7\u02B7\u02B9)
								{
									lastMeasure = this.\u02B3\u02BC\u02B3\u02B6\u02BD\u02B6\u02B4\u02B5\u02B6\u02B7\u02BB.\u02BF\u02B2\u02BC\u02B5\u02C1\u02B8\u02BA\u02B9\u02B7\u02B7\u02B9;
									this.timerText.text = (noteMeasure - lastMeasure).ToString();
								}
							}
							else if (num != lastSecond)
							{
								lastSecond = num;
								this.timerText.text = lastSecond.ToString();
							}
							this.fill.fillAmount = 1f - (float)((this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD.\u02B2\u02BB\u02BA\u02B9\u02BA\u02B2\u02B7\u02BE\u02BB\u02BA\u02B9 - startTime) / timeDif);
							if (num <= 2)
							{
								this.\u02B6\u02B6\u02B6\u02B2\u02BC\u02B6\u02B9\u02BE\u02BA\u02BA\u02B5.a = (float)(endTime - this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD.\u02B2\u02BB\u02BA\u02B9\u02BA\u02B2\u02B7\u02BE\u02BB\u02BA\u02B9) - 2f;
								this.timerImage.color = this.\u02B6\u02B6\u02B6\u02B2\u02BC\u02B6\u02B9\u02BE\u02BA\u02BA\u02B5;
								this.timerText.color = this.\u02B6\u02B6\u02B6\u02B2\u02BC\u02B6\u02B9\u02BE\u02BA\u02BA\u02B5;
								this.fill.color = this.\u02B6\u02B6\u02B6\u02B2\u02BC\u02B6\u02B9\u02BE\u02BA\u02BA\u02B5;
							}
							if (num <= 1)
							{
								break;
							}
							yield return null;
						}
						this.\u02B5\u02C1\u02B7\u02BA\u02B9\u02BC\u02C1\u02B8\u02BE\u02B6\u02B7 = false;
						this.timerImage.enabled = false;
						this.timerText.enabled = false;
						this.fill.enabled = false;
						this.\u02B6\u02B6\u02B6\u02B2\u02BC\u02B6\u02B9\u02BE\u02BA\u02BA\u02B5.a = 1f;
						this.timerImage.color = this.\u02B6\u02B6\u02B6\u02B2\u02BC\u02B6\u02B9\u02BE\u02BA\u02BA\u02B5;
						this.timerText.color = this.\u02B6\u02B6\u02B6\u02B2\u02BC\u02B6\u02B9\u02BE\u02BA\u02BA\u02B5;
						this.fill.color = this.\u02B6\u02B6\u02B6\u02B2\u02BC\u02B6\u02B9\u02BE\u02BA\u02BA\u02B5;
						continue;
					}
				}
				yield return null;
			}
			else
			{
				yield return null;
			}
		}
		base.gameObject.SetActive(false);
		yield break;
		yield break;
	}

	// Token: 0x0600153A RID: 5434 RVA: 0x00011261 File Offset: 0x0000F461
	private IEnumerator \u02B3\u02BD\u02B8\u02C1\u02BB\u02B3\u02BD\u02BB\u02C1\u02B7\u02B5()
	{
		Countdown.\u02C1\u02B2\u02BC\u02B8\u02B8\u02BC\u02B8\u02B8\u02B4\u02BB\u02B8 u02C1_u02B2_u02BC_u02B8_u02B8_u02BC_u02B8_u02B8_u02B4_u02BB_u02B = new Countdown.\u02C1\u02B2\u02BC\u02B8\u02B8\u02BC\u02B8\u02B8\u02B4\u02BB\u02B8(1);
		u02C1_u02B2_u02BC_u02B8_u02B8_u02BC_u02B8_u02B8_u02B4_u02BB_u02B.<>4__this = this;
		return u02C1_u02B2_u02BC_u02B8_u02B8_u02BC_u02B8_u02B8_u02B4_u02BB_u02B;
	}

	// Token: 0x0600153B RID: 5435 RVA: 0x000A6378 File Offset: 0x000A4578
	private void Start()
	{
		if (GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BD\u02B9\u02B7\u02B5\u02BF\u02BC\u02BF\u02BA\u02BE\u02B6\u02B4)
		{
			base.gameObject.SetActive(false);
			return;
		}
		this.timerImage.enabled = false;
		this.timerText.enabled = false;
		this.fill.enabled = false;
		this.\u02B6\u02C0\u02BC\u02BE\u02B2\u02B6\u02B8\u02B9\u02B2\u02B9\u02B2 = SettingsController.\u02B6\u02C0\u02BC\u02BE\u02B2\u02B6\u02B8\u02B9\u02B2\u02B9\u02B2;
		this.\u02B3\u02BC\u02B3\u02B6\u02BD\u02B6\u02B4\u02B5\u02B6\u02B7\u02BB = this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD.\u02B5\u02B9\u02C1\u02C0\u02B7\u02BD\u02BE\u02B2\u02C1\u02B2\u02B6;
		base.StartCoroutine(this.\u02B8\u02BA\u02BD\u02B9\u02BB\u02B3\u02C1\u02B5\u02C0\u02B4\u02C1());
	}

	// Token: 0x0600153C RID: 5436 RVA: 0x00011261 File Offset: 0x0000F461
	private IEnumerator \u02BA\u02C1\u02BB\u02BE\u02B5\u02B8\u02B8\u02C0\u02B8\u02BF\u02BF()
	{
		Countdown.\u02C1\u02B2\u02BC\u02B8\u02B8\u02BC\u02B8\u02B8\u02B4\u02BB\u02B8 u02C1_u02B2_u02BC_u02B8_u02B8_u02BC_u02B8_u02B8_u02B4_u02BB_u02B = new Countdown.\u02C1\u02B2\u02BC\u02B8\u02B8\u02BC\u02B8\u02B8\u02B4\u02BB\u02B8(1);
		u02C1_u02B2_u02BC_u02B8_u02B8_u02BC_u02B8_u02B8_u02B4_u02BB_u02B.<>4__this = this;
		return u02C1_u02B2_u02BC_u02B8_u02B8_u02BC_u02B8_u02B8_u02B4_u02BB_u02B;
	}

	// Token: 0x0600153D RID: 5437 RVA: 0x00011270 File Offset: 0x0000F470
	private IEnumerator \u02C1\u02BB\u02BC\u02B7\u02B6\u02B2\u02BE\u02B3\u02BF\u02B8\u02B7()
	{
		lastMeasure = 0;
		lastSecond = -1;
		lastNote = null;
		for (;;)
		{
			if (this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD.\u02B2\u02BB\u02BA\u02B9\u02BA\u02B2\u02B7\u02BE\u02BB\u02BA\u02B9 >= (double)this.player.\u02B3\u02BC\u02B8\u02B9\u02BE\u02BC\u02BC\u02B8\u02BD\u02C1\u02BD.\u02B2\u02B8\u02B7\u02BD\u02B5\u02B7\u02B6\u02B2\u02BF\u02BD\u02C0 + 0.20000000298023224)
			{
				Note note = this.player.\u02B9\u02BF\u02B4\u02C1\u02C0\u02B7\u02B6\u02B9\u02BC\u02BD\u02B3;
				if (note == null)
				{
					break;
				}
				if (note != lastNote)
				{
					lastNote = note;
					if ((double)note.\u02B2\u02B8\u02BA\u02BA\u02BC\u02B7\u02B5\u02B5\u02B6\u02B5\u02C1 >= this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD.\u02B2\u02BB\u02BA\u02B9\u02BA\u02B2\u02B7\u02BE\u02BB\u02BA\u02B9 + 10.0)
					{
						noteMeasure = this.\u02B3\u02BC\u02B3\u02B6\u02BD\u02B6\u02B4\u02B5\u02B6\u02B7\u02BB.\u02BD\u02BD\u02BC\u02B4\u02B5\u02C0\u02C0\u02BA\u02B7\u02B4\u02B8(this.player.\u02B9\u02BF\u02B4\u02C1\u02C0\u02B7\u02B6\u02B9\u02BC\u02BD\u02B3);
						startTime = (double)this.player.\u02B3\u02BC\u02B8\u02B9\u02BE\u02BC\u02BC\u02B8\u02BD\u02C1\u02BD.\u02B2\u02B8\u02B7\u02BD\u02B5\u02B7\u02B6\u02B2\u02BF\u02BD\u02C0;
						endTime = (double)note.\u02B2\u02B8\u02BA\u02BA\u02BC\u02B7\u02B5\u02B5\u02B6\u02B5\u02C1;
						timeDif = endTime - startTime;
						this.\u02B5\u02C1\u02B7\u02BA\u02B9\u02BC\u02C1\u02B8\u02BE\u02B6\u02B7 = true;
						this.fill.enabled = true;
						this.timerText.enabled = true;
						this.timerImage.enabled = true;
						while (this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD.\u02B2\u02BB\u02BA\u02B9\u02BA\u02B2\u02B7\u02BE\u02BB\u02BA\u02B9 < endTime)
						{
							int num = (int)(endTime - this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD.\u02B2\u02BB\u02BA\u02B9\u02BA\u02B2\u02B7\u02BE\u02BB\u02BA\u02B9);
							if (this.\u02B6\u02C0\u02BC\u02BE\u02B2\u02B6\u02B8\u02B9\u02B2\u02B9\u02B2)
							{
								if (lastMeasure != this.\u02B3\u02BC\u02B3\u02B6\u02BD\u02B6\u02B4\u02B5\u02B6\u02B7\u02BB.\u02BF\u02B2\u02BC\u02B5\u02C1\u02B8\u02BA\u02B9\u02B7\u02B7\u02B9)
								{
									lastMeasure = this.\u02B3\u02BC\u02B3\u02B6\u02BD\u02B6\u02B4\u02B5\u02B6\u02B7\u02BB.\u02BF\u02B2\u02BC\u02B5\u02C1\u02B8\u02BA\u02B9\u02B7\u02B7\u02B9;
									this.timerText.text = (noteMeasure - lastMeasure).ToString();
								}
							}
							else if (num != lastSecond)
							{
								lastSecond = num;
								this.timerText.text = lastSecond.ToString();
							}
							this.fill.fillAmount = 1f - (float)((this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD.\u02B2\u02BB\u02BA\u02B9\u02BA\u02B2\u02B7\u02BE\u02BB\u02BA\u02B9 - startTime) / timeDif);
							if (num <= 2)
							{
								this.\u02B6\u02B6\u02B6\u02B2\u02BC\u02B6\u02B9\u02BE\u02BA\u02BA\u02B5.a = (float)(endTime - this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD.\u02B2\u02BB\u02BA\u02B9\u02BA\u02B2\u02B7\u02BE\u02BB\u02BA\u02B9) - 2f;
								this.timerImage.color = this.\u02B6\u02B6\u02B6\u02B2\u02BC\u02B6\u02B9\u02BE\u02BA\u02BA\u02B5;
								this.timerText.color = this.\u02B6\u02B6\u02B6\u02B2\u02BC\u02B6\u02B9\u02BE\u02BA\u02BA\u02B5;
								this.fill.color = this.\u02B6\u02B6\u02B6\u02B2\u02BC\u02B6\u02B9\u02BE\u02BA\u02BA\u02B5;
							}
							if (num <= 1)
							{
								break;
							}
							yield return null;
						}
						this.\u02B5\u02C1\u02B7\u02BA\u02B9\u02BC\u02C1\u02B8\u02BE\u02B6\u02B7 = false;
						this.timerImage.enabled = false;
						this.timerText.enabled = false;
						this.fill.enabled = false;
						this.\u02B6\u02B6\u02B6\u02B2\u02BC\u02B6\u02B9\u02BE\u02BA\u02BA\u02B5.a = 1f;
						this.timerImage.color = this.\u02B6\u02B6\u02B6\u02B2\u02BC\u02B6\u02B9\u02BE\u02BA\u02BA\u02B5;
						this.timerText.color = this.\u02B6\u02B6\u02B6\u02B2\u02BC\u02B6\u02B9\u02BE\u02BA\u02BA\u02B5;
						this.fill.color = this.\u02B6\u02B6\u02B6\u02B2\u02BC\u02B6\u02B9\u02BE\u02BA\u02BA\u02B5;
						continue;
					}
				}
				yield return null;
			}
			else
			{
				yield return null;
			}
		}
		base.gameObject.SetActive(false);
		yield break;
		yield break;
	}

	// Token: 0x0600153E RID: 5438 RVA: 0x000A63F0 File Offset: 0x000A45F0
	private void \u02B5\u02C0\u02BE\u02B8\u02B9\u02B2\u02BD\u02C0\u02BF\u02B3\u02BD()
	{
		if (GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BD\u02B9\u02B7\u02B5\u02BF\u02BC\u02BF\u02BA\u02BE\u02B6\u02B4)
		{
			base.gameObject.SetActive(false);
			return;
		}
		this.timerImage.enabled = false;
		this.timerText.enabled = true;
		this.fill.enabled = false;
		this.\u02B6\u02C0\u02BC\u02BE\u02B2\u02B6\u02B8\u02B9\u02B2\u02B9\u02B2 = SettingsController.\u02B6\u02C0\u02BC\u02BE\u02B2\u02B6\u02B8\u02B9\u02B2\u02B9\u02B2;
		this.\u02B3\u02BC\u02B3\u02B6\u02BD\u02B6\u02B4\u02B5\u02B6\u02B7\u02BB = this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD.\u02B5\u02B9\u02C1\u02C0\u02B7\u02BD\u02BE\u02B2\u02C1\u02B2\u02B6;
		base.StartCoroutine(this.\u02B4\u02B8\u02B4\u02C1\u02B8\u02B8\u02B4\u02BB\u02C1\u02B3\u02BF());
	}

	// Token: 0x0600153F RID: 5439 RVA: 0x000A6468 File Offset: 0x000A4668
	private void \u02C0\u02BC\u02BC\u02BD\u02B8\u02BD\u02BE\u02B6\u02BE\u02BB\u02BB()
	{
		if (GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BD\u02B9\u02B7\u02B5\u02BF\u02BC\u02BF\u02BA\u02BE\u02B6\u02B4)
		{
			base.gameObject.SetActive(false);
			return;
		}
		this.timerImage.enabled = false;
		this.timerText.enabled = true;
		this.fill.enabled = true;
		this.\u02B6\u02C0\u02BC\u02BE\u02B2\u02B6\u02B8\u02B9\u02B2\u02B9\u02B2 = SettingsController.\u02B6\u02C0\u02BC\u02BE\u02B2\u02B6\u02B8\u02B9\u02B2\u02B9\u02B2;
		this.\u02B3\u02BC\u02B3\u02B6\u02BD\u02B6\u02B4\u02B5\u02B6\u02B7\u02BB = this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD.\u02B5\u02B9\u02C1\u02C0\u02B7\u02BD\u02BE\u02B2\u02C1\u02B2\u02B6;
		base.StartCoroutine(this.\u02B8\u02BD\u02BF\u02B9\u02B7\u02B5\u02B6\u02B2\u02BB\u02BC\u02B5());
	}

	// Token: 0x06001540 RID: 5440 RVA: 0x000A64E0 File Offset: 0x000A46E0
	private void \u02B2\u02BB\u02B6\u02B5\u02B9\u02B8\u02B2\u02B3\u02BF\u02C1\u02BF()
	{
		if (GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BD\u02B9\u02B7\u02B5\u02BF\u02BC\u02BF\u02BA\u02BE\u02B6\u02B4)
		{
			base.gameObject.SetActive(false);
			return;
		}
		this.timerImage.enabled = true;
		this.timerText.enabled = true;
		this.fill.enabled = false;
		this.\u02B6\u02C0\u02BC\u02BE\u02B2\u02B6\u02B8\u02B9\u02B2\u02B9\u02B2 = SettingsController.\u02B6\u02C0\u02BC\u02BE\u02B2\u02B6\u02B8\u02B9\u02B2\u02B9\u02B2;
		this.\u02B3\u02BC\u02B3\u02B6\u02BD\u02B6\u02B4\u02B5\u02B6\u02B7\u02BB = this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD.\u02B5\u02B9\u02C1\u02C0\u02B7\u02BD\u02BE\u02B2\u02C1\u02B2\u02B6;
		base.StartCoroutine(this.\u02B8\u02BD\u02BF\u02B9\u02B7\u02B5\u02B6\u02B2\u02BB\u02BC\u02B5());
	}

	// Token: 0x06001541 RID: 5441 RVA: 0x00011261 File Offset: 0x0000F461
	private IEnumerator \u02BD\u02B2\u02B5\u02BB\u02C0\u02B4\u02BA\u02B2\u02B3\u02BC\u02B4()
	{
		Countdown.\u02C1\u02B2\u02BC\u02B8\u02B8\u02BC\u02B8\u02B8\u02B4\u02BB\u02B8 u02C1_u02B2_u02BC_u02B8_u02B8_u02BC_u02B8_u02B8_u02B4_u02BB_u02B = new Countdown.\u02C1\u02B2\u02BC\u02B8\u02B8\u02BC\u02B8\u02B8\u02B4\u02BB\u02B8(1);
		u02C1_u02B2_u02BC_u02B8_u02B8_u02BC_u02B8_u02B8_u02B4_u02BB_u02B.<>4__this = this;
		return u02C1_u02B2_u02BC_u02B8_u02B8_u02BC_u02B8_u02B8_u02B4_u02BB_u02B;
	}

	// Token: 0x06001542 RID: 5442 RVA: 0x000A6558 File Offset: 0x000A4758
	private void \u02B3\u02BB\u02BF\u02B4\u02B9\u02BA\u02B5\u02B5\u02BE\u02BB\u02BE()
	{
		if (GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BD\u02B9\u02B7\u02B5\u02BF\u02BC\u02BF\u02BA\u02BE\u02B6\u02B4)
		{
			base.gameObject.SetActive(false);
			return;
		}
		this.timerImage.enabled = true;
		this.timerText.enabled = false;
		this.fill.enabled = false;
		this.\u02B6\u02C0\u02BC\u02BE\u02B2\u02B6\u02B8\u02B9\u02B2\u02B9\u02B2 = SettingsController.\u02B6\u02C0\u02BC\u02BE\u02B2\u02B6\u02B8\u02B9\u02B2\u02B9\u02B2;
		this.\u02B3\u02BC\u02B3\u02B6\u02BD\u02B6\u02B4\u02B5\u02B6\u02B7\u02BB = this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD.\u02B5\u02B9\u02C1\u02C0\u02B7\u02BD\u02BE\u02B2\u02C1\u02B2\u02B6;
		base.StartCoroutine(this.\u02C1\u02BB\u02BC\u02B7\u02B6\u02B2\u02BE\u02B3\u02BF\u02B8\u02B7());
	}

	// Token: 0x06001543 RID: 5443 RVA: 0x00011261 File Offset: 0x0000F461
	private IEnumerator \u02B8\u02BD\u02BF\u02B9\u02B7\u02B5\u02B6\u02B2\u02BB\u02BC\u02B5()
	{
		Countdown.\u02C1\u02B2\u02BC\u02B8\u02B8\u02BC\u02B8\u02B8\u02B4\u02BB\u02B8 u02C1_u02B2_u02BC_u02B8_u02B8_u02BC_u02B8_u02B8_u02B4_u02BB_u02B = new Countdown.\u02C1\u02B2\u02BC\u02B8\u02B8\u02BC\u02B8\u02B8\u02B4\u02BB\u02B8(1);
		u02C1_u02B2_u02BC_u02B8_u02B8_u02BC_u02B8_u02B8_u02B4_u02BB_u02B.<>4__this = this;
		return u02C1_u02B2_u02BC_u02B8_u02B8_u02BC_u02B8_u02B8_u02B4_u02BB_u02B;
	}

	// Token: 0x06001544 RID: 5444 RVA: 0x00011261 File Offset: 0x0000F461
	private IEnumerator \u02BB\u02BC\u02BA\u02BC\u02BE\u02C1\u02B3\u02B6\u02C0\u02C0\u02B9()
	{
		Countdown.\u02C1\u02B2\u02BC\u02B8\u02B8\u02BC\u02B8\u02B8\u02B4\u02BB\u02B8 u02C1_u02B2_u02BC_u02B8_u02B8_u02BC_u02B8_u02B8_u02B4_u02BB_u02B = new Countdown.\u02C1\u02B2\u02BC\u02B8\u02B8\u02BC\u02B8\u02B8\u02B4\u02BB\u02B8(1);
		u02C1_u02B2_u02BC_u02B8_u02B8_u02BC_u02B8_u02B8_u02B4_u02BB_u02B.<>4__this = this;
		return u02C1_u02B2_u02BC_u02B8_u02B8_u02BC_u02B8_u02B8_u02B4_u02BB_u02B;
	}

	// Token: 0x04000F9B RID: 3995
	[HideInInspector]
	public GameManager \u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD;

	// Token: 0x04000F9C RID: 3996
	private \u02B5\u02B9\u02C1\u02C0\u02B7\u02BD\u02BE\u02B2\u02C1\u02B2\u02B6 \u02B3\u02BC\u02B3\u02B6\u02BD\u02B6\u02B4\u02B5\u02B6\u02B7\u02BB;

	// Token: 0x04000F9D RID: 3997
	[SerializeField]
	private Image fill;

	// Token: 0x04000F9E RID: 3998
	[SerializeField]
	private Image timerImage;

	// Token: 0x04000F9F RID: 3999
	[SerializeField]
	private TextMeshProUGUI timerText;

	// Token: 0x04000FA0 RID: 4000
	[SerializeField]
	private BasePlayer player;

	// Token: 0x04000FA1 RID: 4001
	private Color \u02B6\u02B6\u02B6\u02B2\u02BC\u02B6\u02B9\u02BE\u02BA\u02BA\u02B5 = Color.white;

	// Token: 0x04000FA2 RID: 4002
	private bool \u02B6\u02C0\u02BC\u02BE\u02B2\u02B6\u02B8\u02B9\u02B2\u02B9\u02B2;

	// Token: 0x04000FA3 RID: 4003
	private const int \u02B9\u02B9\u02B8\u02BF\u02B4\u02BD\u02BE\u02C1\u02B9\u02C1\u02C0 = 10;

	// Token: 0x04000FA4 RID: 4004
	private const double \u02B6\u02C0\u02C1\u02B3\u02C0\u02BE\u02B7\u02BD\u02C0\u02BB\u02C1 = 0.20000000298023224;

	// Token: 0x04000FA5 RID: 4005
	[HideInInspector]
	public bool \u02B5\u02C1\u02B7\u02BA\u02B9\u02BC\u02C1\u02B8\u02BE\u02B6\u02B7;
}
