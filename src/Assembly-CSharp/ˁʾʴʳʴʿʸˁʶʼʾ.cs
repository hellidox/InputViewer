﻿using System;
using System.Runtime.CompilerServices;

// Token: 0x02000022 RID: 34
public static class \u02C1\u02BE\u02B4\u02B3\u02B4\u02BF\u02B8\u02C1\u02B6\u02BC\u02BE
{
	// Token: 0x06000138 RID: 312 RVA: 0x0001F26C File Offset: 0x0001D46C
	public static void \u02B4\u02BB\u02BF\u02BD\u02BA\u02BD\u02B6\u02BA\u02BC\u02B4\u02BF(ref ulong \u02BA\u02B8\u02BE\u02B8\u02B6\u02B7\u02B4\u02BF\u02C1\u02B8\u02BE, ref ulong \u02B6\u02B7\u02B2\u02BA\u02BB\u02B4\u02B2\u02B6\u02BB\u02B5\u02B4)
	{
		for (int i = 0; i <= (int)((\u02BA\u02B8\u02BE\u02B8\u02B6\u02B7\u02B4\u02BF\u02C1\u02B8\u02BE ^ \u02B6\u02B7\u02B2\u02BA\u02BB\u02B4\u02B2\u02B6\u02BB\u02B5\u02B4) & 63UL); i++)
		{
			ulong num = \u02BA\u02B8\u02BE\u02B8\u02B6\u02B7\u02B4\u02BF\u02C1\u02B8\u02BE & (15UL << i);
			ulong num2 = \u02B6\u02B7\u02B2\u02BA\u02BB\u02B4\u02B2\u02B6\u02BB\u02B5\u02B4 & (15UL << i);
			\u02BA\u02B8\u02BE\u02B8\u02B6\u02B7\u02B4\u02BF\u02C1\u02B8\u02BE ^= 15UL << i;
			\u02B6\u02B7\u02B2\u02BA\u02BB\u02B4\u02B2\u02B6\u02BB\u02B5\u02B4 ^= 15UL << i;
			\u02BA\u02B8\u02BE\u02B8\u02B6\u02B7\u02B4\u02BF\u02C1\u02B8\u02BE |= num2;
			\u02B6\u02B7\u02B2\u02BA\u02BB\u02B4\u02B2\u02B6\u02BB\u02B5\u02B4 |= num;
		}
	}

	// Token: 0x06000139 RID: 313 RVA: 0x0001F2CC File Offset: 0x0001D4CC
	public static ulong \u02B3\u02BB\u02B3\u02B2\u02B6\u02B9\u02B7\u02B4\u02BA\u02B4\u02B9(int \u02B2\u02B6\u02B9\u02BD\u02C0\u02B5\u02B6\u02BC\u02C0\u02BD\u02B7)
	{
		ulong num = ulong.MaxValue / (ulong)((ulong)\u02B2\u02B6\u02B9\u02BD\u02C0\u02B5\u02B6\u02BC\u02C0\u02BD\u02B7 << 19);
		ulong num2 = num & 18374966859414961920UL;
		ulong num3 = num & 71777214294589695UL;
		num2 >>= 1;
		num3 <<= 1;
		return \u02C1\u02BE\u02B4\u02B3\u02B4\u02BF\u02B8\u02C1\u02B6\u02BC\u02BE.\u02BA\u02BE\u02BE\u02B6\u02C1\u02B5\u02B6\u02BD\u02B9\u02C0\u02B9(num2 ^ num3);
	}

	// Token: 0x0600013A RID: 314 RVA: 0x0000676E File Offset: 0x0000496E
	public static ulong \u02BA\u02BE\u02BE\u02B6\u02C1\u02B5\u02B6\u02BD\u02B9\u02C0\u02B9(ulong \u02BF\u02B9\u02B3\u02B6\u02B4\u02BF\u02B4\u02B8\u02B6\u02BD\u02BA)
	{
		return \u02BF\u02B9\u02B3\u02B6\u02B4\u02BF\u02B4\u02B8\u02B6\u02BD\u02BA * 1664525UL + 1013904223UL;
	}

