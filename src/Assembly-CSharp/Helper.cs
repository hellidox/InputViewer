using System;
using System.IO;
using ErrorCorrection;

public static class Helper
{
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
