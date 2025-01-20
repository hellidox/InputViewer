using System;
using UnityEngine;

public class GuitarNoteRenderer : BaseNoteRenderer
{
	protected override void Update()
	{
		if (!GlobalHelper.willCurrentFrameRender)
		{
			return;
		}
		if (this.basePlayer.Notes == null)
		{
			return;
		}
		for (int i = 0; i < 6; i++)
		{
			this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD.\u02BF\u02B8\u02BA\u02BB\u02BC\u02B5\u02BE\u02B7\u02C1\u02BA\u02BC.\u02BB\u02B7\u02C1\u02B3\u02B9\u02B6\u02B3\u02B5\u02BF\u02BE\u02B8[i] = Mathf.Min(1f, Mathf.MoveTowards(this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD.\u02BF\u02B8\u02BA\u02BB\u02BC\u02B5\u02BE\u02B7\u02C1\u02BA\u02BC.\u02BB\u02B7\u02C1\u02B3\u02B9\u02B6\u02B3\u02B5\u02BF\u02BE\u02B8[i], 1f, GlobalHelper.renderDeltaTime * 20f));
		}
		this.\u02BA\u02C1\u02B6\u02B4\u02B6\u02B6\u02B9\u02B7\u02B7\u02B2\u02BA += GlobalHelper.renderDeltaTime * (float)this.basePlayer.player.playerProfile.noteSpeed.CurrentValue * (this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD.\u02C0\u02C0\u02BA\u02BF\u02B3\u02BA\u02B5\u02BF\u02B9\u02BB\u02B5 ? 0f : 1f);
		base.\u02B2\u02BF\u02B5\u02C1\u02B6\u02C0\u02B5\u02B5\u02B2\u02B2\u02B7();
		this.currentNoteIndex = this.noteStartIndex;
		this.spritesThisFrame = 0;
		this.sustainsThisFrame = 0;
		this.openSustainsThisFrame = 0;
		this.\u02B4\u02B5\u02BE\u02BC\u02B7\u02BF\u02C1\u02B8\u02C1\u02BF\u02C0 = this.basePlayer.Notes.Count;
		while (!this.\u02B7\u02BF\u02C0\u02B6\u02B3\u02C1\u02C1\u02BC\u02BF\u02BD\u02BE())
		{
			Note note = this.basePlayer.Notes[this.currentNoteIndex];
			if ((double)note.time - this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD.\u02B7\u02B4\u02BA\u02B5\u02B5\u02B8\u02BE\u02B5\u02B3\u02B5\u02BB >= (double)this.\u02B2\u02BE\u02B4\u02BE\u02B9\u02B5\u02B4\u02BA\u02B6\u02BF\u02B8)
			{
				break;
			}
			if (this.currentNoteIndex == this.noteStartIndex && note.time + note.length < this.noteZPosCloseLimit)
			{
				this.noteStartIndex++;
				this.currentNoteIndex = this.noteStartIndex;
			}
			else if (note.wasHit && !note.wasMissed)
			{
				this.currentNoteIndex++;
			}
			else
			{
				if (!note.isSustaining)
				{
					float num = Helper.\u02B5\u02B9\u02C1\u02BB\u02B6\u02B3\u02BA\u02BE\u02B9\u02B5\u02BF((double)note.time, this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD.\u02B7\u02B4\u02BA\u02B5\u02B5\u02B8\u02BE\u02B5\u02B3\u02B5\u02BB, this.\u02BB\u02BE\u02B6\u02B5\u02BD\u02BF\u02C1\u02B9\u02B4\u02B3\u02B9, this.\u02B7\u02BB\u02BA\u02C0\u02BF\u02B5\u02B5\u02B9\u02BD\u02C1\u02B4);
					if (!note.\u02BC\u02B9\u02B4\u02B6\u02B5\u02BC\u02BB\u02BC\u02BB\u02B4\u02B7)
					{
						this.\u02BF\u02BF\u02C1\u02B5\u02B3\u02B4\u02C0\u02B7\u02BB\u02B2\u02BB(note, num);
					}
					if (note.length > 0f)
					{
						this.\u02BE\u02BF\u02BE\u02C1\u02BC\u02B5\u02B5\u02C1\u02BD\u02C0\u02BC(note, num);
					}
				}
				this.currentNoteIndex++;
			}
		}
		if (this.\u02C0\u02C0\u02BA\u02B9\u02B7\u02B3\u02BB\u02B8\u02B8\u02B2\u02B3 != null)
		{
			foreach (Note note2 in this.\u02C0\u02C0\u02BA\u02B9\u02B7\u02B3\u02BB\u02B8\u02B8\u02B2\u02B3)
			{
				this.\u02B4\u02B7\u02BB\u02B2\u02C0\u02B3\u02BF\u02B5\u02BA\u02C1\u02C0(note2, new Vector3(0f, 0f, this.\u02BB\u02BE\u02B6\u02B5\u02BD\u02BF\u02C1\u02B9\u02B4\u02B3\u02B9 + 0.09f));
			}
		}
		BaseNoteRenderer.ClearRemainingObjPool(this.noteObjects, this.spritesThisFrame);
		BaseNoteRenderer.ClearRemainingObjPool(this.sustainObjects, this.sustainsThisFrame);
		BaseNoteRenderer.ClearRemainingObjPool(this.openSustainObjects, this.openSustainsThisFrame);
	}

	private bool \u02BD\u02BD\u02B7\u02B9\u02BC\u02BE\u02B3\u02BB\u02B3\u02B2\u02C0()
	{
		return this.spritesThisFrame < this.maxNotePool && this.currentNoteIndex >= this.\u02B4\u02B5\u02BE\u02BC\u02B7\u02BF\u02C1\u02B8\u02C1\u02BF\u02C0;
	}

	protected override void \u02BE\u02BD\u02BB\u02B8\u02B5\u02BF\u02BE\u02B6\u02BD\u02B9\u02BD()
	{
		base.\u02BE\u02BD\u02BB\u02B8\u02B5\u02BF\u02BE\u02B6\u02BD\u02B9\u02BD();
		this.\u02C1\u02BE\u02BA\u02BF\u02BE\u02B8\u02B3\u02BA\u02B7\u02BA\u02B7();
		this.\u02B5\u02B2\u02B7\u02C1\u02BB\u02C0\u02BF\u02B8\u02B4\u02B2\u02B2();
	}

