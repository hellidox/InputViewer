using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Cysharp.Text;
using StrikeCore;
using UnityEngine;

public abstract class BaseGuitarPlayer : BasePlayer
{
	public abstract ushort OpenNote { get; }

	private bool \u02BC\u02C0\u02BD\u02C1\u02B7\u02BF\u02BD\u02BB\u02B4\u02B8\u02BB
	{
		get
		{
			return this.\u02B6\u02B3\u02BE\u02B6\u02B3\u02BF\u02BC\u02BA\u02C1\u02B6\u02B3 + this.doubleStrumPrevention > this.gameManager.songTime;
		}
	}

	public override void UpdateRemotePlayer(\u02C0\u02C1\u02B2\u02B3\u02B8\u02B7\u02B2\u02B3\u02C0\u02BF\u02BD \u02C1\u02C0\u02B8\u02BE\u02BF\u02B6\u02BE\u02BA\u02B7\u02BE\u02BA)
	{
		base.UpdateRemotePlayer(\u02C1\u02C0\u02B8\u02BE\u02BF\u02B6\u02BE\u02BA\u02B7\u02BE\u02BA);
		if (this.currentWhammy != \u02C1\u02C0\u02B8\u02BE\u02BF\u02B6\u02BE\u02BA\u02B7\u02BE\u02BA.\u02B9\u02B7\u02BC\u02B8\u02B2\u02B7\u02BC\u02B8\u02B6\u02BA\u02C0)
		{
			this.whammyTimer = 0.25f;
		}
		this.currentWhammy = \u02C1\u02C0\u02B8\u02BE\u02BF\u02B6\u02BE\u02BA\u02B7\u02BE\u02BA.\u02B9\u02B7\u02BC\u02B8\u02B2\u02B7\u02BC\u02B8\u02B6\u02BA\u02C0;
	}

	public override void \u02B8\u02BF\u02C0\u02BE\u02B2\u02BA\u02C0\u02B5\u02BE\u02B7\u02BD()
	{
		GlobalVariables.hasReset = true;
		List<Note> list = this.sustainNotes;
		if (list != null)
		{
			list.Clear();
		}
		List<Note> list2 = this.lingeringSustainNotes;
		if (list2 != null)
		{
			list2.Clear();
		}
		this.\u02B6\u02BA\u02B4\u02BA\u02B7\u02BE\u02BD\u02BE\u02BD\u02B7\u02BB = 0f;
		this.\u02B8\u02BA\u02BD\u02B7\u02B2\u02C0\u02BC\u02B9\u02BA\u02C1\u02C0 = 0f;
		this.\u02BC\u02C0\u02C1\u02BD\u02B7\u02BC\u02B3\u02B8\u02C0\u02B7\u02BF = 0;
		this._ghosts = 0;
		this.\u02C0\u02B6\u02BC\u02B2\u02B9\u02B6\u02BA\u02BE\u02B3\u02BC\u02B3 = 0f;
		this.\u02B2\u02BE\u02BD\u02B7\u02BE\u02B9\u02C0\u02B9\u02B2\u02BC\u02BD = 0f;
		this.\u02BA\u02B2\u02B5\u02B2\u02B6\u02BF\u02B7\u02B6\u02BF\u02C0\u02B7 = 0.0;
		this.\u02B6\u02B3\u02BE\u02B6\u02B3\u02BF\u02BC\u02BA\u02C1\u02B6\u02B3 = double.MinValue;
		if (!this.\u02BC\u02B2\u02B2\u02BB\u02B7\u02B4\u02B3\u02B6\u02C1\u02BC\u02C0 && !this.\u02B4\u02BF\u02BD\u02B8\u02B3\u02BF\u02B9\u02C1\u02B9\u02C1\u02B8)
		{
			this.\u02B6\u02BA\u02B4\u02BA\u02B7\u02BE\u02BD\u02BE\u02BD\u02B7\u02BB = this.\u02B4\u02BE\u02BC\u02B9\u02C1\u02B8\u02BC\u02B8\u02BB\u02BA\u02BC;
		}
		base.\u02B8\u02BF\u02C0\u02BE\u02B2\u02BA\u02C0\u02B5\u02BE\u02B7\u02BD();
	}

	public override void \u02B5\u02B5\u02BA\u02BB\u02B7\u02BF\u02BC\u02B9\u02B5\u02BE\u02BF(\u02C0\u02C1\u02B2\u02B3\u02B8\u02B7\u02B2\u02B3\u02C0\u02BF\u02BD \u02C1\u02C0\u02B8\u02BE\u02BF\u02B6\u02BE\u02BA\u02B7\u02BE\u02BA)
	{
		base.\u02B5\u02B5\u02BA\u02BB\u02B7\u02BF\u02BC\u02B9\u02B5\u02BE\u02BF(\u02C1\u02C0\u02B8\u02BE\u02BF\u02B6\u02BE\u02BA\u02B7\u02BE\u02BA);
		\u02C1\u02C0\u02B8\u02BE\u02BF\u02B6\u02BE\u02BA\u02B7\u02BE\u02BA.\u02B9\u02B7\u02BC\u02B8\u02B2\u02B7\u02BC\u02B8\u02B6\u02BA\u02C0 = this.currentWhammy;
	}

	protected override void Start()
	{
		GlobalVariables.hasReset = true;
		if (this.\u02B4\u02BF\u02BD\u02B8\u02B3\u02BF\u02B9\u02C1\u02B9\u02C1\u02B8)
		{
			this.\u02B2\u02B3\u02B6\u02B9\u02B6\u02B8\u02B3\u02BE\u02BE\u02B3\u02B6 = true;
			this.\u02BF\u02BE\u02B8\u02C1\u02BE\u02C1\u02C0\u02C0\u02BB\u02BB\u02BC = 0f;
			this.hitWindow = 0.0525f;
			this.strumLenienceAmount = 0.066f;
			this.strumLenienceAmountNoNotes = this.hitWindow * 2f / 3f;
			this.\u02B4\u02BE\u02BC\u02B9\u02C1\u02B8\u02BC\u02B8\u02BB\u02BA\u02BC = this.hitWindow * 2f / 2.5f;
			this.\u02C1\u02BE\u02B3\u02BA\u02BE\u02BD\u02B8\u02C0\u02C1\u02BE\u02B5 = this.\u02B4\u02BE\u02BC\u02B9\u02C1\u02B8\u02BC\u02B8\u02BB\u02BA\u02BC;
			this.trackSidebarLeft.\u02BC\u02B5\u02B4\u02BE\u02B5\u02C0\u02C1\u02BE\u02B8\u02BD\u02BF(\u02B3\u02B4\u02B2\u02B4\u02B4\u02B2\u02B8\u02BF\u02BC\u02C0\u02B6.PrecisionMode);
			this.trackSidebarRight.\u02BC\u02B5\u02B4\u02BE\u02B5\u02C0\u02C1\u02BE\u02B8\u02BD\u02BF(\u02B3\u02B4\u02B2\u02B4\u02B4\u02B2\u02B8\u02BF\u02BC\u02C0\u02B6.PrecisionMode);
		}
		else if (this.\u02BC\u02B2\u02B2\u02BB\u02B7\u02B4\u02B3\u02B6\u02C1\u02BC\u02C0)
		{
			this.trackSidebarLeft.\u02BC\u02B5\u02B4\u02BE\u02B5\u02C0\u02C1\u02BE\u02B8\u02BD\u02BF(\u02B3\u02B4\u02B2\u02B4\u02B4\u02B2\u02B8\u02BF\u02BC\u02C0\u02B6.DrunkMode);
			this.trackSidebarRight.\u02BC\u02B5\u02B4\u02BE\u02B5\u02C0\u02C1\u02BE\u02B8\u02BD\u02BF(\u02B3\u02B4\u02B2\u02B4\u02B4\u02B2\u02B8\u02BF\u02BC\u02C0\u02B6.DrunkMode);
		}
		if (this.\u02B3\u02BC\u02B4\u02B8\u02BB\u02B8\u02B2\u02C0\u02C0\u02B3\u02C0)
		{
			this.\u02B5\u02B9\u02C1\u02BC\u02C0\u02BF\u02B3\u02B8\u02BD\u02BB\u02B5 = 0;
		}
		this.\u02B2\u02B9\u02B2\u02B4\u02B2\u02BA\u02B2\u02BA\u02C1\u02BA\u02B5 = true;
		this.sustainNotes = new List<Note>(5);
		this.lingeringSustainNotes = new List<Note>(5);
		this.\u02B3\u02B9\u02C1\u02BD\u02B4\u02B3\u02C0\u02B7\u02B4\u02BB\u02BA = new List<double>(5);
		base.Start();
		this.sustainDropLeniency = (double)SettingsController.sustaindropleniency.GetFloatSecond;
		this.doubleStrumPrevention = (double)SettingsController.doubleStrumPrevention.GetFloatSecond;
		if (this.player.playerProfile.IsGamepadMode() || this.\u02BF\u02C1\u02BF\u02BE\u02C1\u02B2\u02BC\u02BE\u02B3\u02BB\u02B8)
		{
			this.doubleStrumPrevention = 0.0;
		}
	}

	protected void \u02B6\u02BB\u02B4\u02B2\u02B3\u02BE\u02B2\u02B4\u02B6\u02B3\u02B2()
	{
		for (int i = 0; i < this.sustainNotes.Count; i++)
		{
			Note note = this.sustainNotes[i];
			if (note.tickLength == 0 && note.length <= 0f)
			{
				this.\u02B7\u02B9\u02BA\u02BC\u02BD\u02B8\u02B2\u02BC\u02B8\u02BA\u02BF(note, i);
				i--;
			}
		}
	}

