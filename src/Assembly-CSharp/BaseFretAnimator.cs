﻿using System;
using UnityEngine;

public abstract class BaseFretAnimator : MonoBehaviour, \u02C0\u02C1\u02B8\u02BF\u02BB\u02BB\u02B9\u02BC\u02B9\u02BD\u02B7
{
	public \u02BB\u02B9\u02B2\u02B3\u02B4\u02B3\u02BF\u02C0\u02B4\u02B8\u02B9 colorInfo { get; set; }

	public abstract void \u02C0\u02BE\u02B5\u02BF\u02B4\u02B9\u02B6\u02BD\u02BC\u02B7\u02B7();

	public abstract void Play(bool \u02B5\u02C1\u02BD\u02B8\u02BB\u02B2\u02B8\u02B9\u02B8\u02B4\u02BA, bool \u02B9\u02B9\u02B8\u02C0\u02B3\u02BE\u02B4\u02BA\u02BA\u02BB\u02B8);

	public abstract void \u02BB\u02BF\u02B2\u02B3\u02BD\u02BB\u02BE\u02BD\u02BB\u02BE\u02B3();

	public bool isHeld;

	public bool isSustaining;

	public int fretIndex;
}
