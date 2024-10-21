using System;
using System.IO;

namespace ErrorCorrection
{
	// Token: 0x0200036B RID: 875
	public class BlockStreamReadAdapter : Stream
	{
		// Token: 0x06002007 RID: 8199 RVA: 0x00018BD5 File Offset: 0x00016DD5
		public BlockStreamReadAdapter(Stream blockSource, int blockSize)
		{
			this.blockSource = blockSource;
			this.BlockSize = blockSize;
			this.leftovers = new byte[blockSize];
			this.leftoverSize = 0;
		}

		// Token: 0x17000468 RID: 1128
		// (get) Token: 0x06002008 RID: 8200 RVA: 0x0000D554 File Offset: 0x0000B754
		public override bool CanRead
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000469 RID: 1129
		// (get) Token: 0x06002009 RID: 8201 RVA: 0x0000C609 File Offset: 0x0000A809
		public override bool CanWrite
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700046A RID: 1130
		// (get) Token: 0x0600200A RID: 8202 RVA: 0x0000C609 File Offset: 0x0000A809
		public override bool CanSeek
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700046B RID: 1131
		// (get) Token: 0x0600200B RID: 8203 RVA: 0x00005F9B File Offset: 0x0000419B
		public override long Length
		{
			get
			{
				throw new NotSupportedException();
			}
		}

		// Token: 0x1700046C RID: 1132
		// (get) Token: 0x0600200C RID: 8204 RVA: 0x00005F9B File Offset: 0x0000419B
		// (set) Token: 0x0600200D RID: 8205 RVA: 0x00005F9B File Offset: 0x0000419B
		public override long Position
		{
			get
			{
				throw new NotSupportedException();
			}
			set
			{
				throw new NotSupportedException();
			}
		}

		// Token: 0x1700046D RID: 1133
		// (get) Token: 0x0600200E RID: 8206 RVA: 0x00018BFE File Offset: 0x00016DFE
		// (set) Token: 0x0600200F RID: 8207 RVA: 0x00018C06 File Offset: 0x00016E06
		public int BlockSize { get; private set; }

		// Token: 0x06002010 RID: 8208 RVA: 0x000D7008 File Offset: 0x000D5208
		public override int Read(byte[] buffer, int offset, int count)
		{
			int num = 0;
			if (this.leftoverSize > 0)
			{
				int num2 = Math.Min(this.leftoverSize, count);
				Array.Copy(this.leftovers, 0, buffer, offset, num2);
				count -= num2;
				offset += num2;
				num += num2;
				if (num2 < this.leftoverSize)
				{
					for (int i = 0; i < this.leftoverSize - num2; i++)
					{
						this.leftovers[i] = this.leftovers[i + num2];
					}
					this.leftoverSize -= num2;
					return num;
				}
				this.leftoverSize = 0;
			}
			while (count >= this.BlockSize)
			{
				if (this.blockSource.Read(buffer, offset, this.BlockSize) == 0)
				{
					return num;
				}
				offset += this.BlockSize;
				count -= this.BlockSize;
				num += this.BlockSize;
			}
			if (count >= this.BlockSize)
			{
				throw new Exception();
			}
			if (count > 0)
			{
				if (this.blockSource.Read(this.leftovers, 0, this.BlockSize) == 0)
				{
					return num;
				}
				Array.Copy(this.leftovers, 0, buffer, offset, count);
				int num3 = this.BlockSize - count;
				for (int j = 0; j < num3; j++)
				{
					this.leftovers[j] = this.leftovers[j + count];
				}
				num += count;
				this.leftoverSize = num3;
			}
			return num;
		}

		// Token: 0x06002011 RID: 8209 RVA: 0x00005F9B File Offset: 0x0000419B
		public override void Write(byte[] buffer, int offset, int count)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06002012 RID: 8210 RVA: 0x00005F9B File Offset: 0x0000419B
		public void SetLength(long value)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06002013 RID: 8211 RVA: 0x00005F9B File Offset: 0x0000419B
		public override long Seek(long offset, SeekOrigin origin)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06002014 RID: 8212 RVA: 0x00018C0F File Offset: 0x00016E0F
		public override void Flush()
		{
			this.blockSource.Flush();
		}

		// Token: 0x04001920 RID: 6432
		private Stream blockSource;

		// Token: 0x04001921 RID: 6433
		private byte[] leftovers;

		// Token: 0x04001922 RID: 6434
		private int leftoverSize;
	}
}
