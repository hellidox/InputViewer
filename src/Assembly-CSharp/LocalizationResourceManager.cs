using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using UnityEngine;

public class LocalizationResourceManager
{
	public static \u02B6\u02BC\u02B5\u02BE\u02B3\u02BF\u02BB\u02B6\u02BE\u02BE\u02B7 \u02B7\u02B8\u02BA\u02B8\u02B6\u02BE\u02B4\u02B2\u02B9\u02B4\u02BB { get; } = new \u02B6\u02BC\u02B5\u02BE\u02B3\u02BF\u02BB\u02B6\u02BE\u02BE\u02B7
	{
		\u02C1\u02B6\u02B3\u02BD\u02B4\u02BC\u02BA\u02B3\u02B5\u02B5\u02C0 = new Dictionary<string, string>
		{
			{ "name", "<Unfound>" },
			{ "rule", "n != 1 ? 'other' : 'one'" }
		}
	};

	public bool \u02BF\u02BF\u02B3\u02B5\u02BE\u02BD\u02BE\u02B5\u02C0\u02B4\u02B3
	{
		get
		{
			return this._languageResourceNode != null;
		}
	}

	public Dictionary<string, string> \u02B5\u02BC\u02BF\u02B3\u02B9\u02BB\u02C0\u02BF\u02C1\u02B7\u02B3()
	{
		if (this.\u02BF\u02B7\u02BE\u02B2\u02BD\u02BF\u02BF\u02BE\u02BB\u02B7\u02BE == null)
		{
			this.\u02BF\u02B7\u02BE\u02B2\u02BD\u02BF\u02BF\u02BE\u02BB\u02B7\u02BE = this.\u02BC\u02BF\u02B2\u02B4\u02B6\u02BE\u02B4\u02B9\u02BA\u02B3\u02B5.ToDictionary(new Func<KeyValuePair<string, \u02B6\u02BC\u02B5\u02BE\u02B3\u02BF\u02BB\u02B6\u02BE\u02BE\u02B7>, string>(LocalizationResourceManager.<>c.<>9.\u02BE\u02B8\u02B7\u02C1\u02BC\u02BF\u02B4\u02B3\u02C0\u02BE\u02B9), new Func<KeyValuePair<string, \u02B6\u02BC\u02B5\u02BE\u02B3\u02BF\u02BB\u02B6\u02BE\u02BE\u02B7>, string>(LocalizationResourceManager.<>c.<>9.\u02B9\u02BB\u02B9\u02BE\u02B5\u02B2\u02BF\u02BF\u02BE\u02B6\u02BB));
		}
		return this.\u02BF\u02B7\u02BE\u02B2\u02BD\u02BF\u02BF\u02BE\u02BB\u02B7\u02BE;
	}

	public bool \u02B6\u02BE\u02C0\u02B3\u02C1\u02B8\u02BE\u02B9\u02BD\u02BE\u02BF()
	{
		return this._languageResourceNode != null;
	}

	public bool \u02C1\u02B9\u02BA\u02BB\u02B8\u02BB\u02B5\u02C0\u02BA\u02B5\u02BD<T>(string \u02BB\u02B5\u02BC\u02BD\u02B2\u02BE\u02BE\u02B5\u02BD\u02B6\u02B4, string \u02B8\u02BF\u02BF\u02BF\u02BF\u02B6\u02BF\u02BC\u02BA\u02BD\u02BE, \u02B5\u02B4\u02C1\u02BA\u02C1\u02BF\u02B9\u02C0\u02C1\u02B6\u02BA? \u02BF\u02B5\u02B6\u02BE\u02B3\u02BD\u02BE\u02BF\u02B6\u02B5\u02B6, bool \u02BF\u02BB\u02C0\u02BA\u02BF\u02BD\u02BD\u02BE\u02BB\u02BC\u02B5) where T : \u02BE\u02BF\u02B6\u02BC\u02BC\u02B9\u02B5\u02B3\u02B8\u02C0\u02B8, new()
	{
		this.\u02B7\u02BA\u02BC\u02BD\u02B4\u02BF\u02B6\u02C0\u02B8\u02B7\u02BA = \u02BB\u02B5\u02BC\u02BD\u02B2\u02BE\u02BE\u02B5\u02BD\u02B6\u02B4;
		bool flag = !string.IsNullOrWhiteSpace(\u02B8\u02BF\u02BF\u02BF\u02BF\u02B6\u02BF\u02BC\u02BA\u02BD\u02BE);
		if (flag)
		{
			T t = new T();
			TranslationNode translationNode;
			t.\u02B2\u02BB\u02B4\u02B8\u02BC\u02C1\u02B8\u02B5\u02B9\u02B9\u02B4(\u02B8\u02BF\u02BF\u02BF\u02BF\u02B6\u02BF\u02BC\u02BA\u02BD\u02BE, \u02BF\u02B5\u02B6\u02BE\u02B3\u02BD\u02BE\u02BF\u02B6\u02B5\u02B6, out translationNode, \u02BF\u02BB\u02C0\u02BA\u02BF\u02BD\u02BD\u02BE\u02BB\u02BC\u02B5);
			if (flag = translationNode != null)
			{
				this._languageResourceNode = translationNode;
			}
		}
		return flag;
	}

