using System;
using System.IO;
using UnityEngine;

namespace ErrorCorrection
{
	// Token: 0x02000368 RID: 872
	public class BlockStreamWriteAdapter : Stream
	{
		// Token: 0x06001FE4 RID: 8164 RVA: 0x000D6B90 File Offset: 0x000D4D90
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

		// Token: 0x1700045A RID: 1114
		// (get) Token: 0x06001FE5 RID: 8165 RVA: 0x00018B84 File Offset: 0x00016D84
		// (set) Token: 0x06001FE6 RID: 8166 RVA: 0x00018B8C File Offset: 0x00016D8C
		public int BlockSize { get; private set; }

		// Token: 0x1700045B RID: 1115
		// (get) Token: 0x06001FE7 RID: 8167 RVA: 0x0000C609 File Offset: 0x0000A809
		public override bool CanRead
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700045C RID: 1116
		// (get) Token: 0x06001FE8 RID: 8168 RVA: 0x0000D554 File Offset: 0x0000B754
		public override bool CanWrite
		{
			get
			{
				return true;
			}
		}

		// Token: 0x1700045D RID: 1117
		// (get) Token: 0x06001FE9 RID: 8169 RVA: 0x0000C609 File Offset: 0x0000A809
		public override bool CanSeek
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700045E RID: 1118
		// (get) Token: 0x06001FEA RID: 8170 RVA: 0x00005F9B File Offset: 0x0000419B
		// (set) Token: 0x06001FEB RID: 8171 RVA: 0x00005F9B File Offset: 0x0000419B
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

		// Token: 0x1700045F RID: 1119
		// (get) Token: 0x06001FEC RID: 8172 RVA: 0x00005F9B File Offset: 0x0000419B
		public override long Length
		{
			get
			{
				throw new NotSupportedException();
			}
		}

		// Token: 0x06001FED RID: 8173 RVA: 0x000D6BDC File Offset: 0x000D4DDC
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

		// Token: 0x06001FEE RID: 8174 RVA: 0x00005F9B File Offset: 0x0000419B
		public override int Read(byte[] buffer, int offset, int count)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06001FEF RID: 8175 RVA: 0x00005F9B File Offset: 0x0000419B
		public void SetLength(long value)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06001FF0 RID: 8176 RVA: 0x00005F9B File Offset: 0x0000419B
		public override long Seek(long offset, SeekOrigin origin)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06001FF1 RID: 8177 RVA: 0x000D6CD4 File Offset: 0x000D4ED4
		public override void Flush()
		{
			if (this.leftoversSize > 0)
			{
				Array.Clear(this.leftovers, this.leftoversSize, this.BlockSize - this.leftoversSize);
				this.blockSink.Write(this.leftovers, 0, this.BlockSize);
				this.blockSink.Flush();
			}
		}

		// Token: 0x04001910 RID: 6416
		private Stream blockSink;

		// Token: 0x04001911 RID: 6417
		private byte[] leftovers;

		// Token: 0x04001912 RID: 6418
		private int leftoversSize;
	}
}
