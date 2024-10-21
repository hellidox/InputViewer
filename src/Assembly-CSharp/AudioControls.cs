using System;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Token: 0x02000219 RID: 537
public class AudioControls : MonoBehaviour
{
	// Token: 0x06001820 RID: 6176 RVA: 0x000126AE File Offset: 0x000108AE
	private void \u02B4\u02BF\u02B6\u02BB\u02B2\u02B6\u02C1\u02B3\u02BC\u02B7\u02BE()
	{
		this.playButton.onClick.AddListener(new UnityAction(this.\u02BB\u02BB\u02BD\u02C0\u02BD\u02B9\u02B6\u02B5\u02B7\u02B4\u02C1));
		this.songNameText.text = this.\u02BA\u02B6\u02BE\u02BD\u02B2\u02BC\u02C1\u02B8\u02BA\u02B4\u02B2().Name.\u02C1\u02B4\u02BF\u02C1\u02BE\u02B9\u02B6\u02B7\u02B5\u02B7\u02B5;
	}

	// Token: 0x06001821 RID: 6177 RVA: 0x000126E7 File Offset: 0x000108E7
	public void \u02BC\u02B6\u02BD\u02BE\u02BE\u02C1\u02C1\u02BD\u02B9\u02B5\u02BE(SongEntry \u02B6\u02B2\u02B5\u02BB\u02C1\u02BB\u02BA\u02B4\u02BF\u02BA\u02B5)
	{
		this.<\u02B7\u02B4\u02B7\u02B5\u02C0\u02C1\u02BF\u02BD\u02C1\u02BF\u02B9>k__BackingField = \u02B6\u02B2\u02B5\u02BB\u02C1\u02BB\u02BA\u02B4\u02BF\u02BA\u02B5;
	}

	// Token: 0x06001823 RID: 6179 RVA: 0x000126F0 File Offset: 0x000108F0
	private void \u02B6\u02B7\u02BE\u02BB\u02BD\u02BD\u02B7\u02B8\u02BC\u02B7\u02C1()
	{
		Debug.Log("Stars Earned");
		this.\u02BD\u02B7\u02B6\u02B4\u02BD\u02B8\u02B2\u02B6\u02B2\u02C0\u02B3.\u02B3\u02B6\u02B8\u02C1\u02B5\u02C1\u02B3\u02B4\u02B8\u02C0\u02BA(this);
	}

	// Token: 0x06001824 RID: 6180 RVA: 0x000126AE File Offset: 0x000108AE
	private void \u02B2\u02BB\u02B6\u02B4\u02BE\u02B8\u02B9\u02B2\u02B3\u02B6\u02C1()
	{
		this.playButton.onClick.AddListener(new UnityAction(this.\u02BB\u02BB\u02BD\u02C0\u02BD\u02B9\u02B6\u02B5\u02B7\u02B4\u02C1));
		this.songNameText.text = this.\u02BA\u02B6\u02BE\u02BD\u02B2\u02BC\u02C1\u02B8\u02BA\u02B4\u02B2().Name.\u02C1\u02B4\u02BF\u02C1\u02BE\u02B9\u02B6\u02B7\u02B5\u02B7\u02B5;
	}

	// Token: 0x06001825 RID: 6181 RVA: 0x00012708 File Offset: 0x00010908
	private void \u02B2\u02BE\u02B6\u02B7\u02C1\u02C1\u02BC\u02B2\u02BA\u02BA\u02B5()
	{
		Debug.Log("Error while loading CLI chart");
		this.\u02BD\u02B7\u02B6\u02B4\u02BD\u02B8\u02B2\u02B6\u02B2\u02C0\u02B3.\u02B3\u02B6\u02B8\u02C1\u02B5\u02C1\u02B3\u02B4\u02B8\u02C0\u02BA(this);
	}

