using System;
using System.Collections.Generic;
using System.Linq;

public class Beats
{
	public void \u02B4\u02C0\u02B2\u02B8\u02B7\u02B6\u02C1\u02C0\u02BA\u02B6\u02B2(\u02B7\u02BD\u02BB\u02BB\u02BF\u02B5\u02C0\u02C1\u02BD\u02B3\u02B6 \u02B4\u02BC\u02BF\u02BC\u02BA\u02B9\u02B8\u02B2\u02BD\u02BE\u02BD)
	{
		uint num = 0U;
		uint num2 = \u02B4\u02BC\u02BF\u02BC\u02BA\u02B9\u02B8\u02B2\u02BD\u02BE\u02BD.\u02BF\u02BC\u02BF\u02BF\u02B5\u02B5\u02B2\u02BF\u02B7\u02C1\u02BB();
		\u02C0\u02B8\u02BC\u02B9\u02BD\u02BA\u02B8\u02C0\u02B7\u02BD\u02B5 u02C0_u02B8_u02BC_u02B9_u02BD_u02BA_u02B8_u02C0_u02B7_u02BD_u02B = null;
		\u02C0\u02B8\u02BC\u02B9\u02BD\u02BA\u02B8\u02C0\u02B7\u02BD\u02B5 u02C0_u02B8_u02BC_u02B9_u02BD_u02BA_u02B8_u02C0_u02B7_u02BD_u02B2 = \u02B4\u02BC\u02BF\u02BC\u02BA\u02B9\u02B8\u02B2\u02BD\u02BE\u02BD.\u02B4\u02B5\u02BF\u02B9\u02B9\u02BE\u02BF\u02B3\u02C0\u02B5\u02BC(num);
		int num3 = 0;
		int num4 = 0;
		while (num <= num2)
		{
			u02C0_u02B8_u02BC_u02B9_u02BD_u02BA_u02B8_u02C0_u02B7_u02BD_u02B2 = \u02B4\u02BC\u02BF\u02BC\u02BA\u02B9\u02B8\u02B2\u02BD\u02BE\u02BD.\u02B4\u02B5\u02BF\u02B9\u02B9\u02BE\u02BF\u02B3\u02C0\u02B5\u02BC(num);
			uint num5 = u02C0_u02B8_u02BC_u02B9_u02BD_u02BA_u02B8_u02C0_u02B7_u02BD_u02B2.\u02B2\u02B2\u02C0\u02B5\u02BC\u02BF\u02B3\u02B8\u02BE\u02BE\u02B4 / 4U;
			bool flag = u02C0_u02B8_u02BC_u02B9_u02BD_u02BA_u02B8_u02C0_u02B7_u02BD_u02B == null || (u02C0_u02B8_u02BC_u02B9_u02BD_u02BA_u02B8_u02C0_u02B7_u02BD_u02B != null && (u02C0_u02B8_u02BC_u02B9_u02BD_u02BA_u02B8_u02C0_u02B7_u02BD_u02B.\u02B6\u02B6\u02C1\u02BF\u02B7\u02BE\u02B9\u02B8\u02B4\u02B7\u02B2 != u02C0_u02B8_u02BC_u02B9_u02BD_u02BA_u02B8_u02C0_u02B7_u02BD_u02B2.\u02B6\u02B6\u02C1\u02BF\u02B7\u02BE\u02B9\u02B8\u02B4\u02B7\u02B2 || u02C0_u02B8_u02BC_u02B9_u02BD_u02BA_u02B8_u02C0_u02B7_u02BD_u02B.\u02B2\u02B2\u02C0\u02B5\u02BC\u02BF\u02B3\u02B8\u02BE\u02BE\u02B4 != u02C0_u02B8_u02BC_u02B9_u02BD_u02BA_u02B8_u02C0_u02B7_u02BD_u02B2.\u02B2\u02B2\u02C0\u02B5\u02BC\u02BF\u02B3\u02B8\u02BE\u02BE\u02B4));
			if (flag)
			{
				num4 = 0;
				num3 = 0;
			}
			if ((long)num3 == (long)((ulong)u02C0_u02B8_u02BC_u02B9_u02BD_u02BA_u02B8_u02C0_u02B7_u02BD_u02B2.\u02B6\u02B6\u02C1\u02BF\u02B7\u02BE\u02B9\u02B8\u02B4\u02B7\u02B2))
			{
				num3 = 0;
			}
			if (num3 == 0 || flag)
			{
				if (u02C0_u02B8_u02BC_u02B9_u02BD_u02BA_u02B8_u02C0_u02B7_u02BD_u02B2.\u02B6\u02B6\u02C1\u02BF\u02B7\u02BE\u02B9\u02B8\u02B4\u02B7\u02B2 == 1U && num4 > 0)
				{
					if (u02C0_u02B8_u02BC_u02B9_u02BD_u02BA_u02B8_u02C0_u02B7_u02BD_u02B2.\u02B2\u02B2\u02C0\u02B5\u02BC\u02BF\u02B3\u02B8\u02BE\u02BE\u02B4 <= 4U || (long)num4 % (long)((ulong)num5) == 0L)
					{
						this.\u02BC\u02BA\u02BE\u02BC\u02C1\u02BC\u02B9\u02C1\u02C1\u02B7\u02BB(\u02B4\u02BC\u02BF\u02BC\u02BA\u02B9\u02B8\u02B2\u02BD\u02BE\u02BD, num, BeatStyle.BEAT_STRONG);
					}
					else
					{
						this.\u02BC\u02BA\u02BE\u02BC\u02C1\u02BC\u02B9\u02C1\u02C1\u02B7\u02BB(\u02B4\u02BC\u02BF\u02BC\u02BA\u02B9\u02B8\u02B2\u02BD\u02BE\u02BD, num, BeatStyle.BEAT_WEAK);
					}
				}
				else
				{
					if (u02C0_u02B8_u02BC_u02B9_u02BD_u02BA_u02B8_u02C0_u02B7_u02BD_u02B != null && u02C0_u02B8_u02BC_u02B9_u02BD_u02BA_u02B8_u02C0_u02B7_u02BD_u02B.\u02B2\u02B2\u02C0\u02B5\u02BC\u02BF\u02B3\u02B8\u02BE\u02BE\u02B4 > 4U)
					{
						this.BeatTypes[this.BeatTypes.Count - 1] = BeatStyle.BEAT_WEAK;
					}
					this.\u02BC\u02BA\u02BE\u02BC\u02C1\u02BC\u02B9\u02C1\u02C1\u02B7\u02BB(\u02B4\u02BC\u02BF\u02BC\u02BA\u02B9\u02B8\u02B2\u02BD\u02BE\u02BD, num, BeatStyle.MEASURE);
				}
			}
			else if (u02C0_u02B8_u02BC_u02B9_u02BD_u02BA_u02B8_u02C0_u02B7_u02BD_u02B2.\u02B2\u02B2\u02C0\u02B5\u02BC\u02BF\u02B3\u02B8\u02BE\u02BE\u02B4 <= 4U || (long)num3 % (long)((ulong)num5) == 0L)
			{
				this.\u02BC\u02BA\u02BE\u02BC\u02C1\u02BC\u02B9\u02C1\u02C1\u02B7\u02BB(\u02B4\u02BC\u02BF\u02BC\u02BA\u02B9\u02B8\u02B2\u02BD\u02BE\u02BD, num, BeatStyle.BEAT_STRONG);
			}
			else
			{
				this.\u02BC\u02BA\u02BE\u02BC\u02C1\u02BC\u02B9\u02C1\u02C1\u02B7\u02BB(\u02B4\u02BC\u02BF\u02BC\u02BA\u02B9\u02B8\u02B2\u02BD\u02BE\u02BD, num, BeatStyle.BEAT_WEAK);
			}
			num3++;
			num4++;
			num += (uint)(\u02B4\u02BC\u02BF\u02BC\u02BA\u02B9\u02B8\u02B2\u02BD\u02BE\u02BD.\u02C0\u02B3\u02C1\u02BB\u02B5\u02BA\u02BB\u02B3\u02C1\u02B8\u02BD * 4f / u02C0_u02B8_u02BC_u02B9_u02BD_u02BA_u02B8_u02C0_u02B7_u02BD_u02B2.\u02B2\u02B2\u02C0\u02B5\u02BC\u02BF\u02B3\u02B8\u02BE\u02BE\u02B4);
			u02C0_u02B8_u02BC_u02B9_u02BD_u02BA_u02B8_u02C0_u02B7_u02BD_u02B = u02C0_u02B8_u02BC_u02B9_u02BD_u02BA_u02B8_u02C0_u02B7_u02BD_u02B2;
		}
		this.\u02BE\u02BE\u02BC\u02B4\u02C0\u02B2\u02BA\u02BA\u02B5\u02B8\u02B5 = this.measures.Count - 1;
	}

