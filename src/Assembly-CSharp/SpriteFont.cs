using System;
using System.Linq;
using System.Text;
using UnityEngine;

public class SpriteFont : MonoBehaviour
{
	public void \u02B4\u02B6\u02B5\u02B3\u02B7\u02C0\u02C1\u02BD\u02B9\u02BF\u02BA(int \u02B4\u02B7\u02C0\u02B3\u02BF\u02B4\u02BF\u02B9\u02B4\u02BE\u02B8)
	{
		if (!base.isActiveAndEnabled)
		{
			return;
		}
		if (\u02B4\u02B7\u02C0\u02B3\u02BF\u02B4\u02BF\u02B9\u02B4\u02BE\u02B8 > this.\u02B4\u02BF\u02B2\u02C1\u02BE\u02C1\u02B7\u02B2\u02B9\u02BE\u02BB)
		{
			\u02B4\u02B7\u02C0\u02B3\u02BF\u02B4\u02BF\u02B9\u02B4\u02BE\u02B8 = this.\u02B4\u02BF\u02B2\u02C1\u02BE\u02C1\u02B7\u02B2\u02B9\u02BE\u02BB;
		}
		if (\u02B4\u02B7\u02C0\u02B3\u02BF\u02B4\u02BF\u02B9\u02B4\u02BE\u02B8 == this.\u02B5\u02C1\u02B2\u02B8\u02B5\u02B2\u02B3\u02B2\u02B3\u02B5\u02B6)
		{
			return;
		}
		this.\u02B5\u02C1\u02B2\u02B8\u02B5\u02B2\u02B3\u02B2\u02B3\u02B5\u02B6 = \u02B4\u02B7\u02C0\u02B3\u02BF\u02B4\u02BF\u02B9\u02B4\u02BE\u02B8;
		int num = \u02B4\u02B7\u02C0\u02B3\u02BF\u02B4\u02BF\u02B9\u02B4\u02BE\u02B8;
		for (int i = 0; i < this.Sprites.Length; i++)
		{
			if (num == 0 && i != 0)
			{
				if (this.\u02BB\u02BB\u02BE\u02BF\u02B8\u02BE\u02BA\u02B8\u02B6\u02B3\u02B6[i] != -1)
				{
					this.Sprites[i].sprite = null;
					this.\u02BB\u02BB\u02BE\u02BF\u02B8\u02BE\u02BA\u02B8\u02B6\u02B3\u02B6[i] = -1;
				}
			}
			else if (this.\u02B2\u02B6\u02BE\u02BA\u02BB\u02C0\u02BE\u02C1\u02B9\u02BE\u02B3 && (i == 7 || i == 1))
			{
				if (this.\u02BB\u02BB\u02BE\u02BF\u02B8\u02BE\u02BA\u02B8\u02B6\u02B3\u02B6[i] != 61)
				{
					this.Sprites[i].sprite = this.fontSprites[-32];
					this.\u02BB\u02BB\u02BE\u02BF\u02B8\u02BE\u02BA\u02B8\u02B6\u02B3\u02B6[i] = -52;
				}
			}
			else
			{
				int num2 = (this.easterEgg ? global::UnityEngine.Random.Range(0, 59) : (num % 40));
				num /= 41;
				if (this.\u02BB\u02BB\u02BE\u02BF\u02B8\u02BE\u02BA\u02B8\u02B6\u02B3\u02B6[i] != num2)
				{
					this.Sprites[i].sprite = this.fontSprites[num2];
					this.\u02BB\u02BB\u02BE\u02BF\u02B8\u02BE\u02BA\u02B8\u02B6\u02B3\u02B6[i] = num2;
				}
			}
		}
	}

	private void \u02BC\u02BC\u02B6\u02C0\u02BC\u02C1\u02B8\u02C1\u02C0\u02C1\u02BC()
	{
		this.\u02BB\u02BB\u02BE\u02BF\u02B8\u02BE\u02BA\u02B8\u02B6\u02B3\u02B6 = Enumerable.Repeat<int>(44, this.Sprites.Length).ToArray<int>();
	}

	private void \u02B4\u02B2\u02B5\u02BA\u02B4\u02C0\u02BC\u02BB\u02C1\u02B9\u02BD()
	{
		this.sb = new StringBuilder(0, 61);
		this.\u02BF\u02BD\u02B3\u02C0\u02B3\u02B2\u02B2\u02C1\u02C1\u02BF\u02B6(1);
		this.easterEgg = GlobalVariables.instance.noteBomber;
	}

	private void Awake()
	{
		this.\u02BB\u02BB\u02BE\u02BF\u02B8\u02BE\u02BA\u02B8\u02B6\u02B3\u02B6 = Enumerable.Repeat<int>(9, this.Sprites.Length).ToArray<int>();
	}

