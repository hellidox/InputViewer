﻿using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NoteBomber : MonoBehaviour
{
	private void \u02C1\u02C0\u02BD\u02B4\u02B7\u02BD\u02BB\u02B7\u02B2\u02BA\u02BE()
	{
		if (CheatManager.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7 && this.\u02B8\u02BD\u02B8\u02BA\u02BE\u02B4\u02B5\u02B7\u02C0\u02B3\u02C0 != -1)
		{
			CheatManager.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.enabled = true;
			CheatManager.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BB\u02C1\u02BA\u02BA\u02B4\u02B9\u02B9\u02BF\u02BB\u02B4\u02BE(this.\u02B8\u02BD\u02B8\u02BA\u02BE\u02B4\u02B5\u02B7\u02C0\u02B3\u02C0);
			CheatManager.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BB\u02B3\u02B4\u02C1\u02B4\u02B4\u02C1\u02B8\u02B6\u02B8\u02B6(this.\u02B6\u02BD\u02B6\u02BA\u02B2\u02B2\u02B5\u02BC\u02BE\u02B5\u02B4);
			this.\u02B8\u02BD\u02B8\u02BA\u02BE\u02B4\u02B5\u02B7\u02C0\u02B3\u02C0 = -1;
			this.\u02B6\u02BD\u02B6\u02BA\u02B2\u02B2\u02B5\u02BC\u02BE\u02B5\u02B4 = -1;
		}
	}

	private void \u02C1\u02BA\u02B8\u02BD\u02BE\u02BE\u02B4\u02B7\u02C0\u02BB\u02B3()
	{
		CheatManager.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.enabled = true;
		this.\u02C0\u02B2\u02B3\u02BB\u02BD\u02C0\u02B8\u02B9\u02B7\u02B5\u02BB();
	}

	private void \u02BA\u02BA\u02B8\u02C1\u02B4\u02BA\u02B9\u02B8\u02BD\u02BA\u02C0(int \u02B7\u02B2\u02BD\u02B8\u02BC\u02B5\u02BC\u02C1\u02B9\u02B3\u02B2)
	{
		this.\u02B5\u02C0\u02BC\u02BD\u02B6\u02C1\u02B6\u02BF\u02BE\u02B7\u02C1();
	}

	private void \u02BA\u02BE\u02C0\u02BA\u02B4\u02B2\u02C1\u02BD\u02B3\u02BB\u02C0(int \u02B7\u02B2\u02BD\u02B8\u02BC\u02B5\u02BC\u02C1\u02B9\u02B3\u02B2)
	{
		this.\u02BC\u02B2\u02B8\u02C1\u02B7\u02C0\u02BC\u02B9\u02BF\u02BA\u02B6();
	}

	private void \u02B2\u02B9\u02C1\u02C1\u02B2\u02B3\u02C1\u02BF\u02BC\u02BB\u02C1()
	{
		this.\u02C1\u02BB\u02B4\u02B6\u02B6\u02BB\u02B6\u02BB\u02B7\u02BE\u02BE();
	}

	private void \u02BC\u02B2\u02B8\u02C1\u02B7\u02C0\u02BC\u02B9\u02BF\u02BA\u02B6()
	{
		SceneManager.LoadScene("Quit");
	}

	private void \u02B2\u02B2\u02B7\u02BE\u02B5\u02B9\u02BC\u02BC\u02C0\u02B2\u02BB()
	{
		SceneManager.LoadScene("6 Fret Guitar Coop");
	}

	private void \u02B4\u02B2\u02B5\u02BA\u02B4\u02C0\u02BC\u02BB\u02C1\u02B9\u02BD()
	{
		this.\u02C0\u02B2\u02B3\u02BB\u02BD\u02C0\u02B8\u02B9\u02B7\u02B5\u02BB();
	}

	private void \u02C0\u02BC\u02BC\u02BD\u02B8\u02BD\u02BE\u02B6\u02BE\u02BB\u02BB()
	{
		this.\u02BF\u02BA\u02BF\u02BE\u02B5\u02C1\u02BE\u02B7\u02B7\u02C0\u02B7();
	}

	private void \u02C0\u02B7\u02B3\u02BF\u02B9\u02B3\u02BB\u02C1\u02BB\u02BA\u02BF()
	{
		CheatManager.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.enabled = true;
		this.\u02C1\u02BB\u02B4\u02B6\u02B6\u02BB\u02B6\u02BB\u02B7\u02BE\u02BE();
	}

	private void \u02BB\u02BF\u02B7\u02BA\u02B5\u02B8\u02BA\u02B5\u02B7\u02B9\u02BE()
	{
		CheatManager.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.enabled = true;
		this.\u02C1\u02BB\u02B4\u02B6\u02B6\u02BB\u02B6\u02BB\u02B7\u02BE\u02BE();
	}

	private void \u02C0\u02B2\u02B3\u02BB\u02BD\u02C0\u02B8\u02B9\u02B7\u02B5\u02BB()
	{
		if (CheatManager.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7 != null)
		{
			if (this.\u02B8\u02BD\u02B8\u02BA\u02BE\u02B4\u02B5\u02B7\u02C0\u02B3\u02C0 == -1)
			{
				this.\u02B8\u02BD\u02B8\u02BA\u02BE\u02B4\u02B5\u02B7\u02C0\u02B3\u02C0 = CheatManager.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BD\u02B4\u02BF\u02C0\u02BE\u02B3\u02BA\u02BF\u02BC\u02B9\u02B9("NoteBomber", new int[] { 4, 3, 4, 2, 4, 3, 4, 2 }, new CheatManager.\u02BC\u02BC\u02C1\u02B6\u02BA\u02B2\u02B4\u02BD\u02BF\u02B4\u02BC(this.\u02B6\u02B8\u02BA\u02BE\u02BB\u02C1\u02B2\u02B7\u02BD\u02BC\u02B2), null, true);
			}
			if (this.\u02B6\u02BD\u02B6\u02BA\u02B2\u02B2\u02B5\u02BC\u02BE\u02B5\u02B4 == -1)
			{
				this.\u02B6\u02BD\u02B6\u02BA\u02B2\u02B2\u02B5\u02BC\u02BE\u02B5\u02B4 = CheatManager.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BD\u02B4\u02BF\u02C0\u02BE\u02B3\u02BA\u02BF\u02BC\u02B9\u02B9("AprilFools", new int[] { 2, 4, 4, 4, 4 }, new CheatManager.\u02BC\u02BC\u02C1\u02B6\u02BA\u02B2\u02B4\u02BD\u02BF\u02B4\u02BC(this.\u02B7\u02B2\u02B9\u02B7\u02B6\u02BF\u02B6\u02B2\u02B3\u02C1\u02BA), null, true);
			}
		}
	}

	private void \u02BF\u02BE\u02BB\u02BB\u02B9\u02B7\u02BF\u02B8\u02B4\u02B4\u02B7()
	{
		SceneManager.LoadScene("Pongers");
	}

	private void \u02B3\u02BC\u02BE\u02B8\u02BE\u02C0\u02B4\u02BC\u02BE\u02BB\u02C1()
	{
		if (CheatManager.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7 && this.\u02B8\u02BD\u02B8\u02BA\u02BE\u02B4\u02B5\u02B7\u02C0\u02B3\u02C0 != -1)
		{
			CheatManager.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.enabled = false;
			CheatManager.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BB\u02B3\u02B4\u02C1\u02B4\u02B4\u02C1\u02B8\u02B6\u02B8\u02B6(this.\u02B8\u02BD\u02B8\u02BA\u02BE\u02B4\u02B5\u02B7\u02C0\u02B3\u02C0);
			CheatManager.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BB\u02B3\u02B4\u02C1\u02B4\u02B4\u02C1\u02B8\u02B6\u02B8\u02B6(this.\u02B6\u02BD\u02B6\u02BA\u02B2\u02B2\u02B5\u02BC\u02BE\u02B5\u02B4);
			this.\u02B8\u02BD\u02B8\u02BA\u02BE\u02B4\u02B5\u02B7\u02C0\u02B3\u02C0 = -1;
			this.\u02B6\u02BD\u02B6\u02BA\u02B2\u02B2\u02B5\u02BC\u02BE\u02B5\u02B4 = -1;
		}
	}

	private void \u02C1\u02BB\u02B4\u02B6\u02B6\u02BB\u02B6\u02BB\u02B7\u02BE\u02BE()
	{
		if (CheatManager.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7 != null)
		{
			if (this.\u02B8\u02BD\u02B8\u02BA\u02BE\u02B4\u02B5\u02B7\u02C0\u02B3\u02C0 == -1)
			{
				this.\u02B8\u02BD\u02B8\u02BA\u02BE\u02B4\u02B5\u02B7\u02C0\u02B3\u02C0 = CheatManager.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BB\u02B7\u02B2\u02C0\u02B6\u02B2\u02B6\u02B2\u02BC\u02BD\u02BF("hasBots", new int[] { 4, 3, 4, 2 }, new CheatManager.\u02BC\u02BC\u02C1\u02B6\u02BA\u02B2\u02B4\u02BD\u02BF\u02B4\u02BC(this.\u02BA\u02BA\u02B8\u02C1\u02B4\u02BA\u02B9\u02B8\u02BD\u02BA\u02C0), null, true);
			}
			if (this.\u02B6\u02BD\u02B6\u02BA\u02B2\u02B2\u02B5\u02BC\u02BE\u02B5\u02B4 == -1)
			{
				CheatManager u02B7_u02B2_u02BA_u02B7_u02BB_u02B3_u02BE_u02B6_u02C1_u02C0_u02B = CheatManager.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7;
				string text = "SP Colors";
				int[] array = new int[6];
				RuntimeHelpers.InitializeArray(array, fieldof(PrivateImplementationDetails.BBF15C918A7BDDEB11D20ACB14770D48B2091B8609BBC3464E415659C884E015).FieldHandle);
				this.\u02B6\u02BD\u02B6\u02BA\u02B2\u02B2\u02B5\u02BC\u02BE\u02B5\u02B4 = u02B7_u02B2_u02BA_u02B7_u02BB_u02B3_u02BE_u02B6_u02C1_u02C0_u02B.\u02B9\u02B5\u02B8\u02BE\u02BF\u02BC\u02BB\u02BA\u02B7\u02C1\u02C1(text, array, new CheatManager.\u02BC\u02BC\u02C1\u02B6\u02BA\u02B2\u02B4\u02BD\u02BF\u02B4\u02BC(this.\u02BA\u02BE\u02C0\u02BA\u02B4\u02B2\u02C1\u02BD\u02B3\u02BB\u02C0), null, false);
			}
		}
	}

	private void \u02BA\u02C0\u02B6\u02C1\u02BD\u02BA\u02B6\u02B7\u02B2\u02B3\u02BF()
	{
		CheatManager.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.enabled = false;
		this.\u02C0\u02B2\u02B3\u02BB\u02BD\u02C0\u02B8\u02B9\u02B7\u02B5\u02BB();
	}

	private void OnDisable()
	{
		if (CheatManager.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7 && this.\u02B8\u02BD\u02B8\u02BA\u02BE\u02B4\u02B5\u02B7\u02C0\u02B3\u02C0 != -1)
		{
			CheatManager.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.enabled = false;
			CheatManager.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BB\u02C1\u02BA\u02BA\u02B4\u02B9\u02B9\u02BF\u02BB\u02B4\u02BE(this.\u02B8\u02BD\u02B8\u02BA\u02BE\u02B4\u02B5\u02B7\u02C0\u02B3\u02C0);
			CheatManager.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BB\u02C1\u02BA\u02BA\u02B4\u02B9\u02B9\u02BF\u02BB\u02B4\u02BE(this.\u02B6\u02BD\u02B6\u02BA\u02B2\u02B2\u02B5\u02BC\u02BE\u02B5\u02B4);
			this.\u02B8\u02BD\u02B8\u02BA\u02BE\u02B4\u02B5\u02B7\u02C0\u02B3\u02C0 = -1;
			this.\u02B6\u02BD\u02B6\u02BA\u02B2\u02B2\u02B5\u02BC\u02BE\u02B5\u02B4 = -1;
		}
	}

	[CompilerGenerated]
	private void \u02B6\u02B8\u02BA\u02BE\u02BB\u02C1\u02B2\u02B7\u02BD\u02BC\u02B2(int \u02B7\u02B2\u02BD\u02B8\u02BC\u02B5\u02BC\u02C1\u02B9\u02B3\u02B2)
	{
		this.\u02B5\u02C0\u02BC\u02BD\u02B6\u02C1\u02B6\u02BF\u02BE\u02B7\u02C1();
	}

	private void \u02B5\u02C0\u02BC\u02BD\u02B6\u02C1\u02B6\u02BF\u02BE\u02B7\u02C1()
	{
		this.\u02BE\u02BD\u02C0\u02BF\u02B5\u02BA\u02BD\u02BC\u02C0\u02B2\u02BC.SetActive(true);
		BaseMenu.\u02B6\u02B7\u02BD\u02BE\u02BB\u02BE\u02C0\u02C1\u02B7\u02B4\u02C0 = true;
		this.\u02BC\u02C0\u02B7\u02B7\u02B5\u02B9\u02B9\u02C1\u02BB\u02B5\u02B3.sprite = (this.\u02B6\u02BB\u02BD\u02BA\u02BC\u02B2\u02B9\u02B4\u02B3\u02BA\u02B2.sprite = (this.\u02B2\u02B8\u02B7\u02BD\u02BF\u02C1\u02BC\u02B7\u02B8\u02B7\u02C0.sprite = this.\u02C0\u02B7\u02C1\u02BF\u02C1\u02B5\u02B8\u02B9\u02BB\u02B6\u02BC));
		this.\u02BC\u02C0\u02B7\u02B7\u02B5\u02B9\u02B9\u02C1\u02BB\u02B5\u02B3.GetComponent<RotateScript>().\u02B9\u02BF\u02BD\u02B6\u02B8\u02B4\u02C0\u02BC\u02BD\u02B2\u02B7 = 0f;
		this.\u02B6\u02BB\u02BD\u02BA\u02BC\u02B2\u02B9\u02B4\u02B3\u02BA\u02B2.GetComponent<RotateScript>().\u02B9\u02BF\u02BD\u02B6\u02B8\u02B4\u02C0\u02BC\u02BD\u02B2\u02B7 = 0f;
		this.\u02B2\u02B8\u02B7\u02BD\u02BF\u02C1\u02BC\u02B7\u02B8\u02B7\u02C0.GetComponent<RotateScript>().\u02B9\u02BF\u02BD\u02B6\u02B8\u02B4\u02C0\u02BC\u02BD\u02B2\u02B7 = 0f;
		this.\u02BC\u02C0\u02B7\u02B7\u02B5\u02B9\u02B9\u02C1\u02BB\u02B5\u02B3.GetComponent<RotateScript>().\u02BE\u02B3\u02BB\u02BF\u02BC\u02C1\u02BC\u02C1\u02B2\u02BF\u02C0 = true;
		this.\u02B6\u02BB\u02BD\u02BA\u02BC\u02B2\u02B9\u02B4\u02B3\u02BA\u02B2.GetComponent<RotateScript>().\u02BE\u02B3\u02BB\u02BF\u02BC\u02C1\u02BC\u02C1\u02B2\u02BF\u02C0 = true;
		this.\u02B2\u02B8\u02B7\u02BD\u02BF\u02C1\u02BC\u02B7\u02B8\u02B7\u02C0.GetComponent<RotateScript>().\u02BE\u02B3\u02BB\u02BF\u02BC\u02C1\u02BC\u02C1\u02B2\u02BF\u02C0 = true;
		GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B3\u02B9\u02B8\u02B6\u02C1\u02B4\u02C1\u02B2\u02C1\u02B5\u02C0 = true;
	}

	[CompilerGenerated]
	private void \u02B7\u02B2\u02B9\u02B7\u02B6\u02BF\u02B6\u02B2\u02B3\u02C1\u02BA(int \u02B7\u02B2\u02BD\u02B8\u02BC\u02B5\u02BC\u02C1\u02B9\u02B3\u02B2)
	{
		this.\u02BF\u02BE\u02BB\u02BB\u02B9\u02B7\u02BF\u02B8\u02B4\u02B4\u02B7();
	}

	private void OnEnable()
	{
		CheatManager.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.enabled = true;
		this.\u02C0\u02B2\u02B3\u02BB\u02BD\u02C0\u02B8\u02B9\u02B7\u02B5\u02BB();
	}

	private void Start()
	{
		this.\u02C0\u02B2\u02B3\u02BB\u02BD\u02C0\u02B8\u02B9\u02B7\u02B5\u02BB();
	}

	private void \u02C1\u02C1\u02BC\u02BA\u02B6\u02BB\u02B8\u02B8\u02B5\u02BD\u02C0()
	{
		if (CheatManager.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7 && this.\u02B8\u02BD\u02B8\u02BA\u02BE\u02B4\u02B5\u02B7\u02C0\u02B3\u02C0 != -1)
		{
			CheatManager.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.enabled = false;
			CheatManager.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BB\u02C1\u02BA\u02BA\u02B4\u02B9\u02B9\u02BF\u02BB\u02B4\u02BE(this.\u02B8\u02BD\u02B8\u02BA\u02BE\u02B4\u02B5\u02B7\u02C0\u02B3\u02C0);
			CheatManager.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BB\u02B3\u02B4\u02C1\u02B4\u02B4\u02C1\u02B8\u02B6\u02B8\u02B6(this.\u02B6\u02BD\u02B6\u02BA\u02B2\u02B2\u02B5\u02BC\u02BE\u02B5\u02B4);
			this.\u02B8\u02BD\u02B8\u02BA\u02BE\u02B4\u02B5\u02B7\u02C0\u02B3\u02C0 = -1;
			this.\u02B6\u02BD\u02B6\u02BA\u02B2\u02B2\u02B5\u02BC\u02BE\u02B5\u02B4 = -1;
		}
	}

	private void \u02B4\u02B7\u02BC\u02B9\u02B3\u02B9\u02B9\u02BE\u02C0\u02B3\u02B5()
	{
		if (CheatManager.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7 && this.\u02B8\u02BD\u02B8\u02BA\u02BE\u02B4\u02B5\u02B7\u02C0\u02B3\u02C0 != -1)
		{
			CheatManager.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.enabled = true;
			CheatManager.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BB\u02C1\u02BA\u02BA\u02B4\u02B9\u02B9\u02BF\u02BB\u02B4\u02BE(this.\u02B8\u02BD\u02B8\u02BA\u02BE\u02B4\u02B5\u02B7\u02C0\u02B3\u02C0);
			CheatManager.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BB\u02C1\u02BA\u02BA\u02B4\u02B9\u02B9\u02BF\u02BB\u02B4\u02BE(this.\u02B6\u02BD\u02B6\u02BA\u02B2\u02B2\u02B5\u02BC\u02BE\u02B5\u02B4);
			this.\u02B8\u02BD\u02B8\u02BA\u02BE\u02B4\u02B5\u02B7\u02C0\u02B3\u02C0 = -1;
			this.\u02B6\u02BD\u02B6\u02BA\u02B2\u02B2\u02B5\u02BC\u02BE\u02B5\u02B4 = -1;
		}
	}

	private void \u02BB\u02B7\u02B9\u02BD\u02BE\u02B8\u02BB\u02BA\u02B5\u02B8\u02B4()
	{
		if (CheatManager.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7 && this.\u02B8\u02BD\u02B8\u02BA\u02BE\u02B4\u02B5\u02B7\u02C0\u02B3\u02C0 != -1)
		{
			CheatManager.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.enabled = false;
			CheatManager.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BB\u02B3\u02B4\u02C1\u02B4\u02B4\u02C1\u02B8\u02B6\u02B8\u02B6(this.\u02B8\u02BD\u02B8\u02BA\u02BE\u02B4\u02B5\u02B7\u02C0\u02B3\u02C0);
			CheatManager.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BB\u02B3\u02B4\u02C1\u02B4\u02B4\u02C1\u02B8\u02B6\u02B8\u02B6(this.\u02B6\u02BD\u02B6\u02BA\u02B2\u02B2\u02B5\u02BC\u02BE\u02B5\u02B4);
			this.\u02B8\u02BD\u02B8\u02BA\u02BE\u02B4\u02B5\u02B7\u02C0\u02B3\u02C0 = -1;
			this.\u02B6\u02BD\u02B6\u02BA\u02B2\u02B2\u02B5\u02BC\u02BE\u02B5\u02B4 = -1;
		}
	}

	private void \u02C1\u02BB\u02BC\u02B4\u02C0\u02B2\u02C0\u02B3\u02B5\u02B8\u02BF()
	{
		SceneManager.LoadScene("Gem Size");
	}

	private void \u02BF\u02BA\u02BF\u02BE\u02B5\u02C1\u02BE\u02B7\u02B7\u02C0\u02B7()
	{
		if (CheatManager.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7 != null)
		{
			if (this.\u02B8\u02BD\u02B8\u02BA\u02BE\u02B4\u02B5\u02B7\u02C0\u02B3\u02C0 == -1)
			{
				this.\u02B8\u02BD\u02B8\u02BA\u02BE\u02B4\u02B5\u02B7\u02C0\u02B3\u02C0 = CheatManager.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BD\u02B4\u02BF\u02C0\u02BE\u02B3\u02BA\u02BF\u02BC\u02B9\u02B9("", new int[] { 4, 3 }, new CheatManager.\u02BC\u02BC\u02C1\u02B6\u02BA\u02B2\u02B4\u02BD\u02BF\u02B4\u02BC(this.\u02B6\u02B8\u02BA\u02BE\u02BB\u02C1\u02B2\u02B7\u02BD\u02BC\u02B2), null, true);
			}
			if (this.\u02B6\u02BD\u02B6\u02BA\u02B2\u02B2\u02B5\u02BC\u02BE\u02B5\u02B4 == -1)
			{
				CheatManager u02B7_u02B2_u02BA_u02B7_u02BB_u02B3_u02BE_u02B6_u02C1_u02C0_u02B = CheatManager.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7;
				string text = "charter";
				int[] array = new int[0];
				RuntimeHelpers.InitializeArray(array, fieldof(PrivateImplementationDetails.BBF15C918A7BDDEB11D20ACB14770D48B2091B8609BBC3464E415659C884E015).FieldHandle);
				this.\u02B6\u02BD\u02B6\u02BA\u02B2\u02B2\u02B5\u02BC\u02BE\u02B5\u02B4 = u02B7_u02B2_u02BA_u02B7_u02BB_u02B3_u02BE_u02B6_u02C1_u02C0_u02B.\u02BB\u02B7\u02B2\u02C0\u02B6\u02B2\u02B6\u02B2\u02BC\u02BD\u02BF(text, array, new CheatManager.\u02BC\u02BC\u02C1\u02B6\u02BA\u02B2\u02B4\u02BD\u02BF\u02B4\u02BC(this.\u02B7\u02B2\u02B9\u02B7\u02B6\u02BF\u02B6\u02B2\u02B3\u02C1\u02BA), null, true);
			}
		}
	}

	private void \u02BD\u02C0\u02BF\u02B6\u02BC\u02B9\u02BB\u02BD\u02B5\u02BC\u02BA()
	{
		if (CheatManager.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7 && this.\u02B8\u02BD\u02B8\u02BA\u02BE\u02B4\u02B5\u02B7\u02C0\u02B3\u02C0 != -1)
		{
			CheatManager.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.enabled = false;
			CheatManager.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BB\u02B3\u02B4\u02C1\u02B4\u02B4\u02C1\u02B8\u02B6\u02B8\u02B6(this.\u02B8\u02BD\u02B8\u02BA\u02BE\u02B4\u02B5\u02B7\u02C0\u02B3\u02C0);
			CheatManager.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BB\u02C1\u02BA\u02BA\u02B4\u02B9\u02B9\u02BF\u02BB\u02B4\u02BE(this.\u02B6\u02BD\u02B6\u02BA\u02B2\u02B2\u02B5\u02BC\u02BE\u02B5\u02B4);
			this.\u02B8\u02BD\u02B8\u02BA\u02BE\u02B4\u02B5\u02B7\u02C0\u02B3\u02C0 = -1;
			this.\u02B6\u02BD\u02B6\u02BA\u02B2\u02B2\u02B5\u02BC\u02BE\u02B5\u02B4 = -1;
		}
	}

	public GameObject \u02BC\u02BC\u02BD\u02BE\u02B4\u02BC\u02C1\u02B8\u02C1\u02BE\u02BE;

	public GameObject \u02BE\u02BD\u02C0\u02BF\u02B5\u02BA\u02BD\u02BC\u02C0\u02B2\u02BC;

	public Sprite \u02C0\u02B7\u02C1\u02BF\u02C1\u02B5\u02B8\u02B9\u02BB\u02B6\u02BC;

	public Sprite \u02BD\u02B4\u02B5\u02B6\u02B2\u02B2\u02BE\u02BD\u02BF\u02BA\u02BC;

	public Image \u02BC\u02C0\u02B7\u02B7\u02B5\u02B9\u02B9\u02C1\u02BB\u02B5\u02B3;

	public Image \u02B6\u02BB\u02BD\u02BA\u02BC\u02B2\u02B9\u02B4\u02B3\u02BA\u02B2;

	public Image \u02B2\u02B8\u02B7\u02BD\u02BF\u02C1\u02BC\u02B7\u02B8\u02B7\u02C0;

	private int \u02B8\u02BD\u02B8\u02BA\u02BE\u02B4\u02B5\u02B7\u02C0\u02B3\u02C0 = -1;

	private int \u02B6\u02BD\u02B6\u02BA\u02B2\u02B2\u02B5\u02BC\u02BE\u02B5\u02B4 = -1;
}
