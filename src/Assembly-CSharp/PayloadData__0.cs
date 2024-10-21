using System;
using System.IO;

// Token: 0x02000377 RID: 887
internal class PayloadData__0
{
	// Token: 0x0600203D RID: 8253 RVA: 0x00018CF4 File Offset: 0x00016EF4
	public PayloadData__0()
	{
		this.data = null;
		this.hash = null;
	}

	// Token: 0x0600203E RID: 8254 RVA: 0x00018D0A File Offset: 0x00016F0A
	public PayloadData__0(byte[] _data)
	{
		this.data = _data;
		this.hash = new byte[1];
	}

	// Token: 0x0600203F RID: 8255 RVA: 0x000D8278 File Offset: 0x000D6478
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

	// Token: 0x06002040 RID: 8256 RVA: 0x000D832C File Offset: 0x000D652C
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

	// Token: 0x06002041 RID: 8257 RVA: 0x000D838C File Offset: 0x000D658C
	public void ReadPayload(byte[] source)
	{
		using (MemoryStream memoryStream = new MemoryStream(source))
		{
			this.ReadPayload(memoryStream);
		}
	}

	// Token: 0x0400199C RID: 6556
	public byte[] hash;

	// Token: 0x0400199D RID: 6557
	public byte[] data;
}
