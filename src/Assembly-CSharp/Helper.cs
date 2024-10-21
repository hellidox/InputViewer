using System;
using System.IO;
using ErrorCorrection;

// Token: 0x02000363 RID: 867
public static class Helper
{
	// Token: 0x06001FD5 RID: 8149 RVA: 0x000D66FC File Offset: 0x000D48FC
	public static byte[] EncodeReedSoloman(byte[] source)
	{
		MemoryStream memoryStream = new MemoryStream();
		Encoder encoder = new Encoder(256, 239, 16, 285);
		using (RsEncoderStream rsEncoderStream = new RsEncoderStream(memoryStream, encoder))
		{
			using (BlockStreamWriteAdapter blockStreamWriteAdapter = new BlockStreamWriteAdapter(rsEncoderStream, encoder.MessageSize))
			{
				blockStreamWriteAdapter.Write(source, 0, source.Length);
				blockStreamWriteAdapter.Flush();
			}
		}
		return memoryStream.ToArray();
	}

	// Token: 0x06001FD6 RID: 8150 RVA: 0x000D6784 File Offset: 0x000D4984
	public static byte[] DecodeReedSoloman(byte[] source)
	{
		Stream stream = new MemoryStream(source);
		MemoryStream memoryStream = new MemoryStream();
		Decoder decoder = new Decoder(256, 239, 16, 285);
		using (RsDecoderStream rsDecoderStream = new RsDecoderStream(stream, decoder))
		{
			using (BlockStreamReadAdapter blockStreamReadAdapter = new BlockStreamReadAdapter(rsDecoderStream, decoder.MessageSize))
			{
				blockStreamReadAdapter.CopyTo(memoryStream);
			}
		}
		return memoryStream.ToArray();
	}
}
