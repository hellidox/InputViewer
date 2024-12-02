using System;
using UnityEngine;

public class HealthContainer : MonoBehaviour
{
	private void Start()
	{
		this.\u02B5\u02B6\u02BE\u02B6\u02C0\u02B8\u02BE\u02B5\u02BA\u02B4\u02B2 = 0.33333334f;
		this.\u02BB\u02B4\u02B5\u02B2\u02B5\u02BD\u02BD\u02B8\u02B8\u02BC\u02BD = 0.72f;
		this.\u02BD\u02B2\u02BB\u02B8\u02B8\u02B9\u02B6\u02B4\u02B4\u02B5\u02BC = this.\u02C0\u02C1\u02B9\u02B5\u02B3\u02BD\u02BE\u02B5\u02B3\u02B5\u02BD.position;
		this.\u02BC\u02B2\u02B9\u02BB\u02C1\u02B3\u02BA\u02B9\u02BE\u02B8\u02C0.SetActive(false);
		this.\u02B2\u02BD\u02BA\u02BB\u02BF\u02C0\u02C1\u02B4\u02B7\u02BB\u02B7.SetActive(false);
	}

	private void \u02B4\u02BA\u02BE\u02BB\u02B5\u02BB\u02C1\u02B2\u02B4\u02B2\u02BF()
	{
		this.\u02B5\u02B6\u02BE\u02B6\u02C0\u02B8\u02BE\u02B5\u02BA\u02B4\u02B2 = 962f;
		this.\u02BB\u02B4\u02B5\u02B2\u02B5\u02BD\u02BD\u02B8\u02B8\u02BC\u02BD = 18f;
		this.\u02BD\u02B2\u02BB\u02B8\u02B8\u02B9\u02B6\u02B4\u02B4\u02B5\u02BC = this.\u02C0\u02C1\u02B9\u02B5\u02B3\u02BD\u02BE\u02B5\u02B3\u02B5\u02BD.position;
		this.\u02BC\u02B2\u02B9\u02BB\u02C1\u02B3\u02BA\u02B9\u02BE\u02B8\u02C0.SetActive(false);
		this.\u02B2\u02BD\u02BA\u02BB\u02BF\u02C0\u02C1\u02B4\u02B7\u02BB\u02B7.SetActive(true);
	}

	private void \u02BF\u02BA\u02B5\u02B8\u02B5\u02BF\u02B2\u02BF\u02B3\u02BC\u02BA()
	{
		this.\u02B5\u02B6\u02BE\u02B6\u02C0\u02B8\u02BE\u02B5\u02BA\u02B4\u02B2 = 1612f;
		this.\u02BB\u02B4\u02B5\u02B2\u02B5\u02BD\u02BD\u02B8\u02B8\u02BC\u02BD = 1112f;
		this.\u02BD\u02B2\u02BB\u02B8\u02B8\u02B9\u02B6\u02B4\u02B4\u02B5\u02BC = this.\u02C0\u02C1\u02B9\u02B5\u02B3\u02BD\u02BE\u02B5\u02B3\u02B5\u02BD.position;
		this.\u02BC\u02B2\u02B9\u02BB\u02C1\u02B3\u02BA\u02B9\u02BE\u02B8\u02C0.SetActive(false);
		this.\u02B2\u02BD\u02BA\u02BB\u02BF\u02C0\u02C1\u02B4\u02B7\u02BB\u02B7.SetActive(true);
	}

