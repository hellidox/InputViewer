using System;
using UnityEngine;
using UnityEngine.SceneManagement;

// Token: 0x0200017D RID: 381
public class Paddle : MonoBehaviour
{
	// Token: 0x06001199 RID: 4505 RVA: 0x0000F4E8 File Offset: 0x0000D6E8
	public void \u02BD\u02B3\u02BC\u02B4\u02B9\u02B4\u02B2\u02BD\u02C1\u02B9\u02BD()
	{
		this.\u02C0\u02B6\u02B6\u02BC\u02BC\u02B5\u02BD\u02B7\u02B5\u02BC\u02B2.localPosition = this.\u02BA\u02C1\u02BF\u02B6\u02C1\u02B8\u02BC\u02BC\u02BC\u02B5\u02C1;
	}

	// Token: 0x0600119A RID: 4506 RVA: 0x0000F4E8 File Offset: 0x0000D6E8
	public void Reset()
	{
		this.\u02C0\u02B6\u02B6\u02BC\u02BC\u02B5\u02BD\u02B7\u02B5\u02BC\u02B2.localPosition = this.\u02BA\u02C1\u02BF\u02B6\u02C1\u02B8\u02BC\u02BC\u02BC\u02B5\u02C1;
	}

	// Token: 0x0600119B RID: 4507 RVA: 0x0000F4E8 File Offset: 0x0000D6E8
	public void \u02B5\u02BB\u02B9\u02B7\u02B9\u02BA\u02BD\u02BF\u02B6\u02B4\u02BE()
	{
		this.\u02C0\u02B6\u02B6\u02BC\u02BC\u02B5\u02BD\u02B7\u02B5\u02BC\u02B2.localPosition = this.\u02BA\u02C1\u02BF\u02B6\u02C1\u02B8\u02BC\u02BC\u02BC\u02B5\u02C1;
	}

	// Token: 0x0600119C RID: 4508 RVA: 0x0009330C File Offset: 0x0009150C
	private void Start()
	{
		this.\u02C0\u02B6\u02B6\u02BC\u02BC\u02B5\u02BD\u02B7\u02B5\u02BC\u02B2 = base.transform;
		this.\u02BA\u02C1\u02BF\u02B6\u02C1\u02B8\u02BC\u02BC\u02BC\u02B5\u02C1 = this.\u02C0\u02B6\u02B6\u02BC\u02BC\u02B5\u02BD\u02B7\u02B5\u02BC\u02B2.localPosition;
		\u02C1\u02BB\u02BD\u02B7\u02BD\u02BB\u02BE\u02B5\u02B7\u02C0\u02B6 u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B = null;
		\u02C1\u02BB\u02BD\u02B7\u02BD\u02BB\u02BE\u02B5\u02B7\u02C0\u02B6 u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B2 = null;
		if (GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7)
		{
			for (int i = 0; i < 4; i++)
			{
				\u02C1\u02BB\u02BD\u02B7\u02BD\u02BB\u02BE\u02B5\u02B7\u02C0\u02B6 u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B3 = GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B8\u02BD\u02B2\u02B2\u02B7\u02B5\u02B5\u02B3\u02C0\u02BD\u02BF[i];
				if (u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B3 != null && u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B3.\u02BC\u02BA\u02BE\u02B2\u02C0\u02BE\u02B6\u02B5\u02BC\u02B3\u02BD)
				{
					if (u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B == null)
					{
						u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B = u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B3;
					}
					else if (u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B2 == null)
					{
						u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B2 = u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B3;
					}
				}
			}
		}
		if (this.\u02B4\u02B3\u02B7\u02B7\u02C1\u02B4\u02B8\u02B4\u02B2\u02B7\u02B5)
		{
			this.\u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7 = u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B;
			return;
		}
		this.\u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7 = u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B2;
		this.\u02BA\u02BB\u02B2\u02C0\u02B4\u02B7\u02BC\u02BD\u02BB\u02BF\u02BC = u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B2 == null;
	}

