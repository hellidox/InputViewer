using System;
using UnityEngine;
using UnityEngine.SceneManagement;

// Token: 0x02000085 RID: 133
public class CreditsScroll : MonoBehaviour
{
	// Token: 0x0600056B RID: 1387 RVA: 0x000353C8 File Offset: 0x000335C8
	private void \u02C0\u02BE\u02B7\u02BF\u02B9\u02BB\u02C1\u02B2\u02B9\u02B7\u02B5()
	{
		this.\u02BB\u02BC\u02BA\u02C1\u02BE\u02B7\u02B6\u02B3\u02B8\u02BB\u02BB = this.containerScrollSpeed;
		foreach (\u02C1\u02BB\u02BD\u02B7\u02BD\u02BB\u02BE\u02B5\u02B7\u02C0\u02B6 u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B in GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B8\u02BD\u02B2\u02B2\u02B7\u02B5\u02B5\u02B3\u02C0\u02BD\u02BF)
		{
			if (u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.\u02BC\u02BA\u02BE\u02B2\u02C0\u02BE\u02B6\u02B5\u02BC\u02B3\u02BD)
			{
				if (u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.rewiredPlayer.GetButtonDown(1))
				{
					this.\u02BC\u02B5\u02B5\u02B2\u02B8\u02BF\u02B3\u02BE\u02BB\u02B8\u02B3();
				}
				else if (u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.rewiredPlayer.GetButton(100) || u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.rewiredPlayer.GetButton(4))
				{
					this.\u02BB\u02BC\u02BA\u02C1\u02BE\u02B7\u02B6\u02B3\u02B8\u02BB\u02BB = this.containerFastScrollSpeed;
				}
			}
		}
		this.\u02C1\u02B6\u02B6\u02BB\u02B4\u02C1\u02B5\u02BF\u02B2\u02BE\u02B7 += Time.deltaTime;
		if (this.\u02C1\u02B6\u02B6\u02BB\u02B4\u02C1\u02B5\u02BF\u02B2\u02BE\u02B7 >= this.scrollDelay)
		{
			this.containerTransform.position = new Vector2(this.containerTransform.position.x, this.containerTransform.position.y + this.\u02BB\u02BC\u02BA\u02C1\u02BE\u02B7\u02B6\u02B3\u02B8\u02BB\u02BB * Time.deltaTime);
			this.containerTransform.GetWorldCorners(this.\u02BB\u02BB\u02B7\u02B2\u02B5\u02BA\u02C1\u02B2\u02B4\u02BF\u02BE);
			if (this.\u02BB\u02BB\u02B7\u02B2\u02B5\u02BA\u02C1\u02B2\u02B4\u02BF\u02BE[0].y - (float)Screen.height > 358f)
			{
				this.\u02BC\u02B5\u02B5\u02B2\u02B8\u02BF\u02B3\u02BE\u02BB\u02B8\u02B3();
			}
		}
	}

	// Token: 0x0600056C RID: 1388 RVA: 0x00035504 File Offset: 0x00033704
	private void Update()
	{
		this.\u02BB\u02BC\u02BA\u02C1\u02BE\u02B7\u02B6\u02B3\u02B8\u02BB\u02BB = this.containerScrollSpeed;
		foreach (\u02C1\u02BB\u02BD\u02B7\u02BD\u02BB\u02BE\u02B5\u02B7\u02C0\u02B6 u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B in GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B8\u02BD\u02B2\u02B2\u02B7\u02B5\u02B5\u02B3\u02C0\u02BD\u02BF)
		{
			if (u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.\u02BC\u02BA\u02BE\u02B2\u02C0\u02BE\u02B6\u02B5\u02BC\u02B3\u02BD)
			{
				if (u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.rewiredPlayer.GetButtonDown(1))
				{
					this.\u02BC\u02B5\u02B5\u02B2\u02B8\u02BF\u02B3\u02BE\u02BB\u02B8\u02B3();
				}
				else if (u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.rewiredPlayer.GetButton(14) || u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.rewiredPlayer.GetButton(5))
				{
					this.\u02BB\u02BC\u02BA\u02C1\u02BE\u02B7\u02B6\u02B3\u02B8\u02BB\u02BB = this.containerFastScrollSpeed;
				}
			}
		}
		this.\u02C1\u02B6\u02B6\u02BB\u02B4\u02C1\u02B5\u02BF\u02B2\u02BE\u02B7 += Time.deltaTime;
		if (this.\u02C1\u02B6\u02B6\u02BB\u02B4\u02C1\u02B5\u02BF\u02B2\u02BE\u02B7 >= this.scrollDelay)
		{
			this.containerTransform.position = new Vector2(this.containerTransform.position.x, this.containerTransform.position.y + this.\u02BB\u02BC\u02BA\u02C1\u02BE\u02B7\u02B6\u02B3\u02B8\u02BB\u02BB * Time.deltaTime);
			this.containerTransform.GetWorldCorners(this.\u02BB\u02BB\u02B7\u02B2\u02B5\u02BA\u02C1\u02B2\u02B4\u02BF\u02BE);
			if (this.\u02BB\u02BB\u02B7\u02B2\u02B5\u02BA\u02C1\u02B2\u02B4\u02BF\u02BE[0].y - (float)Screen.height > 0f)
			{
				this.\u02BC\u02B5\u02B5\u02B2\u02B8\u02BF\u02B3\u02BE\u02BB\u02B8\u02B3();
			}
		}
	}

