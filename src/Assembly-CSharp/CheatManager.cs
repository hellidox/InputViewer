using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheatManager : MonoBehaviour
{
	private IEnumerator \u02B8\u02C0\u02C0\u02BD\u02B7\u02BE\u02B9\u02BB\u02BA\u02BC\u02B7(\u02C1\u02BB\u02BD\u02B7\u02BD\u02BB\u02BE\u02B5\u02B7\u02C0\u02B6 \u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7, CheatManager.\u02B6\u02C0\u02BA\u02B4\u02B2\u02BB\u02B7\u02BE\u02C0\u02BE\u02B7 \u02B2\u02BF\u02B5\u02B4\u02B9\u02B6\u02B9\u02B7\u02B5\u02B2\u02BA, int \u02B2\u02B3\u02B2\u02C0\u02B3\u02C0\u02BF\u02BD\u02BF\u02B3\u02C0)
	{
		CheatManager.\u02BC\u02B4\u02B2\u02BF\u02B2\u02BF\u02B8\u02B3\u02BE\u02BD\u02B8 u02BC_u02B4_u02B2_u02BF_u02B2_u02BF_u02B8_u02B3_u02BE_u02BD_u02B = new CheatManager.\u02BC\u02B4\u02B2\u02BF\u02B2\u02BF\u02B8\u02B3\u02BE\u02BD\u02B8(1);
		u02BC_u02B4_u02B2_u02BF_u02B2_u02BF_u02B8_u02B3_u02BE_u02BD_u02B.player = \u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7;
		u02BC_u02B4_u02B2_u02BF_u02B2_u02BF_u02B8_u02B3_u02BE_u02BD_u02B.cheat = \u02B2\u02BF\u02B5\u02B4\u02B9\u02B6\u02B9\u02B7\u02B5\u02B2\u02BA;
		u02BC_u02B4_u02B2_u02BF_u02B2_u02BF_u02B8_u02B3_u02BE_u02BD_u02B.coIndex = \u02B2\u02B3\u02B2\u02C0\u02B3\u02C0\u02BF\u02BD\u02BF\u02B3\u02C0;
		return u02BC_u02B4_u02B2_u02BF_u02B2_u02BF_u02B8_u02B3_u02BE_u02BD_u02B;
	}

	private IEnumerator \u02B5\u02B9\u02B7\u02B5\u02C1\u02C1\u02BD\u02BA\u02BA\u02B4\u02B7(\u02C1\u02BB\u02BD\u02B7\u02BD\u02BB\u02BE\u02B5\u02B7\u02C0\u02B6 \u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7, CheatManager.\u02B6\u02C0\u02BA\u02B4\u02B2\u02BB\u02B7\u02BE\u02C0\u02BE\u02B7 \u02B2\u02BF\u02B5\u02B4\u02B9\u02B6\u02B9\u02B7\u02B5\u02B2\u02BA, int \u02B2\u02B3\u02B2\u02C0\u02B3\u02C0\u02BF\u02BD\u02BF\u02B3\u02C0)
	{
		CheatManager.\u02BC\u02B4\u02B2\u02BF\u02B2\u02BF\u02B8\u02B3\u02BE\u02BD\u02B8 u02BC_u02B4_u02B2_u02BF_u02B2_u02BF_u02B8_u02B3_u02BE_u02BD_u02B = new CheatManager.\u02BC\u02B4\u02B2\u02BF\u02B2\u02BF\u02B8\u02B3\u02BE\u02BD\u02B8(1);
		u02BC_u02B4_u02B2_u02BF_u02B2_u02BF_u02B8_u02B3_u02BE_u02BD_u02B.player = \u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7;
		u02BC_u02B4_u02B2_u02BF_u02B2_u02BF_u02B8_u02B3_u02BE_u02BD_u02B.cheat = \u02B2\u02BF\u02B5\u02B4\u02B9\u02B6\u02B9\u02B7\u02B5\u02B2\u02BA;
		u02BC_u02B4_u02B2_u02BF_u02B2_u02BF_u02B8_u02B3_u02BE_u02BD_u02B.coIndex = \u02B2\u02B3\u02B2\u02C0\u02B3\u02C0\u02BF\u02BD\u02BF\u02B3\u02C0;
		return u02BC_u02B4_u02B2_u02BF_u02B2_u02BF_u02B8_u02B3_u02BE_u02BD_u02B;
	}

	public void \u02BC\u02B2\u02B3\u02B2\u02B4\u02B4\u02BD\u02BC\u02BB\u02BF\u02BA(int \u02B8\u02BE\u02BE\u02B4\u02B3\u02B2\u02BF\u02BB\u02B4\u02BE\u02B5, bool \u02B3\u02B6\u02C0\u02BB\u02B5\u02BC\u02BE\u02BA\u02BA\u02B5\u02C1)
	{
		this.cheats[\u02B8\u02BE\u02BE\u02B4\u02B3\u02B2\u02BF\u02BB\u02B4\u02BE\u02B5].\u02B8\u02B2\u02B7\u02BB\u02BA\u02C0\u02BF\u02C1\u02B2\u02B6\u02BC = \u02B3\u02B6\u02C0\u02BB\u02B5\u02BC\u02BE\u02BA\u02BA\u02B5\u02C1;
	}

	public void \u02BA\u02BD\u02B2\u02B8\u02BE\u02C1\u02B2\u02BB\u02B9\u02B6\u02B4(int \u02B8\u02BE\u02BE\u02B4\u02B3\u02B2\u02BF\u02BB\u02B4\u02BE\u02B5, bool \u02B3\u02B6\u02C0\u02BB\u02B5\u02BC\u02BE\u02BA\u02BA\u02B5\u02C1)
	{
		this.cheats[\u02B8\u02BE\u02BE\u02B4\u02B3\u02B2\u02BF\u02BB\u02B4\u02BE\u02B5].\u02B8\u02B2\u02B7\u02BB\u02BA\u02C0\u02BF\u02C1\u02B2\u02B6\u02BC = \u02B3\u02B6\u02C0\u02BB\u02B5\u02BC\u02BE\u02BA\u02BA\u02B5\u02C1;
	}

	public int \u02BD\u02B4\u02BF\u02C0\u02BE\u02B3\u02BA\u02BF\u02BC\u02B9\u02B9(string \u02BF\u02B4\u02C1\u02BC\u02BC\u02B2\u02BC\u02BB\u02BA\u02B2\u02B6, int[] \u02B8\u02B4\u02B8\u02BC\u02B5\u02BD\u02B4\u02B2\u02B4\u02BB\u02BD, CheatManager.\u02BC\u02BC\u02C1\u02B6\u02BA\u02B2\u02B4\u02BD\u02BF\u02B4\u02BC \u02BE\u02BA\u02B3\u02C1\u02B5\u02C1\u02BC\u02B2\u02B5\u02B2\u02B9, \u02C1\u02BB\u02BD\u02B7\u02BD\u02BB\u02BE\u02B5\u02B7\u02C0\u02B6 \u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7 = null, bool \u02B8\u02B2\u02B7\u02BB\u02BA\u02C0\u02BF\u02C1\u02B2\u02B6\u02BC = true)
	{
		int num = this.cheats.IndexOf(null);
		CheatManager.\u02B6\u02C0\u02BA\u02B4\u02B2\u02BB\u02B7\u02BE\u02C0\u02BE\u02B7 u02B6_u02C0_u02BA_u02B4_u02B2_u02BB_u02B7_u02BE_u02C0_u02BE_u02B = new CheatManager.\u02B6\u02C0\u02BA\u02B4\u02B2\u02BB\u02B7\u02BE\u02C0\u02BE\u02B7
		{
			\u02BF\u02B4\u02C1\u02BC\u02BC\u02B2\u02BC\u02BB\u02BA\u02B2\u02B6 = \u02BF\u02B4\u02C1\u02BC\u02BC\u02B2\u02BC\u02BB\u02BA\u02B2\u02B6,
			\u02B3\u02C1\u02BB\u02BA\u02B5\u02BE\u02B2\u02C1\u02B8\u02B6\u02B5 = \u02BE\u02BA\u02B3\u02C1\u02B5\u02C1\u02BC\u02B2\u02B5\u02B2\u02B9,
			\u02B7\u02C0\u02B4\u02B3\u02BF\u02B8\u02BE\u02BF\u02BA\u02B4\u02B5 = \u02B8\u02B4\u02B8\u02BC\u02B5\u02BD\u02B4\u02B2\u02B4\u02BB\u02BD,
			\u02B8\u02B2\u02B7\u02BB\u02BA\u02C0\u02BF\u02C1\u02B2\u02B6\u02BC = \u02B8\u02B2\u02B7\u02BB\u02BA\u02C0\u02BF\u02C1\u02B2\u02B6\u02BC,
			\u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7 = \u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7
		};
		if (num == -1)
		{
			num = this.cheats.Count;
			u02B6_u02C0_u02BA_u02B4_u02B2_u02BB_u02B7_u02BE_u02C0_u02BE_u02B.\u02BB\u02C0\u02B7\u02BD\u02BD\u02B2\u02B5\u02B5\u02BB\u02BB\u02BF = num;
			this.cheats.Add(u02B6_u02C0_u02BA_u02B4_u02B2_u02BB_u02B7_u02BE_u02C0_u02BE_u02B);
		}
		else
		{
			u02B6_u02C0_u02BA_u02B4_u02B2_u02BB_u02B7_u02BE_u02C0_u02BE_u02B.\u02BB\u02C0\u02B7\u02BD\u02BD\u02B2\u02B5\u02B5\u02BB\u02BB\u02BF = num;
			this.cheats[num] = u02B6_u02C0_u02BA_u02B4_u02B2_u02BB_u02B7_u02BE_u02C0_u02BE_u02B;
		}
		return num;
	}

	public void \u02B8\u02B6\u02B3\u02B5\u02B4\u02BB\u02BB\u02B8\u02BD\u02B6\u02B5(int \u02B8\u02BE\u02BE\u02B4\u02B3\u02B2\u02BF\u02BB\u02B4\u02BE\u02B5, bool \u02B3\u02B6\u02C0\u02BB\u02B5\u02BC\u02BE\u02BA\u02BA\u02B5\u02C1)
	{
		this.cheats[\u02B8\u02BE\u02BE\u02B4\u02B3\u02B2\u02BF\u02BB\u02B4\u02BE\u02B5].\u02B8\u02B2\u02B7\u02BB\u02BA\u02C0\u02BF\u02C1\u02B2\u02B6\u02BC = \u02B3\u02B6\u02C0\u02BB\u02B5\u02BC\u02BE\u02BA\u02BA\u02B5\u02C1;
	}

	private void Awake()
	{
		if (CheatManager.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7 != null)
		{
			global::UnityEngine.Object.Destroy(this);
			return;
		}
		this.cheats = new List<CheatManager.\u02B6\u02C0\u02BA\u02B4\u02B2\u02BB\u02B7\u02BE\u02C0\u02BE\u02B7>();
		CheatManager.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7 = this;
		global::UnityEngine.Object.DontDestroyOnLoad(this);
	}

	private IEnumerator \u02B6\u02B7\u02B9\u02B7\u02B2\u02B6\u02BA\u02BF\u02B3\u02BD\u02B2(\u02C1\u02BB\u02BD\u02B7\u02BD\u02BB\u02BE\u02B5\u02B7\u02C0\u02B6 \u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7, CheatManager.\u02B6\u02C0\u02BA\u02B4\u02B2\u02BB\u02B7\u02BE\u02C0\u02BE\u02B7 \u02B2\u02BF\u02B5\u02B4\u02B9\u02B6\u02B9\u02B7\u02B5\u02B2\u02BA, int \u02B2\u02B3\u02B2\u02C0\u02B3\u02C0\u02BF\u02BD\u02BF\u02B3\u02C0)
	{
		CheatManager.\u02BC\u02B4\u02B2\u02BF\u02B2\u02BF\u02B8\u02B3\u02BE\u02BD\u02B8 u02BC_u02B4_u02B2_u02BF_u02B2_u02BF_u02B8_u02B3_u02BE_u02BD_u02B = new CheatManager.\u02BC\u02B4\u02B2\u02BF\u02B2\u02BF\u02B8\u02B3\u02BE\u02BD\u02B8(1);
		u02BC_u02B4_u02B2_u02BF_u02B2_u02BF_u02B8_u02B3_u02BE_u02BD_u02B.player = \u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7;
		u02BC_u02B4_u02B2_u02BF_u02B2_u02BF_u02B8_u02B3_u02BE_u02BD_u02B.cheat = \u02B2\u02BF\u02B5\u02B4\u02B9\u02B6\u02B9\u02B7\u02B5\u02B2\u02BA;
		u02BC_u02B4_u02B2_u02BF_u02B2_u02BF_u02B8_u02B3_u02BE_u02BD_u02B.coIndex = \u02B2\u02B3\u02B2\u02C0\u02B3\u02C0\u02BF\u02BD\u02BF\u02B3\u02C0;
		return u02BC_u02B4_u02B2_u02BF_u02B2_u02BF_u02B8_u02B3_u02BE_u02BD_u02B;
	}

	private IEnumerator \u02B7\u02BE\u02B2\u02B5\u02B5\u02B4\u02B2\u02C0\u02B7\u02BC\u02B2(\u02C1\u02BB\u02BD\u02B7\u02BD\u02BB\u02BE\u02B5\u02B7\u02C0\u02B6 \u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7, CheatManager.\u02B6\u02C0\u02BA\u02B4\u02B2\u02BB\u02B7\u02BE\u02C0\u02BE\u02B7 \u02B2\u02BF\u02B5\u02B4\u02B9\u02B6\u02B9\u02B7\u02B5\u02B2\u02BA, int \u02B2\u02B3\u02B2\u02C0\u02B3\u02C0\u02BF\u02BD\u02BF\u02B3\u02C0)
	{
		CheatManager.\u02BC\u02B4\u02B2\u02BF\u02B2\u02BF\u02B8\u02B3\u02BE\u02BD\u02B8 u02BC_u02B4_u02B2_u02BF_u02B2_u02BF_u02B8_u02B3_u02BE_u02BD_u02B = new CheatManager.\u02BC\u02B4\u02B2\u02BF\u02B2\u02BF\u02B8\u02B3\u02BE\u02BD\u02B8(1);
		u02BC_u02B4_u02B2_u02BF_u02B2_u02BF_u02B8_u02B3_u02BE_u02BD_u02B.player = \u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7;
		u02BC_u02B4_u02B2_u02BF_u02B2_u02BF_u02B8_u02B3_u02BE_u02BD_u02B.cheat = \u02B2\u02BF\u02B5\u02B4\u02B9\u02B6\u02B9\u02B7\u02B5\u02B2\u02BA;
		u02BC_u02B4_u02B2_u02BF_u02B2_u02BF_u02B8_u02B3_u02BE_u02BD_u02B.coIndex = \u02B2\u02B3\u02B2\u02C0\u02B3\u02C0\u02BF\u02BD\u02BF\u02B3\u02C0;
		return u02BC_u02B4_u02B2_u02BF_u02B2_u02BF_u02B8_u02B3_u02BE_u02BD_u02B;
	}

	private void Update()
	{
		foreach (\u02C1\u02BB\u02BD\u02B7\u02BD\u02BB\u02BE\u02B5\u02B7\u02C0\u02B6 u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B in GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B8\u02BD\u02B2\u02B2\u02B7\u02B5\u02B5\u02B3\u02C0\u02BD\u02BF)
		{
			if (u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.\u02BC\u02BA\u02BE\u02B2\u02C0\u02BE\u02B6\u02B5\u02BC\u02B3\u02BD && (u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.playerInfo == null || !u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.playerInfo.isRemotePlayer))
			{
				foreach (CheatManager.\u02B6\u02C0\u02BA\u02B4\u02B2\u02BB\u02B7\u02BE\u02C0\u02BE\u02B7 u02B6_u02C0_u02BA_u02B4_u02B2_u02BB_u02B7_u02BE_u02C0_u02BE_u02B in this.cheats)
				{
					if (u02B6_u02C0_u02BA_u02B4_u02B2_u02BB_u02B7_u02BE_u02C0_u02BE_u02B != null && (u02B6_u02C0_u02BA_u02B4_u02B2_u02BB_u02B7_u02BE_u02C0_u02BE_u02B.\u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7 == null || u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.\u02BE\u02BB\u02B5\u02B7\u02B9\u02B2\u02B6\u02BF\u02B9\u02B7\u02B7 == u02B6_u02C0_u02BA_u02B4_u02B2_u02BB_u02B7_u02BE_u02C0_u02BE_u02B.\u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7.\u02BE\u02BB\u02B5\u02B7\u02B9\u02B2\u02B6\u02BF\u02B9\u02B7\u02B7) && u02B6_u02C0_u02BA_u02B4_u02B2_u02BB_u02B7_u02BE_u02C0_u02BE_u02B.\u02B8\u02B2\u02B7\u02BB\u02BA\u02C0\u02BF\u02C1\u02B2\u02B6\u02BC && !u02B6_u02C0_u02BA_u02B4_u02B2_u02BB_u02B7_u02BE_u02C0_u02BE_u02B.\u02C1\u02BD\u02C0\u02BA\u02B3\u02BB\u02BD\u02BE\u02BA\u02B3\u02B2 && u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.rewiredPlayer.GetButtonDown(u02B6_u02C0_u02BA_u02B4_u02B2_u02BB_u02B7_u02BE_u02C0_u02BE_u02B.\u02B7\u02C0\u02B4\u02B3\u02BF\u02B8\u02BE\u02BF\u02BA\u02B4\u02B5[0]))
					{
						u02B6_u02C0_u02BA_u02B4_u02B2_u02BB_u02B7_u02BE_u02C0_u02BE_u02B.\u02C1\u02BD\u02C0\u02BA\u02B3\u02BB\u02BD\u02BE\u02BA\u02B3\u02B2 = true;
						u02B6_u02C0_u02BA_u02B4_u02B2_u02BB_u02B7_u02BE_u02C0_u02BE_u02B.\u02BF\u02BB\u02BB\u02BF\u02BB\u02B4\u02B6\u02B4\u02BC\u02B3\u02BB.Add(base.StartCoroutine(this.\u02B8\u02BA\u02BD\u02BF\u02B6\u02C0\u02B4\u02BA\u02BA\u02BE\u02BB(u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B, u02B6_u02C0_u02BA_u02B4_u02B2_u02BB_u02B7_u02BE_u02C0_u02BE_u02B, u02B6_u02C0_u02BA_u02B4_u02B2_u02BB_u02B7_u02BE_u02C0_u02BE_u02B.\u02BF\u02BB\u02BB\u02BF\u02BB\u02B4\u02B6\u02B4\u02BC\u02B3\u02BB.Count)));
					}
				}
			}
		}
	}

	private void \u02BD\u02B7\u02BD\u02BF\u02BE\u02B9\u02B6\u02C0\u02B4\u02B7\u02BF()
	{
		foreach (\u02C1\u02BB\u02BD\u02B7\u02BD\u02BB\u02BE\u02B5\u02B7\u02C0\u02B6 u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B in GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B8\u02BD\u02B2\u02B2\u02B7\u02B5\u02B5\u02B3\u02C0\u02BD\u02BF)
		{
			if (u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.\u02BC\u02BA\u02BE\u02B2\u02C0\u02BE\u02B6\u02B5\u02BC\u02B3\u02BD && (u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.playerInfo == null || !u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.playerInfo.isRemotePlayer))
			{
				foreach (CheatManager.\u02B6\u02C0\u02BA\u02B4\u02B2\u02BB\u02B7\u02BE\u02C0\u02BE\u02B7 u02B6_u02C0_u02BA_u02B4_u02B2_u02BB_u02B7_u02BE_u02C0_u02BE_u02B in this.cheats)
				{
					if (u02B6_u02C0_u02BA_u02B4_u02B2_u02BB_u02B7_u02BE_u02C0_u02BE_u02B != null && (u02B6_u02C0_u02BA_u02B4_u02B2_u02BB_u02B7_u02BE_u02C0_u02BE_u02B.\u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7 == null || u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.\u02BE\u02BB\u02B5\u02B7\u02B9\u02B2\u02B6\u02BF\u02B9\u02B7\u02B7 == u02B6_u02C0_u02BA_u02B4_u02B2_u02BB_u02B7_u02BE_u02C0_u02BE_u02B.\u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7.\u02BE\u02BB\u02B5\u02B7\u02B9\u02B2\u02B6\u02BF\u02B9\u02B7\u02B7) && u02B6_u02C0_u02BA_u02B4_u02B2_u02BB_u02B7_u02BE_u02C0_u02BE_u02B.\u02B8\u02B2\u02B7\u02BB\u02BA\u02C0\u02BF\u02C1\u02B2\u02B6\u02BC && !u02B6_u02C0_u02BA_u02B4_u02B2_u02BB_u02B7_u02BE_u02C0_u02BE_u02B.\u02C1\u02BD\u02C0\u02BA\u02B3\u02BB\u02BD\u02BE\u02BA\u02B3\u02B2 && u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B.rewiredPlayer.GetButtonDown(u02B6_u02C0_u02BA_u02B4_u02B2_u02BB_u02B7_u02BE_u02C0_u02BE_u02B.\u02B7\u02C0\u02B4\u02B3\u02BF\u02B8\u02BE\u02BF\u02BA\u02B4\u02B5[1]))
					{
						u02B6_u02C0_u02BA_u02B4_u02B2_u02BB_u02B7_u02BE_u02C0_u02BE_u02B.\u02C1\u02BD\u02C0\u02BA\u02B3\u02BB\u02BD\u02BE\u02BA\u02B3\u02B2 = true;
						u02B6_u02C0_u02BA_u02B4_u02B2_u02BB_u02B7_u02BE_u02C0_u02BE_u02B.\u02BF\u02BB\u02BB\u02BF\u02BB\u02B4\u02B6\u02B4\u02BC\u02B3\u02BB.Add(base.StartCoroutine(this.\u02B5\u02B9\u02B7\u02B5\u02C1\u02C1\u02BD\u02BA\u02BA\u02B4\u02B7(u02C1_u02BB_u02BD_u02B7_u02BD_u02BB_u02BE_u02B5_u02B7_u02C0_u02B, u02B6_u02C0_u02BA_u02B4_u02B2_u02BB_u02B7_u02BE_u02C0_u02BE_u02B, u02B6_u02C0_u02BA_u02B4_u02B2_u02BB_u02B7_u02BE_u02C0_u02BE_u02B.\u02BF\u02BB\u02BB\u02BF\u02BB\u02B4\u02B6\u02B4\u02BC\u02B3\u02BB.Count)));
					}
				}
			}
		}
	}

	public void \u02BB\u02C1\u02BA\u02BA\u02B4\u02B9\u02B9\u02BF\u02BB\u02B4\u02BE(int \u02BB\u02C0\u02B7\u02BD\u02BD\u02B2\u02B5\u02B5\u02BB\u02BB\u02BF)
	{
		if (this.cheats == null || \u02BB\u02C0\u02B7\u02BD\u02BD\u02B2\u02B5\u02B5\u02BB\u02BB\u02BF > this.cheats.Count - 1 || this.cheats[\u02BB\u02C0\u02B7\u02BD\u02BD\u02B2\u02B5\u02B5\u02BB\u02BB\u02BF] == null)
		{
			return;
		}
		foreach (Coroutine coroutine in this.cheats[\u02BB\u02C0\u02B7\u02BD\u02BD\u02B2\u02B5\u02B5\u02BB\u02BB\u02BF].\u02BF\u02BB\u02BB\u02BF\u02BB\u02B4\u02B6\u02B4\u02BC\u02B3\u02BB)
		{
			if (coroutine != null)
			{
				base.StopCoroutine(coroutine);
			}
		}
		this.cheats.RemoveAt(\u02BB\u02C0\u02B7\u02BD\u02BD\u02B2\u02B5\u02B5\u02BB\u02BB\u02BF);
	}

	public int \u02BB\u02B7\u02B2\u02C0\u02B6\u02B2\u02B6\u02B2\u02BC\u02BD\u02BF(string \u02BF\u02B4\u02C1\u02BC\u02BC\u02B2\u02BC\u02BB\u02BA\u02B2\u02B6, int[] \u02B8\u02B4\u02B8\u02BC\u02B5\u02BD\u02B4\u02B2\u02B4\u02BB\u02BD, CheatManager.\u02BC\u02BC\u02C1\u02B6\u02BA\u02B2\u02B4\u02BD\u02BF\u02B4\u02BC \u02BE\u02BA\u02B3\u02C1\u02B5\u02C1\u02BC\u02B2\u02B5\u02B2\u02B9, \u02C1\u02BB\u02BD\u02B7\u02BD\u02BB\u02BE\u02B5\u02B7\u02C0\u02B6 \u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7 = null, bool \u02B8\u02B2\u02B7\u02BB\u02BA\u02C0\u02BF\u02C1\u02B2\u02B6\u02BC = true)
	{
		int num = this.cheats.IndexOf(null);
		CheatManager.\u02B6\u02C0\u02BA\u02B4\u02B2\u02BB\u02B7\u02BE\u02C0\u02BE\u02B7 u02B6_u02C0_u02BA_u02B4_u02B2_u02BB_u02B7_u02BE_u02C0_u02BE_u02B = new CheatManager.\u02B6\u02C0\u02BA\u02B4\u02B2\u02BB\u02B7\u02BE\u02C0\u02BE\u02B7
		{
			\u02BF\u02B4\u02C1\u02BC\u02BC\u02B2\u02BC\u02BB\u02BA\u02B2\u02B6 = \u02BF\u02B4\u02C1\u02BC\u02BC\u02B2\u02BC\u02BB\u02BA\u02B2\u02B6,
			\u02B3\u02C1\u02BB\u02BA\u02B5\u02BE\u02B2\u02C1\u02B8\u02B6\u02B5 = \u02BE\u02BA\u02B3\u02C1\u02B5\u02C1\u02BC\u02B2\u02B5\u02B2\u02B9,
			\u02B7\u02C0\u02B4\u02B3\u02BF\u02B8\u02BE\u02BF\u02BA\u02B4\u02B5 = \u02B8\u02B4\u02B8\u02BC\u02B5\u02BD\u02B4\u02B2\u02B4\u02BB\u02BD,
			\u02B8\u02B2\u02B7\u02BB\u02BA\u02C0\u02BF\u02C1\u02B2\u02B6\u02BC = \u02B8\u02B2\u02B7\u02BB\u02BA\u02C0\u02BF\u02C1\u02B2\u02B6\u02BC,
			\u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7 = \u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7
		};
		if (num == -1)
		{
			num = this.cheats.Count;
			u02B6_u02C0_u02BA_u02B4_u02B2_u02BB_u02B7_u02BE_u02C0_u02BE_u02B.\u02BB\u02C0\u02B7\u02BD\u02BD\u02B2\u02B5\u02B5\u02BB\u02BB\u02BF = num;
			this.cheats.Add(u02B6_u02C0_u02BA_u02B4_u02B2_u02BB_u02B7_u02BE_u02C0_u02BE_u02B);
		}
		else
		{
			u02B6_u02C0_u02BA_u02B4_u02B2_u02BB_u02B7_u02BE_u02C0_u02BE_u02B.\u02BB\u02C0\u02B7\u02BD\u02BD\u02B2\u02B5\u02B5\u02BB\u02BB\u02BF = num;
			this.cheats[num] = u02B6_u02C0_u02BA_u02B4_u02B2_u02BB_u02B7_u02BE_u02C0_u02BE_u02B;
		}
		return num;
	}

	private IEnumerator \u02B8\u02BA\u02BD\u02BF\u02B6\u02C0\u02B4\u02BA\u02BA\u02BE\u02BB(\u02C1\u02BB\u02BD\u02B7\u02BD\u02BB\u02BE\u02B5\u02B7\u02C0\u02B6 \u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7, CheatManager.\u02B6\u02C0\u02BA\u02B4\u02B2\u02BB\u02B7\u02BE\u02C0\u02BE\u02B7 \u02B2\u02BF\u02B5\u02B4\u02B9\u02B6\u02B9\u02B7\u02B5\u02B2\u02BA, int \u02B2\u02B3\u02B2\u02C0\u02B3\u02C0\u02BF\u02BD\u02BF\u02B3\u02C0)
	{
		int index = 0;
		for (;;)
		{
			if (\u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7.rewiredPlayer.GetButtonDown(\u02B2\u02BF\u02B5\u02B4\u02B9\u02B6\u02B9\u02B7\u02B5\u02B2\u02BA.\u02B7\u02C0\u02B4\u02B3\u02BF\u02B8\u02BE\u02BF\u02BA\u02B4\u02B5[index]))
			{
				int num = index;
				index = num + 1;
				if (index == \u02B2\u02BF\u02B5\u02B4\u02B9\u02B6\u02B9\u02B7\u02B5\u02B2\u02BA.\u02B7\u02C0\u02B4\u02B3\u02BF\u02B8\u02BE\u02BF\u02BA\u02B4\u02B5.Length)
				{
					break;
				}
			}
			else if (\u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7.rewiredPlayer.GetAnyButtonDown())
			{
				goto Block_3;
			}
			yield return null;
		}
		\u02B2\u02BF\u02B5\u02B4\u02B9\u02B6\u02B9\u02B7\u02B5\u02B2\u02BA.\u02B3\u02C1\u02BB\u02BA\u02B5\u02BE\u02B2\u02C1\u02B8\u02B6\u02B5(\u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7.\u02BE\u02BB\u02B5\u02B7\u02B9\u02B2\u02B6\u02BF\u02B9\u02B7\u02B7);
		\u02B2\u02BF\u02B5\u02B4\u02B9\u02B6\u02B9\u02B7\u02B5\u02B2\u02BA.\u02B6\u02BE\u02B6\u02B6\u02B6\u02BA\u02C0\u02B9\u02B4\u02B9\u02B3(\u02B2\u02B3\u02B2\u02C0\u02B3\u02C0\u02BF\u02BD\u02BF\u02B3\u02C0);
		yield break;
		Block_3:
		\u02B2\u02BF\u02B5\u02B4\u02B9\u02B6\u02B9\u02B7\u02B5\u02B2\u02BA.\u02B6\u02BE\u02B6\u02B6\u02B6\u02BA\u02C0\u02B9\u02B4\u02B9\u02B3(\u02B2\u02B3\u02B2\u02C0\u02B3\u02C0\u02BF\u02BD\u02BF\u02B3\u02C0);
		yield break;
		yield break;
	}

	public int \u02B9\u02B3\u02BE\u02B4\u02B4\u02BC\u02B6\u02BB\u02C1\u02BF\u02B3(string \u02BF\u02B4\u02C1\u02BC\u02BC\u02B2\u02BC\u02BB\u02BA\u02B2\u02B6, int[] \u02B8\u02B4\u02B8\u02BC\u02B5\u02BD\u02B4\u02B2\u02B4\u02BB\u02BD, CheatManager.\u02BC\u02BC\u02C1\u02B6\u02BA\u02B2\u02B4\u02BD\u02BF\u02B4\u02BC \u02BE\u02BA\u02B3\u02C1\u02B5\u02C1\u02BC\u02B2\u02B5\u02B2\u02B9, \u02C1\u02BB\u02BD\u02B7\u02BD\u02BB\u02BE\u02B5\u02B7\u02C0\u02B6 \u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7 = null, bool \u02B8\u02B2\u02B7\u02BB\u02BA\u02C0\u02BF\u02C1\u02B2\u02B6\u02BC = true)
	{
		int num = this.cheats.IndexOf(null);
		CheatManager.\u02B6\u02C0\u02BA\u02B4\u02B2\u02BB\u02B7\u02BE\u02C0\u02BE\u02B7 u02B6_u02C0_u02BA_u02B4_u02B2_u02BB_u02B7_u02BE_u02C0_u02BE_u02B = new CheatManager.\u02B6\u02C0\u02BA\u02B4\u02B2\u02BB\u02B7\u02BE\u02C0\u02BE\u02B7
		{
			\u02BF\u02B4\u02C1\u02BC\u02BC\u02B2\u02BC\u02BB\u02BA\u02B2\u02B6 = \u02BF\u02B4\u02C1\u02BC\u02BC\u02B2\u02BC\u02BB\u02BA\u02B2\u02B6,
			\u02B3\u02C1\u02BB\u02BA\u02B5\u02BE\u02B2\u02C1\u02B8\u02B6\u02B5 = \u02BE\u02BA\u02B3\u02C1\u02B5\u02C1\u02BC\u02B2\u02B5\u02B2\u02B9,
			\u02B7\u02C0\u02B4\u02B3\u02BF\u02B8\u02BE\u02BF\u02BA\u02B4\u02B5 = \u02B8\u02B4\u02B8\u02BC\u02B5\u02BD\u02B4\u02B2\u02B4\u02BB\u02BD,
			\u02B8\u02B2\u02B7\u02BB\u02BA\u02C0\u02BF\u02C1\u02B2\u02B6\u02BC = \u02B8\u02B2\u02B7\u02BB\u02BA\u02C0\u02BF\u02C1\u02B2\u02B6\u02BC,
			\u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7 = \u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7
		};
		if (num == -1)
		{
			num = this.cheats.Count;
			u02B6_u02C0_u02BA_u02B4_u02B2_u02BB_u02B7_u02BE_u02C0_u02BE_u02B.\u02BB\u02C0\u02B7\u02BD\u02BD\u02B2\u02B5\u02B5\u02BB\u02BB\u02BF = num;
			this.cheats.Add(u02B6_u02C0_u02BA_u02B4_u02B2_u02BB_u02B7_u02BE_u02C0_u02BE_u02B);
		}
		else
		{
			u02B6_u02C0_u02BA_u02B4_u02B2_u02BB_u02B7_u02BE_u02C0_u02BE_u02B.\u02BB\u02C0\u02B7\u02BD\u02BD\u02B2\u02B5\u02B5\u02BB\u02BB\u02BF = num;
			this.cheats[num] = u02B6_u02C0_u02BA_u02B4_u02B2_u02BB_u02B7_u02BE_u02C0_u02BE_u02B;
		}
		return num;
	}

	private void \u02BE\u02B6\u02B9\u02B2\u02C1\u02B9\u02B8\u02B6\u02B4\u02B3\u02B3()
	{
		if (CheatManager.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7 != null)
		{
			global::UnityEngine.Object.Destroy(this);
			return;
		}
		this.cheats = new List<CheatManager.\u02B6\u02C0\u02BA\u02B4\u02B2\u02BB\u02B7\u02BE\u02C0\u02BE\u02B7>();
		CheatManager.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7 = this;
		global::UnityEngine.Object.DontDestroyOnLoad(this);
	}

	private IEnumerator \u02C0\u02BD\u02BD\u02BE\u02BA\u02B8\u02BF\u02B4\u02B7\u02BA\u02BB(\u02C1\u02BB\u02BD\u02B7\u02BD\u02BB\u02BE\u02B5\u02B7\u02C0\u02B6 \u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7, CheatManager.\u02B6\u02C0\u02BA\u02B4\u02B2\u02BB\u02B7\u02BE\u02C0\u02BE\u02B7 \u02B2\u02BF\u02B5\u02B4\u02B9\u02B6\u02B9\u02B7\u02B5\u02B2\u02BA, int \u02B2\u02B3\u02B2\u02C0\u02B3\u02C0\u02BF\u02BD\u02BF\u02B3\u02C0)
	{
		CheatManager.\u02BC\u02B4\u02B2\u02BF\u02B2\u02BF\u02B8\u02B3\u02BE\u02BD\u02B8 u02BC_u02B4_u02B2_u02BF_u02B2_u02BF_u02B8_u02B3_u02BE_u02BD_u02B = new CheatManager.\u02BC\u02B4\u02B2\u02BF\u02B2\u02BF\u02B8\u02B3\u02BE\u02BD\u02B8(1);
		u02BC_u02B4_u02B2_u02BF_u02B2_u02BF_u02B8_u02B3_u02BE_u02BD_u02B.player = \u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7;
		u02BC_u02B4_u02B2_u02BF_u02B2_u02BF_u02B8_u02B3_u02BE_u02BD_u02B.cheat = \u02B2\u02BF\u02B5\u02B4\u02B9\u02B6\u02B9\u02B7\u02B5\u02B2\u02BA;
		u02BC_u02B4_u02B2_u02BF_u02B2_u02BF_u02B8_u02B3_u02BE_u02BD_u02B.coIndex = \u02B2\u02B3\u02B2\u02C0\u02B3\u02C0\u02BF\u02BD\u02BF\u02B3\u02C0;
		return u02BC_u02B4_u02B2_u02BF_u02B2_u02BF_u02B8_u02B3_u02BE_u02BD_u02B;
	}

	public void \u02BB\u02B3\u02B4\u02C1\u02B4\u02B4\u02C1\u02B8\u02B6\u02B8\u02B6(int \u02BB\u02C0\u02B7\u02BD\u02BD\u02B2\u02B5\u02B5\u02BB\u02BB\u02BF)
	{
		if (this.cheats == null || \u02BB\u02C0\u02B7\u02BD\u02BD\u02B2\u02B5\u02B5\u02BB\u02BB\u02BF > this.cheats.Count - 0 || this.cheats[\u02BB\u02C0\u02B7\u02BD\u02BD\u02B2\u02B5\u02B5\u02BB\u02BB\u02BF] == null)
		{
			return;
		}
		foreach (Coroutine coroutine in this.cheats[\u02BB\u02C0\u02B7\u02BD\u02BD\u02B2\u02B5\u02B5\u02BB\u02BB\u02BF].\u02BF\u02BB\u02BB\u02BF\u02BB\u02B4\u02B6\u02B4\u02BC\u02B3\u02BB)
		{
			if (coroutine != null)
			{
				base.StopCoroutine(coroutine);
			}
		}
		this.cheats.RemoveAt(\u02BB\u02C0\u02B7\u02BD\u02BD\u02B2\u02B5\u02B5\u02BB\u02BB\u02BF);
	}

	public int \u02B9\u02B5\u02B8\u02BE\u02BF\u02BC\u02BB\u02BA\u02B7\u02C1\u02C1(string \u02BF\u02B4\u02C1\u02BC\u02BC\u02B2\u02BC\u02BB\u02BA\u02B2\u02B6, int[] \u02B8\u02B4\u02B8\u02BC\u02B5\u02BD\u02B4\u02B2\u02B4\u02BB\u02BD, CheatManager.\u02BC\u02BC\u02C1\u02B6\u02BA\u02B2\u02B4\u02BD\u02BF\u02B4\u02BC \u02BE\u02BA\u02B3\u02C1\u02B5\u02C1\u02BC\u02B2\u02B5\u02B2\u02B9, \u02C1\u02BB\u02BD\u02B7\u02BD\u02BB\u02BE\u02B5\u02B7\u02C0\u02B6 \u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7 = null, bool \u02B8\u02B2\u02B7\u02BB\u02BA\u02C0\u02BF\u02C1\u02B2\u02B6\u02BC = true)
	{
		int num = this.cheats.IndexOf(null);
		CheatManager.\u02B6\u02C0\u02BA\u02B4\u02B2\u02BB\u02B7\u02BE\u02C0\u02BE\u02B7 u02B6_u02C0_u02BA_u02B4_u02B2_u02BB_u02B7_u02BE_u02C0_u02BE_u02B = new CheatManager.\u02B6\u02C0\u02BA\u02B4\u02B2\u02BB\u02B7\u02BE\u02C0\u02BE\u02B7
		{
			\u02BF\u02B4\u02C1\u02BC\u02BC\u02B2\u02BC\u02BB\u02BA\u02B2\u02B6 = \u02BF\u02B4\u02C1\u02BC\u02BC\u02B2\u02BC\u02BB\u02BA\u02B2\u02B6,
			\u02B3\u02C1\u02BB\u02BA\u02B5\u02BE\u02B2\u02C1\u02B8\u02B6\u02B5 = \u02BE\u02BA\u02B3\u02C1\u02B5\u02C1\u02BC\u02B2\u02B5\u02B2\u02B9,
			\u02B7\u02C0\u02B4\u02B3\u02BF\u02B8\u02BE\u02BF\u02BA\u02B4\u02B5 = \u02B8\u02B4\u02B8\u02BC\u02B5\u02BD\u02B4\u02B2\u02B4\u02BB\u02BD,
			\u02B8\u02B2\u02B7\u02BB\u02BA\u02C0\u02BF\u02C1\u02B2\u02B6\u02BC = \u02B8\u02B2\u02B7\u02BB\u02BA\u02C0\u02BF\u02C1\u02B2\u02B6\u02BC,
			\u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7 = \u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7
		};
		if (num == -1)
		{
			num = this.cheats.Count;
			u02B6_u02C0_u02BA_u02B4_u02B2_u02BB_u02B7_u02BE_u02C0_u02BE_u02B.\u02BB\u02C0\u02B7\u02BD\u02BD\u02B2\u02B5\u02B5\u02BB\u02BB\u02BF = num;
			this.cheats.Add(u02B6_u02C0_u02BA_u02B4_u02B2_u02BB_u02B7_u02BE_u02C0_u02BE_u02B);
		}
		else
		{
			u02B6_u02C0_u02BA_u02B4_u02B2_u02BB_u02B7_u02BE_u02C0_u02BE_u02B.\u02BB\u02C0\u02B7\u02BD\u02BD\u02B2\u02B5\u02B5\u02BB\u02BB\u02BF = num;
			this.cheats[num] = u02B6_u02C0_u02BA_u02B4_u02B2_u02BB_u02B7_u02BE_u02C0_u02BE_u02B;
		}
		return num;
	}

	public static CheatManager \u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7;

	[SerializeField]
	private List<CheatManager.\u02B6\u02C0\u02BA\u02B4\u02B2\u02BB\u02B7\u02BE\u02C0\u02BE\u02B7> cheats;

	public delegate void \u02BC\u02BC\u02C1\u02B6\u02BA\u02B2\u02B4\u02BD\u02BF\u02B4\u02BC(int \u02BE\u02BB\u02B5\u02B7\u02B9\u02B2\u02B6\u02BF\u02B9\u02B7\u02B7);

	private class \u02B6\u02C0\u02BA\u02B4\u02B2\u02BB\u02B7\u02BE\u02C0\u02BE\u02B7
	{
		public void \u02B6\u02BE\u02B6\u02B6\u02B6\u02BA\u02C0\u02B9\u02B4\u02B9\u02B3(int \u02B8\u02BE\u02BE\u02B4\u02B3\u02B2\u02BF\u02BB\u02B4\u02BE\u02B5)
		{
			this.\u02BF\u02BB\u02BB\u02BF\u02BB\u02B4\u02B6\u02B4\u02BC\u02B3\u02BB[\u02B8\u02BE\u02BE\u02B4\u02B3\u02B2\u02BF\u02BB\u02B4\u02BE\u02B5] = null;
			this.\u02C1\u02BD\u02C0\u02BA\u02B3\u02BB\u02BD\u02BE\u02BA\u02B3\u02B2 = false;
		}

		public string \u02BF\u02B4\u02C1\u02BC\u02BC\u02B2\u02BC\u02BB\u02BA\u02B2\u02B6;

		public CheatManager.\u02BC\u02BC\u02C1\u02B6\u02BA\u02B2\u02B4\u02BD\u02BF\u02B4\u02BC \u02B3\u02C1\u02BB\u02BA\u02B5\u02BE\u02B2\u02C1\u02B8\u02B6\u02B5;

		public int[] \u02B7\u02C0\u02B4\u02B3\u02BF\u02B8\u02BE\u02BF\u02BA\u02B4\u02B5;

		public bool \u02B8\u02B2\u02B7\u02BB\u02BA\u02C0\u02BF\u02C1\u02B2\u02B6\u02BC;

		public \u02C1\u02BB\u02BD\u02B7\u02BD\u02BB\u02BE\u02B5\u02B7\u02C0\u02B6 \u02BE\u02B5\u02BB\u02B3\u02B7\u02B4\u02BC\u02B2\u02BB\u02B6\u02B7;

		public List<Coroutine> \u02BF\u02BB\u02BB\u02BF\u02BB\u02B4\u02B6\u02B4\u02BC\u02B3\u02BB = new List<Coroutine>();

		public bool \u02C1\u02BD\u02C0\u02BA\u02B3\u02BB\u02BD\u02BE\u02BA\u02B3\u02B2;

		public int \u02BB\u02C0\u02B7\u02BD\u02BD\u02B2\u02B5\u02B5\u02BB\u02BB\u02BF;
	}
}
