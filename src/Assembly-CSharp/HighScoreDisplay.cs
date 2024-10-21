using System;
using TMPro;
using UnityEngine;

// Token: 0x020001E5 RID: 485
public class HighScoreDisplay : MonoBehaviour
{
	// Token: 0x0600157D RID: 5501 RVA: 0x000A7CEC File Offset: 0x000A5EEC
	private void \u02B4\u02BA\u02BE\u02BB\u02B5\u02BB\u02C1\u02B2\u02B4\u02B2\u02BF()
	{
		if (GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BD\u02B9\u02B7\u02B5\u02BF\u02BC\u02BF\u02BA\u02BE\u02B6\u02B4)
		{
			base.gameObject.SetActive(false);
			return;
		}
		this.displayText.text = \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02BA\u02B9\u02C1\u02B9\u02B2\u02BD\u02B2\u02BC\u02B7\u02BA\u02B8().\u02BB\u02B9\u02BB\u02B8\u02B3\u02B2\u02B5\u02B6\u02B4\u02B2\u02B4("Highway");
		this.objects.SetActive(true);
	}

	// Token: 0x0600157F RID: 5503 RVA: 0x000A7D38 File Offset: 0x000A5F38
	private void Start()
	{
		if (GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BD\u02B9\u02B7\u02B5\u02BF\u02BC\u02BF\u02BA\u02BE\u02B6\u02B4)
		{
			base.gameObject.SetActive(false);
			return;
		}
		this.displayText.text = \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02B3\u02B5\u02BB\u02BE\u02C1\u02B7\u02B2\u02C0\u02C0\u02BB\u02B6("New Personal Best!");
		this.objects.SetActive(false);
	}

	// Token: 0x06001580 RID: 5504 RVA: 0x00011357 File Offset: 0x0000F557
	public void \u02B3\u02BC\u02B4\u02B5\u02BD\u02C0\u02B8\u02BD\u02B7\u02B5\u02BF(bool \u02BD\u02B9\u02C1\u02B4\u02BB\u02B5\u02BB\u02B8\u02C1\u02B6\u02B2 = false)
	{
		this.objects.SetActive(true);
		this.animator.Play((!\u02BD\u02B9\u02C1\u02B4\u02BB\u02B5\u02BB\u02B8\u02C1\u02B6\u02B2) ? "BaseAnimation" : "BaseAnimationBackwards");
	}

	// Token: 0x06001581 RID: 5505 RVA: 0x0001137F File Offset: 0x0000F57F
	public void \u02B4\u02B6\u02B8\u02B8\u02B9\u02BA\u02BA\u02B7\u02B8\u02BD\u02B4(bool \u02BD\u02B9\u02C1\u02B4\u02BB\u02B5\u02BB\u02B8\u02C1\u02B6\u02B2 = false)
	{
		this.objects.SetActive(true);
		this.animator.Play((!\u02BD\u02B9\u02C1\u02B4\u02BB\u02B5\u02BB\u02B8\u02C1\u02B6\u02B2) ? "" : "Video Highways");
	}

	// Token: 0x06001582 RID: 5506 RVA: 0x000A7D84 File Offset: 0x000A5F84
	private void \u02BF\u02BA\u02B5\u02B8\u02B5\u02BF\u02B2\u02BF\u02B3\u02BC\u02BA()
	{
		if (GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BD\u02B9\u02B7\u02B5\u02BF\u02BC\u02BF\u02BA\u02BE\u02B6\u02B4)
		{
			base.gameObject.SetActive(true);
			return;
		}
		this.displayText.text = \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02B2\u02BE\u02BA\u02B7\u02B4\u02BA\u02BD\u02BE\u02B7\u02B8\u02BE().\u02B9\u02BC\u02BD\u02BE\u02BA\u02C0\u02BC\u02C1\u02BD\u02B3\u02BD("Stars Earned");
		this.objects.SetActive(false);
	}

	// Token: 0x06001583 RID: 5507 RVA: 0x000A7DD0 File Offset: 0x000A5FD0
	private void \u02C0\u02BE\u02B2\u02BE\u02C0\u02B5\u02B3\u02B7\u02B2\u02B8\u02B5()
	{
		if (GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BD\u02B9\u02B7\u02B5\u02BF\u02BC\u02BF\u02BA\u02BE\u02B6\u02B4)
		{
			base.gameObject.SetActive(true);
			return;
		}
		this.displayText.text = \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02B2\u02BE\u02BA\u02B7\u02B4\u02BA\u02BD\u02BE\u02B7\u02B8\u02BE().\u02BB\u02B9\u02BB\u02B8\u02B3\u02B2\u02B5\u02B6\u02B4\u02B2\u02B4("Highway Placement");
		this.objects.SetActive(false);
	}

	// Token: 0x06001584 RID: 5508 RVA: 0x000113A7 File Offset: 0x0000F5A7
	public void \u02BE\u02C0\u02B5\u02B5\u02B3\u02B7\u02C1\u02B3\u02BA\u02B5\u02B7(bool \u02BD\u02B9\u02C1\u02B4\u02BB\u02B5\u02BB\u02B8\u02C1\u02B6\u02B2 = false)
	{
		this.objects.SetActive(true);
		this.animator.Play((!\u02BD\u02B9\u02C1\u02B4\u02BB\u02B5\u02BB\u02B8\u02C1\u02B6\u02B2) ? "Tom1" : "Metal");
	}

	// Token: 0x04000FD3 RID: 4051
	[SerializeField]
	private global::UnityEngine.Animator animator;

	// Token: 0x04000FD4 RID: 4052
	[SerializeField]
	private TextMeshProUGUI displayText;

	// Token: 0x04000FD5 RID: 4053
	[SerializeField]
	private GameObject objects;
}