	// Token: 0x0600013B RID: 315 RVA: 0x0000677F File Offset: 0x0000497F
	public static void \u02B2\u02BE\u02B6\u02C0\u02B5\u02BD\u02B5\u02B8\u02B7\u02BD\u02BC<T>(Span<byte> \u02C0\u02B3\u02B9\u02B7\u02B5\u02C0\u02B2\u02BF\u02BD\u02BA\u02B9, T \u02B8\u02C1\u02BF\u02BF\u02B3\u02B6\u02BD\u02B3\u02B6\u02BA\u02B5, ref int \u02BB\u02B4\u02B2\u02B3\u02B4\u02BD\u02B9\u02B8\u02B5\u02B8\u02BC)
	{
		Unsafe.WriteUnaligned<T>(\u02C0\u02B3\u02B9\u02B7\u02B5\u02C0\u02B2\u02BF\u02BD\u02BA\u02B9[\u02BB\u02B4\u02B2\u02B3\u02B4\u02BD\u02B9\u02B8\u02B5\u02B8\u02BC], \u02B8\u02C1\u02BF\u02BF\u02B3\u02B6\u02BD\u02B3\u02B6\u02BA\u02B5);
		\u02BB\u02B4\u02B2\u02B3\u02B4\u02BD\u02B9\u02B8\u02B5\u02B8\u02BC += Unsafe.SizeOf<T>();
	}

	// Token: 0x0600013C RID: 316 RVA: 0x0001F308 File Offset: 0x0001D508
	public static void \u02BD\u02B3\u02BD\u02B3\u02C0\u02BB\u02BE\u02C0\u02B3\u02BC\u02B3(ulong \u02BE\u02B4\u02BB\u02BC\u02B8\u02BB\u02B2\u02B7\u02B6\u02BD\u02B7, ulong \u02BB\u02B6\u02B8\u02B9\u02B9\u02B4\u02B7\u02C1\u02BD\u02B5\u02B5, Span<byte> \u02C0\u02B3\u02B9\u02B7\u02B5\u02C0\u02B2\u02BF\u02BD\u02BA\u02B9)
	{
		int num = 0;
		\u02C1\u02BE\u02B4\u02B3\u02B4\u02BF\u02B8\u02C1\u02B6\u02BC\u02BE.\u02B2\u02BE\u02B6\u02C0\u02B5\u02BD\u02B5\u02B8\u02B7\u02BD\u02BC<ulong>(\u02C0\u02B3\u02B9\u02B7\u02B5\u02C0\u02B2\u02BF\u02BD\u02BA\u02B9, \u02BE\u02B4\u02BB\u02BC\u02B8\u02BB\u02B2\u02B7\u02B6\u02BD\u02B7, ref num);
		\u02C1\u02BE\u02B4\u02B3\u02B4\u02BF\u02B8\u02C1\u02B6\u02BC\u02BE.\u02B2\u02BE\u02B6\u02C0\u02B5\u02BD\u02B5\u02B8\u02B7\u02BD\u02BC<ulong>(\u02C0\u02B3\u02B9\u02B7\u02B5\u02C0\u02B2\u02BF\u02BD\u02BA\u02B9, \u02BB\u02B6\u02B8\u02B9\u02B9\u02B4\u02B7\u02C1\u02BD\u02B5\u02B5, ref num);
	}

	// Token: 0x0600013D RID: 317 RVA: 0x0001F32C File Offset: 0x0001D52C
	public static void \u02C1\u02B6\u02BF\u02B9\u02B2\u02B6\u02BA\u02B4\u02B4\u02B7\u02B9(Span<byte> \u02C0\u02B3\u02B9\u02B7\u02B5\u02C0\u02B2\u02BF\u02BD\u02BA\u02B9)
	{
		ulong num = \u02C1\u02BE\u02B4\u02B3\u02B4\u02BF\u02B8\u02C1\u02B6\u02BC\u02BE.\u02B3\u02BB\u02B3\u02B2\u02B6\u02B9\u02B7\u02B4\u02BA\u02B4\u02B9(5);
		ulong num2 = \u02C1\u02BE\u02B4\u02B3\u02B4\u02BF\u02B8\u02C1\u02B6\u02BC\u02BE.\u02B3\u02BB\u02B3\u02B2\u02B6\u02B9\u02B7\u02B4\u02BA\u02B4\u02B9(11);
		\u02C1\u02BE\u02B4\u02B3\u02B4\u02BF\u02B8\u02C1\u02B6\u02BC\u02BE.\u02B4\u02BB\u02BF\u02BD\u02BA\u02BD\u02B6\u02BA\u02BC\u02B4\u02BF(ref num, ref num2);
		\u02C1\u02BE\u02B4\u02B3\u02B4\u02BF\u02B8\u02C1\u02B6\u02BC\u02BE.\u02BD\u02B3\u02BD\u02B3\u02C0\u02BB\u02BE\u02C0\u02B3\u02BC\u02B3(num, num2, \u02C0\u02B3\u02B9\u02B7\u02B5\u02C0\u02B2\u02BF\u02BD\u02BA\u02B9);
	}

