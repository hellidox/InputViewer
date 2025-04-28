using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

public static class w32util
{
	public static List<int> GetFileLockers(string path)
	{
		string text = Guid.NewGuid().ToString();
		uint num2;
		int num = w32util.RmStartSession(out num2, 0, text);
		if (num != 0)
		{
			throw new Exception("rmstart failed");
		}
		try
		{
			uint num3 = 0U;
			uint num4 = 0U;
			string[] array = new string[] { path };
			num = w32util.RmRegisterResources(num2, (uint)array.Length, array, 0U, null, 0U, null);
			if (num != 0)
			{
				throw new Exception("rmregisterresource failed");
			}
			uint num5;
			num = w32util.RmGetList(num2, out num5, ref num3, null, ref num4);
			if (num == 234)
			{
				return w32util.EnumerateProcesses(num5, num2, num4);
			}
			if (num != 0)
			{
				throw new Exception("rmgetlist failed");
			}
		}
		finally
		{
			w32util.RmEndSession(num2);
		}
		return new List<int>();
	}

	[DllImport("rstrtmgr.dll", CharSet = CharSet.Unicode)]
	private static extern int RmRegisterResources(uint pSessionHandle, uint nFiles, string[] rgsFilenames, uint nApplications, [In] w32util.RM_UNIQUE_PROCESS[] rgApplications, uint nServices, string[] rgsServiceNames);

	[DllImport("rstrtmgr.dll", CharSet = CharSet.Auto)]
	private static extern int RmStartSession(out uint pSessionHandle, int dwSessionFlags, string strSessionKey);

	[DllImport("rstrtmgr.dll")]
	private static extern int RmEndSession(uint pSessionHandle);

	[DllImport("rstrtmgr.dll")]
	private static extern int RmGetList(uint dwSessionHandle, out uint pnProcInfoNeeded, ref uint pnProcInfo, [In] [Out] w32util.RM_PROCESS_INFO[] rgAffectedApps, ref uint lpdwRebootReasons);

	private static List<int> EnumerateProcesses(uint pnProcInfoNeeded, uint handle, uint lpdwRebootReasons)
	{
		List<int> list = new List<int>();
		w32util.RM_PROCESS_INFO[] array = new w32util.RM_PROCESS_INFO[pnProcInfoNeeded];
		uint num = pnProcInfoNeeded;
		if (w32util.RmGetList(handle, out pnProcInfoNeeded, ref num, array, ref lpdwRebootReasons) != 0)
		{
			throw new Exception("rmgetlist failed");
		}
		int num2 = 0;
		while ((long)num2 < (long)((ulong)num))
		{
			try
			{
				list.Add(array[num2].Process.dwProcessId);
			}
			catch (ArgumentException)
			{
			}
			num2++;
		}
		return list;
	}

	private const int RmRebootReasonNone = 0;

	private const int CCH_RM_MAX_APP_NAME = 255;

	private const int CCH_RM_MAX_SVC_NAME = 63;

	public struct RM_UNIQUE_PROCESS
	{
		public int dwProcessId;

		public long ProcessStartTime;
	}

	public enum RM_APP_TYPE
	{
		RmUnknownApp,
		RmMainWindow,
		RmOtherWindow,
		RmService,
		RmExplorer,
		RmConsole,
		RmCritical = 1000
	}

	public struct RM_PROCESS_INFO
	{
		public w32util.RM_UNIQUE_PROCESS Process;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
		public string strAppName;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
		public string strServiceShortName;

		public w32util.RM_APP_TYPE ApplicationType;

		public uint AppStatus;

		public uint TSSessionId;

		[MarshalAs(UnmanagedType.Bool)]
		public bool bRestartable;
	}
}
