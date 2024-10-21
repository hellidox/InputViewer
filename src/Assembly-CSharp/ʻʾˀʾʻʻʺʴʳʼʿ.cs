using System;
using System.Collections.Generic;
using System.IO;
using IniParser;
using IniParser.Model;
using UnityEngine;

// Token: 0x02000252 RID: 594
public class \u02BB\u02BE\u02C0\u02BE\u02BB\u02BB\u02BA\u02B4\u02B3\u02BC\u02BF : \u02BE\u02B6\u02BA\u02B3\u02BB\u02B9\u02B3\u02B2\u02B4\u02C1\u02B4
{
	// Token: 0x06001990 RID: 6544 RVA: 0x000C5DE8 File Offset: 0x000C3FE8
	private bool \u02BC\u02B8\u02C1\u02BD\u02B5\u02B3\u02BB\u02C0\u02B4\u02B5\u02B9(Stream \u02C1\u02BB\u02BE\u02B6\u02BA\u02BC\u02B9\u02B2\u02B3\u02B5\u02B2, out IDictionary<string, \u02B6\u02BC\u02B5\u02BE\u02B3\u02BF\u02BB\u02B6\u02BE\u02BE\u02B7> \u02BC\u02B4\u02B9\u02BA\u02B2\u02B6\u02BA\u02B5\u02BB\u02B3\u02BC)
	{
		bool flag2;
		using (StreamReader streamReader = new StreamReader(\u02C1\u02BB\u02BE\u02B6\u02BA\u02BC\u02B9\u02B2\u02B3\u02B5\u02B2))
		{
			bool flag = false;
			Dictionary<string, \u02B6\u02BC\u02B5\u02BE\u02B3\u02BF\u02BB\u02B6\u02BE\u02BE\u02B7> dictionary = new Dictionary<string, \u02B6\u02BC\u02B5\u02BE\u02B3\u02BF\u02BB\u02B6\u02BE\u02BE\u02B7>();
			foreach (SectionData sectionData in new FileIniDataParser().ReadData(streamReader).Sections)
			{
				KeyDataCollection keys = sectionData.Keys;
				Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
				foreach (KeyData keyData in keys)
				{
					dictionary2.Add(keyData.KeyName, keyData.Value);
				}
				dictionary.Add(sectionData.SectionName, new \u02B6\u02BC\u02B5\u02BE\u02B3\u02BF\u02BB\u02B6\u02BE\u02BE\u02B7
				{
					\u02BB\u02BA\u02BF\u02B9\u02B9\u02BA\u02B7\u02B5\u02B6\u02BD\u02BF = sectionData.SectionName,
					\u02C1\u02B6\u02B3\u02BD\u02B4\u02BC\u02BA\u02B3\u02B5\u02B5\u02C0 = dictionary2
				});
			}
			\u02BC\u02B4\u02B9\u02BA\u02B2\u02B6\u02BA\u02B5\u02BB\u02B3\u02BC = dictionary;
			flag2 = flag;
		}
		return flag2;
	}

	// Token: 0x06001991 RID: 6545 RVA: 0x000C5EEC File Offset: 0x000C40EC
	public bool \u02BC\u02B8\u02C1\u02BD\u02B5\u02B3\u02BB\u02C0\u02B4\u02B5\u02B9(out IDictionary<string, \u02B6\u02BC\u02B5\u02BE\u02B3\u02BF\u02BB\u02B6\u02BE\u02BE\u02B7> \u02BC\u02B4\u02B9\u02BA\u02B2\u02B6\u02BA\u02B5\u02BB\u02B3\u02BC)
	{
		if (File.Exists(this.\u02B7\u02B2\u02B2\u02BB\u02BB\u02B4\u02B6\u02B3\u02C1\u02BF\u02BC))
		{
			using (FileStream fileStream = File.OpenRead(this.\u02B7\u02B2\u02B2\u02BB\u02BB\u02B4\u02B6\u02B3\u02C1\u02BF\u02BC))
			{
				return this.\u02BC\u02B8\u02C1\u02BD\u02B5\u02B3\u02BB\u02C0\u02B4\u02B5\u02B9(fileStream, out \u02BC\u02B4\u02B9\u02BA\u02B2\u02B6\u02BA\u02B5\u02BB\u02B3\u02BC);
			}
		}
		TextAsset textAsset = Resources.Load<TextAsset>(this.\u02BF\u02BC\u02B8\u02BB\u02B9\u02BA\u02BB\u02B5\u02BE\u02B9\u02B3);
		return this.\u02BC\u02B8\u02C1\u02BD\u02B5\u02B3\u02BB\u02C0\u02B4\u02B5\u02B9(textAsset.text, out \u02BC\u02B4\u02B9\u02BA\u02B2\u02B6\u02BA\u02B5\u02BB\u02B3\u02BC);
	}