	// Token: 0x0600056D RID: 1389 RVA: 0x00035640 File Offset: 0x00033840
	private void \u02BD\u02B8\u02BD\u02B5\u02B6\u02B3\u02BF\u02B3\u02C1\u02B8\u02C1()
	{
		this.\u02BB\u02BC\u02BA\u02C1\u02BE\u02B7\u02B6\u02B3\u02B8\u02BB\u02BB = this.containerScrollSpeed;
		foreach (\u02C1\u02BB\u02BD\u02B7\u02BD\u02BB\u02BE\u02B5\u02B7\u02C0\u02B6 u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B in GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B8\u02BD\u02B2\u02B2\u02B7\u02B5\u02B5\u02B3\u02C0\u02BD\u02BF)
		{
			if (u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.\u02BC\u02BA\u02BE\u02B2\u02C0\u02BE\u02B6\u02B5\u02BC\u02B3\u02BD)
			{
				if (u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.rewiredPlayer.GetButtonDown(0))
				{
					this.\u02BC\u02B5\u02B5\u02B2\u02B8\u02BF\u02B3\u02BE\u02BB\u02B8\u02B3();
				}
				else if (u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.rewiredPlayer.GetButton(-66) || u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.rewiredPlayer.GetButton(7))
				{
					this.\u02BB\u02BC\u02BA\u02C1\u02BE\u02B7\u02B6\u02B3\u02B8\u02BB\u02BB = this.containerFastScrollSpeed;
				}
			}
		}
		this.\u02C1\u02B6\u02B6\u02BB\u02B4\u02C1\u02B5\u02BF\u02B2\u02BE\u02B7 += Time.deltaTime;
		if (this.\u02C1\u02B6\u02B6\u02BB\u02B4\u02C1\u02B5\u02BF\u02B2\u02BE\u02B7 >= this.scrollDelay)
		{
			this.containerTransform.position = new Vector2(this.containerTransform.position.x, this.containerTransform.position.y + this.\u02BB\u02BC\u02BA\u02C1\u02BE\u02B7\u02B6\u02B3\u02B8\u02BB\u02BB * Time.deltaTime);
			this.containerTransform.GetWorldCorners(this.\u02BB\u02BB\u02B7\u02B2\u02B5\u02BA\u02C1\u02B2\u02B4\u02BF\u02BE);
			if (this.\u02BB\u02BB\u02B7\u02B2\u02B5\u02BA\u02C1\u02B2\u02B4\u02BF\u02BE[0].y - (float)Screen.height > 1210f)
			{
				this.\u02BC\u02B5\u02B5\u02B2\u02B8\u02BF\u02B3\u02BE\u02BB\u02B8\u02B3();
			}
		}
	}