	protected override Color \u02C1\u02B7\u02BF\u02BF\u02B2\u02BD\u02BD\u02B8\u02C1\u02B2\u02C0(ushort \u02B6\u02BB\u02BC\u02B4\u02BC\u02BB\u02BC\u02BD\u02BC\u02BF\u02BB)
	{
		if (\u02B6\u02BB\u02BC\u02B4\u02BC\u02BB\u02BC\u02BD\u02BC\u02BF\u02BB != 64)
		{
			\u02B6\u02BB\u02BC\u02B4\u02BC\u02BB\u02BC\u02BD\u02BC\u02BF\u02BB = (ushort)GlobalHelper.randomFret;
		}
		if (\u02B6\u02BB\u02BC\u02B4\u02BC\u02BB\u02BC\u02BD\u02BC\u02BF\u02BB <= 8)
		{
			switch (\u02B6\u02BB\u02BC\u02B4\u02BC\u02BB\u02BC\u02BD\u02BC\u02BF\u02BB)
			{
			case 1:
				return base.\u02B7\u02B9\u02BA\u02B6\u02B3\u02B4\u02B5\u02C1\u02B4\u02B9\u02B6.guitarNoteGreen;
			case 2:
				return base.\u02B7\u02B9\u02BA\u02B6\u02B3\u02B4\u02B5\u02C1\u02B4\u02B9\u02B6.guitarNoteRed;
			case 3:
				break;
			case 4:
				return base.\u02B7\u02B9\u02BA\u02B6\u02B3\u02B4\u02B5\u02C1\u02B4\u02B9\u02B6.guitarNoteYellow;
			default:
				if (\u02B6\u02BB\u02BC\u02B4\u02BC\u02BB\u02BC\u02BD\u02BC\u02BF\u02BB == 8)
				{
					return base.\u02B7\u02B9\u02BA\u02B6\u02B3\u02B4\u02B5\u02C1\u02B4\u02B9\u02B6.guitarNoteBlue;
				}
				break;
			}
		}
		else
		{
			if (\u02B6\u02BB\u02BC\u02B4\u02BC\u02BB\u02BC\u02BD\u02BC\u02BF\u02BB == 16)
			{
				return base.\u02B7\u02B9\u02BA\u02B6\u02B3\u02B4\u02B5\u02C1\u02B4\u02B9\u02B6.guitarNoteOrange;
			}
			if (\u02B6\u02BB\u02BC\u02B4\u02BC\u02BB\u02BC\u02BD\u02BC\u02BF\u02BB == 64)
			{
				return base.\u02B7\u02B9\u02BA\u02B6\u02B3\u02B4\u02B5\u02C1\u02B4\u02B9\u02B6.guitarNoteOpen;
			}
		}
		return Color.white;
	}

	private bool \u02BD\u02B2\u02B6\u02B8\u02B7\u02B2\u02BA\u02B2\u02BF\u02BC\u02B6()
	{
		return this.openSustainsThisFrame >= this.\u02B5\u02B4\u02C0\u02B8\u02B3\u02B2\u02B9\u02C1\u02BB\u02B9\u02B7 || this.currentNoteIndex >= this.\u02B4\u02B5\u02BE\u02BC\u02B7\u02BF\u02C1\u02B8\u02C1\u02BF\u02C0;
	}

	private void \u02B9\u02B9\u02B7\u02B2\u02BB\u02B2\u02BB\u02B6\u02BA\u02BA\u02B4()
	{
		if (this.basePlayer.player.playerProfile.IsGHLController)
		{
			return;
		}
		for (int i = 1; i < this.cachedNoteContainers.Length; i++)
		{
			((NoteContainer)this.cachedNoteContainers[i]).\u02B7\u02B3\u02B3\u02BA\u02BD\u02B8\u02BF\u02BB\u02B6\u02BA\u02BB = this.basePlayer.player.playerProfile.altTaps;
		}
	}

	protected override int \u02C1\u02B7\u02C0\u02B7\u02B9\u02B2\u02B2\u02BF\u02BC\u02C0\u02BF(ushort \u02BF\u02BB\u02BB\u02BB\u02B6\u02B4\u02B8\u02BE\u02C0\u02C1\u02B9)
	{
		if (\u02BF\u02BB\u02BB\u02BB\u02B6\u02B4\u02B8\u02BE\u02C0\u02C1\u02B9 <= 8)
		{
			switch (\u02BF\u02BB\u02BB\u02BB\u02B6\u02B4\u02B8\u02BE\u02C0\u02C1\u02B9)
			{
			case 1:
				return 0;
			case 2:
				return 1;
			case 3:
				break;
			case 4:
				return 2;
			default:
				if (\u02BF\u02BB\u02BB\u02BB\u02B6\u02B4\u02B8\u02BE\u02C0\u02C1\u02B9 == 8)
				{
					return 3;
				}
				break;
			}
		}
		else
		{
			if (\u02BF\u02BB\u02BB\u02BB\u02B6\u02B4\u02B8\u02BE\u02C0\u02C1\u02B9 == 16)
			{
				return 4;
			}
			if (\u02BF\u02BB\u02BB\u02BB\u02B6\u02B4\u02B8\u02BE\u02C0\u02C1\u02B9 == 64)
			{
				return 6;
			}
		}
		return -1;
	}

