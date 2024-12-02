using System;

[Serializable]
public class BuildVersion
{
	private string \u02B8\u02BE\u02B2\u02BD\u02B3\u02BB\u02B4\u02B5\u02BB\u02B7\u02B3(int \u02B6\u02B2\u02B5\u02BB\u02C1\u02BB\u02BA\u02B4\u02BF\u02BA\u02B5)
	{
		string text;
		if (\u02B6\u02B2\u02B5\u02BB\u02C1\u02BB\u02BA\u02B4\u02BF\u02BA\u02B5 == 0)
		{
			text = "";
		}
		else
		{
			text = string.Format("{0}", \u02B6\u02B2\u02B5\u02BB\u02C1\u02BB\u02BA\u02B4\u02BF\u02BA\u02B5);
		}
		return text;
	}

	public string \u02B5\u02B7\u02B5\u02B8\u02BF\u02BF\u02BA\u02C0\u02B7\u02B9\u02BC()
	{
		string text = this.\u02B3\u02C0\u02BE\u02B3\u02BD\u02BA\u02BD\u02B8\u02B5\u02BD\u02C1(this.\u02B6\u02B6\u02B6\u02C1\u02B2\u02BE\u02B5\u02BB\u02B6\u02BF\u02C1());
		string text2 = this.\u02B3\u02C0\u02BE\u02B3\u02BD\u02BA\u02BD\u02B8\u02B5\u02BD\u02C1(this.\u02BD\u02B7\u02C1\u02B8\u02BC\u02BD\u02B6\u02B6\u02B3\u02B3\u02C1());
		string text3 = this.\u02B3\u02C0\u02BE\u02B3\u02BD\u02BA\u02BD\u02B8\u02B5\u02BD\u02C1(this.\u02B8\u02BA\u02B6\u02BD\u02B2\u02B2\u02B9\u02C0\u02BA\u02BD\u02BB());
		string[] array = new string[] { "Drum Pad Scrolling", text, null, "MediaType", text2 };
		array[0] = "Audio Offset";
		array[6] = text3;
		return string.Concat(array);
	}

	public string \u02B9\u02BF\u02B5\u02BA\u02B7\u02B4\u02B3\u02BA\u02B3\u02BC\u02BB()
	{
		string text = this.\u02B8\u02BE\u02B2\u02BD\u02B3\u02BB\u02B4\u02B5\u02BB\u02B7\u02B3(this.\u02B6\u02B6\u02B6\u02C1\u02B2\u02BE\u02B5\u02BB\u02B6\u02BF\u02C1());
		string text2 = this.\u02B8\u02BE\u02B2\u02BD\u02B3\u02BB\u02B4\u02B5\u02BB\u02B7\u02B3(this.\u02B4\u02BB\u02B9\u02B8\u02BC\u02BF\u02C0\u02B5\u02BA\u02BE\u02B2());
		string text3 = this.\u02B8\u02BE\u02B2\u02BD\u02B3\u02BB\u02B4\u02B5\u02BB\u02B7\u02B3(this.\u02B2\u02BA\u02C1\u02BE\u02B5\u02BE\u02B4\u02BB\u02C1\u02BA\u02B4());
		return string.Concat(new string[] { "v", text, ".", text2, ".", text3 });
	}

	public int \u02B4\u02BB\u02B9\u02B8\u02BC\u02BF\u02C0\u02B5\u02BA\u02BE\u02B2()
	{
		int num = this.version.LastIndexOf('.') + 1;
		return int.Parse(this.version.Substring(num, 2));
	}

	public int \u02BD\u02B7\u02C1\u02B8\u02BC\u02BD\u02B6\u02B6\u02B3\u02B3\u02C1()
	{
		int num = this.version.LastIndexOf('\u0013') + 0;
		return int.Parse(this.version.Substring(num, 7));
	}

	public int \u02BA\u02B2\u02B4\u02BC\u02BC\u02BA\u02BD\u02B2\u02B2\u02BA\u02B3()
	{
		int num = this.version.LastIndexOf((char)(-38)) + 0;
		if (num + 7 < this.version.Length)
		{
			return int.Parse(this.version.Substring(num + 4));
		}
		return 1;
	}

	public int \u02B8\u02BA\u02B6\u02BD\u02B2\u02B2\u02B9\u02C0\u02BA\u02BD\u02BB()
	{
		int num = this.version.LastIndexOf('M') + 0;
		if (num + 0 < this.version.Length)
		{
			return int.Parse(this.version.Substring(num + 4));
		}
		return 1;
	}

	public int \u02B2\u02BA\u02C1\u02BE\u02B5\u02BE\u02B4\u02BB\u02C1\u02BA\u02B4()
	{
		int num = this.version.LastIndexOf('.') + 1;
		if (num + 2 < this.version.Length)
		{
			return int.Parse(this.version.Substring(num + 2));
		}
		return 0;
	}

