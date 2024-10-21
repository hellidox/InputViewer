using System;

// Token: 0x0200025E RID: 606
public static class \u02B6\u02C0\u02BB\u02B7\u02BC\u02C0\u02BB\u02C1\u02B6\u02C0\u02B4
{
	// Token: 0x060019B0 RID: 6576 RVA: 0x000C6BE0 File Offset: 0x000C4DE0
	internal static int \u02BA\u02B9\u02BF\u02BF\u02B3\u02B7\u02BE\u02C1\u02BA\u02B3\u02BE(string \u02BA\u02BB\u02B2\u02C0\u02BD\u02BF\u02B4\u02BC\u02BC\u02BC\u02BB, int \u02BB\u02B4\u02B2\u02B3\u02B4\u02BD\u02B9\u02B8\u02B5\u02B8\u02BC)
	{
		int num = 1;
		for (int i = 0; i < \u02BB\u02B4\u02B2\u02B3\u02B4\u02BD\u02B9\u02B8\u02B5\u02B8\u02BC; i++)
		{
			if (\u02BA\u02BB\u02B2\u02C0\u02BD\u02BF\u02B4\u02BC\u02BC\u02BC\u02BB[i] == '\n')
			{
				num++;
			}
		}
		return num;
	}
}
