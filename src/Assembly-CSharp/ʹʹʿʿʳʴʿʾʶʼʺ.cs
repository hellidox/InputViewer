using System;
using System.Collections.Generic;

// Token: 0x0200023D RID: 573
internal static class \u02B9\u02B9\u02BF\u02BF\u02B3\u02B4\u02BF\u02BE\u02B6\u02BC\u02BA
{
	// Token: 0x0600191F RID: 6431 RVA: 0x000B7D18 File Offset: 0x000B5F18
	public static bool \u02BB\u02B6\u02B8\u02BB\u02BC\u02B2\u02BB\u02B9\u02B9\u02BA\u02BE<T>(this IDictionary<string, object> \u02BF\u02B7\u02C1\u02C0\u02B6\u02B3\u02BF\u02C1\u02BE\u02C1\u02BE, string \u02B9\u02C1\u02BA\u02BD\u02BB\u02B3\u02BF\u02B8\u02B9\u02B9\u02BB, out T \u02B4\u02BF\u02B3\u02B3\u02BF\u02B2\u02C1\u02BE\u02B2\u02BD\u02BE)
	{
		object obj;
		if (\u02BF\u02B7\u02C1\u02C0\u02B6\u02B3\u02BF\u02C1\u02BE\u02C1\u02BE.TryGetValue(\u02B9\u02C1\u02BA\u02BD\u02BB\u02B3\u02BF\u02B8\u02B9\u02B9\u02BB, out obj))
		{
			if (obj is T)
			{
				T t = (T)((object)obj);
				\u02B4\u02BF\u02B3\u02B3\u02BF\u02B2\u02C1\u02BE\u02B2\u02BD\u02BE = t;
				return true;
			}
			if (typeof(T) == typeof(float) && obj is int)
			{
				int num = (int)obj;
				\u02B4\u02BF\u02B3\u02B3\u02BF\u02B2\u02C1\u02BE\u02B2\u02BD\u02BE = (T)((object)Convert.ChangeType((float)num, typeof(T)));
				return true;
			}
		}
		\u02B4\u02BF\u02B3\u02B3\u02BF\u02B2\u02C1\u02BE\u02B2\u02BD\u02BE = default(T);
		return false;
	}
}
