﻿using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Token: 0x0200001D RID: 29
public class \u02B7\u02BA\u02B9\u02B7\u02BA\u02B9\u02BA\u02C1\u02B5\u02B4\u02BC
{
	// Token: 0x06000129 RID: 297 RVA: 0x0001E8F0 File Offset: 0x0001CAF0
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static uint \u02B6\u02B6\u02C0\u02BF\u02B5\u02C1\u02BF\u02C1\u02B9\u02B4\u02BA(uint \u02BF\u02BB\u02B9\u02B7\u02B9\u02BF\u02BD\u02B5\u02BC\u02B3\u02BF)
	{
		return (uint)((int)\u02B7\u02BA\u02B9\u02B7\u02BA\u02B9\u02BA\u02C1\u02B5\u02B4\u02BC.\u02BD\u02B3\u02BB\u02B6\u02BE\u02BB\u02B2\u02BB\u02BD\u02B6\u02B2[(int)(\u02BF\u02BB\u02B9\u02B7\u02B9\u02BF\u02BD\u02B5\u02BC\u02B3\u02BF & 255U)] | ((int)\u02B7\u02BA\u02B9\u02B7\u02BA\u02B9\u02BA\u02C1\u02B5\u02B4\u02BC.\u02BD\u02B3\u02BB\u02B6\u02BE\u02BB\u02B2\u02BB\u02BD\u02B6\u02B2[(int)((\u02BF\u02BB\u02B9\u02B7\u02B9\u02BF\u02BD\u02B5\u02BC\u02B3\u02BF >> 8) & 255U)] << 8) | ((int)\u02B7\u02BA\u02B9\u02B7\u02BA\u02B9\u02BA\u02C1\u02B5\u02B4\u02BC.\u02BD\u02B3\u02BB\u02B6\u02BE\u02BB\u02B2\u02BB\u02BD\u02B6\u02B2[(int)((\u02BF\u02BB\u02B9\u02B7\u02B9\u02BF\u02BD\u02B5\u02BC\u02B3\u02BF >> 16) & 255U)] << 16) | ((int)\u02B7\u02BA\u02B9\u02B7\u02BA\u02B9\u02BA\u02C1\u02B5\u02B4\u02BC.\u02BD\u02B3\u02BB\u02B6\u02BE\u02BB\u02B2\u02BB\u02BD\u02B6\u02B2[(int)((\u02BF\u02BB\u02B9\u02B7\u02B9\u02BF\u02BD\u02B5\u02BC\u02B3\u02BF >> 24) & 255U)] << 24));
	}