	private static void \u02C1\u02C1\u02BD\u02BA\u02C0\u02B4\u02B6\u02BF\u02BD\u02B5\u02B9(string \u02C0\u02BC\u02BE\u02BE\u02B8\u02C0\u02B2\u02B2\u02B7\u02B2\u02B3, Dictionary<\u02BA\u02BE\u02B5\u02BF\u02BE\u02BE\u02B9\u02C1\u02B2\u02BB\u02C0, string> \u02BA\u02B6\u02B3\u02B5\u02BD\u02C1\u02B3\u02BB\u02B6\u02BF\u02B2)
	{
		if (\u02BA\u02B6\u02B3\u02B5\u02BD\u02C1\u02B3\u02BB\u02B6\u02BF\u02B2.Count > 1)
		{
			Debug.LogWarning("Inappropriate method call. String resource '" + \u02C0\u02BC\u02BE\u02BE\u02B8\u02C0\u02B2\u02B2\u02B7\u02B2\u02B3 + "' has plural forms. Specify plural.");
		}
	}

	private bool \u02C1\u02C0\u02BC\u02B5\u02BF\u02BB\u02B8\u02BA\u02BA\u02C1\u02C0(string \u02BB\u02C0\u02B7\u02BD\u02BD\u02B2\u02B5\u02B5\u02BB\u02BB\u02BF)
	{
		bool flag = this._languageResourceNode.Resources != null;
		if (!flag)
		{
			Debug.LogWarning(string.Format("Language resources '{0}' been accessed before reading in localization resources. Localization resources may have failed to load.", \u02BB\u02C0\u02B7\u02BD\u02BD\u02B2\u02B5\u02B5\u02BB\u02BB\u02BF));
		}
		return flag;
	}

	public bool \u02B7\u02BD\u02B9\u02BF\u02B5\u02B2\u02BA\u02B7\u02BF\u02BE\u02BE()
	{
		return this._languageResourceNode != null;
	}

	private static void \u02B6\u02C0\u02B9\u02C0\u02B8\u02B9\u02BA\u02B5\u02BE\u02B4\u02BF(string \u02C0\u02BC\u02BE\u02BE\u02B8\u02C0\u02B2\u02B2\u02B7\u02B2\u02B3, LocalizationResourceManager \u02C0\u02B9\u02BB\u02BE\u02B6\u02C1\u02B6\u02B7\u02B6\u02BA\u02B2)
	{
		string text = \u02C0\u02BC\u02BE\u02BE\u02B8\u02C0\u02B2\u02B2\u02B7\u02B2\u02B3 + "Display" + \u02C0\u02B9\u02BB\u02BE\u02B6\u02C1\u02B6\u02B7\u02B6\u02BA\u02B2.\u02B7\u02BA\u02BC\u02BD\u02B4\u02BF\u02B6\u02C0\u02B8\u02B7\u02BA;
		int hashCode = text.GetHashCode();
		if (!\u02C0\u02B9\u02BB\u02BE\u02B6\u02C1\u02B6\u02B7\u02B6\u02BA\u02B2.\u02B9\u02B7\u02B2\u02B6\u02BA\u02BB\u02B6\u02BD\u02B4\u02B3\u02B4.Contains(hashCode))
		{
			Debug.LogWarning("</color>" + text);
			\u02C0\u02B9\u02BB\u02BE\u02B6\u02C1\u02B6\u02B7\u02B6\u02BA\u02B2.\u02B9\u02B7\u02B2\u02B6\u02BA\u02BB\u02B6\u02BD\u02B4\u02B3\u02B4.Add(hashCode);
		}
	}

