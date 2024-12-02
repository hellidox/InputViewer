using System;

namespace ErrorCorrection
{
	public sealed class Decoder
	{
		public Decoder(int fieldSize, int messageSymbols, int paritySymbols, int fieldGenPoly)
		{
			if (fieldSize - 1 != messageSymbols + paritySymbols)
			{
				throw new ArgumentOutOfRangeException("Invalid reed-solomon block parameters were provided - the number of message symbols plus the number of parity symbols does not add up to the size of a block");
			}
			this.fieldSize = fieldSize;
			this.messageSymbols = messageSymbols;
			this.paritySymbols = paritySymbols;
			this.BlockSize = fieldSize - 1;
			this.fieldGenPoly = fieldGenPoly;
			this.gf = new GaloisField(fieldSize, fieldGenPoly);
			this.syndroms = new int[paritySymbols];
			this.lambda = new int[paritySymbols - 1];
			this.corrPoly = new int[paritySymbols - 1];
			this.lambdaStar = new int[paritySymbols - 1];
			this.lambdaPrime = new int[paritySymbols - 2];
			this.omega = new int[paritySymbols - 2];
			this.errorIndexes = new int[fieldSize - 1];
			this.chienCache = new int[fieldSize - 1];
			for (int i = 0; i < this.chienCache.Length; i++)
			{
				this.chienCache[i] = this.gf.Inverses[this.gf.Field[i + 1]];
			}
		}

		public int BlockSize { get; private set; }

		public int MessageSize
		{
			get
			{
				return this.messageSymbols;
			}
		}

		public void Decode(int[] message)
		{
			if (message.Length != this.BlockSize)
			{
				throw new ArgumentException("The provided message's size was not the size of a block");
			}
			this.CalcSyndromPoly(message);
			this.CalcLambda();
			this.CalcLambdaPrime();
			this.CalcOmega();
			this.ChienSearch();
			this.RepairErrors(message, this.errorIndexes, this.omega, this.lambdaPrime);
		}

		private void RepairErrors(int[] message, int[] errorIndexes, int[] omega, int[] lp)
		{
			int num = message.Length;
			for (int i = 0; i < num; i++)
			{
				if (errorIndexes[i] == 0)
				{
					int num2 = this.gf.Field[i + 1];
					int num3 = this.gf.Inverses[num2];
					int num4 = this.gf.PolyEval(omega, num3);
					num4 = this.gf.Multiply(num4, num2);
					int num5 = this.gf.PolyEval(lp, num3);
					message[i] ^= this.gf.Divide(num4, num5);
				}
			}
		}

		private void CalcLambda()
		{
			Array.Clear(this.corrPoly, 0, this.corrPoly.Length);
			Array.Clear(this.lambda, 0, this.lambda.Length);
			int i = 1;
			int num = 0;
			this.corrPoly[1] = 1;
			this.lambda[0] = 1;
			while (i <= this.paritySymbols)
			{
				int num2 = this.syndroms[i - 1];
				for (int j = 1; j <= num; j++)
				{
					num2 ^= this.gf.Multiply(this.lambda[j], this.syndroms[i - 1 - j]);
				}
				if (num2 != 0)
				{
					for (int k = 0; k < this.lambdaStar.Length; k++)
					{
						this.lambdaStar[k] = this.lambda[k] ^ this.gf.Multiply(num2, this.corrPoly[k]);
					}
					if (2 * num < i)
					{
						num = i - num;
						int num3 = this.gf.Inverses[num2];
						for (int l = 0; l < this.corrPoly.Length; l++)
						{
							this.corrPoly[l] = this.gf.Multiply(this.lambda[l], num3);
						}
					}
				}
				for (int m = this.corrPoly.Length - 1; m >= 1; m--)
				{
					this.corrPoly[m] = this.corrPoly[m - 1];
				}
				this.corrPoly[0] = 0;
				if (num2 != 0)
				{
					Array.Copy(this.lambdaStar, this.lambda, this.lambda.Length);
				}
				i++;
			}
		}

		private void CalcLambdaPrime()
		{
			for (int i = 0; i < this.lambdaPrime.Length; i++)
			{
				if ((i & 1) == 0)
				{
					this.lambdaPrime[i] = this.lambda[i + 1];
				}
				else
				{
					this.lambdaPrime[i] = 0;
				}
			}
		}

		private void CalcOmega()
		{
			for (int i = 0; i < this.omega.Length; i++)
			{
				this.omega[i] = this.syndroms[i];
				for (int j = 1; j <= i; j++)
				{
					this.omega[i] ^= this.gf.Multiply(this.syndroms[i - j], this.lambda[j]);
				}
			}
		}

		private void ChienSearch()
		{
			for (int i = 0; i < this.errorIndexes.Length; i++)
			{
				this.errorIndexes[i] = this.gf.PolyEval(this.lambda, this.chienCache[i]);
			}
		}

		private void CalcSyndromPoly(int[] message)
		{
			for (int i = 0; i < this.syndroms.Length; i++)
			{
				int num = this.gf.Field[i + 1];
				int num2 = 0;
				for (int j = message.Length - 1; j > 0; j--)
				{
					num2 = this.gf.Multiply(num2 ^ message[j], num);
				}
				this.syndroms[i] = num2 ^ message[0];
			}
		}

		private readonly int fieldSize;

		private readonly int messageSymbols;

		private readonly int paritySymbols;

		private readonly int fieldGenPoly;

		private readonly GaloisField gf;

		private readonly int[] syndroms;

		private readonly int[] lambda;

		private readonly int[] corrPoly;

		private readonly int[] lambdaStar;

		private readonly int[] lambdaPrime;

		private readonly int[] omega;

		private readonly int[] errorIndexes;

		private readonly int[] chienCache;
	}
}
