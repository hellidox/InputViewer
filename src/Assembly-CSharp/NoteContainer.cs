﻿using System;
using UnityEngine;

public class NoteContainer : MonoBehaviour, \u02BF\u02BB\u02BF\u02B2\u02B6\u02C1\u02BC\u02BD\u02B3\u02BB\u02BB, \u02C0\u02C1\u02B8\u02BF\u02BB\u02BB\u02B9\u02BC\u02B9\u02BD\u02B7
{
	public void \u02BF\u02BF\u02B7\u02B3\u02BF\u02BD\u02BE\u02B6\u02B4\u02BB\u02B4(\u02BB\u02B9\u02B2\u02B3\u02B4\u02B3\u02BF\u02C0\u02B4\u02B8\u02B9 \u02B6\u02B2\u02B5\u02BB\u02C1\u02BB\u02BA\u02B4\u02BF\u02BA\u02B5)
	{
		this.<\u02BC\u02BD\u02B9\u02BE\u02BD\u02B5\u02C1\u02B3\u02B5\u02B9\u02BE>k__BackingField = \u02B6\u02B2\u02B5\u02BB\u02C1\u02BB\u02BA\u02B4\u02BF\u02BA\u02B5;
	}

	public \u02BB\u02B9\u02B2\u02B3\u02B4\u02B3\u02BF\u02C0\u02B4\u02B8\u02B9 \u02B6\u02BA\u02B6\u02B6\u02BC\u02B7\u02C0\u02B6\u02C1\u02B8\u02C1()
	{
		return this.<\u02BC\u02BD\u02B9\u02BE\u02BD\u02B5\u02C1\u02B3\u02B5\u02B9\u02BE>k__BackingField;
	}

	public void \u02C0\u02BF\u02B4\u02B2\u02BC\u02B2\u02B2\u02B3\u02B6\u02BA\u02B9(Vector3 \u02B6\u02B2\u02B5\u02BB\u02C1\u02BB\u02BA\u02B4\u02BF\u02BA\u02B5)
	{
		this.<\u02B6\u02C1\u02BA\u02BA\u02B9\u02BC\u02B9\u02C0\u02BA\u02C0\u02B8>k__BackingField = \u02B6\u02B2\u02B5\u02BB\u02C1\u02BB\u02BA\u02B4\u02BF\u02BA\u02B5;
	}

	public virtual void \u02BF\u02BC\u02B7\u02B2\u02B9\u02BA\u02BD\u02B6\u02C0\u02C0\u02BE(Vector3 \u02B3\u02BF\u02B9\u02BA\u02B5\u02B9\u02B7\u02BC\u02BC\u02B8\u02B8, int \u02BE\u02C1\u02BE\u02B8\u02BB\u02B8\u02B6\u02BE\u02C1\u02BB\u02B4, Note \u02B9\u02BF\u02B6\u02BE\u02BA\u02BE\u02C1\u02B4\u02BB\u02C1\u02B2, bool \u02C1\u02B8\u02B4\u02B5\u02B3\u02BE\u02BD\u02BF\u02B9\u02B7\u02BF, bool \u02BB\u02C0\u02BA\u02BA\u02B9\u02B3\u02BB\u02B5\u02C0\u02B6\u02B3)
	{
		base.transform.localPosition = \u02B3\u02BF\u02B9\u02BA\u02B5\u02B9\u02B7\u02BC\u02BC\u02B8\u02B8;
		if (\u02B9\u02BF\u02B6\u02BE\u02BA\u02BE\u02C1\u02B4\u02BB\u02C1\u02B2._noteMask == 64 || (BaseMenu.\u02B6\u02B7\u02BD\u02BE\u02BB\u02BE\u02C0\u02C1\u02B7\u02B4\u02C0 && global::UnityEngine.Random.Range(0, 40) == 10))
		{
			this.\u02BF\u02C0\u02B8\u02B7\u02BF\u02B5\u02B9\u02BB\u02BF\u02C1\u02BA(\u02B9\u02BF\u02B6\u02BE\u02BA\u02BE\u02C1\u02B4\u02BB\u02C1\u02B2, \u02C1\u02B8\u02B4\u02B5\u02B3\u02BE\u02BD\u02BF\u02B9\u02B7\u02BF);
			return;
		}
		this.\u02B8\u02BE\u02B8\u02B7\u02B4\u02B6\u02BA\u02BA\u02B8\u02BB\u02C1(\u02BE\u02C1\u02BE\u02B8\u02BB\u02B8\u02B6\u02BE\u02C1\u02BB\u02B4, \u02B9\u02BF\u02B6\u02BE\u02BA\u02BE\u02C1\u02B4\u02BB\u02C1\u02B2, \u02C1\u02B8\u02B4\u02B5\u02B3\u02BE\u02BD\u02BF\u02B9\u02B7\u02BF);
	}

	public Vector3 \u02C0\u02BD\u02B2\u02B8\u02BF\u02B8\u02BC\u02BB\u02B7\u02B7\u02BD()
	{
		return this.<\u02B6\u02C1\u02BA\u02BA\u02B9\u02BC\u02B9\u02C0\u02BA\u02C0\u02B8>k__BackingField;
	}