	// Token: 0x0600013E RID: 318 RVA: 0x0000679A File Offset: 0x0000499A
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static uint \u02BE\u02B4\u02BB\u02BB\u02C1\u02BD\u02BB\u02B2\u02B6\u02BC\u02BE(uint \u02BF\u02B9\u02B3\u02B6\u02B4\u02BF\u02B4\u02B8\u02B6\u02BD\u02BA)
	{
		\u02BF\u02B9\u02B3\u02B6\u02B4\u02BF\u02B4\u02B8\u02B6\u02BD\u02BA = ((\u02BF\u02B9\u02B3\u02B6\u02B4\u02BF\u02B4\u02B8\u02B6\u02BD\u02BA << 8) & 4278255360U) | ((\u02BF\u02B9\u02B3\u02B6\u02B4\u02BF\u02B4\u02B8\u02B6\u02BD\u02BA >> 8) & 16711935U);
		return (\u02BF\u02B9\u02B3\u02B6\u02B4\u02BF\u02B4\u02B8\u02B6\u02BD\u02BA << 16) | (\u02BF\u02B9\u02B3\u02B6\u02B4\u02BF\u02B4\u02B8\u02B6\u02BD\u02BA >> 16);
	}

	// Token: 0x0600013F RID: 319 RVA: 0x000067BA File Offset: 0x000049BA
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static ulong \u02BE\u02B4\u02BB\u02BB\u02C1\u02BD\u02BB\u02B2\u02B6\u02BC\u02BE(ulong \u02BF\u02B9\u02B3\u02B6\u02B4\u02BF\u02B4\u02B8\u02B6\u02BD\u02BA)
	{
		return ((ulong)\u02C1\u02BE\u02B4\u02B3\u02B4\u02BF\u02B8\u02C1\u02B6\u02BC\u02BE.\u02BE\u02B4\u02BB\u02BB\u02C1\u02BD\u02BB\u02B2\u02B6\u02BC\u02BE((uint)\u02BF\u02B9\u02B3\u02B6\u02B4\u02BF\u02B4\u02B8\u02B6\u02BD\u02BA) << 32) | (ulong)\u02C1\u02BE\u02B4\u02B3\u02B4\u02BF\u02B8\u02C1\u02B6\u02BC\u02BE.\u02BE\u02B4\u02BB\u02BB\u02C1\u02BD\u02BB\u02B2\u02B6\u02BC\u02BE((uint)(\u02BF\u02B9\u02B3\u02B6\u02B4\u02BF\u02B4\u02B8\u02B6\u02BD\u02BA >> 32));
	}

	// Token: 0x06000140 RID: 320 RVA: 0x000067D3 File Offset: 0x000049D3
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static long \u02BC\u02B9\u02BF\u02BD\u02BF\u02B2\u02BE\u02BB\u02BF\u02C0\u02BF(this byte[] \u02B3\u02BC\u02BE\u02BA\u02C0\u02BD\u02BF\u02B3\u02B9\u02B7\u02BD, int \u02BB\u02B4\u02B2\u02B3\u02B4\u02BD\u02B9\u02B8\u02B5\u02B8\u02BC)
	{
		return (long)\u02B3\u02BC\u02BE\u02BA\u02C0\u02BD\u02BF\u02B3\u02B9\u02B7\u02BD.\u02C0\u02B5\u02BE\u02B5\u02B8\u02C0\u02B3\u02B7\u02B7\u02C0\u02C0(\u02BB\u02B4\u02B2\u02B3\u02B4\u02BD\u02B9\u02B8\u02B5\u02B8\u02BC);
	}