	// Token: 0x0600119D RID: 4509 RVA: 0x000933A0 File Offset: 0x000915A0
	private void \u02B6\u02B6\u02B4\u02BB\u02B7\u02C1\u02C0\u02B6\u02B7\u02BD\u02B5()
	{
		this.\u02C0\u02B6\u02B6\u02BC\u02BC\u02B5\u02BD\u02B7\u02B5\u02BC\u02B2 = base.transform;
		this.\u02BA\u02C1\u02BF\u02B6\u02C1\u02B8\u02BC\u02BC\u02BC\u02B5\u02C1 = this.\u02C0\u02B6\u02B6\u02BC\u02BC\u02B5\u02BD\u02B7\u02B5\u02BC\u02B2.localPosition;
		\u02C1\u02BB\u02BD\u02B7\u02BD\u02BB\u02BE\u02B5\u02B7\u02C0\u02B6 u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B = null;
		\u02C1\u02BB\u02BD\u02B7\u02BD\u02BB\u02BE\u02B5\u02B7\u02C0\u02B6 u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B2 = null;
		if (GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7)
		{
			for (int i = 0; i < 5; i++)
			{
				\u02C1\u02BB\u02BD\u02B7\u02BD\u02BB\u02BE\u02B5\u02B7\u02C0\u02B6 u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B3 = GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B8\u02BD\u02B2\u02B2\u02B7\u02B5\u02B5\u02B3\u02C0\u02BD\u02BF[i];
				if (u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B3 != null && u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B3.\u02BC\u02BA\u02BE\u02B2\u02C0\u02BE\u02B6\u02B5\u02BC\u02B3\u02BD)
				{
					if (u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B == null)
					{
						u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B = u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B3;
					}
					else if (u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B2 == null)
					{
						u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B2 = u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B3;
					}
				}
			}
		}
		if (this.\u02B4\u02B3\u02B7\u02B7\u02C1\u02B4\u02B8\u02B4\u02B2\u02B7\u02B5)
		{
			this.\u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7 = u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B;
			return;
		}
		this.\u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7 = u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B2;
		this.\u02BA\u02BB\u02B2\u02C0\u02B4\u02B7\u02BC\u02BD\u02BB\u02BF\u02BC = u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B2 == null;
	}

	// Token: 0x0600119E RID: 4510 RVA: 0x0000F4E8 File Offset: 0x0000D6E8
	public void \u02B5\u02C0\u02BD\u02B3\u02BA\u02C0\u02BB\u02BA\u02BE\u02B9\u02BE()
	{
		this.\u02C0\u02B6\u02B6\u02BC\u02BC\u02B5\u02BD\u02B7\u02B5\u02BC\u02B2.localPosition = this.\u02BA\u02C1\u02BF\u02B6\u02C1\u02B8\u02BC\u02BC\u02BC\u02B5\u02C1;
	}

	// Token: 0x0600119F RID: 4511 RVA: 0x0000F4E8 File Offset: 0x0000D6E8
	public void \u02B6\u02BE\u02B4\u02BD\u02B5\u02B9\u02BF\u02B5\u02BE\u02BA\u02BA()
	{
		this.\u02C0\u02B6\u02B6\u02BC\u02BC\u02B5\u02BD\u02B7\u02B5\u02BC\u02B2.localPosition = this.\u02BA\u02C1\u02BF\u02B6\u02C1\u02B8\u02BC\u02BC\u02BC\u02B5\u02C1;
	}