	protected void \u02B7\u02B9\u02BA\u02BC\u02BD\u02B8\u02B2\u02BC\u02B8\u02BA\u02BF(Note \u02C0\u02B9\u02C1\u02B8\u02B7\u02BD\u02B2\u02C0\u02BD\u02BE\u02B9, int \u02C0\u02C1\u02BB\u02B9\u02B7\u02C1\u02BC\u02B4\u02BA\u02B8\u02B3)
	{
		this.neckController.\u02B8\u02BA\u02B8\u02B9\u02B7\u02B3\u02B6\u02BD\u02C1\u02BC\u02B8(\u02C0\u02B9\u02C1\u02B8\u02B7\u02BD\u02B2\u02C0\u02BD\u02BE\u02B9._noteMask);
		\u02C0\u02B9\u02C1\u02B8\u02B7\u02BD\u02B2\u02C0\u02BD\u02BE\u02B9.wasMissed = true;
		if (\u02C0\u02B9\u02C1\u02B8\u02B7\u02BD\u02B2\u02C0\u02BD\u02BE\u02B9.tickLength > 0)
		{
			\u02C0\u02B9\u02C1\u02B8\u02B7\u02BD\u02B2\u02C0\u02BD\u02BE\u02B9.isSustaining = false;
		}
		this.sustainNotes.RemoveAt(\u02C0\u02C1\u02BB\u02B9\u02B7\u02C1\u02BC\u02B4\u02BA\u02B8\u02B3);
		this.\u02B3\u02B9\u02C1\u02BD\u02B4\u02B3\u02C0\u02B7\u02B4\u02BB\u02BA.RemoveAt(\u02C0\u02C1\u02BB\u02B9\u02B7\u02C1\u02BC\u02B4\u02BA\u02B8\u02B3);
		if (\u02C0\u02B9\u02C1\u02B8\u02B7\u02BD\u02B2\u02C0\u02BD\u02BE\u02B9.tickLength == 0)
		{
			this.lingeringSustainNotes.Add(\u02C0\u02B9\u02C1\u02B8\u02B7\u02BD\u02B2\u02C0\u02BD\u02BE\u02B9);
		}
		if (!\u02C0\u02B9\u02C1\u02B8\u02B7\u02BD\u02B2\u02C0\u02BD\u02BE\u02B9.\u02B6\u02B3\u02B9\u02B5\u02B6\u02B6\u02BF\u02B3\u02B9\u02BC\u02BA && this.\u02BD\u02B8\u02B6\u02B2\u02B8\u02B6\u02BD\u02C0\u02BD\u02B8\u02BB)
		{
			this.Overstrum(false);
		}
		if ((long)\u02C0\u02B9\u02C1\u02B8\u02B7\u02BD\u02B2\u02C0\u02BD\u02BE\u02B9.tickLength > (long)((ulong)this.gameManager.ticksPerQuarterBeat) && this.sustainNotes.Count == 0)
		{
			BassAudioManager.Instance.MuteInstrument(this.player.playerProfile.moonInstrument, false, -1f);
			this.isMutedAudio = true;
		}
	}

	protected void UpdateSustains()
	{
		if (this.sustainNotes == null)
		{
			return;
		}
		if (this.sustainNotes.Count == 0)
		{
			this.whammyTimer = 0f;
			if (this.lingeringSustainNotes.Count == 0)
			{
				return;
			}
		}
		bool flag = false;
		for (int i = 0; i < this.sustainNotes.Count; i++)
		{
			Note note = this.sustainNotes[i];
			if (note != null)
			{
				if (!flag)
				{
					flag = note.isStarPower;
				}
				if (this.gameManager.currentTick > note.tickPosition && note.tickLength > 0)
				{
					int num;
					if ((long)note.tickLength <= (long)((ulong)this.gameManager.ticksPerQuarterBeat))
					{
						num = note.tickLength;
						note.\u02B6\u02B3\u02B9\u02B5\u02B6\u02B6\u02BF\u02B3\u02B9\u02BC\u02BA = true;
						note.tickLength = 0;
					}
					else
					{
						num = (int)(this.gameManager.currentTick - note.tickPosition);
						note.tickLength -= num;
						if (note.tickLength < 0)
						{
							num += note.tickLength;
							note.tickLength = 0;
						}
					}
					base.AddScore(this.gameManager.GetSustainPoints(ref num, note.\u02B6\u02B3\u02B9\u02B5\u02B6\u02B6\u02BF\u02B3\u02B9\u02BC\u02BA));
					if (!note.\u02B6\u02B3\u02B9\u02B5\u02B6\u02B6\u02BF\u02B3\u02B9\u02BC\u02BA)
					{
						note.tickLength += num;
					}
					note.tickPosition = this.gameManager.currentTick - (uint)num;
				}
				note.length -= this.gameManager.\u02C0\u02BE\u02C1\u02BD\u02C0\u02BC\u02BB\u02B4\u02C1\u02B3\u02B9;
				if ((!this.\u02BA\u02B7\u02B5\u02C1\u02C0\u02B4\u02BE\u02BF\u02BF\u02C0\u02BE(note) && !note.IsExtendedSustain) || ((note._noteMask & this.buttonsPressed) != note._noteMask && (note._noteMask & this.OpenNote) == 0))
				{
					if (this.gameManager.songTime > this.\u02B3\u02B9\u02C1\u02BD\u02B4\u02B3\u02C0\u02B7\u02B4\u02BB\u02BA[i] + this.\u02BE\u02B9\u02BB\u02B6\u02BC\u02B2\u02BD\u02BC\u02C0\u02C1\u02B5)
					{
						this.\u02B7\u02B9\u02BA\u02BC\u02BD\u02B8\u02B2\u02BC\u02B8\u02BA\u02BF(note, i);
						i--;
					}
				}
				else
				{
					this.\u02B3\u02B9\u02C1\u02BD\u02B4\u02B3\u02C0\u02B7\u02B4\u02BB\u02BA[i] = this.gameManager.songTime;
				}
			}
		}
		if (flag && this.whammyTimer > 0f && !GlobalVariables.instance.\u02BD\u02B9\u02B7\u02B5\u02BF\u02BC\u02BF\u02BA\u02BE\u02B6\u02B4)
		{
			this.\u02B8\u02B8\u02B3\u02BD\u02B2\u02BB\u02BF\u02B8\u02B3\u02B8\u02BD(this.gameManager.\u02BE\u02C1\u02BF\u02BD\u02BA\u02B8\u02B6\u02B5\u02B5\u02B8\u02B7(), false);
		}
	}

	protected void \u02C0\u02BB\u02BF\u02B6\u02C1\u02B8\u02B3\u02BB\u02BE\u02BE\u02B3()
	{
		for (int i = this.lingeringSustainNotes.Count - 1; i >= 0; i--)
		{
			Note note = this.lingeringSustainNotes[i];
			if (this.gameManager.songTime > (double)(note.\u02B2\u02B8\u02B7\u02BD\u02B5\u02B7\u02B6\u02B2\u02BF\u02BD\u02C0 + this.hitWindow))
			{
				this.lingeringSustainNotes.RemoveAt(i);
			}
		}
	}

	protected override float \u02B9\u02B9\u02B4\u02C1\u02B9\u02B6\u02B2\u02BA\u02B2\u02B2\u02BF(float \u02BF\u02B3\u02B9\u02B7\u02B3\u02C0\u02BB\u02B4\u02BB\u02B6\u02B4)
	{
		\u02BF\u02B3\u02B9\u02B7\u02B3\u02C0\u02BB\u02B4\u02BB\u02B6\u02B4 *= 1000f;
		return (float)(0.55238 * (double)\u02BF\u02B3\u02B9\u02B7\u02B3\u02C0\u02BB\u02B4\u02BB\u02B6\u02B4 + 42.0) / 1000f;
	}

	public override void \u02B3\u02B6\u02C0\u02C1\u02B6\u02B6\u02BD\u02BD\u02B7\u02BC\u02BC(Note \u02BB\u02B3\u02C1\u02BF\u02B4\u02B3\u02B3\u02B3\u02B6\u02C1\u02B2)
	{
		this.\u02BC\u02C0\u02C1\u02BD\u02B7\u02BC\u02B3\u02B8\u02C0\u02B7\u02BF = 0;
		this.\u02B2\u02B4\u02BC\u02B2\u02B5\u02BC\u02BD\u02B7\u02BA\u02BF\u02B3 = this.\u02B8\u02BA\u02BD\u02B7\u02B2\u02C0\u02BC\u02B9\u02BA\u02C1\u02C0;
		base.\u02B3\u02B6\u02C0\u02C1\u02B6\u02B6\u02BD\u02BD\u02B7\u02BC\u02BC(\u02BB\u02B3\u02C1\u02BF\u02B4\u02B3\u02B3\u02B3\u02B6\u02C1\u02B2);
	}

	protected virtual bool \u02C0\u02B5\u02BA\u02BD\u02B8\u02B6\u02B7\u02B6\u02BE\u02BE\u02B9()
	{
		return !this.\u02B8\u02B3\u02B4\u02B7\u02C0\u02B5\u02BA\u02C0\u02B4\u02B9\u02BB || this.\u02C0\u02BD\u02C1\u02B2\u02B5\u02BD\u02B6\u02C1\u02B9\u02C0\u02BF > 0f || (this.\u02B8\u02B3\u02B4\u02B7\u02C0\u02B5\u02BA\u02C0\u02B4\u02B9\u02BB && this.combo == 0 && this.\u02B2\u02BE\u02BD\u02B7\u02BE\u02B9\u02C0\u02B9\u02B2\u02BC\u02BD <= 0f);
	}

