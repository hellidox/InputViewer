using System;
using System.IO;

namespace ErrorCorrection
{
	// Token: 0x0200036C RID: 876
	public class RsDecoderStream : Stream
	{
		// Token: 0x06002015 RID: 8213 RVA: 0x000D7148 File Offset: 0x000D5348
		public RsDecoderStream(Stream stream, Decoder decoder)
		{
			this.stream = stream;
			this.decoder = decoder;
			this.inputBuffer = new byte[decoder.BlockSize];
			this.blockBuffer = new int[decoder.BlockSize];
			this.checkSymbols = decoder.BlockSize - decoder.MessageSize;
		}

		// Token: 0x06002016 RID: 8214 RVA: 0x000D71A0 File Offset: 0x000D53A0
		public override int Read(byte[] buffer, int offset, int count)
		{
			if (count != this.decoder.MessageSize)
			{
				throw new InvalidOperationException();
			}
			int num = this.stream.Read(this.inputBuffer, 0, this.decoder.BlockSize);
			if (num == 0)
			{
				return 0;
			}
			if (num != this.decoder.BlockSize)
			{
				this.stream.Position -= (long)num;
				return 0;
			}
			Array.Copy(this.inputBuffer, this.blockBuffer, this.decoder.BlockSize);
			this.decoder.Decode(this.blockBuffer);
			for (int i = 0; i < this.decoder.MessageSize; i++)
			{
				buffer[offset + i] = (byte)this.blockBuffer[this.checkSymbols + i];
			}
			return count;
		}

		// Token: 0x06002017 RID: 8215 RVA: 0x00005F9B File Offset: 0x0000419B
		public override void Write(byte[] buffer, int offset, int count)
		{
			throw new NotSupportedException();
		}

		// Token: 0x1700046E RID: 1134
		// (get) Token: 0x06002018 RID: 8216 RVA: 0x0000D554 File Offset: 0x0000B754
		public override bool CanRead
		{
			get
			{
				return true;
			}
		}

		// Token: 0x1700046F RID: 1135
		// (get) Token: 0x06002019 RID: 8217 RVA: 0x0000C609 File Offset: 0x0000A809
		public override bool CanWrite
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000470 RID: 1136
		// (get) Token: 0x0600201A RID: 8218 RVA: 0x0000C609 File Offset: 0x0000A809
		public override bool CanSeek
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000471 RID: 1137
		// (get) Token: 0x0600201B RID: 8219 RVA: 0x00005F9B File Offset: 0x0000419B
		// (set) Token: 0x0600201C RID: 8220 RVA: 0x00005F9B File Offset: 0x0000419B
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

		// Token: 0x17000472 RID: 1138
		// (get) Token: 0x0600201D RID: 8221 RVA: 0x00005F9B File Offset: 0x0000419B
		public override long Length
		{
			get
			{
				throw new NotSupportedException();
			}
		}

		// Token: 0x0600201E RID: 8222 RVA: 0x00005F9B File Offset: 0x0000419B
		public override long Seek(long offset, SeekOrigin origin)
		{
			throw new NotSupportedException();
		}

		// Token: 0x0600201F RID: 8223 RVA: 0x00018C1C File Offset: 0x00016E1C
		public override void Flush()
		{
			this.stream.Flush();
		}

		// Token: 0x06002020 RID: 8224 RVA: 0x00005F9B File Offset: 0x0000419B
		public void SetLength(long value)
		{
			throw new NotSupportedException();
		}

		// Token: 0x04001924 RID: 6436
		private Stream stream;

		// Token: 0x04001925 RID: 6437
		private Decoder decoder;

		// Token: 0x04001926 RID: 6438
		private int[] blockBuffer;

		// Token: 0x04001927 RID: 6439
		private byte[] inputBuffer;

		// Token: 0x04001928 RID: 6440
		private int checkSymbols;
	}
}