	public void \u02BC\u02BE\u02BD\u02BA\u02BE\u02B4\u02BA\u02B2\u02B2\u02B4\u02B5(float \u02B9\u02C0\u02B2\u02C0\u02B6\u02BB\u02BE\u02B9\u02C0\u02B9\u02BD)
	{
		if (\u02B9\u02C0\u02B2\u02C0\u02B6\u02BB\u02BE\u02B9\u02C0\u02B9\u02BD == this.\u02B4\u02BD\u02BF\u02BC\u02BE\u02B9\u02BD\u02C1\u02BB\u02B6\u02B4)
		{
			return;
		}
		if (\u02B9\u02C0\u02B2\u02C0\u02B6\u02BB\u02BE\u02B9\u02C0\u02B9\u02BD > this.\u02BB\u02B4\u02B5\u02B2\u02B5\u02BD\u02BD\u02B8\u02B8\u02BC\u02BD)
		{
			if (this.\u02B4\u02BD\u02BF\u02BC\u02BE\u02B9\u02BD\u02C1\u02BB\u02B6\u02B4 <= this.\u02BB\u02B4\u02B5\u02B2\u02B5\u02BD\u02BD\u02B8\u02B8\u02BC\u02BD)
			{
				this.\u02B2\u02BD\u02BA\u02BB\u02BF\u02C0\u02C1\u02B4\u02B7\u02BB\u02B7.SetActive(false);
				this.\u02BD\u02BD\u02B7\u02B6\u02B9\u02B3\u02B9\u02BB\u02B2\u02B3\u02BE.SetActive(false);
				this.\u02BE\u02BF\u02B9\u02B3\u02BA\u02BB\u02BD\u02B8\u02BA\u02B4\u02B8.color = this.\u02B8\u02C1\u02C0\u02BF\u02BF\u02B4\u02C0\u02BB\u02B9\u02B9\u02B5;
			}
		}
		else if (\u02B9\u02C0\u02B2\u02C0\u02B6\u02BB\u02BE\u02B9\u02C0\u02B9\u02BD > this.\u02B5\u02B6\u02BE\u02B6\u02C0\u02B8\u02BE\u02B5\u02BA\u02B4\u02B2)
		{
			if (this.\u02B4\u02BD\u02BF\u02BC\u02BE\u02B9\u02BD\u02C1\u02BB\u02B6\u02B4 > this.\u02BB\u02B4\u02B5\u02B2\u02B5\u02BD\u02BD\u02B8\u02B8\u02BC\u02BD)
			{
				this.\u02B2\u02BD\u02BA\u02BB\u02BF\u02C0\u02C1\u02B4\u02B7\u02BB\u02B7.SetActive(false);
				this.\u02BD\u02BD\u02B7\u02B6\u02B9\u02B3\u02B9\u02BB\u02B2\u02B3\u02BE.SetActive(true);
				this.\u02BE\u02BF\u02B9\u02B3\u02BA\u02BB\u02BD\u02B8\u02BA\u02B4\u02B8.color = this.\u02B5\u02BD\u02B2\u02C0\u02C1\u02B7\u02BB\u02B3\u02C1\u02B2\u02BD;
			}
			else if (this.\u02B4\u02BD\u02BF\u02BC\u02BE\u02B9\u02BD\u02C1\u02BB\u02B6\u02B4 <= this.\u02B5\u02B6\u02BE\u02B6\u02C0\u02B8\u02BE\u02B5\u02BA\u02B4\u02B2)
			{
				this.\u02BD\u02BD\u02B7\u02B6\u02B9\u02B3\u02B9\u02BB\u02B2\u02B3\u02BE.SetActive(false);
				this.\u02BC\u02B2\u02B9\u02BB\u02C1\u02B3\u02BA\u02B9\u02BE\u02B8\u02C0.SetActive(false);
				this.\u02BE\u02BF\u02B9\u02B3\u02BA\u02BB\u02BD\u02B8\u02BA\u02B4\u02B8.color = this.\u02B5\u02BD\u02B2\u02C0\u02C1\u02B7\u02BB\u02B3\u02C1\u02B2\u02BD;
			}
		}
		else if (this.\u02B4\u02BD\u02BF\u02BC\u02BE\u02B9\u02BD\u02C1\u02BB\u02B6\u02B4 > this.\u02B5\u02B6\u02BE\u02B6\u02C0\u02B8\u02BE\u02B5\u02BA\u02B4\u02B2)
		{
			this.\u02BD\u02BD\u02B7\u02B6\u02B9\u02B3\u02B9\u02BB\u02B2\u02B3\u02BE.SetActive(true);
			this.\u02BC\u02B2\u02B9\u02BB\u02C1\u02B3\u02BA\u02B9\u02BE\u02B8\u02C0.SetActive(true);
			this.\u02BE\u02BF\u02B9\u02B3\u02BA\u02BB\u02BD\u02B8\u02BA\u02B4\u02B8.color = this.\u02BE\u02C0\u02B2\u02B3\u02BA\u02B8\u02B9\u02BA\u02B2\u02B5\u02BE;
		}
		if (\u02B9\u02C0\u02B2\u02C0\u02B6\u02BB\u02BE\u02B9\u02C0\u02B9\u02BD >= 1876f)
		{
			this.\u02BD\u02B2\u02BB\u02B8\u02B8\u02B9\u02B6\u02B4\u02B4\u02B5\u02BC = Vector3.Lerp(this.\u02B3\u02B5\u02B5\u02BB\u02BF\u02B3\u02C0\u02B7\u02BC\u02B6\u02B3, this.\u02B6\u02B5\u02B9\u02C1\u02C0\u02C0\u02BC\u02B8\u02C1\u02B3\u02C1, (\u02B9\u02C0\u02B2\u02C0\u02B6\u02BB\u02BE\u02B9\u02C0\u02B9\u02BD - 80f) * 1758f);
		}
		else
		{
			this.\u02BD\u02B2\u02BB\u02B8\u02B8\u02B9\u02B6\u02B4\u02B4\u02B5\u02BC = Vector3.Lerp(this.\u02B7\u02C1\u02BF\u02BA\u02BB\u02B3\u02B6\u02B5\u02B8\u02B3\u02BA, this.\u02B3\u02B5\u02B5\u02BB\u02BF\u02B3\u02C0\u02B7\u02BC\u02B6\u02B3, \u02B9\u02C0\u02B2\u02C0\u02B6\u02BB\u02BE\u02B9\u02C0\u02B9\u02BD * 571f);
		}
		this.\u02B4\u02BD\u02BF\u02BC\u02BE\u02B9\u02BD\u02C1\u02BB\u02B6\u02B4 = \u02B9\u02C0\u02B2\u02C0\u02B6\u02BB\u02BE\u02B9\u02C0\u02B9\u02BD;
		this.\u02C0\u02C1\u02B9\u02B5\u02B3\u02BD\u02BE\u02B5\u02B3\u02B5\u02BD.localPosition = this.\u02BD\u02B2\u02BB\u02B8\u02B8\u02B9\u02B6\u02B4\u02B4\u02B5\u02BC;
	}