	protected override void \u02BE\u02BC\u02BA\u02BB\u02C0\u02B5\u02B6\u02B8\u02B6\u02BB\u02B3(Note \u02BC\u02BD\u02B6\u02BD\u02B4\u02B3\u02C0\u02C1\u02C1\u02BC\u02B8)
	{
		bool flag = false;
		Note.\u02C0\u02C1\u02C0\u02BC\u02B5\u02BC\u02C0\u02B5\u02B7\u02B8\u02B3 u02C0_u02C1_u02C0_u02BC_u02B5_u02BC_u02C0_u02B5_u02B7_u02B8_u02B;
		foreach (Note note in EnumerableRanges.EnumerateRange<Note>(this.hittableNotes, 0, this.\u02B9\u02BF\u02B7\u02BE\u02B9\u02B5\u02B4\u02B9\u02B6\u02B9\u02B6 - 1))
		{
			if (note.tickPosition > \u02BC\u02BD\u02B6\u02BD\u02B4\u02B3\u02C0\u02C1\u02C1\u02BC\u02B8.tickPosition)
			{
				break;
			}
			u02C0_u02C1_u02C0_u02BC_u02B5_u02BC_u02C0_u02B5_u02B7_u02B8_u02B = note.\u02BE\u02BD\u02B6\u02BB\u02B8\u02BE\u02B3\u02B4\u02BF\u02B3\u02B2.\u02BC\u02C0\u02B8\u02B9\u02B4\u02BB\u02BE\u02B6\u02BC\u02B7\u02C1();
			while (u02C0_u02C1_u02C0_u02BC_u02B5_u02BC_u02C0_u02B5_u02B7_u02B8_u02B.\u02BF\u02B5\u02B7\u02BB\u02B5\u02BB\u02B7\u02B5\u02B6\u02BA\u02BC())
			{
				Note note2 = u02C0_u02C1_u02C0_u02BC_u02B5_u02BC_u02C0_u02B5_u02B7_u02B8_u02B.\u02B9\u02BA\u02BB\u02B4\u02C0\u02B4\u02B6\u02B2\u02B9\u02B3\u02BF;
				if (note2 == \u02BC\u02BD\u02B6\u02BD\u02B4\u02B3\u02C0\u02C1\u02C1\u02BC\u02B8)
				{
					flag = true;
					break;
				}
				if (!note2.\u02BC\u02B9\u02B4\u02B6\u02B5\u02BC\u02BB\u02BC\u02BB\u02B4\u02B7 && note2.tickPosition != \u02BC\u02BD\u02B6\u02BD\u02B4\u02B3\u02C0\u02C1\u02C1\u02BC\u02B8.tickPosition)
				{
					this.\u02B3\u02B6\u02C0\u02C1\u02B6\u02B6\u02BD\u02BD\u02B7\u02BC\u02BC(note2);
				}
			}
			if (flag)
			{
				break;
			}
		}
		this.\u02BB\u02B3\u02B2\u02C0\u02B3\u02BC\u02B3\u02B5\u02BB\u02C0\u02B6 = (float)((double)\u02BC\u02BD\u02B6\u02BD\u02B4\u02B3\u02C0\u02C1\u02C1\u02BC\u02B8.time - this.gameManager.songTime);
		base.\u02B3\u02B2\u02B7\u02C1\u02BF\u02B6\u02BE\u02BA\u02BA\u02BF\u02B2();
		this.\u02BC\u02C0\u02C1\u02BD\u02B7\u02BC\u02B3\u02B8\u02C0\u02B7\u02BF = 0;
		this.\u02B2\u02B4\u02BC\u02B2\u02B5\u02BC\u02BD\u02B7\u02BA\u02BF\u02B3 = this.\u02B8\u02BA\u02BD\u02B7\u02B2\u02C0\u02BC\u02B9\u02BA\u02C1\u02C0;
		if (\u02BC\u02BD\u02B6\u02BD\u02B4\u02B3\u02C0\u02C1\u02C1\u02BC\u02B8.IsHopo && this.\u02C0\u02B5\u02BA\u02BD\u02B8\u02B6\u02B7\u02B6\u02BE\u02BE\u02B9())
		{
			if (this.strumLenienceTimer > 0f)
			{
				this.\u02C0\u02C0\u02C1\u02BF\u02B5\u02B9\u02BA\u02BA\u02BB\u02B8\u02B7 = this.strumLenienceAmountNoNotes;
			}
			else if (this.\u02B4\u02BF\u02BD\u02B8\u02B3\u02BF\u02B9\u02C1\u02B9\u02C1\u02B8)
			{
				this.\u02C0\u02C0\u02C1\u02BF\u02B5\u02B9\u02BA\u02BA\u02BB\u02B8\u02B7 = \u02BC\u02BD\u02B6\u02BD\u02B4\u02B3\u02C0\u02C1\u02C1\u02BC\u02B8.time + this.\u02B2\u02B3\u02BF\u02C1\u02BF\u02BB\u02C1\u02C0\u02C1\u02B6\u02BF / 2f - (float)this.gameManager.songTime;
			}
			else
			{
				this.\u02C0\u02C0\u02C1\u02BF\u02B5\u02B9\u02BA\u02BA\u02BB\u02B8\u02B7 = 0.096f;
			}
			this.\u02C0\u02BD\u02C1\u02B2\u02B5\u02BD\u02B6\u02C1\u02B9\u02C0\u02BF = this.\u02C0\u02C0\u02C1\u02BF\u02B5\u02B9\u02BA\u02BA\u02BB\u02B8\u02B7;
		}
		if (this.\u02B8\u02B3\u02B4\u02B7\u02C0\u02B5\u02BA\u02C0\u02B4\u02B9\u02BB && \u02BC\u02BD\u02B6\u02BD\u02B4\u02B3\u02C0\u02C1\u02C1\u02BC\u02B8.IsHopo)
		{
			this.\u02B2\u02BE\u02BD\u02B7\u02BE\u02B9\u02C0\u02B9\u02B2\u02BC\u02BD = this.\u02B3\u02C0\u02BA\u02BC\u02BB\u02BF\u02B4\u02B5\u02BC\u02BD\u02BC;
		}
		if (\u02BC\u02BD\u02B6\u02BD\u02B4\u02B3\u02C0\u02C1\u02C1\u02BC\u02B8.\u02B8\u02C1\u02BA\u02B2\u02BC\u02B6\u02C0\u02BD\u02BD\u02BA\u02BE || (this.\u02C0\u02B5\u02BA\u02BD\u02B8\u02B6\u02B7\u02B6\u02BE\u02BE\u02B9() && \u02BC\u02BD\u02B6\u02BD\u02B4\u02B3\u02C0\u02C1\u02C1\u02BC\u02B8.IsHopo))
		{
			this.strumLenienceTimer = 0f;
		}
		if (this.sustainNotes.Count > 0 && !\u02BC\u02BD\u02B6\u02BD\u02B4\u02B3\u02C0\u02C1\u02C1\u02BC\u02B8.IsExtendedSustain)
		{
			foreach (Note note3 in this.sustainNotes)
			{
				if ((long)note3.tickLength <= (long)((ulong)this.gameManager.ticksPerQuarterBeat))
				{
					note3.length = 0f;
				}
				note3.wasMissed = true;
				note3.isSustaining = false;
				this.lingeringSustainNotes.Add(note3);
			}
			this.sustainNotes.Clear();
			this.\u02B3\u02B9\u02C1\u02BD\u02B4\u02B3\u02C0\u02B7\u02B4\u02BB\u02BA.Clear();
			this.neckController.EndFretHeldStates();
		}
		u02C0_u02C1_u02C0_u02BC_u02B5_u02BC_u02C0_u02B5_u02B7_u02B8_u02B = \u02BC\u02BD\u02B6\u02BD\u02B4\u02B3\u02C0\u02C1\u02C1\u02BC\u02B8.\u02BE\u02BD\u02B6\u02BB\u02B8\u02BE\u02B3\u02B4\u02BF\u02B3\u02B2.\u02BC\u02C0\u02B8\u02B9\u02B4\u02BB\u02BE\u02B6\u02BC\u02B7\u02C1();
		while (u02C0_u02C1_u02C0_u02BC_u02B5_u02BC_u02C0_u02B5_u02B7_u02B8_u02B.\u02BF\u02B5\u02B7\u02BB\u02B5\u02BB\u02B7\u02B5\u02B6\u02BA\u02BC())
		{
			u02C0_u02C1_u02C0_u02BC_u02B5_u02BC_u02C0_u02B5_u02B7_u02B8_u02B.\u02B9\u02BA\u02BB\u02B4\u02C0\u02B4\u02B6\u02B2\u02B9\u02B3\u02BF.wasHit = true;
		}
		if (this.isMutedAudio)
		{
			BassAudioManager.Instance.MuteInstrument(this.player.playerProfile.moonInstrument, true, -1f);
			this.isMutedAudio = false;
		}
		base.\u02BE\u02BC\u02BA\u02BB\u02C0\u02B5\u02B6\u02B8\u02B6\u02BB\u02B3(\u02BC\u02BD\u02B6\u02BD\u02B4\u02B3\u02C0\u02C1\u02C1\u02BC\u02B8);
		u02C0_u02C1_u02C0_u02BC_u02B5_u02BC_u02C0_u02B5_u02B7_u02B8_u02B = \u02BC\u02BD\u02B6\u02BD\u02B4\u02B3\u02C0\u02C1\u02C1\u02BC\u02B8.\u02BE\u02BD\u02B6\u02BB\u02B8\u02BE\u02B3\u02B4\u02BF\u02B3\u02B2.\u02BC\u02C0\u02B8\u02B9\u02B4\u02BB\u02BE\u02B6\u02BC\u02B7\u02C1();
		while (u02C0_u02C1_u02C0_u02BC_u02B5_u02BC_u02C0_u02B5_u02B7_u02B8_u02B.\u02BF\u02B5\u02B7\u02BB\u02B5\u02BB\u02B7\u02B5\u02B6\u02BA\u02BC())
		{
			Note note4 = u02C0_u02C1_u02C0_u02BC_u02B5_u02BC_u02C0_u02B5_u02B7_u02B8_u02B.\u02B9\u02BA\u02BB\u02B4\u02C0\u02B4\u02B6\u02B2\u02B9\u02B3\u02BF;
			this.\u02BB\u02B4\u02B5\u02B9\u02B7\u02B5\u02C1\u02C0\u02B6\u02C1\u02BD(note4, 50);
			if (note4.length > 0f)
			{
				this.\u02BA\u02BE\u02B7\u02B7\u02B7\u02B4\u02B4\u02B9\u02B4\u02BD\u02B9(note4);
			}
			this.neckController.PlayFret(note4, this.\u02C0\u02B4\u02B5\u02B8\u02B6\u02B8\u02B2\u02BE\u02B6\u02B5\u02B2, base.\u02B4\u02BE\u02B5\u02B5\u02B4\u02BE\u02B3\u02C0\u02BC\u02BA\u02B9);
		}
	}

	protected virtual void \u02BA\u02BE\u02B7\u02B7\u02B7\u02B4\u02B4\u02B9\u02B4\u02BD\u02B9(Note \u02BC\u02BD\u02B6\u02BD\u02B4\u02B3\u02C0\u02C1\u02C1\u02BC\u02B8)
	{
		for (int i = 0; i < this.sustainNotes.Count; i++)
		{
			Note note = this.sustainNotes[i];
			if ((note._noteMask & \u02BC\u02BD\u02B6\u02BD\u02B4\u02B3\u02C0\u02C1\u02C1\u02BC\u02B8._noteMask) != 0)
			{
				this.\u02B7\u02B9\u02BA\u02BC\u02BD\u02B8\u02B2\u02BC\u02B8\u02BA\u02BF(note, i);
			}
		}
		this.sustainNotes.Add(\u02BC\u02BD\u02B6\u02BD\u02B4\u02B3\u02C0\u02C1\u02C1\u02BC\u02B8);
		this.\u02B3\u02B9\u02C1\u02BD\u02B4\u02B3\u02C0\u02B7\u02B4\u02BB\u02BA.Add(this.gameManager.songTime);
		\u02BC\u02BD\u02B6\u02BD\u02B4\u02B3\u02C0\u02C1\u02C1\u02BC\u02B8.isSustaining = true;
		float num = (float)((double)\u02BC\u02BD\u02B6\u02BD\u02B4\u02B3\u02C0\u02C1\u02C1\u02BC\u02B8.time - this.gameManager.songTime);
		\u02BC\u02BD\u02B6\u02BD\u02B4\u02B3\u02C0\u02C1\u02C1\u02BC\u02B8.length += num;
	}

