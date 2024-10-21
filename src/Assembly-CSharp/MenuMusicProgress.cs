using System;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000008 RID: 8
public class MenuMusicProgress : MonoBehaviour
{
	// Token: 0x06000052 RID: 82 RVA: 0x00019148 File Offset: 0x00017348
	private void \u02C1\u02B8\u02B5\u02BD\u02BD\u02C0\u02BB\u02B4\u02BD\u02B8\u02B3()
	{
		if (BassAudioManager.Instance.\u02C0\u02B4\u02B5\u02B4\u02BA\u02B2\u02BB\u02BB\u02BB\u02B8\u02B8)
		{
			double num = BassAudioManager.Instance.\u02B4\u02B4\u02B3\u02B6\u02BA\u02B4\u02BE\u02B2\u02B8\u02B6\u02C0();
			double u02B9_u02BE_u02B9_u02B8_u02B2_u02B2_u02BE_u02BC_u02B5_u02B9_u02BC = BassAudioManager.Instance.\u02B9\u02BE\u02B9\u02B8\u02B2\u02B2\u02BE\u02BC\u02B5\u02B9\u02BC;
			this.progressSlider.value = (float)(num / u02B9_u02BE_u02B9_u02B8_u02B2_u02B2_u02BE_u02BC_u02B5_u02B9_u02BC);
		}
	}

	// Token: 0x06000053 RID: 83 RVA: 0x00019148 File Offset: 0x00017348
	private void Update()
	{
		if (BassAudioManager.Instance.\u02C0\u02B4\u02B5\u02B4\u02BA\u02B2\u02BB\u02BB\u02BB\u02B8\u02B8)
		{
			double num = BassAudioManager.Instance.\u02B4\u02B4\u02B3\u02B6\u02BA\u02B4\u02BE\u02B2\u02B8\u02B6\u02C0();
			double u02B9_u02BE_u02B9_u02B8_u02B2_u02B2_u02BE_u02BC_u02B5_u02B9_u02BC = BassAudioManager.Instance.\u02B9\u02BE\u02B9\u02B8\u02B2\u02B2\u02BE\u02BC\u02B5\u02B9\u02BC;
			this.progressSlider.value = (float)(num / u02B9_u02BE_u02B9_u02B8_u02B2_u02B2_u02BE_u02BC_u02B5_u02B9_u02BC);
		}
	}

	// Token: 0x06000054 RID: 84 RVA: 0x00019148 File Offset: 0x00017348
	private void \u02BC\u02B6\u02B8\u02BA\u02B2\u02B4\u02B7\u02B3\u02C0\u02B8\u02B7()
	{
		if (BassAudioManager.Instance.\u02C0\u02B4\u02B5\u02B4\u02BA\u02B2\u02BB\u02BB\u02BB\u02B8\u02B8)
		{
			double num = BassAudioManager.Instance.\u02B4\u02B4\u02B3\u02B6\u02BA\u02B4\u02BE\u02B2\u02B8\u02B6\u02C0();
			double u02B9_u02BE_u02B9_u02B8_u02B2_u02B2_u02BE_u02BC_u02B5_u02B9_u02BC = BassAudioManager.Instance.\u02B9\u02BE\u02B9\u02B8\u02B2\u02B2\u02BE\u02BC\u02B5\u02B9\u02BC;
			this.progressSlider.value = (float)(num / u02B9_u02BE_u02B9_u02B8_u02B2_u02B2_u02BE_u02BC_u02B5_u02B9_u02BC);
		}
	}

	// Token: 0x06000055 RID: 85 RVA: 0x00019148 File Offset: 0x00017348
	private void \u02BB\u02BF\u02BA\u02BC\u02B8\u02B7\u02B4\u02B5\u02B7\u02B9\u02C1()
	{
		if (BassAudioManager.Instance.\u02C0\u02B4\u02B5\u02B4\u02BA\u02B2\u02BB\u02BB\u02BB\u02B8\u02B8)
		{
			double num = BassAudioManager.Instance.\u02B4\u02B4\u02B3\u02B6\u02BA\u02B4\u02BE\u02B2\u02B8\u02B6\u02C0();
			double u02B9_u02BE_u02B9_u02B8_u02B2_u02B2_u02BE_u02BC_u02B5_u02B9_u02BC = BassAudioManager.Instance.\u02B9\u02BE\u02B9\u02B8\u02B2\u02B2\u02BE\u02BC\u02B5\u02B9\u02BC;
			this.progressSlider.value = (float)(num / u02B9_u02BE_u02B9_u02B8_u02B2_u02B2_u02BE_u02BC_u02B5_u02B9_u02BC);
		}
	}