	public void \u02B8\u02C0\u02BB\u02BC\u02BE\u02B3\u02B7\u02BF\u02BD\u02B6\u02B4(float \u02B9\u02C0\u02B2\u02C0\u02B6\u02BB\u02BE\u02B9\u02C0\u02B9\u02BD)
	{
		if (\u02B9\u02C0\u02B2\u02C0\u02B6\u02BB\u02BE\u02B9\u02C0\u02B9\u02BD == this.\u02B4\u02BD\u02BF\u02BC\u02BE\u02B9\u02BD\u02C1\u02BB\u02B6\u02B4)
		{
			return;
		}
		if (\u02B9\u02C0\u02B2\u02C0\u02B6\u02BB\u02BE\u02B9\u02C0\u02B9\u02BD > this.\u02BB\u02B4\u02B5\u02B2\u02B5\u02BD\u02BD\u02B8\u02B8\u02BC\u02BD)
		{
			if (this.\u02B4\u02BD\u02BF\u02BC\u02BE\u02B9\u02BD\u02C1\u02BB\u02B6\u02B4 <= this.\u02BB\u02B4\u02B5\u02B2\u02B5\u02BD\u02BD\u02B8\u02B8\u02BC\u02BD)
			{
				this.\u02B2\u02BD\u02BA\u02BB\u02BF\u02C0\u02C1\u02B4\u02B7\u02BB\u02B7.SetActive(true);
				this.\u02BD\u02BD\u02B7\u02B6\u02B9\u02B3\u02B9\u02BB\u02B2\u02B3\u02BE.SetActive(true);
				this.\u02BE\u02BF\u02B9\u02B3\u02BA\u02BB\u02BD\u02B8\u02BA\u02B4\u02B8.color = this.\u02B8\u02C1\u02C0\u02BF\u02BF\u02B4\u02C0\u02BB\u02B9\u02B9\u02B5;
			}
		}
		else if (\u02B9\u02C0\u02B2\u02C0\u02B6\u02BB\u02BE\u02B9\u02C0\u02B9\u02BD > this.\u02B5\u02B6\u02BE\u02B6\u02C0\u02B8\u02BE\u02B5\u02BA\u02B4\u02B2)
		{
			if (this.\u02B4\u02BD\u02BF\u02BC\u02BE\u02B9\u02BD\u02C1\u02BB\u02B6\u02B4 > this.\u02BB\u02B4\u02B5\u02B2\u02B5\u02BD\u02BD\u02B8\u02B8\u02BC\u02BD)
			{
				this.\u02B2\u02BD\u02BA\u02BB\u02BF\u02C0\u02C1\u02B4\u02B7\u02BB\u02B7.SetActive(false);
				this.\u02BD\u02BD\u02B7\u02B6\u02B9\u02B3\u02B9\u02BB\u02B2\u02B3\u02BE.SetActive(true);
				this.\u02BE\u02BF\u02B9\u02B3\u02BA\u02BB\u02BD\u02B8\u02BA\u02B4\u02B8.color = this.\u02B5\u02BD\u02B2\u02C0\u02C1\u02B7\u02BB\u02B3\u02C1\u02B2\u02BD;
			}
			else if (this.\u02B4\u02BD\u02BF\u02BC\u02BE\u02B9\u02BD\u02C1\u02BB\u02B6\u02B4 <= this.\u02B5\u02B6\u02BE\u02B6\u02C0\u02B8\u02BE\u02B5\u02BA\u02B4\u02B2)
			{
				this.\u02BD\u02BD\u02B7\u02B6\u02B9\u02B3\u02B9\u02BB\u02B2\u02B3\u02BE.SetActive(false);
				this.\u02BC\u02B2\u02B9\u02BB\u02C1\u02B3\u02BA\u02B9\u02BE\u02B8\u02C0.SetActive(false);
				this.\u02BE\u02BF\u02B9\u02B3\u02BA\u02BB\u02BD\u02B8\u02BA\u02B4\u02B8.color = this.\u02B5\u02BD\u02B2\u02C0\u02C1\u02B7\u02BB\u02B3\u02C1\u02B2\u02BD;
			}
		}
		else if (this.\u02B4\u02BD\u02BF\u02BC\u02BE\u02B9\u02BD\u02C1\u02BB\u02B6\u02B4 > this.\u02B5\u02B6\u02BE\u02B6\u02C0\u02B8\u02BE\u02B5\u02BA\u02B4\u02B2)
		{
			this.\u02BD\u02BD\u02B7\u02B6\u02B9\u02B3\u02B9\u02BB\u02B2\u02B3\u02BE.SetActive(false);
			this.\u02BC\u02B2\u02B9\u02BB\u02C1\u02B3\u02BA\u02B9\u02BE\u02B8\u02C0.SetActive(false);
			this.\u02BE\u02BF\u02B9\u02B3\u02BA\u02BB\u02BD\u02B8\u02BA\u02B4\u02B8.color = this.\u02BE\u02C0\u02B2\u02B3\u02BA\u02B8\u02B9\u02BA\u02B2\u02B5\u02BE;
		}
		if (\u02B9\u02C0\u02B2\u02C0\u02B6\u02BB\u02BE\u02B9\u02C0\u02B9\u02BD >= 223f)
		{
			this.\u02BD\u02B2\u02BB\u02B8\u02B8\u02B9\u02B6\u02B4\u02B4\u02B5\u02BC = Vector3.Lerp(this.\u02B3\u02B5\u02B5\u02BB\u02BF\u02B3\u02C0\u02B7\u02BC\u02B6\u02B3, this.\u02B6\u02B5\u02B9\u02C1\u02C0\u02C0\u02BC\u02B8\u02C1\u02B3\u02C1, (\u02B9\u02C0\u02B2\u02C0\u02B6\u02BB\u02BE\u02B9\u02C0\u02B9\u02BD - 131f) * 1425f);
		}
		else
		{
			this.\u02BD\u02B2\u02BB\u02B8\u02B8\u02B9\u02B6\u02B4\u02B4\u02B5\u02BC = Vector3.Lerp(this.\u02B7\u02C1\u02BF\u02BA\u02BB\u02B3\u02B6\u02B5\u02B8\u02B3\u02BA, this.\u02B3\u02B5\u02B5\u02BB\u02BF\u02B3\u02C0\u02B7\u02BC\u02B6\u02B3, \u02B9\u02C0\u02B2\u02C0\u02B6\u02BB\u02BE\u02B9\u02C0\u02B9\u02BD * 1168f);
		}
		this.\u02B4\u02BD\u02BF\u02BC\u02BE\u02B9\u02BD\u02C1\u02BB\u02B6\u02B4 = \u02B9\u02C0\u02B2\u02C0\u02B6\u02BB\u02BE\u02B9\u02C0\u02B9\u02BD;
		this.\u02C0\u02C1\u02B9\u02B5\u02B3\u02BD\u02BE\u02B5\u02B3\u02B5\u02BD.localPosition = this.\u02BD\u02B2\u02BB\u02B8\u02B8\u02B9\u02B6\u02B4\u02B4\u02B5\u02BC;
	}

