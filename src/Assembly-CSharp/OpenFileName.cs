using System;
using System.Runtime.InteropServices;

public class OpenFileName
{
	public int structSize = Marshal.SizeOf(typeof(OpenFileName));

	public IntPtr dlgOwner = IntPtr.Zero;

	public IntPtr instance = IntPtr.Zero;

	public string filter;

	public string customFilter;

	public int maxCustFilter;

	public int filterIndex;

	public string file;

	public int maxFile = 256;

	public string fileTitle;

	public int maxFileTitle = 64;

	public string initialDir;

	public string title;

	public int flags = 8;

	public ushort fileOffset;

	public ushort fileExtension;

	public string defExt;

	public IntPtr custData = IntPtr.Zero;

	public IntPtr hook = IntPtr.Zero;

	public string templateName;

	public IntPtr reservedPtr = IntPtr.Zero;

	public int reservedInt;

	public int flagsEx;
}
