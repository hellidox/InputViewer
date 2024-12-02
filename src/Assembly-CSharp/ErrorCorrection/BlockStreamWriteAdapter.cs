using System;
using System.IO;
using UnityEngine;

namespace ErrorCorrection
{
	public class BlockStreamWriteAdapter : Stream
	{
		public BlockStreamWriteAdapter(Stream blockSink, int blockSize)
		{
			if (!blockSink.CanWrite)
			{
				throw new ArgumentException("The provided stream does not support writing", "blockSink");
			}
			this.blockSink = blockSink;
			this.BlockSize = blockSize;
			this.leftovers = new byte[blockSize];
			this.leftoversSize = 0;
		}

		public int BlockSize { get; private set; }

		public override bool CanRead
		{
			get
			{
				return false;
			}
		}

		public override bool CanWrite
		{
			get
			{
				return true;
			}
		}

		public override bool CanSeek
		{
			get
			{
				return false;
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

		public override long Length
		{
			get
			{
				throw new NotSupportedException();
			}
		}

		public override void Write(byte[] buffer, int offset, int count)
		{
			if (this.leftoversSize + count >= this.BlockSize)
			{
				if (this.leftoversSize > 0)
				{
					int num = this.BlockSize - this.leftoversSize;
					Array.Copy(buffer, offset, this.leftovers, this.leftoversSize, num);
					this.blockSink.Write(this.leftovers, 0, this.BlockSize);
					count -= num;
					offset += num;
					this.leftoversSize = 0;
				}
				while (count >= this.BlockSize)
				{
					this.blockSink.Write(buffer, offset, this.BlockSize);
					count -= this.BlockSize;
					offset += this.BlockSize;
				}
			}
			if (count > 0)
			{
				if (count + this.leftoversSize >= this.BlockSize)
				{
					Debug.Log(new string[] { "Attempted to save leftovers equal or larger than a block", "The point of leftovers is to store bytes that couldn't be written because they didn't fill a full block. However, we found that we have enough leftovers to fill a full block which means we should've written one more block to the output, but didn't. The math is broken somewhere" });
				}
				Array.Copy(buffer, offset, this.leftovers, this.leftoversSize, count);
				this.leftoversSize += count;
			}
		}

		public override int Read(byte[] buffer, int offset, int count)
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
			if (this.leftoversSize > 0)
			{
				Array.Clear(this.leftovers, this.leftoversSize, this.BlockSize - this.leftoversSize);
				this.blockSink.Write(this.leftovers, 0, this.BlockSize);
				this.blockSink.Flush();
			}
		}

		private Stream blockSink;

		private byte[] leftovers;

		private int leftoversSize;
	}
}