	public Beats()
	{
		this.times = new List<float>();
		this.measures = new List<float>();
		this.BeatTypes = new List<BeatStyle>();
	}

	public int \u02B4\u02B8\u02BD\u02C0\u02B5\u02B2\u02BB\u02BC\u02BB\u02B2\u02BE()
	{
		return this.times.Count;
	}

	public int \u02BF\u02B2\u02BC\u02B5\u02C1\u02B8\u02BA\u02B9\u02B7\u02B7\u02B9 { get; private set; }

	public void \u02C0\u02B6\u02BD\u02BE\u02BE\u02BB\u02B4\u02B4\u02B7\u02B6\u02BC(double \u02B2\u02BB\u02BA\u02B9\u02BA\u02B2\u02B7\u02BE\u02BB\u02BA\u02B9)
	{
		while (this.\u02BF\u02B2\u02BC\u02B5\u02C1\u02B8\u02BA\u02B9\u02B7\u02B7\u02B9 <= this.\u02BE\u02BE\u02BC\u02B4\u02C0\u02B2\u02BA\u02BA\u02B5\u02B8\u02B5 && \u02B2\u02BB\u02BA\u02B9\u02BA\u02B2\u02B7\u02BE\u02BB\u02BA\u02B9 > (double)this.measures[this.\u02BF\u02B2\u02BC\u02B5\u02C1\u02B8\u02BA\u02B9\u02B7\u02B7\u02B9])
		{
			int num = this.\u02BF\u02B2\u02BC\u02B5\u02C1\u02B8\u02BA\u02B9\u02B7\u02B7\u02B9;
			this.\u02BF\u02B2\u02BC\u02B5\u02C1\u02B8\u02BA\u02B9\u02B7\u02B7\u02B9 = num + 1;
		}
	}