	// Token: 0x06001826 RID: 6182 RVA: 0x00012720 File Offset: 0x00010920
	private void \u02C0\u02B5\u02B5\u02B5\u02B2\u02BA\u02B8\u02C1\u02BB\u02BA\u02BC()
	{
		Debug.Log("Disabled");
		this.\u02BD\u02B7\u02B6\u02B4\u02BD\u02B8\u02B2\u02B6\u02B2\u02C0\u02B3.\u02BB\u02BB\u02B8\u02B7\u02BF\u02B7\u02BB\u02B5\u02C1\u02B7\u02B9(this);
	}

	// Token: 0x06001827 RID: 6183 RVA: 0x00012738 File Offset: 0x00010938
	private void \u02B2\u02B7\u02B5\u02C0\u02B4\u02B3\u02B8\u02B3\u02C0\u02BD\u02B5()
	{
		this.playButton.onClick.AddListener(new UnityAction(this.\u02BB\u02B8\u02C1\u02B5\u02BB\u02B9\u02BB\u02B9\u02C1\u02BD\u02BF));
		this.songNameText.text = this.\u02BA\u02B4\u02B8\u02BA\u02C1\u02B7\u02BF\u02BD\u02B5\u02BE\u02BA.Name.\u02C1\u02B4\u02BF\u02C1\u02BE\u02B9\u02B6\u02B7\u02B5\u02B7\u02B5;
	}

	// Token: 0x06001828 RID: 6184 RVA: 0x00012771 File Offset: 0x00010971
	private void \u02B8\u02B3\u02BD\u02BE\u02BF\u02B2\u02B6\u02BC\u02B9\u02B7\u02B3()
	{
		Debug.Log("hasDrums");
		this.\u02BD\u02B7\u02B6\u02B4\u02BD\u02B8\u02B2\u02B6\u02B2\u02C0\u02B3.\u02B5\u02BD\u02BC\u02BF\u02BC\u02B6\u02B6\u02BA\u02BE\u02BF\u02BE(this);
	}

	// Token: 0x06001829 RID: 6185 RVA: 0x00012789 File Offset: 0x00010989
	private void \u02B7\u02B8\u02BD\u02C0\u02B2\u02B4\u02B7\u02C0\u02BC\u02BE\u02B3()
	{
		this.playButton.onClick.AddListener(new UnityAction(this.\u02B6\u02C0\u02BE\u02B4\u02BB\u02BD\u02BC\u02BB\u02C0\u02B8\u02B6));
		this.songNameText.text = this.\u02BA\u02B6\u02BE\u02BD\u02B2\u02BC\u02C1\u02B8\u02BA\u02B4\u02B2().Name.\u02B2\u02B2\u02B6\u02BA\u02C1\u02C1\u02BE\u02B2\u02B3\u02BF\u02BA();
	}

	// Token: 0x0600182A RID: 6186 RVA: 0x000126E7 File Offset: 0x000108E7
	public void \u02BB\u02B8\u02BD\u02B7\u02B6\u02BF\u02B2\u02B6\u02BF\u02B7\u02BE(SongEntry \u02B6\u02B2\u02B5\u02BB\u02C1\u02BB\u02BA\u02B4\u02BF\u02BA\u02B5)
	{
		this.<\u02B7\u02B4\u02B7\u02B5\u02C0\u02C1\u02BF\u02BD\u02C1\u02BF\u02B9>k__BackingField = \u02B6\u02B2\u02B5\u02BB\u02C1\u02BB\u02BA\u02B4\u02BF\u02BA\u02B5;
	}

	// Token: 0x0600182B RID: 6187 RVA: 0x000127C2 File Offset: 0x000109C2
	private void \u02BB\u02B8\u02C1\u02B5\u02BB\u02B9\u02BB\u02B9\u02C1\u02BD\u02BF()
	{
		Debug.Log("Played");
		this.\u02BD\u02B7\u02B6\u02B4\u02BD\u02B8\u02B2\u02B6\u02B2\u02C0\u02B3.\u02B5\u02BD\u02BC\u02BF\u02BC\u02B6\u02B6\u02BA\u02BE\u02BF\u02BE(this);
	}