	private void \u02B5\u02B4\u02B4\u02BD\u02B7\u02B2\u02B8\u02B8\u02BD\u02B5\u02B7(Note \u02B9\u02BF\u02B6\u02BE\u02BA\u02BE\u02C1\u02B4\u02BB\u02C1\u02B2, bool \u02C1\u02B8\u02B4\u02B5\u02B3\u02BE\u02BD\u02BF\u02B9\u02B7\u02BF)
	{
		this.Body.sprite = this.\u02BA\u02B2\u02BE\u02BA\u02B9\u02B3\u02B5\u02B4\u02C1\u02C1\u02B9;
		this.Body.color = Color.white;
		this.Head.sprite = this.\u02B7\u02B2\u02B8\u02BB\u02BA\u02BD\u02B7\u02B8\u02BB\u02B8\u02BB;
		this.Head.color = this.\u02B7\u02B9\u02BA\u02B6\u02B3\u02B4\u02B5\u02C1\u02B4\u02B9\u02B6.guitarNoteOpen;
		this.Anim.sprite = this.\u02BB\u02B5\u02B8\u02B2\u02BA\u02B6\u02B2\u02B9\u02BC\u02B3\u02BD[NoteAnimator.\u02B5\u02B8\u02C1\u02BF\u02C1\u02BA\u02B7\u02B4\u02B9\u02B7\u02BA];
		this.Body.sortingOrder = 67;
		this.Head.sortingOrder = 62;
		this.Anim.sortingOrder = -1;
		this.Open_HOPO.sortingOrder = 1;
		if (\u02B9\u02BF\u02B6\u02BE\u02BA\u02BE\u02C1\u02B4\u02BB\u02C1\u02B2.isStarPower)
		{
			this.Anim.sprite = this.\u02BB\u02BF\u02B9\u02B8\u02BC\u02B6\u02BE\u02B7\u02B8\u02BA\u02B2[NoteAnimator.\u02BB\u02BD\u02B2\u02B5\u02B8\u02B9\u02B5\u02BE\u02B9\u02BE\u02C1];
			this.Body.color = this.\u02B7\u02B9\u02BA\u02B6\u02B3\u02B4\u02B5\u02C1\u02B4\u02B9\u02B6.\u02C0\u02C1\u02B9\u02C0\u02B3\u02B4\u02B7\u02B6\u02B5\u02B3\u02B8;
			this.Anim.color = this.\u02B7\u02B9\u02BA\u02B6\u02B3\u02B4\u02B5\u02C1\u02B4\u02B9\u02B6.\u02C0\u02C1\u02B9\u02C0\u02B3\u02B4\u02B7\u02B6\u02B5\u02B3\u02B8;
		}
		else
		{
			this.Anim.sprite = this.\u02BB\u02B5\u02B8\u02B2\u02BA\u02B6\u02B2\u02B9\u02BC\u02B3\u02BD[NoteAnimator.\u02B5\u02B8\u02C1\u02BF\u02C1\u02BA\u02B7\u02B4\u02B9\u02B7\u02BA];
			this.Body.color = Color.white;
			this.Anim.color = this.\u02B6\u02BA\u02B6\u02B6\u02BC\u02B7\u02C0\u02B6\u02C1\u02B8\u02C1().\u02B9\u02BB\u02B4\u02C1\u02B5\u02C0\u02C1\u02C1\u02B5\u02C0\u02BC;
		}
		this.Open_HOPO.sprite = (\u02B9\u02BF\u02B6\u02BE\u02BA\u02BE\u02C1\u02B4\u02BB\u02C1\u02B2.IsHopo ? this.\u02B5\u02BC\u02B7\u02BA\u02C1\u02C1\u02B4\u02BA\u02C1\u02C0\u02B6 : null);
		if (\u02C1\u02B8\u02B4\u02B5\u02B3\u02BE\u02BD\u02BF\u02B9\u02B7\u02BF)
		{
			this.Head.color = this.\u02B6\u02BA\u02B6\u02B6\u02BC\u02B7\u02C0\u02B6\u02C1\u02B8\u02C1().\u02B2\u02B4\u02B8\u02BB\u02B6\u02BF\u02BA\u02B6\u02BB\u02BF\u02B8;
		}
	}