	// Token: 0x0600012A RID: 298 RVA: 0x0001E944 File Offset: 0x0001CB44
	public unsafe int \u02B4\u02B3\u02BD\u02B5\u02C0\u02B6\u02C1\u02B6\u02C1\u02B5\u02C0(byte* \u02B7\u02BD\u02BA\u02BA\u02B7\u02BB\u02B6\u02BA\u02BB\u02B2\u02BF, byte* \u02BC\u02B5\u02C0\u02B6\u02B7\u02B8\u02BF\u02C1\u02B5\u02BF\u02C1)
	{
		uint[][] u02B5_u02C0_u02BC_u02B2_u02B9_u02BD_u02B6_u02BA_u02B5_u02B3_u02B = this.\u02B5\u02C0\u02BC\u02B2\u02B9\u02BD\u02B6\u02BA\u02B5\u02B3\u02B4;
		uint[] array = u02B5_u02C0_u02BC_u02B2_u02B9_u02BD_u02B6_u02BA_u02B5_u02B3_u02B[0];
		uint num = *(uint*)\u02B7\u02BD\u02BA\u02BA\u02B7\u02BB\u02B6\u02BA\u02BB\u02B2\u02BF ^ array[0];
		uint num2 = *(uint*)(\u02B7\u02BD\u02BA\u02BA\u02B7\u02BB\u02B6\u02BA\u02BB\u02B2\u02BF + 4) ^ array[1];
		uint num3 = *(uint*)(\u02B7\u02BD\u02BA\u02BA\u02B7\u02BB\u02B6\u02BA\u02BB\u02B2\u02BF + (IntPtr)2 * 4) ^ array[2];
		uint num4 = *(uint*)(\u02B7\u02BD\u02BA\u02BA\u02B7\u02BB\u02B6\u02BA\u02BB\u02B2\u02BF + (IntPtr)3 * 4) ^ array[3];
		int i = 1;
		uint num5;
		uint num6;
		uint num7;
		while (i < 9)
		{
			array = u02B5_u02C0_u02BC_u02B2_u02B9_u02BD_u02B6_u02BA_u02B5_u02B3_u02B[i++];
			num5 = \u02B7\u02BA\u02B9\u02B7\u02BA\u02B9\u02BA\u02C1\u02B5\u02B4\u02BC.\u02BB\u02BC\u02B2\u02BF\u02B6\u02C1\u02C1\u02B9\u02BC\u02B4\u02BC[(int)(num & 255U)] ^ \u02B7\u02BA\u02B9\u02B7\u02BA\u02B9\u02BA\u02C1\u02B5\u02B4\u02BC.\u02BA\u02B3\u02BA\u02B9\u02BB\u02B2\u02B3\u02C1\u02C0\u02BC\u02C0(\u02B7\u02BA\u02B9\u02B7\u02BA\u02B9\u02BA\u02C1\u02B5\u02B4\u02BC.\u02BB\u02BC\u02B2\u02BF\u02B6\u02C1\u02C1\u02B9\u02BC\u02B4\u02BC[(int)((num2 >> 8) & 255U)]) ^ \u02B7\u02BA\u02B9\u02B7\u02BA\u02B9\u02BA\u02C1\u02B5\u02B4\u02BC.\u02C0\u02BE\u02B5\u02B9\u02B2\u02B5\u02B5\u02C0\u02BF\u02C0\u02BA(\u02B7\u02BA\u02B9\u02B7\u02BA\u02B9\u02BA\u02C1\u02B5\u02B4\u02BC.\u02BB\u02BC\u02B2\u02BF\u02B6\u02C1\u02C1\u02B9\u02BC\u02B4\u02BC[(int)((num3 >> 16) & 255U)]) ^ \u02B7\u02BA\u02B9\u02B7\u02BA\u02B9\u02BA\u02C1\u02B5\u02B4\u02BC.\u02B7\u02BB\u02B9\u02BB\u02BD\u02BF\u02B3\u02B9\u02C0\u02BB\u02BE(\u02B7\u02BA\u02B9\u02B7\u02BA\u02B9\u02BA\u02C1\u02B5\u02B4\u02BC.\u02BB\u02BC\u02B2\u02BF\u02B6\u02C1\u02C1\u02B9\u02BC\u02B4\u02BC[(int)((num4 >> 24) & 255U)]) ^ array[0];
			num6 = \u02B7\u02BA\u02B9\u02B7\u02BA\u02B9\u02BA\u02C1\u02B5\u02B4\u02BC.\u02BB\u02BC\u02B2\u02BF\u02B6\u02C1\u02C1\u02B9\u02BC\u02B4\u02BC[(int)(num2 & 255U)] ^ \u02B7\u02BA\u02B9\u02B7\u02BA\u02B9\u02BA\u02C1\u02B5\u02B4\u02BC.\u02BA\u02B3\u02BA\u02B9\u02BB\u02B2\u02B3\u02C1\u02C0\u02BC\u02C0(\u02B7\u02BA\u02B9\u02B7\u02BA\u02B9\u02BA\u02C1\u02B5\u02B4\u02BC.\u02BB\u02BC\u02B2\u02BF\u02B6\u02C1\u02C1\u02B9\u02BC\u02B4\u02BC[(int)((num3 >> 8) & 255U)]) ^ \u02B7\u02BA\u02B9\u02B7\u02BA\u02B9\u02BA\u02C1\u02B5\u02B4\u02BC.\u02C0\u02BE\u02B5\u02B9\u02B2\u02B5\u02B5\u02C0\u02BF\u02C0\u02BA(\u02B7\u02BA\u02B9\u02B7\u02BA\u02B9\u02BA\u02C1\u02B5\u02B4\u02BC.\u02BB\u02BC\u02B2\u02BF\u02B6\u02C1\u02C1\u02B9\u02BC\u02B4\u02BC[(int)((num4 >> 16) & 255U)]) ^ \u02B7\u02BA\u02B9\u02B7\u02BA\u02B9\u02BA\u02C1\u02B5\u02B4\u02BC.\u02B7\u02BB\u02B9\u02BB\u02BD\u02BF\u02B3\u02B9\u02C0\u02BB\u02BE(\u02B7\u02BA\u02B9\u02B7\u02BA\u02B9\u02BA\u02C1\u02B5\u02B4\u02BC.\u02BB\u02BC\u02B2\u02BF\u02B6\u02C1\u02C1\u02B9\u02BC\u02B4\u02BC[(int)((num >> 24) & 255U)]) ^ array[1];
			num7 = \u02B7\u02BA\u02B9\u02B7\u02BA\u02B9\u02BA\u02C1\u02B5\u02B4\u02BC.\u02BB\u02BC\u02B2\u02BF\u02B6\u02C1\u02C1\u02B9\u02BC\u02B4\u02BC[(int)(num3 & 255U)] ^ \u02B7\u02BA\u02B9\u02B7\u02BA\u02B9\u02BA\u02C1\u02B5\u02B4\u02BC.\u02BA\u02B3\u02BA\u02B9\u02BB\u02B2\u02B3\u02C1\u02C0\u02BC\u02C0(\u02B7\u02BA\u02B9\u02B7\u02BA\u02B9\u02BA\u02C1\u02B5\u02B4\u02BC.\u02BB\u02BC\u02B2\u02BF\u02B6\u02C1\u02C1\u02B9\u02BC\u02B4\u02BC[(int)((num4 >> 8) & 255U)]) ^ \u02B7\u02BA\u02B9\u02B7\u02BA\u02B9\u02BA\u02C1\u02B5\u02B4\u02BC.\u02C0\u02BE\u02B5\u02B9\u02B2\u02B5\u02B5\u02C0\u02BF\u02C0\u02BA(\u02B7\u02BA\u02B9\u02B7\u02BA\u02B9\u02BA\u02C1\u02B5\u02B4\u02BC.\u02BB\u02BC\u02B2\u02BF\u02B6\u02C1\u02C1\u02B9\u02BC\u02B4\u02BC[(int)((num >> 16) & 255U)]) ^ \u02B7\u02BA\u02B9\u02B7\u02BA\u02B9\u02BA\u02C1\u02B5\u02B4\u02BC.\u02B7\u02BB\u02B9\u02BB\u02BD\u02BF\u02B3\u02B9\u02C0\u02BB\u02BE(\u02B7\u02BA\u02B9\u02B7\u02BA\u02B9\u02BA\u02C1\u02B5\u02B4\u02BC.\u02BB\u02BC\u02B2\u02BF\u02B6\u02C1\u02C1\u02B9\u02BC\u02B4\u02BC[(int)((num2 >> 24) & 255U)]) ^ array[2];
			num4 = \u02B7\u02BA\u02B9\u02B7\u02BA\u02B9\u02BA\u02C1\u02B5\u02B4\u02BC.\u02BB\u02BC\u02B2\u02BF\u02B6\u02C1\u02C1\u02B9\u02BC\u02B4\u02BC[(int)(num4 & 255U)] ^ \u02B7\u02BA\u02B9\u02B7\u02BA\u02B9\u02BA\u02C1\u02B5\u02B4\u02BC.\u02BA\u02B3\u02BA\u02B9\u02BB\u02B2\u02B3\u02C1\u02C0\u02BC\u02C0(\u02B7\u02BA\u02B9\u02B7\u02BA\u02B9\u02BA\u02C1\u02B5\u02B4\u02BC.\u02BB\u02BC\u02B2\u02BF\u02B6\u02C1\u02C1\u02B9\u02BC\u02B4\u02BC[(int)((num >> 8) & 255U)]) ^ \u02B7\u02BA\u02B9\u02B7\u02BA\u02B9\u02BA\u02C1\u02B5\u02B4\u02BC.\u02C0\u02BE\u02B5\u02B9\u02B2\u02B5\u02B5\u02C0\u02BF\u02C0\u02BA(\u02B7\u02BA\u02B9\u02B7\u02BA\u02B9\u02BA\u02C1\u02B5\u02B4\u02BC.\u02BB\u02BC\u02B2\u02BF\u02B6\u02C1\u02C1\u02B9\u02BC\u02B4\u02BC[(int)((num2 >> 16) & 255U)]) ^ \u02B7\u02BA\u02B9\u02B7\u02BA\u02B9\u02BA\u02C1\u02B5\u02B4\u02BC.\u02B7\u02BB\u02B9\u02BB\u02BD\u02BF\u02B3\u02B9\u02C0\u02BB\u02BE(\u02B7\u02BA\u02B9\u02B7\u02BA\u02B9\u02BA\u02C1\u02B5\u02B4\u02BC.\u02BB\u02BC\u02B2\u02BF\u02B6\u02C1\u02C1\u02B9\u02BC\u02B4\u02BC[(int)((num3 >> 24) & 255U)]) ^ array[3];
			array = u02B5_u02C0_u02BC_u02B2_u02B9_u02BD_u02B6_u02BA_u02B5_u02B3_u02B[i++];
			num = \u02B7\u02BA\u02B9\u02B7\u02BA\u02B9\u02BA\u02C1\u02B5\u02B4\u02BC.\u02BB\u02BC\u02B2\u02BF\u02B6\u02C1\u02C1\u02B9\u02BC\u02B4\u02BC[(int)(num5 & 255U)] ^ \u02B7\u02BA\u02B9\u02B7\u02BA\u02B9\u02BA\u02C1\u02B5\u02B4\u02BC.\u02BA\u02B3\u02BA\u02B9\u02BB\u02B2\u02B3\u02C1\u02C0\u02BC\u02C0(\u02B7\u02BA\u02B9\u02B7\u02BA\u02B9\u02BA\u02C1\u02B5\u02B4\u02BC.\u02BB\u02BC\u02B2\u02BF\u02B6\u02C1\u02C1\u02B9\u02BC\u02B4\u02BC[(int)((num6 >> 8) & 255U)]) ^ \u02B7\u02BA\u02B9\u02B7\u02BA\u02B9\u02BA\u02C1\u02B5\u02B4\u02BC.\u02C0\u02BE\u02B5\u02B9\u02B2\u02B5\u02B5\u02C0\u02BF\u02C0\u02BA(\u02B7\u02BA\u02B9\u02B7\u02BA\u02B9\u02BA\u02C1\u02B5\u02B4\u02BC.\u02BB\u02BC\u02B2\u02BF\u02B6\u02C1\u02C1\u02B9\u02BC\u02B4\u02BC[(int)((num7 >> 16) & 255U)]) ^ \u02B7\u02BA\u02B9\u02B7\u02BA\u02B9\u02BA\u02C1\u02B5\u02B4\u02BC.\u02B7\u02BB\u02B9\u02BB\u02BD\u02BF\u02B3\u02B9\u02C0\u02BB\u02BE(\u02B7\u02BA\u02B9\u02B7\u02BA\u02B9\u02BA\u02C1\u02B5\u02B4\u02BC.\u02BB\u02BC\u02B2\u02BF\u02B6\u02C1\u02C1\u02B9\u02BC\u02B4\u02BC[(int)((num4 >> 24) & 255U)]) ^ array[0];
			num2 = \u02B7\u02BA\u02B9\u02B7\u02BA\u02B9\u02BA\u02C1\u02B5\u02B4\u02BC.\u02BB\u02BC\u02B2\u02BF\u02B6\u02C1\u02C1\u02B9\u02BC\u02B4\u02BC[(int)(num6 & 255U)] ^ \u02B7\u02BA\u02B9\u02B7\u02BA\u02B9\u02BA\u02C1\u02B5\u02B4\u02BC.\u02BA\u02B3\u02BA\u02B9\u02BB\u02B2\u02B3\u02C1\u02C0\u02BC\u02C0(\u02B7\u02BA\u02B9\u02B7\u02BA\u02B9\u02BA\u02C1\u02B5\u02B4\u02BC.\u02BB\u02BC\u02B2\u02BF\u02B6\u02C1\u02C1\u02B9\u02BC\u02B4\u02BC[(int)((num7 >> 8) & 255U)]) ^ \u02B7\u02BA\u02B9\u02B7\u02BA\u02B9\u02BA\u02C1\u02B5\u02B4\u02BC.\u02C0\u02BE\u02B5\u02B9\u02B2\u02B5\u02B5\u02C0\u02BF\u02C0\u02BA(\u02B7\u02BA\u02B9\u02B7\u02BA\u02B9\u02BA\u02C1\u02B5\u02B4\u02BC.\u02BB\u02BC\u02B2\u02BF\u02B6\u02C1\u02C1\u02B9\u02BC\u02B4\u02BC[(int)((num4 >> 16) & 255U)]) ^ \u02B7\u02BA\u02B9\u02B7\u02BA\u02B9\u02BA\u02C1\u02B5\u02B4\u02BC.\u02B7\u02BB\u02B9\u02BB\u02BD\u02BF\u02B3\u02B9\u02C0\u02BB\u02BE(\u02B7\u02BA\u02B9\u02B7\u02BA\u02B9\u02BA\u02C1\u02B5\u02B4\u02BC.\u02BB\u02BC\u02B2\u02BF\u02B6\u02C1\u02C1\u02B9\u02BC\u02B4\u02BC[(int)((num5 >> 24) & 255U)]) ^ array[1];
			num3 = \u02B7\u02BA\u02B9\u02B7\u02BA\u02B9\u02BA\u02C1\u02B5\u02B4\u02BC.\u02BB\u02BC\u02B2\u02BF\u02B6\u02C1\u02C1\u02B9\u02BC\u02B4\u02BC[(int)(num7 & 255U)] ^ \u02B7\u02BA\u02B9\u02B7\u02BA\u02B9\u02BA\u02C1\u02B5\u02B4\u02BC.\u02BA\u02B3\u02BA\u02B9\u02BB\u02B2\u02B3\u02C1\u02C0\u02BC\u02C0(\u02B7\u02BA\u02B9\u02B7\u02BA\u02B9\u02BA\u02C1\u02B5\u02B4\u02BC.\u02BB\u02BC\u02B2\u02BF\u02B6\u02C1\u02C1\u02B9\u02BC\u02B4\u02BC[(int)((num4 >> 8) & 255U)]) ^ \u02B7\u02BA\u02B9\u02B7\u02BA\u02B9\u02BA\u02C1\u02B5\u02B4\u02BC.\u02C0\u02BE\u02B5\u02B9\u02B2\u02B5\u02B5\u02C0\u02BF\u02C0\u02BA(\u02B7\u02BA\u02B9\u02B7\u02BA\u02B9\u02BA\u02C1\u02B5\u02B4\u02BC.\u02BB\u02BC\u02B2\u02BF\u02B6\u02C1\u02C1\u02B9\u02BC\u02B4\u02BC[(int)((num5 >> 16) & 255U)]) ^ \u02B7\u02BA\u02B9\u02B7\u02BA\u02B9\u02BA\u02C1\u02B5\u02B4\u02BC.\u02B7\u02BB\u02B9\u02BB\u02BD\u02BF\u02B3\u02B9\u02C0\u02BB\u02BE(\u02B7\u02BA\u02B9\u02B7\u02BA\u02B9\u02BA\u02C1\u02B5\u02B4\u02BC.\u02BB\u02BC\u02B2\u02BF\u02B6\u02C1\u02C1\u02B9\u02BC\u02B4\u02BC[(int)((num6 >> 24) & 255U)]) ^ array[2];
			num4 = \u02B7\u02BA\u02B9\u02B7\u02BA\u02B9\u02BA\u02C1\u02B5\u02B4\u02BC.\u02BB\u02BC\u02B2\u02BF\u02B6\u02C1\u02C1\u02B9\u02BC\u02B4\u02BC[(int)(num4 & 255U)] ^ \u02B7\u02BA\u02B9\u02B7\u02BA\u02B9\u02BA\u02C1\u02B5\u02B4\u02BC.\u02BA\u02B3\u02BA\u02B9\u02BB\u02B2\u02B3\u02C1\u02C0\u02BC\u02C0(\u02B7\u02BA\u02B9\u02B7\u02BA\u02B9\u02BA\u02C1\u02B5\u02B4\u02BC.\u02BB\u02BC\u02B2\u02BF\u02B6\u02C1\u02C1\u02B9\u02BC\u02B4\u02BC[(int)((num5 >> 8) & 255U)]) ^ \u02B7\u02BA\u02B9\u02B7\u02BA\u02B9\u02BA\u02C1\u02B5\u02B4\u02BC.\u02C0\u02BE\u02B5\u02B9\u02B2\u02B5\u02B5\u02C0\u02BF\u02C0\u02BA(\u02B7\u02BA\u02B9\u02B7\u02BA\u02B9\u02BA\u02C1\u02B5\u02B4\u02BC.\u02BB\u02BC\u02B2\u02BF\u02B6\u02C1\u02C1\u02B9\u02BC\u02B4\u02BC[(int)((num6 >> 16) & 255U)]) ^ \u02B7\u02BA\u02B9\u02B7\u02BA\u02B9\u02BA\u02C1\u02B5\u02B4\u02BC.\u02B7\u02BB\u02B9\u02BB\u02BD\u02BF\u02B3\u02B9\u02C0\u02BB\u02BE(\u02B7\u02BA\u02B9\u02B7\u02BA\u02B9\u02BA\u02C1\u02B5\u02B4\u02BC.\u02BB\u02BC\u02B2\u02BF\u02B6\u02C1\u02C1\u02B9\u02BC\u02B4\u02BC[(int)((num7 >> 24) & 255U)]) ^ array[3];
		}
		array = u02B5_u02C0_u02BC_u02B2_u02B9_u02BD_u02B6_u02BA_u02B5_u02B3_u02B[i++];
		num5 = \u02B7\u02BA\u02B9\u02B7\u02BA\u02B9\u02BA\u02C1\u02B5\u02B4\u02BC.\u02BB\u02BC\u02B2\u02BF\u02B6\u02C1\u02C1\u02B9\u02BC\u02B4\u02BC[(int)(num & 255U)] ^ \u02B7\u02BA\u02B9\u02B7\u02BA\u02B9\u02BA\u02C1\u02B5\u02B4\u02BC.\u02BA\u02B3\u02BA\u02B9\u02BB\u02B2\u02B3\u02C1\u02C0\u02BC\u02C0(\u02B7\u02BA\u02B9\u02B7\u02BA\u02B9\u02BA\u02C1\u02B5\u02B4\u02BC.\u02BB\u02BC\u02B2\u02BF\u02B6\u02C1\u02C1\u02B9\u02BC\u02B4\u02BC[(int)((num2 >> 8) & 255U)]) ^ \u02B7\u02BA\u02B9\u02B7\u02BA\u02B9\u02BA\u02C1\u02B5\u02B4\u02BC.\u02C0\u02BE\u02B5\u02B9\u02B2\u02B5\u02B5\u02C0\u02BF\u02C0\u02BA(\u02B7\u02BA\u02B9\u02B7\u02BA\u02B9\u02BA\u02C1\u02B5\u02B4\u02BC.\u02BB\u02BC\u02B2\u02BF\u02B6\u02C1\u02C1\u02B9\u02BC\u02B4\u02BC[(int)((num3 >> 16) & 255U)]) ^ \u02B7\u02BA\u02B9\u02B7\u02BA\u02B9\u02BA\u02C1\u02B5\u02B4\u02BC.\u02B7\u02BB\u02B9\u02BB\u02BD\u02BF\u02B3\u02B9\u02C0\u02BB\u02BE(\u02B7\u02BA\u02B9\u02B7\u02BA\u02B9\u02BA\u02C1\u02B5\u02B4\u02BC.\u02BB\u02BC\u02B2\u02BF\u02B6\u02C1\u02C1\u02B9\u02BC\u02B4\u02BC[(int)((num4 >> 24) & 255U)]) ^ array[0];
		num6 = \u02B7\u02BA\u02B9\u02B7\u02BA\u02B9\u02BA\u02C1\u02B5\u02B4\u02BC.\u02BB\u02BC\u02B2\u02BF\u02B6\u02C1\u02C1\u02B9\u02BC\u02B4\u02BC[(int)(num2 & 255U)] ^ \u02B7\u02BA\u02B9\u02B7\u02BA\u02B9\u02BA\u02C1\u02B5\u02B4\u02BC.\u02BA\u02B3\u02BA\u02B9\u02BB\u02B2\u02B3\u02C1\u02C0\u02BC\u02C0(\u02B7\u02BA\u02B9\u02B7\u02BA\u02B9\u02BA\u02C1\u02B5\u02B4\u02BC.\u02BB\u02BC\u02B2\u02BF\u02B6\u02C1\u02C1\u02B9\u02BC\u02B4\u02BC[(int)((num3 >> 8) & 255U)]) ^ \u02B7\u02BA\u02B9\u02B7\u02BA\u02B9\u02BA\u02C1\u02B5\u02B4\u02BC.\u02C0\u02BE\u02B5\u02B9\u02B2\u02B5\u02B5\u02C0\u02BF\u02C0\u02BA(\u02B7\u02BA\u02B9\u02B7\u02BA\u02B9\u02BA\u02C1\u02B5\u02B4\u02BC.\u02BB\u02BC\u02B2\u02BF\u02B6\u02C1\u02C1\u02B9\u02BC\u02B4\u02BC[(int)((num4 >> 16) & 255U)]) ^ \u02B7\u02BA\u02B9\u02B7\u02BA\u02B9\u02BA\u02C1\u02B5\u02B4\u02BC.\u02B7\u02BB\u02B9\u02BB\u02BD\u02BF\u02B3\u02B9\u02C0\u02BB\u02BE(\u02B7\u02BA\u02B9\u02B7\u02BA\u02B9\u02BA\u02C1\u02B5\u02B4\u02BC.\u02BB\u02BC\u02B2\u02BF\u02B6\u02C1\u02C1\u02B9\u02BC\u02B4\u02BC[(int)((num >> 24) & 255U)]) ^ array[1];
		num7 = \u02B7\u02BA\u02B9\u02B7\u02BA\u02B9\u02BA\u02C1\u02B5\u02B4\u02BC.\u02BB\u02BC\u02B2\u02BF\u02B6\u02C1\u02C1\u02B9\u02BC\u02B4\u02BC[(int)(num3 & 255U)] ^ \u02B7\u02BA\u02B9\u02B7\u02BA\u02B9\u02BA\u02C1\u02B5\u02B4\u02BC.\u02BA\u02B3\u02BA\u02B9\u02BB\u02B2\u02B3\u02C1\u02C0\u02BC\u02C0(\u02B7\u02BA\u02B9\u02B7\u02BA\u02B9\u02BA\u02C1\u02B5\u02B4\u02BC.\u02BB\u02BC\u02B2\u02BF\u02B6\u02C1\u02C1\u02B9\u02BC\u02B4\u02BC[(int)((num4 >> 8) & 255U)]) ^ \u02B7\u02BA\u02B9\u02B7\u02BA\u02B9\u02BA\u02C1\u02B5\u02B4\u02BC.\u02C0\u02BE\u02B5\u02B9\u02B2\u02B5\u02B5\u02C0\u02BF\u02C0\u02BA(\u02B7\u02BA\u02B9\u02B7\u02BA\u02B9\u02BA\u02C1\u02B5\u02B4\u02BC.\u02BB\u02BC\u02B2\u02BF\u02B6\u02C1\u02C1\u02B9\u02BC\u02B4\u02BC[(int)((num >> 16) & 255U)]) ^ \u02B7\u02BA\u02B9\u02B7\u02BA\u02B9\u02BA\u02C1\u02B5\u02B4\u02BC.\u02B7\u02BB\u02B9\u02BB\u02BD\u02BF\u02B3\u02B9\u02C0\u02BB\u02BE(\u02B7\u02BA\u02B9\u02B7\u02BA\u02B9\u02BA\u02C1\u02B5\u02B4\u02BC.\u02BB\u02BC\u02B2\u02BF\u02B6\u02C1\u02C1\u02B9\u02BC\u02B4\u02BC[(int)((num2 >> 24) & 255U)]) ^ array[2];
		num4 = \u02B7\u02BA\u02B9\u02B7\u02BA\u02B9\u02BA\u02C1\u02B5\u02B4\u02BC.\u02BB\u02BC\u02B2\u02BF\u02B6\u02C1\u02C1\u02B9\u02BC\u02B4\u02BC[(int)(num4 & 255U)] ^ \u02B7\u02BA\u02B9\u02B7\u02BA\u02B9\u02BA\u02C1\u02B5\u02B4\u02BC.\u02BA\u02B3\u02BA\u02B9\u02BB\u02B2\u02B3\u02C1\u02C0\u02BC\u02C0(\u02B7\u02BA\u02B9\u02B7\u02BA\u02B9\u02BA\u02C1\u02B5\u02B4\u02BC.\u02BB\u02BC\u02B2\u02BF\u02B6\u02C1\u02C1\u02B9\u02BC\u02B4\u02BC[(int)((num >> 8) & 255U)]) ^ \u02B7\u02BA\u02B9\u02B7\u02BA\u02B9\u02BA\u02C1\u02B5\u02B4\u02BC.\u02C0\u02BE\u02B5\u02B9\u02B2\u02B5\u02B5\u02C0\u02BF\u02C0\u02BA(\u02B7\u02BA\u02B9\u02B7\u02BA\u02B9\u02BA\u02C1\u02B5\u02B4\u02BC.\u02BB\u02BC\u02B2\u02BF\u02B6\u02C1\u02C1\u02B9\u02BC\u02B4\u02BC[(int)((num2 >> 16) & 255U)]) ^ \u02B7\u02BA\u02B9\u02B7\u02BA\u02B9\u02BA\u02C1\u02B5\u02B4\u02BC.\u02B7\u02BB\u02B9\u02BB\u02BD\u02BF\u02B3\u02B9\u02C0\u02BB\u02BE(\u02B7\u02BA\u02B9\u02B7\u02BA\u02B9\u02BA\u02C1\u02B5\u02B4\u02BC.\u02BB\u02BC\u02B2\u02BF\u02B6\u02C1\u02C1\u02B9\u02BC\u02B4\u02BC[(int)((num3 >> 24) & 255U)]) ^ array[3];
		array = u02B5_u02C0_u02BC_u02B2_u02B9_u02BD_u02B6_u02BA_u02B5_u02B3_u02B[i];
		*(int*)\u02BC\u02B5\u02C0\u02B6\u02B7\u02B8\u02BF\u02C1\u02B5\u02BF\u02C1 = (int)\u02B7\u02BA\u02B9\u02B7\u02BA\u02B9\u02BA\u02C1\u02B5\u02B4\u02BC.\u02BD\u02B3\u02BB\u02B6\u02BE\u02BB\u02B2\u02BB\u02BD\u02B6\u02B2[(int)(num5 & 255U)] ^ ((int)\u02B7\u02BA\u02B9\u02B7\u02BA\u02B9\u02BA\u02C1\u02B5\u02B4\u02BC.\u02BD\u02B3\u02BB\u02B6\u02BE\u02BB\u02B2\u02BB\u02BD\u02B6\u02B2[(int)((num6 >> 8) & 255U)] << 8) ^ ((int)\u02B7\u02BA\u02B9\u02B7\u02BA\u02B9\u02BA\u02C1\u02B5\u02B4\u02BC.\u02BD\u02B3\u02BB\u02B6\u02BE\u02BB\u02B2\u02BB\u02BD\u02B6\u02B2[(int)((num7 >> 16) & 255U)] << 16) ^ ((int)\u02B7\u02BA\u02B9\u02B7\u02BA\u02B9\u02BA\u02C1\u02B5\u02B4\u02BC.\u02BD\u02B3\u02BB\u02B6\u02BE\u02BB\u02B2\u02BB\u02BD\u02B6\u02B2[(int)((num4 >> 24) & 255U)] << 24) ^ (int)array[0];
		*(int*)(\u02BC\u02B5\u02C0\u02B6\u02B7\u02B8\u02BF\u02C1\u02B5\u02BF\u02C1 + 4) = (int)\u02B7\u02BA\u02B9\u02B7\u02BA\u02B9\u02BA\u02C1\u02B5\u02B4\u02BC.\u02BD\u02B3\u02BB\u02B6\u02BE\u02BB\u02B2\u02BB\u02BD\u02B6\u02B2[(int)(num6 & 255U)] ^ ((int)\u02B7\u02BA\u02B9\u02B7\u02BA\u02B9\u02BA\u02C1\u02B5\u02B4\u02BC.\u02BD\u02B3\u02BB\u02B6\u02BE\u02BB\u02B2\u02BB\u02BD\u02B6\u02B2[(int)((num7 >> 8) & 255U)] << 8) ^ ((int)\u02B7\u02BA\u02B9\u02B7\u02BA\u02B9\u02BA\u02C1\u02B5\u02B4\u02BC.\u02BD\u02B3\u02BB\u02B6\u02BE\u02BB\u02B2\u02BB\u02BD\u02B6\u02B2[(int)((num4 >> 16) & 255U)] << 16) ^ ((int)\u02B7\u02BA\u02B9\u02B7\u02BA\u02B9\u02BA\u02C1\u02B5\u02B4\u02BC.\u02BD\u02B3\u02BB\u02B6\u02BE\u02BB\u02B2\u02BB\u02BD\u02B6\u02B2[(int)((num5 >> 24) & 255U)] << 24) ^ (int)array[1];
		*(int*)(\u02BC\u02B5\u02C0\u02B6\u02B7\u02B8\u02BF\u02C1\u02B5\u02BF\u02C1 + (IntPtr)2 * 4) = (int)\u02B7\u02BA\u02B9\u02B7\u02BA\u02B9\u02BA\u02C1\u02B5\u02B4\u02BC.\u02BD\u02B3\u02BB\u02B6\u02BE\u02BB\u02B2\u02BB\u02BD\u02B6\u02B2[(int)(num7 & 255U)] ^ ((int)\u02B7\u02BA\u02B9\u02B7\u02BA\u02B9\u02BA\u02C1\u02B5\u02B4\u02BC.\u02BD\u02B3\u02BB\u02B6\u02BE\u02BB\u02B2\u02BB\u02BD\u02B6\u02B2[(int)((num4 >> 8) & 255U)] << 8) ^ ((int)\u02B7\u02BA\u02B9\u02B7\u02BA\u02B9\u02BA\u02C1\u02B5\u02B4\u02BC.\u02BD\u02B3\u02BB\u02B6\u02BE\u02BB\u02B2\u02BB\u02BD\u02B6\u02B2[(int)((num5 >> 16) & 255U)] << 16) ^ ((int)\u02B7\u02BA\u02B9\u02B7\u02BA\u02B9\u02BA\u02C1\u02B5\u02B4\u02BC.\u02BD\u02B3\u02BB\u02B6\u02BE\u02BB\u02B2\u02BB\u02BD\u02B6\u02B2[(int)((num6 >> 24) & 255U)] << 24) ^ (int)array[2];
		*(int*)(\u02BC\u02B5\u02C0\u02B6\u02B7\u02B8\u02BF\u02C1\u02B5\u02BF\u02C1 + (IntPtr)3 * 4) = (int)\u02B7\u02BA\u02B9\u02B7\u02BA\u02B9\u02BA\u02C1\u02B5\u02B4\u02BC.\u02BD\u02B3\u02BB\u02B6\u02BE\u02BB\u02B2\u02BB\u02BD\u02B6\u02B2[(int)(num4 & 255U)] ^ ((int)\u02B7\u02BA\u02B9\u02B7\u02BA\u02B9\u02BA\u02C1\u02B5\u02B4\u02BC.\u02BD\u02B3\u02BB\u02B6\u02BE\u02BB\u02B2\u02BB\u02BD\u02B6\u02B2[(int)((num5 >> 8) & 255U)] << 8) ^ ((int)\u02B7\u02BA\u02B9\u02B7\u02BA\u02B9\u02BA\u02C1\u02B5\u02B4\u02BC.\u02BD\u02B3\u02BB\u02B6\u02BE\u02BB\u02B2\u02BB\u02BD\u02B6\u02B2[(int)((num6 >> 16) & 255U)] << 16) ^ ((int)\u02B7\u02BA\u02B9\u02B7\u02BA\u02B9\u02BA\u02C1\u02B5\u02B4\u02BC.\u02BD\u02B3\u02BB\u02B6\u02BE\u02BB\u02B2\u02BB\u02BD\u02B6\u02B2[(int)((num7 >> 24) & 255U)] << 24) ^ (int)array[3];
		return 16;
	}