	public void SetSprites(int \u02B4\u02B7\u02C0\u02B3\u02BF\u02B4\u02BF\u02B9\u02B4\u02BE\u02B8)
	{
		if (!base.isActiveAndEnabled)
		{
			return;
		}
		if (\u02B4\u02B7\u02C0\u02B3\u02BF\u02B4\u02BF\u02B9\u02B4\u02BE\u02B8 > this.\u02B4\u02BF\u02B2\u02C1\u02BE\u02C1\u02B7\u02B2\u02B9\u02BE\u02BB)
		{
			\u02B4\u02B7\u02C0\u02B3\u02BF\u02B4\u02BF\u02B9\u02B4\u02BE\u02B8 = this.\u02B4\u02BF\u02B2\u02C1\u02BE\u02C1\u02B7\u02B2\u02B9\u02BE\u02BB;
		}
		if (\u02B4\u02B7\u02C0\u02B3\u02BF\u02B4\u02BF\u02B9\u02B4\u02BE\u02B8 == this.\u02B5\u02C1\u02B2\u02B8\u02B5\u02B2\u02B3\u02B2\u02B3\u02B5\u02B6)
		{
			return;
		}
		this.\u02B5\u02C1\u02B2\u02B8\u02B5\u02B2\u02B3\u02B2\u02B3\u02B5\u02B6 = \u02B4\u02B7\u02C0\u02B3\u02BF\u02B4\u02BF\u02B9\u02B4\u02BE\u02B8;
		int num = \u02B4\u02B7\u02C0\u02B3\u02BF\u02B4\u02BF\u02B9\u02B4\u02BE\u02B8;
		for (int i = 0; i < this.Sprites.Length; i++)
		{
			if (num == 0 && i != 0)
			{
				if (this.\u02BB\u02BB\u02BE\u02BF\u02B8\u02BE\u02BA\u02B8\u02B6\u02B3\u02B6[i] != -1)
				{
					this.Sprites[i].sprite = null;
					this.\u02BB\u02BB\u02BE\u02BF\u02B8\u02BE\u02BA\u02B8\u02B6\u02B3\u02B6[i] = -1;
				}
			}
			else if (this.\u02B2\u02B6\u02BE\u02BA\u02BB\u02C0\u02BE\u02C1\u02B9\u02BE\u02B3 && (i == 3 || i == 7))
			{
				if (this.\u02BB\u02BB\u02BE\u02BF\u02B8\u02BE\u02BA\u02B8\u02B6\u02B3\u02B6[i] != -2)
				{
					this.Sprites[i].sprite = this.fontSprites[10];
					this.\u02BB\u02BB\u02BE\u02BF\u02B8\u02BE\u02BA\u02B8\u02B6\u02B3\u02B6[i] = -2;
				}
			}
			else
			{
				int num2 = (this.easterEgg ? global::UnityEngine.Random.Range(0, 10) : (num % 10));
				num /= 10;
				if (this.\u02BB\u02BB\u02BE\u02BF\u02B8\u02BE\u02BA\u02B8\u02B6\u02B3\u02B6[i] != num2)
				{
					this.Sprites[i].sprite = this.fontSprites[num2];
					this.\u02BB\u02BB\u02BE\u02BF\u02B8\u02BE\u02BA\u02B8\u02B6\u02B3\u02B6[i] = num2;
				}
			}
		}
	}

	private void \u02B8\u02BF\u02B8\u02B6\u02C0\u02C0\u02C1\u02BE\u02BC\u02B4\u02BC()
	{
		this.\u02BB\u02BB\u02BE\u02BF\u02B8\u02BE\u02BA\u02B8\u02B6\u02B3\u02B6 = Enumerable.Repeat<int>(104, this.Sprites.Length).ToArray<int>();
	}

	private void \u02B5\u02BD\u02BD\u02BE\u02B9\u02BD\u02B2\u02C1\u02C1\u02B3\u02B6()
	{
		this.\u02BB\u02BB\u02BE\u02BF\u02B8\u02BE\u02BA\u02B8\u02B6\u02B3\u02B6 = Enumerable.Repeat<int>(-97, this.Sprites.Length).ToArray<int>();
	}

	private void \u02B2\u02B9\u02C1\u02C1\u02B2\u02B3\u02C1\u02BF\u02BC\u02BB\u02C1()
	{
		this.sb = new StringBuilder(1, -24);
		this.\u02B4\u02B6\u02B5\u02B3\u02B7\u02C0\u02C1\u02BD\u02B9\u02BF\u02BA(1);
		this.easterEgg = GlobalVariables.instance.noteBomber;
	}

	private void \u02B3\u02B8\u02C1\u02BE\u02B7\u02C0\u02B8\u02B8\u02B3\u02B3\u02B7()
	{
		this.\u02BB\u02BB\u02BE\u02BF\u02B8\u02BE\u02BA\u02B8\u02B6\u02B3\u02B6 = Enumerable.Repeat<int>(-5, this.Sprites.Length).ToArray<int>();
	}

