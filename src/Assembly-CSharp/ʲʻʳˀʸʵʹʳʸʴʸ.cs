using System;
using System.IO;
using System.Security.Cryptography;

internal class \u02B2\u02BB\u02B3\u02C0\u02B8\u02B5\u02B9\u02B3\u02B8\u02B4\u02B8
{
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

	private byte[] \u02B7\u02B5\u02C0\u02BA\u02B4\u02BE\u02B9\u02B3\u02BF\u02BB\u02BB()
	{
		byte[] array;
		using (SHA1 sha = SHA1.Create())
		{
			array = sha.ComputeHash(this.\u02BD\u02BD\u02BF\u02BF\u02BE\u02B2\u02B5\u02BD\u02BC\u02B7\u02C0);
		}
		return array;
	}

	public \u02B2\u02BB\u02B3\u02C0\u02B8\u02B5\u02B9\u02B3\u02B8\u02B4\u02B8(byte[] \u02B9\u02B5\u02BE\u02B5\u02B8\u02C1\u02BA\u02B9\u02BC\u02B9\u02B6)
	{
		this.\u02BD\u02BD\u02BF\u02BF\u02BE\u02B2\u02B5\u02BD\u02BC\u02B7\u02C0 = \u02B9\u02B5\u02BE\u02B5\u02B8\u02C1\u02BA\u02B9\u02BC\u02B9\u02B6;
		this.\u02B7\u02C1\u02BF\u02B4\u02B8\u02B6\u02B3\u02B8\u02B2\u02BB\u02B2 = this.\u02B7\u02B5\u02C0\u02BA\u02B4\u02BE\u02B9\u02B3\u02BF\u02BB\u02BB();
	}

	public byte[] \u02B7\u02C1\u02BF\u02B4\u02B8\u02B6\u02B3\u02B8\u02B2\u02BB\u02B2;

	public byte[] \u02BD\u02BD\u02BF\u02BF\u02BE\u02B2\u02B5\u02BD\u02BC\u02B7\u02C0;
}