	// Token: 0x0600012B RID: 299 RVA: 0x00006727 File Offset: 0x00004927
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static uint \u02B7\u02BB\u02B9\u02BB\u02BD\u02BF\u02B3\u02B9\u02C0\u02BB\u02BE(uint \u02B4\u02B4\u02B3\u02BC\u02BA\u02B9\u02B3\u02B3\u02B5\u02B5\u02BE)
	{
		return (\u02B4\u02B4\u02B3\u02BC\u02BA\u02B9\u02B3\u02B3\u02B5\u02B5\u02BE >> 8) | (\u02B4\u02B4\u02B3\u02BC\u02BA\u02B9\u02B3\u02B3\u02B5\u02B5\u02BE << 24);
	}

	// Token: 0x0600012D RID: 301 RVA: 0x00006731 File Offset: 0x00004931
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static uint \u02BA\u02B3\u02BA\u02B9\u02BB\u02B2\u02B3\u02C1\u02C0\u02BC\u02C0(uint \u02B4\u02B4\u02B3\u02BC\u02BA\u02B9\u02B3\u02B3\u02B5\u02B5\u02BE)
	{
		return (\u02B4\u02B4\u02B3\u02BC\u02BA\u02B9\u02B3\u02B3\u02B5\u02B5\u02BE >> 24) | (\u02B4\u02B4\u02B3\u02BC\u02BA\u02B9\u02B3\u02B3\u02B5\u02B5\u02BE << 8);
	}