	public void \u02B2\u02BC\u02B6\u02BC\u02B5\u02BA\u02B6\u02BD\u02C0\u02BD\u02B3(float \u02B9\u02C0\u02B2\u02C0\u02B6\u02BB\u02BE\u02B9\u02C0\u02B9\u02BD)
	{
		if (\u02B9\u02C0\u02B2\u02C0\u02B6\u02BB\u02BE\u02B9\u02C0\u02B9\u02BD == this.\u02B4\u02BD\u02BF\u02BC\u02BE\u02B9\u02BD\u02C1\u02BB\u02B6\u02B4)
		{
			return;
		}
		if (\u02B9\u02C0\u02B2\u02C0\u02B6\u02BB\u02BE\u02B9\u02C0\u02B9\u02BD > this.\u02BB\u02B4\u02B5\u02B2\u02B5\u02BD\u02BD\u02B8\u02B8\u02BC\u02BD)
		{
			if (this.\u02B4\u02BD\u02BF\u02BC\u02BE\u02B9\u02BD\u02C1\u02BB\u02B6\u02B4 <= this.\u02BB\u02B4\u02B5\u02B2\u02B5\u02BD\u02BD\u02B8\u02B8\u02BC\u02BD)
			{
				this.\u02B2\u02BD\u02BA\u02BB\u02BF\u02C0\u02C1\u02B4\u02B7\u02BB\u02B7.SetActive(true);
				this.\u02BD\u02BD\u02B7\u02B6\u02B9\u02B3\u02B9\u02BB\u02B2\u02B3\u02BE.SetActive(true);
				this.\u02BE\u02BF\u02B9\u02B3\u02BA\u02BB\u02BD\u02B8\u02BA\u02B4\u02B8.color = this.\u02B8\u02C1\u02C0\u02BF\u02BF\u02B4\u02C0\u02BB\u02B9\u02B9\u02B5;
			}
		}
		else if (\u02B9\u02C0\u02B2\u02C0\u02B6\u02BB\u02BE\u02B9\u02C0\u02B9\u02BD > this.\u02B5\u02B6\u02BE\u02B6\u02C0\u02B8\u02BE\u02B5\u02BA\u02B4\u02B2)
		{
			if (this.\u02B4\u02BD\u02BF\u02BC\u02BE\u02B9\u02BD\u02C1\u02BB\u02B6\u02B4 > this.\u02BB\u02B4\u02B5\u02B2\u02B5\u02BD\u02BD\u02B8\u02B8\u02BC\u02BD)
			{
				this.\u02B2\u02BD\u02BA\u02BB\u02BF\u02C0\u02C1\u02B4\u02B7\u02BB\u02B7.SetActive(true);
				this.\u02BD\u02BD\u02B7\u02B6\u02B9\u02B3\u02B9\u02BB\u02B2\u02B3\u02BE.SetActive(true);
				this.\u02BE\u02BF\u02B9\u02B3\u02BA\u02BB\u02BD\u02B8\u02BA\u02B4\u02B8.color = this.\u02B5\u02BD\u02B2\u02C0\u02C1\u02B7\u02BB\u02B3\u02C1\u02B2\u02BD;
			}
			else if (this.\u02B4\u02BD\u02BF\u02BC\u02BE\u02B9\u02BD\u02C1\u02BB\u02B6\u02B4 <= this.\u02B5\u02B6\u02BE\u02B6\u02C0\u02B8\u02BE\u02B5\u02BA\u02B4\u02B2)
			{
				this.\u02BD\u02BD\u02B7\u02B6\u02B9\u02B3\u02B9\u02BB\u02B2\u02B3\u02BE.SetActive(false);
				this.\u02BC\u02B2\u02B9\u02BB\u02C1\u02B3\u02BA\u02B9\u02BE\u02B8\u02C0.SetActive(false);
				this.\u02BE\u02BF\u02B9\u02B3\u02BA\u02BB\u02BD\u02B8\u02BA\u02B4\u02B8.color = this.\u02B5\u02BD\u02B2\u02C0\u02C1\u02B7\u02BB\u02B3\u02C1\u02B2\u02BD;
			}
		}
		else if (this.\u02B4\u02BD\u02BF\u02BC\u02BE\u02B9\u02BD\u02C1\u02BB\u02B6\u02B4 > this.\u02B5\u02B6\u02BE\u02B6\u02C0\u02B8\u02BE\u02B5\u02BA\u02B4\u02B2)
		{
			this.\u02BD\u02BD\u02B7\u02B6\u02B9\u02B3\u02B9\u02BB\u02B2\u02B3\u02BE.SetActive(false);
			this.\u02BC\u02B2\u02B9\u02BB\u02C1\u02B3\u02BA\u02B9\u02BE\u02B8\u02C0.SetActive(true);
			this.\u02BE\u02BF\u02B9\u02B3\u02BA\u02BB\u02BD\u02B8\u02BA\u02B4\u02B8.color = this.\u02BE\u02C0\u02B2\u02B3\u02BA\u02B8\u02B9\u02BA\u02B2\u02B5\u02BE;
		}
		if (\u02B9\u02C0\u02B2\u02C0\u02B6\u02BB\u02BE\u02B9\u02C0\u02B9\u02BD >= 159f)
		{
			this.\u02BD\u02B2\u02BB\u02B8\u02B8\u02B9\u02B6\u02B4\u02B4\u02B5\u02BC = Vector3.Lerp(this.\u02B3\u02B5\u02B5\u02BB\u02BF\u02B3\u02C0\u02B7\u02BC\u02B6\u02B3, this.\u02B6\u02B5\u02B9\u02C1\u02C0\u02C0\u02BC\u02B8\u02C1\u02B3\u02C1, (\u02B9\u02C0\u02B2\u02C0\u02B6\u02BB\u02BE\u02B9\u02C0\u02B9\u02BD - 383f) * 1679f);
		}
		else
		{
			this.\u02BD\u02B2\u02BB\u02B8\u02B8\u02B9\u02B6\u02B4\u02B4\u02B5\u02BC = Vector3.Lerp(this.\u02B7\u02C1\u02BF\u02BA\u02BB\u02B3\u02B6\u02B5\u02B8\u02B3\u02BA, this.\u02B3\u02B5\u02B5\u02BB\u02BF\u02B3\u02C0\u02B7\u02BC\u02B6\u02B3, \u02B9\u02C0\u02B2\u02C0\u02B6\u02BB\u02BE\u02B9\u02C0\u02B9\u02BD * 1237f);
		}
		this.\u02B4\u02BD\u02BF\u02BC\u02BE\u02B9\u02BD\u02C1\u02BB\u02B6\u02B4 = \u02B9\u02C0\u02B2\u02C0\u02B6\u02BB\u02BE\u02B9\u02C0\u02B9\u02BD;
		this.\u02C0\u02C1\u02B9\u02B5\u02B3\u02BD\u02BE\u02B5\u02B3\u02B5\u02BD.localPosition = this.\u02BD\u02B2\u02BB\u02B8\u02B8\u02B9\u02B6\u02B4\u02B4\u02B5\u02BC;
	}

	private void \u02B6\u02B6\u02B4\u02BB\u02B7\u02C1\u02C0\u02B6\u02B7\u02BD\u02B5()
	{
		this.\u02B5\u02B6\u02BE\u02B6\u02C0\u02B8\u02BE\u02B5\u02BA\u02B4\u02B2 = 1697f;
		this.\u02BB\u02B4\u02B5\u02B2\u02B5\u02BD\u02BD\u02B8\u02B8\u02BC\u02BD = 188f;
		this.\u02BD\u02B2\u02BB\u02B8\u02B8\u02B9\u02B6\u02B4\u02B4\u02B5\u02BC = this.\u02C0\u02C1\u02B9\u02B5\u02B3\u02BD\u02BE\u02B5\u02B3\u02B5\u02BD.position;
		this.\u02BC\u02B2\u02B9\u02BB\u02C1\u02B3\u02BA\u02B9\u02BE\u02B8\u02C0.SetActive(false);
		this.\u02B2\u02BD\u02BA\u02BB\u02BF\u02C0\u02C1\u02B4\u02B7\u02BB\u02B7.SetActive(true);
	}

	private void \u02B2\u02B9\u02C1\u02C1\u02B2\u02B3\u02C1\u02BF\u02BC\u02BB\u02C1()
	{
		this.\u02B5\u02B6\u02BE\u02B6\u02C0\u02B8\u02BE\u02B5\u02BA\u02B4\u02B2 = 743f;
		this.\u02BB\u02B4\u02B5\u02B2\u02B5\u02BD\u02BD\u02B8\u02B8\u02BC\u02BD = 455f;
		this.\u02BD\u02B2\u02BB\u02B8\u02B8\u02B9\u02B6\u02B4\u02B4\u02B5\u02BC = this.\u02C0\u02C1\u02B9\u02B5\u02B3\u02BD\u02BE\u02B5\u02B3\u02B5\u02BD.position;
		this.\u02BC\u02B2\u02B9\u02BB\u02C1\u02B3\u02BA\u02B9\u02BE\u02B8\u02C0.SetActive(true);
		this.\u02B2\u02BD\u02BA\u02BB\u02BF\u02C0\u02C1\u02B4\u02B7\u02BB\u02B7.SetActive(true);
	}