	// Token: 0x0600056F RID: 1391 RVA: 0x0003577C File Offset: 0x0003397C
	private void \u02B2\u02B6\u02C1\u02B8\u02B3\u02B5\u02B7\u02B5\u02B6\u02B9\u02C0()
	{
		this.\u02BB\u02BC\u02BA\u02C1\u02BE\u02B7\u02B6\u02B3\u02B8\u02BB\u02BB = this.containerScrollSpeed;
		foreach (\u02C1\u02BB\u02BD\u02B7\u02BD\u02BB\u02BE\u02B5\u02B7\u02C0\u02B6 u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B in GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B8\u02BD\u02B2\u02B2\u02B7\u02B5\u02B5\u02B3\u02C0\u02BD\u02BF)
		{
			if (u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.\u02BC\u02BA\u02BE\u02B2\u02C0\u02BE\u02B6\u02B5\u02BC\u02B3\u02BD)
			{
				if (u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.rewiredPlayer.GetButtonDown(0))
				{
					this.\u02BC\u02B5\u02B5\u02B2\u02B8\u02BF\u02B3\u02BE\u02BB\u02B8\u02B3();
				}
				else if (u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.rewiredPlayer.GetButton(-97) || u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.rewiredPlayer.GetButton(2))
				{
					this.\u02BB\u02BC\u02BA\u02C1\u02BE\u02B7\u02B6\u02B3\u02B8\u02BB\u02BB = this.containerFastScrollSpeed;
				}
			}
		}
		this.\u02C1\u02B6\u02B6\u02BB\u02B4\u02C1\u02B5\u02BF\u02B2\u02BE\u02B7 += Time.deltaTime;
		if (this.\u02C1\u02B6\u02B6\u02BB\u02B4\u02C1\u02B5\u02BF\u02B2\u02BE\u02B7 >= this.scrollDelay)
		{
			this.containerTransform.position = new Vector2(this.containerTransform.position.x, this.containerTransform.position.y + this.\u02BB\u02BC\u02BA\u02C1\u02BE\u02B7\u02B6\u02B3\u02B8\u02BB\u02BB * Time.deltaTime);
			this.containerTransform.GetWorldCorners(this.\u02BB\u02BB\u02B7\u02B2\u02B5\u02BA\u02C1\u02B2\u02B4\u02BF\u02BE);
			if (this.\u02BB\u02BB\u02B7\u02B2\u02B5\u02BA\u02C1\u02B2\u02B4\u02BF\u02BE[1].y - (float)Screen.height > 1140f)
			{
				this.\u02BC\u02B5\u02B5\u02B2\u02B8\u02BF\u02B3\u02BE\u02BB\u02B8\u02B3();
			}
		}
	}

	// Token: 0x06000570 RID: 1392 RVA: 0x00008AD1 File Offset: 0x00006CD1
	private void \u02BC\u02B5\u02B5\u02B2\u02B8\u02BF\u02B3\u02BE\u02BB\u02B8\u02B3()
	{
		GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B9\u02B4\u02BC\u02B8\u02B7\u02C0\u02BB\u02B9\u02B9\u02B5\u02C0 = false;
		SceneManager.LoadScene("Main Menu");
	}

	// Token: 0x06000571 RID: 1393 RVA: 0x000358B8 File Offset: 0x00033AB8
	private void \u02B5\u02B9\u02B7\u02B7\u02B6\u02B5\u02BC\u02BA\u02B4\u02B2\u02B4()
	{
		this.\u02BB\u02BC\u02BA\u02C1\u02BE\u02B7\u02B6\u02B3\u02B8\u02BB\u02BB = this.containerScrollSpeed;
		foreach (\u02C1\u02BB\u02BD\u02B7\u02BD\u02BB\u02BE\u02B5\u02B7\u02C0\u02B6 u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B in GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B8\u02BD\u02B2\u02B2\u02B7\u02B5\u02B5\u02B3\u02C0\u02BD\u02BF)
		{
			if (u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.\u02BC\u02BA\u02BE\u02B2\u02C0\u02BE\u02B6\u02B5\u02BC\u02B3\u02BD)
			{
				if (u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.rewiredPlayer.GetButtonDown(0))
				{
					this.\u02BC\u02B5\u02B5\u02B2\u02B8\u02BF\u02B3\u02BE\u02BB\u02B8\u02B3();
				}
				else if (u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.rewiredPlayer.GetButton(93) || u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.rewiredPlayer.GetButton(2))
				{
					this.\u02BB\u02BC\u02BA\u02C1\u02BE\u02B7\u02B6\u02B3\u02B8\u02BB\u02BB = this.containerFastScrollSpeed;
				}
			}
		}
		this.\u02C1\u02B6\u02B6\u02BB\u02B4\u02C1\u02B5\u02BF\u02B2\u02BE\u02B7 += Time.deltaTime;
		if (this.\u02C1\u02B6\u02B6\u02BB\u02B4\u02C1\u02B5\u02BF\u02B2\u02BE\u02B7 >= this.scrollDelay)
		{
			this.containerTransform.position = new Vector2(this.containerTransform.position.x, this.containerTransform.position.y + this.\u02BB\u02BC\u02BA\u02C1\u02BE\u02B7\u02B6\u02B3\u02B8\u02BB\u02BB * Time.deltaTime);
			this.containerTransform.GetWorldCorners(this.\u02BB\u02BB\u02B7\u02B2\u02B5\u02BA\u02C1\u02B2\u02B4\u02BF\u02BE);
			if (this.\u02BB\u02BB\u02B7\u02B2\u02B5\u02BA\u02C1\u02B2\u02B4\u02BF\u02BE[0].y - (float)Screen.height > 1755f)
			{
				this.\u02BC\u02B5\u02B5\u02B2\u02B8\u02BF\u02B3\u02BE\u02BB\u02B8\u02B3();
			}
		}
	}

