using System;
using System.Collections.Generic;

public static class AJson
{
	private static string UnescapeString(string input)
	{
		return input.Replace("\\\"", "\"").Replace("\\\\", "\\").Replace("\\n", "\n")
			.Replace("\\r", "\r")
			.Replace("\\t", "\t");
	}

	public static Dictionary<string, string> JsonToDict(string json)
	{
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		string[] array = json.Split(new char[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
		for (int i = 0; i < array.Length; i++)
		{
			string text = array[i].Trim();
			if (!(text == "{") && !(text == "}"))
			{
				int num = text.IndexOf(':');
				if (num != -1)
				{
					string text2 = text.Substring(0, num).Trim().Trim('"');
					string text3 = text.Substring(num + 1).Trim();
					if (text3.EndsWith(","))
					{
						text3 = text3.Substring(0, text3.Length - 1);
					}
					text3 = text3.Trim('"');
					dictionary[text2] = AJson.UnescapeString(text3);
				}
			}
		}
		return dictionary;
	}

	public static List<Tuple<string, string>> JsonToList(string json)
	{
		List<Tuple<string, string>> list = new List<Tuple<string, string>>();
		string[] array = json.Split(new char[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
		for (int i = 0; i < array.Length; i++)
		{
			string text = array[i].Trim();
			if (!(text == "{") && !(text == "}"))
			{
				int num = text.IndexOf(':');
				if (num != -1)
				{
					string text2 = text.Substring(0, num).Trim().Trim('"');
					string text3 = text.Substring(num + 1).Trim();
					if (text3.EndsWith(","))
					{
						text3 = text3.Substring(0, text3.Length - 1);
					}
					text3 = text3.Trim('"');
					list.Add(Tuple.Create<string, string>(AJson.UnescapeString(text2), AJson.UnescapeString(text3)));
				}
			}
		}
		return list;
	}
}
