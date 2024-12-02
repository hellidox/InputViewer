using System;
using System.IO;

namespace ErrorCorrection
{
	public class BlockStreamReadAdapter : Stream
	{
		public BlockStreamReadAdapter(Stream blockSource, int blockSize)
		{
			this.blockSource = blockSource;
			this.BlockSize = blockSize;
			this.leftovers = new byte[blockSize];
			this.leftoverSize = 0;
		}

		public override bool CanRead
		{
			get
			{
				return true;
			}
		}

		public override bool CanWrite
		{
			get
			{
				return false;
			}
		}

		public override bool CanSeek
		{
			get
			{
				return false;
			}
		}

		public override long Length
		{
			get
			{
				throw new NotSupportedException();
			}
		}

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

		public int BlockSize { get; private set; }

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

		public override void Write(byte[] buffer, int offset, int count)
		{
			throw new NotSupportedException();
		}

		public void SetLength(long value)
		{
			throw new NotSupportedException();
		}

		public override long Seek(long offset, SeekOrigin origin)
		{
			throw new NotSupportedException();
		}

		public override void Flush()
		{
			this.blockSource.Flush();
		}

		private Stream blockSource;

		private byte[] leftovers;

		private int leftoverSize;
	}
}