	// Token: 0x06000056 RID: 86 RVA: 0x00019148 File Offset: 0x00017348
	private void \u02B2\u02B6\u02C1\u02B8\u02B3\u02B5\u02B7\u02B5\u02B6\u02B9\u02C0()
	{
		if (BassAudioManager.Instance.\u02C0\u02B4\u02B5\u02B4\u02BA\u02B2\u02BB\u02BB\u02BB\u02B8\u02B8)
		{
			double num = BassAudioManager.Instance.\u02B4\u02B4\u02B3\u02B6\u02BA\u02B4\u02BE\u02B2\u02B8\u02B6\u02C0();
			double u02B9_u02BE_u02B9_u02B8_u02B2_u02B2_u02BE_u02BC_u02B5_u02B9_u02BC = BassAudioManager.Instance.\u02B9\u02BE\u02B9\u02B8\u02B2\u02B2\u02BE\u02BC\u02B5\u02B9\u02BC;
			this.progressSlider.value = (float)(num / u02B9_u02BE_u02B9_u02B8_u02B2_u02B2_u02BE_u02BC_u02B5_u02B9_u02BC);
		}
	}

	// Token: 0x06000057 RID: 87 RVA: 0x00019148 File Offset: 0x00017348
	private void \u02C0\u02B5\u02BC\u02B3\u02B3\u02B7\u02B9\u02B2\u02C0\u02BC\u02BB()
	{
		if (BassAudioManager.Instance.\u02C0\u02B4\u02B5\u02B4\u02BA\u02B2\u02BB\u02BB\u02BB\u02B8\u02B8)
		{
			double num = BassAudioManager.Instance.\u02B4\u02B4\u02B3\u02B6\u02BA\u02B4\u02BE\u02B2\u02B8\u02B6\u02C0();
			double u02B9_u02BE_u02B9_u02B8_u02B2_u02B2_u02BE_u02BC_u02B5_u02B9_u02BC = BassAudioManager.Instance.\u02B9\u02BE\u02B9\u02B8\u02B2\u02B2\u02BE\u02BC\u02B5\u02B9\u02BC;
			this.progressSlider.value = (float)(num / u02B9_u02BE_u02B9_u02B8_u02B2_u02B2_u02BE_u02BC_u02B5_u02B9_u02BC);
		}
	}

	// Token: 0x06000058 RID: 88 RVA: 0x00019148 File Offset: 0x00017348
	private void \u02C0\u02BE\u02B7\u02BF\u02B9\u02BB\u02C1\u02B2\u02B9\u02B7\u02B5()
	{
		if (BassAudioManager.Instance.\u02C0\u02B4\u02B5\u02B4\u02BA\u02B2\u02BB\u02BB\u02BB\u02B8\u02B8)
		{
			double num = BassAudioManager.Instance.\u02B4\u02B4\u02B3\u02B6\u02BA\u02B4\u02BE\u02B2\u02B8\u02B6\u02C0();
			double u02B9_u02BE_u02B9_u02B8_u02B2_u02B2_u02BE_u02BC_u02B5_u02B9_u02BC = BassAudioManager.Instance.\u02B9\u02BE\u02B9\u02B8\u02B2\u02B2\u02BE\u02BC\u02B5\u02B9\u02BC;
			this.progressSlider.value = (float)(num / u02B9_u02BE_u02B9_u02B8_u02B2_u02B2_u02BE_u02BC_u02B5_u02B9_u02BC);
		}
	}