	protected void \u02B4\u02B7\u02BB\u02B2\u02C0\u02B3\u02BF\u02B5\u02BA\u02C1\u02C0(Note \u02B9\u02BF\u02B6\u02BE\u02BA\u02BE\u02C1\u02B4\u02BB\u02C1\u02B2, Vector3 \u02BB\u02B7\u02C1\u02BC\u02B8\u02B5\u02B6\u02B5\u02B6\u02B7\u02B4)
	{
		float num = (this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD.\u02C0\u02C0\u02BA\u02BF\u02B3\u02BA\u02B5\u02BF\u02B9\u02BB\u02B5 ? (\u02B9\u02BF\u02B6\u02BE\u02BA\u02BE\u02C1\u02B4\u02BB\u02C1\u02B2.\u02B2\u02B8\u02B7\u02BD\u02B5\u02B7\u02B6\u02B2\u02BF\u02BD\u02C0 - (float)this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD.\u02B7\u02B4\u02BA\u02B5\u02B5\u02B8\u02BE\u02B5\u02B3\u02B5\u02BB) : \u02B9\u02BF\u02B6\u02BE\u02BA\u02BE\u02C1\u02B4\u02BB\u02C1\u02B2.length) * this.\u02B7\u02BB\u02BA\u02C0\u02BF\u02B5\u02B5\u02B9\u02BD\u02C1\u02B4;
		Helper.\u02B2\u02B8\u02C1\u02BF\u02B7\u02B4\u02B2\u02B2\u02C0\u02B2\u02BA u02B2_u02B8_u02C1_u02BF_u02B7_u02B4_u02B2_u02B2_u02C0_u02B2_u02BA = Helper.\u02B8\u02C0\u02BA\u02BB\u02B6\u02BA\u02BA\u02C0\u02B4\u02C1\u02B9(\u02B9\u02BF\u02B6\u02BE\u02BA\u02BE\u02C1\u02B4\u02BB\u02C1\u02B2._noteMask).\u02BC\u02C0\u02B8\u02B9\u02B4\u02BB\u02BE\u02B6\u02BC\u02B7\u02C1();
		while (u02B2_u02B8_u02C1_u02BF_u02B7_u02B4_u02B2_u02B2_u02C0_u02B2_u02BA.\u02BF\u02B5\u02B7\u02BB\u02B5\u02BB\u02B7\u02B5\u02B6\u02BA\u02BC())
		{
			byte b = (byte)u02B2_u02B8_u02C1_u02BF_u02B7_u02B4_u02B2_u02B2_u02C0_u02B2_u02BA.\u02B9\u02BA\u02BB\u02B4\u02C0\u02B4\u02B6\u02B2\u02B9\u02B3\u02BF;
			bool flag = (\u02B9\u02BF\u02B6\u02BE\u02BA\u02BE\u02C1\u02B4\u02BB\u02C1\u02B2._noteMask & 64) > 0;
			if (flag)
			{
				GameObject gameObject = this.openSustainObjects[this.openSustainsThisFrame];
				gameObject.SetActive(!this.\u02B6\u02BB\u02B2\u02B5\u02BC\u02BB\u02B7\u02B3\u02C1\u02B4\u02B2);
				SpriteRenderer spriteRenderer = this.\u02B6\u02B8\u02B9\u02B4\u02B7\u02B2\u02C0\u02BC\u02BE\u02C1\u02B6[this.openSustainsThisFrame];
				SpriteRenderer spriteRenderer2 = this.\u02B5\u02B6\u02BD\u02B2\u02BE\u02B6\u02B8\u02B5\u02C0\u02B2\u02B3[this.openSustainsThisFrame];
				spriteRenderer2.enabled = true;
				\u02BB\u02B7\u02C1\u02BC\u02B8\u02B5\u02B6\u02B5\u02B6\u02B7\u02B4.x = 0f;
				gameObject.transform.localPosition = \u02BB\u02B7\u02C1\u02BC\u02B8\u02B5\u02B6\u02B5\u02B6\u02B7\u02B4;
				spriteRenderer.sprite = this.Sustains[4];
				if (this.basePlayer.\u02B4\u02BE\u02B5\u02B5\u02B4\u02BE\u02B3\u02C0\u02BC\u02BA\u02B9)
				{
					spriteRenderer2.color = base.\u02B7\u02B9\u02BA\u02B6\u02B3\u02B4\u02B5\u02C1\u02B4\u02B9\u02B6.\u02B2\u02B3\u02BE\u02C0\u02B4\u02BE\u02B5\u02BD\u02BD\u02BB\u02BE;
					spriteRenderer.color = base.\u02B7\u02B9\u02BA\u02B6\u02B3\u02B4\u02B5\u02C1\u02B4\u02B9\u02B6.\u02B2\u02B3\u02BE\u02C0\u02B4\u02BE\u02B5\u02BD\u02BD\u02BB\u02BE;
				}
				else if (\u02B9\u02BF\u02B6\u02BE\u02BA\u02BE\u02C1\u02B4\u02BB\u02C1\u02B2.isStarPower && (this.basePlayer as BaseGuitarPlayer).whammyTimer > 0f)
				{
					Color color = (this.basePlayer.\u02B4\u02BE\u02B5\u02B5\u02B4\u02BE\u02B3\u02C0\u02BC\u02BA\u02B9 ? base.\u02B7\u02B9\u02BA\u02B6\u02B3\u02B4\u02B5\u02C1\u02B4\u02B9\u02B6.\u02C0\u02B8\u02BD\u02B2\u02BC\u02BC\u02BA\u02B3\u02B5\u02B9\u02C1 : base.\u02B7\u02B9\u02BA\u02B6\u02B3\u02B4\u02B5\u02C1\u02B4\u02B9\u02B6.\u02B3\u02B6\u02C1\u02B6\u02B5\u02B9\u02B8\u02B8\u02B6\u02B4\u02C1);
					spriteRenderer2.color = color;
					spriteRenderer.color = color;
				}
				else
				{
					spriteRenderer2.color = base.\u02B7\u02B9\u02BA\u02B6\u02B3\u02B4\u02B5\u02C1\u02B4\u02B9\u02B6.\u02B3\u02C0\u02B2\u02C1\u02BD\u02B7\u02B9\u02BD\u02B6\u02B4\u02C1;
					spriteRenderer.color = base.\u02B7\u02B9\u02BA\u02B6\u02B3\u02B4\u02B5\u02C1\u02B4\u02B9\u02B6.\u02B3\u02C0\u02B2\u02C1\u02BD\u02B7\u02B9\u02BD\u02B6\u02B4\u02C1;
				}
				this.openSustainsThisFrame++;
			}
			else
			{
				GameObject gameObject2 = this.sustainObjects[this.sustainsThisFrame];
				gameObject2.SetActive(!this.\u02B6\u02BB\u02B2\u02B5\u02BC\u02BB\u02B7\u02B3\u02C1\u02B4\u02B2);
				SpriteRenderer spriteRenderer3 = this.\u02B5\u02BB\u02BD\u02B3\u02B6\u02BD\u02B5\u02C1\u02C0\u02B8\u02BF[this.sustainsThisFrame];
				SpriteRenderer spriteRenderer4 = this.\u02BF\u02BD\u02B2\u02B3\u02B2\u02B4\u02B2\u02C1\u02BA\u02B5\u02B3[this.sustainsThisFrame];
				spriteRenderer4.enabled = true;
				\u02BB\u02B7\u02C1\u02BC\u02B8\u02B5\u02B6\u02B5\u02B6\u02B7\u02B4.x = this.firstNoteXPos + this.\u02BD\u02B5\u02BC\u02B6\u02B5\u02BE\u02C1\u02BE\u02B7\u02C1\u02B5 * (float)b;
				gameObject2.transform.localPosition = \u02BB\u02B7\u02C1\u02BC\u02B8\u02B5\u02B6\u02B5\u02B6\u02B7\u02B4;
				spriteRenderer3.sprite = this.Sustains[3];
				if (this.basePlayer.\u02B4\u02BE\u02B5\u02B5\u02B4\u02BE\u02B3\u02C0\u02BC\u02BA\u02B9)
				{
					spriteRenderer3.color = base.\u02B7\u02B9\u02BA\u02B6\u02B3\u02B4\u02B5\u02C1\u02B4\u02B9\u02B6.\u02B2\u02B3\u02BE\u02C0\u02B4\u02BE\u02B5\u02BD\u02BD\u02BB\u02BE;
				}
				else if (\u02B9\u02BF\u02B6\u02BE\u02BA\u02BE\u02C1\u02B4\u02BB\u02C1\u02B2.isStarPower && (this.basePlayer as BaseGuitarPlayer).whammyTimer > 0f)
				{
					spriteRenderer3.color = (this.basePlayer.\u02B4\u02BE\u02B5\u02B5\u02B4\u02BE\u02B3\u02C0\u02BC\u02BA\u02B9 ? base.\u02B7\u02B9\u02BA\u02B6\u02B3\u02B4\u02B5\u02C1\u02B4\u02B9\u02B6.\u02C0\u02B8\u02BD\u02B2\u02BC\u02BC\u02BA\u02B3\u02B5\u02B9\u02C1 : base.\u02B7\u02B9\u02BA\u02B6\u02B3\u02B4\u02B5\u02C1\u02B4\u02B9\u02B6.\u02B3\u02B6\u02C1\u02B6\u02B5\u02B9\u02B8\u02B8\u02B6\u02B4\u02C1);
				}
				else
				{
					spriteRenderer3.color = base.\u02B7\u02B9\u02BA\u02B6\u02B3\u02B4\u02B5\u02C1\u02B4\u02B9\u02B6.\u02BC\u02C0\u02B7\u02BD\u02B7\u02B4\u02B6\u02B6\u02B2\u02B3\u02C1[(int)b];
				}
				spriteRenderer4.color = spriteRenderer3.color;
				this.sustainsThisFrame++;
			}
			int num2 = \u02BB\u02B3\u02BF\u02BC\u02B5\u02B7\u02BA\u02B9\u02C0\u02B8\u02BE.\u02BD\u02B9\u02B3\u02BB\u02BC\u02B9\u02B5\u02BB\u02B5\u02BE\u02BA((int)(flag ? 5 : b), this.basePlayer.player.\u02BE\u02BB\u02B5\u02B7\u02B9\u02B2\u02B6\u02BF\u02B9\u02B7\u02B7);
			float num3 = (this.basePlayer as BaseGuitarPlayer).currentWhammy;
			if (this.\u02B4\u02B2\u02B9\u02BC\u02B4\u02B6\u02B2\u02B9\u02BC\u02BA\u02C1)
			{
				num3 = Mathf.Abs(num3);
			}
			this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD.\u02BF\u02B8\u02BA\u02BB\u02BC\u02B5\u02BE\u02B7\u02C1\u02BA\u02BC.\u02B2\u02B7\u02B8\u02B3\u02C1\u02BF\u02B4\u02B8\u02C0\u02C0\u02BA(num2, num3);
			SpriteRenderer spriteRenderer5;
			Vector4 vector;
			if (flag)
			{
				spriteRenderer5 = this.\u02B5\u02B6\u02BD\u02B2\u02BE\u02B6\u02B8\u02B5\u02C0\u02B2\u02B3[this.openSustainsThisFrame - 1];
				vector = this.\u02B6\u02BF\u02C1\u02B3\u02B8\u02B9\u02C0\u02B8\u02B3\u02B6\u02B8;
			}
			else
			{
				spriteRenderer5 = this.\u02BF\u02BD\u02B2\u02B3\u02B2\u02B4\u02B2\u02C1\u02BA\u02B5\u02B3[this.sustainsThisFrame - 1];
				vector = this.\u02BA\u02BE\u02BD\u02BE\u02B6\u02B9\u02B4\u02B6\u02B9\u02C0\u02C0;
			}
			Vector4 vector2 = new Vector4((float)num2, num, this.\u02BA\u02C1\u02B6\u02B4\u02B6\u02B6\u02B9\u02B7\u02B7\u02B2\u02BA, ((float)this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD.\u02BF\u02B8\u02BA\u02BB\u02BC\u02B5\u02BE\u02B7\u02C1\u02BA\u02BC.\u02B2\u02B3\u02BE\u02B9\u02B7\u02BB\u02B2\u02BB\u02C0\u02BC\u02B6 + this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD.\u02BF\u02B8\u02BA\u02BB\u02BC\u02B5\u02BE\u02B7\u02C1\u02BA\u02BC.\u02BB\u02B5\u02BB\u02B6\u02BF\u02B3\u02B5\u02B5\u02B6\u02BF\u02B7) / 1024f);
			spriteRenderer5.GetPropertyBlock(this.\u02B9\u02B6\u02B8\u02BB\u02BD\u02BB\u02BC\u02B4\u02BC\u02BB\u02BA);
			this.\u02B9\u02B6\u02B8\u02BB\u02BD\u02BB\u02BC\u02B4\u02BC\u02BB\u02BA.SetVector(this.\u02BD\u02B7\u02BA\u02BC\u02BE\u02BB\u02BD\u02B4\u02B4\u02B9\u02BD, vector2);
			this.\u02B9\u02B6\u02B8\u02BB\u02BD\u02BB\u02BC\u02B4\u02BC\u02BB\u02BA.SetVector(this.\u02B5\u02C0\u02B9\u02BA\u02BF\u02C0\u02BA\u02B8\u02C1\u02BD\u02B4, vector);
			spriteRenderer5.SetPropertyBlock(this.\u02B9\u02B6\u02B8\u02BB\u02BD\u02BB\u02BC\u02B4\u02BC\u02BB\u02BA);
			if (flag)
			{
				spriteRenderer5 = this.\u02B6\u02B8\u02B9\u02B4\u02B7\u02B2\u02C0\u02BC\u02BE\u02C1\u02B6[this.openSustainsThisFrame - 1];
				spriteRenderer5.GetPropertyBlock(this.\u02B9\u02B6\u02B8\u02BB\u02BD\u02BB\u02BC\u02B4\u02BC\u02BB\u02BA);
				this.\u02B9\u02B6\u02B8\u02BB\u02BD\u02BB\u02BC\u02B4\u02BC\u02BB\u02BA.SetVector(this.\u02BD\u02B7\u02BA\u02BC\u02BE\u02BB\u02BD\u02B4\u02B4\u02B9\u02BD, vector2);
				this.\u02B9\u02B6\u02B8\u02BB\u02BD\u02BB\u02BC\u02B4\u02BC\u02BB\u02BA.SetVector(this.\u02B5\u02C0\u02B9\u02BA\u02BF\u02C0\u02BA\u02B8\u02C1\u02BD\u02B4, this.\u02B4\u02B2\u02B3\u02BE\u02BE\u02B9\u02BE\u02B2\u02BD\u02B3\u02B5);
				spriteRenderer5.SetPropertyBlock(this.\u02B9\u02B6\u02B8\u02BB\u02BD\u02BB\u02BC\u02B4\u02BC\u02BB\u02BA);
			}
			else
			{
				spriteRenderer5 = this.\u02B5\u02BB\u02BD\u02B3\u02B6\u02BD\u02B5\u02C1\u02C0\u02B8\u02BF[this.sustainsThisFrame - 1];
				spriteRenderer5.GetPropertyBlock(this.\u02B9\u02B6\u02B8\u02BB\u02BD\u02BB\u02BC\u02B4\u02BC\u02BB\u02BA);
				this.\u02B9\u02B6\u02B8\u02BB\u02BD\u02BB\u02BC\u02B4\u02BC\u02BB\u02BA.SetFloat(this.\u02B6\u02B3\u02BC\u02BA\u02B4\u02BE\u02B4\u02B2\u02BA\u02C0\u02B7, num);
				spriteRenderer5.SetPropertyBlock(this.\u02B9\u02B6\u02B8\u02BB\u02BD\u02BB\u02BC\u02B4\u02BC\u02BB\u02BA);
			}
		}
	}

