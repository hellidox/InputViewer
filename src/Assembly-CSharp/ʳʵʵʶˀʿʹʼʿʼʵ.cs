using System;
using Cysharp.Text;
using StrikeCore.Logging;
using UnityEngine;

internal class \u02B3\u02B5\u02B5\u02B6\u02C0\u02BF\u02B9\u02BC\u02BF\u02BC\u02B5 : ILogProvider
{
	public void WriteLog(ref Utf16ValueStringBuilder \u02BD\u02B3\u02B7\u02B8\u02B6\u02BF\u02B7\u02B8\u02C1\u02B5\u02BA, LogEntry \u02B8\u02BB\u02BA\u02BD\u02BB\u02B6\u02BC\u02BB\u02BB\u02B8\u02B4)
	{
		UnityWrapper.\u02BC\u02B7\u02B4\u02B2\u02BE\u02B2\u02BD\u02BD\u02B9\u02BC\u02B8(this.\u02B2\u02BF\u02B6\u02BD\u02BA\u02BD\u02BF\u02B4\u02B3\u02C1\u02BF(\u02B8\u02BB\u02BA\u02BD\u02BB\u02B6\u02BC\u02BB\u02BB\u02B8\u02B4.Level), LogOption.NoStacktrace, \u02BD\u02B3\u02B7\u02B8\u02B6\u02BF\u02B7\u02B8\u02C1\u02B5\u02BA.ToString(), null);
	}

	private LogType \u02B2\u02BF\u02B6\u02BD\u02BA\u02BD\u02BF\u02B4\u02B3\u02C1\u02BF(LogLevel \u02BE\u02B9\u02BE\u02B8\u02BE\u02B2\u02B6\u02C0\u02B4\u02C0\u02BF)
	{
		switch (\u02BE\u02B9\u02BE\u02B8\u02BE\u02B2\u02B6\u02C0\u02B4\u02C0\u02BF)
		{
		case LogLevel.Error:
			return LogType.Error;
		case LogLevel.Warning:
			return LogType.Warning;
		case LogLevel.Information:
			return LogType.Log;
		case LogLevel.Debug:
			return LogType.Log;
		case LogLevel.Trace:
			return LogType.Log;
		default:
			return LogType.Log;
		}
	}
}