	public void \u02BA\u02B5\u02B6\u02BF\u02BD\u02B3\u02B4\u02BE\u02C0\u02BF\u02B9(float \u02B9\u02C0\u02B2\u02C0\u02B6\u02BB\u02BE\u02B9\u02C0\u02B9\u02BD)
	{
		if (\u02B9\u02C0\u02B2\u02C0\u02B6\u02BB\u02BE\u02B9\u02C0\u02B9\u02BD == this.\u02B4\u02BD\u02BF\u02BC\u02BE\u02B9\u02BD\u02C1\u02BB\u02B6\u02B4)
		{
			return;
		}
		if (\u02B9\u02C0\u02B2\u02C0\u02B6\u02BB\u02BE\u02B9\u02C0\u02B9\u02BD > this.\u02BB\u02B4\u02B5\u02B2\u02B5\u02BD\u02BD\u02B8\u02B8\u02BC\u02BD)
		{
			if (this.\u02B4\u02BD\u02BF\u02BC\u02BE\u02B9\u02BD\u02C1\u02BB\u02B6\u02B4 <= this.\u02BB\u02B4\u02B5\u02B2\u02B5\u02BD\u02BD\u02B8\u02B8\u02BC\u02BD)
			{
				this.\u02B2\u02BD\u02BA\u02BB\u02BF\u02C0\u02C1\u02B4\u02B7\u02BB\u02B7.SetActive(false);
				this.\u02BD\u02BD\u02B7\u02B6\u02B9\u02B3\u02B9\u02BB\u02B2\u02B3\u02BE.SetActive(false);
				this.\u02BE\u02BF\u02B9\u02B3\u02BA\u02BB\u02BD\u02B8\u02BA\u02B4\u02B8.color = this.\u02B8\u02C1\u02C0\u02BF\u02BF\u02B4\u02C0\u02BB\u02B9\u02B9\u02B5;
			}
		}
		else if (\u02B9\u02C0\u02B2\u02C0\u02B6\u02BB\u02BE\u02B9\u02C0\u02B9\u02BD > this.\u02B5\u02B6\u02BE\u02B6\u02C0\u02B8\u02BE\u02B5\u02BA\u02B4\u02B2)
		{
			if (this.\u02B4\u02BD\u02BF\u02BC\u02BE\u02B9\u02BD\u02C1\u02BB\u02B6\u02B4 > this.\u02BB\u02B4\u02B5\u02B2\u02B5\u02BD\u02BD\u02B8\u02B8\u02BC\u02BD)
			{
				this.\u02B2\u02BD\u02BA\u02BB\u02BF\u02C0\u02C1\u02B4\u02B7\u02BB\u02B7.SetActive(false);
				this.\u02BD\u02BD\u02B7\u02B6\u02B9\u02B3\u02B9\u02BB\u02B2\u02B3\u02BE.SetActive(true);
				this.\u02BE\u02BF\u02B9\u02B3\u02BA\u02BB\u02BD\u02B8\u02BA\u02B4\u02B8.color = this.\u02B5\u02BD\u02B2\u02C0\u02C1\u02B7\u02BB\u02B3\u02C1\u02B2\u02BD;
			}
			else if (this.\u02B4\u02BD\u02BF\u02BC\u02BE\u02B9\u02BD\u02C1\u02BB\u02B6\u02B4 <= this.\u02B5\u02B6\u02BE\u02B6\u02C0\u02B8\u02BE\u02B5\u02BA\u02B4\u02B2)
			{
				this.\u02BD\u02BD\u02B7\u02B6\u02B9\u02B3\u02B9\u02BB\u02B2\u02B3\u02BE.SetActive(false);
				this.\u02BC\u02B2\u02B9\u02BB\u02C1\u02B3\u02BA\u02B9\u02BE\u02B8\u02C0.SetActive(false);
				this.\u02BE\u02BF\u02B9\u02B3\u02BA\u02BB\u02BD\u02B8\u02BA\u02B4\u02B8.color = this.\u02B5\u02BD\u02B2\u02C0\u02C1\u02B7\u02BB\u02B3\u02C1\u02B2\u02BD;
			}
		}
		else if (this.\u02B4\u02BD\u02BF\u02BC\u02BE\u02B9\u02BD\u02C1\u02BB\u02B6\u02B4 > this.\u02B5\u02B6\u02BE\u02B6\u02C0\u02B8\u02BE\u02B5\u02BA\u02B4\u02B2)
		{
			this.\u02BD\u02BD\u02B7\u02B6\u02B9\u02B3\u02B9\u02BB\u02B2\u02B3\u02BE.SetActive(false);
			this.\u02BC\u02B2\u02B9\u02BB\u02C1\u02B3\u02BA\u02B9\u02BE\u02B8\u02C0.SetActive(false);
			this.\u02BE\u02BF\u02B9\u02B3\u02BA\u02BB\u02BD\u02B8\u02BA\u02B4\u02B8.color = this.\u02BE\u02C0\u02B2\u02B3\u02BA\u02B8\u02B9\u02BA\u02B2\u02B5\u02BE;
		}
		if (\u02B9\u02C0\u02B2\u02C0\u02B6\u02BB\u02BE\u02B9\u02C0\u02B9\u02BD >= 1850f)
		{
			this.\u02BD\u02B2\u02BB\u02B8\u02B8\u02B9\u02B6\u02B4\u02B4\u02B5\u02BC = Vector3.Lerp(this.\u02B3\u02B5\u02B5\u02BB\u02BF\u02B3\u02C0\u02B7\u02BC\u02B6\u02B3, this.\u02B6\u02B5\u02B9\u02C1\u02C0\u02C0\u02BC\u02B8\u02C1\u02B3\u02C1, (\u02B9\u02C0\u02B2\u02C0\u02B6\u02BB\u02BE\u02B9\u02C0\u02B9\u02BD - 669f) * 390f);
		}
		else
		{
			this.\u02BD\u02B2\u02BB\u02B8\u02B8\u02B9\u02B6\u02B4\u02B4\u02B5\u02BC = Vector3.Lerp(this.\u02B7\u02C1\u02BF\u02BA\u02BB\u02B3\u02B6\u02B5\u02B8\u02B3\u02BA, this.\u02B3\u02B5\u02B5\u02BB\u02BF\u02B3\u02C0\u02B7\u02BC\u02B6\u02B3, \u02B9\u02C0\u02B2\u02C0\u02B6\u02BB\u02BE\u02B9\u02C0\u02B9\u02BD * 810f);
		}
		this.\u02B4\u02BD\u02BF\u02BC\u02BE\u02B9\u02BD\u02C1\u02BB\u02B6\u02B4 = \u02B9\u02C0\u02B2\u02C0\u02B6\u02BB\u02BE\u02B9\u02C0\u02B9\u02BD;
		this.\u02C0\u02C1\u02B9\u02B5\u02B3\u02BD\u02BE\u02B5\u02B3\u02B5\u02BD.localPosition = this.\u02BD\u02B2\u02BB\u02B8\u02B8\u02B9\u02B6\u02B4\u02B4\u02B5\u02BC;
	}