	private void \u02B3\u02BE\u02B6\u02C0\u02BF\u02BE\u02B4\u02C0\u02B8\u02B6\u02BE(int \u02BE\u02C1\u02BE\u02B8\u02BB\u02B8\u02B6\u02BE\u02C1\u02BB\u02B4, Note \u02B9\u02BF\u02B6\u02BE\u02BA\u02BE\u02C1\u02B4\u02BB\u02C1\u02B2, bool \u02C1\u02B8\u02B4\u02B5\u02B3\u02BE\u02BD\u02BF\u02B9\u02B7\u02BF)
	{
		this.Head.sortingOrder = 1;
		this.Anim.sortingOrder = -1;
		this.Body.sortingOrder = -106;
		if (\u02B9\u02BF\u02B6\u02BE\u02BA\u02BE\u02C1\u02B4\u02BB\u02C1\u02B2.isStarPower)
		{
			if (\u02B9\u02BF\u02B6\u02BE\u02BA\u02BE\u02C1\u02B4\u02BB\u02C1\u02B2.\u02BD\u02B9\u02B7\u02C1\u02BC\u02BE\u02BC\u02B8\u02BB\u02B5\u02B7())
			{
				this.Head.sprite = this.\u02B5\u02BF\u02BD\u02B5\u02B6\u02BD\u02BD\u02B7\u02C0\u02C0\u02B3;
			}
			else if (\u02B9\u02BF\u02B6\u02BE\u02BA\u02BE\u02C1\u02B4\u02BB\u02C1\u02B2.IsTap)
			{
				this.Head.sprite = (this.\u02B7\u02B3\u02B3\u02BA\u02BD\u02B8\u02BF\u02BB\u02B6\u02BA\u02BB ? this.\u02B9\u02BD\u02B4\u02BD\u02BD\u02BE\u02B7\u02B5\u02B5\u02BB\u02B5 : this.\u02B8\u02C0\u02B2\u02BC\u02BB\u02C1\u02BA\u02C0\u02BB\u02B8\u02BC);
			}
			else
			{
				this.Head.sprite = this.\u02B8\u02C0\u02B2\u02BC\u02BB\u02C1\u02BA\u02C0\u02BB\u02B8\u02BC;
			}
			this.Body.sprite = (\u02B9\u02BF\u02B6\u02BE\u02BA\u02BE\u02C1\u02B4\u02BB\u02C1\u02B2.IsTap ? this.\u02B2\u02BC\u02BB\u02B7\u02BD\u02C1\u02BB\u02C0\u02BC\u02BD\u02BD[NoteAnimator.\u02BB\u02BD\u02B2\u02B5\u02B8\u02B9\u02B5\u02BE\u02B9\u02BE\u02C1] : this.\u02BE\u02BE\u02BA\u02B9\u02B6\u02BC\u02B2\u02B5\u02B9\u02BC\u02BC[NoteAnimator.\u02BB\u02BD\u02B2\u02B5\u02B8\u02B9\u02B5\u02BE\u02B9\u02BE\u02C1]);
			this.Anim.sprite = this.\u02BF\u02B5\u02BC\u02BE\u02BF\u02BF\u02BA\u02BC\u02BD\u02B6\u02B4[NoteAnimator.\u02BB\u02BD\u02B2\u02B5\u02B8\u02B9\u02B5\u02BE\u02B9\u02BE\u02C1];
			if (\u02C1\u02B8\u02B4\u02B5\u02B3\u02BE\u02BD\u02BF\u02B9\u02B7\u02BF)
			{
				this.Anim.color = this.\u02B6\u02BA\u02B6\u02B6\u02BC\u02B7\u02C0\u02B6\u02C1\u02B8\u02C1().\u02B8\u02BB\u02B5\u02B6\u02B5\u02B2\u02B9\u02BC\u02C1\u02BC\u02B7;
				this.Body.color = this.\u02B6\u02BA\u02B6\u02B6\u02BC\u02B7\u02C0\u02B6\u02C1\u02B8\u02C1().\u02C0\u02B6\u02B9\u02B8\u02B4\u02BE\u02BC\u02B4\u02C1\u02BF\u02B6;
			}
			else
			{
				this.Anim.color = this.\u02B7\u02B9\u02BA\u02B6\u02B3\u02B4\u02B5\u02C1\u02B4\u02B9\u02B6.\u02B3\u02B5\u02BF\u02B4\u02BB\u02B7\u02B7\u02B7\u02B8\u02B9\u02BC;
				this.Body.color = this.\u02B7\u02B9\u02BA\u02B6\u02B3\u02B4\u02B5\u02C1\u02B4\u02B9\u02B6.\u02B3\u02B3\u02BF\u02B3\u02C0\u02B6\u02BC\u02BB\u02B3\u02B6\u02B8[\u02BE\u02C1\u02BE\u02B8\u02BB\u02B8\u02B6\u02BE\u02C1\u02BB\u02B4];
			}
		}
		else
		{
			this.Head.color = Color.white;
			if (\u02B9\u02BF\u02B6\u02BE\u02BA\u02BE\u02C1\u02B4\u02BB\u02C1\u02B2.IsTap)
			{
				this.Body.sprite = this.\u02B5\u02BF\u02BB\u02BE\u02BC\u02C0\u02B5\u02C1\u02B7\u02BC\u02BF;
				this.Anim.sprite = null;
				if (this.\u02B7\u02B3\u02B3\u02BA\u02BD\u02B8\u02BF\u02BB\u02B6\u02BA\u02BB)
				{
					this.Head.sprite = this.\u02BE\u02BE\u02B9\u02BA\u02B7\u02BE\u02C0\u02B4\u02B8\u02C0\u02BE;
				}
				else
				{
					this.Head.sprite = this.\u02C0\u02BA\u02C1\u02B3\u02BF\u02B5\u02B4\u02BE\u02BC\u02B7\u02C0;
				}
			}
			else
			{
				this.Body.sprite = this.\u02B6\u02BE\u02B6\u02B2\u02BA\u02BA\u02BB\u02BB\u02C0\u02BE\u02B6;
				this.Anim.sprite = this.\u02B4\u02B6\u02B2\u02B8\u02C1\u02C0\u02B9\u02BF\u02B7\u02B9\u02B5[NoteAnimator.\u02B5\u02B8\u02C1\u02BF\u02C1\u02BA\u02B7\u02B4\u02B9\u02B7\u02BA];
				this.Head.sprite = (\u02B9\u02BF\u02B6\u02BE\u02BA\u02BE\u02C1\u02B4\u02BB\u02C1\u02B2.IsPureHopo ? this.\u02BA\u02B5\u02BE\u02B4\u02BD\u02B4\u02B8\u02B4\u02BA\u02BA\u02B5 : this.\u02C0\u02BA\u02C1\u02B3\u02BF\u02B5\u02B4\u02BE\u02BC\u02B7\u02C0);
			}
			if (\u02C1\u02B8\u02B4\u02B5\u02B3\u02BE\u02BD\u02BF\u02B9\u02B7\u02BF)
			{
				this.Anim.color = this.\u02B7\u02B9\u02BA\u02B6\u02B3\u02B4\u02B5\u02C1\u02B4\u02B9\u02B6.\u02B4\u02BA\u02BA\u02B6\u02B2\u02BE\u02B2\u02C1\u02C0\u02B6\u02B6;
				this.Body.color = this.\u02B6\u02BA\u02B6\u02B6\u02BC\u02B7\u02C0\u02B6\u02C1\u02B8\u02C1().\u02B2\u02B4\u02B8\u02BB\u02B6\u02BF\u02BA\u02B6\u02BB\u02BF\u02B8;
			}
			else
			{
				this.Anim.color = this.\u02BB\u02C0\u02BB\u02C0\u02C1\u02B3\u02BD\u02B3\u02B2\u02B6\u02C1().\u02B6\u02C0\u02B8\u02BE\u02B3\u02BF\u02B3\u02C0\u02BA\u02C0\u02B2[\u02BE\u02C1\u02BE\u02B8\u02BB\u02B8\u02B6\u02BE\u02C1\u02BB\u02B4];
				this.Body.color = this.\u02B7\u02B9\u02BA\u02B6\u02B3\u02B4\u02B5\u02C1\u02B4\u02B9\u02B6.\u02B3\u02B3\u02BF\u02B3\u02C0\u02B6\u02BC\u02BB\u02B3\u02B6\u02B8[\u02BE\u02C1\u02BE\u02B8\u02BB\u02B8\u02B6\u02BE\u02C1\u02BB\u02B4];
			}
		}
		this.Head.color = Color.white;
		this.Open_HOPO.sprite = null;
	}