	protected override void Update()
	{
		if (!this.player.playerProfile.isRemotePlayer)
		{
			BaseGuitarPlayer.instance = this;
			this.minputs = this.Inputs;
			this.minputs.su = this.player.player.GetButton(5);
			this.minputs.sd = this.player.player.GetButton(14);
			float unscaledDeltaTime = Time.unscaledDeltaTime;
			float num = 0f;
			if (!this.lastinputs.g && this.minputs.g)
			{
				this.minputs.gcount = this.minputs.gcount + 1;
				this.minputs.gptime = unscaledDeltaTime + num;
			}
			if (this.lastinputs.g && this.minputs.g)
			{
				this.minputs.gptime = this.minputs.gptime + unscaledDeltaTime;
			}
			if (!this.lastinputs.r && this.minputs.r)
			{
				this.minputs.rcount = this.minputs.rcount + 1;
				this.minputs.rptime = unscaledDeltaTime + num;
			}
			if (this.lastinputs.r && this.minputs.r)
			{
				this.minputs.rptime = this.minputs.rptime + unscaledDeltaTime;
			}
			if (!this.lastinputs.y && this.minputs.y)
			{
				this.minputs.ycount = this.minputs.ycount + 1;
				this.minputs.yptime = unscaledDeltaTime + num;
			}
			if (this.lastinputs.y && this.minputs.y)
			{
				this.minputs.yptime = this.minputs.yptime + unscaledDeltaTime;
			}
			if (!this.lastinputs.b && this.minputs.b)
			{
				this.minputs.bcount = this.minputs.bcount + 1;
				this.minputs.bptime = unscaledDeltaTime + num;
			}
			if (this.lastinputs.b && this.minputs.b)
			{
				this.minputs.bptime = this.minputs.bptime + unscaledDeltaTime;
			}
			if (!this.lastinputs.o && this.minputs.o)
			{
				this.minputs.ocount = this.minputs.ocount + 1;
				this.minputs.optime = unscaledDeltaTime + num;
			}
			if (this.lastinputs.o && this.minputs.o)
			{
				this.minputs.optime = this.minputs.optime + unscaledDeltaTime;
			}
			if (!this.lastinputs.su && this.minputs.su)
			{
				this.minputs.sucount = this.minputs.sucount + 1;
				this.minputs.sutime = unscaledDeltaTime + num;
			}
			if (this.lastinputs.su && this.minputs.su)
			{
				this.minputs.sutime = this.minputs.sutime + unscaledDeltaTime;
			}
			if (!this.lastinputs.sd && this.minputs.sd)
			{
				this.minputs.sdcount = this.minputs.sdcount + 1;
				this.minputs.sdtime = unscaledDeltaTime + num;
			}
			if (this.lastinputs.sd && this.minputs.sd)
			{
				this.minputs.sdtime = this.minputs.sdtime + unscaledDeltaTime;
			}
			this.lastinputs = this.minputs;
		}
		if (!this.\u02B3\u02B3\u02BD\u02C0\u02B6\u02B7\u02C0\u02BA\u02BB\u02B9\u02B9 && this.gameManager.\u02C0\u02C0\u02BA\u02BF\u02B3\u02BA\u02B5\u02BF\u02B9\u02BB\u02B5)
		{
			this.\u02BE\u02B9\u02BB\u02B6\u02BC\u02B2\u02BD\u02BC\u02C0\u02C1\u02B5 = this.\u02B7\u02B6\u02B4\u02B8\u02BD\u02B2\u02BF\u02B6\u02B7\u02C1\u02BD;
			this.\u02B3\u02B3\u02BD\u02C0\u02B6\u02B7\u02C0\u02BA\u02BB\u02B9\u02B9 = true;
			this.\u02BA\u02B2\u02B5\u02B2\u02B6\u02BF\u02B7\u02B6\u02BF\u02C0\u02B7 = this.gameManager.songTime;
		}
		if (this.\u02B3\u02B3\u02BD\u02C0\u02B6\u02B7\u02C0\u02BA\u02BB\u02B9\u02B9 && this.gameManager.songTime >= this.\u02BE\u02B9\u02BB\u02B6\u02BC\u02B2\u02BD\u02BC\u02C0\u02C1\u02B5 + this.\u02BA\u02B2\u02B5\u02B2\u02B6\u02BF\u02B7\u02B6\u02BF\u02C0\u02B7)
		{
			this.\u02BE\u02B9\u02BB\u02B6\u02BC\u02B2\u02BD\u02BC\u02C0\u02C1\u02B5 = this.sustainDropLeniency;
			this.\u02B3\u02B3\u02BD\u02C0\u02B6\u02B7\u02C0\u02BA\u02BB\u02B9\u02B9 = false;
		}
		if (this.\u02B2\u02B4\u02BC\u02B2\u02B5\u02BC\u02BD\u02B7\u02BA\u02BF\u02B3 > 0f)
		{
			this.\u02B2\u02B4\u02BC\u02B2\u02B5\u02BC\u02BD\u02B7\u02BA\u02BF\u02B3 -= Time.deltaTime;
			if (this.\u02B2\u02B4\u02BC\u02B2\u02B5\u02BC\u02BD\u02B7\u02BA\u02BF\u02B3 <= 0f)
			{
				this.\u02B2\u02B4\u02BC\u02B2\u02B5\u02BC\u02BD\u02B7\u02BA\u02BF\u02B3 = 0f;
			}
		}
		if (this.\u02C0\u02C0\u02C1\u02BF\u02B5\u02B9\u02BA\u02BA\u02BB\u02B8\u02B7 > 0f)
		{
			this.\u02C0\u02C0\u02C1\u02BF\u02B5\u02B9\u02BA\u02BA\u02BB\u02B8\u02B7 -= Time.deltaTime;
		}
		if (this.\u02C0\u02B6\u02BC\u02B2\u02B9\u02B6\u02BA\u02BE\u02B3\u02BC\u02B3 > 0f)
		{
			this.\u02C0\u02B6\u02BC\u02B2\u02B9\u02B6\u02BA\u02BE\u02B3\u02BC\u02B3 -= Time.deltaTime;
			if (this.\u02C0\u02B6\u02BC\u02B2\u02B9\u02B6\u02BA\u02BE\u02B3\u02BC\u02B3 <= 0f)
			{
				this.\u02BC\u02B8\u02B5\u02BB\u02BB\u02B7\u02C1\u02B6\u02BC\u02B4\u02BE = 0;
				this.\u02C0\u02B6\u02BC\u02B2\u02B9\u02B6\u02BA\u02BE\u02B3\u02BC\u02B3 = 0f;
			}
		}
		if (this.strumLenienceTimer > 0f)
		{
			if (this.sl_nonotes)
			{
				if (this.strumLenienceTimer > this.strumLenienceAmountNoNotes - 0.01f)
				{
					this.lenienceFirstTick = false;
				}
				else if (this.strumLenienceTimer > this.strumLenienceAmount - 0.01f)
				{
					this.lenienceFirstTick = false;
				}
			}
			if (this.lenienceFirstTick)
			{
				GlobalVariables.neededLeniency = true;
			}
			this.strumLenienceTimer -= Time.deltaTime;
			if (this.strumLenienceTimer <= 0f)
			{
				this.Overstrum(true);
				this.strumLenienceTimer = 0f;
			}
			this.lenienceFirstTick = true;
		}
		if (this.\u02B6\u02BA\u02B4\u02BA\u02B7\u02BE\u02BD\u02BE\u02BD\u02B7\u02BB > 0f && (this.\u02B4\u02BF\u02BD\u02B8\u02B3\u02BF\u02B9\u02C1\u02B9\u02C1\u02B8 || this.\u02BC\u02B2\u02B2\u02BB\u02B7\u02B4\u02B3\u02B6\u02C1\u02BC\u02C0))
		{
			this.\u02B6\u02BA\u02B4\u02BA\u02B7\u02BE\u02BD\u02BE\u02BD\u02B7\u02BB -= Time.deltaTime;
			if (this.\u02B6\u02BA\u02B4\u02BA\u02B7\u02BE\u02BD\u02BE\u02BD\u02B7\u02BB <= 0f)
			{
				this.\u02B6\u02BA\u02B4\u02BA\u02B7\u02BE\u02BD\u02BE\u02BD\u02B7\u02BB = 0f;
			}
		}
		if (this.\u02BC\u02B2\u02B2\u02BB\u02B7\u02B4\u02B3\u02B6\u02C1\u02BC\u02C0 && this.\u02B9\u02C0\u02B3\u02C0\u02B2\u02C1\u02B8\u02C1\u02B5\u02B6\u02B3 > 0f)
		{
			this.\u02B9\u02C0\u02B3\u02C0\u02B2\u02C1\u02B8\u02C1\u02B5\u02B6\u02B3 -= Time.deltaTime;
			if (this.\u02B9\u02C0\u02B3\u02C0\u02B2\u02C1\u02B8\u02C1\u02B5\u02B6\u02B3 <= 0f)
			{
				this.\u02B9\u02C0\u02B3\u02C0\u02B2\u02C1\u02B8\u02C1\u02B5\u02B6\u02B3 = 0f;
			}
		}
		if (this.\u02B8\u02B3\u02B4\u02B7\u02C0\u02B5\u02BA\u02C0\u02B4\u02B9\u02BB && this.\u02B2\u02BE\u02BD\u02B7\u02BE\u02B9\u02C0\u02B9\u02B2\u02BC\u02BD > 0f)
		{
			this.\u02B2\u02BE\u02BD\u02B7\u02BE\u02B9\u02C0\u02B9\u02B2\u02BC\u02BD -= Time.deltaTime;
			if (this.\u02B2\u02BE\u02BD\u02B7\u02BE\u02B9\u02C0\u02B9\u02B2\u02BC\u02BD <= 0f)
			{
				this.\u02B2\u02BE\u02BD\u02B7\u02BE\u02B9\u02C0\u02B9\u02B2\u02BC\u02BD = 0f;
			}
		}
		if (this.\u02B8\u02B3\u02B4\u02B7\u02C0\u02B5\u02BA\u02C0\u02B4\u02B9\u02BB && this.\u02C0\u02BD\u02C1\u02B2\u02B5\u02BD\u02B6\u02C1\u02B9\u02C0\u02BF > 0f)
		{
			this.\u02C0\u02BD\u02C1\u02B2\u02B5\u02BD\u02B6\u02C1\u02B9\u02C0\u02BF -= Time.deltaTime;
			if (this.\u02C0\u02BD\u02C1\u02B2\u02B5\u02BD\u02B6\u02C1\u02B9\u02C0\u02BF <= 0f)
			{
				this.\u02C0\u02BD\u02C1\u02B2\u02B5\u02BD\u02B6\u02C1\u02B9\u02C0\u02BF = 0f;
			}
		}
		base.Update();
		this.\u02B6\u02BB\u02B4\u02B2\u02B3\u02BE\u02B2\u02B4\u02B6\u02B3\u02B2();
		this.\u02BF\u02B6\u02B2\u02B3\u02B2\u02B4\u02B4\u02B5\u02B4\u02B2\u02B7();
		this.UpdateSustains();
		this.\u02C0\u02BB\u02BF\u02B6\u02C1\u02B8\u02B3\u02BB\u02BE\u02BE\u02B3();
		if (this.whammyTimer > 0f)
		{
			this.whammyTimer -= Time.deltaTime;
		}
		if (!this.gameManager.\u02C0\u02C0\u02BA\u02BF\u02B3\u02BA\u02B5\u02BF\u02B9\u02BB\u02B5)
		{
			this.noteRenderer.\u02C0\u02C0\u02BA\u02B9\u02B7\u02B3\u02BB\u02B8\u02B8\u02B2\u02B3 = this.sustainNotes;
		}
	}