	// Token: 0x060011A0 RID: 4512 RVA: 0x00093434 File Offset: 0x00091634
	private void Update()
	{
		Vector2 vector = this.\u02C0\u02B6\u02B6\u02BC\u02BC\u02B5\u02BD\u02B7\u02B5\u02BC\u02B2.localPosition;
		if (this.\u02BA\u02BB\u02B2\u02C0\u02B4\u02B7\u02BC\u02BD\u02BB\u02BF\u02BC)
		{
			if (!this.\u02BD\u02B6\u02B6\u02BD\u02BF\u02B3\u02BE\u02BC\u02B9\u02BD\u02B5)
			{
				GameObject gameObject = GameObject.Find("Ball(Clone)");
				if (gameObject)
				{
					this.\u02BD\u02B6\u02B6\u02BD\u02BF\u02B3\u02BE\u02BC\u02B9\u02BD\u02B5 = gameObject.transform;
				}
			}
			else if (this.\u02BD\u02B6\u02B6\u02BD\u02BF\u02B3\u02BE\u02BC\u02B9\u02BD\u02B5.localPosition.y > vector.y)
			{
				vector.y = Mathf.Clamp(vector.y + this.\u02C0\u02B7\u02BE\u02BB\u02B2\u02BC\u02B8\u02B9\u02B6\u02BC\u02BB * Time.deltaTime * global::UnityEngine.Random.Range(0.7f, 1f), this.\u02BF\u02C0\u02B4\u02C1\u02B8\u02BB\u02B6\u02B2\u02B3\u02B7\u02BC, this.\u02BA\u02C1\u02BC\u02B5\u02C0\u02B4\u02BC\u02BF\u02B5\u02BE\u02BA);
			}
			else if (this.\u02BD\u02B6\u02B6\u02BD\u02BF\u02B3\u02BE\u02BC\u02B9\u02BD\u02B5.localPosition.y < vector.y)
			{
				vector.y = Mathf.Clamp(vector.y - this.\u02C0\u02B7\u02BE\u02BB\u02B2\u02BC\u02B8\u02B9\u02B6\u02BC\u02BB * Time.deltaTime * global::UnityEngine.Random.Range(0.7f, 1f), this.\u02BF\u02C0\u02B4\u02C1\u02B8\u02BB\u02B6\u02B2\u02B3\u02B7\u02BC, this.\u02BA\u02C1\u02BC\u02B5\u02C0\u02B4\u02BC\u02BF\u02B5\u02BE\u02BA);
			}
		}
		else if (this.\u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7 != null)
		{
			if (this.\u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7.rewiredPlayer.GetButtonDown(1))
			{
				SceneManager.LoadScene("Main Menu");
				return;
			}
			if (this.\u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7.rewiredPlayer.GetButtonDown(2))
			{
				this.\u02C0\u02B3\u02C0\u02B6\u02B4\u02B9\u02C1\u02B7\u02B3\u02B9\u02B8.clearFlags = ((this.\u02C0\u02B3\u02C0\u02B6\u02B4\u02B9\u02C1\u02B7\u02B3\u02B9\u02B8.clearFlags == CameraClearFlags.Color) ? CameraClearFlags.Nothing : CameraClearFlags.Color);
				return;
			}
			if (this.\u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7.rewiredPlayer.GetButton(5))
			{
				vector.y = Mathf.Clamp(vector.y + this.\u02B3\u02B3\u02C0\u02BA\u02B5\u02B9\u02B2\u02B9\u02B7\u02BE\u02BB * Time.deltaTime * global::UnityEngine.Random.Range(0.7f, 1f), this.\u02BF\u02C0\u02B4\u02C1\u02B8\u02BB\u02B6\u02B2\u02B3\u02B7\u02BC, this.\u02BA\u02C1\u02BC\u02B5\u02C0\u02B4\u02BC\u02BF\u02B5\u02BE\u02BA);
			}
			else if (this.\u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7.rewiredPlayer.GetButton(14))
			{
				vector.y = Mathf.Clamp(vector.y - this.\u02B3\u02B3\u02C0\u02BA\u02B5\u02B9\u02B2\u02B9\u02B7\u02BE\u02BB * Time.deltaTime * global::UnityEngine.Random.Range(0.7f, 1f), this.\u02BF\u02C0\u02B4\u02C1\u02B8\u02BB\u02B6\u02B2\u02B3\u02B7\u02BC, this.\u02BA\u02C1\u02BC\u02B5\u02C0\u02B4\u02BC\u02BF\u02B5\u02BE\u02BA);
			}
		}
		else
		{
			if (Input.GetKey(KeyCode.UpArrow))
			{
				vector.y = Mathf.Clamp(vector.y + this.\u02B3\u02B3\u02C0\u02BA\u02B5\u02B9\u02B2\u02B9\u02B7\u02BE\u02BB * Time.deltaTime * global::UnityEngine.Random.Range(0.7f, 1f), this.\u02BF\u02C0\u02B4\u02C1\u02B8\u02BB\u02B6\u02B2\u02B3\u02B7\u02BC, this.\u02BA\u02C1\u02BC\u02B5\u02C0\u02B4\u02BC\u02BF\u02B5\u02BE\u02BA);
			}
			else if (Input.GetKey(KeyCode.DownArrow))
			{
				vector.y = Mathf.Clamp(vector.y - this.\u02B3\u02B3\u02C0\u02BA\u02B5\u02B9\u02B2\u02B9\u02B7\u02BE\u02BB * Time.deltaTime * global::UnityEngine.Random.Range(0.7f, 1f), this.\u02BF\u02C0\u02B4\u02C1\u02B8\u02BB\u02B6\u02B2\u02B3\u02B7\u02BC, this.\u02BA\u02C1\u02BC\u02B5\u02C0\u02B4\u02BC\u02BF\u02B5\u02BE\u02BA);
			}
			if (Input.GetKeyDown(KeyCode.Space))
			{
				this.\u02C0\u02B3\u02C0\u02B6\u02B4\u02B9\u02C1\u02B7\u02B3\u02B9\u02B8.clearFlags = ((this.\u02C0\u02B3\u02C0\u02B6\u02B4\u02B9\u02C1\u02B7\u02B3\u02B9\u02B8.clearFlags == CameraClearFlags.Color) ? CameraClearFlags.Nothing : CameraClearFlags.Color);
				return;
			}
		}
		this.\u02C0\u02B6\u02B6\u02BC\u02BC\u02B5\u02BD\u02B7\u02B5\u02BC\u02B2.localPosition = vector;
	}

