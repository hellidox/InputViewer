using System;
using System.Reflection;
using StrikeCore.Logging;
using UnityEngine;

// Token: 0x02000079 RID: 121
public static class UnityWrapper
{
	// Token: 0x060004B9 RID: 1209 RVA: 0x00008598 File Offset: 0x00006798
	static UnityWrapper()
	{
		UnityWrapper.Setup();
	}

	// Token: 0x060004BA RID: 1210 RVA: 0x00032944 File Offset: 0x00030B44
	private static bool \u02B4\u02B8\u02B7\u02B4\u02B9\u02C0\u02B5\u02BD\u02B2\u02BE\u02BA<T>(T \u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7, Type \u02C0\u02B2\u02BA\u02B6\u02BC\u02C0\u02BC\u02BE\u02B6\u02B2\u02B5, string \u02BF\u02B5\u02BC\u02C0\u02C0\u02B2\u02BD\u02BC\u02BB\u02B6\u02B4)
	{
		BindingFlags bindingFlags = BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic;
		\u02C0\u02B2\u02BA\u02B6\u02BC\u02C0\u02BC\u02BE\u02B6\u02B2\u02B5.GetField(\u02BF\u02B5\u02BC\u02C0\u02C0\u02B2\u02BD\u02BC\u02BB\u02B6\u02B4, bindingFlags).SetValue(null, \u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7);
		return true;
	}

	// Token: 0x060004BB RID: 1211 RVA: 0x0003296C File Offset: 0x00030B6C
	private static T \u02B2\u02BF\u02B3\u02B9\u02BF\u02BD\u02BA\u02BF\u02BF\u02B6\u02B5<T>(Type \u02C0\u02B2\u02BA\u02B6\u02BC\u02C0\u02BC\u02BE\u02B6\u02B2\u02B5, string \u02BF\u02B5\u02BC\u02C0\u02C0\u02B2\u02BD\u02BC\u02BB\u02B6\u02B4) where T : Delegate
	{
		BindingFlags bindingFlags = BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic;
		return (T)((object)\u02C0\u02B2\u02BA\u02B6\u02BC\u02C0\u02BC\u02BE\u02B6\u02B2\u02B5.GetMethod(\u02BF\u02B5\u02BC\u02C0\u02C0\u02B2\u02BD\u02BC\u02BB\u02B6\u02B4, bindingFlags).CreateDelegate(typeof(T)));
	}

	// Token: 0x060004BC RID: 1212 RVA: 0x0000859F File Offset: 0x0000679F
	public static void \u02C1\u02C0\u02C0\u02B9\u02B9\u02BB\u02BA\u02B9\u02BE\u02B9\u02C1(string \u02B6\u02B2\u02B5\u02BB\u02C1\u02BB\u02BA\u02B4\u02BF\u02BA\u02B5)
	{
		UnityWrapper.\u02BC\u02B7\u02B4\u02B2\u02BE\u02B2\u02BD\u02BD\u02B9\u02BC\u02B8(LogType.Log, LogOption.None, \u02B6\u02B2\u02B5\u02BB\u02C1\u02BB\u02BA\u02B4\u02BF\u02BA\u02B5, null);
	}