	private bool \u02B5\u02BD\u02B2\u02B6\u02B2\u02B5\u02BE\u02BF\u02B7\u02C1\u02BA()
	{
		return this.sustainsThisFrame >= this.\u02BC\u02BE\u02B9\u02BD\u02BC\u02B5\u02C0\u02C0\u02C0\u02B6\u02B4 || this.currentNoteIndex >= this.\u02B4\u02B5\u02BE\u02BC\u02B7\u02BF\u02C1\u02B8\u02C1\u02BF\u02C0;
	}

	protected void \u02BE\u02BF\u02BE\u02C1\u02BC\u02B5\u02B5\u02C1\u02BD\u02C0\u02BC(Note \u02B9\u02BF\u02B6\u02BE\u02BA\u02BE\u02C1\u02B4\u02BB\u02C1\u02B2, float \u02B9\u02BB\u02BC\u02B5\u02B4\u02B3\u02C1\u02B7\u02B7\u02B4\u02B2)
	{
		float num = \u02B9\u02BF\u02B6\u02BE\u02BA\u02BE\u02C1\u02B4\u02BB\u02C1\u02B2.length * this.\u02B7\u02BB\u02BA\u02C0\u02BF\u02B5\u02B5\u02B9\u02BD\u02C1\u02B4;
		Helper.\u02B2\u02B8\u02C1\u02BF\u02B7\u02B4\u02B2\u02B2\u02C0\u02B2\u02BA u02B2_u02B8_u02C1_u02BF_u02B7_u02B4_u02B2_u02B2_u02C0_u02B2_u02BA = Helper.\u02B8\u02C0\u02BA\u02BB\u02B6\u02BA\u02BA\u02C0\u02B4\u02C1\u02B9(\u02B9\u02BF\u02B6\u02BE\u02BA\u02BE\u02C1\u02B4\u02BB\u02C1\u02B2._noteMask).\u02BC\u02C0\u02B8\u02B9\u02B4\u02BB\u02BE\u02B6\u02BC\u02B7\u02C1();
		while (u02B2_u02B8_u02C1_u02BF_u02B7_u02B4_u02B2_u02B2_u02C0_u02B2_u02BA.\u02BF\u02B5\u02B7\u02BB\u02B5\u02BB\u02B7\u02B5\u02B6\u02BA\u02BC())
		{
			byte b = (byte)u02B2_u02B8_u02C1_u02BF_u02B7_u02B4_u02B2_u02B2_u02C0_u02B2_u02BA.\u02B9\u02BA\u02BB\u02B4\u02C0\u02B4\u02B6\u02B2\u02B9\u02B3\u02BF;
			float num2 = num + Mathf.Min(0f, \u02B9\u02BB\u02BC\u02B5\u02B4\u02B3\u02C1\u02B7\u02B7\u02B4\u02B2 - -0.7f);
			if (\u02B9\u02BF\u02B6\u02BE\u02BA\u02BE\u02C1\u02B4\u02BB\u02C1\u02B2._noteMask == 64)
			{
				if (this.\u02BD\u02B2\u02B6\u02B8\u02B7\u02B2\u02BA\u02B2\u02BF\u02BC\u02B6())
				{
					break;
				}
				GameObject gameObject = this.openSustainObjects[this.openSustainsThisFrame];
				SpriteRenderer spriteRenderer = this.\u02B6\u02B8\u02B9\u02B4\u02B7\u02B2\u02C0\u02BC\u02BE\u02C1\u02B6[this.openSustainsThisFrame];
				this.\u02B5\u02B6\u02BD\u02B2\u02BE\u02B6\u02B8\u02B5\u02C0\u02B2\u02B3[this.openSustainsThisFrame].enabled = false;
				gameObject.SetActive(!this.\u02B6\u02BB\u02B2\u02B5\u02BC\u02BB\u02B7\u02B3\u02C1\u02B4\u02B2);
				gameObject.transform.localPosition = new Vector3(0f, 0f, Mathf.Max(\u02B9\u02BB\u02BC\u02B5\u02B4\u02B3\u02C1\u02B7\u02B7\u02B4\u02B2, -0.7f));
				if (\u02B9\u02BF\u02B6\u02BE\u02BA\u02BE\u02C1\u02B4\u02BB\u02C1\u02B2.wasMissed)
				{
					spriteRenderer.color = Color.gray;
				}
				else if (this.basePlayer.\u02B4\u02BE\u02B5\u02B5\u02B4\u02BE\u02B3\u02C0\u02BC\u02BA\u02B9)
				{
					spriteRenderer.color = base.\u02B7\u02B9\u02BA\u02B6\u02B3\u02B4\u02B5\u02C1\u02B4\u02B9\u02B6.\u02B2\u02B3\u02BE\u02C0\u02B4\u02BE\u02B5\u02BD\u02BD\u02BB\u02BE;
				}
				else
				{
					spriteRenderer.color = base.\u02B7\u02B9\u02BA\u02B6\u02B3\u02B4\u02B5\u02C1\u02B4\u02B9\u02B6.\u02B3\u02C0\u02B2\u02C1\u02BD\u02B7\u02B9\u02BD\u02B6\u02B4\u02C1;
				}
				spriteRenderer.sprite = this.Sustains[4];
				spriteRenderer.GetPropertyBlock(this.\u02B9\u02B6\u02B8\u02BB\u02BD\u02BB\u02BC\u02B4\u02BC\u02BB\u02BA);
				this.\u02B9\u02B6\u02B8\u02BB\u02BD\u02BB\u02BC\u02B4\u02BC\u02BB\u02BA.SetVector(this.\u02BD\u02B7\u02BA\u02BC\u02BE\u02BB\u02BD\u02B4\u02B4\u02B9\u02BD, new Vector4(1f, num2, this.\u02BA\u02C1\u02B6\u02B4\u02B6\u02B6\u02B9\u02B7\u02B7\u02B2\u02BA, ((float)this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD.\u02BF\u02B8\u02BA\u02BB\u02BC\u02B5\u02BE\u02B7\u02C1\u02BA\u02BC.\u02B2\u02B3\u02BE\u02B9\u02B7\u02BB\u02B2\u02BB\u02C0\u02BC\u02B6 + this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD.\u02BF\u02B8\u02BA\u02BB\u02BC\u02B5\u02BE\u02B7\u02C1\u02BA\u02BC.\u02BB\u02B5\u02BB\u02B6\u02BF\u02B3\u02B5\u02B5\u02B6\u02BF\u02B7) / 1024f));
				this.\u02B9\u02B6\u02B8\u02BB\u02BD\u02BB\u02BC\u02B4\u02BC\u02BB\u02BA.SetVector(this.\u02B5\u02C0\u02B9\u02BA\u02BF\u02C0\u02BA\u02B8\u02C1\u02BD\u02B4, this.\u02B4\u02B2\u02B3\u02BE\u02BE\u02B9\u02BE\u02B2\u02BD\u02B3\u02B5);
				spriteRenderer.SetPropertyBlock(this.\u02B9\u02B6\u02B8\u02BB\u02BD\u02BB\u02BC\u02B4\u02BC\u02BB\u02BA);
				this.openSustainsThisFrame++;
			}
			else
			{
				if (this.\u02B5\u02BD\u02B2\u02B6\u02B2\u02B5\u02BE\u02BF\u02B7\u02C1\u02BA())
				{
					break;
				}
				GameObject gameObject2 = this.sustainObjects[this.sustainsThisFrame];
				SpriteRenderer spriteRenderer2 = this.\u02B5\u02BB\u02BD\u02B3\u02B6\u02BD\u02B5\u02C1\u02C0\u02B8\u02BF[this.sustainsThisFrame];
				spriteRenderer2.enabled = true;
				this.\u02BF\u02BD\u02B2\u02B3\u02B2\u02B4\u02B2\u02C1\u02BA\u02B5\u02B3[this.sustainsThisFrame].enabled = false;
				gameObject2.SetActive(!this.\u02B6\u02BB\u02B2\u02B5\u02BC\u02BB\u02B7\u02B3\u02C1\u02B4\u02B2);
				gameObject2.transform.localPosition = new Vector3(this.firstNoteXPos + this.\u02BD\u02B5\u02BC\u02B6\u02B5\u02BE\u02C1\u02BE\u02B7\u02C1\u02B5 * (float)b, 0f, Mathf.Max(\u02B9\u02BB\u02BC\u02B5\u02B4\u02B3\u02C1\u02B7\u02B7\u02B4\u02B2, -0.7f));
				if (\u02B9\u02BF\u02B6\u02BE\u02BA\u02BE\u02C1\u02B4\u02BB\u02C1\u02B2.wasMissed)
				{
					spriteRenderer2.color = Color.white;
					spriteRenderer2.sprite = this.Sustains[2];
				}
				else
				{
					if (this.basePlayer.\u02B4\u02BE\u02B5\u02B5\u02B4\u02BE\u02B3\u02C0\u02BC\u02BA\u02B9)
					{
						spriteRenderer2.color = base.\u02B7\u02B9\u02BA\u02B6\u02B3\u02B4\u02B5\u02C1\u02B4\u02B9\u02B6.\u02B2\u02B3\u02BE\u02C0\u02B4\u02BE\u02B5\u02BD\u02BD\u02BB\u02BE;
					}
					else
					{
						spriteRenderer2.color = base.\u02B7\u02B9\u02BA\u02B6\u02B3\u02B4\u02B5\u02C1\u02B4\u02B9\u02B6.\u02BC\u02C0\u02B7\u02BD\u02B7\u02B4\u02B6\u02B6\u02B2\u02B3\u02C1[(int)b];
					}
					spriteRenderer2.sprite = (\u02B9\u02BF\u02B6\u02BE\u02BA\u02BE\u02C1\u02B4\u02BB\u02C1\u02B2.IsTap ? this.Sustains[1] : this.Sustains[0]);
				}
				spriteRenderer2.GetPropertyBlock(this.\u02B9\u02B6\u02B8\u02BB\u02BD\u02BB\u02BC\u02B4\u02BC\u02BB\u02BA);
				this.\u02B9\u02B6\u02B8\u02BB\u02BD\u02BB\u02BC\u02B4\u02BC\u02BB\u02BA.SetFloat(this.\u02B6\u02B3\u02BC\u02BA\u02B4\u02BE\u02B4\u02B2\u02BA\u02C0\u02B7, num2);
				spriteRenderer2.SetPropertyBlock(this.\u02B9\u02B6\u02B8\u02BB\u02BD\u02BB\u02BC\u02B4\u02BC\u02BB\u02BA);
				this.sustainsThisFrame++;
			}
		}
	}

