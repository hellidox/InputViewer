using System;
using System.Collections.Generic;

namespace ErrorCorrection
{
	// Token: 0x0200036A RID: 874
	public sealed class Encoder
	{
		// Token: 0x06002001 RID: 8193 RVA: 0x000D6E38 File Offset: 0x000D5038
		public Encoder(int fieldSize, int messageSymbols, int paritySymbols, int fieldGenPoly)
		{
			if (fieldSize - 1 != messageSymbols + paritySymbols)
			{
				throw new ArgumentOutOfRangeException("Invalid reed-solomon block parameters were provided - the number of message symbols plus the number of parity symbols does not add up to the size of a block");
			}
			this.fieldSize = fieldSize;
			this.messageSymbols = messageSymbols;
			this.paritySymbols = paritySymbols;
			this.BlockSize = fieldSize - 1;
			this.gf = new GaloisField(fieldSize, fieldGenPoly);
			this.codeGenPoly = this.BuildCodeGenPoly();
			this.modulusResult = new int[paritySymbols];
		}

		// Token: 0x17000466 RID: 1126
		// (get) Token: 0x06002002 RID: 8194 RVA: 0x00018BBC File Offset: 0x00016DBC
		// (set) Token: 0x06002003 RID: 8195 RVA: 0x00018BC4 File Offset: 0x00016DC4
		public int BlockSize { get; private set; }

		// Token: 0x17000467 RID: 1127
		// (get) Token: 0x06002004 RID: 8196 RVA: 0x00018BCD File Offset: 0x00016DCD
		public int MessageSize
		{
			get
			{
				return this.messageSymbols;
			}
		}

		// Token: 0x06002005 RID: 8197 RVA: 0x000D6EA4 File Offset: 0x000D50A4
		private int[] BuildCodeGenPoly()
		{
			int num = this.fieldSize - this.messageSymbols - 1;
			List<int[]> list = new List<int[]>(num);
			for (int i = 0; i < num; i++)
			{
				list.Add(new int[]
				{
					this.gf.Field[i + 1],
					1
				});
			}
			int[] array = list[0];
			for (int j = 1; j < num; j++)
			{
				array = this.gf.PolyMult(array, list[j]);
			}
			return array;
		}

		// Token: 0x06002006 RID: 8198 RVA: 0x000D6F24 File Offset: 0x000D5124
		public void Encode(int[] message)
		{
			int[] array = this.modulusResult;
			int[] array2 = this.codeGenPoly;
			Array.Clear(message, 0, this.paritySymbols);
			Array.Clear(array, 0, array.Length);
			int num = 0;
			int num2;
			for (int i = message.Length - 1; i > this.paritySymbols; i--)
			{
				num2 = num ^ message[i];
				for (int j = 0; j < array.Length; j++)
				{
					array[j] ^= this.gf.Multiply(array2[j], num2);
				}
				num = array[array.Length - 1];
				for (int k = array.Length - 1; k >= 1; k--)
				{
					array[k] = array[k - 1];
				}
				array[0] = 0;
			}
			num2 = num ^ message[this.paritySymbols];
			for (int l = 0; l < array.Length; l++)
			{
				message[l] = array[l] ^ this.gf.Multiply(array2[l], num2);
			}
		}

		// Token: 0x04001919 RID: 6425
		private readonly int fieldSize;

		// Token: 0x0400191A RID: 6426
		private readonly int messageSymbols;

		// Token: 0x0400191B RID: 6427
		private readonly int paritySymbols;

		// Token: 0x0400191C RID: 6428
		private readonly int[] codeGenPoly;

		// Token: 0x0400191D RID: 6429
		private readonly int[] modulusResult;

		// Token: 0x0400191E RID: 6430
		private readonly GaloisField gf;
	}
}
