using System;
using System.Collections;
using A;
using StrikeCore;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
	public void \u02B7\u02B5\u02B9\u02BE\u02B4\u02B4\u02C1\u02B8\u02BE\u02B2\u02B7(int \u02BE\u02BB\u02B5\u02B7\u02B9\u02B2\u02B6\u02BF\u02B9\u02B7\u02B7)
	{
		this.\u02BC\u02B6\u02B6\u02B6\u02BA\u02BA\u02BF\u02BE\u02B5\u02BA\u02BA.\u02B8\u02B2\u02C1\u02B8\u02BB\u02BA\u02B7\u02B7\u02BD\u02C1\u02BC(-this.playerObjects[\u02BE\u02BB\u02B5\u02B7\u02B9\u02B2\u02B6\u02BF\u02B9\u02B7\u02B7].\u02C1\u02BA\u02BA\u02C0\u02B7\u02BA\u02B3\u02BF\u02C1\u02B7\u02C1());
	}

	private void \u02B7\u02BA\u02BD\u02B8\u02B7\u02BD\u02B6\u02BE\u02B6\u02B7\u02B9()
	{
		if (this.\u02B4\u02BA\u02BF\u02BF\u02BD\u02B5\u02BF\u02B2\u02BF\u02B9\u02B3 != this.\u02BC\u02B3\u02BD\u02BA\u02B4\u02BA\u02B4\u02B4\u02C1\u02B5\u02B6)
		{
			if (this.\u02BC\u02B3\u02BD\u02BA\u02B4\u02BA\u02B4\u02B4\u02C1\u02B5\u02B6 >= 3)
			{
				this.\u02B2\u02B9\u02B3\u02C0\u02BC\u02BA\u02B4\u02B5\u02C0\u02BA\u02B3 = 5;
			}
			else if (this.\u02BC\u02B3\u02BD\u02BA\u02B4\u02BA\u02B4\u02B4\u02C1\u02B5\u02B6 < -9)
			{
				this.\u02B2\u02B9\u02B3\u02C0\u02BC\u02BA\u02B4\u02B5\u02C0\u02BA\u02B3 = 1;
			}
		}
		this.\u02B4\u02BA\u02BF\u02BF\u02BD\u02B5\u02BF\u02B2\u02BF\u02B9\u02B3 = this.\u02BC\u02B3\u02BD\u02BA\u02B4\u02BA\u02B4\u02B4\u02C1\u02B5\u02B6;
		this.comboFont.\u02B4\u02B6\u02B5\u02B3\u02B7\u02C0\u02C1\u02BD\u02B9\u02BF\u02BA(this.\u02BC\u02B3\u02BD\u02BA\u02B4\u02BA\u02B4\u02B4\u02C1\u02B5\u02B6);
		if (this.\u02BF\u02B9\u02B4\u02BF\u02C1\u02B2\u02B5\u02C1\u02BA\u02BE\u02C1(this.\u02B2\u02B9\u02B3\u02C0\u02BC\u02BA\u02B4\u02B5\u02C0\u02BA\u02B3))
		{
			this.comboBox.localPosition = this.comboBoxDesiredPos;
		}
	}

	private void \u02BD\u02BA\u02BA\u02B8\u02B5\u02B6\u02B5\u02B7\u02B8\u02B9\u02B2()
	{
		if (this.\u02B4\u02BA\u02BF\u02BF\u02BD\u02B5\u02BF\u02B2\u02BF\u02B9\u02B3 != this.\u02BC\u02B3\u02BD\u02BA\u02B4\u02BA\u02B4\u02B4\u02C1\u02B5\u02B6)
		{
			if (this.\u02BC\u02B3\u02BD\u02BA\u02B4\u02BA\u02B4\u02B4\u02C1\u02B5\u02B6 >= GlobalHelper.comboShowAt)
			{
				this.\u02B2\u02B9\u02B3\u02C0\u02BC\u02BA\u02B4\u02B5\u02C0\u02BA\u02B3 = 2;
			}
			else if (this.\u02BC\u02B3\u02BD\u02BA\u02B4\u02BA\u02B4\u02B4\u02C1\u02B5\u02B6 < GlobalHelper.comboShowAt)
			{
				this.\u02B2\u02B9\u02B3\u02C0\u02BC\u02BA\u02B4\u02B5\u02C0\u02BA\u02B3 = 1;
			}
		}
		this.\u02B4\u02BA\u02BF\u02BF\u02BD\u02B5\u02BF\u02B2\u02BF\u02B9\u02B3 = this.\u02BC\u02B3\u02BD\u02BA\u02B4\u02BA\u02B4\u02B4\u02C1\u02B5\u02B6;
		this.comboFont.SetSprites(this.\u02BC\u02B3\u02BD\u02BA\u02B4\u02BA\u02B4\u02B4\u02C1\u02B5\u02B6);
		if (this.\u02BA\u02C1\u02C1\u02BE\u02C1\u02B7\u02B5\u02B3\u02BC\u02B4\u02B4(this.\u02B2\u02B9\u02B3\u02C0\u02BC\u02BA\u02B4\u02B5\u02C0\u02BA\u02B3))
		{
			this.comboBox.localPosition = this.comboBoxDesiredPos;
		}
	}

	public void \u02B5\u02B2\u02BC\u02B8\u02B9\u02C1\u02BE\u02B2\u02B2\u02BC\u02BF(int \u02BE\u02BB\u02B5\u02B7\u02B9\u02B2\u02B6\u02BF\u02B9\u02B7\u02B7)
	{
		this.\u02BC\u02B6\u02B6\u02B6\u02BA\u02BA\u02BF\u02BE\u02B5\u02BA\u02BA.\u02B8\u02B2\u02C1\u02B8\u02BB\u02BA\u02B7\u02B7\u02BD\u02C1\u02BC(-this.playerObjects[\u02BE\u02BB\u02B5\u02B7\u02B9\u02B2\u02B6\u02BF\u02B9\u02B7\u02B7].\u02C1\u02BA\u02BA\u02C0\u02B7\u02BA\u02B3\u02BF\u02C1\u02B7\u02C1());
	}

	private IEnumerator Start()
	{
		this.comboOrigColor = this.comboFont.Sprites[0].color;
		if (GlobalVariables.instance.\u02B6\u02B9\u02B5\u02BA\u02BD\u02B9\u02BD\u02BC\u02B9\u02B3\u02C1 == GameMode.Versus && !GlobalVariables.instance.isPracticeEnabled)
		{
			base.enabled = false;
			yield break;
		}
		base.enabled = false;
		GameManager manager = GameObject.Find("Game Manager").GetComponent<GameManager>();
		this.\u02BF\u02BD\u02B7\u02B8\u02B5\u02B4\u02B5\u02C1\u02C1\u02BE\u02B2 = this.\u02B3\u02BC\u02BD\u02C1\u02BF\u02B5\u02BA\u02C0\u02B4\u02BF\u02B7();
		while (manager.playerObjects == null || manager.playerObjects.Length == 0)
		{
			yield return null;
		}
		this.playerObjects = manager.playerObjects;
		this.\u02B5\u02B7\u02C1\u02BC\u02B5\u02BD\u02B9\u02BC\u02BE\u02B8\u02BA = GlobalVariables.instance.\u02BA\u02B9\u02BD\u02BA\u02B4\u02B4\u02BF\u02BD\u02B8\u02B3\u02C1.scores.\u02BC\u02BB\u02B9\u02B5\u02B5\u02BB\u02B8\u02B9\u02B9\u02BC\u02BC(GlobalVariables.instance.\u02BA\u02BB\u02B6\u02B2\u02BF\u02C0\u02BF\u02B3\u02B8\u02B3\u02BE()).\u02BC\u02BC\u02C1\u02B4\u02BF\u02B8\u02BF\u02B2\u02BA\u02B3\u02B5;
		this.\u02BA\u02B7\u02C0\u02B2\u02BF\u02B6\u02BE\u02BF\u02BA\u02C0\u02BA = GlobalVariables.instance.\u02BA\u02B3\u02BE\u02B6\u02BF\u02B3\u02BB\u02C1\u02B6\u02C1\u02BF();
		base.enabled = true;
		yield break;
	}

	private IEnumerator \u02B3\u02BC\u02BD\u02C1\u02BF\u02B5\u02BA\u02C0\u02B4\u02BF\u02B7()
	{
		this.highScoreDisplay.\u02B3\u02BC\u02B4\u02B5\u02BD\u02C0\u02B8\u02BD\u02B7\u02B5\u02BF(false);
		yield return this.\u02B2\u02B5\u02B2\u02B5\u02B4\u02BF\u02B2\u02B8\u02BE\u02B2\u02B9;
		this.highScoreDisplay.\u02B3\u02BC\u02B4\u02B5\u02BD\u02C0\u02B8\u02BD\u02B7\u02B5\u02BF(true);
		yield break;
	}

	private void \u02C0\u02BB\u02B9\u02BC\u02BD\u02B3\u02B2\u02BE\u02B7\u02B9\u02B2()
	{
		this.\u02BC\u02B3\u02BD\u02BA\u02B4\u02BA\u02B4\u02B4\u02C1\u02B5\u02B6 = 0;
		this.\u02BF\u02B4\u02C0\u02B3\u02BF\u02C1\u02C0\u02BE\u02B7\u02C1\u02C0 = 0;
		this.\u02B3\u02B7\u02BA\u02B4\u02B6\u02C0\u02B6\u02B7\u02B4\u02B7\u02BE = 0;
		for (int i = 0; i < this.playerObjects.Length; i++)
		{
			BasePlayer basePlayer = this.playerObjects[i];
			if (!(basePlayer == null) && basePlayer.player.\u02BC\u02BA\u02BE\u02B2\u02C0\u02BE\u02B6\u02B5\u02BC\u02B3\u02BD)
			{
				this.\u02BF\u02B4\u02C0\u02B3\u02BF\u02C1\u02C0\u02BE\u02B7\u02C1\u02C0 += basePlayer.\u02BC\u02BC\u02C1\u02B4\u02BF\u02B8\u02BF\u02B2\u02BA\u02B3\u02B5;
				this.\u02B3\u02B7\u02BA\u02B4\u02B6\u02C0\u02B6\u02B7\u02B4\u02B7\u02BE += basePlayer.\u02C1\u02B4\u02BB\u02B3\u02B3\u02BB\u02C0\u02B4\u02C1\u02BB\u02BE;
				this.\u02BC\u02B3\u02BD\u02BA\u02B4\u02BA\u02B4\u02B4\u02C1\u02B5\u02B6 += basePlayer.combo;
			}
		}
		this.overallScore = this.\u02BF\u02B4\u02C0\u02B3\u02BF\u02C1\u02C0\u02BE\u02B7\u02C1\u02C0 + this.\u02B3\u02B7\u02BA\u02B4\u02B6\u02C0\u02B6\u02B7\u02B4\u02B7\u02BE;
		float scoreSmoothTime = GlobalHelper.scoreSmoothTime;
		if (scoreSmoothTime == 0f)
		{
			this.startScore = this.overallScore;
			this.lastScore = this.overallScore;
			this.targetScore = this.overallScore;
			this.elapsedTime = 0f;
			this.scoreFont.SetSprites(this.lastScore);
			return;
		}
		if (this.overallScore != this.targetScore)
		{
			this.startScore = this.lastScore;
			this.targetScore = this.overallScore;
			this.elapsedTime = 0f;
		}
		else
		{
			this.elapsedTime += Time.deltaTime;
		}
		if (this.elapsedTime >= scoreSmoothTime)
		{
			this.elapsedTime = scoreSmoothTime;
			this.lastScore = this.targetScore;
		}
		else
		{
			this.lastScore = this.calculateDisplayScore(this.elapsedTime);
		}
		this.scoreFont.SetSprites(this.lastScore);
	}

	private void Update()
	{
		this.ticker += Time.unscaledDeltaTime;
		if (this.ticker > 0.11f)
		{
			this.ticker -= 0.11f;
			Color color = Helper.HexColorToColor(HexColor.FromHexString(GlobalHelper.scoreColor), 1f);
			if (color == Color.black)
			{
				color = Color.clear;
			}
			SpriteRenderer[] array = this.scoreFont.Sprites;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].color = color;
			}
			color = Helper.HexColorToColor(HexColor.FromHexString(GlobalHelper.noteStreakColor), 1f);
			if (color == Color.white)
			{
				color = this.comboOrigColor;
			}
			if (color == Color.black)
			{
				color = Color.clear;
			}
			array = this.comboFont.Sprites;
			for (int j = 0; j < array.Length; j++)
			{
				array[j].color = color;
			}
		}
		this.\u02C0\u02BB\u02B9\u02BC\u02BD\u02B3\u02B2\u02BE\u02B7\u02B9\u02B2();
		this.\u02BD\u02BA\u02BA\u02B8\u02B5\u02B6\u02B5\u02B7\u02B8\u02B9\u02B2();
		if (!GlobalVariables.instance.isPracticeEnabled)
		{
			this.\u02BC\u02B6\u02B6\u02B6\u02BA\u02BA\u02BF\u02BE\u02B5\u02BA\u02BA.\u02BA\u02BD\u02B8\u02BA\u02BE\u02C0\u02B2\u02BE\u02B9\u02B2\u02BB(this.\u02BF\u02B4\u02C0\u02B3\u02BF\u02C1\u02C0\u02BE\u02B7\u02C1\u02C0);
			if (this.\u02B5\u02B7\u02C1\u02BC\u02B5\u02BD\u02B9\u02BC\u02BE\u02B8\u02BA != 0 && !this.\u02BA\u02B7\u02C0\u02B2\u02BF\u02B6\u02BE\u02BF\u02BA\u02C0\u02BA && GlobalVariables.instance.\u02BB\u02BA\u02C1\u02B8\u02BA\u02C0\u02BD\u02BE\u02B7\u02B7\u02BA == \u02BD\u02B9\u02B2\u02B5\u02BD\u02BC\u02BE\u02BE\u02BE\u02B7\u02B2.None && this.overallScore > this.\u02B5\u02B7\u02C1\u02BC\u02B5\u02BD\u02B9\u02BC\u02BE\u02B8\u02BA && !this.\u02BD\u02BE\u02BB\u02BA\u02BC\u02BB\u02B3\u02BF\u02B3\u02BA\u02C1)
			{
				this.\u02BD\u02BE\u02BB\u02BA\u02BC\u02BB\u02B3\u02BF\u02B3\u02BA\u02C1 = true;
				base.StartCoroutine(this.\u02BF\u02BD\u02B7\u02B8\u02B5\u02B4\u02B5\u02C1\u02C1\u02BE\u02B2);
			}
		}
	}

	private bool \u02BA\u02C1\u02C1\u02BE\u02C1\u02B7\u02B5\u02B3\u02BC\u02B4\u02B4(int \u02B2\u02B9\u02B3\u02C0\u02BC\u02BA\u02B4\u02B5\u02C0\u02BA\u02B3)
	{
		this.comboBoxDesiredPos = this.comboBox.localPosition;
		if (\u02B2\u02B9\u02B3\u02C0\u02BC\u02BA\u02B4\u02B5\u02C0\u02BA\u02B3 == 1)
		{
			if (this.comboBoxDesiredPos.y >= this.maxHeight)
			{
				if (this.comboBoxDesiredPos.y > this.maxHeight)
				{
					this.comboBoxDesiredPos.y = this.maxHeight;
					return true;
				}
				return false;
			}
			else
			{
				this.comboBoxDesiredPos.y = this.comboBoxDesiredPos.y + this.\u02BA\u02C1\u02B6\u02B7\u02BE\u02BB\u02BE\u02B6\u02BC\u02B6\u02C1 * Time.deltaTime;
			}
		}
		if (\u02B2\u02B9\u02B3\u02C0\u02BC\u02BA\u02B4\u02B5\u02C0\u02BA\u02B3 == 2)
		{
			if (this.comboBoxDesiredPos.y <= this.minHeight)
			{
				if (this.comboBoxDesiredPos.y < this.minHeight)
				{
					this.comboBoxDesiredPos.y = this.minHeight;
					return true;
				}
				return false;
			}
			else
			{
				this.comboBoxDesiredPos.y = this.comboBoxDesiredPos.y - this.\u02BA\u02C1\u02B6\u02B7\u02BE\u02BB\u02BE\u02B6\u02BC\u02B6\u02C1 * Time.deltaTime;
			}
		}
		return true;
	}

	private bool \u02BF\u02B9\u02B4\u02BF\u02C1\u02B2\u02B5\u02C1\u02BA\u02BE\u02C1(int \u02B2\u02B9\u02B3\u02C0\u02BC\u02BA\u02B4\u02B5\u02C0\u02BA\u02B3)
	{
		this.comboBoxDesiredPos = this.comboBox.localPosition;
		if (\u02B2\u02B9\u02B3\u02C0\u02BC\u02BA\u02B4\u02B5\u02C0\u02BA\u02B3 == 0)
		{
			if (this.comboBoxDesiredPos.y >= this.maxHeight)
			{
				if (this.comboBoxDesiredPos.y > this.maxHeight)
				{
					this.comboBoxDesiredPos.y = this.maxHeight;
					return false;
				}
				return true;
			}
			else
			{
				this.comboBoxDesiredPos.y = this.comboBoxDesiredPos.y + this.\u02BA\u02C1\u02B6\u02B7\u02BE\u02BB\u02BE\u02B6\u02BC\u02B6\u02C1 * Time.deltaTime;
			}
		}
		if (\u02B2\u02B9\u02B3\u02C0\u02BC\u02BA\u02B4\u02B5\u02C0\u02BA\u02B3 == 0)
		{
			if (this.comboBoxDesiredPos.y <= this.minHeight)
			{
				if (this.comboBoxDesiredPos.y < this.minHeight)
				{
					this.comboBoxDesiredPos.y = this.minHeight;
					return true;
				}
				return true;
			}
			else
			{
				this.comboBoxDesiredPos.y = this.comboBoxDesiredPos.y - this.\u02BA\u02C1\u02B6\u02B7\u02BE\u02BB\u02BE\u02B6\u02BC\u02B6\u02C1 * Time.deltaTime;
			}
		}
		return true;
	}

	public void \u02BD\u02B5\u02C1\u02B8\u02BE\u02BE\u02BB\u02B4\u02BA\u02B4\u02B4(int \u02BE\u02BB\u02B5\u02B7\u02B9\u02B2\u02B6\u02BF\u02B9\u02B7\u02B7)
	{
		this.\u02BC\u02B6\u02B6\u02B6\u02BA\u02BA\u02BF\u02BE\u02B5\u02BA\u02BA.\u02BD\u02BA\u02B5\u02B9\u02C1\u02BE\u02BA\u02BF\u02B9\u02B7\u02B8(-this.playerObjects[\u02BE\u02BB\u02B5\u02B7\u02B9\u02B2\u02B6\u02BF\u02B9\u02B7\u02B7].\u02C1\u02BA\u02BA\u02C0\u02B7\u02BA\u02B3\u02BF\u02C1\u02B7\u02C1());
	}

	private IEnumerator \u02BB\u02C0\u02BB\u02BF\u02BE\u02B4\u02BB\u02BB\u02C0\u02B3\u02C0()
	{
		this.highScoreDisplay.\u02B3\u02BC\u02B4\u02B5\u02BD\u02C0\u02B8\u02BD\u02B7\u02B5\u02BF(false);
		yield return this.\u02B2\u02B5\u02B2\u02B5\u02B4\u02BF\u02B2\u02B8\u02BE\u02B2\u02B9;
		this.highScoreDisplay.\u02B3\u02BC\u02B4\u02B5\u02BD\u02C0\u02B8\u02BD\u02B7\u02B5\u02BF(true);
		yield break;
	}

	private int calculateDisplayScore(float t)
	{
		if (t == 0f)
		{
			return this.startScore;
		}
		if (t > GlobalHelper.scoreSmoothTime)
		{
			return this.targetScore;
		}
		float num = t / GlobalHelper.scoreSmoothTime;
		return (int)Mathf.Ceil(Mathf.Lerp((float)this.startScore, (float)this.targetScore, num));
	}

	public Transform comboBox;

	[SerializeField]
	private HighScoreDisplay highScoreDisplay;

	private bool \u02BA\u02B7\u02C0\u02B2\u02BF\u02B6\u02BE\u02BF\u02BA\u02C0\u02BA;

	private BasePlayer[] playerObjects;

	private int \u02BF\u02B4\u02C0\u02B3\u02BF\u02C1\u02C0\u02BE\u02B7\u02C1\u02C0;

	private int \u02B3\u02B7\u02BA\u02B4\u02B6\u02C0\u02B6\u02B7\u02B4\u02B7\u02BE;

	private int \u02BC\u02B3\u02BD\u02BA\u02B4\u02BA\u02B4\u02B4\u02C1\u02B5\u02B6;

	private int \u02B5\u02B7\u02C1\u02BC\u02B5\u02BD\u02B9\u02BC\u02BE\u02B8\u02BA;

	private int overallScore;

	private int \u02B4\u02BA\u02BF\u02BF\u02BD\u02B5\u02BF\u02B2\u02BF\u02B9\u02B3;

	private int \u02B2\u02B9\u02B3\u02C0\u02BC\u02BA\u02B4\u02B5\u02C0\u02BA\u02B3 = -1;

	private float \u02BA\u02C1\u02B6\u02B7\u02BE\u02BB\u02BE\u02B6\u02BC\u02B6\u02C1 = 0.3f;

	private float maxHeight = 0.36f;

	private float minHeight = 0.28f;

	private Vector3 comboBoxDesiredPos;

	private bool \u02BD\u02BE\u02BB\u02BA\u02BC\u02BB\u02B3\u02BF\u02B3\u02BA\u02C1;

	private IEnumerator \u02BF\u02BD\u02B7\u02B8\u02B5\u02B4\u02B5\u02C1\u02C1\u02BE\u02B2;

	public SpriteFont comboFont;

	public SpriteFont scoreFont;

	public StarProgress \u02BC\u02B6\u02B6\u02B6\u02BA\u02BA\u02BF\u02BE\u02B5\u02BA\u02BA;

	private YieldInstruction \u02B2\u02B5\u02B2\u02B5\u02B4\u02BF\u02B2\u02B8\u02BE\u02B2\u02B9 = new WaitForSeconds(3.5f);

	private float colorr;

	private float colorg;

	private float colorb;

	private float ticker;

	private Color comboOrigColor;

	private int lastScore;

	private float elapsedTime;

	private int targetScore;

	private int startScore;
}