	public virtual void \u02B2\u02BA\u02BE\u02B9\u02BD\u02B9\u02BE\u02B2\u02BA\u02BD\u02B2(Vector3 \u02B3\u02BF\u02B9\u02BA\u02B5\u02B9\u02B7\u02BC\u02BC\u02B8\u02B8, int \u02BE\u02C1\u02BE\u02B8\u02BB\u02B8\u02B6\u02BE\u02C1\u02BB\u02B4, Note \u02B9\u02BF\u02B6\u02BE\u02BA\u02BE\u02C1\u02B4\u02BB\u02C1\u02B2, bool \u02C1\u02B8\u02B4\u02B5\u02B3\u02BE\u02BD\u02BF\u02B9\u02B7\u02BF, bool \u02BB\u02C0\u02BA\u02BA\u02B9\u02B3\u02BB\u02B5\u02C0\u02B6\u02B3)
	{
		base.transform.localPosition = \u02B3\u02BF\u02B9\u02BA\u02B5\u02B9\u02B7\u02BC\u02BC\u02B8\u02B8;
		if ((int)\u02B9\u02BF\u02B6\u02BE\u02BA\u02BE\u02C1\u02B4\u02BB\u02C1\u02B2._noteMask == -15 || (BaseMenu.\u02B6\u02B7\u02BD\u02BE\u02BB\u02BE\u02C0\u02C1\u02B7\u02B4\u02C0 && global::UnityEngine.Random.Range(0, -9) == -43))
		{
			this.\u02BF\u02C0\u02B8\u02B7\u02BF\u02B5\u02B9\u02BB\u02BF\u02C1\u02BA(\u02B9\u02BF\u02B6\u02BE\u02BA\u02BE\u02C1\u02B4\u02BB\u02C1\u02B2, \u02C1\u02B8\u02B4\u02B5\u02B3\u02BE\u02BD\u02BF\u02B9\u02B7\u02BF);
			return;
		}
		this.\u02B3\u02BE\u02B6\u02C0\u02BF\u02BE\u02B4\u02C0\u02B8\u02B6\u02BE(\u02BE\u02C1\u02BE\u02B8\u02BB\u02B8\u02B6\u02BE\u02C1\u02BB\u02B4, \u02B9\u02BF\u02B6\u02BE\u02BA\u02BE\u02C1\u02B4\u02BB\u02C1\u02B2, \u02C1\u02B8\u02B4\u02B5\u02B3\u02BE\u02BD\u02BF\u02B9\u02B7\u02BF);
	}