	// Token: 0x060011A1 RID: 4513 RVA: 0x000933A0 File Offset: 0x000915A0
	private void \u02B5\u02C0\u02BE\u02B8\u02B9\u02B2\u02BD\u02C0\u02BF\u02B3\u02BD()
	{
		this.\u02C0\u02B6\u02B6\u02BC\u02BC\u02B5\u02BD\u02B7\u02B5\u02BC\u02B2 = base.transform;
		this.\u02BA\u02C1\u02BF\u02B6\u02C1\u02B8\u02BC\u02BC\u02BC\u02B5\u02C1 = this.\u02C0\u02B6\u02B6\u02BC\u02BC\u02B5\u02BD\u02B7\u02B5\u02BC\u02B2.localPosition;
		\u02C1\u02BB\u02BD\u02B7\u02BD\u02BB\u02BE\u02B5\u02B7\u02C0\u02B6 u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B = null;
		\u02C1\u02BB\u02BD\u02B7\u02BD\u02BB\u02BE\u02B5\u02B7\u02C0\u02B6 u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B2 = null;
		if (GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7)
		{
			for (int i = 0; i < 5; i++)
			{
				\u02C1\u02BB\u02BD\u02B7\u02BD\u02BB\u02BE\u02B5\u02B7\u02C0\u02B6 u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B3 = GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B8\u02BD\u02B2\u02B2\u02B7\u02B5\u02B5\u02B3\u02C0\u02BD\u02BF[i];
				if (u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B3 != null && u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B3.\u02BC\u02BA\u02BE\u02B2\u02C0\u02BE\u02B6\u02B5\u02BC\u02B3\u02BD)
				{
					if (u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B == null)
					{
						u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B = u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B3;
					}
					else if (u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B2 == null)
					{
						u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B2 = u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B3;
					}
				}
			}
		}
		if (this.\u02B4\u02B3\u02B7\u02B7\u02C1\u02B4\u02B8\u02B4\u02B2\u02B7\u02B5)
		{
			this.\u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7 = u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B;
			return;
		}
		this.\u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7 = u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B2;
		this.\u02BA\u02BB\u02B2\u02C0\u02B4\u02B7\u02BC\u02BD\u02BB\u02BF\u02BC = u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B2 == null;
	}

