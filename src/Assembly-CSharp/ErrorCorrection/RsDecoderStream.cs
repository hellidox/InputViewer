using System;
using System.IO;

namespace ErrorCorrection
{
	public class RsDecoderStream : Stream
	{
		public RsDecoderStream(Stream stream, Decoder decoder)
		{
			this.stream = stream;
			this.decoder = decoder;
			this.inputBuffer = new byte[decoder.BlockSize];
			this.blockBuffer = new int[decoder.BlockSize];
			this.checkSymbols = decoder.BlockSize - decoder.MessageSize;
		}

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

		public override void Write(byte[] buffer, int offset, int count)
		{
			throw new NotSupportedException();
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

		public override long Seek(long offset, SeekOrigin origin)
		{
			throw new NotSupportedException();
		}

		public override void Flush()
		{
			this.stream.Flush();
		}

		public void SetLength(long value)
		{
			throw new NotSupportedException();
		}

		private Stream stream;

		private Decoder decoder;

		private int[] blockBuffer;

		private byte[] inputBuffer;

		private int checkSymbols;
	}
}