	private void \u02B8\u02BE\u02B8\u02B7\u02B4\u02B6\u02BA\u02BA\u02B8\u02BB\u02C1(int \u02BE\u02C1\u02BE\u02B8\u02BB\u02B8\u02B6\u02BE\u02C1\u02BB\u02B4, Note \u02B9\u02BF\u02B6\u02BE\u02BA\u02BE\u02C1\u02B4\u02BB\u02C1\u02B2, bool \u02C1\u02B8\u02B4\u02B5\u02B3\u02BE\u02BD\u02BF\u02B9\u02B7\u02BF)
	{
		this.Head.sortingOrder = 0;
		this.Anim.sortingOrder = -1;
		this.Body.sortingOrder = -2;
		if (\u02B9\u02BF\u02B6\u02BE\u02BA\u02BE\u02C1\u02B4\u02BB\u02C1\u02B2.isStarPower)
		{
			if (\u02B9\u02BF\u02B6\u02BE\u02BA\u02BE\u02C1\u02B4\u02BB\u02C1\u02B2.IsPureHopo)
			{
				this.Head.sprite = this.\u02B5\u02BF\u02BD\u02B5\u02B6\u02BD\u02BD\u02B7\u02C0\u02C0\u02B3;
			}
			else if (\u02B9\u02BF\u02B6\u02BE\u02BA\u02BE\u02C1\u02B4\u02BB\u02C1\u02B2.IsTap)
			{
				this.Head.sprite = (this.\u02B7\u02B3\u02B3\u02BA\u02BD\u02B8\u02BF\u02BB\u02B6\u02BA\u02BB ? this.\u02B9\u02BD\u02B4\u02BD\u02BD\u02BE\u02B7\u02B5\u02B5\u02BB\u02B5 : this.\u02B8\u02C0\u02B2\u02BC\u02BB\u02C1\u02BA\u02C0\u02BB\u02B8\u02BC);
			}
			else
			{
				this.Head.sprite = this.\u02B8\u02C0\u02B2\u02BC\u02BB\u02C1\u02BA\u02C0\u02BB\u02B8\u02BC;
			}
			this.Body.sprite = (\u02B9\u02BF\u02B6\u02BE\u02BA\u02BE\u02C1\u02B4\u02BB\u02C1\u02B2.IsTap ? this.\u02B2\u02BC\u02BB\u02B7\u02BD\u02C1\u02BB\u02C0\u02BC\u02BD\u02BD[NoteAnimator.\u02BB\u02BD\u02B2\u02B5\u02B8\u02B9\u02B5\u02BE\u02B9\u02BE\u02C1] : this.\u02BE\u02BE\u02BA\u02B9\u02B6\u02BC\u02B2\u02B5\u02B9\u02BC\u02BC[NoteAnimator.\u02BB\u02BD\u02B2\u02B5\u02B8\u02B9\u02B5\u02BE\u02B9\u02BE\u02C1]);
			this.Anim.sprite = this.\u02BF\u02B5\u02BC\u02BE\u02BF\u02BF\u02BA\u02BC\u02BD\u02B6\u02B4[NoteAnimator.\u02BB\u02BD\u02B2\u02B5\u02B8\u02B9\u02B5\u02BE\u02B9\u02BE\u02C1];
			if (\u02C1\u02B8\u02B4\u02B5\u02B3\u02BE\u02BD\u02BF\u02B9\u02B7\u02BF)
			{
				this.Anim.color = this.\u02B7\u02B9\u02BA\u02B6\u02B3\u02B4\u02B5\u02C1\u02B4\u02B9\u02B6.\u02B8\u02BB\u02B5\u02B6\u02B5\u02B2\u02B9\u02BC\u02C1\u02BC\u02B7;
				this.Body.color = this.\u02B7\u02B9\u02BA\u02B6\u02B3\u02B4\u02B5\u02C1\u02B4\u02B9\u02B6.\u02C0\u02B6\u02B9\u02B8\u02B4\u02BE\u02BC\u02B4\u02C1\u02BF\u02B6;
			}
			else
			{
				this.Anim.color = this.\u02B7\u02B9\u02BA\u02B6\u02B3\u02B4\u02B5\u02C1\u02B4\u02B9\u02B6.\u02B3\u02B5\u02BF\u02B4\u02BB\u02B7\u02B7\u02B7\u02B8\u02B9\u02BC;
				this.Body.color = this.\u02B7\u02B9\u02BA\u02B6\u02B3\u02B4\u02B5\u02C1\u02B4\u02B9\u02B6.\u02B3\u02B3\u02BF\u02B3\u02C0\u02B6\u02BC\u02BB\u02B3\u02B6\u02B8[\u02BE\u02C1\u02BE\u02B8\u02BB\u02B8\u02B6\u02BE\u02C1\u02BB\u02B4];
			}
		}
		else
		{
			this.Head.color = Color.white;
			if (\u02B9\u02BF\u02B6\u02BE\u02BA\u02BE\u02C1\u02B4\u02BB\u02C1\u02B2.IsTap)
			{
				this.Body.sprite = this.\u02B5\u02BF\u02BB\u02BE\u02BC\u02C0\u02B5\u02C1\u02B7\u02BC\u02BF;
				this.Anim.sprite = null;
				if (this.\u02B7\u02B3\u02B3\u02BA\u02BD\u02B8\u02BF\u02BB\u02B6\u02BA\u02BB)
				{
					this.Head.sprite = this.\u02BE\u02BE\u02B9\u02BA\u02B7\u02BE\u02C0\u02B4\u02B8\u02C0\u02BE;
				}
				else
				{
					this.Head.sprite = this.\u02C0\u02BA\u02C1\u02B3\u02BF\u02B5\u02B4\u02BE\u02BC\u02B7\u02C0;
				}
			}
			else
			{
				this.Body.sprite = this.\u02B6\u02BE\u02B6\u02B2\u02BA\u02BA\u02BB\u02BB\u02C0\u02BE\u02B6;
				this.Anim.sprite = this.\u02B4\u02B6\u02B2\u02B8\u02C1\u02C0\u02B9\u02BF\u02B7\u02B9\u02B5[NoteAnimator.\u02B5\u02B8\u02C1\u02BF\u02C1\u02BA\u02B7\u02B4\u02B9\u02B7\u02BA];
				this.Head.sprite = (\u02B9\u02BF\u02B6\u02BE\u02BA\u02BE\u02C1\u02B4\u02BB\u02C1\u02B2.IsPureHopo ? this.\u02BA\u02B5\u02BE\u02B4\u02BD\u02B4\u02B8\u02B4\u02BA\u02BA\u02B5 : this.\u02C0\u02BA\u02C1\u02B3\u02BF\u02B5\u02B4\u02BE\u02BC\u02B7\u02C0);
			}
			if (\u02C1\u02B8\u02B4\u02B5\u02B3\u02BE\u02BD\u02BF\u02B9\u02B7\u02BF)
			{
				this.Anim.color = this.\u02B7\u02B9\u02BA\u02B6\u02B3\u02B4\u02B5\u02C1\u02B4\u02B9\u02B6.\u02B4\u02BA\u02BA\u02B6\u02B2\u02BE\u02B2\u02C1\u02C0\u02B6\u02B6;
				this.Body.color = this.\u02B7\u02B9\u02BA\u02B6\u02B3\u02B4\u02B5\u02C1\u02B4\u02B9\u02B6.\u02B2\u02B4\u02B8\u02BB\u02B6\u02BF\u02BA\u02B6\u02BB\u02BF\u02B8;
			}
			else
			{
				this.Anim.color = this.\u02B7\u02B9\u02BA\u02B6\u02B3\u02B4\u02B5\u02C1\u02B4\u02B9\u02B6.\u02B6\u02C0\u02B8\u02BE\u02B3\u02BF\u02B3\u02C0\u02BA\u02C0\u02B2[\u02BE\u02C1\u02BE\u02B8\u02BB\u02B8\u02B6\u02BE\u02C1\u02BB\u02B4];
				this.Body.color = this.\u02B7\u02B9\u02BA\u02B6\u02B3\u02B4\u02B5\u02C1\u02B4\u02B9\u02B6.\u02B3\u02B3\u02BF\u02B3\u02C0\u02B6\u02BC\u02BB\u02B3\u02B6\u02B8[\u02BE\u02C1\u02BE\u02B8\u02BB\u02B8\u02B6\u02BE\u02C1\u02BB\u02B4];
			}
		}
		this.Head.color = Color.white;
		this.Open_HOPO.sprite = null;
	}