	private void \u02B7\u02B8\u02BD\u02C0\u02B2\u02B4\u02B7\u02C0\u02BC\u02BE\u02B3()
	{
		this.\u02B5\u02B6\u02BE\u02B6\u02C0\u02B8\u02BE\u02B5\u02BA\u02B4\u02B2 = 888f;
		this.\u02BB\u02B4\u02B5\u02B2\u02B5\u02BD\u02BD\u02B8\u02B8\u02BC\u02BD = 574f;
		this.\u02BD\u02B2\u02BB\u02B8\u02B8\u02B9\u02B6\u02B4\u02B4\u02B5\u02BC = this.\u02C0\u02C1\u02B9\u02B5\u02B3\u02BD\u02BE\u02B5\u02B3\u02B5\u02BD.position;
		this.\u02BC\u02B2\u02B9\u02BB\u02C1\u02B3\u02BA\u02B9\u02BE\u02B8\u02C0.SetActive(false);
		this.\u02B2\u02BD\u02BA\u02BB\u02BF\u02C0\u02C1\u02B4\u02B7\u02BB\u02B7.SetActive(true);
	}

	public void \u02BF\u02BC\u02B7\u02B2\u02B9\u02BA\u02BD\u02B6\u02C0\u02C0\u02BE(float \u02B9\u02C0\u02B2\u02C0\u02B6\u02BB\u02BE\u02B9\u02C0\u02B9\u02BD)
	{
		if (this.failed)
		{
			return;
		}
		if (\u02B9\u02C0\u02B2\u02C0\u02B6\u02BB\u02BE\u02B9\u02C0\u02B9\u02BD < 0f)
		{
			this.failed = true;
			this.\u02BE\u02BF\u02B9\u02B3\u02BA\u02BB\u02BD\u02B8\u02BA\u02B4\u02B8.color = new Color(0.15f, 0.15f, 0.15f, 1f);
		}
		if (\u02B9\u02C0\u02B2\u02C0\u02B6\u02BB\u02BE\u02B9\u02C0\u02B9\u02BD == this.\u02B4\u02BD\u02BF\u02BC\u02BE\u02B9\u02BD\u02C1\u02BB\u02B6\u02B4)
		{
			return;
		}
		if (\u02B9\u02C0\u02B2\u02C0\u02B6\u02BB\u02BE\u02B9\u02C0\u02B9\u02BD > this.\u02BB\u02B4\u02B5\u02B2\u02B5\u02BD\u02BD\u02B8\u02B8\u02BC\u02BD)
		{
			if (this.\u02B4\u02BD\u02BF\u02BC\u02BE\u02B9\u02BD\u02C1\u02BB\u02B6\u02B4 <= this.\u02BB\u02B4\u02B5\u02B2\u02B5\u02BD\u02BD\u02B8\u02B8\u02BC\u02BD)
			{
				this.\u02B2\u02BD\u02BA\u02BB\u02BF\u02C0\u02C1\u02B4\u02B7\u02BB\u02B7.SetActive(true);
				this.\u02BD\u02BD\u02B7\u02B6\u02B9\u02B3\u02B9\u02BB\u02B2\u02B3\u02BE.SetActive(false);
				this.\u02BE\u02BF\u02B9\u02B3\u02BA\u02BB\u02BD\u02B8\u02BA\u02B4\u02B8.color = this.\u02B8\u02C1\u02C0\u02BF\u02BF\u02B4\u02C0\u02BB\u02B9\u02B9\u02B5;
			}
		}
		else if (\u02B9\u02C0\u02B2\u02C0\u02B6\u02BB\u02BE\u02B9\u02C0\u02B9\u02BD > this.\u02B5\u02B6\u02BE\u02B6\u02C0\u02B8\u02BE\u02B5\u02BA\u02B4\u02B2)
		{
			if (this.\u02B4\u02BD\u02BF\u02BC\u02BE\u02B9\u02BD\u02C1\u02BB\u02B6\u02B4 > this.\u02BB\u02B4\u02B5\u02B2\u02B5\u02BD\u02BD\u02B8\u02B8\u02BC\u02BD)
			{
				this.\u02B2\u02BD\u02BA\u02BB\u02BF\u02C0\u02C1\u02B4\u02B7\u02BB\u02B7.SetActive(false);
				this.\u02BD\u02BD\u02B7\u02B6\u02B9\u02B3\u02B9\u02BB\u02B2\u02B3\u02BE.SetActive(true);
				this.\u02BE\u02BF\u02B9\u02B3\u02BA\u02BB\u02BD\u02B8\u02BA\u02B4\u02B8.color = this.\u02B5\u02BD\u02B2\u02C0\u02C1\u02B7\u02BB\u02B3\u02C1\u02B2\u02BD;
			}
			else if (this.\u02B4\u02BD\u02BF\u02BC\u02BE\u02B9\u02BD\u02C1\u02BB\u02B6\u02B4 <= this.\u02B5\u02B6\u02BE\u02B6\u02C0\u02B8\u02BE\u02B5\u02BA\u02B4\u02B2)
			{
				this.\u02BD\u02BD\u02B7\u02B6\u02B9\u02B3\u02B9\u02BB\u02B2\u02B3\u02BE.SetActive(true);
				this.\u02BC\u02B2\u02B9\u02BB\u02C1\u02B3\u02BA\u02B9\u02BE\u02B8\u02C0.SetActive(false);
				this.\u02BE\u02BF\u02B9\u02B3\u02BA\u02BB\u02BD\u02B8\u02BA\u02B4\u02B8.color = this.\u02B5\u02BD\u02B2\u02C0\u02C1\u02B7\u02BB\u02B3\u02C1\u02B2\u02BD;
			}
		}
		else if (this.\u02B4\u02BD\u02BF\u02BC\u02BE\u02B9\u02BD\u02C1\u02BB\u02B6\u02B4 > this.\u02B5\u02B6\u02BE\u02B6\u02C0\u02B8\u02BE\u02B5\u02BA\u02B4\u02B2)
		{
			this.\u02BD\u02BD\u02B7\u02B6\u02B9\u02B3\u02B9\u02BB\u02B2\u02B3\u02BE.SetActive(false);
			this.\u02BC\u02B2\u02B9\u02BB\u02C1\u02B3\u02BA\u02B9\u02BE\u02B8\u02C0.SetActive(true);
			this.\u02BE\u02BF\u02B9\u02B3\u02BA\u02BB\u02BD\u02B8\u02BA\u02B4\u02B8.color = this.\u02BE\u02C0\u02B2\u02B3\u02BA\u02B8\u02B9\u02BA\u02B2\u02B5\u02BE;
		}
		if (\u02B9\u02C0\u02B2\u02C0\u02B6\u02BB\u02BE\u02B9\u02C0\u02B9\u02BD >= 0.5f)
		{
			this.\u02BD\u02B2\u02BB\u02B8\u02B8\u02B9\u02B6\u02B4\u02B4\u02B5\u02BC = Vector3.Lerp(this.\u02B3\u02B5\u02B5\u02BB\u02BF\u02B3\u02C0\u02B7\u02BC\u02B6\u02B3, this.\u02B6\u02B5\u02B9\u02C1\u02C0\u02C0\u02BC\u02B8\u02C1\u02B3\u02C1, (\u02B9\u02C0\u02B2\u02C0\u02B6\u02BB\u02BE\u02B9\u02C0\u02B9\u02BD - 0.5f) * 2f);
		}
		else
		{
			this.\u02BD\u02B2\u02BB\u02B8\u02B8\u02B9\u02B6\u02B4\u02B4\u02B5\u02BC = Vector3.Lerp(this.\u02B7\u02C1\u02BF\u02BA\u02BB\u02B3\u02B6\u02B5\u02B8\u02B3\u02BA, this.\u02B3\u02B5\u02B5\u02BB\u02BF\u02B3\u02C0\u02B7\u02BC\u02B6\u02B3, \u02B9\u02C0\u02B2\u02C0\u02B6\u02BB\u02BE\u02B9\u02C0\u02B9\u02BD * 2f);
		}
		this.\u02B4\u02BD\u02BF\u02BC\u02BE\u02B9\u02BD\u02C1\u02BB\u02B6\u02B4 = \u02B9\u02C0\u02B2\u02C0\u02B6\u02BB\u02BE\u02B9\u02C0\u02B9\u02BD;
		this.\u02C0\u02C1\u02B9\u02B5\u02B3\u02BD\u02BE\u02B5\u02B3\u02B5\u02BD.localPosition = this.\u02BD\u02B2\u02BB\u02B8\u02B8\u02B9\u02B6\u02B4\u02B4\u02B5\u02BC;
	}