	public string \u02B7\u02BA\u02BC\u02BD\u02B4\u02BF\u02B6\u02C0\u02B8\u02B7\u02BA { get; private set; }

	public string \u02B2\u02B5\u02C1\u02B4\u02C0\u02B4\u02BE\u02BE\u02B6\u02BE\u02B7(string \u02BA\u02B2\u02BA\u02BB\u02BE\u02B7\u02BB\u02C0\u02B4\u02B6\u02C1, string \u02B8\u02BB\u02B6\u02C0\u02BD\u02C0\u02BA\u02B4\u02C1\u02B5\u02B9 = null)
	{
		string text = \u02B8\u02BB\u02B6\u02C0\u02BD\u02C0\u02BA\u02B4\u02C1\u02B5\u02B9 ?? \u02BA\u02B2\u02BA\u02BB\u02BE\u02B7\u02BB\u02C0\u02B4\u02B6\u02C1;
		if (!string.IsNullOrWhiteSpace(\u02BA\u02B2\u02BA\u02BB\u02BE\u02B7\u02BB\u02C0\u02B4\u02B6\u02C1) && this.\u02C1\u02C0\u02BC\u02B5\u02BF\u02BB\u02B8\u02BA\u02BA\u02C1\u02C0(\u02BA\u02B2\u02BA\u02BB\u02BE\u02B7\u02BB\u02C0\u02B4\u02B6\u02C1))
		{
			Dictionary<\u02BA\u02BE\u02B5\u02BF\u02BE\u02BE\u02B9\u02C1\u02B2\u02BB\u02C0, string> dictionary;
			if (this._languageResourceNode.\u02B5\u02B8\u02BB\u02BC\u02B4\u02B2\u02B8\u02B8\u02B8\u02B6\u02BB().TryGetValue(\u02B7\u02B6\u02BE\u02B4\u02B4\u02C0\u02B2\u02C0\u02B7\u02BE\u02BC.\u02B5\u02B5\u02C0\u02B3\u02B4\u02BF\u02B7\u02B9\u02B6\u02B3\u02B8(\u02BA\u02B2\u02BA\u02BB\u02BE\u02B7\u02BB\u02C0\u02B4\u02B6\u02C1), out dictionary))
			{
				LocalizationResourceManager.\u02C1\u02C1\u02BD\u02BA\u02C0\u02B4\u02B6\u02BF\u02BD\u02B5\u02B9(\u02BA\u02B2\u02BA\u02BB\u02BE\u02B7\u02BB\u02C0\u02B4\u02B6\u02C1, dictionary);
				text = dictionary.Values.First<string>();
			}
			else
			{
				LocalizationResourceManager.\u02B6\u02C0\u02B9\u02C0\u02B8\u02B9\u02BA\u02B5\u02BE\u02B4\u02BF(\u02BA\u02B2\u02BA\u02BB\u02BE\u02B7\u02BB\u02C0\u02B4\u02B6\u02C1, this);
			}
		}
		return text;
	}

	public string GetResource(string resourceID, string defaultValue = null)
	{
		string text = defaultValue ?? resourceID;
		if (!string.IsNullOrWhiteSpace(resourceID) && this.\u02C1\u02C0\u02BC\u02B5\u02BF\u02BB\u02B8\u02BA\u02BA\u02C1\u02C0(resourceID))
		{
			string text2;
			if (this.overrides != null && this.overrides.TryGetValue(resourceID, out text2))
			{
				return text2;
			}
			Dictionary<\u02BA\u02BE\u02B5\u02BF\u02BE\u02BE\u02B9\u02C1\u02B2\u02BB\u02C0, string> dictionary;
			if (this._languageResourceNode.Resources.TryGetValue(\u02B7\u02B6\u02BE\u02B4\u02B4\u02C0\u02B2\u02C0\u02B7\u02BE\u02BC.\u02B4\u02C1\u02BA\u02B8\u02B2\u02B6\u02B8\u02B5\u02B9\u02B9\u02BF(resourceID), out dictionary))
			{
				LocalizationResourceManager.\u02C1\u02C1\u02BD\u02BA\u02C0\u02B4\u02B6\u02BF\u02BD\u02B5\u02B9(resourceID, dictionary);
				if (!LocalizationResourceManager.written)
				{
					string text3 = Path.Combine(Application.persistentDataPath, "Translations");
					if (!Directory.Exists(text3))
					{
						Directory.CreateDirectory(text3);
					}
					StringBuilder stringBuilder = new StringBuilder();
					stringBuilder.Append("{\n");
					bool flag = true;
					foreach (KeyValuePair<\u02B7\u02B6\u02BE\u02B4\u02B4\u02C0\u02B2\u02C0\u02B7\u02BE\u02BC, Dictionary<\u02BA\u02BE\u02B5\u02BF\u02BE\u02BE\u02B9\u02C1\u02B2\u02BB\u02C0, string>> keyValuePair in this._languageResourceNode.Resources)
					{
						if (!flag)
						{
							stringBuilder.Append(",\n");
						}
						string text4 = keyValuePair.Key.ToString();
						stringBuilder.Append("  \"" + this.EscapeString(text4) + "\": ");
						string text5 = keyValuePair.Value.Values.First<string>();
						stringBuilder.Append("\"" + this.EscapeString(text5) + "\"");
						flag = false;
					}
					stringBuilder.Append("\n}");
					File.WriteAllText(Path.Combine(text3, "strings.json"), stringBuilder.ToString());
					LocalizationResourceManager.written = true;
				}
				text = dictionary.Values.First<string>();
			}
			else
			{
				LocalizationResourceManager.\u02B7\u02BF\u02B7\u02C1\u02BF\u02BF\u02C0\u02BD\u02BF\u02B5\u02B3(resourceID, this);
			}
		}
		return text;
	}