	public Vector3 \u02B8\u02C0\u02BF\u02BE\u02BF\u02B9\u02BE\u02B3\u02BA\u02BF\u02B7 { get; set; }

	public \u02BB\u02B9\u02B2\u02B3\u02B4\u02B3\u02BF\u02C0\u02B4\u02B8\u02B9 \u02BB\u02C0\u02BB\u02C0\u02C1\u02B3\u02BD\u02B3\u02B2\u02B6\u02C1()
	{
		return this.<\u02BC\u02BD\u02B9\u02BE\u02BD\u02B5\u02C1\u02B3\u02B5\u02B9\u02BE>k__BackingField;
	}

	public void \u02BE\u02BD\u02B6\u02B8\u02B5\u02BC\u02B7\u02BE\u02C0\u02B2\u02B6(\u02BB\u02B9\u02B2\u02B3\u02B4\u02B3\u02BF\u02C0\u02B4\u02B8\u02B9 \u02B6\u02B2\u02B5\u02BB\u02C1\u02BB\u02BA\u02B4\u02BF\u02BA\u02B5)
	{
		this.<\u02BC\u02BD\u02B9\u02BE\u02BD\u02B5\u02C1\u02B3\u02B5\u02B9\u02BE>k__BackingField = \u02B6\u02B2\u02B5\u02BB\u02C1\u02BB\u02BA\u02B4\u02BF\u02BA\u02B5;
	}

	public \u02BB\u02B9\u02B2\u02B3\u02B4\u02B3\u02BF\u02C0\u02B4\u02B8\u02B9 \u02B7\u02B9\u02BA\u02B6\u02B3\u02B4\u02B5\u02C1\u02B4\u02B9\u02B6 { get; set; }

	public void \u02B3\u02B4\u02B7\u02B7\u02BA\u02B6\u02B7\u02BF\u02B4\u02B2\u02B6(Vector3 \u02B6\u02B2\u02B5\u02BB\u02C1\u02BB\u02BA\u02B4\u02BF\u02BA\u02B5)
	{
		this.<\u02B6\u02C1\u02BA\u02BA\u02B9\u02BC\u02B9\u02C0\u02BA\u02C0\u02B8>k__BackingField = \u02B6\u02B2\u02B5\u02BB\u02C1\u02BB\u02BA\u02B4\u02BF\u02BA\u02B5;
	}