	// Token: 0x06000572 RID: 1394 RVA: 0x000359F4 File Offset: 0x00033BF4
	private void \u02C0\u02B5\u02BC\u02B3\u02B3\u02B7\u02B9\u02B2\u02C0\u02BC\u02BB()
	{
		this.\u02BB\u02BC\u02BA\u02C1\u02BE\u02B7\u02B6\u02B3\u02B8\u02BB\u02BB = this.containerScrollSpeed;
		foreach (\u02C1\u02BB\u02BD\u02B7\u02BD\u02BB\u02BE\u02B5\u02B7\u02C0\u02B6 u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B in GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B8\u02BD\u02B2\u02B2\u02B7\u02B5\u02B5\u02B3\u02C0\u02BD\u02BF)
		{
			if (u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.\u02BC\u02BA\u02BE\u02B2\u02C0\u02BE\u02B6\u02B5\u02BC\u02B3\u02BD)
			{
				if (u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.rewiredPlayer.GetButtonDown(0))
				{
					this.\u02BC\u02B5\u02B5\u02B2\u02B8\u02BF\u02B3\u02BE\u02BB\u02B8\u02B3();
				}
				else if (u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.rewiredPlayer.GetButton(95) || u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.rewiredPlayer.GetButton(4))
				{
					this.\u02BB\u02BC\u02BA\u02C1\u02BE\u02B7\u02B6\u02B3\u02B8\u02BB\u02BB = this.containerFastScrollSpeed;
				}
			}
		}
		this.\u02C1\u02B6\u02B6\u02BB\u02B4\u02C1\u02B5\u02BF\u02B2\u02BE\u02B7 += Time.deltaTime;
		if (this.\u02C1\u02B6\u02B6\u02BB\u02B4\u02C1\u02B5\u02BF\u02B2\u02BE\u02B7 >= this.scrollDelay)
		{
			this.containerTransform.position = new Vector2(this.containerTransform.position.x, this.containerTransform.position.y + this.\u02BB\u02BC\u02BA\u02C1\u02BE\u02B7\u02B6\u02B3\u02B8\u02BB\u02BB * Time.deltaTime);
			this.containerTransform.GetWorldCorners(this.\u02BB\u02BB\u02B7\u02B2\u02B5\u02BA\u02C1\u02B2\u02B4\u02BF\u02BE);
			if (this.\u02BB\u02BB\u02B7\u02B2\u02B5\u02BA\u02C1\u02B2\u02B4\u02BF\u02BE[1].y - (float)Screen.height > 798f)
			{
				this.\u02BC\u02B5\u02B5\u02B2\u02B8\u02BF\u02B3\u02BE\u02BB\u02B8\u02B3();
			}
		}
	}

