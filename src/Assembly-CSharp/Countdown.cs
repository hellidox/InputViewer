using System;
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour
{
	private IEnumerator \u02B9\u02BF\u02B8\u02BE\u02B7\u02B6\u02C0\u02B2\u02BA\u02BA\u02BE()
	{
		Countdown.\u02C1\u02B2\u02BC\u02B8\u02B8\u02BC\u02B8\u02B8\u02B4\u02BB\u02B8 u02C1_u02B2_u02BC_u02B8_u02B8_u02BC_u02B8_u02B8_u02B4_u02BB_u02B = new Countdown.\u02C1\u02B2\u02BC\u02B8\u02B8\u02BC\u02B8\u02B8\u02B4\u02BB\u02B8(1);
		u02C1_u02B2_u02BC_u02B8_u02B8_u02BC_u02B8_u02B8_u02B4_u02BB_u02B.<>4__this = this;
		return u02C1_u02B2_u02BC_u02B8_u02B8_u02BC_u02B8_u02B8_u02B4_u02BB_u02B;
	}

	private IEnumerator \u02B4\u02B8\u02B4\u02C1\u02B8\u02B8\u02B4\u02BB\u02C1\u02B3\u02BF()
	{
		int lastMeasure = 0;
		int lastSecond = -1;
		Note lastNote = null;
		for (;;)
		{
			if (this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD.songTime >= (double)this.player.\u02B3\u02BC\u02B8\u02B9\u02BE\u02BC\u02BC\u02B8\u02BD\u02C1\u02BD.\u02B2\u02B8\u02B7\u02BD\u02B5\u02B7\u02B6\u02B2\u02BF\u02BD\u02C0 + 0.20000000298023224)
			{
				Note note = this.player.\u02B9\u02BF\u02B4\u02C1\u02C0\u02B7\u02B6\u02B9\u02BC\u02BD\u02B3;
				if (note == null)
				{
					break;
				}
				if (note != lastNote)
				{
					lastNote = note;
					if ((double)note.time >= this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD.songTime + 10.0)
					{
						int noteMeasure = this.\u02B3\u02BC\u02B3\u02B6\u02BD\u02B6\u02B4\u02B5\u02B6\u02B7\u02BB.\u02BD\u02BD\u02BC\u02B4\u02B5\u02C0\u02C0\u02BA\u02B7\u02B4\u02B8(this.player.\u02B9\u02BF\u02B4\u02C1\u02C0\u02B7\u02B6\u02B9\u02BC\u02BD\u02B3);
						double startTime = (double)this.player.\u02B3\u02BC\u02B8\u02B9\u02BE\u02BC\u02BC\u02B8\u02BD\u02C1\u02BD.\u02B2\u02B8\u02B7\u02BD\u02B5\u02B7\u02B6\u02B2\u02BF\u02BD\u02C0;
						double endTime = (double)note.time;
						double timeDif = endTime - startTime;
						this.\u02B5\u02C1\u02B7\u02BA\u02B9\u02BC\u02C1\u02B8\u02BE\u02B6\u02B7 = true;
						this.fill.enabled = true;
						this.timerText.enabled = true;
						this.timerImage.enabled = true;
						while (this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD.songTime < endTime)
						{
							int num = (int)(endTime - this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD.songTime);
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
							this.fill.fillAmount = 1f - (float)((this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD.songTime - startTime) / timeDif);
							if (num <= 2)
							{
								this.\u02B6\u02B6\u02B6\u02B2\u02BC\u02B6\u02B9\u02BE\u02BA\u02BA\u02B5.a = (float)(endTime - this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD.songTime) - 2f;
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

	private IEnumerator \u02B8\u02BA\u02BD\u02B9\u02BB\u02B3\u02C1\u02B5\u02C0\u02B4\u02C1()
	{
		lastMeasure = 0;
		lastSecond = -1;
		lastNote = null;
		for (;;)
		{
			if (this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD.songTime >= (double)this.player.\u02B3\u02BC\u02B8\u02B9\u02BE\u02BC\u02BC\u02B8\u02BD\u02C1\u02BD.\u02B2\u02B8\u02B7\u02BD\u02B5\u02B7\u02B6\u02B2\u02BF\u02BD\u02C0 + 0.20000000298023224)
			{
				Note note = this.player.\u02B9\u02BF\u02B4\u02C1\u02C0\u02B7\u02B6\u02B9\u02BC\u02BD\u02B3;
				if (note == null)
				{
					break;
				}
				if (note != lastNote)
				{
					lastNote = note;
					if ((double)note.time >= this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD.songTime + 10.0)
					{
						noteMeasure = this.\u02B3\u02BC\u02B3\u02B6\u02BD\u02B6\u02B4\u02B5\u02B6\u02B7\u02BB.\u02BD\u02BD\u02BC\u02B4\u02B5\u02C0\u02C0\u02BA\u02B7\u02B4\u02B8(this.player.\u02B9\u02BF\u02B4\u02C1\u02C0\u02B7\u02B6\u02B9\u02BC\u02BD\u02B3);
						startTime = (double)this.player.\u02B3\u02BC\u02B8\u02B9\u02BE\u02BC\u02BC\u02B8\u02BD\u02C1\u02BD.\u02B2\u02B8\u02B7\u02BD\u02B5\u02B7\u02B6\u02B2\u02BF\u02BD\u02C0;
						endTime = (double)note.time;
						timeDif = endTime - startTime;
						this.\u02B5\u02C1\u02B7\u02BA\u02B9\u02BC\u02C1\u02B8\u02BE\u02B6\u02B7 = true;
						this.fill.enabled = true;
						this.timerText.enabled = true;
						this.timerImage.enabled = true;
						while (this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD.songTime < endTime)
						{
							int num = (int)(endTime - this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD.songTime);
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
							this.fill.fillAmount = 1f - (float)((this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD.songTime - startTime) / timeDif);
							if (num <= 2)
							{
								this.\u02B6\u02B6\u02B6\u02B2\u02BC\u02B6\u02B9\u02BE\u02BA\u02BA\u02B5.a = (float)(endTime - this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD.songTime) - 2f;
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

	private IEnumerator \u02BA\u02B9\u02B8\u02BE\u02BD\u02B9\u02BA\u02BF\u02BF\u02BA\u02B3()
	{
		Countdown.\u02C1\u02B2\u02BC\u02B8\u02B8\u02BC\u02B8\u02B8\u02B4\u02BB\u02B8 u02C1_u02B2_u02BC_u02B8_u02B8_u02BC_u02B8_u02B8_u02B4_u02BB_u02B = new Countdown.\u02C1\u02B2\u02BC\u02B8\u02B8\u02BC\u02B8\u02B8\u02B4\u02BB\u02B8(1);
		u02C1_u02B2_u02BC_u02B8_u02B8_u02BC_u02B8_u02B8_u02B4_u02BB_u02B.<>4__this = this;
		return u02C1_u02B2_u02BC_u02B8_u02B8_u02BC_u02B8_u02B8_u02B4_u02BB_u02B;
	}

	private void \u02B4\u02BA\u02BE\u02BB\u02B5\u02BB\u02C1\u02B2\u02B4\u02B2\u02BF()
	{
		if (GlobalVariables.instance.\u02BD\u02B9\u02B7\u02B5\u02BF\u02BC\u02BF\u02BA\u02BE\u02B6\u02B4)
		{
			base.gameObject.SetActive(true);
			return;
		}
		this.timerImage.enabled = false;
		this.timerText.enabled = true;
		this.fill.enabled = false;
		this.\u02B6\u02C0\u02BC\u02BE\u02B2\u02B6\u02B8\u02B9\u02B2\u02B9\u02B2 = SettingsController.measure_countdown;
		this.\u02B3\u02BC\u02B3\u02B6\u02BD\u02B6\u02B4\u02B5\u02B6\u02B7\u02BB = this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD.GetBeatsFromChart;
		base.StartCoroutine(this.\u02B9\u02BF\u02B8\u02BE\u02B7\u02B6\u02C0\u02B2\u02BA\u02BA\u02BE());
	}

	private void \u02BF\u02BA\u02B5\u02B8\u02B5\u02BF\u02B2\u02BF\u02B3\u02BC\u02BA()
	{
		if (GlobalVariables.instance.\u02BD\u02B9\u02B7\u02B5\u02BF\u02BC\u02BF\u02BA\u02BE\u02B6\u02B4)
		{
			base.gameObject.SetActive(false);
			return;
		}
		this.timerImage.enabled = true;
		this.timerText.enabled = true;
		this.fill.enabled = false;
		this.\u02B6\u02C0\u02BC\u02BE\u02B2\u02B6\u02B8\u02B9\u02B2\u02B9\u02B2 = SettingsController.measure_countdown;
		this.\u02B3\u02BC\u02B3\u02B6\u02BD\u02B6\u02B4\u02B5\u02B6\u02B7\u02BB = this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD.GetBeatsFromChart;
		base.StartCoroutine(this.\u02BD\u02B2\u02B5\u02BB\u02C0\u02B4\u02BA\u02B2\u02B3\u02BC\u02B4());
	}

	private IEnumerator \u02BF\u02B5\u02B7\u02B5\u02B5\u02B3\u02BD\u02BD\u02C0\u02B8\u02B6()
	{
		lastMeasure = 0;
		lastSecond = -1;
		lastNote = null;
		for (;;)
		{
			if (this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD.songTime >= (double)this.player.\u02B3\u02BC\u02B8\u02B9\u02BE\u02BC\u02BC\u02B8\u02BD\u02C1\u02BD.\u02B2\u02B8\u02B7\u02BD\u02B5\u02B7\u02B6\u02B2\u02BF\u02BD\u02C0 + 0.20000000298023224)
			{
				Note note = this.player.\u02B9\u02BF\u02B4\u02C1\u02C0\u02B7\u02B6\u02B9\u02BC\u02BD\u02B3;
				if (note == null)
				{
					break;
				}
				if (note != lastNote)
				{
					lastNote = note;
					if ((double)note.time >= this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD.songTime + 10.0)
					{
						noteMeasure = this.\u02B3\u02BC\u02B3\u02B6\u02BD\u02B6\u02B4\u02B5\u02B6\u02B7\u02BB.\u02BD\u02BD\u02BC\u02B4\u02B5\u02C0\u02C0\u02BA\u02B7\u02B4\u02B8(this.player.\u02B9\u02BF\u02B4\u02C1\u02C0\u02B7\u02B6\u02B9\u02BC\u02BD\u02B3);
						startTime = (double)this.player.\u02B3\u02BC\u02B8\u02B9\u02BE\u02BC\u02BC\u02B8\u02BD\u02C1\u02BD.\u02B2\u02B8\u02B7\u02BD\u02B5\u02B7\u02B6\u02B2\u02BF\u02BD\u02C0;
						endTime = (double)note.time;
						timeDif = endTime - startTime;
						this.\u02B5\u02C1\u02B7\u02BA\u02B9\u02BC\u02C1\u02B8\u02BE\u02B6\u02B7 = true;
						this.fill.enabled = true;
						this.timerText.enabled = true;
						this.timerImage.enabled = true;
						while (this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD.songTime < endTime)
						{
							int num = (int)(endTime - this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD.songTime);
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
							this.fill.fillAmount = 1f - (float)((this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD.songTime - startTime) / timeDif);
							if (num <= 2)
							{
								this.\u02B6\u02B6\u02B6\u02B2\u02BC\u02B6\u02B9\u02BE\u02BA\u02BA\u02B5.a = (float)(endTime - this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD.songTime) - 2f;
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

	private IEnumerator \u02B3\u02BD\u02B8\u02C1\u02BB\u02B3\u02BD\u02BB\u02C1\u02B7\u02B5()
	{
		Countdown.\u02C1\u02B2\u02BC\u02B8\u02B8\u02BC\u02B8\u02B8\u02B4\u02BB\u02B8 u02C1_u02B2_u02BC_u02B8_u02B8_u02BC_u02B8_u02B8_u02B4_u02BB_u02B = new Countdown.\u02C1\u02B2\u02BC\u02B8\u02B8\u02BC\u02B8\u02B8\u02B4\u02BB\u02B8(1);
		u02C1_u02B2_u02BC_u02B8_u02B8_u02BC_u02B8_u02B8_u02B4_u02BB_u02B.<>4__this = this;
		return u02C1_u02B2_u02BC_u02B8_u02B8_u02BC_u02B8_u02B8_u02B4_u02BB_u02B;
	}

	private void Start()
	{
		if (GlobalVariables.instance.\u02BD\u02B9\u02B7\u02B5\u02BF\u02BC\u02BF\u02BA\u02BE\u02B6\u02B4)
		{
			base.gameObject.SetActive(false);
			return;
		}
		this.timerImage.enabled = false;
		this.timerText.enabled = false;
		this.fill.enabled = false;
		this.\u02B6\u02C0\u02BC\u02BE\u02B2\u02B6\u02B8\u02B9\u02B2\u02B9\u02B2 = SettingsController.measure_countdown;
		this.\u02B3\u02BC\u02B3\u02B6\u02BD\u02B6\u02B4\u02B5\u02B6\u02B7\u02BB = this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD.GetBeatsFromChart;
		base.StartCoroutine(this.\u02B8\u02BA\u02BD\u02B9\u02BB\u02B3\u02C1\u02B5\u02C0\u02B4\u02C1());
	}

	private IEnumerator \u02BA\u02C1\u02BB\u02BE\u02B5\u02B8\u02B8\u02C0\u02B8\u02BF\u02BF()
	{
		Countdown.\u02C1\u02B2\u02BC\u02B8\u02B8\u02BC\u02B8\u02B8\u02B4\u02BB\u02B8 u02C1_u02B2_u02BC_u02B8_u02B8_u02BC_u02B8_u02B8_u02B4_u02BB_u02B = new Countdown.\u02C1\u02B2\u02BC\u02B8\u02B8\u02BC\u02B8\u02B8\u02B4\u02BB\u02B8(1);
		u02C1_u02B2_u02BC_u02B8_u02B8_u02BC_u02B8_u02B8_u02B4_u02BB_u02B.<>4__this = this;
		return u02C1_u02B2_u02BC_u02B8_u02B8_u02BC_u02B8_u02B8_u02B4_u02BB_u02B;
	}

	private IEnumerator \u02C1\u02BB\u02BC\u02B7\u02B6\u02B2\u02BE\u02B3\u02BF\u02B8\u02B7()
	{
		lastMeasure = 0;
		lastSecond = -1;
		lastNote = null;
		for (;;)
		{
			if (this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD.songTime >= (double)this.player.\u02B3\u02BC\u02B8\u02B9\u02BE\u02BC\u02BC\u02B8\u02BD\u02C1\u02BD.\u02B2\u02B8\u02B7\u02BD\u02B5\u02B7\u02B6\u02B2\u02BF\u02BD\u02C0 + 0.20000000298023224)
			{
				Note note = this.player.\u02B9\u02BF\u02B4\u02C1\u02C0\u02B7\u02B6\u02B9\u02BC\u02BD\u02B3;
				if (note == null)
				{
					break;
				}
				if (note != lastNote)
				{
					lastNote = note;
					if ((double)note.time >= this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD.songTime + 10.0)
					{
						noteMeasure = this.\u02B3\u02BC\u02B3\u02B6\u02BD\u02B6\u02B4\u02B5\u02B6\u02B7\u02BB.\u02BD\u02BD\u02BC\u02B4\u02B5\u02C0\u02C0\u02BA\u02B7\u02B4\u02B8(this.player.\u02B9\u02BF\u02B4\u02C1\u02C0\u02B7\u02B6\u02B9\u02BC\u02BD\u02B3);
						startTime = (double)this.player.\u02B3\u02BC\u02B8\u02B9\u02BE\u02BC\u02BC\u02B8\u02BD\u02C1\u02BD.\u02B2\u02B8\u02B7\u02BD\u02B5\u02B7\u02B6\u02B2\u02BF\u02BD\u02C0;
						endTime = (double)note.time;
						timeDif = endTime - startTime;
						this.\u02B5\u02C1\u02B7\u02BA\u02B9\u02BC\u02C1\u02B8\u02BE\u02B6\u02B7 = true;
						this.fill.enabled = true;
						this.timerText.enabled = true;
						this.timerImage.enabled = true;
						while (this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD.songTime < endTime)
						{
							int num = (int)(endTime - this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD.songTime);
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
							this.fill.fillAmount = 1f - (float)((this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD.songTime - startTime) / timeDif);
							if (num <= 2)
							{
								this.\u02B6\u02B6\u02B6\u02B2\u02BC\u02B6\u02B9\u02BE\u02BA\u02BA\u02B5.a = (float)(endTime - this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD.songTime) - 2f;
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

	private void \u02B5\u02C0\u02BE\u02B8\u02B9\u02B2\u02BD\u02C0\u02BF\u02B3\u02BD()
	{
		if (GlobalVariables.instance.\u02BD\u02B9\u02B7\u02B5\u02BF\u02BC\u02BF\u02BA\u02BE\u02B6\u02B4)
		{
			base.gameObject.SetActive(false);
			return;
		}
		this.timerImage.enabled = false;
		this.timerText.enabled = true;
		this.fill.enabled = false;
		this.\u02B6\u02C0\u02BC\u02BE\u02B2\u02B6\u02B8\u02B9\u02B2\u02B9\u02B2 = SettingsController.measure_countdown;
		this.\u02B3\u02BC\u02B3\u02B6\u02BD\u02B6\u02B4\u02B5\u02B6\u02B7\u02BB = this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD.GetBeatsFromChart;
		base.StartCoroutine(this.\u02B4\u02B8\u02B4\u02C1\u02B8\u02B8\u02B4\u02BB\u02C1\u02B3\u02BF());
	}

	private void \u02C0\u02BC\u02BC\u02BD\u02B8\u02BD\u02BE\u02B6\u02BE\u02BB\u02BB()
	{
		if (GlobalVariables.instance.\u02BD\u02B9\u02B7\u02B5\u02BF\u02BC\u02BF\u02BA\u02BE\u02B6\u02B4)
		{
			base.gameObject.SetActive(false);
			return;
		}
		this.timerImage.enabled = false;
		this.timerText.enabled = true;
		this.fill.enabled = true;
		this.\u02B6\u02C0\u02BC\u02BE\u02B2\u02B6\u02B8\u02B9\u02B2\u02B9\u02B2 = SettingsController.measure_countdown;
		this.\u02B3\u02BC\u02B3\u02B6\u02BD\u02B6\u02B4\u02B5\u02B6\u02B7\u02BB = this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD.GetBeatsFromChart;
		base.StartCoroutine(this.\u02B8\u02BD\u02BF\u02B9\u02B7\u02B5\u02B6\u02B2\u02BB\u02BC\u02B5());
	}

	private void \u02B2\u02BB\u02B6\u02B5\u02B9\u02B8\u02B2\u02B3\u02BF\u02C1\u02BF()
	{
		if (GlobalVariables.instance.\u02BD\u02B9\u02B7\u02B5\u02BF\u02BC\u02BF\u02BA\u02BE\u02B6\u02B4)
		{
			base.gameObject.SetActive(false);
			return;
		}
		this.timerImage.enabled = true;
		this.timerText.enabled = true;
		this.fill.enabled = false;
		this.\u02B6\u02C0\u02BC\u02BE\u02B2\u02B6\u02B8\u02B9\u02B2\u02B9\u02B2 = SettingsController.measure_countdown;
		this.\u02B3\u02BC\u02B3\u02B6\u02BD\u02B6\u02B4\u02B5\u02B6\u02B7\u02BB = this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD.GetBeatsFromChart;
		base.StartCoroutine(this.\u02B8\u02BD\u02BF\u02B9\u02B7\u02B5\u02B6\u02B2\u02BB\u02BC\u02B5());
	}

	private IEnumerator \u02BD\u02B2\u02B5\u02BB\u02C0\u02B4\u02BA\u02B2\u02B3\u02BC\u02B4()
	{
		Countdown.\u02C1\u02B2\u02BC\u02B8\u02B8\u02BC\u02B8\u02B8\u02B4\u02BB\u02B8 u02C1_u02B2_u02BC_u02B8_u02B8_u02BC_u02B8_u02B8_u02B4_u02BB_u02B = new Countdown.\u02C1\u02B2\u02BC\u02B8\u02B8\u02BC\u02B8\u02B8\u02B4\u02BB\u02B8(1);
		u02C1_u02B2_u02BC_u02B8_u02B8_u02BC_u02B8_u02B8_u02B4_u02BB_u02B.<>4__this = this;
		return u02C1_u02B2_u02BC_u02B8_u02B8_u02BC_u02B8_u02B8_u02B4_u02BB_u02B;
	}

	private void \u02B3\u02BB\u02BF\u02B4\u02B9\u02BA\u02B5\u02B5\u02BE\u02BB\u02BE()
	{
		if (GlobalVariables.instance.\u02BD\u02B9\u02B7\u02B5\u02BF\u02BC\u02BF\u02BA\u02BE\u02B6\u02B4)
		{
			base.gameObject.SetActive(false);
			return;
		}
		this.timerImage.enabled = true;
		this.timerText.enabled = false;
		this.fill.enabled = false;
		this.\u02B6\u02C0\u02BC\u02BE\u02B2\u02B6\u02B8\u02B9\u02B2\u02B9\u02B2 = SettingsController.measure_countdown;
		this.\u02B3\u02BC\u02B3\u02B6\u02BD\u02B6\u02B4\u02B5\u02B6\u02B7\u02BB = this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD.GetBeatsFromChart;
		base.StartCoroutine(this.\u02C1\u02BB\u02BC\u02B7\u02B6\u02B2\u02BE\u02B3\u02BF\u02B8\u02B7());
	}

	private IEnumerator \u02B8\u02BD\u02BF\u02B9\u02B7\u02B5\u02B6\u02B2\u02BB\u02BC\u02B5()
	{
		Countdown.\u02C1\u02B2\u02BC\u02B8\u02B8\u02BC\u02B8\u02B8\u02B4\u02BB\u02B8 u02C1_u02B2_u02BC_u02B8_u02B8_u02BC_u02B8_u02B8_u02B4_u02BB_u02B = new Countdown.\u02C1\u02B2\u02BC\u02B8\u02B8\u02BC\u02B8\u02B8\u02B4\u02BB\u02B8(1);
		u02C1_u02B2_u02BC_u02B8_u02B8_u02BC_u02B8_u02B8_u02B4_u02BB_u02B.<>4__this = this;
		return u02C1_u02B2_u02BC_u02B8_u02B8_u02BC_u02B8_u02B8_u02B4_u02BB_u02B;
	}

	private IEnumerator \u02BB\u02BC\u02BA\u02BC\u02BE\u02C1\u02B3\u02B6\u02C0\u02C0\u02B9()
	{
		Countdown.\u02C1\u02B2\u02BC\u02B8\u02B8\u02BC\u02B8\u02B8\u02B4\u02BB\u02B8 u02C1_u02B2_u02BC_u02B8_u02B8_u02BC_u02B8_u02B8_u02B4_u02BB_u02B = new Countdown.\u02C1\u02B2\u02BC\u02B8\u02B8\u02BC\u02B8\u02B8\u02B4\u02BB\u02B8(1);
		u02C1_u02B2_u02BC_u02B8_u02B8_u02BC_u02B8_u02B8_u02B4_u02BB_u02B.<>4__this = this;
		return u02C1_u02B2_u02BC_u02B8_u02B8_u02BC_u02B8_u02B8_u02B4_u02BB_u02B;
	}

	[HideInInspector]
	public GameManager \u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD;

	private Beats \u02B3\u02BC\u02B3\u02B6\u02BD\u02B6\u02B4\u02B5\u02B6\u02B7\u02BB;

	[SerializeField]
	private Image fill;

	[SerializeField]
	private Image timerImage;

	[SerializeField]
	private TextMeshProUGUI timerText;

	[SerializeField]
	private BasePlayer player;

	private Color \u02B6\u02B6\u02B6\u02B2\u02BC\u02B6\u02B9\u02BE\u02BA\u02BA\u02B5 = Color.white;

	private bool \u02B6\u02C0\u02BC\u02BE\u02B2\u02B6\u02B8\u02B9\u02B2\u02B9\u02B2;

	private const int \u02B9\u02B9\u02B8\u02BF\u02B4\u02BD\u02BE\u02C1\u02B9\u02C1\u02C0 = 10;

	private const double \u02B6\u02C0\u02C1\u02B3\u02C0\u02BE\u02B7\u02BD\u02C0\u02BB\u02C1 = 0.20000000298023224;

	[HideInInspector]
	public bool \u02B5\u02C1\u02B7\u02BA\u02B9\u02BC\u02C1\u02B8\u02BE\u02B6\u02B7;
}