	public void \u02BD\u02BB\u02B2\u02B7\u02B9\u02BA\u02BB\u02B4\u02B3\u02B7\u02C1(float \u02B9\u02C0\u02B2\u02C0\u02B6\u02BB\u02BE\u02B9\u02C0\u02B9\u02BD)
	{
		if (\u02B9\u02C0\u02B2\u02C0\u02B6\u02BB\u02BE\u02B9\u02C0\u02B9\u02BD == this.\u02B4\u02BD\u02BF\u02BC\u02BE\u02B9\u02BD\u02C1\u02BB\u02B6\u02B4)
		{
			return;
		}
		if (\u02B9\u02C0\u02B2\u02C0\u02B6\u02BB\u02BE\u02B9\u02C0\u02B9\u02BD > this.\u02BB\u02B4\u02B5\u02B2\u02B5\u02BD\u02BD\u02B8\u02B8\u02BC\u02BD)
		{
			if (this.\u02B4\u02BD\u02BF\u02BC\u02BE\u02B9\u02BD\u02C1\u02BB\u02B6\u02B4 <= this.\u02BB\u02B4\u02B5\u02B2\u02B5\u02BD\u02BD\u02B8\u02B8\u02BC\u02BD)
			{
				this.\u02B2\u02BD\u02BA\u02BB\u02BF\u02C0\u02C1\u02B4\u02B7\u02BB\u02B7.SetActive(true);
				this.\u02BD\u02BD\u02B7\u02B6\u02B9\u02B3\u02B9\u02BB\u02B2\u02B3\u02BE.SetActive(true);
				this.\u02BE\u02BF\u02B9\u02B3\u02BA\u02BB\u02BD\u02B8\u02BA\u02B4\u02B8.color = this.\u02B8\u02C1\u02C0\u02BF\u02BF\u02B4\u02C0\u02BB\u02B9\u02B9\u02B5;
			}
		}
		else if (\u02B9\u02C0\u02B2\u02C0\u02B6\u02BB\u02BE\u02B9\u02C0\u02B9\u02BD > this.\u02B5\u02B6\u02BE\u02B6\u02C0\u02B8\u02BE\u02B5\u02BA\u02B4\u02B2)
		{
			if (this.\u02B4\u02BD\u02BF\u02BC\u02BE\u02B9\u02BD\u02C1\u02BB\u02B6\u02B4 > this.\u02BB\u02B4\u02B5\u02B2\u02B5\u02BD\u02BD\u02B8\u02B8\u02BC\u02BD)
			{
				this.\u02B2\u02BD\u02BA\u02BB\u02BF\u02C0\u02C1\u02B4\u02B7\u02BB\u02B7.SetActive(true);
				this.\u02BD\u02BD\u02B7\u02B6\u02B9\u02B3\u02B9\u02BB\u02B2\u02B3\u02BE.SetActive(true);
				this.\u02BE\u02BF\u02B9\u02B3\u02BA\u02BB\u02BD\u02B8\u02BA\u02B4\u02B8.color = this.\u02B5\u02BD\u02B2\u02C0\u02C1\u02B7\u02BB\u02B3\u02C1\u02B2\u02BD;
			}
			else if (this.\u02B4\u02BD\u02BF\u02BC\u02BE\u02B9\u02BD\u02C1\u02BB\u02B6\u02B4 <= this.\u02B5\u02B6\u02BE\u02B6\u02C0\u02B8\u02BE\u02B5\u02BA\u02B4\u02B2)
			{
				this.\u02BD\u02BD\u02B7\u02B6\u02B9\u02B3\u02B9\u02BB\u02B2\u02B3\u02BE.SetActive(true);
				this.\u02BC\u02B2\u02B9\u02BB\u02C1\u02B3\u02BA\u02B9\u02BE\u02B8\u02C0.SetActive(false);
				this.\u02BE\u02BF\u02B9\u02B3\u02BA\u02BB\u02BD\u02B8\u02BA\u02B4\u02B8.color = this.\u02B5\u02BD\u02B2\u02C0\u02C1\u02B7\u02BB\u02B3\u02C1\u02B2\u02BD;
			}
		}
		else if (this.\u02B4\u02BD\u02BF\u02BC\u02BE\u02B9\u02BD\u02C1\u02BB\u02B6\u02B4 > this.\u02B5\u02B6\u02BE\u02B6\u02C0\u02B8\u02BE\u02B5\u02BA\u02B4\u02B2)
		{
			this.\u02BD\u02BD\u02B7\u02B6\u02B9\u02B3\u02B9\u02BB\u02B2\u02B3\u02BE.SetActive(true);
			this.\u02BC\u02B2\u02B9\u02BB\u02C1\u02B3\u02BA\u02B9\u02BE\u02B8\u02C0.SetActive(true);
			this.\u02BE\u02BF\u02B9\u02B3\u02BA\u02BB\u02BD\u02B8\u02BA\u02B4\u02B8.color = this.\u02BE\u02C0\u02B2\u02B3\u02BA\u02B8\u02B9\u02BA\u02B2\u02B5\u02BE;
		}
		if (\u02B9\u02C0\u02B2\u02C0\u02B6\u02BB\u02BE\u02B9\u02C0\u02B9\u02BD >= 1754f)
		{
			this.\u02BD\u02B2\u02BB\u02B8\u02B8\u02B9\u02B6\u02B4\u02B4\u02B5\u02BC = Vector3.Lerp(this.\u02B3\u02B5\u02B5\u02BB\u02BF\u02B3\u02C0\u02B7\u02BC\u02B6\u02B3, this.\u02B6\u02B5\u02B9\u02C1\u02C0\u02C0\u02BC\u02B8\u02C1\u02B3\u02C1, (\u02B9\u02C0\u02B2\u02C0\u02B6\u02BB\u02BE\u02B9\u02C0\u02B9\u02BD - 629f) * 684f);
		}
		else
		{
			this.\u02BD\u02B2\u02BB\u02B8\u02B8\u02B9\u02B6\u02B4\u02B4\u02B5\u02BC = Vector3.Lerp(this.\u02B7\u02C1\u02BF\u02BA\u02BB\u02B3\u02B6\u02B5\u02B8\u02B3\u02BA, this.\u02B3\u02B5\u02B5\u02BB\u02BF\u02B3\u02C0\u02B7\u02BC\u02B6\u02B3, \u02B9\u02C0\u02B2\u02C0\u02B6\u02BB\u02BE\u02B9\u02C0\u02B9\u02BD * 738f);
		}
		this.\u02B4\u02BD\u02BF\u02BC\u02BE\u02B9\u02BD\u02C1\u02BB\u02B6\u02B4 = \u02B9\u02C0\u02B2\u02C0\u02B6\u02BB\u02BE\u02B9\u02C0\u02B9\u02BD;
		this.\u02C0\u02C1\u02B9\u02B5\u02B3\u02BD\u02BE\u02B5\u02B3\u02B5\u02BD.localPosition = this.\u02BD\u02B2\u02BB\u02B8\u02B8\u02B9\u02B6\u02B4\u02B4\u02B5\u02BC;
	}