	// Token: 0x17000289 RID: 649
	// (get) Token: 0x06001992 RID: 6546 RVA: 0x000135C2 File Offset: 0x000117C2
	public string \u02BF\u02BC\u02B8\u02BB\u02B9\u02BA\u02BB\u02B5\u02BE\u02B9\u02B3
	{
		get
		{
			return this.\u02C0\u02C0\u02C0\u02BE\u02B3\u02B7\u02B9\u02BA\u02C0\u02B6\u02B6;
		}
	}

	// Token: 0x17000288 RID: 648
	// (get) Token: 0x06001993 RID: 6547 RVA: 0x000135CA File Offset: 0x000117CA
	public string \u02B7\u02B2\u02B2\u02BB\u02BB\u02B4\u02B6\u02B3\u02C1\u02BF\u02BC
	{
		get
		{
			return this.\u02C0\u02B7\u02B7\u02B4\u02BD\u02B2\u02BD\u02B3\u02BF\u02B4\u02B7;
		}
	}

	// Token: 0x06001994 RID: 6548 RVA: 0x000135D2 File Offset: 0x000117D2
	public \u02BB\u02BE\u02C0\u02BE\u02BB\u02BB\u02BA\u02B4\u02B3\u02BC\u02BF(string \u02C0\u02B7\u02B4\u02BA\u02B9\u02C1\u02B6\u02B9\u02BA\u02B7\u02BE, string \u02B7\u02BF\u02C0\u02B9\u02B4\u02B6\u02BE\u02B5\u02B2\u02BE\u02B3)
	{
		this.\u02C0\u02C0\u02C0\u02BE\u02B3\u02B7\u02B9\u02BA\u02C0\u02B6\u02B6 = \u02B7\u02BF\u02C0\u02B9\u02B4\u02B6\u02BE\u02B5\u02B2\u02BE\u02B3;
		this.\u02C0\u02B7\u02B7\u02B4\u02BD\u02B2\u02BD\u02B3\u02BF\u02B4\u02B7 = \u02C0\u02B7\u02B4\u02BA\u02B9\u02C1\u02B6\u02B9\u02BA\u02B7\u02BE;
	}

	// Token: 0x06001995 RID: 6549 RVA: 0x000C5F54 File Offset: 0x000C4154
	private bool \u02BC\u02B8\u02C1\u02BD\u02B5\u02B3\u02BB\u02C0\u02B4\u02B5\u02B9(string \u02C0\u02BB\u02BE\u02BE\u02C0\u02B4\u02B3\u02BB\u02B6\u02BA\u02BF, out IDictionary<string, \u02B6\u02BC\u02B5\u02BE\u02B3\u02BF\u02BB\u02B6\u02BE\u02BE\u02B7> \u02BC\u02B4\u02B9\u02BA\u02B2\u02B6\u02BA\u02B5\u02BB\u02B3\u02BC)
	{
		bool flag;
		using (MemoryStream memoryStream = new MemoryStream())
		{
			using (StreamWriter streamWriter = new StreamWriter(memoryStream))
			{
				streamWriter.Write(\u02C0\u02BB\u02BE\u02BE\u02C0\u02B4\u02B3\u02BB\u02B6\u02BA\u02BF);
				streamWriter.Flush();
				memoryStream.Position = 0L;
				flag = this.\u02BC\u02B8\u02C1\u02BD\u02B5\u02B3\u02BB\u02C0\u02B4\u02B5\u02B9(memoryStream, out \u02BC\u02B4\u02B9\u02BA\u02B2\u02B6\u02BA\u02B5\u02BB\u02B3\u02BC);
			}
		}
		return flag;
	}

	// Token: 0x04001233 RID: 4659
	private string \u02C0\u02B7\u02B7\u02B4\u02BD\u02B2\u02BD\u02B3\u02BF\u02B4\u02B7;

	// Token: 0x04001234 RID: 4660
	private string \u02C0\u02C0\u02C0\u02BE\u02B3\u02B7\u02B9\u02BA\u02C0\u02B6\u02B6;
}