	private bool \u02B7\u02BF\u02C0\u02B6\u02B3\u02C1\u02C1\u02BC\u02BF\u02BD\u02BE()
	{
		return this.spritesThisFrame >= this.maxNotePool || this.currentNoteIndex >= this.\u02B4\u02B5\u02BE\u02BC\u02B7\u02BF\u02C1\u02B8\u02C1\u02BF\u02C0;
	}

	private void \u02C1\u02BE\u02BA\u02BF\u02BE\u02B8\u02B3\u02BA\u02B7\u02BA\u02B7()
	{
		float getFloatPercent = SettingsController.gem_size.GetFloatPercent;
		Vector2 vector = new Vector2(0.13f * getFloatPercent, 100.2f);
		Vector2 vector2 = new Vector2(0.3f * getFloatPercent, 101.2f);
		Vector2 vector3 = new Vector2(0.9f * getFloatPercent, 100.2f);
		Vector2 vector4 = new Vector2(0.85f * getFloatPercent, 100.2f);
		this.sustainObjects = new GameObject[this.\u02BC\u02BE\u02B9\u02BD\u02BC\u02B5\u02C0\u02C0\u02C0\u02B6\u02B4];
		GameObject gameObject = Resources.Load("Prefabs/Gameplay/Notes/Sustain") as GameObject;
		this.\u02B5\u02BB\u02BD\u02B3\u02B6\u02BD\u02B5\u02C1\u02C0\u02B8\u02BF = new SpriteRenderer[this.\u02BC\u02BE\u02B9\u02BD\u02BC\u02B5\u02C0\u02C0\u02C0\u02B6\u02B4];
		this.\u02BF\u02BD\u02B2\u02B3\u02B2\u02B4\u02B2\u02C1\u02BA\u02B5\u02B3 = new SpriteRenderer[this.\u02BC\u02BE\u02B9\u02BD\u02BC\u02B5\u02C0\u02C0\u02C0\u02B6\u02B4];
		for (int i = 0; i < this.sustainObjects.Length; i++)
		{
			this.sustainObjects[i] = global::UnityEngine.Object.Instantiate<GameObject>(gameObject, Vector3.zero, gameObject.transform.rotation);
			this.sustainObjects[i].SetActive(false);
			this.sustainObjects[i].transform.parent = base.transform;
			SpriteRenderer[] componentsInChildren = this.sustainObjects[i].GetComponentsInChildren<SpriteRenderer>();
			this.\u02B5\u02BB\u02BD\u02B3\u02B6\u02BD\u02B5\u02C1\u02C0\u02B8\u02BF[i] = componentsInChildren[0];
			this.\u02B5\u02BB\u02BD\u02B3\u02B6\u02BD\u02B5\u02C1\u02C0\u02B8\u02BF[i].sortingOrder = -1000;
			this.\u02B5\u02BB\u02BD\u02B3\u02B6\u02BD\u02B5\u02C1\u02C0\u02B8\u02BF[i].size = vector;
			this.\u02BF\u02BD\u02B2\u02B3\u02B2\u02B4\u02B2\u02C1\u02BA\u02B5\u02B3[i] = componentsInChildren[1];
			this.\u02BF\u02BD\u02B2\u02B3\u02B2\u02B4\u02B2\u02C1\u02BA\u02B5\u02B3[i].sortingOrder = -999;
			this.\u02BF\u02BD\u02B2\u02B3\u02B2\u02B4\u02B2\u02C1\u02BA\u02B5\u02B3[i].size = vector2;
		}
		this.openSustainObjects = new GameObject[this.\u02B5\u02B4\u02C0\u02B8\u02B3\u02B2\u02B9\u02C1\u02BB\u02B9\u02B7];
		GameObject gameObject2 = Resources.Load("Prefabs/Gameplay/Notes/Open_Sustain") as GameObject;
		this.\u02B6\u02B8\u02B9\u02B4\u02B7\u02B2\u02C0\u02BC\u02BE\u02C1\u02B6 = new SpriteRenderer[this.\u02B5\u02B4\u02C0\u02B8\u02B3\u02B2\u02B9\u02C1\u02BB\u02B9\u02B7];
		this.\u02B5\u02B6\u02BD\u02B2\u02BE\u02B6\u02B8\u02B5\u02C0\u02B2\u02B3 = new SpriteRenderer[this.\u02B5\u02B4\u02C0\u02B8\u02B3\u02B2\u02B9\u02C1\u02BB\u02B9\u02B7];
		for (int j = 0; j < this.openSustainObjects.Length; j++)
		{
			this.openSustainObjects[j] = global::UnityEngine.Object.Instantiate<GameObject>(gameObject2, Vector3.zero, gameObject2.transform.rotation);
			this.openSustainObjects[j].SetActive(false);
			this.openSustainObjects[j].transform.parent = base.transform;
			SpriteRenderer[] componentsInChildren2 = this.openSustainObjects[j].GetComponentsInChildren<SpriteRenderer>();
			this.\u02B6\u02B8\u02B9\u02B4\u02B7\u02B2\u02C0\u02BC\u02BE\u02C1\u02B6[j] = componentsInChildren2[0];
			this.\u02B6\u02B8\u02B9\u02B4\u02B7\u02B2\u02C0\u02BC\u02BE\u02C1\u02B6[j].sortingOrder = -1000;
			this.\u02B6\u02B8\u02B9\u02B4\u02B7\u02B2\u02C0\u02BC\u02BE\u02C1\u02B6[j].size = vector3;
			this.\u02B5\u02B6\u02BD\u02B2\u02BE\u02B6\u02B8\u02B5\u02C0\u02B2\u02B3[j] = componentsInChildren2[1];
			this.\u02B5\u02B6\u02BD\u02B2\u02BE\u02B6\u02B8\u02B5\u02C0\u02B2\u02B3[j].sortingOrder = -999;
			this.\u02B5\u02B6\u02BD\u02B2\u02BE\u02B6\u02B8\u02B5\u02C0\u02B2\u02B3[j].size = vector4;
		}
	}

