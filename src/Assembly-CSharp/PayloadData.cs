using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography;

// Token: 0x02000364 RID: 868
internal class PayloadData
{
	// Token: 0x06001FD7 RID: 8151 RVA: 0x00018B40 File Offset: 0x00016D40
	public PayloadData()
	{
		this.data = null;
		this.hash = null;
	}

	// Token: 0x06001FD8 RID: 8152 RVA: 0x00018B56 File Offset: 0x00016D56
	public PayloadData(byte[] _data)
	{
		this.data = _data;
		this.hash = this.CalculateHash();
	}

	// Token: 0x06001FD9 RID: 8153 RVA: 0x000D6808 File Offset: 0x000D4A08
	private byte[] CalculateHash()
	{
		byte[] array;
		using (SHA1 sha = SHA1.Create())
		{
			array = sha.ComputeHash(this.data);
		}
		return array;
	}

	// Token: 0x06001FDA RID: 8154 RVA: 0x00018B71 File Offset: 0x00016D71
	public bool VerifyHash()
	{
		return this.hash.SequenceEqual(this.CalculateHash());
	}

	// Token: 0x06001FDB RID: 8155 RVA: 0x000D6848 File Offset: 0x000D4A48
	public byte[] BuildPayload()
	{
		byte[] array;
		using (MemoryStream memoryStream = new MemoryStream())
		{
			using (BinaryWriter binaryWriter = new BinaryWriter(memoryStream))
			{
				binaryWriter.Write(0L);
				binaryWriter.Write(this.hash.Length);
				binaryWriter.Write(this.hash);
				binaryWriter.Write(this.data.Length);
				binaryWriter.Write(this.data);
				binaryWriter.Flush();
				binaryWriter.BaseStream.Position = 0L;
				binaryWriter.Write(memoryStream.Length);
			}
			array = memoryStream.ToArray();
		}
		return array;
	}

	// Token: 0x06001FDC RID: 8156 RVA: 0x000D68FC File Offset: 0x000D4AFC
	public void ReadPayload(Stream sourceStream)
	{
		using (BinaryReader binaryReader = new BinaryReader(sourceStream))
		{
			binaryReader.ReadInt64();
			int num = binaryReader.ReadInt32();
			this.hash = binaryReader.ReadBytes(num);
			int num2 = binaryReader.ReadInt32();
			this.data = binaryReader.ReadBytes(num2);
		}
	}

	// Token: 0x06001FDD RID: 8157 RVA: 0x000D695C File Offset: 0x000D4B5C
	public void ReadPayload(byte[] source)
	{
		using (MemoryStream memoryStream = new MemoryStream(source))
		{
			this.ReadPayload(memoryStream);
		}
	}

	// Token: 0x040018F9 RID: 6393
	public byte[] hash;

	// Token: 0x040018FA RID: 6394
	public byte[] data;
}
