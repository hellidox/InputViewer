using System;
using System.Linq;

public static class \u02B2\u02BB\u02BD\u02C0\u02B7\u02BB\u02B2\u02B4\u02B6\u02B2\u02C1
{
	public static \u02B2\u02BB\u02BD\u02C0\u02B7\u02BB\u02B2\u02B4\u02B6\u02B2\u02C1.\u02B3\u02B4\u02BE\u02BF\u02B9\u02BF\u02B4\u02C0\u02BD\u02BA\u02BA \u02B5\u02BC\u02B4\u02B8\u02B6\u02B2\u02BE\u02C0\u02B2\u02BF\u02BC(byte[] \u02BD\u02BD\u02BF\u02BF\u02BE\u02B2\u02B5\u02BD\u02BC\u02B7\u02C0)
	{
		if (\u02BD\u02BD\u02BF\u02BF\u02BE\u02B2\u02B5\u02BD\u02BC\u02B7\u02C0.Length == 8)
		{
			\u02B2\u02BB\u02BD\u02C0\u02B7\u02BB\u02B2\u02B4\u02B6\u02B2\u02C1.\u02B3\u02B4\u02BE\u02BF\u02B9\u02BF\u02B4\u02C0\u02BD\u02BA\u02BA u02B3_u02B4_u02BE_u02BF_u02B9_u02BF_u02B4_u02C0_u02BD_u02BA_u02BA = default(\u02B2\u02BB\u02BD\u02C0\u02B7\u02BB\u02B2\u02B4\u02B6\u02B2\u02C1.\u02B3\u02B4\u02BE\u02BF\u02B9\u02BF\u02B4\u02C0\u02BD\u02BA\u02BA);
			int num = 0;
			byte[] array = new byte[3];
			\u02BD\u02BD\u02BF\u02BF\u02BE\u02B2\u02B5\u02BD\u02BC\u02B7\u02C0.\u02C1\u02B8\u02B2\u02BB\u02BC\u02BD\u02B4\u02BF\u02B9\u02B5\u02B5(ref num, array, 3U);
			if (array.SequenceEqual(\u02B2\u02BB\u02BD\u02C0\u02B7\u02BB\u02B2\u02B4\u02B6\u02B2\u02C1.\u02B9\u02C1\u02B6\u02BB\u02B3\u02BC\u02B6\u02BE\u02B8\u02B5\u02B8))
			{
				u02B3_u02B4_u02BE_u02BF_u02B9_u02BF_u02B4_u02C0_u02BD_u02BA_u02BA.\u02B2\u02BE\u02B9\u02C1\u02BA\u02C1\u02BC\u02B9\u02B7\u02B7\u02B4 = \u02BD\u02BD\u02BF\u02BF\u02BE\u02B2\u02B5\u02BD\u02BC\u02B7\u02C0.\u02B3\u02BC\u02B5\u02B4\u02BD\u02B2\u02BE\u02BE\u02BB\u02B8\u02B5(ref num);
				if (u02B3_u02B4_u02BE_u02BF_u02B9_u02BF_u02B4_u02C0_u02BD_u02BA_u02BA.\u02B2\u02BE\u02B9\u02C1\u02BA\u02C1\u02BC\u02B9\u02B7\u02B7\u02B4 == 0)
				{
					u02B3_u02B4_u02BE_u02BF_u02B9_u02BF_u02B4_u02C0_u02BD_u02BA_u02BA.\u02BF\u02B8\u02BD\u02BA\u02BE\u02BD\u02B4\u02BB\u02BC\u02B2\u02BE = \u02BD\u02BD\u02BF\u02BF\u02BE\u02B2\u02B5\u02BD\u02BC\u02B7\u02C0.\u02B3\u02BC\u02B5\u02B4\u02BD\u02B2\u02BE\u02BE\u02BB\u02B8\u02B5(ref num);
					u02B3_u02B4_u02BE_u02BF_u02B9_u02BF_u02B4_u02C0_u02BD_u02BA_u02BA.\u02BF\u02B9\u02B3\u02BC\u02BA\u02B2\u02B4\u02B4\u02BC\u02B3\u02B8 = \u02BD\u02BD\u02BF\u02BF\u02BE\u02B2\u02B5\u02BD\u02BC\u02B7\u02C0.\u02B3\u02BC\u02B5\u02B4\u02BD\u02B2\u02BE\u02BE\u02BB\u02B8\u02B5(ref num);
					u02B3_u02B4_u02BE_u02BF_u02B9_u02BF_u02B4_u02C0_u02BD_u02BA_u02BA.\u02C0\u02BA\u02B8\u02B9\u02B4\u02B8\u02BE\u02BA\u02BE\u02B6\u02B7 = \u02BD\u02BD\u02BF\u02BF\u02BE\u02B2\u02B5\u02BD\u02BC\u02B7\u02C0.\u02B3\u02BC\u02B5\u02B4\u02BD\u02B2\u02BE\u02BE\u02BB\u02B8\u02B5(ref num);
					u02B3_u02B4_u02BE_u02BF_u02B9_u02BF_u02B4_u02C0_u02BD_u02BA_u02BA.\u02C1\u02BA\u02BF\u02BE\u02B6\u02BB\u02BD\u02B6\u02B2\u02B9\u02B7 = true;
					return u02B3_u02B4_u02BE_u02BF_u02B9_u02BF_u02B4_u02C0_u02BD_u02BA_u02BA;
				}
			}
		}
		return default(\u02B2\u02BB\u02BD\u02C0\u02B7\u02BB\u02B2\u02B4\u02B6\u02B2\u02C1.\u02B3\u02B4\u02BE\u02BF\u02B9\u02BF\u02B4\u02C0\u02BD\u02BA\u02BA);
	}

	// Note: this type is marked as 'beforefieldinit'.
	static \u02B2\u02BB\u02BD\u02C0\u02B7\u02BB\u02B2\u02B4\u02B6\u02B2\u02C1()
	{
		byte[] array = new byte[3];
		array[0] = 80;
		array[1] = 83;
		\u02B2\u02BB\u02BD\u02C0\u02B7\u02BB\u02B2\u02B4\u02B6\u02B2\u02C1.\u02B9\u02C1\u02B6\u02BB\u02B3\u02BC\u02B6\u02BE\u02B8\u02B5\u02B8 = array;
	}

	private static readonly byte[] \u02B9\u02C1\u02B6\u02BB\u02B3\u02BC\u02B6\u02BE\u02B8\u02B5\u02B8;

	public struct \u02B3\u02B4\u02BE\u02BF\u02B9\u02BF\u02B4\u02C0\u02BD\u02BA\u02BA
	{
		public byte \u02B2\u02BE\u02B9\u02C1\u02BA\u02C1\u02BC\u02B9\u02B7\u02B7\u02B4;

		public byte \u02BF\u02B8\u02BD\u02BA\u02BE\u02BD\u02B4\u02BB\u02BC\u02B2\u02BE;

		public byte \u02BF\u02B9\u02B3\u02BC\u02BA\u02B2\u02B4\u02B4\u02BC\u02B3\u02B8;

		public byte \u02C0\u02BA\u02B8\u02B9\u02B4\u02B8\u02BE\u02BA\u02BE\u02B6\u02B7;

		public bool \u02C1\u02BA\u02BF\u02BE\u02B6\u02BB\u02BD\u02B6\u02B2\u02B9\u02B7;
	}
}