	// Token: 0x0600012E RID: 302 RVA: 0x0000673B File Offset: 0x0000493B
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static uint \u02C0\u02BE\u02B5\u02B9\u02B2\u02B5\u02B5\u02C0\u02BF\u02C0\u02BA(uint \u02B4\u02B4\u02B3\u02BC\u02BA\u02B9\u02B3\u02B3\u02B5\u02B5\u02BE)
	{
		return (\u02B4\u02B4\u02B3\u02BC\u02BA\u02B9\u02B3\u02B3\u02B5\u02B5\u02BE >> 16) | (\u02B4\u02B4\u02B3\u02BC\u02BA\u02B9\u02B3\u02B3\u02B5\u02B5\u02BE << 16);
	}

	// Token: 0x0600012F RID: 303 RVA: 0x00006746 File Offset: 0x00004946
	public void \u02BA\u02B7\u02BB\u02B2\u02B4\u02BA\u02B7\u02BA\u02BA\u02B6\u02B4()
	{
		this.\u02B5\u02C0\u02BC\u02B2\u02B9\u02BD\u02B6\u02BA\u02B5\u02B3\u02B4 = this.\u02BC\u02C1\u02BC\u02C0\u02BB\u02BC\u02B7\u02BD\u02BA\u02BE\u02BB();
	}