	// Token: 0x06000141 RID: 321 RVA: 0x000067DC File Offset: 0x000049DC
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int \u02B6\u02BB\u02B9\u02C1\u02C0\u02BB\u02BF\u02BD\u02B8\u02BC\u02B3(this byte[] \u02B3\u02BC\u02BE\u02BA\u02C0\u02BD\u02BF\u02B3\u02B9\u02B7\u02BD, int \u02BB\u02B4\u02B2\u02B3\u02B4\u02BD\u02B9\u02B8\u02B5\u02B8\u02BC)
	{
		return (int)\u02B3\u02BC\u02BE\u02BA\u02C0\u02BD\u02BF\u02B3\u02B9\u02B7\u02BD.\u02B6\u02C1\u02C0\u02B2\u02B3\u02B7\u02BB\u02B5\u02B2\u02B2\u02B5(\u02BB\u02B4\u02B2\u02B3\u02B4\u02BD\u02B9\u02B8\u02B5\u02B8\u02BC);
	}

	// Token: 0x06000142 RID: 322 RVA: 0x000067E5 File Offset: 0x000049E5
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static sbyte \u02B8\u02B4\u02BA\u02C0\u02BB\u02C0\u02C0\u02BE\u02B4\u02B9\u02B6(this byte[] \u02B3\u02BC\u02BE\u02BA\u02C0\u02BD\u02BF\u02B3\u02B9\u02B7\u02BD, int \u02BB\u02B4\u02B2\u02B3\u02B4\u02BD\u02B9\u02B8\u02B5\u02B8\u02BC)
	{
		return (sbyte)\u02B3\u02BC\u02BE\u02BA\u02C0\u02BD\u02BF\u02B3\u02B9\u02B7\u02BD[\u02BB\u02B4\u02B2\u02B3\u02B4\u02BD\u02B9\u02B8\u02B5\u02B8\u02BC];
	}

	// Token: 0x06000143 RID: 323 RVA: 0x000067EB File Offset: 0x000049EB
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public unsafe static ulong \u02C0\u02B5\u02BE\u02B5\u02B8\u02C0\u02B3\u02B7\u02B7\u02C0\u02C0(this byte[] \u02B3\u02BC\u02BE\u02BA\u02C0\u02BD\u02BF\u02B3\u02B9\u02B7\u02BD, int \u02BB\u02B4\u02B2\u02B3\u02B4\u02BD\u02B9\u02B8\u02B5\u02B8\u02BC)
	{
		return *Unsafe.As<byte, ulong>(ref \u02B3\u02BC\u02BE\u02BA\u02C0\u02BD\u02BF\u02B3\u02B9\u02B7\u02BD[\u02BB\u02B4\u02B2\u02B3\u02B4\u02BD\u02B9\u02B8\u02B5\u02B8\u02BC]);
	}

	// Token: 0x06000144 RID: 324 RVA: 0x000067FA File Offset: 0x000049FA
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public unsafe static uint \u02B6\u02C1\u02C0\u02B2\u02B3\u02B7\u02BB\u02B5\u02B2\u02B2\u02B5(this byte[] \u02B3\u02BC\u02BE\u02BA\u02C0\u02BD\u02BF\u02B3\u02B9\u02B7\u02BD, int \u02BB\u02B4\u02B2\u02B3\u02B4\u02BD\u02B9\u02B8\u02B5\u02B8\u02BC)
	{
		return *Unsafe.As<byte, uint>(ref \u02B3\u02BC\u02BE\u02BA\u02C0\u02BD\u02BF\u02B3\u02B9\u02B7\u02BD[\u02BB\u02B4\u02B2\u02B3\u02B4\u02BD\u02B9\u02B8\u02B5\u02B8\u02BC]);
	}