	// Token: 0x06000059 RID: 89 RVA: 0x00019148 File Offset: 0x00017348
	private void \u02B5\u02B9\u02B7\u02B7\u02B6\u02B5\u02BC\u02BA\u02B4\u02B2\u02B4()
	{
		if (BassAudioManager.Instance.\u02C0\u02B4\u02B5\u02B4\u02BA\u02B2\u02BB\u02BB\u02BB\u02B8\u02B8)
		{
			double num = BassAudioManager.Instance.\u02B4\u02B4\u02B3\u02B6\u02BA\u02B4\u02BE\u02B2\u02B8\u02B6\u02C0();
			double u02B9_u02BE_u02B9_u02B8_u02B2_u02B2_u02BE_u02BC_u02B5_u02B9_u02BC = BassAudioManager.Instance.\u02B9\u02BE\u02B9\u02B8\u02B2\u02B2\u02BE\u02BC\u02B5\u02B9\u02BC;
			this.progressSlider.value = (float)(num / u02B9_u02BE_u02B9_u02B8_u02B2_u02B2_u02BE_u02BC_u02B5_u02B9_u02BC);
		}
	}

	// Token: 0x0600005A RID: 90 RVA: 0x00019148 File Offset: 0x00017348
	private void \u02BB\u02B7\u02C0\u02B3\u02C1\u02BD\u02B9\u02B2\u02B4\u02BE\u02B6()
	{
		if (BassAudioManager.Instance.\u02C0\u02B4\u02B5\u02B4\u02BA\u02B2\u02BB\u02BB\u02BB\u02B8\u02B8)
		{
			double num = BassAudioManager.Instance.\u02B4\u02B4\u02B3\u02B6\u02BA\u02B4\u02BE\u02B2\u02B8\u02B6\u02C0();
			double u02B9_u02BE_u02B9_u02B8_u02B2_u02B2_u02BE_u02BC_u02B5_u02B9_u02BC = BassAudioManager.Instance.\u02B9\u02BE\u02B9\u02B8\u02B2\u02B2\u02BE\u02BC\u02B5\u02B9\u02BC;
			this.progressSlider.value = (float)(num / u02B9_u02BE_u02B9_u02B8_u02B2_u02B2_u02BE_u02BC_u02B5_u02B9_u02BC);
		}
	}

	// Token: 0x0600005B RID: 91 RVA: 0x00019148 File Offset: 0x00017348
	private void \u02BD\u02B7\u02BD\u02BF\u02BE\u02B9\u02B6\u02C0\u02B4\u02B7\u02BF()
	{
		if (BassAudioManager.Instance.\u02C0\u02B4\u02B5\u02B4\u02BA\u02B2\u02BB\u02BB\u02BB\u02B8\u02B8)
		{
			double num = BassAudioManager.Instance.\u02B4\u02B4\u02B3\u02B6\u02BA\u02B4\u02BE\u02B2\u02B8\u02B6\u02C0();
			double u02B9_u02BE_u02B9_u02B8_u02B2_u02B2_u02BE_u02BC_u02B5_u02B9_u02BC = BassAudioManager.Instance.\u02B9\u02BE\u02B9\u02B8\u02B2\u02B2\u02BE\u02BC\u02B5\u02B9\u02BC;
			this.progressSlider.value = (float)(num / u02B9_u02BE_u02B9_u02B8_u02B2_u02B2_u02BE_u02BC_u02B5_u02B9_u02BC);
		}
	}

	// Token: 0x0600005D RID: 93 RVA: 0x00019148 File Offset: 0x00017348
	private void \u02BD\u02B8\u02BD\u02B5\u02B6\u02B3\u02BF\u02B3\u02C1\u02B8\u02C1()
	{
		if (BassAudioManager.Instance.\u02C0\u02B4\u02B5\u02B4\u02BA\u02B2\u02BB\u02BB\u02BB\u02B8\u02B8)
		{
			double num = BassAudioManager.Instance.\u02B4\u02B4\u02B3\u02B6\u02BA\u02B4\u02BE\u02B2\u02B8\u02B6\u02C0();
			double u02B9_u02BE_u02B9_u02B8_u02B2_u02B2_u02BE_u02BC_u02B5_u02B9_u02BC = BassAudioManager.Instance.\u02B9\u02BE\u02B9\u02B8\u02B2\u02B2\u02BE\u02BC\u02B5\u02B9\u02BC;
			this.progressSlider.value = (float)(num / u02B9_u02BE_u02B9_u02B8_u02B2_u02B2_u02BE_u02BC_u02B5_u02B9_u02BC);
		}
	}

	// Token: 0x04000013 RID: 19
	[SerializeField]
	private Slider progressSlider;
}