	private void \u02BE\u02B9\u02B5\u02B3\u02BE\u02B5\u02B4\u02B8\u02BE\u02B8\u02BA(\u02B3\u02BE\u02B9\u02BD\u02B5\u02B5\u02BE\u02BE\u02B5\u02BA\u02C0 \u02C1\u02B6\u02B3\u02B5\u02B6\u02C0\u02BD\u02BB\u02BE\u02B8\u02B6)
	{
		\u02C1\u02B6\u02B3\u02B5\u02B6\u02C0\u02BD\u02BB\u02BE\u02B8\u02B6.\u02B4\u02B8\u02BF\u02BA\u02BA\u02C1\u02BC\u02B9\u02B2\u02B5\u02B8.\u02BC\u02B8\u02C1\u02BD\u02B5\u02B3\u02BB\u02C0\u02B4\u02B5\u02B9(out this.\u02BC\u02BF\u02B2\u02B4\u02B6\u02BE\u02B4\u02B9\u02BA\u02B3\u02B5);
	}

	private static void \u02B7\u02BF\u02B7\u02C1\u02BF\u02BF\u02C0\u02BD\u02BF\u02B5\u02B3(string \u02C0\u02BC\u02BE\u02BE\u02B8\u02C0\u02B2\u02B2\u02B7\u02B2\u02B3, LocalizationResourceManager \u02C0\u02B9\u02BB\u02BE\u02B6\u02C1\u02B6\u02B7\u02B6\u02BA\u02B2)
	{
		string text = \u02C0\u02BC\u02BE\u02BE\u02B8\u02C0\u02B2\u02B2\u02B7\u02B2\u02B3 + ":" + \u02C0\u02B9\u02BB\u02BE\u02B6\u02C1\u02B6\u02B7\u02B6\u02BA\u02B2.\u02B7\u02BA\u02BC\u02BD\u02B4\u02BF\u02B6\u02C0\u02B8\u02B7\u02BA;
		int hashCode = text.GetHashCode();
		if (!\u02C0\u02B9\u02BB\u02BE\u02B6\u02C1\u02B6\u02B7\u02B6\u02BA\u02B2.\u02B9\u02B7\u02B2\u02B6\u02BA\u02BB\u02B6\u02BD\u02B4\u02B3\u02B4.Contains(hashCode))
		{
			Debug.LogWarning("<Missing i18n Resource>: " + text);
			\u02C0\u02B9\u02BB\u02BE\u02B6\u02C1\u02B6\u02B7\u02B6\u02BA\u02B2.\u02B9\u02B7\u02B2\u02B6\u02BA\u02BB\u02B6\u02BD\u02B4\u02B3\u02B4.Add(hashCode);
		}
	}

