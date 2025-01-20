using System;
using UnityEngine;

public class GHLNoteRenderer : GuitarNoteRenderer
{
	protected override void \u02BE\u02BD\u02BB\u02B8\u02B5\u02BF\u02BE\u02B6\u02BD\u02B9\u02BD()
	{
		base.\u02BE\u02BD\u02BB\u02B8\u02B5\u02BF\u02BE\u02B6\u02BD\u02B9\u02BD();
	}

	protected virtual void \u02B4\u02B2\u02B5\u02BA\u02B4\u02C0\u02BC\u02BB\u02C1\u02B9\u02BD()
	{
		base.Start();
		this.\u02B9\u02B6\u02B8\u02BB\u02BD\u02BB\u02BC\u02B4\u02BC\u02BB\u02BA = new MaterialPropertyBlock();
	}

	protected override int \u02C1\u02B7\u02C0\u02B7\u02B9\u02B2\u02B2\u02BF\u02BC\u02C0\u02BF(ushort \u02BF\u02BB\u02BB\u02BB\u02B6\u02B4\u02B8\u02BE\u02C0\u02C1\u02B9)
	{
		if (\u02BF\u02BB\u02BB\u02BB\u02B6\u02B4\u02B8\u02BE\u02C0\u02C1\u02B9 <= 8)
		{
			switch (\u02BF\u02BB\u02BB\u02BB\u02B6\u02B4\u02B8\u02BE\u02C0\u02C1\u02B9)
			{
			case 1:
				break;
			case 2:
				return 1;
			case 3:
				return -1;
			case 4:
				return 2;
			default:
				if (\u02BF\u02BB\u02BB\u02BB\u02B6\u02B4\u02B8\u02BE\u02C0\u02C1\u02B9 != 8)
				{
					return -1;
				}
				break;
			}
			return 0;
		}
		if (\u02BF\u02BB\u02BB\u02BB\u02B6\u02B4\u02B8\u02BE\u02C0\u02C1\u02B9 == 16)
		{
			return 1;
		}
		if (\u02BF\u02BB\u02BB\u02BB\u02B6\u02B4\u02B8\u02BE\u02C0\u02C1\u02B9 == 32)
		{
			return 2;
		}
		if (\u02BF\u02BB\u02BB\u02BB\u02B6\u02B4\u02B8\u02BE\u02C0\u02C1\u02B9 != 64)
		{
			return -1;
		}
		return 3;
	}

	protected override Color \u02C1\u02B7\u02BF\u02BF\u02B2\u02BD\u02BD\u02B8\u02C1\u02B2\u02C0(ushort \u02B6\u02BB\u02BC\u02B4\u02BC\u02BB\u02BC\u02BD\u02BC\u02BF\u02BB)
	{
		if (\u02B6\u02BB\u02BC\u02B4\u02BC\u02BB\u02BC\u02BD\u02BC\u02BF\u02BB <= 8)
		{
			switch (\u02B6\u02BB\u02BC\u02B4\u02BC\u02BB\u02BC\u02BD\u02BC\u02BF\u02BB)
			{
			case 1:
				return base.\u02B7\u02B9\u02BA\u02B6\u02B3\u02B4\u02B5\u02C1\u02B4\u02B9\u02B6.\u02BA\u02B9\u02B7\u02B9\u02B3\u02B9\u02BA\u02B7\u02BE\u02B8\u02B2;
			case 2:
				return base.\u02B7\u02B9\u02BA\u02B6\u02B3\u02B4\u02B5\u02C1\u02B4\u02B9\u02B6.\u02C0\u02BF\u02B8\u02B7\u02B2\u02BC\u02B2\u02B7\u02BF\u02BA\u02BC;
			case 3:
				break;
			case 4:
				return base.\u02B7\u02B9\u02BA\u02B6\u02B3\u02B4\u02B5\u02C1\u02B4\u02B9\u02B6.\u02B2\u02B3\u02B2\u02BD\u02BC\u02B4\u02BB\u02BE\u02BA\u02C0\u02BF;
			default:
				if (\u02B6\u02BB\u02BC\u02B4\u02BC\u02BB\u02BC\u02BD\u02BC\u02BF\u02BB == 8)
				{
					return base.\u02B7\u02B9\u02BA\u02B6\u02B3\u02B4\u02B5\u02C1\u02B4\u02B9\u02B6.\u02C0\u02C1\u02BE\u02BD\u02B6\u02B9\u02B4\u02BF\u02BD\u02BC\u02C0;
				}
				break;
			}
		}
		else
		{
			if (\u02B6\u02BB\u02BC\u02B4\u02BC\u02BB\u02BC\u02BD\u02BC\u02BF\u02BB == 16)
			{
				return base.\u02B7\u02B9\u02BA\u02B6\u02B3\u02B4\u02B5\u02C1\u02B4\u02B9\u02B6.\u02B2\u02B5\u02C0\u02BC\u02B7\u02BF\u02B2\u02B5\u02BD\u02BF\u02B7;
			}
			if (\u02B6\u02BB\u02BC\u02B4\u02BC\u02BB\u02BC\u02BD\u02BC\u02BF\u02BB == 32)
			{
				return base.\u02B7\u02B9\u02BA\u02B6\u02B3\u02B4\u02B5\u02C1\u02B4\u02B9\u02B6.\u02BB\u02BF\u02BB\u02BE\u02BB\u02BA\u02B6\u02BC\u02BD\u02B9\u02BD;
			}
		}
		return Color.white;
	}