	// Token: 0x060011A2 RID: 4514 RVA: 0x00093710 File Offset: 0x00091910
	private void \u02BE\u02B8\u02B4\u02BC\u02B7\u02B7\u02BE\u02BC\u02B5\u02BC\u02BF()
	{
		this.\u02C0\u02B6\u02B6\u02BC\u02BC\u02B5\u02BD\u02B7\u02B5\u02BC\u02B2 = base.transform;
		this.\u02BA\u02C1\u02BF\u02B6\u02C1\u02B8\u02BC\u02BC\u02BC\u02B5\u02C1 = this.\u02C0\u02B6\u02B6\u02BC\u02BC\u02B5\u02BD\u02B7\u02B5\u02BC\u02B2.localPosition;
		\u02C1\u02BB\u02BD\u02B7\u02BD\u02BB\u02BE\u02B5\u02B7\u02C0\u02B6 u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B = null;
		\u02C1\u02BB\u02BD\u02B7\u02BD\u02BB\u02BE\u02B5\u02B7\u02C0\u02B6 u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B2 = null;
		if (GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7)
		{
			for (int i = 1; i < 2; i += 0)
			{
				\u02C1\u02BB\u02BD\u02B7\u02BD\u02BB\u02BE\u02B5\u02B7\u02C0\u02B6 u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B3 = GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B8\u02BD\u02B2\u02B2\u02B7\u02B5\u02B5\u02B3\u02C0\u02BD\u02BF[i];
				if (u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B3 != null && u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B3.\u02BC\u02BA\u02BE\u02B2\u02C0\u02BE\u02B6\u02B5\u02BC\u02B3\u02BD)
				{
					if (u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B == null)
					{
						u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B = u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B3;
					}
					else if (u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B2 == null)
					{
						u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B2 = u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B3;
					}
				}
			}
		}
		if (this.\u02B4\u02B3\u02B7\u02B7\u02C1\u02B4\u02B8\u02B4\u02B2\u02B7\u02B5)
		{
			this.\u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7 = u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B;
			return;
		}
		this.\u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7 = u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B2;
		this.\u02BA\u02BB\u02B2\u02C0\u02B4\u02B7\u02BC\u02BD\u02BB\u02BF\u02BC = u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B2 == null;
	}

	// Token: 0x060011A3 RID: 4515 RVA: 0x0000F4E8 File Offset: 0x0000D6E8
	public void \u02C0\u02B4\u02BA\u02B9\u02B2\u02BD\u02B9\u02BD\u02B4\u02B8\u02BA()
	{
		this.\u02C0\u02B6\u02B6\u02BC\u02BC\u02B5\u02BD\u02B7\u02B5\u02BC\u02B2.localPosition = this.\u02BA\u02C1\u02BF\u02B6\u02C1\u02B8\u02BC\u02BC\u02BC\u02B5\u02C1;
	}