	protected override void UpdateInputs()
	{
		float axis = this.player.player.GetAxis(7);
		bool button = this.player.player.GetButton(6);
		if (this.gameManager.\u02B2\u02B5\u02B8\u02C0\u02B4\u02B2\u02B2\u02BD\u02B2\u02B3\u02C1)
		{
			if (button)
			{
				this.\u02B4\u02BA\u02BA\u02B3\u02C0\u02BC\u02BD\u02BA\u02B5\u02B2\u02B8 = true;
			}
			if (this.player.playerProfile.tilt && axis >= 1f)
			{
				this.\u02B6\u02C0\u02BA\u02BF\u02B7\u02B8\u02B2\u02B2\u02B5\u02B6\u02B2 = true;
			}
		}
		else
		{
			if (!button)
			{
				this.\u02B4\u02BA\u02BA\u02B3\u02C0\u02BC\u02BD\u02BA\u02B5\u02B2\u02B8 = false;
			}
			if (axis < 0.75f)
			{
				this.\u02B6\u02C0\u02BA\u02BF\u02B7\u02B8\u02B2\u02B2\u02B5\u02B6\u02B2 = false;
			}
		}
		if (base.\u02BF\u02C0\u02BA\u02B6\u02B7\u02C0\u02B2\u02BE\u02BC\u02BA\u02B2 && ((!this.\u02B4\u02BA\u02BA\u02B3\u02C0\u02BC\u02BD\u02BA\u02B5\u02B2\u02B8 && button) || (!this.\u02B6\u02C0\u02BA\u02BF\u02B7\u02B8\u02B2\u02B2\u02B5\u02B6\u02B2 && this.player.playerProfile.tilt && axis >= 1f)))
		{
			base.\u02B9\u02BC\u02B2\u02B7\u02BD\u02B2\u02B2\u02B2\u02B2\u02BE\u02BE();
		}
		bool flag = false;
		bool flag2 = true;
		if (this.player.playerProfile.IsGamepadMode() && this.strumLenienceTimer == 0f)
		{
			if (this.player.player.GetButtonDown(5))
			{
				this.buttonsPressed |= this.OpenNote;
			}
			if (this.player.player.GetButtonDown(14))
			{
				this.buttonsPressed |= this.OpenNote;
			}
			flag = this.buttonsPressed > this.\u02BA\u02BD\u02B4\u02BB\u02B8\u02C1\u02B2\u02B3\u02B2\u02BC\u02B3;
		}
		if (!this.player.playerProfile.IsGamepadMode())
		{
			if (this.player.player.GetButtonDown(5))
			{
				flag = true;
				flag2 = true;
			}
			if (this.player.player.GetButtonDown(14))
			{
				flag = true;
				flag2 = false;
			}
		}
		if (this.\u02B4\u02BA\u02B4\u02BF\u02B6\u02B9\u02B5\u02BA\u02C0\u02BD\u02BB.\u02B5\u02C1\u02B7\u02BA\u02B9\u02BC\u02C1\u02B8\u02BE\u02B6\u02B7)
		{
			flag = false;
		}
		this.currentWhammy = this.player.player.GetAxis(17);
		if (this.player.player.GetButton(30))
		{
			this.currentWhammy = 1f;
		}
		if (this.sustainNotes.Count > 0 && this.\u02B2\u02BF\u02BD\u02B2\u02C0\u02BD\u02BA\u02B2\u02BC\u02B5\u02B6)
		{
			if (!this.isMutedAudio)
			{
				float num = Mathf.Abs(this.currentWhammy);
				BassAudioManager.Instance.\u02B2\u02B2\u02B9\u02BA\u02B2\u02B2\u02BA\u02B8\u02BC\u02B9\u02BF(this.player.playerProfile.moonInstrument, num);
			}
		}
		else if (!this.isMutedAudio)
		{
			BassAudioManager.Instance.\u02B2\u02B2\u02B9\u02BA\u02B2\u02B2\u02BA\u02B8\u02BC\u02B9\u02BF(this.player.playerProfile.moonInstrument, 0f);
		}
		if (this.currentWhammy != this.\u02BF\u02B7\u02C1\u02BF\u02B6\u02BB\u02B7\u02B2\u02B6\u02B7\u02B9)
		{
			this.whammyTimer = 0.25f;
		}
		if (this.player.player.GetButtonDown(30))
		{
			this.whammyTimer = 0.75f;
		}
		this.\u02BF\u02B7\u02C1\u02BF\u02B6\u02BB\u02B7\u02B2\u02B6\u02B7\u02B9 = this.currentWhammy;
		this.\u02BA\u02BD\u02B4\u02BB\u02B8\u02C1\u02B2\u02B3\u02B2\u02BC\u02B3 = this.buttonsPressed;
		if (this.buttonsPressed == 0)
		{
			this.buttonsPressed |= this.OpenNote;
		}
		Note note;
		if (this.\u02B9\u02BF\u02B7\u02BE\u02B9\u02B5\u02B4\u02B9\u02B6\u02B9\u02B6 > 0)
		{
			note = this.hittableNotes[0];
		}
		else
		{
			note = this.Notes.\u02B5\u02B5\u02B9\u02B6\u02BF\u02C0\u02B9\u02B8\u02B8\u02B8\u02C0(this.gameManager.currentTick, this.\u02BA\u02B8\u02B6\u02BF\u02B7\u02BF\u02BB\u02BC\u02B9\u02B5\u02B9);
		}
		int num2 = this.Notes.\u02B2\u02B4\u02B6\u02B8\u02C0\u02C0\u02B4\u02C0\u02B2\u02BE\u02BD(note, this.\u02BA\u02B8\u02B6\u02BF\u02B7\u02BF\u02BB\u02BC\u02B9\u02B5\u02B9);
		if (this.buttonsPressed != this.\u02C0\u02B4\u02BD\u02BF\u02B8\u02B9\u02B4\u02BE\u02BE\u02B7\u02B3)
		{
			if (note != null && num2 > 0)
			{
				ushort num3 = note.noteMask;
				int num4 = (int)(this.\u02C0\u02B4\u02BD\u02BF\u02B8\u02B9\u02B4\u02BE\u02BE\u02B7\u02B3 & this.buttonsPressed);
				num4 = (int)this.buttonsPressed ^ num4;
				num4 &= (int)(~(int)this.\u02BC\u02B8\u02B5\u02BB\u02BB\u02B7\u02C1\u02B6\u02BC\u02B4\u02BE);
				if (this.combo > 0 && this.buttonsPressed != this.OpenNote && this.buttonsPressed != num3 && num4 != 0 && ((int)num3 & num4) == 0)
				{
					this.\u02BC\u02C0\u02C1\u02BD\u02B7\u02BC\u02B3\u02B8\u02C0\u02B7\u02BF++;
					this._ghosts++;
				}
				int num5 = (int)(this.\u02C0\u02B4\u02BD\u02BF\u02B8\u02B9\u02B4\u02BE\u02BE\u02B7\u02B3 & ~(int)this.OpenNote);
				int num6 = (int)(this.buttonsPressed & ~(int)this.OpenNote);
				int num7 = num5 ^ num6;
				num7 &= (int)this.\u02C0\u02B4\u02BD\u02BF\u02B8\u02B9\u02B4\u02BE\u02BE\u02B7\u02B3;
				if (num7 != 0)
				{
					this.\u02BC\u02B8\u02B5\u02BB\u02BB\u02B7\u02C1\u02B6\u02BC\u02B4\u02BE |= (ushort)num7;
					this.\u02C0\u02B6\u02BC\u02B2\u02B9\u02B6\u02BA\u02BE\u02B3\u02BC\u02B3 = this.\u02C0\u02BE\u02C1\u02BB\u02C0\u02BE\u02B2\u02B5\u02B8\u02BA\u02BF;
				}
				if (this.\u02C0\u02B6\u02BC\u02B2\u02B9\u02B6\u02BA\u02BE\u02B3\u02BC\u02B3 <= 0f)
				{
					this.\u02BC\u02B8\u02B5\u02BB\u02BB\u02B7\u02C1\u02B6\u02BC\u02B4\u02BE = 0;
				}
			}
			this.\u02C0\u02B4\u02BD\u02BF\u02B8\u02B9\u02B4\u02BE\u02BE\u02B7\u02B3 = this.buttonsPressed;
			if (this.\u02BC\u02B2\u02B2\u02BB\u02B7\u02B4\u02B3\u02B6\u02C1\u02BC\u02C0 && note != null && (note.IsTap || (note.IsPureHopo && (this.combo != 0 || (GlobalVariables.instance.\u02BD\u02B9\u02B7\u02B5\u02BF\u02BC\u02BF\u02BA\u02BE\u02B6\u02B4 && !this.\u02B7\u02BD\u02C1\u02B3\u02BD\u02B5\u02B6\u02B8\u02B8\u02B2\u02BF)))) && this.\u02BA\u02B7\u02B5\u02C1\u02C0\u02B4\u02BE\u02BF\u02BF\u02C0\u02BE(note) && note.IsHopo && !note.\u02C1\u02B9\u02BD\u02B6\u02B7\u02BA\u02B5\u02B7\u02BA\u02B6\u02C0)
			{
				note.\u02C1\u02B9\u02BD\u02B6\u02B7\u02BA\u02B5\u02B7\u02BA\u02B6\u02C0 = true;
				this.\u02B9\u02C0\u02B3\u02C0\u02B2\u02C1\u02B8\u02C1\u02B5\u02B6\u02B3 = note.time - (float)this.gameManager.songTime;
			}
			this.\u02B6\u02BA\u02B4\u02BA\u02B7\u02BE\u02BD\u02BE\u02BD\u02B7\u02BB = this.\u02B4\u02BE\u02BC\u02B9\u02C1\u02B8\u02BC\u02B8\u02BB\u02BA\u02BC;
		}
		if (this.\u02BF\u02C1\u02BF\u02BE\u02C1\u02B2\u02BC\u02BE\u02B3\u02BB\u02B8 && ((!this.\u02B3\u02BC\u02B4\u02B8\u02BB\u02B8\u02B2\u02C0\u02C0\u02B3\u02C0 && !this.\u02B8\u02B3\u02B4\u02B7\u02C0\u02B5\u02BA\u02C0\u02B4\u02B9\u02BB) || ((this.\u02B3\u02BC\u02B4\u02B8\u02BB\u02B8\u02B2\u02C0\u02C0\u02B3\u02C0 || this.\u02B8\u02B3\u02B4\u02B7\u02C0\u02B5\u02BA\u02C0\u02B4\u02B9\u02BB) && note != null && !note.IsHopo) || this.combo == 0))
		{
			flag = true;
		}
		if (flag && (flag2 != this.\u02C1\u02B8\u02B7\u02BB\u02B4\u02BE\u02BB\u02B5\u02B3\u02B6\u02B2 || !this.\u02BC\u02C0\u02BD\u02C1\u02B7\u02BF\u02BD\u02BB\u02B4\u02B8\u02BB))
		{
			this.\u02B6\u02B3\u02BE\u02B6\u02B3\u02BF\u02BC\u02BA\u02C1\u02B6\u02B3 = this.gameManager.songTime;
			this.\u02C1\u02B8\u02B7\u02BB\u02B4\u02BE\u02BB\u02B5\u02B3\u02B6\u02B2 = flag2;
			if (this.\u02C0\u02B5\u02BA\u02BD\u02B8\u02B6\u02B7\u02B6\u02BE\u02BE\u02B9() && this.\u02C0\u02C0\u02C1\u02BF\u02B5\u02B9\u02BA\u02BA\u02BB\u02B8\u02B7 > 0f)
			{
				this.strumLenienceTimer = 0f;
				if (this.\u02B4\u02BF\u02BD\u02B8\u02B3\u02BF\u02B9\u02C1\u02B9\u02C1\u02B8)
				{
					this.\u02C0\u02C0\u02C1\u02BF\u02B5\u02B9\u02BA\u02BA\u02BB\u02B8\u02B7 = 0f;
					return;
				}
			}
			else
			{
				if (this.\u02C0\u02B5\u02BA\u02BD\u02B8\u02B6\u02B7\u02B6\u02BE\u02BE\u02B9() || (this.\u02B8\u02B3\u02B4\u02B7\u02C0\u02B5\u02BA\u02C0\u02B4\u02B9\u02BB && note.\u02B8\u02C1\u02BA\u02B2\u02BC\u02B6\u02C0\u02BD\u02BD\u02BA\u02BE))
				{
					this.\u02B6\u02BA\u02B4\u02BA\u02B7\u02BE\u02BD\u02BE\u02BD\u02B7\u02BB = this.\u02C1\u02BE\u02B3\u02BA\u02BE\u02BD\u02B8\u02C0\u02C1\u02BE\u02B5;
				}
				if (this.strumLenienceTimer > 0f)
				{
					this.Overstrum(true);
				}
				bool flag3 = false;
				if (note != null)
				{
					double num8 = (double)this.\u02B2\u02B3\u02BF\u02C1\u02BF\u02BB\u02C1\u02C0\u02C1\u02B6\u02BF;
					double num9 = (double)note.time - this.gameManager.songTime;
					float num10 = (float)(num9 - num8);
					float num11 = (float)(num9 + num8);
					if (num10 <= this.strumLenienceAmountNoNotes)
					{
						this.strumLenienceTimer = Mathf.Min(num11, this.strumLenienceAmount);
						flag3 = true;
					}
				}
				if (!flag3)
				{
					this.strumLenienceTimer = this.strumLenienceAmountNoNotes;
				}
			}
		}
	}