	private void \u02B2\u02B3\u02BE\u02BF\u02B3\u02BC\u02B3\u02B5\u02C1\u02B3\u02B8(Note \u02B9\u02BF\u02B6\u02BE\u02BA\u02BE\u02C1\u02B4\u02BB\u02C1\u02B2, bool \u02C1\u02B8\u02B4\u02B5\u02B3\u02BE\u02BD\u02BF\u02B9\u02B7\u02BF)
	{
		this.Body.sprite = this.\u02BA\u02B2\u02BE\u02BA\u02B9\u02B3\u02B5\u02B4\u02C1\u02C1\u02B9;
		this.Body.color = Color.white;
		this.Head.sprite = this.\u02B7\u02B2\u02B8\u02BB\u02BA\u02BD\u02B7\u02B8\u02BB\u02B8\u02BB;
		this.Head.color = this.\u02BB\u02C0\u02BB\u02C0\u02C1\u02B3\u02BD\u02B3\u02B2\u02B6\u02C1().guitarNoteOpen;
		this.Anim.sprite = this.\u02BB\u02B5\u02B8\u02B2\u02BA\u02B6\u02B2\u02B9\u02BC\u02B3\u02BD[NoteAnimator.\u02B5\u02B8\u02C1\u02BF\u02C1\u02BA\u02B7\u02B4\u02B9\u02B7\u02BA];
		this.Body.sortingOrder = 34;
		this.Head.sortingOrder = 23;
		this.Anim.sortingOrder = -1;
		this.Open_HOPO.sortingOrder = 1;
		if (\u02B9\u02BF\u02B6\u02BE\u02BA\u02BE\u02C1\u02B4\u02BB\u02C1\u02B2.isStarPower)
		{
			this.Anim.sprite = this.\u02BB\u02BF\u02B9\u02B8\u02BC\u02B6\u02BE\u02B7\u02B8\u02BA\u02B2[NoteAnimator.\u02BB\u02BD\u02B2\u02B5\u02B8\u02B9\u02B5\u02BE\u02B9\u02BE\u02C1];
			this.Body.color = this.\u02BB\u02C0\u02BB\u02C0\u02C1\u02B3\u02BD\u02B3\u02B2\u02B6\u02C1().\u02C0\u02C1\u02B9\u02C0\u02B3\u02B4\u02B7\u02B6\u02B5\u02B3\u02B8;
			this.Anim.color = this.\u02B6\u02BA\u02B6\u02B6\u02BC\u02B7\u02C0\u02B6\u02C1\u02B8\u02C1().\u02C0\u02C1\u02B9\u02C0\u02B3\u02B4\u02B7\u02B6\u02B5\u02B3\u02B8;
		}
		else
		{
			this.Anim.sprite = this.\u02BB\u02B5\u02B8\u02B2\u02BA\u02B6\u02B2\u02B9\u02BC\u02B3\u02BD[NoteAnimator.\u02B5\u02B8\u02C1\u02BF\u02C1\u02BA\u02B7\u02B4\u02B9\u02B7\u02BA];
			this.Body.color = Color.white;
			this.Anim.color = this.\u02B6\u02BA\u02B6\u02B6\u02BC\u02B7\u02C0\u02B6\u02C1\u02B8\u02C1().\u02B9\u02BB\u02B4\u02C1\u02B5\u02C0\u02C1\u02C1\u02B5\u02C0\u02BC;
		}
		this.Open_HOPO.sprite = (\u02B9\u02BF\u02B6\u02BE\u02BA\u02BE\u02C1\u02B4\u02BB\u02C1\u02B2.IsHopo ? this.\u02B5\u02BC\u02B7\u02BA\u02C1\u02C1\u02B4\u02BA\u02C1\u02C0\u02B6 : null);
		if (\u02C1\u02B8\u02B4\u02B5\u02B3\u02BE\u02BD\u02BF\u02B9\u02B7\u02BF)
		{
			this.Head.color = this.\u02BB\u02C0\u02BB\u02C0\u02C1\u02B3\u02BD\u02B3\u02B2\u02B6\u02C1().\u02B2\u02B4\u02B8\u02BB\u02B6\u02BF\u02BA\u02B6\u02BB\u02BF\u02B8;
		}
	}

	private void \u02BF\u02C0\u02B8\u02B7\u02BF\u02B5\u02B9\u02BB\u02BF\u02C1\u02BA(Note \u02B9\u02BF\u02B6\u02BE\u02BA\u02BE\u02C1\u02B4\u02BB\u02C1\u02B2, bool \u02C1\u02B8\u02B4\u02B5\u02B3\u02BE\u02BD\u02BF\u02B9\u02B7\u02BF)
	{
		this.Body.sprite = this.\u02BA\u02B2\u02BE\u02BA\u02B9\u02B3\u02B5\u02B4\u02C1\u02C1\u02B9;
		this.Body.color = Color.white;
		this.Head.sprite = this.\u02B7\u02B2\u02B8\u02BB\u02BA\u02BD\u02B7\u02B8\u02BB\u02B8\u02BB;
		this.Head.color = this.\u02B7\u02B9\u02BA\u02B6\u02B3\u02B4\u02B5\u02C1\u02B4\u02B9\u02B6.guitarNoteOpen;
		this.Anim.sprite = this.\u02BB\u02B5\u02B8\u02B2\u02BA\u02B6\u02B2\u02B9\u02BC\u02B3\u02BD[NoteAnimator.\u02B5\u02B8\u02C1\u02BF\u02C1\u02BA\u02B7\u02B4\u02B9\u02B7\u02BA];
		this.Body.sortingOrder = -3;
		this.Head.sortingOrder = -2;
		this.Anim.sortingOrder = -1;
		this.Open_HOPO.sortingOrder = 0;
		if (\u02B9\u02BF\u02B6\u02BE\u02BA\u02BE\u02C1\u02B4\u02BB\u02C1\u02B2.isStarPower)
		{
			this.Anim.sprite = this.\u02BB\u02BF\u02B9\u02B8\u02BC\u02B6\u02BE\u02B7\u02B8\u02BA\u02B2[NoteAnimator.\u02BB\u02BD\u02B2\u02B5\u02B8\u02B9\u02B5\u02BE\u02B9\u02BE\u02C1];
			this.Body.color = this.\u02B7\u02B9\u02BA\u02B6\u02B3\u02B4\u02B5\u02C1\u02B4\u02B9\u02B6.\u02C0\u02C1\u02B9\u02C0\u02B3\u02B4\u02B7\u02B6\u02B5\u02B3\u02B8;
			this.Anim.color = this.\u02B7\u02B9\u02BA\u02B6\u02B3\u02B4\u02B5\u02C1\u02B4\u02B9\u02B6.\u02C0\u02C1\u02B9\u02C0\u02B3\u02B4\u02B7\u02B6\u02B5\u02B3\u02B8;
		}
		else
		{
			this.Anim.sprite = this.\u02BB\u02B5\u02B8\u02B2\u02BA\u02B6\u02B2\u02B9\u02BC\u02B3\u02BD[NoteAnimator.\u02B5\u02B8\u02C1\u02BF\u02C1\u02BA\u02B7\u02B4\u02B9\u02B7\u02BA];
			this.Body.color = Color.white;
			this.Anim.color = this.\u02B7\u02B9\u02BA\u02B6\u02B3\u02B4\u02B5\u02C1\u02B4\u02B9\u02B6.\u02B9\u02BB\u02B4\u02C1\u02B5\u02C0\u02C1\u02C1\u02B5\u02C0\u02BC;
		}
		this.Open_HOPO.sprite = (\u02B9\u02BF\u02B6\u02BE\u02BA\u02BE\u02C1\u02B4\u02BB\u02C1\u02B2.IsHopo ? this.\u02B5\u02BC\u02B7\u02BA\u02C1\u02C1\u02B4\u02BA\u02C1\u02C0\u02B6 : null);
		if (\u02C1\u02B8\u02B4\u02B5\u02B3\u02BE\u02BD\u02BF\u02B9\u02B7\u02BF)
		{
			this.Head.color = this.\u02B7\u02B9\u02BA\u02B6\u02B3\u02B4\u02B5\u02C1\u02B4\u02B9\u02B6.\u02B2\u02B4\u02B8\u02BB\u02B6\u02BF\u02BA\u02B6\u02BB\u02BF\u02B8;
		}
	}