	// Token: 0x0600182C RID: 6188 RVA: 0x000127DA File Offset: 0x000109DA
	private void \u02B6\u02B6\u02B4\u02BB\u02B7\u02C1\u02C0\u02B6\u02B7\u02BD\u02B5()
	{
		this.playButton.onClick.AddListener(new UnityAction(this.\u02BA\u02BF\u02BE\u02C1\u02B4\u02B7\u02BD\u02BE\u02BA\u02BC\u02B2));
		this.songNameText.text = this.\u02BA\u02B4\u02B8\u02BA\u02C1\u02B7\u02BF\u02BD\u02B5\u02BE\u02BA.Name.\u02C1\u02B4\u02BF\u02C1\u02BE\u02B9\u02B6\u02B7\u02B5\u02B7\u02B5;
	}

	// Token: 0x0600182D RID: 6189 RVA: 0x00012813 File Offset: 0x00010A13
	private void \u02BB\u02BB\u02BD\u02C0\u02BD\u02B9\u02B6\u02B5\u02B7\u02B4\u02C1()
	{
		Debug.Log("android.os.Build$VERSION");
		this.\u02BD\u02B7\u02B6\u02B4\u02BD\u02B8\u02B2\u02B6\u02B2\u02C0\u02B3.\u02BB\u02BB\u02B8\u02B7\u02BF\u02B7\u02BB\u02B5\u02C1\u02B7\u02B9(this);
	}

	// Token: 0x0600182E RID: 6190 RVA: 0x000126E7 File Offset: 0x000108E7
	public void \u02BE\u02BB\u02B2\u02BE\u02B5\u02C1\u02BA\u02B5\u02BD\u02B8\u02BB(SongEntry \u02B6\u02B2\u02B5\u02BB\u02C1\u02BB\u02BA\u02B4\u02BF\u02BA\u02B5)
	{
		this.<\u02B7\u02B4\u02B7\u02B5\u02C0\u02C1\u02BF\u02BD\u02C1\u02BF\u02B9>k__BackingField = \u02B6\u02B2\u02B5\u02BB\u02C1\u02BB\u02BA\u02B4\u02BF\u02BA\u02B5;
	}

	// Token: 0x0600182F RID: 6191 RVA: 0x0001282B File Offset: 0x00010A2B
	public SongEntry \u02BA\u02B6\u02BE\u02BD\u02B2\u02BC\u02C1\u02B8\u02BA\u02B4\u02B2()
	{
		return this.<\u02B7\u02B4\u02B7\u02B5\u02C0\u02C1\u02BF\u02BD\u02C1\u02BF\u02B9>k__BackingField;
	}

	// Token: 0x1700024F RID: 591
	// (get) Token: 0x06001834 RID: 6196 RVA: 0x0001282B File Offset: 0x00010A2B
	// (set) Token: 0x06001830 RID: 6192 RVA: 0x000126E7 File Offset: 0x000108E7
	public SongEntry \u02BA\u02B4\u02B8\u02BA\u02C1\u02B7\u02BF\u02BD\u02B5\u02BE\u02BA { get; set; }

	// Token: 0x06001831 RID: 6193 RVA: 0x000126E7 File Offset: 0x000108E7
	public void \u02BA\u02BD\u02B5\u02B9\u02B5\u02B8\u02B8\u02BA\u02B2\u02B7\u02B6(SongEntry \u02B6\u02B2\u02B5\u02BB\u02C1\u02BB\u02BA\u02B4\u02BF\u02BA\u02B5)
	{
		this.<\u02B7\u02B4\u02B7\u02B5\u02C0\u02C1\u02BF\u02BD\u02C1\u02BF\u02B9>k__BackingField = \u02B6\u02B2\u02B5\u02BB\u02C1\u02BB\u02BA\u02B4\u02BF\u02BA\u02B5;
	}

	// Token: 0x06001832 RID: 6194 RVA: 0x00012833 File Offset: 0x00010A33
	private void \u02BA\u02BF\u02BE\u02C1\u02B4\u02B7\u02BD\u02BE\u02BA\u02BC\u02B2()
	{
		Debug.Log("settings");
		this.\u02BD\u02B7\u02B6\u02B4\u02BD\u02B8\u02B2\u02B6\u02B2\u02C0\u02B3.\u02B7\u02B2\u02B6\u02B6\u02BB\u02C1\u02B2\u02B3\u02BC\u02B9\u02B6(this);
	}