	private void \u02BF\u02B6\u02B2\u02B3\u02B2\u02B4\u02B4\u02B5\u02B4\u02B2\u02B7()
	{
		if (this.\u02B9\u02BF\u02B7\u02BE\u02B9\u02B5\u02B4\u02B9\u02B6\u02B9\u02B6 > 0)
		{
			this.\u02C0\u02C0\u02C1\u02BF\u02B5\u02B9\u02BA\u02BA\u02BB\u02B8\u02B7 = 0f;
			BaseGuitarPlayer.\u02B6\u02B5\u02B9\u02B2\u02B4\u02B9\u02B7\u02BE\u02B7\u02B9\u02B2 u02B6_u02B5_u02B9_u02B2_u02B4_u02B9_u02B7_u02BE_u02B7_u02B9_u02B;
			u02B6_u02B5_u02B9_u02B2_u02B4_u02B9_u02B7_u02BE_u02B7_u02B9_u02B.hitIndex = 0;
			while (u02B6_u02B5_u02B9_u02B2_u02B4_u02B9_u02B7_u02BE_u02B7_u02B9_u02B.hitIndex < this.\u02B9\u02BF\u02B7\u02BE\u02B9\u02B5\u02B4\u02B9\u02B6\u02B9\u02B6)
			{
				Note note = this.hittableNotes[u02B6_u02B5_u02B9_u02B2_u02B4_u02B9_u02B7_u02BE_u02B7_u02B9_u02B.hitIndex];
				if (!note.\u02BC\u02B9\u02B4\u02B6\u02B5\u02BC\u02BB\u02BC\u02BB\u02B4\u02B7)
				{
					bool flag = false;
					if (!this.\u02B4\u02BF\u02BD\u02B8\u02B3\u02BF\u02B9\u02C1\u02B9\u02C1\u02B8 && !this.\u02B3\u02BC\u02B4\u02B8\u02BB\u02B8\u02B2\u02C0\u02C0\u02B3\u02C0)
					{
						flag = true;
					}
					else if (this.\u02BC\u02C0\u02C1\u02BD\u02B7\u02BC\u02B3\u02B8\u02C0\u02B7\u02BF <= this.\u02B5\u02B9\u02C1\u02BC\u02C0\u02BF\u02B3\u02B8\u02BD\u02BB\u02B5)
					{
						flag = true;
					}
					if (this.\u02B6\u02BA\u02B4\u02BA\u02B7\u02BE\u02BD\u02BE\u02BD\u02B7\u02BB > 0f && flag && ((note.IsTap && (((!this.\u02B7\u02BD\u02C1\u02B3\u02BD\u02B5\u02B6\u02B8\u02B8\u02B2\u02BF) ? BaseGuitarPlayer.\u02B3\u02B9\u02B2\u02BB\u02BE\u02BF\u02B7\u02C0\u02B2\u02B7\u02BF(ref u02B6_u02B5_u02B9_u02B2_u02B4_u02B9_u02B7_u02BE_u02B7_u02B9_u02B) : (!this.\u02B9\u02B7\u02B5\u02BD\u02BB\u02B8\u02C0\u02B2\u02C0\u02C1\u02B9())) || BaseGuitarPlayer.\u02B3\u02B9\u02B2\u02BB\u02BE\u02BF\u02B7\u02C0\u02B2\u02B7\u02BF(ref u02B6_u02B5_u02B9_u02B2_u02B4_u02B9_u02B7_u02BE_u02B7_u02B9_u02B))) || (note.IsPureHopo && BaseGuitarPlayer.\u02B3\u02B9\u02B2\u02BB\u02BE\u02BF\u02B7\u02C0\u02B2\u02B7\u02BF(ref u02B6_u02B5_u02B9_u02B2_u02B4_u02B9_u02B7_u02BE_u02B7_u02B9_u02B) && (this.\u02B9\u02B7\u02B5\u02BD\u02BB\u02B8\u02C0\u02B2\u02C0\u02C1\u02B9() || this.\u02BA\u02BA\u02B9\u02BF\u02B8\u02B6\u02B5\u02B7\u02B9\u02C1\u02BD()))) && (this.\u02BA\u02B7\u02B5\u02C1\u02C0\u02B4\u02BE\u02BF\u02BF\u02C0\u02BE(note) || (this.\u02BC\u02B2\u02B2\u02BB\u02B7\u02B4\u02B3\u02B6\u02C1\u02BC\u02C0 && this.\u02B9\u02C0\u02B3\u02C0\u02B2\u02C1\u02B8\u02C1\u02B5\u02B6\u02B3 > 0f && note.\u02C1\u02B9\u02BD\u02B6\u02B7\u02BA\u02B5\u02B7\u02BA\u02B6\u02C0)))
					{
						this.\u02B6\u02BA\u02B4\u02BA\u02B7\u02BE\u02BD\u02BE\u02BD\u02B7\u02BB = 0f;
						this.\u02BE\u02BC\u02BA\u02BB\u02C0\u02B5\u02B6\u02B8\u02B6\u02BB\u02B3(note);
						return;
					}
					if ((note.\u02B8\u02C1\u02BA\u02B2\u02BC\u02B6\u02C0\u02BD\u02BD\u02BA\u02BE || (note.IsHopo && this.\u02C0\u02B5\u02BA\u02BD\u02B8\u02B6\u02B7\u02B6\u02BE\u02BE\u02B9())) && this.strumLenienceTimer > 0f && (BaseGuitarPlayer.\u02B3\u02B9\u02B2\u02BB\u02BE\u02BF\u02B7\u02C0\u02B2\u02B7\u02BF(ref u02B6_u02B5_u02B9_u02B2_u02B4_u02B9_u02B7_u02BE_u02B7_u02B9_u02B) || !this.\u02B9\u02B7\u02B5\u02BD\u02BB\u02B8\u02C0\u02B2\u02C0\u02C1\u02B9()) && this.\u02BA\u02B7\u02B5\u02C1\u02C0\u02B4\u02BE\u02BF\u02BF\u02C0\u02BE(note))
					{
						this.\u02BE\u02BC\u02BA\u02BB\u02C0\u02B5\u02B6\u02B8\u02B6\u02BB\u02B3(note);
						return;
					}
				}
				int num = u02B6_u02B5_u02B9_u02B2_u02B4_u02B9_u02B7_u02BE_u02B7_u02B9_u02B.hitIndex + 1;
				u02B6_u02B5_u02B9_u02B2_u02B4_u02B9_u02B7_u02BE_u02B7_u02B9_u02B.hitIndex = num;
			}
		}
	}

	protected override void UpdateAI()
	{
		ushort num = 0;
		foreach (Note note in this.sustainNotes)
		{
			if (note.IsExtendedSustain)
			{
				num |= note._noteMask;
			}
		}
		if (this.\u02B9\u02BF\u02B7\u02BE\u02B9\u02B5\u02B4\u02B9\u02B6\u02B9\u02B6 == 0)
		{
			return;
		}
		Note note2 = this.hittableNotes[0];
		uint num2 = (uint)(note2.IsDisjoint ? note2.noteMask : note2._noteMask);
		this.buttonsPressed = num;
		Helper.UintPair this2 = Helper.NewUintPair(num2).GetThis();
		while (this2.MoreThanOneBitSet())
		{
			ushort num3 = (ushort)this2.xor;
			this.buttonsPressed |= num3;
		}
		if (note2.IsHopo && this.combo > 0)
		{
			this.\u02B6\u02BA\u02B4\u02BA\u02B7\u02BE\u02BD\u02BE\u02BD\u02B7\u02BB = this.\u02B4\u02BE\u02BC\u02B9\u02C1\u02B8\u02BC\u02B8\u02BB\u02BA\u02BC;
			return;
		}
		this.strumLenienceTimer = this.strumLenienceAmount;
	}

	protected override bool \u02BA\u02B7\u02B5\u02C1\u02C0\u02B4\u02BE\u02BF\u02BF\u02C0\u02BE(Note \u02B9\u02BF\u02B6\u02BE\u02BA\u02BE\u02C1\u02B4\u02BB\u02C1\u02B2)
	{
		ushort num = this.buttonsPressed;
		if (\u02B9\u02BF\u02B6\u02BE\u02BA\u02BE\u02C1\u02B4\u02BB\u02C1\u02B2.IsExtendedSustain)
		{
			if (this.sustainNotes.Count > 0)
			{
				foreach (Note note in this.sustainNotes)
				{
					if (note.IsExtendedSustain)
					{
						num &= this.to_ushort((int)(~(int)note._noteMask));
					}
				}
				if (num == 0 && \u02B9\u02BF\u02B6\u02BE\u02BA\u02BE\u02C1\u02B4\u02BB\u02C1\u02B2._noteMask == this.OpenNote)
				{
					return true;
				}
				if (num != this.buttonsPressed && this.\u02B7\u02BF\u02BA\u02BF\u02C1\u02B4\u02B5\u02BD\u02C1\u02B8\u02B6(\u02B9\u02BF\u02B6\u02BE\u02BA\u02BE\u02C1\u02B4\u02BB\u02C1\u02B2, num))
				{
					return true;
				}
			}
			ushort num2 = num;
			if (this.lingeringSustainNotes.Count > 0)
			{
				foreach (Note note2 in this.lingeringSustainNotes)
				{
					if (note2.IsExtendedSustain)
					{
						num2 &= this.to_ushort((int)(~(int)note2._noteMask));
					}
				}
				if (num2 != num && this.\u02B7\u02BF\u02BA\u02BF\u02C1\u02B4\u02B5\u02BD\u02C1\u02B8\u02B6(\u02B9\u02BF\u02B6\u02BE\u02BA\u02BE\u02C1\u02B4\u02BB\u02C1\u02B2, num2))
				{
					return true;
				}
			}
		}
		return this.\u02B7\u02BF\u02BA\u02BF\u02C1\u02B4\u02B5\u02BD\u02C1\u02B8\u02B6(\u02B9\u02BF\u02B6\u02BE\u02BA\u02BE\u02C1\u02B4\u02BB\u02C1\u02B2, this.buttonsPressed);
	}

