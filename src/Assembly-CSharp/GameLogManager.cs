using System;
using System.IO;
using UnityEngine;

public static class GameLogManager
{
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSplashScreen)]
	private static void InitLogManager()
	{
		AppDomain.CurrentDomain.ProcessExit += GameLogManager.<>c.<>9.\u02C0\u02C1\u02B9\u02B2\u02B2\u02C0\u02B2\u02B8\u02BF\u02BE\u02B6;
	}

	private static void \u02BA\u02B6\u02BE\u02B2\u02C1\u02BC\u02BB\u02C1\u02B2\u02B4\u02BB()
	{
		if (GameLogManager.\u02BB\u02B7\u02BA\u02B3\u02B4\u02B6\u02BA\u02BD\u02B8\u02BA\u02BD == null)
		{
			return;
		}
		StreamWriter u02BB_u02B7_u02BA_u02B3_u02B4_u02B6_u02BA_u02BD_u02B8_u02BA_u02BD = GameLogManager.\u02BB\u02B7\u02BA\u02B3\u02B4\u02B6\u02BA\u02BD\u02B8\u02BA\u02BD;
		lock (u02BB_u02B7_u02BA_u02B3_u02B4_u02B6_u02BA_u02BD_u02B8_u02BA_u02BD)
		{
			GameLogManager.\u02BB\u02B7\u02BA\u02B3\u02B4\u02B6\u02BA\u02BD\u02B8\u02BA\u02BD.Dispose();
		}
		GameLogManager.\u02BB\u02B7\u02BA\u02B3\u02B4\u02B6\u02BA\u02BD\u02B8\u02BA\u02BD = null;
	}

	public static void \u02BD\u02B2\u02BC\u02BF\u02BA\u02BC\u02BC\u02B5\u02BA\u02C0\u02BF()
	{
		if (GameLogManager.\u02B8\u02B3\u02BC\u02B8\u02C0\u02B5\u02BE\u02BA\u02C0\u02C1\u02B8 != null)
		{
			return;
		}
		GameLogManager.\u02C1\u02B2\u02BE\u02B4\u02B3\u02BF\u02B2\u02BC\u02BB\u02BD\u02B8 = Path.Combine(Helper.GetDocumentsClonFolder(), "Logs");
		if (!Directory.Exists(GameLogManager.\u02BA\u02BF\u02B2\u02B6\u02B6\u02B5\u02BE\u02BF\u02BD\u02B4\u02BF()))
		{
			Directory.CreateDirectory(GameLogManager.\u02BA\u02BF\u02B2\u02B6\u02B6\u02B5\u02BE\u02BF\u02BD\u02B4\u02BF());
		}
		GameLogManager.\u02BB\u02B9\u02BA\u02BF\u02B2\u02B2\u02BD\u02BC\u02BE\u02B7\u02C1 = (SystemInfo.deviceUniqueIdentifier + DateTime.Now.ToString()).GetHashCode();
		Debug.Log(string.Format("Log ID: {0}", GameLogManager.\u02BB\u02B9\u02BA\u02BF\u02B2\u02B2\u02BD\u02BC\u02BE\u02B7\u02C1));
		Application.logMessageReceivedThreaded += GameLogManager.\u02BE\u02B7\u02B7\u02C0\u02B8\u02C0\u02BB\u02BE\u02BB\u02B5\u02B3;
		GameLogManager.\u02BB\u02B9\u02BB\u02B8\u02B9\u02C1\u02B2\u02BE\u02B9\u02B4\u02B4();
	}

	private static void \u02BE\u02B7\u02B7\u02C0\u02B8\u02C0\u02BB\u02BE\u02BB\u02B5\u02B3(string \u02BD\u02B7\u02B4\u02B9\u02BC\u02BC\u02B7\u02B4\u02B3\u02B7\u02B3, string \u02BD\u02B9\u02BC\u02C1\u02B7\u02BC\u02B6\u02C0\u02B3\u02B7\u02B6, LogType \u02C0\u02B2\u02BA\u02B6\u02BC\u02C0\u02BC\u02BE\u02B6\u02B2\u02B5)
	{
		if (GameLogManager.\u02BB\u02B7\u02BA\u02B3\u02B4\u02B6\u02BA\u02BD\u02B8\u02BA\u02BD == null)
		{
			return;
		}
		StreamWriter u02BB_u02B7_u02BA_u02B3_u02B4_u02B6_u02BA_u02BD_u02B8_u02BA_u02BD = GameLogManager.\u02BB\u02B7\u02BA\u02B3\u02B4\u02B6\u02BA\u02BD\u02B8\u02BA\u02BD;
		lock (u02BB_u02B7_u02BA_u02B3_u02B4_u02B6_u02BA_u02BD_u02B8_u02BA_u02BD)
		{
			if (\u02C0\u02B2\u02BA\u02B6\u02BC\u02C0\u02BC\u02BE\u02B6\u02B2\u02B5 == LogType.Log || \u02C0\u02B2\u02BA\u02B6\u02BC\u02C0\u02BC\u02BE\u02B6\u02B2\u02B5 == LogType.Warning)
			{
				GameLogManager.\u02BB\u02B7\u02BA\u02B3\u02B4\u02B6\u02BA\u02BD\u02B8\u02BA\u02BD.WriteLine(string.Format("[{0}] {1}", \u02C0\u02B2\u02BA\u02B6\u02BC\u02C0\u02BC\u02BE\u02B6\u02B2\u02B5, \u02BD\u02B7\u02B4\u02B9\u02BC\u02BC\u02B7\u02B4\u02B3\u02B7\u02B3));
			}
			else
			{
				GameLogManager.\u02BB\u02B7\u02BA\u02B3\u02B4\u02B6\u02BA\u02BD\u02B8\u02BA\u02BD.WriteLine(" ");
				GameLogManager.\u02BB\u02B7\u02BA\u02B3\u02B4\u02B6\u02BA\u02BD\u02B8\u02BA\u02BD.WriteLine(string.Format("----{0}----", \u02C0\u02B2\u02BA\u02B6\u02BC\u02C0\u02BC\u02BE\u02B6\u02B2\u02B5));
				GameLogManager.\u02BB\u02B7\u02BA\u02B3\u02B4\u02B6\u02BA\u02BD\u02B8\u02BA\u02BD.WriteLine(\u02BD\u02B7\u02B4\u02B9\u02BC\u02BC\u02B7\u02B4\u02B3\u02B7\u02B3);
				GameLogManager.\u02BB\u02B7\u02BA\u02B3\u02B4\u02B6\u02BA\u02BD\u02B8\u02BA\u02BD.WriteLine("Stacktrace: " + \u02BD\u02B9\u02BC\u02C1\u02B7\u02BC\u02B6\u02C0\u02B3\u02B7\u02B6);
				GameLogManager.\u02BB\u02B7\u02BA\u02B3\u02B4\u02B6\u02BA\u02BD\u02B8\u02BA\u02BD.WriteLine(string.Format("----{0}----", \u02C0\u02B2\u02BA\u02B6\u02BC\u02C0\u02BC\u02BE\u02B6\u02B2\u02B5));
				GameLogManager.\u02BB\u02B7\u02BA\u02B3\u02B4\u02B6\u02BA\u02BD\u02B8\u02BA\u02BD.WriteLine(" ");
			}
		}
	}

	private static void \u02BB\u02B9\u02BB\u02B8\u02B9\u02C1\u02B2\u02BE\u02B9\u02B4\u02B4()
	{
		GameLogManager.\u02B8\u02B3\u02BC\u02B8\u02C0\u02B5\u02BE\u02BA\u02C0\u02C1\u02B8 = string.Format("Session-{0:yyyy-M-d_hh-mm-ss}.log", DateTime.Now);
		GameLogManager.\u02BE\u02BD\u02BD\u02BE\u02C1\u02B8\u02BE\u02B6\u02B3\u02B4\u02BA = Path.Combine(GameLogManager.\u02BA\u02BF\u02B2\u02B6\u02B6\u02B5\u02BE\u02BF\u02BD\u02B4\u02BF(), GameLogManager.\u02B8\u02B3\u02BC\u02B8\u02C0\u02B5\u02BE\u02BA\u02C0\u02C1\u02B8);
		GameLogManager.\u02BB\u02B7\u02BA\u02B3\u02B4\u02B6\u02BA\u02BD\u02B8\u02BA\u02BD = File.CreateText(Path.Combine(GameLogManager.\u02BA\u02BF\u02B2\u02B6\u02B6\u02B5\u02BE\u02BF\u02BD\u02B4\u02BF(), GameLogManager.\u02B8\u02B3\u02BC\u02B8\u02C0\u02B5\u02BE\u02BA\u02C0\u02C1\u02B8));
		GameLogManager.\u02BB\u02B7\u02BA\u02B3\u02B4\u02B6\u02BA\u02BD\u02B8\u02BA\u02BD.AutoFlush = true;
		GameLogManager.\u02BA\u02BC\u02B6\u02BB\u02BF\u02BE\u02B2\u02BB\u02C1\u02B7\u02B8();
	}

	private static void \u02BA\u02BC\u02B6\u02BB\u02BF\u02BE\u02B2\u02BB\u02C1\u02B7\u02B8()
	{
		if (GameLogManager.\u02BB\u02B7\u02BA\u02B3\u02B4\u02B6\u02BA\u02BD\u02B8\u02BA\u02BD == null)
		{
			return;
		}
		StreamWriter u02BB_u02B7_u02BA_u02B3_u02B4_u02B6_u02BA_u02BD_u02B8_u02BA_u02BD = GameLogManager.\u02BB\u02B7\u02BA\u02B3\u02B4\u02B6\u02BA\u02BD\u02B8\u02BA\u02BD;
		lock (u02BB_u02B7_u02BA_u02B3_u02B4_u02B6_u02BA_u02BD_u02B8_u02BA_u02BD)
		{
			GameLogManager.\u02BB\u02B7\u02BA\u02B3\u02B4\u02B6\u02BA\u02BD\u02B8\u02BA\u02BD.WriteLine(string.Format("Log ID: {0}", GameLogManager.\u02BB\u02B9\u02BA\u02BF\u02B2\u02B2\u02BD\u02BC\u02BE\u02B7\u02C1));
			GameLogManager.\u02BB\u02B7\u02BA\u02B3\u02B4\u02B6\u02BA\u02BD\u02B8\u02BA\u02BD.WriteLine(" ");
			GameLogManager.\u02BB\u02B7\u02BA\u02B3\u02B4\u02B6\u02BA\u02BD\u02B8\u02BA\u02BD.WriteLine("----Info----");
			GameLogManager.\u02BB\u02B7\u02BA\u02B3\u02B4\u02B6\u02BA\u02BD\u02B8\u02BA\u02BD.WriteLine("Game Version: " + Application.version);
			GameLogManager.\u02BB\u02B7\u02BA\u02B3\u02B4\u02B6\u02BA\u02BD\u02B8\u02BA\u02BD.WriteLine("Operating System: " + SystemInfo.operatingSystem);
			GameLogManager.\u02BB\u02B7\u02BA\u02B3\u02B4\u02B6\u02BA\u02BD\u02B8\u02BA\u02BD.WriteLine(string.Format("CPU: {0}, Count: {1}, Frequency: {2} MHz", SystemInfo.processorType, SystemInfo.processorCount, SystemInfo.processorFrequency));
			GameLogManager.\u02BB\u02B7\u02BA\u02B3\u02B4\u02B6\u02BA\u02BD\u02B8\u02BA\u02BD.WriteLine(string.Format("GPU: {0}, Driver Version: {1}, VRAM: {2} MBs", SystemInfo.graphicsDeviceName, SystemInfo.graphicsDeviceVersion, SystemInfo.graphicsMemorySize));
			GameLogManager.\u02BB\u02B7\u02BA\u02B3\u02B4\u02B6\u02BA\u02BD\u02B8\u02BA\u02BD.WriteLine(string.Format("RAM: {0} MBs", SystemInfo.systemMemorySize));
			GameLogManager.\u02BB\u02B7\u02BA\u02B3\u02B4\u02B6\u02BA\u02BD\u02B8\u02BA\u02BD.WriteLine(string.Format("Renderer: {0}", SystemInfo.graphicsDeviceType));
			string[] commandLineArgs = Environment.GetCommandLineArgs();
			if (commandLineArgs != null && commandLineArgs.Length > 1)
			{
				GameLogManager.\u02BB\u02B7\u02BA\u02B3\u02B4\u02B6\u02BA\u02BD\u02B8\u02BA\u02BD.WriteLine("Startup Parameters:");
				for (int i = 1; i < commandLineArgs.Length; i++)
				{
					GameLogManager.\u02BB\u02B7\u02BA\u02B3\u02B4\u02B6\u02BA\u02BD\u02B8\u02BA\u02BD.WriteLine(commandLineArgs[i]);
				}
			}
			GameLogManager.\u02BB\u02B7\u02BA\u02B3\u02B4\u02B6\u02BA\u02BD\u02B8\u02BA\u02BD.WriteLine("------------");
			GameLogManager.\u02BB\u02B7\u02BA\u02B3\u02B4\u02B6\u02BA\u02BD\u02B8\u02BA\u02BD.WriteLine(" ");
		}
	}

	public static string \u02BA\u02BF\u02B2\u02B6\u02B6\u02B5\u02BE\u02BF\u02BD\u02B4\u02BF()
	{
		return GameLogManager.\u02C1\u02B2\u02BE\u02B4\u02B3\u02BF\u02B2\u02BC\u02BB\u02BD\u02B8;
	}

	private static string \u02B8\u02B3\u02BC\u02B8\u02C0\u02B5\u02BE\u02BA\u02C0\u02C1\u02B8;

	private static string \u02BE\u02BD\u02BD\u02BE\u02C1\u02B8\u02BE\u02B6\u02B3\u02B4\u02BA;

	private static int \u02BB\u02B9\u02BA\u02BF\u02B2\u02B2\u02BD\u02BC\u02BE\u02B7\u02C1;

	private static string \u02C1\u02B2\u02BE\u02B4\u02B3\u02BF\u02B2\u02BC\u02BB\u02BD\u02B8;

	private static StreamWriter \u02BB\u02B7\u02BA\u02B3\u02B4\u02B6\u02BA\u02BD\u02B8\u02BA\u02BD;
}