	// Token: 0x060004BD RID: 1213 RVA: 0x00032998 File Offset: 0x00030B98
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
	private static void Setup()
	{
		if (UnityWrapper.\u02BC\u02B7\u02B4\u02B2\u02BE\u02B2\u02BD\u02BD\u02B9\u02BC\u02B8 != null)
		{
			return;
		}
		Type type = Debug.unityLogger.logHandler.GetType();
		UnityWrapper.\u02C1\u02BF\u02BA\u02B3\u02C1\u02BD\u02BF\u02B8\u02BF\u02B7\u02B6 = UnityWrapper.\u02B2\u02BF\u02B3\u02B9\u02BF\u02BD\u02BA\u02BF\u02BF\u02B6\u02B5<UnityWrapper.\u02BD\u02BC\u02BB\u02B8\u02B7\u02B5\u02BB\u02BE\u02B9\u02B9\u02C1>(type, "Internal_LogException");
		UnityWrapper.\u02BC\u02B7\u02B4\u02B2\u02BE\u02B2\u02BD\u02BD\u02B9\u02BC\u02B8 = UnityWrapper.\u02B2\u02BF\u02B3\u02B9\u02BF\u02BD\u02BA\u02BF\u02BF\u02B6\u02B5<UnityWrapper.\u02B8\u02B7\u02B3\u02B5\u02BC\u02B8\u02B3\u02B2\u02B8\u02C1\u02B9>(type, "Internal_Log");
		UnityWrapper.\u02C1\u02C0\u02C0\u02B9\u02B9\u02BB\u02BA\u02B9\u02BE\u02B9\u02C1("FastLogger: Activated");
		UnityWrapper.\u02B4\u02B8\u02B7\u02B4\u02B9\u02C0\u02B5\u02BD\u02B2\u02BE\u02BA<\u02BE\u02BE\u02B6\u02BF\u02BC\u02C1\u02BE\u02BF\u02C1\u02B2\u02B6>(new \u02BE\u02BE\u02B6\u02BF\u02BC\u02C1\u02BE\u02BF\u02C1\u02B2\u02B6(), typeof(Debug), "s_Logger");
		Log.AddLogProvider(new LevelFilter(LogLevel.Trace), new DefaultLogFormatter(), new \u02B3\u02B5\u02B5\u02B6\u02C0\u02BF\u02B9\u02BC\u02BF\u02BC\u02B5());
	}

	// Token: 0x040003AD RID: 941
	public static UnityWrapper.\u02B8\u02B7\u02B3\u02B5\u02BC\u02B8\u02B3\u02B2\u02B8\u02C1\u02B9 \u02BC\u02B7\u02B4\u02B2\u02BE\u02B2\u02BD\u02BD\u02B9\u02BC\u02B8;

	// Token: 0x040003AE RID: 942
	public static UnityWrapper.\u02BD\u02BC\u02BB\u02B8\u02B7\u02B5\u02BB\u02BE\u02B9\u02B9\u02C1 \u02C1\u02BF\u02BA\u02B3\u02C1\u02BD\u02BF\u02B8\u02BF\u02B7\u02B6;

	// Token: 0x0200007A RID: 122
	// (Invoke) Token: 0x060004BF RID: 1215
	public delegate void \u02B8\u02B7\u02B3\u02B5\u02BC\u02B8\u02B3\u02B2\u02B8\u02C1\u02B9(LogType \u02B7\u02B7\u02BF\u02B2\u02BA\u02BA\u02BA\u02B9\u02B5\u02B9\u02B6, LogOption \u02BC\u02C0\u02B2\u02B5\u02BE\u02B7\u02C1\u02B4\u02B7\u02BD\u02C0, string \u02B5\u02BE\u02C1\u02BE\u02B2\u02B5\u02B7\u02B8\u02B4\u02B4\u02B5, global::UnityEngine.Object \u02BA\u02BE\u02BE\u02B3\u02BD\u02BD\u02B3\u02BA\u02B2\u02B9\u02B7);

	// Token: 0x0200007B RID: 123
	// (Invoke) Token: 0x060004C1 RID: 1217
	public delegate void \u02BD\u02BC\u02BB\u02B8\u02B7\u02B5\u02BB\u02BE\u02B9\u02B9\u02C1(Exception \u02B7\u02BB\u02C1\u02B2\u02B4\u02BE\u02B4\u02B6\u02B6\u02B6\u02BE, global::UnityEngine.Object \u02BA\u02BE\u02BE\u02B3\u02BD\u02BD\u02B3\u02BA\u02B2\u02B9\u02B7);
}