	// Token: 0x060011A4 RID: 4516 RVA: 0x000937A4 File Offset: 0x000919A4
	private void \u02C1\u02B8\u02B5\u02BD\u02BD\u02C0\u02BB\u02B4\u02BD\u02B8\u02B3()
	{
		Vector2 vector = this.\u02C0\u02B6\u02B6\u02BC\u02BC\u02B5\u02BD\u02B7\u02B5\u02BC\u02B2.localPosition;
		if (this.\u02BA\u02BB\u02B2\u02C0\u02B4\u02B7\u02BC\u02BD\u02BB\u02BF\u02BC)
		{
			if (!this.\u02BD\u02B6\u02B6\u02BD\u02BF\u02B3\u02BE\u02BC\u02B9\u02BD\u02B5)
			{
				GameObject gameObject = GameObject.Find("SDK_INT");
				if (gameObject)
				{
					this.\u02BD\u02B6\u02B6\u02BD\u02BF\u02B3\u02BE\u02BC\u02B9\u02BD\u02B5 = gameObject.transform;
				}
			}
			else if (this.\u02BD\u02B6\u02B6\u02BD\u02BF\u02B3\u02BE\u02BC\u02B9\u02BD\u02B5.localPosition.y > vector.y)
			{
				vector.y = Mathf.Clamp(vector.y + this.\u02C0\u02B7\u02BE\u02BB\u02B2\u02BC\u02B8\u02B9\u02B6\u02BC\u02BB * Time.deltaTime * global::UnityEngine.Random.Range(943f, 480f), this.\u02BF\u02C0\u02B4\u02C1\u02B8\u02BB\u02B6\u02B2\u02B3\u02B7\u02BC, this.\u02BA\u02C1\u02BC\u02B5\u02C0\u02B4\u02BC\u02BF\u02B5\u02BE\u02BA);
			}
			else if (this.\u02BD\u02B6\u02B6\u02BD\u02BF\u02B3\u02BE\u02BC\u02B9\u02BD\u02B5.localPosition.y < vector.y)
			{
				vector.y = Mathf.Clamp(vector.y - this.\u02C0\u02B7\u02BE\u02BB\u02B2\u02BC\u02B8\u02B9\u02B6\u02BC\u02BB * Time.deltaTime * global::UnityEngine.Random.Range(603f, 1014f), this.\u02BF\u02C0\u02B4\u02C1\u02B8\u02BB\u02B6\u02B2\u02B3\u02B7\u02BC, this.\u02BA\u02C1\u02BC\u02B5\u02C0\u02B4\u02BC\u02BF\u02B5\u02BE\u02BA);
			}
		}
		else if (this.\u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7 != null)
		{
			if (this.\u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7.rewiredPlayer.GetButtonDown(0))
			{
				SceneManager.LoadScene("year");
				return;
			}
			if (this.\u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7.rewiredPlayer.GetButtonDown(1))
			{
				this.\u02C0\u02B3\u02C0\u02B6\u02B4\u02B9\u02C1\u02B7\u02B3\u02B9\u02B8.clearFlags = ((this.\u02C0\u02B3\u02C0\u02B6\u02B4\u02B9\u02C1\u02B7\u02B3\u02B9\u02B8.clearFlags == CameraClearFlags.Color) ? ((CameraClearFlags)0) : ((CameraClearFlags)0));
				return;
			}
			if (this.\u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7.rewiredPlayer.GetButton(0))
			{
				vector.y = Mathf.Clamp(vector.y + this.\u02B3\u02B3\u02C0\u02BA\u02B5\u02B9\u02B2\u02B9\u02B7\u02BE\u02BB * Time.deltaTime * global::UnityEngine.Random.Range(67f, 1354f), this.\u02BF\u02C0\u02B4\u02C1\u02B8\u02BB\u02B6\u02B2\u02B3\u02B7\u02BC, this.\u02BA\u02C1\u02BC\u02B5\u02C0\u02B4\u02BC\u02BF\u02B5\u02BE\u02BA);
			}
			else if (this.\u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7.rewiredPlayer.GetButton(-75))
			{
				vector.y = Mathf.Clamp(vector.y - this.\u02B3\u02B3\u02C0\u02BA\u02B5\u02B9\u02B2\u02B9\u02B7\u02BE\u02BB * Time.deltaTime * global::UnityEngine.Random.Range(1477f, 1118f), this.\u02BF\u02C0\u02B4\u02C1\u02B8\u02BB\u02B6\u02B2\u02B3\u02B7\u02BC, this.\u02BA\u02C1\u02BC\u02B5\u02C0\u02B4\u02BC\u02BF\u02B5\u02BE\u02BA);
			}
		}
		else
		{
			if (Input.GetKey((KeyCode)(-58)))
			{
				vector.y = Mathf.Clamp(vector.y + this.\u02B3\u02B3\u02C0\u02BA\u02B5\u02B9\u02B2\u02B9\u02B7\u02BE\u02BB * Time.deltaTime * global::UnityEngine.Random.Range(1565f, 679f), this.\u02BF\u02C0\u02B4\u02C1\u02B8\u02BB\u02B6\u02B2\u02B3\u02B7\u02BC, this.\u02BA\u02C1\u02BC\u02B5\u02C0\u02B4\u02BC\u02BF\u02B5\u02BE\u02BA);
			}
			else if (Input.GetKey((KeyCode)(-185)))
			{
				vector.y = Mathf.Clamp(vector.y - this.\u02B3\u02B3\u02C0\u02BA\u02B5\u02B9\u02B2\u02B9\u02B7\u02BE\u02BB * Time.deltaTime * global::UnityEngine.Random.Range(201f, 289f), this.\u02BF\u02C0\u02B4\u02C1\u02B8\u02BB\u02B6\u02B2\u02B3\u02B7\u02BC, this.\u02BA\u02C1\u02BC\u02B5\u02C0\u02B4\u02BC\u02BF\u02B5\u02BE\u02BA);
			}
			if (Input.GetKeyDown(KeyCode.Alpha9))
			{
				this.\u02C0\u02B3\u02C0\u02B6\u02B4\u02B9\u02C1\u02B7\u02B3\u02B9\u02B8.clearFlags = ((this.\u02C0\u02B3\u02C0\u02B6\u02B4\u02B9\u02C1\u02B7\u02B3\u02B9\u02B8.clearFlags == (CameraClearFlags)0) ? ((CameraClearFlags)6) : CameraClearFlags.Nothing);
				return;
			}
		}
		this.\u02C0\u02B6\u02B6\u02BC\u02BC\u02B5\u02BD\u02B7\u02B5\u02BC\u02B2.localPosition = vector;
	}

