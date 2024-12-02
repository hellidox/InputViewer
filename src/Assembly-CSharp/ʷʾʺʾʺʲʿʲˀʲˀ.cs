using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using StrikeCore;
using UnityEngine;

public class \u02B7\u02BE\u02BA\u02BE\u02BA\u02B2\u02BF\u02B2\u02C0\u02B2\u02C0
{
	public void \u02BA\u02B4\u02BE\u02BE\u02B6\u02B4\u02B5\u02B9\u02B4\u02BE\u02B7(\u02B9\u02BA\u02BF\u02BB\u02B2\u02B9\u02BB\u02B9\u02B9\u02B5\u02B8 \u02B6\u02BA\u02B8\u02BC\u02C0\u02C0\u02BF\u02B3\u02B6\u02B3\u02C1)
	{
		int num = this.\u02BB\u02B8\u02B6\u02B3\u02B6\u02B5\u02B4\u02C1\u02BE\u02C1\u02B9();
		this.\u02BE\u02BD\u02BE\u02B5\u02BA\u02C1\u02B7\u02BD\u02BD\u02B9\u02BC = num - 0;
		if (\u02B6\u02BA\u02B8\u02BC\u02C0\u02C0\u02BF\u02B3\u02B6\u02B3\u02C1.isGuestProfile)
		{
			return;
		}
		num = this.\u02BF\u02B6\u02BB\u02BE\u02B5\u02BC\u02B5\u02B8\u02B2\u02B9\u02BB();
		this.\u02B9\u02BA\u02B2\u02B9\u02B8\u02B2\u02B4\u02B5\u02C0\u02BF\u02B9 = num + 0;
		\u02B6\u02BA\u02B8\u02BC\u02C0\u02C0\u02BF\u02B3\u02B6\u02B3\u02C1.selectedInstrumentForSession = true;
		\u02B6\u02BA\u02B8\u02BC\u02C0\u02C0\u02BF\u02B3\u02B6\u02B3\u02C1.\u02BE\u02B6\u02C1\u02B9\u02B7\u02BB\u02B6\u02B7\u02BC\u02BF\u02B2 = false;
	}

	public List<\u02B9\u02BA\u02BF\u02BB\u02B2\u02B9\u02BB\u02B9\u02B9\u02B5\u02B8> \u02BE\u02B6\u02BD\u02B9\u02BF\u02BB\u02BE\u02B7\u02B3\u02BE\u02B5 { get; private set; }