	// Token: 0x06000130 RID: 304 RVA: 0x0001EF34 File Offset: 0x0001D134
	private unsafe uint[][] \u02BC\u02C1\u02BC\u02C0\u02BB\u02BC\u02B7\u02BD\u02BA\u02BE\u02BB()
	{
		Span<byte> span = new Span<byte>(stackalloc byte[(UIntPtr)16], 16);
		\u02C1\u02BE\u02B4\u02B3\u02B4\u02BF\u02B8\u02C1\u02B6\u02BC\u02BE.\u02C1\u02B6\u02BF\u02B9\u02B2\u02B6\u02BA\u02B4\u02B4\u02B7\u02B9(span);
		Span<uint> span2 = MemoryMarshal.Cast<byte, uint>(span);
		uint[][] array = new uint[11][];
		for (int i = 0; i <= 10; i++)
		{
			array[i] = new uint[4];
		}
		uint num = (array[0][0] = *span2[0]);
		uint num2 = (array[0][1] = *span2[1]);
		uint num3 = (array[0][2] = *span2[2]);
		uint num4 = (array[0][3] = *span2[3]);
		for (int j = 1; j <= 10; j++)
		{
			num = (array[j][0] = num ^ (\u02B7\u02BA\u02B9\u02B7\u02BA\u02B9\u02BA\u02C1\u02B5\u02B4\u02BC.\u02B6\u02B6\u02C0\u02BF\u02B5\u02C1\u02BF\u02C1\u02B9\u02B4\u02BA(\u02B7\u02BA\u02B9\u02B7\u02BA\u02B9\u02BA\u02C1\u02B5\u02B4\u02BC.\u02B7\u02BB\u02B9\u02BB\u02BD\u02BF\u02B3\u02B9\u02C0\u02BB\u02BE(num4)) ^ (uint)\u02B7\u02BA\u02B9\u02B7\u02BA\u02B9\u02BA\u02C1\u02B5\u02B4\u02BC.\u02C0\u02B5\u02BA\u02B4\u02C0\u02BE\u02B4\u02BB\u02BB\u02C1\u02BE[j - 1]));
			num2 = (array[j][1] = num2 ^ num);
			num3 = (array[j][2] = num3 ^ num2);
			num4 = (array[j][3] = num4 ^ num3);
		}
		return array;
	}