	protected override void Overstrum(bool plink)
	{
		if (plink)
		{
			GlobalVariables.overstrummed = true;
			if (this.\u02BF\u02C1\u02BF\u02BE\u02C1\u02B2\u02BC\u02BE\u02B3\u02BB\u02B8)
			{
				return;
			}
			if (!this.\u02C0\u02B2\u02B2\u02BA\u02B5\u02B9\u02BD\u02B6\u02BD\u02B6\u02B9 && this.sustainNotes.Count == 0)
			{
				return;
			}
			if (this.\u02C0\u02B5\u02BA\u02BD\u02B8\u02B6\u02B7\u02B6\u02BE\u02BE\u02B9() && this.combo > 0 && this.\u02B9\u02BF\u02B7\u02BE\u02B9\u02B5\u02B4\u02B9\u02B6\u02B9\u02B6 > 0 && this.hittableNotes[0].IsHopo)
			{
				return;
			}
			if (this.sustainNotes.Count > 0)
			{
				foreach (Note note in this.sustainNotes)
				{
					note.wasMissed = true;
					note.isSustaining = false;
				}
				this.sustainNotes.Clear();
				this.neckController.EndFretHeldStates();
			}
			GameAudioManager.\u02B6\u02B2\u02B3\u02BB\u02BB\u02BC\u02B9\u02BF\u02B5\u02B4\u02BB();
			this.overstrums++;
		}
		this.\u02BC\u02C0\u02C1\u02BD\u02B7\u02BC\u02B3\u02B8\u02C0\u02B7\u02BF = 0;
		this.\u02B2\u02B4\u02BC\u02B2\u02B5\u02BC\u02BD\u02B7\u02BA\u02BF\u02B3 = this.\u02B8\u02BA\u02BD\u02B7\u02B2\u02C0\u02BC\u02B9\u02BA\u02C1\u02C0;
		if (!this.isMutedAudio && this.sustainNotes.Count == 0)
		{
			BassAudioManager.Instance.MuteInstrument(this.player.playerProfile.moonInstrument, false, -1f);
			this.isMutedAudio = true;
		}
		base.Overstrum(plink);
	}

	protected override void \u02B9\u02C0\u02B2\u02BA\u02B9\u02BF\u02BE\u02BE\u02BD\u02B4\u02B7()
	{
		base.\u02B9\u02C0\u02B2\u02BA\u02B9\u02BF\u02BE\u02BE\u02BD\u02B4\u02B7();
		if (this.sustainNotes == null)
		{
			return;
		}
		if (this.\u02B4\u02BF\u02BD\u02B8\u02B3\u02BF\u02B9\u02C1\u02B9\u02C1\u02B8)
		{
			this.strumLenienceAmountNoNotes = this.\u02B2\u02B3\u02BF\u02C1\u02BF\u02BB\u02C1\u02C0\u02C1\u02B6\u02BF / 3f;
			this.\u02B4\u02BE\u02BC\u02B9\u02C1\u02B8\u02BC\u02B8\u02BB\u02BA\u02BC = this.\u02B2\u02B3\u02BF\u02C1\u02BF\u02BB\u02C1\u02C0\u02C1\u02B6\u02BF / 3f;
			this.\u02C1\u02BE\u02B3\u02BA\u02BE\u02BD\u02B8\u02C0\u02C1\u02BE\u02B5 = this.\u02B4\u02BE\u02BC\u02B9\u02C1\u02B8\u02BC\u02B8\u02BB\u02BA\u02BC;
		}
		foreach (Note note in this.sustainNotes)
		{
			note.time = (float)this.gameManager.songTime;
		}
	}

	protected BaseGuitarPlayer()
	{
		this.ticker = 60;
		this.strumLenienceAmount = 0.084f;
		this.strumLenienceAmountNoNotes = 0.048f;
		this.\u02B4\u02BE\u02BC\u02B9\u02C1\u02B8\u02BC\u02B8\u02BB\u02BA\u02BC = 1f;
		this.\u02C1\u02BE\u02B3\u02BA\u02BE\u02BD\u02B8\u02C0\u02C1\u02BE\u02B5 = 1f;
		this.\u02B3\u02C0\u02BA\u02BC\u02BB\u02BF\u02B4\u02B5\u02BC\u02BD\u02BC = 0.5f;
		this.\u02B6\u02B3\u02BE\u02B6\u02B3\u02BF\u02BC\u02BA\u02C1\u02B6\u02B3 = double.MinValue;
		this.sustainDropLeniency = 0.02;
		this.\u02B7\u02B6\u02B4\u02B8\u02BD\u02B2\u02BF\u02B6\u02B7\u02C1\u02BD = 0.3;
		this.\u02B5\u02B9\u02C1\u02BC\u02C0\u02BF\u02B3\u02B8\u02BD\u02BB\u02B5 = 4;
		this.\u02B8\u02BA\u02BD\u02B7\u02B2\u02C0\u02BC\u02B9\u02BA\u02C1\u02C0 = 1f;
		this.\u02C0\u02BE\u02C1\u02BB\u02C0\u02BE\u02B2\u02B5\u02B8\u02BA\u02BF = 0.025f;
		if (BaseGuitarPlayer.instance == null)
		{
			BaseGuitarPlayer.instance = this;
		}
	}

	[CompilerGenerated]
	internal static bool \u02B3\u02B9\u02B2\u02BB\u02BE\u02BF\u02B7\u02C0\u02B2\u02B7\u02BF(ref BaseGuitarPlayer.\u02B6\u02B5\u02B9\u02B2\u02B4\u02B9\u02B7\u02BE\u02B7\u02B9\u02B2 A_0)
	{
		return A_0.hitIndex == 0;
	}

	[CompilerGenerated]
	private bool \u02B9\u02B7\u02B5\u02BD\u02BB\u02B8\u02C0\u02B2\u02C0\u02C1\u02B9()
	{
		return this.combo != 0;
	}

	[CompilerGenerated]
	private bool \u02BA\u02BA\u02B9\u02BF\u02B8\u02B6\u02B5\u02B7\u02B9\u02C1\u02BD()
	{
		return GlobalVariables.instance.\u02BD\u02B9\u02B7\u02B5\u02BF\u02BC\u02BF\u02BA\u02BE\u02B6\u02B4 && !this.\u02B7\u02BD\u02C1\u02B3\u02BD\u02B5\u02B6\u02B8\u02B8\u02B2\u02BF;
	}

	public BaseGuitarPlayer.inputmap Inputs
	{
		get
		{
			ushort buttonsPressed = this.buttonsPressed;
			return new BaseGuitarPlayer.inputmap
			{
				g = ((buttonsPressed & 1) > 0),
				r = ((buttonsPressed & 2) > 0),
				y = ((buttonsPressed & 4) > 0),
				b = ((buttonsPressed & 8) > 0),
				o = ((buttonsPressed & 16) > 0),
				su = this.minputs.su,
				sd = this.minputs.sd,
				sutime = this.minputs.sutime,
				sdtime = this.minputs.sdtime,
				sucount = this.minputs.sucount,
				sdcount = this.minputs.sdcount,
				gcount = this.minputs.gcount,
				gptime = this.minputs.gptime,
				rcount = this.minputs.rcount,
				rptime = this.minputs.rptime,
				ycount = this.minputs.ycount,
				yptime = this.minputs.yptime,
				bcount = this.minputs.bcount,
				bptime = this.minputs.bptime,
				ocount = this.minputs.ocount,
				optime = this.minputs.optime
			};
		}
		set
		{
			ushort num = 0;
			int num2 = 0;
			num2 = (value.g ? (num2 | 1) : ((int)num));
			num2 = (value.r ? (num2 | 2) : ((int)num));
			num2 = (value.y ? (num2 | 4) : ((int)num));
			num2 = (value.b ? (num2 | 8) : ((int)num));
			num2 = (value.o ? (num2 | 16) : ((int)num));
			num = (ushort)num2;
			this.minputs.g = value.g;
			this.minputs.r = value.r;
			this.minputs.y = value.y;
			this.minputs.b = value.b;
			this.minputs.o = value.o;
			this.buttonsPressed = num;
		}
	}

	public ushort to_ushort(int i)
	{
		return (ushort)i;
	}

	private void OnDestroy()
	{
		BaseGuitarPlayer.instance = null;
	}

	protected float strumLenienceTimer;

	protected float strumLenienceAmount;

	protected float strumLenienceAmountNoNotes;

	protected float \u02C0\u02C0\u02C1\u02BF\u02B5\u02B9\u02BA\u02BA\u02BB\u02B8\u02B7;

	protected float \u02B6\u02BA\u02B4\u02BA\u02B7\u02BE\u02BD\u02BE\u02BD\u02B7\u02BB;

	protected float \u02B4\u02BE\u02BC\u02B9\u02C1\u02B8\u02BC\u02B8\u02BB\u02BA\u02BC;

	protected float \u02C1\u02BE\u02B3\u02BA\u02BE\u02BD\u02B8\u02C0\u02C1\u02BE\u02B5;

	protected float \u02B9\u02C0\u02B3\u02C0\u02B2\u02C1\u02B8\u02C1\u02B5\u02B6\u02B3;

	protected float \u02B3\u02C0\u02BA\u02BC\u02BB\u02BF\u02B4\u02B5\u02BC\u02BD\u02BC;

	protected float \u02B2\u02BE\u02BD\u02B7\u02BE\u02B9\u02C0\u02B9\u02B2\u02BC\u02BD;

	protected float \u02C0\u02BD\u02C1\u02B2\u02B5\u02BD\u02B6\u02C1\u02B9\u02C0\u02BF;

	private double \u02B6\u02B3\u02BE\u02B6\u02B3\u02BF\u02BC\u02BA\u02C1\u02B6\u02B3;

	private double doubleStrumPrevention;

	private bool \u02C1\u02B8\u02B7\u02BB\u02B4\u02BE\u02BB\u02B5\u02B3\u02B6\u02B2;

