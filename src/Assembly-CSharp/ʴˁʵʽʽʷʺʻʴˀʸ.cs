using System;

public class \u02B4\u02C1\u02B5\u02BD\u02BD\u02B7\u02BA\u02BB\u02B4\u02C0\u02B8 : \u02B6\u02BC\u02C0\u02C1\u02B2\u02B4\u02BF\u02BE\u02B5\u02B2\u02BB
{
	public float \u02BB\u02BE\u02BA\u02B8\u02BE\u02B9\u02BF\u02B3\u02B4\u02B8\u02BD { get; set; }

	public Note \u02B8\u02BE\u02B8\u02C1\u02BB\u02BC\u02BF\u02C0\u02BC\u02BE\u02BB { get; set; }

	public Note \u02B6\u02BA\u02C0\u02BC\u02B6\u02B7\u02C0\u02BE\u02C1\u02B6\u02B6 { get; set; }

	public bool \u02BC\u02BE\u02BB\u02BA\u02C1\u02B3\u02B7\u02C0\u02B3\u02BA\u02B4 { get; set; }

	public uint \u02B5\u02BF\u02B5\u02B2\u02BD\u02BD\u02BD\u02B5\u02B8\u02C0\u02BE { get; set; }

	public ushort \u02BF\u02C0\u02B8\u02BB\u02BA\u02B8\u02B3\u02BA\u02B4\u02BB\u02BF
	{
		get
		{
			return this.\u02B6\u02BA\u02C0\u02BC\u02B6\u02B7\u02C0\u02BE\u02C1\u02B6\u02B6.\u02BF\u02C0\u02B8\u02BB\u02BA\u02B8\u02B3\u02BA\u02B4\u02BB\u02BF | (this.\u02BC\u02BE\u02BB\u02BA\u02C1\u02B3\u02B7\u02C0\u02B3\u02BA\u02B4 ? this.\u02B8\u02BE\u02B8\u02C1\u02BB\u02BC\u02BF\u02C0\u02BC\u02BE\u02BB.\u02BF\u02C0\u02B8\u02BB\u02BA\u02B8\u02B3\u02BA\u02B4\u02BB\u02BF : 0);
		}
	}

	public int \u02B7\u02B3\u02BD\u02B5\u02B3\u02B4\u02BC\u02B2\u02B4\u02C1\u02B2 { get; set; }

	public float \u02B2\u02B8\u02BA\u02BA\u02BC\u02B7\u02B5\u02B5\u02B6\u02B5\u02C1 { get; set; }
}