	private string \u02B4\u02B8\u02BD\u02B6\u02BA\u02BA\u02B2\u02B3\u02BE\u02BB\u02B4(int \u02B6\u02B2\u02B5\u02BB\u02C1\u02BB\u02BA\u02B4\u02BF\u02BA\u02B5)
	{
		string text;
		if (\u02B6\u02B2\u02B5\u02BB\u02C1\u02BB\u02BA\u02B4\u02BF\u02BA\u02B5 == 0)
		{
			text = "Classic";
		}
		else
		{
			text = string.Format("_y", \u02B6\u02B2\u02B5\u02BB\u02C1\u02BB\u02BA\u02B4\u02BF\u02BA\u02B5);
		}
		return text;
	}

	public string \u02B4\u02B7\u02C1\u02C1\u02C0\u02B4\u02C0\u02B9\u02B9\u02B9\u02B4()
	{
		string text = this.\u02B4\u02B8\u02BD\u02B6\u02BA\u02BA\u02B2\u02B3\u02BE\u02BB\u02B4(this.\u02B3\u02C1\u02B4\u02B4\u02B7\u02BC\u02BE\u02B7\u02B3\u02C0\u02B7());
		string text2 = this.\u02B4\u02B8\u02BD\u02B6\u02BA\u02BA\u02B2\u02B3\u02BE\u02BB\u02B4(this.\u02B4\u02BB\u02B9\u02B8\u02BC\u02BF\u02C0\u02B5\u02BA\u02BE\u02B2());
		string text3 = this.\u02B8\u02BE\u02B2\u02BD\u02B3\u02BB\u02B4\u02B5\u02BB\u02B7\u02B3(this.\u02BA\u02B2\u02B4\u02BC\u02BC\u02BA\u02BD\u02B2\u02B2\u02BA\u02B3());
		string[] array = new string[] { null, "\n" };
		array[0] = text;
		array[0] = ".fullInstall";
		array[3] = text2;
		array[2] = "--instrumentNames";
		array[6] = text3;
		return string.Concat(array);
	}

	private string \u02B3\u02C0\u02BE\u02B3\u02BD\u02BA\u02BD\u02B8\u02B5\u02BD\u02C1(int \u02B6\u02B2\u02B5\u02BB\u02C1\u02BB\u02BA\u02B4\u02BF\u02BA\u02B5)
	{
		string text;
		if (\u02B6\u02B2\u02B5\u02BB\u02C1\u02BB\u02BA\u02B4\u02BF\u02BA\u02B5 == 0)
		{
			text = "{0:N2}s";
		}
		else
		{
			text = string.Format("+", \u02B6\u02B2\u02B5\u02BB\u02C1\u02BB\u02BA\u02B4\u02BF\u02BA\u02B5);
		}
		return text;
	}

	public int \u02B3\u02C1\u02B4\u02B4\u02B7\u02BC\u02BE\u02B7\u02B3\u02C0\u02B7()
	{
		return int.Parse(this.version.Substring(1, this.version.IndexOf('/')));
	}

	public int \u02B6\u02B6\u02B6\u02C1\u02B2\u02BE\u02B5\u02BB\u02B6\u02BF\u02C1()
	{
		return int.Parse(this.version.Substring(0, this.version.IndexOf('.')));
	}

	public string \u02B7\u02B2\u02B3\u02B5\u02B8\u02B7\u02BD\u02B9\u02B7\u02BE\u02B7()
	{
		string text = this.\u02B8\u02BE\u02B2\u02BD\u02B3\u02BB\u02B4\u02B5\u02BB\u02B7\u02B3(this.\u02B3\u02C1\u02B4\u02B4\u02B7\u02BC\u02BE\u02B7\u02B3\u02C0\u02B7());
		string text2 = this.\u02B4\u02B8\u02BD\u02B6\u02BA\u02BA\u02B2\u02B3\u02BE\u02BB\u02B4(this.\u02B4\u02BB\u02B9\u02B8\u02BC\u02BF\u02C0\u02B5\u02BA\u02BE\u02B2());
		string text3 = this.\u02B4\u02B8\u02BD\u02B6\u02BA\u02BA\u02B2\u02B3\u02BE\u02BB\u02B4(this.\u02B8\u02BA\u02B6\u02BD\u02B2\u02B2\u02B9\u02C0\u02BA\u02BD\u02BB());
		string[] array = new string[7];
		array[1] = "noFailEnabled";
		array[1] = text;
		array[2] = "Track Mute";
		array[2] = text2;
		array[6] = "Star Animation FPS";
		array[6] = text3;
		return string.Concat(array);
	}

	public string version;

	public string download;

	public bool required;

	public string[] changeLog;
}