	protected override void Update()
	{
		if (this.basePlayer.Notes == null || !GlobalHelper.willCurrentFrameRender)
		{
			return;
		}
		base.\u02B2\u02BF\u02B5\u02C1\u02B6\u02C0\u02B5\u02B5\u02B2\u02B2\u02B7();
		this.\u02BA\u02C1\u02B6\u02B4\u02B6\u02B6\u02B9\u02B7\u02B7\u02B2\u02BA += GlobalHelper.renderDeltaTime * (float)this.basePlayer.player.playerProfile.noteSpeed.CurrentValue * (this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD.\u02C0\u02C0\u02BA\u02BF\u02B3\u02BA\u02B5\u02BF\u02B9\u02BB\u02B5 ? 0f : 1f);
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		Vector3 zero = Vector3.zero;
		for (;;)
		{
			int num4 = this.noteStartIndex + num;
			if (num2 >= this.maxNotePool || num4 >= this.basePlayer.Notes.Count)
			{
				break;
			}
			Note note = this.basePlayer.Notes[num4];
			if ((double)note.time - this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD.\u02B7\u02B4\u02BA\u02B5\u02B5\u02B8\u02BE\u02B5\u02B3\u02B5\u02BB > (double)this.\u02B2\u02BE\u02B4\u02BE\u02B9\u02B5\u02B4\u02BA\u02B6\u02BF\u02B8)
			{
				break;
			}
			float num5 = Helper.\u02B5\u02B9\u02C1\u02BB\u02B6\u02B3\u02BA\u02BE\u02B9\u02B5\u02BF((double)note.time, this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD.\u02B7\u02B4\u02BA\u02B5\u02B5\u02B8\u02BE\u02B5\u02B3\u02B5\u02BB, this.\u02BB\u02BE\u02B6\u02B5\u02BD\u02BF\u02C1\u02B9\u02B4\u02B3\u02B9, this.\u02B7\u02BB\u02BA\u02C0\u02BF\u02B5\u02B5\u02B9\u02BD\u02C1\u02B4);
			float num6 = note.length * this.\u02B7\u02BB\u02BA\u02C0\u02BF\u02B5\u02B5\u02B9\u02BD\u02C1\u02B4;
			if (num == 0 && note.time + note.length < this.noteZPosCloseLimit)
			{
				this.noteStartIndex++;
			}
			else if (note.wasHit && !note.wasMissed)
			{
				num++;
			}
			else
			{
				if (!note.isSustaining)
				{
					ushort num7 = note._noteMask;
					ushort num8 = (ushort)\u02B6\u02C0\u02B5\u02C1\u02B9\u02BF\u02C0\u02B6\u02BF\u02B2\u02BE.\u02B6\u02BE\u02B6\u02BE\u02B4\u02BB\u02B3\u02BC\u02BF\u02B7\u02BC(num7);
					for (int i = 0; i < 4; i++)
					{
						if (((int)num8 & (1 << i)) != 0)
						{
							if (!note.isSustaining && !note.\u02BC\u02B9\u02B4\u02B6\u02B5\u02BC\u02BB\u02BC\u02BB\u02B4\u02B7)
							{
								zero.z = num5;
								this.noteObjects[num2].SetActive(!this.\u02B6\u02BB\u02B2\u02B5\u02BC\u02BB\u02B7\u02B3\u02C1\u02B4\u02B2);
								if (num7 == 64)
								{
									zero.x = 0f;
								}
								else
								{
									zero.x = this.firstNoteXPos + this.\u02BD\u02B5\u02BC\u02B6\u02B5\u02BE\u02C1\u02BE\u02B7\u02C1\u02B5 * (float)i;
								}
								this.cachedNoteContainers[num2].\u02BF\u02BC\u02B7\u02B2\u02B9\u02BA\u02BD\u02B6\u02C0\u02C0\u02BE(zero, i, note, this.basePlayer.\u02B4\u02BE\u02B5\u02B5\u02B4\u02BE\u02B3\u02C0\u02BC\u02BA\u02B9, this.basePlayer.player.playerProfile.leftyFlip.GetBoolValue);
								num2++;
							}
							if (note.length > 0f)
							{
								GameObject gameObject = this.sustainObjects[num3];
								SpriteRenderer spriteRenderer = this.\u02B5\u02BB\u02BD\u02B3\u02B6\u02BD\u02B5\u02C1\u02C0\u02B8\u02BF[num3];
								this.\u02BF\u02BD\u02B2\u02B3\u02B2\u02B4\u02B2\u02C1\u02BA\u02B5\u02B3[num3].enabled = false;
								gameObject.SetActive(!this.\u02B6\u02BB\u02B2\u02B5\u02BC\u02BB\u02B7\u02B3\u02C1\u02B4\u02B2);
								float num9 = 0f;
								if (num7 != 64)
								{
									num9 = this.firstNoteXPos + this.\u02BD\u02B5\u02BC\u02B6\u02B5\u02BE\u02C1\u02BE\u02B7\u02C1\u02B5 * (float)i;
								}
								gameObject.transform.localPosition = new Vector3(num9, 0f, num5);
								spriteRenderer.sortingOrder = -100;
								this.\u02BF\u02BD\u02B2\u02B3\u02B2\u02B4\u02B2\u02C1\u02BA\u02B5\u02B3[num3].sortingOrder = 0;
								if (note.wasMissed)
								{
									spriteRenderer.color = Color.white;
									spriteRenderer.sprite = this.Sustains[2];
								}
								else
								{
									if (this.basePlayer.\u02B4\u02BE\u02B5\u02B5\u02B4\u02BE\u02B3\u02C0\u02BC\u02BA\u02B9)
									{
										spriteRenderer.color = base.\u02B7\u02B9\u02BA\u02B6\u02B3\u02B4\u02B5\u02C1\u02B4\u02B9\u02B6.\u02BC\u02BD\u02B4\u02C0\u02BD\u02B6\u02B4\u02C1\u02B6\u02B2\u02BB;
									}
									else
									{
										spriteRenderer.color = base.\u02B7\u02B9\u02BA\u02B6\u02B3\u02B4\u02B5\u02C1\u02B4\u02B9\u02B6.\u02B7\u02BE\u02B3\u02B8\u02B9\u02B6\u02B3\u02B8\u02B2\u02BC\u02B3[i];
									}
									if (note.IsTap)
									{
										spriteRenderer.sprite = this.Sustains[1];
									}
									else
									{
										spriteRenderer.sprite = this.Sustains[0];
									}
								}
								spriteRenderer.GetPropertyBlock(this.\u02B9\u02B6\u02B8\u02BB\u02BD\u02BB\u02BC\u02B4\u02BC\u02BB\u02BA);
								this.\u02B9\u02B6\u02B8\u02BB\u02BD\u02BB\u02BC\u02B4\u02BC\u02BB\u02BA.SetFloat(this.\u02B6\u02B3\u02BC\u02BA\u02B4\u02BE\u02B4\u02B2\u02BA\u02C0\u02B7, num6);
								spriteRenderer.SetPropertyBlock(this.\u02B9\u02B6\u02B8\u02BB\u02BD\u02BB\u02BC\u02B4\u02BC\u02BB\u02BA);
								num3++;
							}
						}
					}
				}
				num++;
			}
		}
		if (this.\u02C0\u02C0\u02BA\u02B9\u02B7\u02B3\u02BB\u02B8\u02B8\u02B2\u02B3 != null)
		{
			foreach (Note note2 in this.\u02C0\u02C0\u02BA\u02B9\u02B7\u02B3\u02BB\u02B8\u02B8\u02B2\u02B3)
			{
				float num10 = (this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD.\u02C0\u02C0\u02BA\u02BF\u02B3\u02BA\u02B5\u02BF\u02B9\u02BB\u02B5 ? (note2.\u02B2\u02B8\u02B7\u02BD\u02B5\u02B7\u02B6\u02B2\u02BF\u02BD\u02C0 - (float)this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD.\u02B7\u02B4\u02BA\u02B5\u02B5\u02B8\u02BE\u02B5\u02B3\u02B5\u02BB) : note2.length) * this.\u02B7\u02BB\u02BA\u02C0\u02BF\u02B5\u02B5\u02B9\u02BD\u02C1\u02B4;
				byte b = (byte)(note2._noteMask >> 3);
				byte b2 = (byte)(note2._noteMask & 7);
				byte b3 = b | b2;
				for (int j = 0; j < 4; j++)
				{
					if (((int)b3 & (1 << j)) != 0)
					{
						GameObject gameObject2 = this.sustainObjects[num3];
						SpriteRenderer spriteRenderer2 = this.\u02B5\u02BB\u02BD\u02B3\u02B6\u02BD\u02B5\u02C1\u02C0\u02B8\u02BF[num3];
						spriteRenderer2.sprite = this.Sustains[3];
						SpriteRenderer spriteRenderer3 = this.\u02BF\u02BD\u02B2\u02B3\u02B2\u02B4\u02B2\u02C1\u02BA\u02B5\u02B3[num3];
						spriteRenderer3.enabled = true;
						gameObject2.SetActive(true);
						float num11 = this.firstNoteXPos + this.\u02BD\u02B5\u02BC\u02B6\u02B5\u02BE\u02C1\u02BE\u02B7\u02C1\u02B5 * (float)j;
						if (j == 3)
						{
							num11 = 0f;
						}
						gameObject2.transform.localPosition = new Vector3(num11, 0f, this.\u02BB\u02BE\u02B6\u02B5\u02BD\u02BF\u02C1\u02B9\u02B4\u02B3\u02B9);
						if (this.basePlayer.\u02B4\u02BE\u02B5\u02B5\u02B4\u02BE\u02B3\u02C0\u02BC\u02BA\u02B9 || (note2.isStarPower && ((BaseGuitarPlayer)this.basePlayer).whammyTimer > 0f))
						{
							spriteRenderer2.color = base.\u02B7\u02B9\u02BA\u02B6\u02B3\u02B4\u02B5\u02C1\u02B4\u02B9\u02B6.\u02BC\u02BD\u02B4\u02C0\u02BD\u02B6\u02B4\u02C1\u02B6\u02B2\u02BB;
						}
						else
						{
							spriteRenderer2.color = base.\u02B7\u02B9\u02BA\u02B6\u02B3\u02B4\u02B5\u02C1\u02B4\u02B9\u02B6.\u02B7\u02BE\u02B3\u02B8\u02B9\u02B6\u02B3\u02B8\u02B2\u02BC\u02B3[j];
						}
						spriteRenderer2.sortingOrder = -27001;
						spriteRenderer3.sortingOrder = -27000;
						spriteRenderer3.color = spriteRenderer2.color;
						int num12 = \u02BB\u02B3\u02BF\u02BC\u02B5\u02B7\u02BA\u02B9\u02C0\u02B8\u02BE.\u02BD\u02B9\u02B3\u02BB\u02BC\u02B9\u02B5\u02BB\u02B5\u02BE\u02BA(((b3 & 8) > 0) ? 1 : j, this.basePlayer.player.\u02BE\u02BB\u02B5\u02B7\u02B9\u02B2\u02B6\u02BF\u02B9\u02B7\u02B7);
						float num13 = (this.basePlayer as BaseGuitarPlayer).currentWhammy;
						if (this.\u02B4\u02B2\u02B9\u02BC\u02B4\u02B6\u02B2\u02B9\u02BC\u02BA\u02C1)
						{
							num13 = Mathf.Abs(num13);
						}
						this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD.\u02BF\u02B8\u02BA\u02BB\u02BC\u02B5\u02BE\u02B7\u02C1\u02BA\u02BC.\u02B2\u02B7\u02B8\u02B3\u02C1\u02BF\u02B4\u02B8\u02C0\u02C0\u02BA(num12, num13);
						spriteRenderer3.GetPropertyBlock(this.\u02B9\u02B6\u02B8\u02BB\u02BD\u02BB\u02BC\u02B4\u02BC\u02BB\u02BA);
						this.\u02B9\u02B6\u02B8\u02BB\u02BD\u02BB\u02BC\u02B4\u02BC\u02BB\u02BA.SetVector(this.\u02BD\u02B7\u02BA\u02BC\u02BE\u02BB\u02BD\u02B4\u02B4\u02B9\u02BD, new Vector4((float)num12, num10, this.\u02BA\u02C1\u02B6\u02B4\u02B6\u02B6\u02B9\u02B7\u02B7\u02B2\u02BA, ((float)this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD.\u02BF\u02B8\u02BA\u02BB\u02BC\u02B5\u02BE\u02B7\u02C1\u02BA\u02BC.\u02B2\u02B3\u02BE\u02B9\u02B7\u02BB\u02B2\u02BB\u02C0\u02BC\u02B6 + this.\u02C0\u02B9\u02B3\u02B4\u02B8\u02BA\u02B3\u02B4\u02B7\u02B5\u02BD.\u02BF\u02B8\u02BA\u02BB\u02BC\u02B5\u02BE\u02B7\u02C1\u02BA\u02BC.\u02BB\u02B5\u02BB\u02B6\u02BF\u02B3\u02B5\u02B5\u02B6\u02BF\u02B7) / 1024f));
						this.\u02B9\u02B6\u02B8\u02BB\u02BD\u02BB\u02BC\u02B4\u02BC\u02BB\u02BA.SetVector(this.\u02B5\u02C0\u02B9\u02BA\u02BF\u02C0\u02BA\u02B8\u02C1\u02BD\u02B4, this.\u02BA\u02BE\u02BD\u02BE\u02B6\u02B9\u02B4\u02B6\u02B9\u02C0\u02C0);
						spriteRenderer3.SetPropertyBlock(this.\u02B9\u02B6\u02B8\u02BB\u02BD\u02BB\u02BC\u02B4\u02BC\u02BB\u02BA);
						spriteRenderer2.GetPropertyBlock(this.\u02B9\u02B6\u02B8\u02BB\u02BD\u02BB\u02BC\u02B4\u02BC\u02BB\u02BA);
						this.\u02B9\u02B6\u02B8\u02BB\u02BD\u02BB\u02BC\u02B4\u02BC\u02BB\u02BA.SetFloat(this.\u02B6\u02B3\u02BC\u02BA\u02B4\u02BE\u02B4\u02B2\u02BA\u02C0\u02B7, num10);
						spriteRenderer2.SetPropertyBlock(this.\u02B9\u02B6\u02B8\u02BB\u02BD\u02BB\u02BC\u02B4\u02BC\u02BB\u02BA);
						num3++;
					}
				}
			}
		}
		BaseNoteRenderer.ClearRemainingObjPool(this.noteObjects, num2);
		BaseNoteRenderer.ClearRemainingObjPool(this.sustainObjects, num3);
	}

	protected virtual void \u02B7\u02B8\u02BD\u02C0\u02B2\u02B4\u02B7\u02C0\u02BC\u02BE\u02B3()
	{
		base.Start();
		this.\u02B9\u02B6\u02B8\u02BB\u02BD\u02BB\u02BC\u02B4\u02BC\u02BB\u02BA = new MaterialPropertyBlock();
	}

	protected override void Start()
	{
		base.Start();
		this.\u02B9\u02B6\u02B8\u02BB\u02BD\u02BB\u02BC\u02B4\u02BC\u02BB\u02BA = new MaterialPropertyBlock();
	}
}