	// Token: 0x06001833 RID: 6195 RVA: 0x000126E7 File Offset: 0x000108E7
	public void \u02B8\u02C1\u02BC\u02BE\u02B4\u02B7\u02B7\u02B3\u02BC\u02B9\u02B6(SongEntry \u02B6\u02B2\u02B5\u02BB\u02C1\u02BB\u02BA\u02B4\u02BF\u02BA\u02B5)
	{
		this.<\u02B7\u02B4\u02B7\u02B5\u02C0\u02C1\u02BF\u02BD\u02C1\u02BF\u02B9>k__BackingField = \u02B6\u02B2\u02B5\u02BB\u02C1\u02BB\u02BA\u02B4\u02BF\u02BA\u02B5;
	}

	// Token: 0x06001835 RID: 6197 RVA: 0x0001284B File Offset: 0x00010A4B
	private void \u02BC\u02B7\u02BA\u02B9\u02BF\u02B6\u02B4\u02BA\u02BB\u02B5\u02BA()
	{
		Debug.Log("getPackageName");
		this.\u02BD\u02B7\u02B6\u02B4\u02BD\u02B8\u02B2\u02B6\u02B2\u02C0\u02B3.\u02B5\u02BD\u02BC\u02BF\u02BC\u02B6\u02B6\u02BA\u02BE\u02BF\u02BE(this);
	}

	// Token: 0x06001836 RID: 6198 RVA: 0x00012863 File Offset: 0x00010A63
	private void \u02B6\u02C0\u02BE\u02B4\u02BB\u02BD\u02BC\u02BB\u02C0\u02B8\u02B6()
	{
		Debug.Log("Untagged");
		this.\u02BD\u02B7\u02B6\u02B4\u02BD\u02B8\u02B2\u02B6\u02B2\u02C0\u02B3.\u02B3\u02B6\u02B8\u02C1\u02B5\u02C1\u02B3\u02B4\u02B8\u02C0\u02BA(this);
	}

	// Token: 0x06001837 RID: 6199 RVA: 0x00012738 File Offset: 0x00010938
	private void Start()
	{
		this.playButton.onClick.AddListener(new UnityAction(this.\u02BB\u02B8\u02C1\u02B5\u02BB\u02B9\u02BB\u02B9\u02C1\u02BD\u02BF));
		this.songNameText.text = this.\u02BA\u02B4\u02B8\u02BA\u02C1\u02B7\u02BF\u02BD\u02B5\u02BE\u02BA.Name.\u02C1\u02B4\u02BF\u02C1\u02BE\u02B9\u02B6\u02B7\u02B5\u02B7\u02B5;
	}

	// Token: 0x06001838 RID: 6200 RVA: 0x0001287B File Offset: 0x00010A7B
	private void \u02B8\u02B4\u02B9\u02B6\u02BA\u02C0\u02B8\u02C0\u02C0\u02B2\u02B4()
	{
		this.playButton.onClick.AddListener(new UnityAction(this.\u02BB\u02B8\u02C1\u02B5\u02BB\u02B9\u02BB\u02B9\u02C1\u02BD\u02BF));
		this.songNameText.text = this.\u02BA\u02B4\u02B8\u02BA\u02C1\u02B7\u02BF\u02BD\u02B5\u02BE\u02BA.Name.\u02B2\u02B2\u02B6\u02BA\u02C1\u02C1\u02BE\u02B2\u02B3\u02BF\u02BA();
	}

	// Token: 0x04001123 RID: 4387
	[SerializeField]
	private Button playButton;

	// Token: 0x04001124 RID: 4388
	[SerializeField]
	private TextMeshProUGUI songNameText;

	// Token: 0x04001125 RID: 4389
	public SongPlayerUI \u02BD\u02B7\u02B6\u02B4\u02BD\u02B8\u02B2\u02B6\u02B2\u02C0\u02B3;
}