	// Token: 0x04000071 RID: 113
	private static readonly byte[] \u02BD\u02B3\u02BB\u02B6\u02BE\u02BB\u02B2\u02BB\u02BD\u02B6\u02B2 = new byte[]
	{
		99, 124, 119, 123, 242, 107, 111, 197, 48, 1,
		103, 43, 254, 215, 171, 118, 202, 130, 201, 125,
		250, 89, 71, 240, 173, 212, 162, 175, 156, 164,
		114, 192, 183, 253, 147, 38, 54, 63, 247, 204,
		52, 165, 229, 241, 113, 216, 49, 21, 4, 199,
		35, 195, 24, 150, 5, 154, 7, 18, 128, 226,
		235, 39, 178, 117, 9, 131, 44, 26, 27, 110,
		90, 160, 82, 59, 214, 179, 41, 227, 47, 132,
		83, 209, 0, 237, 32, 252, 177, 91, 106, 203,
		190, 57, 74, 76, 88, 207, 208, 239, 170, 251,
		67, 77, 51, 133, 69, 249, 2, 127, 80, 60,
		159, 168, 81, 163, 64, 143, 146, 157, 56, 245,
		188, 182, 218, 33, 16, byte.MaxValue, 243, 210, 205, 12,
		19, 236, 95, 151, 68, 23, 196, 167, 126, 61,
		100, 93, 25, 115, 96, 129, 79, 220, 34, 42,
		144, 136, 70, 238, 184, 20, 222, 94, 11, 219,
		224, 50, 58, 10, 73, 6, 36, 92, 194, 211,
		172, 98, 145, 149, 228, 121, 231, 200, 55, 109,
		141, 213, 78, 169, 108, 86, 244, 234, 101, 122,
		174, 8, 186, 120, 37, 46, 28, 166, 180, 198,
		232, 221, 116, 31, 75, 189, 139, 138, 112, 62,
		181, 102, 72, 3, 246, 14, 97, 53, 87, 185,
		134, 193, 29, 158, 225, 248, 152, 17, 105, 217,
		142, 148, 155, 30, 135, 233, 206, 85, 40, 223,
		140, 161, 137, 13, 191, 230, 66, 104, 65, 153,
		45, 15, 176, 84, 187, 22
	};