	// Token: 0x06000145 RID: 325 RVA: 0x00006809 File Offset: 0x00004A09
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int \u02C1\u02B8\u02B2\u02BB\u02BC\u02BD\u02B4\u02BF\u02B9\u02B5\u02B5(this byte[] \u02B3\u02BC\u02BE\u02BA\u02C0\u02BD\u02BF\u02B3\u02B9\u02B7\u02BD, int \u02BB\u02B4\u02B2\u02B3\u02B4\u02BD\u02B9\u02B8\u02B5\u02B8\u02BC, byte[] \u02C0\u02B3\u02B9\u02B7\u02B5\u02C0\u02B2\u02BF\u02BD\u02BA\u02B9, uint \u02B6\u02C0\u02BF\u02B7\u02B4\u02BB\u02B6\u02C1\u02B6\u02BF\u02BF)
	{
		Unsafe.CopyBlockUnaligned(ref \u02C0\u02B3\u02B9\u02B7\u02B5\u02C0\u02B2\u02BF\u02BD\u02BA\u02B9[0], ref \u02B3\u02BC\u02BE\u02BA\u02C0\u02BD\u02BF\u02B3\u02B9\u02B7\u02BD[\u02BB\u02B4\u02B2\u02B3\u02B4\u02BD\u02B9\u02B8\u02B5\u02B8\u02BC], \u02B6\u02C0\u02BF\u02B7\u02B4\u02BB\u02B6\u02C1\u02B6\u02BF\u02BF);
		return (int)\u02B6\u02C0\u02BF\u02B7\u02B4\u02BB\u02B6\u02C1\u02B6\u02BF\u02BF;
	}

	// Token: 0x06000146 RID: 326 RVA: 0x0001F35C File Offset: 0x0001D55C
	public unsafe static int \u02BD\u02B9\u02B5\u02BE\u02BA\u02B7\u02BE\u02B8\u02C0\u02BE\u02BB<[IsUnmanaged] T>(this byte[] \u02B3\u02BC\u02BE\u02BA\u02C0\u02BD\u02BF\u02B3\u02B9\u02B7\u02BD, int \u02BB\u02B4\u02B2\u02B3\u02B4\u02BD\u02B9\u02B8\u02B5\u02B8\u02BC, T[] \u02C0\u02B3\u02B9\u02B7\u02B5\u02C0\u02B2\u02BF\u02BD\u02BA\u02B9, uint \u02B6\u02C0\u02BF\u02B7\u02B4\u02BB\u02B6\u02C1\u02B6\u02BF\u02BF) where T : struct, ValueType
	{
		int num = Unsafe.SizeOf<T>() * (int)\u02B6\u02C0\u02BF\u02B7\u02B4\u02BB\u02B6\u02C1\u02B6\u02BF\u02BF;
		byte* ptr = (byte*)Unsafe.AsPointer<T>(ref \u02C0\u02B3\u02B9\u02B7\u02B5\u02C0\u02B2\u02BF\u02BD\u02BA\u02B9[0]);
		Unsafe.CopyBlockUnaligned(Unsafe.AsRef<byte>((void*)ptr), ref \u02B3\u02BC\u02BE\u02BA\u02C0\u02BD\u02BF\u02B3\u02B9\u02B7\u02BD[\u02BB\u02B4\u02B2\u02B3\u02B4\u02BD\u02B9\u02B8\u02B5\u02B8\u02BC], (uint)num);
		return num;
	}

	// Token: 0x06000147 RID: 327 RVA: 0x00006820 File Offset: 0x00004A20
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static long \u02BC\u02B9\u02BF\u02BD\u02BF\u02B2\u02BE\u02BB\u02BF\u02C0\u02BF(this byte[] \u02B3\u02BC\u02BE\u02BA\u02C0\u02BD\u02BF\u02B3\u02B9\u02B7\u02BD, ref int \u02BB\u02B4\u02B2\u02B3\u02B4\u02BD\u02B9\u02B8\u02B5\u02B8\u02BC)
	{
		long num = \u02B3\u02BC\u02BE\u02BA\u02C0\u02BD\u02BF\u02B3\u02B9\u02B7\u02BD.\u02BC\u02B9\u02BF\u02BD\u02BF\u02B2\u02BE\u02BB\u02BF\u02C0\u02BF(\u02BB\u02B4\u02B2\u02B3\u02B4\u02BD\u02B9\u02B8\u02B5\u02B8\u02BC);
		\u02BB\u02B4\u02B2\u02B3\u02B4\u02BD\u02B9\u02B8\u02B5\u02B8\u02BC += 8;
		return num;
	}

