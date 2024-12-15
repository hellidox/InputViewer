using System;
using System.Linq;

public static class AExtensions
{
	public static byte[] ToByteArray(this char[] src)
	{
		return src.Select((char x) => (byte)x).ToArray<byte>();
	}

	public static byte[] ToByteArray(this string src)
	{
		return src.ToCharArray().ToByteArray();
	}
}