	// Token: 0x060011A5 RID: 4517 RVA: 0x0000F4E8 File Offset: 0x0000D6E8
	public void \u02B7\u02B6\u02B9\u02C1\u02BE\u02BE\u02B4\u02B3\u02B9\u02BC\u02C1()
	{
		this.\u02C0\u02B6\u02B6\u02BC\u02BC\u02B5\u02BD\u02B7\u02B5\u02BC\u02B2.localPosition = this.\u02BA\u02C1\u02BF\u02B6\u02C1\u02B8\u02BC\u02BC\u02BC\u02B5\u02C1;
	}

	// Token: 0x060011A6 RID: 4518 RVA: 0x0000F4E8 File Offset: 0x0000D6E8
	public void \u02BC\u02B7\u02B6\u02BB\u02BF\u02BF\u02C1\u02C0\u02C0\u02B8\u02B5()
	{
		this.\u02C0\u02B6\u02B6\u02BC\u02BC\u02B5\u02BD\u02B7\u02B5\u02BC\u02B2.localPosition = this.\u02BA\u02C1\u02BF\u02B6\u02C1\u02B8\u02BC\u02BC\u02BC\u02B5\u02C1;
	}

	// Token: 0x060011A8 RID: 4520 RVA: 0x00093A80 File Offset: 0x00091C80
	private void \u02B7\u02B8\u02BD\u02C0\u02B2\u02B4\u02B7\u02C0\u02BC\u02BE\u02B3()
	{
		this.\u02C0\u02B6\u02B6\u02BC\u02BC\u02B5\u02BD\u02B7\u02B5\u02BC\u02B2 = base.transform;
		this.\u02BA\u02C1\u02BF\u02B6\u02C1\u02B8\u02BC\u02BC\u02BC\u02B5\u02C1 = this.\u02C0\u02B6\u02B6\u02BC\u02BC\u02B5\u02BD\u02B7\u02B5\u02BC\u02B2.localPosition;
		\u02C1\u02BB\u02BD\u02B7\u02BD\u02BB\u02BE\u02B5\u02B7\u02C0\u02B6 u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B = null;
		\u02C1\u02BB\u02BD\u02B7\u02BD\u02BB\u02BE\u02B5\u02B7\u02C0\u02B6 u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B2 = null;
		if (GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7)
		{
			for (int i = 1; i < 8; i += 0)
			{
				\u02C1\u02BB\u02BD\u02B7\u02BD\u02BB\u02BE\u02B5\u02B7\u02C0\u02B6 u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B3 = GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B8\u02BD\u02B2\u02B2\u02B7\u02B5\u02B5\u02B3\u02C0\u02BD\u02BF[i];
				if (u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B3 != null && u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B3.\u02BC\u02BA\u02BE\u02B2\u02C0\u02BE\u02B6\u02B5\u02BC\u02B3\u02BD)
				{
					if (u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B == null)
					{
						u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B = u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B3;
					}
					else if (u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B2 == null)
					{
						u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B2 = u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B3;
					}
				}
			}
		}
		if (this.\u02B4\u02B3\u02B7\u02B7\u02C1\u02B4\u02B8\u02B4\u02B2\u02B7\u02B5)
		{
			this.\u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7 = u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B;
			return;
		}
		this.\u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7 = u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B2;
		this.\u02BA\u02BB\u02B2\u02C0\u02B4\u02B7\u02BC\u02BD\u02BB\u02BF\u02BC = u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B2 == null;
	}