	public bool \u02B4\u02BC\u02BA\u02B4\u02B5\u02B5\u02BD\u02BC\u02C1\u02B9\u02BA<T>(string \u02C0\u02BA\u02B4\u02BD\u02B2\u02BF\u02B8\u02B5\u02BF\u02B2\u02BE, string \u02BD\u02BD\u02BF\u02BB\u02B4\u02C0\u02BB\u02B9\u02B4\u02B6\u02B8, string \u02BB\u02B5\u02BC\u02BD\u02B2\u02BE\u02BE\u02B5\u02BD\u02B6\u02B4, \u02B5\u02B4\u02C1\u02BA\u02C1\u02BF\u02B9\u02C0\u02C1\u02B6\u02BA? \u02BF\u02B5\u02B6\u02BE\u02B3\u02BD\u02BE\u02BF\u02B6\u02B5\u02B6 = null, bool \u02BD\u02B3\u02B9\u02B5\u02B3\u02BF\u02B4\u02B9\u02C0\u02BF\u02BB = false) where T : \u02BE\u02BF\u02B6\u02BC\u02BC\u02B9\u02B5\u02B3\u02B8\u02C0\u02B8, new()
	{
		if (this.\u02B7\u02BA\u02BC\u02BD\u02B4\u02BF\u02B6\u02C0\u02B8\u02B7\u02BA == \u02BB\u02B5\u02BC\u02BD\u02B2\u02BE\u02BE\u02B5\u02BD\u02B6\u02B4 && this._languageResourceNode != null)
		{
			return true;
		}
		\u02B6\u02BC\u02B5\u02BE\u02B3\u02BF\u02BB\u02B6\u02BE\u02BE\u02B7 u02B6_u02BC_u02B5_u02BE_u02B3_u02BF_u02BB_u02B6_u02BE_u02BE_u02B;
		bool flag = this.\u02BC\u02BF\u02B2\u02B4\u02B6\u02BE\u02B4\u02B9\u02BA\u02B3\u02B5.TryGetValue(\u02BB\u02B5\u02BC\u02BD\u02B2\u02BE\u02BE\u02B5\u02BD\u02B6\u02B4, out u02B6_u02BC_u02B5_u02BE_u02B3_u02BF_u02BB_u02B6_u02BE_u02BE_u02B);
		if (!flag)
		{
			u02B6_u02BC_u02B5_u02BE_u02B3_u02BF_u02BB_u02B6_u02BE_u02BE_u02B = LocalizationResourceManager.\u02B7\u02B8\u02BA\u02B8\u02B6\u02BE\u02B4\u02B2\u02B9\u02B4\u02BB;
			u02B6_u02BC_u02B5_u02BE_u02B3_u02BF_u02BB_u02B6_u02BE_u02BE_u02B.\u02C1\u02B6\u02B3\u02BD\u02B4\u02BC\u02BA\u02B3\u02B5\u02B5\u02C0["native"] = "<NoRule: '" + \u02BB\u02B5\u02BC\u02BD\u02B2\u02BE\u02BE\u02B5\u02BD\u02B6\u02B4 + "'>";
		}
		this.\u02B2\u02B9\u02B4\u02BC\u02BE\u02B8\u02B8\u02B9\u02B3\u02B2\u02B5 = u02B6_u02BC_u02B5_u02BE_u02B3_u02BF_u02BB_u02B6_u02BE_u02BE_u02B.\u02C1\u02B6\u02B3\u02BD\u02B4\u02BC\u02BA\u02B3\u02B5\u02B5\u02C0["native"];
		if (flag)
		{
			string text;
			if (File.Exists(\u02C0\u02BA\u02B4\u02BD\u02B2\u02BF\u02B8\u02B5\u02BF\u02B2\u02BE))
			{
				text = File.ReadAllText(\u02C0\u02BA\u02B4\u02BD\u02B2\u02BF\u02B8\u02B5\u02BF\u02B2\u02BE);
			}
			else
			{
				text = Resources.Load<TextAsset>("Languages/" + \u02BD\u02BD\u02BF\u02BB\u02B4\u02C0\u02BB\u02B9\u02B4\u02B6\u02B8).text;
			}
			if (text != null)
			{
				this.\u02C1\u02B9\u02BA\u02BB\u02B8\u02BB\u02B5\u02C0\u02BA\u02B5\u02BD<T>(\u02BB\u02B5\u02BC\u02BD\u02B2\u02BE\u02BE\u02B5\u02BD\u02B6\u02B4, text, \u02BF\u02B5\u02B6\u02BE\u02B3\u02BD\u02BE\u02BF\u02B6\u02B5\u02B6, \u02BD\u02B3\u02B9\u02B5\u02B3\u02BF\u02B4\u02B9\u02C0\u02BF\u02BB);
				return flag;
			}
		}
		else
		{
			Debug.LogWarning("Language: '" + \u02BB\u02B5\u02BC\u02BD\u02B2\u02BE\u02BE\u02B5\u02BD\u02B6\u02B4 + "' not found");
		}
		return flag;
	}