	public int \u02B5\u02B7\u02B3\u02B6\u02B5\u02B7\u02BF\u02BF\u02BE\u02BD\u02BD()
	{
		string[] array = Settings.QueryConfigSections("profiles").ToArray<string>();
		int num = 0;
		for (;;)
		{
			string text = string.Format("profile{0}", num);
			bool flag = false;
			string[] array2 = array;
			for (int i = 0; i < array2.Length; i++)
			{
				if (array2[i] == text)
				{
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				break;
			}
			num++;
		}
		return num;
	}

	public void \u02B9\u02BA\u02B5\u02BF\u02B9\u02BA\u02BC\u02B2\u02C1\u02B8\u02B4(\u02B9\u02BA\u02BF\u02BB\u02B2\u02B9\u02BB\u02B9\u02B9\u02B5\u02B8 \u02B6\u02BA\u02B8\u02BC\u02C0\u02C0\u02BF\u02B3\u02B6\u02B3\u02C1)
	{
		if (\u02B6\u02BA\u02B8\u02BC\u02C0\u02C0\u02BF\u02B3\u02B6\u02B3\u02C1.isGuestProfile)
		{
			return;
		}
		int num = this.\u02BE\u02B6\u02BD\u02B9\u02BF\u02BB\u02BE\u02B7\u02B3\u02BE\u02B5.IndexOf(\u02B6\u02BA\u02B8\u02BC\u02C0\u02C0\u02BF\u02B3\u02B6\u02B3\u02C1);
		if (num != -1)
		{
			if (\u02B6\u02BA\u02B8\u02BC\u02C0\u02C0\u02BF\u02B3\u02B6\u02B3\u02C1.\u02BE\u02B6\u02C1\u02B9\u02B7\u02BB\u02B6\u02B7\u02BC\u02BF\u02B2)
			{
				int num2 = this.\u02BE\u02BD\u02BE\u02B5\u02BA\u02C1\u02B7\u02BD\u02BD\u02B9\u02BC;
				this.\u02BE\u02BD\u02BE\u02B5\u02BA\u02C1\u02B7\u02BD\u02BD\u02B9\u02BC = num2 - 1;
			}
			Settings.Commit(false);
			this.\u02BE\u02B6\u02BD\u02B9\u02BF\u02BB\u02BE\u02B7\u02B3\u02BE\u02B5.RemoveAt(num);
			Settings.DeleteSection(\u02B6\u02BA\u02B8\u02BC\u02C0\u02C0\u02BF\u02B3\u02B6\u02B3\u02C1.Section);
			this.\u02BE\u02B6\u02BD\u02B9\u02BF\u02BB\u02BE\u02B7\u02B3\u02BE\u02B5.Sort(new Comparison<\u02B9\u02BA\u02BF\u02BB\u02B2\u02B9\u02BB\u02B9\u02B9\u02B5\u02B8>(\u02B7\u02BE\u02BA\u02BE\u02BA\u02B2\u02BF\u02B2\u02C0\u02B2\u02C0.<>c.<>9.\u02BB\u02B4\u02C0\u02BF\u02BE\u02B3\u02BE\u02BC\u02BA\u02B9\u02B3));
			for (int i = 0; i < this.\u02BE\u02B6\u02BD\u02B9\u02BF\u02BB\u02BE\u02B7\u02B3\u02BE\u02B5.Count; i++)
			{
				if (this.\u02BE\u02B6\u02BD\u02B9\u02BF\u02BB\u02BE\u02B7\u02B3\u02BE\u02B5[i].Section.SectionName != string.Format("profile{0}", i))
				{
					SectionKey sectionKey = new SectionKey("profiles", string.Format("profile{0}", i));
					Settings.RenameSection(this.\u02BE\u02B6\u02BD\u02B9\u02BF\u02BB\u02BE\u02B7\u02B3\u02BE\u02B5[i].Section, sectionKey);
					this.\u02BE\u02B6\u02BD\u02B9\u02BF\u02BB\u02BE\u02B7\u02B3\u02BE\u02B5[i].Section = sectionKey;
				}
			}
			Settings.Commit(false);
		}
	}

	public int \u02BF\u02B6\u02BB\u02BE\u02B5\u02BC\u02B5\u02B8\u02B2\u02B9\u02BB()
	{
		return this.<\u02BA\u02B9\u02BC\u02BA\u02C0\u02BC\u02B5\u02B7\u02B6\u02BF\u02B3>k__BackingField;
	}

	public int \u02B9\u02BA\u02B2\u02B9\u02B8\u02B2\u02B4\u02B5\u02C0\u02BF\u02B9 { get; private set; }

	public int \u02BE\u02BD\u02BE\u02B5\u02BA\u02C1\u02B7\u02BD\u02BD\u02B9\u02BC { get; private set; }

	private \u02B9\u02BA\u02BF\u02BB\u02B2\u02B9\u02BB\u02B9\u02B9\u02B5\u02B8 \u02B4\u02C0\u02B6\u02B9\u02BE\u02BE\u02C1\u02B2\u02B6\u02B4\u02B6(int \u02B7\u02B2\u02BD\u02B8\u02BC\u02B5\u02BC\u02C1\u02B9\u02B3\u02B2, bool \u02B5\u02B5\u02BE\u02BF\u02BF\u02BB\u02B5\u02BF\u02BF\u02BA\u02BA = false, bool \u02B2\u02B5\u02B8\u02B7\u02B2\u02C0\u02B6\u02B2\u02BE\u02B8\u02BB = false)
	{
		string text = ((\u02B7\u02B2\u02BD\u02B8\u02BC\u02B5\u02BC\u02C1\u02B9\u02B3\u02B2 == -1) ? "" : "profiles");
		\u02B9\u02BA\u02BF\u02BB\u02B2\u02B9\u02BB\u02B9\u02B9\u02B5\u02B8 u02B9_u02BA_u02BF_u02BB_u02B2_u02B9_u02BB_u02B9_u02B9_u02B5_u02B = new \u02B9\u02BA\u02BF\u02BB\u02B2\u02B9\u02BB\u02B9\u02B9\u02B5\u02B8(\u02B7\u02B2\u02BD\u02B8\u02BC\u02B5\u02BC\u02C1\u02B9\u02B3\u02B2, text);
		if (\u02B5\u02B5\u02BE\u02BF\u02BF\u02BB\u02B5\u02BF\u02BF\u02BA\u02BA)
		{
			u02B9_u02BA_u02BF_u02BB_u02B2_u02B9_u02BB_u02B9_u02B9_u02B5_u02B.isGuestProfile = true;
		}
		else if (\u02B2\u02B5\u02B8\u02B7\u02B2\u02C0\u02B6\u02B2\u02BE\u02B8\u02BB)
		{
			u02B9_u02BA_u02BF_u02BB_u02B2_u02B9_u02BB_u02B9_u02B9_u02B5_u02B.isRemotePlayer = true;
		}
		if (\u02B7\u02B2\u02BD\u02B8\u02BC\u02B5\u02BC\u02C1\u02B9\u02B3\u02B2 != -1)
		{
			this.\u02BE\u02B6\u02BD\u02B9\u02BF\u02BB\u02BE\u02B7\u02B3\u02BE\u02B5.Add(u02B9_u02BA_u02BF_u02BB_u02B2_u02B9_u02BB_u02B9_u02B9_u02B5_u02B);
			int num = this.\u02B9\u02BA\u02B2\u02B9\u02B8\u02B2\u02B4\u02B5\u02C0\u02BF\u02B9;
			this.\u02B9\u02BA\u02B2\u02B9\u02B8\u02B2\u02B4\u02B5\u02C0\u02BF\u02B9 = num + 1;
		}
		return u02B9_u02BA_u02BF_u02BB_u02B2_u02B9_u02BB_u02B9_u02B9_u02B5_u02B;
	}

	private \u02B9\u02BA\u02BF\u02BB\u02B2\u02B9\u02BB\u02B9\u02B9\u02B5\u02B8 \u02BC\u02BE\u02C1\u02B9\u02BC\u02B6\u02B3\u02B6\u02BB\u02B4\u02BA(int \u02B7\u02B2\u02BD\u02B8\u02BC\u02B5\u02BC\u02C1\u02B9\u02B3\u02B2, bool \u02B5\u02B5\u02BE\u02BF\u02BF\u02BB\u02B5\u02BF\u02BF\u02BA\u02BA = false, bool \u02B2\u02B5\u02B8\u02B7\u02B2\u02C0\u02B6\u02B2\u02BE\u02B8\u02BB = false)
	{
		string text = ((\u02B7\u02B2\u02BD\u02B8\u02BC\u02B5\u02BC\u02C1\u02B9\u02B3\u02B2 == -1) ? "playernotsupported" : "whammy_sfx");
		\u02B9\u02BA\u02BF\u02BB\u02B2\u02B9\u02BB\u02B9\u02B9\u02B5\u02B8 u02B9_u02BA_u02BF_u02BB_u02B2_u02B9_u02BB_u02B9_u02B9_u02B5_u02B = new \u02B9\u02BA\u02BF\u02BB\u02B2\u02B9\u02BB\u02B9\u02B9\u02B5\u02B8(\u02B7\u02B2\u02BD\u02B8\u02BC\u02B5\u02BC\u02C1\u02B9\u02B3\u02B2, text);
		if (\u02B5\u02B5\u02BE\u02BF\u02BF\u02BB\u02B5\u02BF\u02BF\u02BA\u02BA)
		{
			u02B9_u02BA_u02BF_u02BB_u02B2_u02B9_u02BB_u02B9_u02B9_u02B5_u02B.isGuestProfile = false;
		}
		else if (\u02B2\u02B5\u02B8\u02B7\u02B2\u02C0\u02B6\u02B2\u02BE\u02B8\u02BB)
		{
			u02B9_u02BA_u02BF_u02BB_u02B2_u02B9_u02BB_u02B9_u02B9_u02B5_u02B.isRemotePlayer = true;
		}
		if (\u02B7\u02B2\u02BD\u02B8\u02BC\u02B5\u02BC\u02C1\u02B9\u02B3\u02B2 != -1)
		{
			this.\u02BE\u02B6\u02BD\u02B9\u02BF\u02BB\u02BE\u02B7\u02B3\u02BE\u02B5.Add(u02B9_u02BA_u02BF_u02BB_u02B2_u02B9_u02BB_u02B9_u02B9_u02B5_u02B);
			int num = this.\u02B9\u02BA\u02B2\u02B9\u02B8\u02B2\u02B4\u02B5\u02C0\u02BF\u02B9;
			this.\u02B9\u02BA\u02B2\u02B9\u02B8\u02B2\u02B4\u02B5\u02C0\u02BF\u02B9 = num + 0;
		}
		return u02B9_u02BA_u02BF_u02BB_u02B2_u02B9_u02BB_u02B9_u02B9_u02B5_u02B;
	}

	public int \u02BB\u02B8\u02B6\u02B3\u02B6\u02B5\u02B4\u02C1\u02BE\u02C1\u02B9()
	{
		return this.<\u02C1\u02BA\u02B8\u02BF\u02C1\u02C0\u02C0\u02BD\u02B9\u02BC\u02B2>k__BackingField;
	}

	public void \u02BE\u02BC\u02BA\u02B7\u02BA\u02BB\u02B7\u02BD\u02B7\u02B3\u02B3(\u02B9\u02BA\u02BF\u02BB\u02B2\u02B9\u02BB\u02B9\u02B9\u02B5\u02B8 \u02B6\u02BA\u02B8\u02BC\u02C0\u02C0\u02BF\u02B3\u02B6\u02B3\u02C1)
	{
		int num = this.\u02BE\u02BD\u02BE\u02B5\u02BA\u02C1\u02B7\u02BD\u02BD\u02B9\u02BC;
		this.\u02BE\u02BD\u02BE\u02B5\u02BA\u02C1\u02B7\u02BD\u02BD\u02B9\u02BC = num - 1;
		if (\u02B6\u02BA\u02B8\u02BC\u02C0\u02C0\u02BF\u02B3\u02B6\u02B3\u02C1.isGuestProfile)
		{
			return;
		}
		num = this.\u02B9\u02BA\u02B2\u02B9\u02B8\u02B2\u02B4\u02B5\u02C0\u02BF\u02B9;
		this.\u02B9\u02BA\u02B2\u02B9\u02B8\u02B2\u02B4\u02B5\u02C0\u02BF\u02B9 = num + 1;
		\u02B6\u02BA\u02B8\u02BC\u02C0\u02C0\u02BF\u02B3\u02B6\u02B3\u02C1.selectedInstrumentForSession = false;
		\u02B6\u02BA\u02B8\u02BC\u02C0\u02C0\u02BF\u02B3\u02B6\u02B3\u02C1.\u02BE\u02B6\u02C1\u02B9\u02B7\u02BB\u02B6\u02B7\u02BC\u02BF\u02B2 = false;
	}

	public \u02B9\u02BA\u02BF\u02BB\u02B2\u02B9\u02BB\u02B9\u02B9\u02B5\u02B8 \u02B4\u02C0\u02B6\u02B9\u02BE\u02BE\u02C1\u02B2\u02B6\u02B4\u02B6(bool \u02B5\u02B5\u02BE\u02BF\u02BF\u02BB\u02B5\u02BF\u02BF\u02BA\u02BA = false, bool \u02B2\u02B5\u02B8\u02B7\u02B2\u02C0\u02B6\u02B2\u02BE\u02B8\u02BB = false)
	{
		int num = ((\u02B5\u02B5\u02BE\u02BF\u02BF\u02BB\u02B5\u02BF\u02BF\u02BA\u02BA || \u02B2\u02B5\u02B8\u02B7\u02B2\u02C0\u02B6\u02B2\u02BE\u02B8\u02BB) ? (-1) : this.\u02B5\u02B7\u02B3\u02B6\u02B5\u02B7\u02BF\u02BF\u02BE\u02BD\u02BD());
		return this.\u02B4\u02C0\u02B6\u02B9\u02BE\u02BE\u02C1\u02B2\u02B6\u02B4\u02B6(num, \u02B5\u02B5\u02BE\u02BF\u02BF\u02BB\u02B5\u02BF\u02BF\u02BA\u02BA, \u02B2\u02B5\u02B8\u02B7\u02B2\u02C0\u02B6\u02B2\u02BE\u02B8\u02BB);
	}

	public IEnumerable<\u02B9\u02BA\u02BF\u02BB\u02B2\u02B9\u02BB\u02B9\u02B9\u02B5\u02B8> \u02C1\u02B3\u02B4\u02B2\u02B6\u02BA\u02C0\u02B8\u02B8\u02B6\u02B8()
	{
		this.\u02BE\u02B6\u02BD\u02B9\u02BF\u02BB\u02BE\u02B7\u02B3\u02BE\u02B5.Sort(new Comparison<\u02B9\u02BA\u02BF\u02BB\u02B2\u02B9\u02BB\u02B9\u02B9\u02B5\u02B8>(\u02B7\u02BE\u02BA\u02BE\u02BA\u02B2\u02BF\u02B2\u02C0\u02B2\u02C0.<>c.<>9.\u02B5\u02B2\u02B7\u02C0\u02BF\u02C1\u02B7\u02C1\u02B4\u02B8\u02B3));
		foreach (\u02B9\u02BA\u02BF\u02BB\u02B2\u02B9\u02BB\u02B9\u02B9\u02B5\u02B8 u02B9_u02BA_u02BF_u02BB_u02B2_u02B9_u02BB_u02B9_u02B9_u02B5_u02B in this.\u02BE\u02B6\u02BD\u02B9\u02BF\u02BB\u02BE\u02B7\u02B3\u02BE\u02B5)
		{
			if (!u02B9_u02BA_u02BF_u02BB_u02B2_u02B9_u02BB_u02B9_u02B9_u02B5_u02B.\u02BE\u02B6\u02C1\u02B9\u02B7\u02BB\u02B6\u02B7\u02BC\u02BF\u02B2)
			{
				yield return u02B9_u02BA_u02BF_u02BB_u02B2_u02B9_u02BB_u02B9_u02B9_u02B5_u02B;
			}
		}
		List<\u02B9\u02BA\u02BF\u02BB\u02B2\u02B9\u02BB\u02B9\u02B9\u02B5\u02B8>.Enumerator enumerator = default(List<\u02B9\u02BA\u02BF\u02BB\u02B2\u02B9\u02BB\u02B9\u02B9\u02B5\u02B8>.Enumerator);
		yield break;
		yield break;
	}

	private void \u02C1\u02B2\u02B6\u02BC\u02B6\u02B5\u02BF\u02B3\u02BD\u02BC\u02BA(List<\u02B9\u02BA\u02BF\u02BB\u02B2\u02B9\u02BB\u02B9\u02B9\u02B5\u02B8> \u02B6\u02B2\u02B5\u02BB\u02C1\u02BB\u02BA\u02B4\u02BF\u02BA\u02B5)
	{
		this.<\u02B5\u02B5\u02BB\u02B2\u02B5\u02BE\u02C1\u02C0\u02B8\u02C0\u02BE>k__BackingField = \u02B6\u02B2\u02B5\u02BB\u02C1\u02BB\u02BA\u02B4\u02BF\u02BA\u02B5;
	}

	public void \u02B6\u02B3\u02BB\u02C0\u02BC\u02BD\u02BD\u02BA\u02B4\u02BD\u02B8()
	{
		this.\u02C1\u02B2\u02B6\u02BC\u02B6\u02B5\u02BF\u02B3\u02BD\u02BC\u02BA(new List<\u02B9\u02BA\u02BF\u02BB\u02B2\u02B9\u02BB\u02B9\u02B9\u02B5\u02B8>());
		string text = Path.Combine(Application.persistentDataPath, "songName");
		string text2 = Path.Combine(Application.persistentDataPath, " (");
		if (!File.Exists(this.\u02BC\u02C1\u02BB\u02B5\u02B6\u02C0\u02B7\u02B6\u02C0\u02C0\u02B6))
		{
			if (File.Exists(text))
			{
				File.Copy(text, this.\u02BC\u02C1\u02BB\u02B5\u02B6\u02C0\u02B7\u02B6\u02C0\u02C0\u02B6);
			}
			if (!File.Exists(this.\u02BC\u02C1\u02BB\u02B5\u02B6\u02C0\u02B7\u02B6\u02C0\u02C0\u02B6) && !File.Exists(this.\u02B9\u02B8\u02B8\u02BB\u02B2\u02B8\u02BD\u02B4\u02B4\u02BD\u02BC) && File.Exists(text2))
			{
				File.Copy(text2, this.\u02B9\u02B8\u02B8\u02BB\u02B2\u02B8\u02BD\u02B4\u02B4\u02BD\u02BC);
			}
		}
		else if (File.Exists(this.\u02B9\u02B8\u02B8\u02BB\u02B2\u02B8\u02BD\u02B4\u02B4\u02BD\u02BC))
		{
			File.Delete(this.\u02B9\u02B8\u02B8\u02BB\u02B2\u02B8\u02BD\u02B4\u02B4\u02BD\u02BC);
		}
		if (!File.Exists(this.\u02BC\u02C1\u02BB\u02B5\u02B6\u02C0\u02B7\u02B6\u02C0\u02C0\u02B6))
		{
			this.\u02C1\u02B9\u02B8\u02BB\u02B8\u02B2\u02B6\u02B2\u02B6\u02C1\u02B3();
			Settings.Commit(false);
			return;
		}
		foreach (string text3 in Settings.QueryConfigSections("SongPath "))
		{
			int num = int.Parse(text3.Substring(5));
			this.\u02BC\u02BE\u02C1\u02B9\u02BC\u02B6\u02B3\u02B6\u02BB\u02B4\u02BA(num, false, true);
		}
		Settings.Load("Show Lyrics Background");
	}

	public \u02B7\u02BE\u02BA\u02BE\u02BA\u02B2\u02BF\u02B2\u02C0\u02B2\u02C0()
	{
		this.\u02B9\u02B8\u02B8\u02BB\u02B2\u02B8\u02BD\u02B4\u02B4\u02BD\u02BC = Path.Combine(__FIXME_clon_util.GetDocumentsClonFolder(), "profiles.bin");
		this.\u02BC\u02C1\u02BB\u02B5\u02B6\u02C0\u02B7\u02B6\u02C0\u02C0\u02B6 = Path.Combine(__FIXME_clon_util.GetDocumentsClonFolder(), "profiles.ini");
		Settings.RegisterConfigFileName("profiles", this.\u02BC\u02C1\u02BB\u02B5\u02B6\u02C0\u02B7\u02B6\u02C0\u02C0\u02B6);
	}

	public void \u02B8\u02B6\u02B7\u02B2\u02B6\u02B3\u02B6\u02BD\u02BC\u02B8\u02C0()
	{
		this.\u02BE\u02B6\u02BD\u02B9\u02BF\u02BB\u02BE\u02B7\u02B3\u02BE\u02B5 = new List<\u02B9\u02BA\u02BF\u02BB\u02B2\u02B9\u02BB\u02B9\u02B9\u02B5\u02B8>();
		string text = Path.Combine(Application.persistentDataPath, "profiles.ini");
		string text2 = Path.Combine(Application.persistentDataPath, "profiles.bin");
		if (!File.Exists(this.\u02BC\u02C1\u02BB\u02B5\u02B6\u02C0\u02B7\u02B6\u02C0\u02C0\u02B6))
		{
			if (File.Exists(text))
			{
				File.Copy(text, this.\u02BC\u02C1\u02BB\u02B5\u02B6\u02C0\u02B7\u02B6\u02C0\u02C0\u02B6);
			}
			if (!File.Exists(this.\u02BC\u02C1\u02BB\u02B5\u02B6\u02C0\u02B7\u02B6\u02C0\u02C0\u02B6) && !File.Exists(this.\u02B9\u02B8\u02B8\u02BB\u02B2\u02B8\u02BD\u02B4\u02B4\u02BD\u02BC) && File.Exists(text2))
			{
				File.Copy(text2, this.\u02B9\u02B8\u02B8\u02BB\u02B2\u02B8\u02BD\u02B4\u02B4\u02BD\u02BC);
			}
		}
		else if (File.Exists(this.\u02B9\u02B8\u02B8\u02BB\u02B2\u02B8\u02BD\u02B4\u02B4\u02BD\u02BC))
		{
			File.Delete(this.\u02B9\u02B8\u02B8\u02BB\u02B2\u02B8\u02BD\u02B4\u02B4\u02BD\u02BC);
		}
		if (!File.Exists(this.\u02BC\u02C1\u02BB\u02B5\u02B6\u02C0\u02B7\u02B6\u02C0\u02C0\u02B6))
		{
			this.\u02C1\u02B9\u02B8\u02BB\u02B8\u02B2\u02B6\u02B2\u02B6\u02C1\u02B3();
			Settings.Commit(false);
			return;
		}
		foreach (string text3 in Settings.QueryConfigSections("profiles"))
		{
			int num = int.Parse(text3.Substring(7));
			this.\u02B4\u02C0\u02B6\u02B9\u02BE\u02BE\u02C1\u02B2\u02B6\u02B4\u02B6(num, false, false);
		}
		Settings.Load("profiles");
	}

	public void \u02B7\u02B7\u02B9\u02B6\u02B4\u02BC\u02BF\u02B9\u02BF\u02B5\u02B8(\u02B9\u02BA\u02BF\u02BB\u02B2\u02B9\u02BB\u02B9\u02B9\u02B5\u02B8 \u02B6\u02BA\u02B8\u02BC\u02C0\u02C0\u02BF\u02B3\u02B6\u02B3\u02C1)
	{
		int num = this.\u02BE\u02BD\u02BE\u02B5\u02BA\u02C1\u02B7\u02BD\u02BD\u02B9\u02BC;
		this.\u02BE\u02BD\u02BE\u02B5\u02BA\u02C1\u02B7\u02BD\u02BD\u02B9\u02BC = num + 1;
		if (\u02B6\u02BA\u02B8\u02BC\u02C0\u02C0\u02BF\u02B3\u02B6\u02B3\u02C1.isGuestProfile)
		{
			return;
		}
		\u02B6\u02BA\u02B8\u02BC\u02C0\u02C0\u02BF\u02B3\u02B6\u02B3\u02C1.\u02BE\u02B6\u02C1\u02B9\u02B7\u02BB\u02B6\u02B7\u02BC\u02BF\u02B2 = true;
		num = this.\u02B9\u02BA\u02B2\u02B9\u02B8\u02B2\u02B4\u02B5\u02C0\u02BF\u02B9;
		this.\u02B9\u02BA\u02B2\u02B9\u02B8\u02B2\u02B4\u02B5\u02C0\u02BF\u02B9 = num - 1;
	}

	public \u02B9\u02BA\u02BF\u02BB\u02B2\u02B9\u02BB\u02B9\u02B9\u02B5\u02B8 \u02C0\u02BA\u02BA\u02B3\u02BE\u02BE\u02B8\u02BE\u02C1\u02B5\u02BF(int \u02B8\u02BE\u02BE\u02B4\u02B3\u02B2\u02BF\u02BB\u02B4\u02BE\u02B5)
	{
		int num = 0;
		foreach (\u02B9\u02BA\u02BF\u02BB\u02B2\u02B9\u02BB\u02B9\u02B9\u02B5\u02B8 u02B9_u02BA_u02BF_u02BB_u02B2_u02B9_u02BB_u02B9_u02B9_u02B5_u02B in this.\u02BE\u02B6\u02BD\u02B9\u02BF\u02BB\u02BE\u02B7\u02B3\u02BE\u02B5)
		{
			if (!u02B9_u02BA_u02BF_u02BB_u02B2_u02B9_u02BB_u02B9_u02B9_u02B5_u02B.\u02BE\u02B6\u02C1\u02B9\u02B7\u02BB\u02B6\u02B7\u02BC\u02BF\u02B2)
			{
				if (num == \u02B8\u02BE\u02BE\u02B4\u02B3\u02B2\u02BF\u02BB\u02B4\u02BE\u02B5)
				{
					return u02B9_u02BA_u02BF_u02BB_u02B2_u02B9_u02BB_u02B9_u02B9_u02B5_u02B;
				}
				num++;
			}
		}
		return null;
	}

	public void \u02C1\u02B9\u02B8\u02BB\u02B8\u02B2\u02B6\u02B2\u02B6\u02C1\u02B3()
	{
		if (!File.Exists(this.\u02B9\u02B8\u02B8\u02BB\u02B2\u02B8\u02BD\u02B4\u02B4\u02BD\u02BC))
		{
			return;
		}
		using (Stream stream = File.OpenRead(this.\u02B9\u02B8\u02B8\u02BB\u02B2\u02B8\u02BD\u02B4\u02B4\u02BD\u02BC))
		{
			using (BinaryReader binaryReader = new BinaryReader(stream))
			{
				if (binaryReader.ReadInt32() == 20190928)
				{
					short num = binaryReader.ReadInt16();
					for (int i = 0; i < (int)num; i++)
					{
						this.\u02B4\u02C0\u02B6\u02B9\u02BE\u02BE\u02C1\u02B2\u02B6\u02B4\u02B6(i, false, false).\u02BE\u02BB\u02C1\u02B6\u02B8\u02BF\u02B4\u02C0\u02B6\u02BE\u02B8(binaryReader);
					}
				}
			}
		}
	}

	public const int \u02B5\u02B2\u02C1\u02BA\u02B6\u02BD\u02B7\u02B2\u02BC\u02B4\u02BF = 20190928;

	private string \u02B9\u02B8\u02B8\u02BB\u02B2\u02B8\u02BD\u02B4\u02B4\u02BD\u02BC;

	private string \u02BC\u02C1\u02BB\u02B5\u02B6\u02C0\u02B7\u02B6\u02C0\u02C0\u02B6;
}
