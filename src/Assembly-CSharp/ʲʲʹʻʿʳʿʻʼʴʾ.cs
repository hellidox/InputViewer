using System;
using System.IO;
using System.IO.Compression;

// Token: 0x0200001E RID: 30
public static class \u02B2\u02B2\u02B9\u02BB\u02BF\u02B3\u02BF\u02BB\u02BC\u02B4\u02BE
{
	// Token: 0x06000131 RID: 305 RVA: 0x0001F028 File Offset: 0x0001D228
	public static byte[] \u02BA\u02BC\u02B3\u02B5\u02BB\u02BA\u02BB\u02BF\u02B9\u02B5\u02BB(byte[] \u02BD\u02BD\u02BF\u02BF\u02BE\u02B2\u02B5\u02BD\u02BC\u02B7\u02C0)
	{
		Stream stream = new MemoryStream(\u02BD\u02BD\u02BF\u02BF\u02BE\u02B2\u02B5\u02BD\u02BC\u02B7\u02C0);
		MemoryStream memoryStream = new MemoryStream();
		using (DeflateStream deflateStream = new DeflateStream(stream, CompressionMode.Decompress))
		{
			deflateStream.CopyTo(memoryStream);
		}
		return memoryStream.ToArray();
	}
}