	// Token: 0x06000148 RID: 328 RVA: 0x00006830 File Offset: 0x00004A30
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int \u02B6\u02BB\u02B9\u02C1\u02C0\u02BB\u02BF\u02BD\u02B8\u02BC\u02B3(this byte[] \u02B3\u02BC\u02BE\u02BA\u02C0\u02BD\u02BF\u02B3\u02B9\u02B7\u02BD, ref int \u02BB\u02B4\u02B2\u02B3\u02B4\u02BD\u02B9\u02B8\u02B5\u02B8\u02BC)
	{
		int num = \u02B3\u02BC\u02BE\u02BA\u02C0\u02BD\u02BF\u02B3\u02B9\u02B7\u02BD.\u02B6\u02BB\u02B9\u02C1\u02C0\u02BB\u02BF\u02BD\u02B8\u02BC\u02B3(\u02BB\u02B4\u02B2\u02B3\u02B4\u02BD\u02B9\u02B8\u02B5\u02B8\u02BC);
		\u02BB\u02B4\u02B2\u02B3\u02B4\u02BD\u02B9\u02B8\u02B5\u02B8\u02BC += 4;
		return num;
	}

	// Token: 0x06000149 RID: 329 RVA: 0x00006840 File Offset: 0x00004A40
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static sbyte \u02B8\u02B4\u02BA\u02C0\u02BB\u02C0\u02C0\u02BE\u02B4\u02B9\u02B6(this byte[] \u02B3\u02BC\u02BE\u02BA\u02C0\u02BD\u02BF\u02B3\u02B9\u02B7\u02BD, ref int \u02BB\u02B4\u02B2\u02B3\u02B4\u02BD\u02B9\u02B8\u02B5\u02B8\u02BC)
	{
		sbyte b = \u02B3\u02BC\u02BE\u02BA\u02C0\u02BD\u02BF\u02B3\u02B9\u02B7\u02BD.\u02B8\u02B4\u02BA\u02C0\u02BB\u02C0\u02C0\u02BE\u02B4\u02B9\u02B6(\u02BB\u02B4\u02B2\u02B3\u02B4\u02BD\u02B9\u02B8\u02B5\u02B8\u02BC);
		\u02BB\u02B4\u02B2\u02B3\u02B4\u02BD\u02B9\u02B8\u02B5\u02B8\u02BC++;
		return b;
	}

	// Token: 0x0600014A RID: 330 RVA: 0x00006850 File Offset: 0x00004A50
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static uint \u02B6\u02C1\u02C0\u02B2\u02B3\u02B7\u02BB\u02B5\u02B2\u02B2\u02B5(this byte[] \u02B3\u02BC\u02BE\u02BA\u02C0\u02BD\u02BF\u02B3\u02B9\u02B7\u02BD, ref int \u02BB\u02B4\u02B2\u02B3\u02B4\u02BD\u02B9\u02B8\u02B5\u02B8\u02BC)
	{
		uint num = \u02B3\u02BC\u02BE\u02BA\u02C0\u02BD\u02BF\u02B3\u02B9\u02B7\u02BD.\u02B6\u02C1\u02C0\u02B2\u02B3\u02B7\u02BB\u02B5\u02B2\u02B2\u02B5(\u02BB\u02B4\u02B2\u02B3\u02B4\u02BD\u02B9\u02B8\u02B5\u02B8\u02BC);
		\u02BB\u02B4\u02B2\u02B3\u02B4\u02BD\u02B9\u02B8\u02B5\u02B8\u02BC += 4;
		return num;
	}