	public int \u02BE\u02BC\u02C0\u02B2\u02B3\u02BA\u02B4\u02B3\u02B9\u02B9\u02B5()
	{
		return this.times.Count;
	}

	public int beatCount()
	{
		return this.times.Count;
	}

	private void \u02BC\u02BA\u02BE\u02BC\u02C1\u02BC\u02B9\u02C1\u02C1\u02B7\u02BB(\u02B7\u02BD\u02BB\u02BB\u02BF\u02B5\u02C0\u02C1\u02BD\u02B3\u02B6 \u02B4\u02BC\u02BF\u02BC\u02BA\u02B9\u02B8\u02B2\u02BD\u02BE\u02BD, uint \u02B6\u02B2\u02B8\u02B4\u02B7\u02B7\u02B2\u02B8\u02C1\u02B5\u02BF, BeatStyle beatType)
	{
		this.times.Add(\u02B4\u02BC\u02BF\u02BC\u02BA\u02B9\u02B8\u02B2\u02BD\u02BE\u02BD.\u02B9\u02B4\u02B6\u02B8\u02BE\u02B2\u02B6\u02C0\u02BC\u02BA\u02B7(\u02B6\u02B2\u02B8\u02B4\u02B7\u02B7\u02B2\u02B8\u02C1\u02B5\u02BF));
		this.BeatTypes.Add(beatType);
		if (beatType == BeatStyle.MEASURE)
		{
			this.measures.Add(this.times.Last<float>());
		}
	}

	public int count
	{
		get
		{
			return this.times.Count;
		}
	}

	public int \u02BD\u02BD\u02BC\u02B4\u02B5\u02C0\u02C0\u02BA\u02B7\u02B4\u02B8(Note \u02B9\u02BF\u02B6\u02BE\u02BA\u02BE\u02C1\u02B4\u02BB\u02C1\u02B2)
	{
		int num = this.\u02BF\u02B2\u02BC\u02B5\u02C1\u02B8\u02BA\u02B9\u02B7\u02B7\u02B9;
		while (num < this.measures.Count && \u02B9\u02BF\u02B6\u02BE\u02BA\u02BE\u02C1\u02B4\u02BB\u02C1\u02B2.\u02B2\u02B8\u02BA\u02BA\u02BC\u02B7\u02B5\u02B5\u02B6\u02B5\u02C1 >= this.measures[num])
		{
			num++;
		}
		return num;
	}

	public List<float> times;

	public List<BeatStyle> BeatTypes;

	public List<float> measures;

	private int \u02BE\u02BE\u02BC\u02B4\u02C0\u02B2\u02BA\u02BA\u02B5\u02B8\u02B5;
}