	// Token: 0x04000072 RID: 114
	private static readonly byte[] \u02C0\u02B5\u02BA\u02B4\u02C0\u02BE\u02B4\u02BB\u02BB\u02C1\u02BE = new byte[] { 1, 2, 4, 8, 16, 32, 64, 128, 27, 54 };

	// Token: 0x04000073 RID: 115
	private static readonly uint[] \u02BB\u02BC\u02B2\u02BF\u02B6\u02C1\u02C1\u02B9\u02BC\u02B4\u02BC = new uint[]
	{
		2774754246U, 2222750968U, 2574743534U, 2373680118U, 234025727U, 3177933782U, 2976870366U, 1422247313U, 1345335392U, 50397442U,
		2842126286U, 2099981142U, 436141799U, 1658312629U, 3870010189U, 2591454956U, 1170918031U, 2642575903U, 1086966153U, 2273148410U,
		368769775U, 3948501426U, 3376891790U, 200339707U, 3970805057U, 1742001331U, 4255294047U, 3937382213U, 3214711843U, 4154762323U,
		2524082916U, 1539358875U, 3266819957U, 486407649U, 2928907069U, 1780885068U, 1513502316U, 1094664062U, 49805301U, 1338821763U,
		1546925160U, 4104496465U, 887481809U, 150073849U, 2473685474U, 1943591083U, 1395732834U, 1058346282U, 201589768U, 1388824469U,
		1696801606U, 1589887901U, 672667696U, 2711000631U, 251987210U, 3046808111U, 151455502U, 907153956U, 2608889883U, 1038279391U,
		652995533U, 1764173646U, 3451040383U, 2675275242U, 453576978U, 2659418909U, 1949051992U, 773462580U, 756751158U, 2993581788U,
		3998898868U, 4221608027U, 4132590244U, 1295727478U, 1641469623U, 3467883389U, 2066295122U, 1055122397U, 1898917726U, 2542044179U,
		4115878822U, 1758581177U, 0U, 753790401U, 1612718144U, 536673507U, 3367088505U, 3982187446U, 3194645204U, 1187761037U,
		3653156455U, 1262041458U, 3729410708U, 3561770136U, 3898103984U, 1255133061U, 1808847035U, 720367557U, 3853167183U, 385612781U,
		3309519750U, 3612167578U, 1429418854U, 2491778321U, 3477423498U, 284817897U, 100794884U, 2172616702U, 4031795360U, 1144798328U,
		3131023141U, 3819481163U, 4082192802U, 4272137053U, 3225436288U, 2324664069U, 2912064063U, 3164445985U, 1211644016U, 83228145U,
		3753688163U, 3249976951U, 1977277103U, 1663115586U, 806359072U, 452984805U, 250868733U, 1842533055U, 1288555905U, 336333848U,
		890442534U, 804056259U, 3781124030U, 2727843637U, 3427026056U, 957814574U, 1472513171U, 4071073621U, 2189328124U, 1195195770U,
		2892260552U, 3881655738U, 723065138U, 2507371494U, 2690670784U, 2558624025U, 3511635870U, 2145180835U, 1713513028U, 2116692564U,
		2878378043U, 2206763019U, 3393603212U, 703524551U, 3552098411U, 1007948840U, 2044649127U, 3797835452U, 487262998U, 1994120109U,
		1004593371U, 1446130276U, 1312438900U, 503974420U, 3679013266U, 168166924U, 1814307912U, 3831258296U, 1573044895U, 1859376061U,
		4021070915U, 2791465668U, 2828112185U, 2761266481U, 937747667U, 2339994098U, 854058965U, 1137232011U, 1496790894U, 3077402074U,
		2358086913U, 1691735473U, 3528347292U, 3769215305U, 3027004632U, 4199962284U, 133494003U, 636152527U, 2942657994U, 2390391540U,
		3920539207U, 403179536U, 3585784431U, 2289596656U, 1864705354U, 1915629148U, 605822008U, 4054230615U, 3350508659U, 1371981463U,
		602466507U, 2094914977U, 2624877800U, 555687742U, 3712699286U, 3703422305U, 2257292045U, 2240449039U, 2423288032U, 1111375484U,
		3300242801U, 2858837708U, 3628615824U, 84083462U, 32962295U, 302911004U, 2741068226U, 1597322602U, 4183250862U, 3501832553U,
		2441512471U, 1489093017U, 656219450U, 3114180135U, 954327513U, 335083755U, 3013122091U, 856756514U, 3144247762U, 1893325225U,
		2307821063U, 2811532339U, 3063651117U, 572399164U, 2458355477U, 552200649U, 1238290055U, 4283782570U, 2015897680U, 2061492133U,
		2408352771U, 4171342169U, 2156497161U, 386731290U, 3669999461U, 837215959U, 3326231172U, 3093850320U, 3275833730U, 2962856233U,
		1999449434U, 286199582U, 3417354363U, 4233385128U, 3602627437U, 974525996U
	};

	// Token: 0x04000074 RID: 116
	private uint[][] \u02B5\u02C0\u02BC\u02B2\u02B9\u02BD\u02B6\u02BA\u02B5\u02B3\u02B4;
}