	private void \u02B5\u02C0\u02BE\u02B8\u02B9\u02B2\u02BD\u02C0\u02BF\u02B3\u02BD()
	{
		this.\u02B5\u02B6\u02BE\u02B6\u02C0\u02B8\u02BE\u02B5\u02BA\u02B4\u02B2 = 1910f;
		this.\u02BB\u02B4\u02B5\u02B2\u02B5\u02BD\u02BD\u02B8\u02B8\u02BC\u02BD = 986f;
		this.\u02BD\u02B2\u02BB\u02B8\u02B8\u02B9\u02B6\u02B4\u02B4\u02B5\u02BC = this.\u02C0\u02C1\u02B9\u02B5\u02B3\u02BD\u02BE\u02B5\u02B3\u02B5\u02BD.position;
		this.\u02BC\u02B2\u02B9\u02BB\u02C1\u02B3\u02BA\u02B9\u02BE\u02B8\u02C0.SetActive(true);
		this.\u02B2\u02BD\u02BA\u02BB\u02BF\u02C0\u02C1\u02B4\u02B7\u02BB\u02B7.SetActive(true);
	}

	public GameObject \u02BC\u02B2\u02B9\u02BB\u02C1\u02B3\u02BA\u02B9\u02BE\u02B8\u02C0;

	public GameObject \u02BD\u02BD\u02B7\u02B6\u02B9\u02B3\u02B9\u02BB\u02B2\u02B3\u02BE;

	public GameObject \u02B2\u02BD\u02BA\u02BB\u02BF\u02C0\u02C1\u02B4\u02B7\u02BB\u02B7;

	public Transform \u02C0\u02C1\u02B9\u02B5\u02B3\u02BD\u02BE\u02B5\u02B3\u02B5\u02BD;

	public SpriteRenderer \u02BE\u02BF\u02B9\u02B3\u02BA\u02BB\u02BD\u02B8\u02BA\u02B4\u02B8;

	public float \u02B8\u02BE\u02BE\u02B5\u02C0\u02B2\u02BE\u02B9\u02B2\u02C1\u02B2;

	public float \u02B8\u02B9\u02B3\u02BF\u02C1\u02BB\u02B8\u02B4\u02B3\u02BE\u02BA;

	public float \u02C1\u02B3\u02C0\u02C0\u02BF\u02B7\u02B9\u02C1\u02BC\u02B2\u02BB;

	public float \u02C0\u02BF\u02BB\u02C1\u02B8\u02B8\u02B2\u02B3\u02B3\u02B7\u02BC;

	private float \u02B4\u02BD\u02BF\u02BC\u02BE\u02B9\u02BD\u02C1\u02BB\u02B6\u02B4;

	private float \u02B5\u02B6\u02BE\u02B6\u02C0\u02B8\u02BE\u02B5\u02BA\u02B4\u02B2;

	private float \u02BB\u02B4\u02B5\u02B2\u02B5\u02BD\u02BD\u02B8\u02B8\u02BC\u02BD;

	private Vector3 \u02BD\u02B2\u02BB\u02B8\u02B8\u02B9\u02B6\u02B4\u02B4\u02B5\u02BC;

	public Color \u02B8\u02C1\u02C0\u02BF\u02BF\u02B4\u02C0\u02BB\u02B9\u02B9\u02B5;

	public Color \u02B5\u02BD\u02B2\u02C0\u02C1\u02B7\u02BB\u02B3\u02C1\u02B2\u02BD;

	public Color \u02BE\u02C0\u02B2\u02B3\u02BA\u02B8\u02B9\u02BA\u02B2\u02B5\u02BE;

	public Vector3 \u02B6\u02B5\u02B9\u02C1\u02C0\u02C0\u02BC\u02B8\u02C1\u02B3\u02C1;

	public Vector3 \u02B3\u02B5\u02B5\u02BB\u02BF\u02B3\u02C0\u02B7\u02BC\u02B6\u02B3;

	public Vector3 \u02B7\u02C1\u02BF\u02BA\u02BB\u02B3\u02B6\u02B5\u02B8\u02B3\u02BA;

	private bool failed;
}
