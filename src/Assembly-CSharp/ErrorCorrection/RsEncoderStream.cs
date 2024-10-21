using System;
using System.IO;

namespace ErrorCorrection
{
	// Token: 0x02000369 RID: 873
	public class RsEncoderStream : Stream
	{
		// Token: 0x06001FF2 RID: 8178 RVA: 0x000D6D2C File Offset: 0x000D4F2C
		public RsEncoderStream(Stream stream, Encoder encoder)
		{
			if (!stream.CanWrite)
			{
				throw new ArgumentException("Must be a writable stream", "stream");
			}
			this.stream = stream;
			this.encoder = encoder;
			this.blockBuffer = new int[encoder.BlockSize];
			this.checkSymbols = encoder.BlockSize - encoder.MessageSize;
			this.outputBuffer = new byte[encoder.BlockSize];
		}

		// Token: 0x17000460 RID: 1120
		// (get) Token: 0x06001FF3 RID: 8179 RVA: 0x0000D554 File Offset: 0x0000B754
		public override bool CanWrite
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000461 RID: 1121
		// (get) Token: 0x06001FF4 RID: 8180 RVA: 0x0000C609 File Offset: 0x0000A809
		public override bool CanRead
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000462 RID: 1122
		// (get) Token: 0x06001FF5 RID: 8181 RVA: 0x0000C609 File Offset: 0x0000A809
		public override bool CanSeek
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000463 RID: 1123
		// (get) Token: 0x06001FF6 RID: 8182 RVA: 0x0000C609 File Offset: 0x0000A809
		public bool CanTimeout
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06001FF7 RID: 8183 RVA: 0x00018B95 File Offset: 0x00016D95
		public override void Close()
		{
			base.Close();
			this.stream.Close();
		}

		// Token: 0x17000464 RID: 1124
		// (get) Token: 0x06001FF8 RID: 8184 RVA: 0x00018BA8 File Offset: 0x00016DA8
		// (set) Token: 0x06001FF9 RID: 8185 RVA: 0x00018BA8 File Offset: 0x00016DA8
		public override long Position
		{
			get
			{
				throw new InvalidOperationException();
			}
			set
			{
				throw new InvalidOperationException();
			}
		}

		// Token: 0x17000465 RID: 1125
		// (get) Token: 0x06001FFA RID: 8186 RVA: 0x00018BA8 File Offset: 0x00016DA8
		public override long Length
		{
			get
			{
				throw new InvalidOperationException();
			}
		}

		// Token: 0x06001FFB RID: 8187 RVA: 0x00018BA8 File Offset: 0x00016DA8
		public void SetLength(long value)
		{
			throw new InvalidOperationException();
		}

		// Token: 0x06001FFC RID: 8188 RVA: 0x00018BA8 File Offset: 0x00016DA8
		public override long Seek(long offset, SeekOrigin origin)
		{
			throw new InvalidOperationException();
		}

		// Token: 0x06001FFD RID: 8189 RVA: 0x000D6D9C File Offset: 0x000D4F9C
		public override void Write(byte[] buffer, int offset, int count)
		{
			if (count != this.encoder.MessageSize)
			{
				throw new InvalidOperationException("RsEncoderStream only accepts writes that are exactly the size of a single reed-solmon block. Use BlockStreamWriteAdapter to buffer writes of differing sizes.");
			}
			Array.Clear(this.blockBuffer, 0, this.checkSymbols);
			Array.Copy(buffer, offset, this.blockBuffer, this.checkSymbols, count);
			this.encoder.Encode(this.blockBuffer);
			for (int i = 0; i < this.blockBuffer.Length; i++)
			{
				this.outputBuffer[i] = (byte)this.blockBuffer[i];
			}
			this.stream.Write(this.outputBuffer, 0, this.outputBuffer.Length);
		}

		// Token: 0x06001FFE RID: 8190 RVA: 0x00018BA8 File Offset: 0x00016DA8
		public override void WriteByte(byte value)
		{
			throw new InvalidOperationException();
		}

		// Token: 0x06001FFF RID: 8191 RVA: 0x00018BAF File Offset: 0x00016DAF
		public override void Flush()
		{
			this.stream.Flush();
		}

		// Token: 0x06002000 RID: 8192 RVA: 0x00018BA8 File Offset: 0x00016DA8
		public override int Read(byte[] buffer, int offset, int count)
		{
			throw new InvalidOperationException();
		}

		// Token: 0x04001914 RID: 6420
		private Stream stream;

		// Token: 0x04001915 RID: 6421
		private Encoder encoder;

		// Token: 0x04001916 RID: 6422
		private int[] blockBuffer;

		// Token: 0x04001917 RID: 6423
		private byte[] outputBuffer;

		// Token: 0x04001918 RID: 6424
		private int checkSymbols;
	}
}