	private bool \u02C0\u02BA\u02B2\u02BF\u02BF\u02B2\u02BF\u02BD\u02BC\u02BE\u02BA()
	{
		return this.sustainsThisFrame >= this.\u02BC\u02BE\u02B9\u02BD\u02BC\u02B5\u02C0\u02C0\u02C0\u02B6\u02B4 || this.currentNoteIndex < this.\u02B4\u02B5\u02BE\u02BC\u02B7\u02BF\u02C1\u02B8\u02C1\u02BF\u02C0;
	}

	protected override void Start()
	{
		this.\u02B4\u02B2\u02B9\u02BC\u02B4\u02B6\u02B2\u02B9\u02BC\u02BA\u02C1 = this.basePlayer.player.playerProfile.IsGamepadMode();
		this.\u02B4\u02B8\u02BA\u02BA\u02B2\u02BF\u02BC\u02C1\u02B6\u02BA\u02B4 = this.Sustains[0].border[3] / 2f / this.Sustains[0].rect.height;
		this.\u02B4\u02B7\u02B5\u02B2\u02C0\u02B3\u02B9\u02B9\u02BA\u02BC\u02C1 = 1f / (this.Sustains[0].rect.height / this.Sustains[0].pixelsPerUnit);
		this.\u02B9\u02B6\u02B8\u02BB\u02BD\u02BB\u02BC\u02B4\u02BC\u02BB\u02BA = new MaterialPropertyBlock();
		Vector2[] uv = this.Sustains[5].uv;
		this.\u02B6\u02BF\u02C1\u02B3\u02B8\u02B9\u02C0\u02B8\u02B3\u02B6\u02B8 = new Vector4(uv[0].x, uv[0].y, uv[3].x, uv[3].y);
		Vector2[] uv2 = this.Sustains[4].uv;
		this.\u02B4\u02B2\u02B3\u02BE\u02BE\u02B9\u02BE\u02B2\u02BD\u02B3\u02B5 = new Vector4(uv2[0].x, uv2[0].y, uv2[3].x, uv2[3].y);
		Vector2[] uv3 = this.Sustains[3].uv;
		this.\u02BA\u02BE\u02BD\u02BE\u02B6\u02B9\u02B4\u02B6\u02B9\u02C0\u02C0 = new Vector4(uv3[0].x, uv3[0].y, uv3[3].x, uv3[3].y);
		base.Start();
	}