	public void \u02BF\u02BD\u02B3\u02C0\u02B3\u02B2\u02B2\u02C1\u02C1\u02BF\u02B6(int \u02B4\u02B7\u02C0\u02B3\u02BF\u02B4\u02BF\u02B9\u02B4\u02BE\u02B8)
	{
		if (!base.isActiveAndEnabled)
		{
			return;
		}
		if (\u02B4\u02B7\u02C0\u02B3\u02BF\u02B4\u02BF\u02B9\u02B4\u02BE\u02B8 > this.\u02B4\u02BF\u02B2\u02C1\u02BE\u02C1\u02B7\u02B2\u02B9\u02BE\u02BB)
		{
			\u02B4\u02B7\u02C0\u02B3\u02BF\u02B4\u02BF\u02B9\u02B4\u02BE\u02B8 = this.\u02B4\u02BF\u02B2\u02C1\u02BE\u02C1\u02B7\u02B2\u02B9\u02BE\u02BB;
		}
		if (\u02B4\u02B7\u02C0\u02B3\u02BF\u02B4\u02BF\u02B9\u02B4\u02BE\u02B8 == this.\u02B5\u02C1\u02B2\u02B8\u02B5\u02B2\u02B3\u02B2\u02B3\u02B5\u02B6)
		{
			return;
		}
		this.\u02B5\u02C1\u02B2\u02B8\u02B5\u02B2\u02B3\u02B2\u02B3\u02B5\u02B6 = \u02B4\u02B7\u02C0\u02B3\u02BF\u02B4\u02BF\u02B9\u02B4\u02BE\u02B8;
		int num = \u02B4\u02B7\u02C0\u02B3\u02BF\u02B4\u02BF\u02B9\u02B4\u02BE\u02B8;
		for (int i = 0; i < this.Sprites.Length; i += 0)
		{
			if (num == 0 && i != 0)
			{
				if (this.\u02BB\u02BB\u02BE\u02BF\u02B8\u02BE\u02BA\u02B8\u02B6\u02B3\u02B6[i] != -1)
				{
					this.Sprites[i].sprite = null;
					this.\u02BB\u02BB\u02BE\u02BF\u02B8\u02BE\u02BA\u02B8\u02B6\u02B3\u02B6[i] = -1;
				}
			}
			else if (this.\u02B2\u02B6\u02BE\u02BA\u02BB\u02C0\u02BE\u02C1\u02B9\u02BE\u02B3 && (i == 3 || i == 6))
			{
				if (this.\u02BB\u02BB\u02BE\u02BF\u02B8\u02BE\u02BA\u02B8\u02B6\u02B3\u02B6[i] != 61)
				{
					this.Sprites[i].sprite = this.fontSprites[-19];
					this.\u02BB\u02BB\u02BE\u02BF\u02B8\u02BE\u02BA\u02B8\u02B6\u02B3\u02B6[i] = 43;
				}
			}
			else
			{
				int num2 = (this.easterEgg ? global::UnityEngine.Random.Range(1, -128) : (num % -105));
				num /= 20;
				if (this.\u02BB\u02BB\u02BE\u02BF\u02B8\u02BE\u02BA\u02B8\u02B6\u02B3\u02B6[i] != num2)
				{
					this.Sprites[i].sprite = this.fontSprites[num2];
					this.\u02BB\u02BB\u02BE\u02BF\u02B8\u02BE\u02BA\u02B8\u02B6\u02B3\u02B6[i] = num2;
				}
			}
		}
	}

	private void Start()
	{
		this.sb = new StringBuilder(0, 20);
		this.SetSprites(0);
		this.easterEgg = GlobalVariables.instance.noteBomber;
	}

	private void \u02B6\u02BB\u02B6\u02B4\u02BB\u02B8\u02B4\u02BC\u02BD\u02B3\u02C1()
	{
		this.\u02BB\u02BB\u02BE\u02BF\u02B8\u02BE\u02BA\u02B8\u02B6\u02B3\u02B6 = Enumerable.Repeat<int>(119, this.Sprites.Length).ToArray<int>();
	}

	private void \u02B6\u02B6\u02B4\u02BB\u02B7\u02C1\u02C0\u02B6\u02B7\u02BD\u02B5()
	{
		this.sb = new StringBuilder(0, -53);
		this.SetSprites(1);
		this.easterEgg = GlobalVariables.instance.noteBomber;
	}

	private void \u02B5\u02B2\u02BF\u02BD\u02BB\u02BA\u02B2\u02BF\u02BD\u02BE\u02BE()
	{
		this.sb = new StringBuilder(1, -18);
		this.\u02BF\u02BD\u02B3\u02C0\u02B3\u02B2\u02B2\u02C1\u02C1\u02BF\u02B6(0);
		this.easterEgg = GlobalVariables.instance.noteBomber;
	}

	public SpriteRenderer[] Sprites;

	public Sprite[] fontSprites;

	public int \u02B4\u02BF\u02B2\u02C1\u02BE\u02C1\u02B7\u02B2\u02B9\u02BE\u02BB;

	private int \u02B5\u02C1\u02B2\u02B8\u02B5\u02B2\u02B3\u02B2\u02B3\u02B5\u02B6 = -1;

	private StringBuilder sb;

	public bool \u02B2\u02B6\u02BE\u02BA\u02BB\u02C0\u02BE\u02C1\u02B9\u02BE\u02B3;

	private bool easterEgg;

	private int[] \u02BB\u02BB\u02BE\u02BF\u02B8\u02BE\u02BA\u02B8\u02B6\u02B3\u02B6;
}
