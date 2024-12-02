using System;
using System.Collections.Generic;

namespace ErrorCorrection
{
	public sealed class Encoder
	{
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

		public int BlockSize { get; private set; }

		public int MessageSize
		{
			get
			{
				return this.messageSymbols;
			}
		}

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

		private readonly int fieldSize;

		private readonly int messageSymbols;

		private readonly int paritySymbols;

		private readonly int[] codeGenPoly;

		private readonly int[] modulusResult;

		private readonly GaloisField gf;
	}
}