	protected void \u02BF\u02BF\u02C1\u02B5\u02B3\u02B4\u02C0\u02B7\u02BB\u02B2\u02BB(Note \u02B9\u02BF\u02B6\u02BE\u02BA\u02BE\u02C1\u02B4\u02BB\u02C1\u02B2, float \u02B9\u02BB\u02BC\u02B5\u02B4\u02B3\u02C1\u02B7\u02B7\u02B4\u02B2)
	{
		Helper.\u02B2\u02B8\u02C1\u02BF\u02B7\u02B4\u02B2\u02B2\u02C0\u02B2\u02BA u02B2_u02B8_u02C1_u02BF_u02B7_u02B4_u02B2_u02B2_u02C0_u02B2_u02BA = Helper.\u02B8\u02C0\u02BA\u02BB\u02B6\u02BA\u02BA\u02C0\u02B4\u02C1\u02B9(\u02B9\u02BF\u02B6\u02BE\u02BA\u02BE\u02C1\u02B4\u02BB\u02C1\u02B2._noteMask).\u02BC\u02C0\u02B8\u02B9\u02B4\u02BB\u02BE\u02B6\u02BC\u02B7\u02C1();
		while (u02B2_u02B8_u02C1_u02BF_u02B7_u02B4_u02B2_u02B2_u02C0_u02B2_u02BA.\u02BF\u02B5\u02B7\u02BB\u02B5\u02BB\u02B7\u02B5\u02B6\u02BA\u02BC())
		{
			byte b = (byte)u02B2_u02B8_u02C1_u02BF_u02B7_u02B4_u02B2_u02B2_u02C0_u02B2_u02BA.\u02B9\u02BA\u02BB\u02B4\u02C0\u02B4\u02B6\u02B2\u02B9\u02B3\u02BF;
			if (this.\u02B7\u02BF\u02C0\u02B6\u02B3\u02C1\u02C1\u02BC\u02BF\u02BD\u02BE())
			{
				break;
			}
			bool flag = \u02B9\u02BF\u02B6\u02BE\u02BA\u02BE\u02C1\u02B4\u02BB\u02C1\u02B2._noteMask == 64;
			this.noteObjects[this.spritesThisFrame].SetActive(!this.\u02B6\u02BB\u02B2\u02B5\u02BC\u02BB\u02B7\u02B3\u02C1\u02B4\u02B2);
			Vector3 vector;
			if (BaseMenu.HAVEFUN && global::UnityEngine.Random.Range(0, 33) == 23)
			{
				vector.x = this.firstNoteXPos + this.\u02BD\u02B5\u02BC\u02B6\u02B5\u02BE\u02C1\u02BE\u02B7\u02C1\u02B5 * (float)global::UnityEngine.Random.Range(0, 5);
				vector.y = 0f;
				vector.z = global::UnityEngine.Random.Range(this.\u02B8\u02B4\u02B5\u02B8\u02C1\u02B4\u02B2\u02B4\u02BF\u02BC\u02BC, this.\u02BD\u02B4\u02B8\u02B9\u02BF\u02BF\u02B4\u02C0\u02C1\u02BC\u02BF);
			}
			else
			{
				vector.x = (flag ? 0f : (this.firstNoteXPos + this.\u02BD\u02B5\u02BC\u02B6\u02B5\u02BE\u02C1\u02BE\u02B7\u02C1\u02B5 * (float)b));
				vector.y = 0f;
				vector.z = \u02B9\u02BB\u02BC\u02B5\u02B4\u02B3\u02C1\u02B7\u02B7\u02B4\u02B2;
			}
			this.cachedNoteContainers[this.spritesThisFrame].\u02BF\u02BC\u02B7\u02B2\u02B9\u02BA\u02BD\u02B6\u02C0\u02C0\u02BE(vector, (int)b, \u02B9\u02BF\u02B6\u02BE\u02BA\u02BE\u02C1\u02B4\u02BB\u02C1\u02B2, this.basePlayer.\u02B4\u02BE\u02B5\u02B5\u02B4\u02BE\u02B3\u02C0\u02BC\u02BA\u02B9, false);
			this.spritesThisFrame++;
		}
	}

