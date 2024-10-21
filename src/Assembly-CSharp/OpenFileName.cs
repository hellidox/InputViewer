using System;
using System.Runtime.InteropServices;

// Token: 0x02000379 RID: 889
public class OpenFileName
{
	// Token: 0x0400199E RID: 6558
	public int structSize = Marshal.SizeOf(typeof(OpenFileName));

	// Token: 0x0400199F RID: 6559
	public IntPtr dlgOwner = IntPtr.Zero;

	// Token: 0x040019A0 RID: 6560
	public IntPtr instance = IntPtr.Zero;

	// Token: 0x040019A1 RID: 6561
	public string filter;

	// Token: 0x040019A2 RID: 6562
	public string customFilter;

	// Token: 0x040019A3 RID: 6563
	public int maxCustFilter;

	// Token: 0x040019A4 RID: 6564
	public int filterIndex;

	// Token: 0x040019A5 RID: 6565
	public string file;

	// Token: 0x040019A6 RID: 6566
	public int maxFile = 256;

	// Token: 0x040019A7 RID: 6567
	public string fileTitle;

	// Token: 0x040019A8 RID: 6568
	public int maxFileTitle = 64;

	// Token: 0x040019A9 RID: 6569
	public string initialDir;

	// Token: 0x040019AA RID: 6570
	public string title;

	// Token: 0x040019AB RID: 6571
	public int flags = 8;

	// Token: 0x040019AC RID: 6572
	public ushort fileOffset;

	// Token: 0x040019AD RID: 6573
	public ushort fileExtension;

	// Token: 0x040019AE RID: 6574
	public string defExt;

	// Token: 0x040019AF RID: 6575
	public IntPtr custData = IntPtr.Zero;

	// Token: 0x040019B0 RID: 6576
	public IntPtr hook = IntPtr.Zero;

	// Token: 0x040019B1 RID: 6577
	public string templateName;

	// Token: 0x040019B2 RID: 6578
	public IntPtr reservedPtr = IntPtr.Zero;

	// Token: 0x040019B3 RID: 6579
	public int reservedInt;

	// Token: 0x040019B4 RID: 6580
	public int flagsEx;
}