	// Token: 0x06000573 RID: 1395 RVA: 0x00035B30 File Offset: 0x00033D30
	private void \u02BB\u02BF\u02BA\u02BC\u02B8\u02B7\u02B4\u02B5\u02B7\u02B9\u02C1()
	{
		this.\u02BB\u02BC\u02BA\u02C1\u02BE\u02B7\u02B6\u02B3\u02B8\u02BB\u02BB = this.containerScrollSpeed;
		foreach (\u02C1\u02BB\u02BD\u02B7\u02BD\u02BB\u02BE\u02B5\u02B7\u02C0\u02B6 u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B in GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B8\u02BD\u02B2\u02B2\u02B7\u02B5\u02B5\u02B3\u02C0\u02BD\u02BF)
		{
			if (u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.\u02BC\u02BA\u02BE\u02B2\u02C0\u02BE\u02B6\u02B5\u02BC\u02B3\u02BD)
			{
				if (u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.rewiredPlayer.GetButtonDown(0))
				{
					this.\u02BC\u02B5\u02B5\u02B2\u02B8\u02BF\u02B3\u02BE\u02BB\u02B8\u02B3();
				}
				else if (u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.rewiredPlayer.GetButton(95) || u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.rewiredPlayer.GetButton(7))
				{
					this.\u02BB\u02BC\u02BA\u02C1\u02BE\u02B7\u02B6\u02B3\u02B8\u02BB\u02BB = this.containerFastScrollSpeed;
				}
			}
		}
		this.\u02C1\u02B6\u02B6\u02BB\u02B4\u02C1\u02B5\u02BF\u02B2\u02BE\u02B7 += Time.deltaTime;
		if (this.\u02C1\u02B6\u02B6\u02BB\u02B4\u02C1\u02B5\u02BF\u02B2\u02BE\u02B7 >= this.scrollDelay)
		{
			this.containerTransform.position = new Vector2(this.containerTransform.position.x, this.containerTransform.position.y + this.\u02BB\u02BC\u02BA\u02C1\u02BE\u02B7\u02B6\u02B3\u02B8\u02BB\u02BB * Time.deltaTime);
			this.containerTransform.GetWorldCorners(this.\u02BB\u02BB\u02B7\u02B2\u02B5\u02BA\u02C1\u02B2\u02B4\u02BF\u02BE);
			if (this.\u02BB\u02BB\u02B7\u02B2\u02B5\u02BA\u02C1\u02B2\u02B4\u02BF\u02BE[0].y - (float)Screen.height > 1127f)
			{
				this.\u02BC\u02B5\u02B5\u02B2\u02B8\u02BF\u02B3\u02BE\u02BB\u02B8\u02B3();
			}
		}
	}

	// Token: 0x06000574 RID: 1396 RVA: 0x00035C6C File Offset: 0x00033E6C
	private void \u02BB\u02B7\u02C0\u02B3\u02C1\u02BD\u02B9\u02B2\u02B4\u02BE\u02B6()
	{
		this.\u02BB\u02BC\u02BA\u02C1\u02BE\u02B7\u02B6\u02B3\u02B8\u02BB\u02BB = this.containerScrollSpeed;
		foreach (\u02C1\u02BB\u02BD\u02B7\u02BD\u02BB\u02BE\u02B5\u02B7\u02C0\u02B6 u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B in GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B8\u02BD\u02B2\u02B2\u02B7\u02B5\u02B5\u02B3\u02C0\u02BD\u02BF)
		{
			if (u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.\u02BC\u02BA\u02BE\u02B2\u02C0\u02BE\u02B6\u02B5\u02BC\u02B3\u02BD)
			{
				if (u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.rewiredPlayer.GetButtonDown(1))
				{
					this.\u02BC\u02B5\u02B5\u02B2\u02B8\u02BF\u02B3\u02BE\u02BB\u02B8\u02B3();
				}
				else if (u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.rewiredPlayer.GetButton(-117) || u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.rewiredPlayer.GetButton(3))
				{
					this.\u02BB\u02BC\u02BA\u02C1\u02BE\u02B7\u02B6\u02B3\u02B8\u02BB\u02BB = this.containerFastScrollSpeed;
				}
			}
		}
		this.\u02C1\u02B6\u02B6\u02BB\u02B4\u02C1\u02B5\u02BF\u02B2\u02BE\u02B7 += Time.deltaTime;
		if (this.\u02C1\u02B6\u02B6\u02BB\u02B4\u02C1\u02B5\u02BF\u02B2\u02BE\u02B7 >= this.scrollDelay)
		{
			this.containerTransform.position = new Vector2(this.containerTransform.position.x, this.containerTransform.position.y + this.\u02BB\u02BC\u02BA\u02C1\u02BE\u02B7\u02B6\u02B3\u02B8\u02BB\u02BB * Time.deltaTime);
			this.containerTransform.GetWorldCorners(this.\u02BB\u02BB\u02B7\u02B2\u02B5\u02BA\u02C1\u02B2\u02B4\u02BF\u02BE);
			if (this.\u02BB\u02BB\u02B7\u02B2\u02B5\u02BA\u02C1\u02B2\u02B4\u02BF\u02BE[1].y - (float)Screen.height > 369f)
			{
				this.\u02BC\u02B5\u02B5\u02B2\u02B8\u02BF\u02B3\u02BE\u02BB\u02B8\u02B3();
			}
		}
	}