	private void \u02B5\u02B2\u02B7\u02C1\u02BB\u02C0\u02BF\u02B8\u02B4\u02B2\u02B2()
	{
		if (this.basePlayer.player.playerProfile.IsGHLController)
		{
			return;
		}
		for (int i = 0; i < this.cachedNoteContainers.Length; i++)
		{
			((NoteContainer)this.cachedNoteContainers[i]).\u02B7\u02B3\u02B3\u02BA\u02BD\u02B8\u02BF\u02BB\u02B6\u02BA\u02BB = this.basePlayer.player.playerProfile.altTaps;
		}
	}

	public float \u02BC\u02BC\u02BF\u02BD\u02B7\u02B7\u02BF\u02C0\u02C0\u02B6\u02BA;

	protected GameObject[] sustainObjects;

	protected GameObject[] openSustainObjects;

	protected SpriteRenderer[] \u02B5\u02BB\u02BD\u02B3\u02B6\u02BD\u02B5\u02C1\u02C0\u02B8\u02BF;

	protected SpriteRenderer[] \u02BF\u02BD\u02B2\u02B3\u02B2\u02B4\u02B2\u02C1\u02BA\u02B5\u02B3;

	protected SpriteRenderer[] \u02B6\u02B8\u02B9\u02B4\u02B7\u02B2\u02C0\u02BC\u02BE\u02C1\u02B6;

	protected SpriteRenderer[] \u02B5\u02B6\u02BD\u02B2\u02BE\u02B6\u02B8\u02B5\u02C0\u02B2\u02B3;

	protected int \u02BC\u02BE\u02B9\u02BD\u02BC\u02B5\u02C0\u02C0\u02C0\u02B6\u02B4 = 250;

	protected int \u02B5\u02B4\u02C0\u02B8\u02B3\u02B2\u02B9\u02C1\u02BB\u02B9\u02B7 = 50;

	[SerializeField]
	protected Sprite[] Sustains;

	protected float \u02B4\u02B8\u02BA\u02BA\u02B2\u02BF\u02BC\u02C1\u02B6\u02BA\u02B4;

	protected float \u02B4\u02B7\u02B5\u02B2\u02C0\u02B3\u02B9\u02B9\u02BA\u02BC\u02C1;

	protected int \u02BD\u02B7\u02BA\u02BC\u02BE\u02BB\u02BD\u02B4\u02B4\u02B9\u02BD = Shader.PropertyToID("_uSustainProperties");

	protected int \u02B5\u02C0\u02B9\u02BA\u02BF\u02C0\u02BA\u02B8\u02C1\u02BD\u02B4 = Shader.PropertyToID("_uUVProperties");

	protected int \u02B6\u02B3\u02BC\u02BA\u02B4\u02BE\u02B4\u02B2\u02BA\u02C0\u02B7 = Shader.PropertyToID("_TailLength");

	private Vector4 \u02B4\u02B2\u02B3\u02BE\u02BE\u02B9\u02BE\u02B2\u02BD\u02B3\u02B5;

	private Vector4 \u02B6\u02BF\u02C1\u02B3\u02B8\u02B9\u02C0\u02B8\u02B3\u02B6\u02B8;

	protected Vector4 \u02BA\u02BE\u02BD\u02BE\u02B6\u02B9\u02B4\u02B6\u02B9\u02C0\u02C0;

	protected MaterialPropertyBlock \u02B9\u02B6\u02B8\u02BB\u02BD\u02BB\u02BC\u02B4\u02BC\u02BB\u02BA;

	protected bool \u02B4\u02B2\u02B9\u02BC\u02B4\u02B6\u02B2\u02B9\u02BC\u02BA\u02C1;

	private int spritesThisFrame;

	private int sustainsThisFrame;

	private int openSustainsThisFrame;

	private int currentNoteIndex;

	private int \u02B4\u02B5\u02BE\u02BC\u02B7\u02BF\u02C1\u02B8\u02C1\u02BF\u02C0;
}