	// Token: 0x0600014B RID: 331 RVA: 0x0001F394 File Offset: 0x0001D594
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static byte \u02B3\u02BC\u02B5\u02B4\u02BD\u02B2\u02BE\u02BE\u02BB\u02B8\u02B5(this byte[] \u02B3\u02BC\u02BE\u02BA\u02C0\u02BD\u02BF\u02B3\u02B9\u02B7\u02BD, ref int \u02BB\u02B4\u02B2\u02B3\u02B4\u02BD\u02B9\u02B8\u02B5\u02B8\u02BC)
	{
		int num = \u02BB\u02B4\u02B2\u02B3\u02B4\u02BD\u02B9\u02B8\u02B5\u02B8\u02BC;
		\u02BB\u02B4\u02B2\u02B3\u02B4\u02BD\u02B9\u02B8\u02B5\u02B8\u02BC = num + 1;
		return \u02B3\u02BC\u02BE\u02BA\u02C0\u02BD\u02BF\u02B3\u02B9\u02B7\u02BD[num];
	}

	// Token: 0x0600014C RID: 332 RVA: 0x00006860 File Offset: 0x00004A60
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void \u02C1\u02B8\u02B2\u02BB\u02BC\u02BD\u02B4\u02BF\u02B9\u02B5\u02B5(this byte[] \u02BD\u02BD\u02BF\u02BF\u02BE\u02B2\u02B5\u02BD\u02BC\u02B7\u02C0, ref int \u02BB\u02B4\u02B2\u02B3\u02B4\u02BD\u02B9\u02B8\u02B5\u02B8\u02BC, byte[] \u02C0\u02B3\u02B9\u02B7\u02B5\u02C0\u02B2\u02BF\u02BD\u02BA\u02B9, uint \u02B6\u02C0\u02BF\u02B7\u02B4\u02BB\u02B6\u02C1\u02B6\u02BF\u02BF)
	{
		\u02BB\u02B4\u02B2\u02B3\u02B4\u02BD\u02B9\u02B8\u02B5\u02B8\u02BC += \u02BD\u02BD\u02BF\u02BF\u02BE\u02B2\u02B5\u02BD\u02BC\u02B7\u02C0.\u02C1\u02B8\u02B2\u02BB\u02BC\u02BD\u02B4\u02BF\u02B9\u02B5\u02B5(\u02BB\u02B4\u02B2\u02B3\u02B4\u02BD\u02B9\u02B8\u02B5\u02B8\u02BC, \u02C0\u02B3\u02B9\u02B7\u02B5\u02C0\u02B2\u02BF\u02BD\u02BA\u02B9, \u02B6\u02C0\u02BF\u02B7\u02B4\u02BB\u02B6\u02C1\u02B6\u02BF\u02BF);
	}

	// Token: 0x0600014D RID: 333 RVA: 0x00006871 File Offset: 0x00004A71
	public static void \u02BD\u02B9\u02B5\u02BE\u02BA\u02B7\u02BE\u02B8\u02C0\u02BE\u02BB<[IsUnmanaged] T>(this byte[] \u02BD\u02BD\u02BF\u02BF\u02BE\u02B2\u02B5\u02BD\u02BC\u02B7\u02C0, ref int \u02BB\u02B4\u02B2\u02B3\u02B4\u02BD\u02B9\u02B8\u02B5\u02B8\u02BC, T[] \u02C0\u02B3\u02B9\u02B7\u02B5\u02C0\u02B2\u02BF\u02BD\u02BA\u02B9, uint \u02B6\u02C0\u02BF\u02B7\u02B4\u02BB\u02B6\u02C1\u02B6\u02BF\u02BF) where T : struct, ValueType
	{
		\u02BB\u02B4\u02B2\u02B3\u02B4\u02BD\u02B9\u02B8\u02B5\u02B8\u02BC += \u02BD\u02BD\u02BF\u02BF\u02BE\u02B2\u02B5\u02BD\u02BC\u02B7\u02C0.\u02BD\u02B9\u02B5\u02BE\u02BA\u02B7\u02BE\u02B8\u02C0\u02BE\u02BB(\u02BB\u02B4\u02B2\u02B3\u02B4\u02BD\u02B9\u02B8\u02B5\u02B8\u02BC, \u02C0\u02B3\u02B9\u02B7\u02B5\u02C0\u02B2\u02BF\u02BD\u02BA\u02B9, \u02B6\u02C0\u02BF\u02B7\u02B4\u02BB\u02B6\u02C1\u02B6\u02BF\u02BF);
	}
}
