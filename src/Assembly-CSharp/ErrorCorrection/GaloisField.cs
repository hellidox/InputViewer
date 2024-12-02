using System;
using System.Text;

namespace ErrorCorrection
{
	public sealed class GaloisField
	{
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

		public int Divide(int dividend, int divisor)
		{
			return this.multTable[dividend, this.Inverses[divisor]];
		}

		public int Multiply(int left, int right)
		{
			return this.multTable[left, right];
		}

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

		private void BuildInverses()
		{
			this.Inverses[0] = 0;
			for (int i = 1; i < this.Inverses.Length; i++)
			{
				this.Inverses[this.Field[i]] = this.InternalDivide(1, this.Field[i]);
			}
		}

		private void BuildLogarithms()
		{
			for (int i = 0; i < this.Field.Length; i++)
			{
				this.Logarithms[this.Field[i]] = i - 1;
			}
		}

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

		public readonly int[] Field;

		public readonly int[] Inverses;

		public readonly int[] Logarithms;

		private int fieldGenPoly;

		private int[,] multTable;

		private int size;
	}
}