	// Token: 0x06000575 RID: 1397 RVA: 0x00035DA8 File Offset: 0x00033FA8
	private void \u02BD\u02B7\u02BD\u02BF\u02BE\u02B9\u02B6\u02C0\u02B4\u02B7\u02BF()
	{
		this.\u02BB\u02BC\u02BA\u02C1\u02BE\u02B7\u02B6\u02B3\u02B8\u02BB\u02BB = this.containerScrollSpeed;
		foreach (\u02C1\u02BB\u02BD\u02B7\u02BD\u02BB\u02BE\u02B5\u02B7\u02C0\u02B6 u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B in GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B8\u02BD\u02B2\u02B2\u02B7\u02B5\u02B5\u02B3\u02C0\u02BD\u02BF)
		{
			if (u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.\u02BC\u02BA\u02BE\u02B2\u02C0\u02BE\u02B6\u02B5\u02BC\u02B3\u02BD)
			{
				if (u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.rewiredPlayer.GetButtonDown(1))
				{
					this.\u02BC\u02B5\u02B5\u02B2\u02B8\u02BF\u02B3\u02BE\u02BB\u02B8\u02B3();
				}
				else if (u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.rewiredPlayer.GetButton(-109) || u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.rewiredPlayer.GetButton(1))
				{
					this.\u02BB\u02BC\u02BA\u02C1\u02BE\u02B7\u02B6\u02B3\u02B8\u02BB\u02BB = this.containerFastScrollSpeed;
				}
			}
		}
		this.\u02C1\u02B6\u02B6\u02BB\u02B4\u02C1\u02B5\u02BF\u02B2\u02BE\u02B7 += Time.deltaTime;
		if (this.\u02C1\u02B6\u02B6\u02BB\u02B4\u02C1\u02B5\u02BF\u02B2\u02BE\u02B7 >= this.scrollDelay)
		{
			this.containerTransform.position = new Vector2(this.containerTransform.position.x, this.containerTransform.position.y + this.\u02BB\u02BC\u02BA\u02C1\u02BE\u02B7\u02B6\u02B3\u02B8\u02BB\u02BB * Time.deltaTime);
			this.containerTransform.GetWorldCorners(this.\u02BB\u02BB\u02B7\u02B2\u02B5\u02BA\u02C1\u02B2\u02B4\u02BF\u02BE);
			if (this.\u02BB\u02BB\u02B7\u02B2\u02B5\u02BA\u02C1\u02B2\u02B4\u02BF\u02BE[1].y - (float)Screen.height > 1535f)
			{
				this.\u02BC\u02B5\u02B5\u02B2\u02B8\u02BF\u02B3\u02BE\u02BB\u02B8\u02B3();
			}
		}
	}

	// Token: 0x04000408 RID: 1032
	[SerializeField]
	private RectTransform containerTransform;

	// Token: 0x04000409 RID: 1033
	[SerializeField]
	private float containerScrollSpeed = 5f;

	// Token: 0x0400040A RID: 1034
	[SerializeField]
	private float containerFastScrollSpeed = 50f;

	// Token: 0x0400040B RID: 1035
	private float \u02BB\u02BC\u02BA\u02C1\u02BE\u02B7\u02B6\u02B3\u02B8\u02BB\u02BB;

	// Token: 0x0400040C RID: 1036
	[SerializeField]
	private float scrollDelay = 5f;

	// Token: 0x0400040D RID: 1037
	private float \u02C1\u02B6\u02B6\u02BB\u02B4\u02C1\u02B5\u02BF\u02B2\u02BE\u02B7;

	// Token: 0x0400040E RID: 1038
	private Vector3[] \u02BB\u02BB\u02B7\u02B2\u02B5\u02BA\u02C1\u02B2\u02B4\u02BF\u02BE = new Vector3[4];
}