	private double \u02BE\u02B9\u02BB\u02B6\u02BC\u02B2\u02BD\u02BC\u02C0\u02C1\u02B5;

	private double sustainDropLeniency;

	private double \u02B7\u02B6\u02B4\u02B8\u02BD\u02B2\u02BF\u02B6\u02B7\u02C1\u02BD;

	private int \u02B5\u02B9\u02C1\u02BC\u02C0\u02BF\u02B3\u02B8\u02BD\u02BB\u02B5;

	private int \u02BC\u02C0\u02C1\u02BD\u02B7\u02BC\u02B3\u02B8\u02C0\u02B7\u02BF;

	private float \u02B8\u02BA\u02BD\u02B7\u02B2\u02C0\u02BC\u02B9\u02BA\u02C1\u02C0;

	private float \u02B2\u02B4\u02BC\u02B2\u02B5\u02BC\u02BD\u02B7\u02BA\u02BF\u02B3;

	protected ushort \u02C0\u02B4\u02BD\u02BF\u02B8\u02B9\u02B4\u02BE\u02BE\u02B7\u02B3;

	protected ushort \u02BC\u02B8\u02B5\u02BB\u02BB\u02B7\u02C1\u02B6\u02BC\u02B4\u02BE;

	protected float \u02C0\u02B6\u02BC\u02B2\u02B9\u02B6\u02BA\u02BE\u02B3\u02BC\u02B3;

	protected float \u02C0\u02BE\u02C1\u02BB\u02C0\u02BE\u02B2\u02B5\u02B8\u02BA\u02BF;

	public float whammyTimer;

	protected float \u02BF\u02B7\u02C1\u02BF\u02B6\u02BB\u02B7\u02B2\u02B6\u02B7\u02B9;

	[HideInInspector]
	public float currentWhammy;

	public List<Note> sustainNotes;

	private List<double> \u02B3\u02B9\u02C1\u02BD\u02B4\u02B3\u02C0\u02B7\u02B4\u02BB\u02BA;

	public List<Note> lingeringSustainNotes;

	private bool \u02B3\u02B3\u02BD\u02C0\u02B6\u02B7\u02C0\u02BA\u02BB\u02B9\u02B9;

	private double \u02BA\u02B2\u02B5\u02B2\u02B6\u02BF\u02B7\u02B6\u02BF\u02C0\u02B7;

	protected bool \u02B4\u02BA\u02BA\u02B3\u02C0\u02BC\u02BD\u02BA\u02B5\u02B2\u02B8;

	protected bool \u02B6\u02C0\u02BA\u02BF\u02B7\u02B8\u02B2\u02B2\u02B5\u02B6\u02B2;

	public BaseGuitarPlayer.inputmap lastinputs;

	public BaseGuitarPlayer.inputmap minputs;

	public static BaseGuitarPlayer instance;

	private int ticker;

	private ushort setButton;

	private bool lenienceFirstTick;

	private bool sl_nonotes;

	private ushort goodMask;

	private float maskTimer;

	private float timeSinceMask;

	[CompilerGenerated]
	public struct \u02B6\u02B5\u02B9\u02B2\u02B4\u02B9\u02B7\u02BE\u02B7\u02B9\u02B2
	{
		public int hitIndex;
	}

	public struct inputmap
	{
		public override string ToString()
		{
			string text = "<cspace=-0.7em>███████<color=#000000FF>█";
			string text2 = "<cspace=-0.7em>▀▀▀▀▀▀▀<color=#000000FF>█";
			string text3 = "<cspace=-0.7em>▄▄▄▄▄▄▄<color=#000000FF>█";
			string text4 = "<color=REPLACEWITHSTRUMCOLOR>";
			string text5 = "<color=#000000FF>";
			return string.Format("<i>{12}{6}{0}{7}{1}{8}{2}{9}{3}{10}{4} {12}{11}{5}</i></cspace>", new object[]
			{
				text,
				text,
				text,
				text,
				text,
				(this.su && this.sd) ? text : ((this.su && !this.sd) ? text2 : ((!this.su && this.sd) ? text3 : (text5 + text))),
				this.g ? ("<color=" + GlobalHelper.greenFretColor + ">") : text5,
				this.r ? ("<color=" + GlobalHelper.redFretColor + ">") : text5,
				this.y ? ("<color=" + GlobalHelper.yellowFretColor + ">") : text5,
				this.b ? ("<color=" + GlobalHelper.blueFretColor + ">") : text5,
				this.o ? ("<color=" + GlobalHelper.orangeFretColor + ">") : text5,
				text4,
				"                                   "
			});
		}

		public char[] ToCharArray()
		{
			char[] array;
			using (Utf16ValueStringBuilder utf16ValueStringBuilder = ZString.CreateStringBuilder())
			{
				utf16ValueStringBuilder.Append("<i>                                   <cspace=-0.7em>");
				if (this.su && this.sd)
				{
					utf16ValueStringBuilder.Append("<color=#cc11cc>███████<color=#000000FF>█");
				}
				else if (this.su && !this.sd)
				{
					utf16ValueStringBuilder.Append("<color=#cc11cc>▀▀▀▀▀▀▀<color=#000000FF>█");
				}
				else if (!this.su && this.sd)
				{
					utf16ValueStringBuilder.Append("<color=#cc11cc>▄▄▄▄▄▄▄<color=#000000FF>█");
				}
				else
				{
					utf16ValueStringBuilder.Append("<color=#000000FF>");
					utf16ValueStringBuilder.Append("████████");
				}
				if (this.g)
				{
					utf16ValueStringBuilder.Append("<color=");
					utf16ValueStringBuilder.Append(new ReadOnlySpan<char>(GlobalHelper.char_greenFretColor));
				}
				else
				{
					utf16ValueStringBuilder.Append("<color=#000000FF");
				}
				utf16ValueStringBuilder.Append(">███████<color=#000000FF>█");
				if (this.r)
				{
					utf16ValueStringBuilder.Append("<color=");
					utf16ValueStringBuilder.Append(new ReadOnlySpan<char>(GlobalHelper.char_redFretColor));
				}
				else
				{
					utf16ValueStringBuilder.Append("<color=#000000FF");
				}
				utf16ValueStringBuilder.Append(">███████<color=#000000FF>█");
				if (this.y)
				{
					utf16ValueStringBuilder.Append("<color=");
					utf16ValueStringBuilder.Append(new ReadOnlySpan<char>(GlobalHelper.char_yellowFretColor));
				}
				else
				{
					utf16ValueStringBuilder.Append("<color=#000000FF");
				}
				utf16ValueStringBuilder.Append(">███████<color=#000000FF>█");
				if (this.b)
				{
					utf16ValueStringBuilder.Append("<color=");
					utf16ValueStringBuilder.Append(new ReadOnlySpan<char>(GlobalHelper.char_blueFretColor));
				}
				else
				{
					utf16ValueStringBuilder.Append("<color=#000000FF");
				}
				utf16ValueStringBuilder.Append(">███████<color=#000000FF>█");
				if (this.o)
				{
					utf16ValueStringBuilder.Append("<color=");
					utf16ValueStringBuilder.Append(new ReadOnlySpan<char>(GlobalHelper.char_orangeFretColor));
				}
				else
				{
					utf16ValueStringBuilder.Append("<color=#000000FF");
				}
				utf16ValueStringBuilder.Append(">███████<color=#000000FF>█</cspace></i>");
				array = utf16ValueStringBuilder.AsArraySegment().ToArray<char>();
				utf16ValueStringBuilder.Dispose();
			}
			return array;
		}

		public void AppendToZString(Utf16ValueStringBuilder utf16ValueStringBuilder)
		{
			if (!this.sd)
			{
				utf16ValueStringBuilder.Clear();
			}
			utf16ValueStringBuilder.Append("<i>                                   <cspace=-0.7em>");
			if (this.su && this.sd)
			{
				utf16ValueStringBuilder.Append("<color=#cc11cc>███████<color=#000000FF>█");
			}
			else if (this.su && !this.sd)
			{
				utf16ValueStringBuilder.Append("<color=#cc11cc>▀▀▀▀▀▀▀<color=#000000FF>█");
			}
			else if (!this.su && this.sd)
			{
				utf16ValueStringBuilder.Append("<color=#cc11cc>▄▄▄▄▄▄▄<color=#000000FF>█");
			}
			else
			{
				utf16ValueStringBuilder.Append("<color=#000000FF>");
				utf16ValueStringBuilder.Append("████████");
			}
			if (this.g)
			{
				utf16ValueStringBuilder.Append("<color=");
				utf16ValueStringBuilder.Append(new ReadOnlySpan<char>(GlobalHelper.char_greenFretColor));
			}
			else
			{
				utf16ValueStringBuilder.Append("<color=#000000FF");
			}
			utf16ValueStringBuilder.Append(">███████<color=#000000FF>█");
			if (this.r)
			{
				utf16ValueStringBuilder.Append("<color=");
				utf16ValueStringBuilder.Append(new ReadOnlySpan<char>(GlobalHelper.char_redFretColor));
			}
			else
			{
				utf16ValueStringBuilder.Append("<color=#000000FF");
			}
			utf16ValueStringBuilder.Append(">███████<color=#000000FF>█");
			if (this.y)
			{
				utf16ValueStringBuilder.Append("<color=");
				utf16ValueStringBuilder.Append(new ReadOnlySpan<char>(GlobalHelper.char_yellowFretColor));
			}
			else
			{
				utf16ValueStringBuilder.Append("<color=#000000FF");
			}
			utf16ValueStringBuilder.Append(">███████<color=#000000FF>█");
			if (this.b)
			{
				utf16ValueStringBuilder.Append("<color=");
				utf16ValueStringBuilder.Append(new ReadOnlySpan<char>(GlobalHelper.char_blueFretColor));
			}
			else
			{
				utf16ValueStringBuilder.Append("<color=#000000FF");
			}
			utf16ValueStringBuilder.Append(">███████<color=#000000FF>█");
			if (this.o)
			{
				utf16ValueStringBuilder.Append("<color=");
				utf16ValueStringBuilder.Append(new ReadOnlySpan<char>(GlobalHelper.char_orangeFretColor));
			}
			else
			{
				utf16ValueStringBuilder.Append("<color=#000000FF");
			}
			utf16ValueStringBuilder.Append(">███████<color=#000000FF>█</cspace></i>");
		}

		public bool g;

		public bool r;

		public bool y;

		public bool b;

		public bool o;

		public int gcount;

		public int rcount;

		public int ycount;

		public int bcount;

		public int ocount;

		public bool su;

		public bool sd;

		public float gptime;

		public float rptime;

		public float yptime;

		public float bptime;

		public float optime;

		public int sucount;

		public int sdcount;

		public float sutime;

		public float sdtime;

		public bool gn;

		public bool rn;

		public bool yn;

		public bool bn;

		public bool on;

		public bool sun;

		public bool sdn;
	}

	public enum GuitarButtons
	{
		Green,
		Red,
		Yellow,
		Blue,
		Orange,
		Upstrum,
		Downstrum = 14
	}
}
