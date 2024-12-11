using System;
using System.IO;
using UnityEngine;

internal static class \u02C0\u02B2\u02BC\u02B7\u02B5\u02BE\u02BA\u02B2\u02B4\u02C0\u02BF
{
	public static LocalizationResourceManager \u02BA\u02BC\u02BB\u02B4\u02BE\u02B3\u02BB\u02B3\u02BF\u02BA\u02B5()
	{
		return new LocalizationResourceManager(new \u02B3\u02BE\u02B9\u02BD\u02B5\u02B5\u02BE\u02BE\u02B5\u02BA\u02C0
		{
			\u02B4\u02B8\u02BF\u02BA\u02BA\u02C1\u02BC\u02B9\u02B2\u02B5\u02B8 = new \u02BB\u02BE\u02C0\u02BE\u02BB\u02BB\u02BA\u02B4\u02B3\u02BC\u02BF(Path.Combine(Application.persistentDataPath, "LanguagePluralRules.txt"), "Languages/" + Path.GetFileNameWithoutExtension("LanguagePluralRules.txt"))
		});
	}
}
