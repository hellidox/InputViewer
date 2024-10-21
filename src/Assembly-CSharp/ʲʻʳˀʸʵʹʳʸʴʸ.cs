using System;
using System.IO;
using System.Security.Cryptography;

// Token: 0x02000054 RID: 84
internal class \u02B2\u02BB\u02B3\u02C0\u02B8\u02B5\u02B9\u02B3\u02B8\u02B4\u02B8
{
	// Token: 0x06000387 RID: 903 RVA: 0x0002BA34 File Offset: 0x00029C34
	public byte[] \u02BC\u02B3\u02B5\u02B9\u02B8\u02BC\u02B7\u02B9\u02B3\u02B8\u02BF()
	{
		byte[] array;
		using (MemoryStream memoryStream = new MemoryStream())
		{
			using (BinaryWriter binaryWriter = new BinaryWriter(memoryStream))
			{
				binaryWriter.Write(0L);
				binaryWriter.Write(this.\u02B7\u02C1\u02BF\u02B4\u02B8\u02B6\u02B3\u02B8\u02B2\u02BB\u02B2.Length);
				binaryWriter.Write(this.\u02B7\u02C1\u02BF\u02B4\u02B8\u02B6\u02B3\u02B8\u02B2\u02BB\u02B2);
				binaryWriter.Write(this.\u02BD\u02BD\u02BF\u02BF\u02BE\u02B2\u02B5\u02BD\u02BC\u02B7\u02C0.Length);
				binaryWriter.Write(this.\u02BD\u02BD\u02BF\u02BF\u02BE\u02B2\u02B5\u02BD\u02BC\u02B7\u02C0);
				binaryWriter.Flush();
				binaryWriter.BaseStream.Position = 0L;
				binaryWriter.Write(memoryStream.Length);
			}
			array = memoryStream.ToArray();
		}
		return array;
	}

	// Token: 0x06000388 RID: 904 RVA: 0x0002BAE8 File Offset: 0x00029CE8
	private byte[] \u02B7\u02B5\u02C0\u02BA\u02B4\u02BE\u02B9\u02B3\u02BF\u02BB\u02BB()
	{
		byte[] array;
		using (SHA1 sha = SHA1.Create())
		{
			array = sha.ComputeHash(this.\u02BD\u02BD\u02BF\u02BF\u02BE\u02B2\u02B5\u02BD\u02BC\u02B7\u02C0);
		}
		return array;
	}

	// Token: 0x06000389 RID: 905 RVA: 0x00007CE2 File Offset: 0x00005EE2
	public \u02B2\u02BB\u02B3\u02C0\u02B8\u02B5\u02B9\u02B3\u02B8\u02B4\u02B8(byte[] \u02B9\u02B5\u02BE\u02B5\u02B8\u02C1\u02BA\u02B9\u02BC\u02B9\u02B6)
	{
		this.\u02BD\u02BD\u02BF\u02BF\u02BE\u02B2\u02B5\u02BD\u02BC\u02B7\u02C0 = \u02B9\u02B5\u02BE\u02B5\u02B8\u02C1\u02BA\u02B9\u02BC\u02B9\u02B6;
		this.\u02B7\u02C1\u02BF\u02B4\u02B8\u02B6\u02B3\u02B8\u02B2\u02BB\u02B2 = this.\u02B7\u02B5\u02C0\u02BA\u02B4\u02BE\u02B9\u02B3\u02BF\u02BB\u02BB();
	}

	// Token: 0x0400025E RID: 606
	public byte[] \u02B7\u02C1\u02BF\u02B4\u02B8\u02B6\u02B3\u02B8\u02B2\u02BB\u02B2;

	// Token: 0x0400025F RID: 607
	public byte[] \u02BD\u02BD\u02BF\u02BF\u02BE\u02B2\u02B5\u02BD\u02BC\u02B7\u02C0;
}