	public LocalizationResourceManager(\u02B3\u02BE\u02B9\u02BD\u02B5\u02B5\u02BE\u02BE\u02B5\u02BA\u02C0 \u02C1\u02BD\u02B6\u02B6\u02B8\u02BC\u02B5\u02B9\u02C0\u02B5\u02BA)
	{
		this.\u02B9\u02B7\u02B2\u02B6\u02BA\u02BB\u02B6\u02BD\u02B4\u02B3\u02B4 = new HashSet<int>();
		this.\u02BE\u02B9\u02B5\u02B3\u02BE\u02B5\u02B4\u02B8\u02BE\u02B8\u02BA(\u02C1\u02BD\u02B6\u02B6\u02B8\u02BC\u02B5\u02B9\u02C0\u02B5\u02BA);
		string text = Path.Combine(Application.persistentDataPath, "Translations\\strings.json");
		if (File.Exists(text))
		{
			this.overrides = AJson.JsonToDict(File.ReadAllText(text));
		}
	}

	public Dictionary<string, string> \u02B6\u02BB\u02BC\u02BD\u02C1\u02B3\u02B9\u02B3\u02B3\u02BC\u02B3
	{
		get
		{
			if (this.\u02BF\u02B7\u02BE\u02B2\u02BD\u02BF\u02BF\u02BE\u02BB\u02B7\u02BE == null)
			{
				this.\u02BF\u02B7\u02BE\u02B2\u02BD\u02BF\u02BF\u02BE\u02BB\u02B7\u02BE = this.\u02BC\u02BF\u02B2\u02B4\u02B6\u02BE\u02B4\u02B9\u02BA\u02B3\u02B5.ToDictionary(new Func<KeyValuePair<string, \u02B6\u02BC\u02B5\u02BE\u02B3\u02BF\u02BB\u02B6\u02BE\u02BE\u02B7>, string>(LocalizationResourceManager.<>c.<>9.\u02BE\u02B8\u02B7\u02C1\u02BC\u02BF\u02B4\u02B3\u02C0\u02BE\u02B9), new Func<KeyValuePair<string, \u02B6\u02BC\u02B5\u02BE\u02B3\u02BF\u02BB\u02B6\u02BE\u02BE\u02B7>, string>(LocalizationResourceManager.<>c.<>9.\u02B9\u02BB\u02B9\u02BE\u02B5\u02B2\u02BF\u02BF\u02BE\u02B6\u02BB));
			}
			return this.\u02BF\u02B7\u02BE\u02B2\u02BD\u02BF\u02BF\u02BE\u02BB\u02B7\u02BE;
		}
	}

	private string \u02B2\u02B9\u02B4\u02BC\u02BE\u02B8\u02B8\u02B9\u02B3\u02B2\u02B5
	{
		[CompilerGenerated]
		set
		{
			this.<\u02BD\u02BA\u02B9\u02B5\u02B2\u02B3\u02BD\u02BE\u02B2\u02B5\u02B6>k__BackingField = value;
		}
	}

	private string EscapeString(string input)
	{
		return input.Replace("\\", "\\\\").Replace("\"", "\\\"").Replace("\n", "\\n")
			.Replace("\r", "\\r")
			.Replace("\t", "\\t");
	}

	private HashSet<int> \u02B9\u02B7\u02B2\u02B6\u02BA\u02BB\u02B6\u02BD\u02B4\u02B3\u02B4;

	private TranslationNode _languageResourceNode;

	private IDictionary<string, \u02B6\u02BC\u02B5\u02BE\u02B3\u02BF\u02BB\u02B6\u02BE\u02BE\u02B7> \u02BC\u02BF\u02B2\u02B4\u02B6\u02BE\u02B4\u02B9\u02BA\u02B3\u02B5;

	private Dictionary<string, string> \u02BF\u02B7\u02BE\u02B2\u02BD\u02BF\u02BF\u02BE\u02BB\u02B7\u02BE;

	private static LocalizationResourceManager \u02B7\u02B3\u02BE\u02B8\u02BB\u02B5\u02B7\u02B9\u02C1\u02B5\u02B9 = null;

	private static bool written;

	private Dictionary<string, string> overrides;
}