	public void \u02BE\u02B9\u02B6\u02BF\u02C1\u02C0\u02B7\u02BD\u02C0\u02B3\u02B7(Vector3 \u02B6\u02B2\u02B5\u02BB\u02C1\u02BB\u02BA\u02B4\u02BF\u02BA\u02B5)
	{
		this.<\u02B6\u02C1\u02BA\u02BA\u02B9\u02BC\u02B9\u02C0\u02BA\u02C0\u02B8>k__BackingField = \u02B6\u02B2\u02B5\u02BB\u02C1\u02BB\u02BA\u02B4\u02BF\u02BA\u02B5;
	}

	public Sprite \u02C0\u02BA\u02C1\u02B3\u02BF\u02B5\u02B4\u02BE\u02BC\u02B7\u02C0;

	public Sprite \u02BE\u02BE\u02B9\u02BA\u02B7\u02BE\u02C0\u02B4\u02B8\u02C0\u02BE;

	public Sprite \u02BA\u02B5\u02BE\u02B4\u02BD\u02B4\u02B8\u02B4\u02BA\u02BA\u02B5;

	public Sprite \u02B6\u02BE\u02B6\u02B2\u02BA\u02BA\u02BB\u02BB\u02C0\u02BE\u02B6;

	public Sprite \u02B5\u02BF\u02BB\u02BE\u02BC\u02C0\u02B5\u02C1\u02B7\u02BC\u02BF;

	public Sprite \u02B8\u02C0\u02B2\u02BC\u02BB\u02C1\u02BA\u02C0\u02BB\u02B8\u02BC;

	public Sprite \u02B9\u02BD\u02B4\u02BD\u02BD\u02BE\u02B7\u02B5\u02B5\u02BB\u02B5;

	public Sprite \u02B5\u02BF\u02BD\u02B5\u02B6\u02BD\u02BD\u02B7\u02C0\u02C0\u02B3;

	public Sprite \u02BA\u02B2\u02BE\u02BA\u02B9\u02B3\u02B5\u02B4\u02C1\u02C1\u02B9;

	public Sprite \u02B7\u02B2\u02B8\u02BB\u02BA\u02BD\u02B7\u02B8\u02BB\u02B8\u02BB;

	public Sprite \u02B5\u02BC\u02B7\u02BA\u02C1\u02C1\u02B4\u02BA\u02C1\u02C0\u02B6;

	public Sprite[] \u02B4\u02B6\u02B2\u02B8\u02C1\u02C0\u02B9\u02BF\u02B7\u02B9\u02B5;

	public Sprite[] \u02BB\u02B5\u02B8\u02B2\u02BA\u02B6\u02B2\u02B9\u02BC\u02B3\u02BD;

	public Sprite[] \u02BE\u02BE\u02BA\u02B9\u02B6\u02BC\u02B2\u02B5\u02B9\u02BC\u02BC;

	public Sprite[] \u02BB\u02BF\u02B9\u02B8\u02BC\u02B6\u02BE\u02B7\u02B8\u02BA\u02B2;

	public Sprite[] \u02B2\u02BC\u02BB\u02B7\u02BD\u02C1\u02BB\u02C0\u02BC\u02BD\u02BD;

	public Sprite[] \u02BF\u02B5\u02BC\u02BE\u02BF\u02BF\u02BA\u02BC\u02BD\u02B6\u02B4;

	[SerializeField]
	protected SpriteRenderer Head;

	[SerializeField]
	protected SpriteRenderer Body;

	[SerializeField]
	protected SpriteRenderer Anim;

	[SerializeField]
	protected SpriteRenderer Open_HOPO;

	public Note \u02BC\u02C0\u02C0\u02B8\u02B9\u02BC\u02BF\u02BE\u02C0\u02BA\u02B9;

	public bool \u02B7\u02B3\u02B3\u02BA\u02BD\u02B8\u02BF\u02BB\u02B6\u02BA\u02BB;
}
