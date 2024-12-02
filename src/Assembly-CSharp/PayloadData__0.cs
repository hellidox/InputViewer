using System;
using System.IO;

internal class PayloadData__0
{
	public PayloadData__0()
	{
		this.data = null;
		this.hash = null;
	}

	public PayloadData__0(byte[] _data)
	{
		this.data = _data;
		this.hash = new byte[1];
	}

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

	public void ReadPayload(byte[] source)
	{
		using (MemoryStream memoryStream = new MemoryStream(source))
		{
			this.ReadPayload(memoryStream);
		}
	}

	public byte[] hash;

	public byte[] data;
}
