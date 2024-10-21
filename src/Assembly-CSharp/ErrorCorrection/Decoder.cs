using System;

namespace ErrorCorrection
{
	// Token: 0x0200036E RID: 878
	public sealed class Decoder
	{
		// Token: 0x0600202D RID: 8237 RVA: 0x000D7530 File Offset: 0x000D5730
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

		// Token: 0x17000473 RID: 1139
		// (get) Token: 0x0600202E RID: 8238 RVA: 0x00018CC0 File Offset: 0x00016EC0
		// (set) Token: 0x0600202F RID: 8239 RVA: 0x00018CC8 File Offset: 0x00016EC8
		public int BlockSize { get; private set; }

		// Token: 0x17000474 RID: 1140
		// (get) Token: 0x06002030 RID: 8240 RVA: 0x00018CD1 File Offset: 0x00016ED1
		public int MessageSize
		{
			get
			{
				return this.messageSymbols;
			}
		}

		// Token: 0x06002031 RID: 8241 RVA: 0x000D7630 File Offset: 0x000D5830
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

		// Token: 0x06002032 RID: 8242 RVA: 0x000D768C File Offset: 0x000D588C
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

		// Token: 0x06002033 RID: 8243 RVA: 0x000D7718 File Offset: 0x000D5918
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

		// Token: 0x06002034 RID: 8244 RVA: 0x000D789C File Offset: 0x000D5A9C
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

		// Token: 0x06002035 RID: 8245 RVA: 0x000D78E0 File Offset: 0x000D5AE0
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

		// Token: 0x06002036 RID: 8246 RVA: 0x000D794C File Offset: 0x000D5B4C
		private void ChienSearch()
		{
			for (int i = 0; i < this.errorIndexes.Length; i++)
			{
				this.errorIndexes[i] = this.gf.PolyEval(this.lambda, this.chienCache[i]);
			}
		}

		// Token: 0x06002037 RID: 8247 RVA: 0x000D7990 File Offset: 0x000D5B90
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

		// Token: 0x0400192F RID: 6447
		private readonly int fieldSize;

		// Token: 0x04001930 RID: 6448
		private readonly int messageSymbols;

		// Token: 0x04001931 RID: 6449
		private readonly int paritySymbols;

		// Token: 0x04001932 RID: 6450
		private readonly int fieldGenPoly;

		// Token: 0x04001933 RID: 6451
		private readonly GaloisField gf;

		// Token: 0x04001934 RID: 6452
		private readonly int[] syndroms;

		// Token: 0x04001935 RID: 6453
		private readonly int[] lambda;

		// Token: 0x04001936 RID: 6454
		private readonly int[] corrPoly;

		// Token: 0x04001937 RID: 6455
		private readonly int[] lambdaStar;

		// Token: 0x04001938 RID: 6456
		private readonly int[] lambdaPrime;

		// Token: 0x04001939 RID: 6457
		private readonly int[] omega;

		// Token: 0x0400193A RID: 6458
		private readonly int[] errorIndexes;

		// Token: 0x0400193B RID: 6459
		private readonly int[] chienCache;
	}
}
