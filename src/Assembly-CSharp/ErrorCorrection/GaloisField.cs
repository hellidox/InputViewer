using System;
using System.Text;

namespace ErrorCorrection
{
	// Token: 0x0200036D RID: 877
	public sealed class GaloisField
	{
		// Token: 0x06002021 RID: 8225 RVA: 0x000D7264 File Offset: 0x000D5464
		public GaloisField(int size, int fieldGenPoly)
		{
			this.size = size;
			this.fieldGenPoly = fieldGenPoly;
			this.Field = new int[size];
			this.Logarithms = new int[this.Field.Length];
			this.Inverses = new int[this.Field.Length];
			this.BuildField();
			this.BuildLogarithms();
			this.BuildMultTable();
			this.BuildInverses();
		}

		// Token: 0x06002022 RID: 8226 RVA: 0x000D72D0 File Offset: 0x000D54D0
		public static string PolyPrint(int[] poly)
		{
			StringBuilder stringBuilder = new StringBuilder(poly.Length * 3);
			for (int i = poly.Length - 1; i >= 0; i--)
			{
				if (i > 1)
				{
					stringBuilder.Append(poly[i]).Append("x^").Append(i)
						.Append(" + ");
				}
				else if (i == 1)
				{
					stringBuilder.Append(poly[i]).Append("x").Append(" + ");
				}
				else
				{
					stringBuilder.Append(poly[i]);
				}
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06002023 RID: 8227 RVA: 0x00018C29 File Offset: 0x00016E29
		public int Divide(int dividend, int divisor)
		{
			return this.multTable[dividend, this.Inverses[divisor]];
		}

		// Token: 0x06002024 RID: 8228 RVA: 0x00018C3F File Offset: 0x00016E3F
		public int Multiply(int left, int right)
		{
			return this.multTable[left, right];
		}

		// Token: 0x06002025 RID: 8229 RVA: 0x000D7358 File Offset: 0x000D5558
		public int PolyEval(int[] poly, int x)
		{
			int num = poly[0];
			int num2 = this.Logarithms[x];
			for (int i = 1; i < poly.Length; i++)
			{
				if (poly[i] != 0)
				{
					int num3 = (this.Logarithms[poly[i]] + num2 * i) % (this.size - 1);
					num ^= this.Field[num3 + 1];
				}
			}
			return num;
		}

		// Token: 0x06002026 RID: 8230 RVA: 0x000D73AC File Offset: 0x000D55AC
		public int[] PolyMult(int[] left, int[] right)
		{
			int[] array = new int[left.Length + right.Length - 1];
			for (int i = 0; i < left.Length; i++)
			{
				for (int j = 0; j < right.Length; j++)
				{
					int num = this.InternalMult(left[i], right[j]);
					array[i + j] = array[i + j] ^ num;
				}
			}
			return array;
		}

		// Token: 0x06002027 RID: 8231 RVA: 0x000D7400 File Offset: 0x000D5600
		private void BuildField()
		{
			this.Field[0] = 0;
			this.Field[1] = 1;
			int num = 1;
			for (int i = 2; i < this.Field.Length; i++)
			{
				int num2 = num << 1;
				if (num2 >= this.size)
				{
					num2 ^= this.fieldGenPoly;
				}
				this.Field[i] = num2;
				num = num2;
			}
		}

		// Token: 0x06002028 RID: 8232 RVA: 0x000D7458 File Offset: 0x000D5658
		private void BuildInverses()
		{
			this.Inverses[0] = 0;
			for (int i = 1; i < this.Inverses.Length; i++)
			{
				this.Inverses[this.Field[i]] = this.InternalDivide(1, this.Field[i]);
			}
		}

		// Token: 0x06002029 RID: 8233 RVA: 0x000D74A0 File Offset: 0x000D56A0
		private void BuildLogarithms()
		{
			for (int i = 0; i < this.Field.Length; i++)
			{
				this.Logarithms[this.Field[i]] = i - 1;
			}
		}

		// Token: 0x0600202A RID: 8234 RVA: 0x000D74D4 File Offset: 0x000D56D4
		private void BuildMultTable()
		{
			this.multTable = new int[this.size, this.size];
			for (int i = 0; i < this.size; i++)
			{
				for (int j = 0; j < this.size; j++)
				{
					this.multTable[i, j] = this.InternalMult(i, j);
				}
			}
		}

		// Token: 0x0600202B RID: 8235 RVA: 0x00018C4E File Offset: 0x00016E4E
		private int InternalDivide(int dividend, int divisor)
		{
			if (dividend == 0)
			{
				return 0;
			}
			dividend = this.Logarithms[dividend];
			divisor = this.Logarithms[divisor];
			dividend = (dividend - divisor + (this.size - 1)) % (this.size - 1);
			return this.Field[dividend + 1];
		}

		// Token: 0x0600202C RID: 8236 RVA: 0x00018C8A File Offset: 0x00016E8A
		private int InternalMult(int left, int right)
		{
			if (left == 0 || right == 0)
			{
				return 0;
			}
			left = this.Logarithms[left];
			right = this.Logarithms[right];
			left = (left + right) % (this.size - 1);
			return this.Field[left + 1];
		}

		// Token: 0x04001929 RID: 6441
		public readonly int[] Field;

		// Token: 0x0400192A RID: 6442
		public readonly int[] Inverses;

		// Token: 0x0400192B RID: 6443
		public readonly int[] Logarithms;

		// Token: 0x0400192C RID: 6444
		private int fieldGenPoly;

		// Token: 0x0400192D RID: 6445
		private int[,] multTable;

		// Token: 0x0400192E RID: 6446
		private int size;
	}
}