	// Token: 0x04000D67 RID: 3431
	private Vector2 \u02BA\u02C1\u02BF\u02B6\u02C1\u02B8\u02BC\u02BC\u02BC\u02B5\u02C1;

	// Token: 0x04000D68 RID: 3432
	private Transform \u02C0\u02B6\u02B6\u02BC\u02BC\u02B5\u02BD\u02B7\u02B5\u02BC\u02B2;

	// Token: 0x04000D69 RID: 3433
	public bool \u02B4\u02B3\u02B7\u02B7\u02C1\u02B4\u02B8\u02B4\u02B2\u02B7\u02B5;

	// Token: 0x04000D6A RID: 3434
	private bool \u02BA\u02BB\u02B2\u02C0\u02B4\u02B7\u02BC\u02BD\u02BB\u02BF\u02BC;

	// Token: 0x04000D6B RID: 3435
	public Transform \u02BD\u02B6\u02B6\u02BD\u02BF\u02B3\u02BE\u02BC\u02B9\u02BD\u02B5;

	// Token: 0x04000D6C RID: 3436
	public float \u02B3\u02B3\u02C0\u02BA\u02B5\u02B9\u02B2\u02B9\u02B7\u02BE\u02BB;

	// Token: 0x04000D6D RID: 3437
	public float \u02C0\u02B7\u02BE\u02BB\u02B2\u02BC\u02B8\u02B9\u02B6\u02BC\u02BB;

	// Token: 0x04000D6E RID: 3438
	public float \u02BA\u02C1\u02BC\u02B5\u02C0\u02B4\u02BC\u02BF\u02B5\u02BE\u02BA;

	// Token: 0x04000D6F RID: 3439
	public float \u02BF\u02C0\u02B4\u02C1\u02B8\u02BB\u02B6\u02B2\u02B3\u02B7\u02BC;

	// Token: 0x04000D70 RID: 3440
	private \u02C1\u02BB\u02BD\u02B7\u02BD\u02BB\u02BE\u02B5\u02B7\u02C0\u02B6 \u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7;

	// Token: 0x04000D71 RID: 3441
	public Camera \u02C0\u02B3\u02C0\u02B6\u02B4\u02B9\u02C1\u02B7\u02B3\u02B9\u02B8;
}
