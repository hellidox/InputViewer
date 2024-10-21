using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x0200010B RID: 267
public class SongListAdder : MonoBehaviour
{
	// Token: 0x06000B53 RID: 2899 RVA: 0x0000BA3A File Offset: 0x00009C3A
	public bool \u02B6\u02C0\u02BC\u02BB\u02BD\u02C0\u02B3\u02B3\u02BA\u02BB\u02BE()
	{
		if (!this.\u02B3\u02B9\u02BF\u02BC\u02B6\u02BC\u02B6\u02BA\u02BA\u02B9\u02C1)
		{
			this.\u02B6\u02B5\u02BA\u02BF\u02C0\u02C0\u02C1\u02B9\u02B4\u02B9\u02B6();
		}
		return false;
	}

	// Token: 0x06000B54 RID: 2900 RVA: 0x0000BA3A File Offset: 0x00009C3A
	public bool \u02B7\u02C0\u02B7\u02B8\u02C0\u02B5\u02C0\u02C0\u02C1\u02BD\u02B3()
	{
		if (!this.\u02B3\u02B9\u02BF\u02BC\u02B6\u02BC\u02B6\u02BA\u02BA\u02B9\u02C1)
		{
			this.\u02B6\u02B5\u02BA\u02BF\u02C0\u02C0\u02C1\u02B9\u02B4\u02B9\u02B6();
		}
		return false;
	}

	// Token: 0x06000B55 RID: 2901 RVA: 0x00065134 File Offset: 0x00063334
	public void \u02B6\u02B5\u02BA\u02BF\u02C0\u02C0\u02C1\u02B9\u02B4\u02B9\u02B6()
	{
		if (!this.\u02B3\u02B9\u02BF\u02BC\u02B6\u02BC\u02B6\u02BA\u02BA\u02B9\u02C1)
		{
			this.\u02BF\u02B2\u02B6\u02BD\u02C0\u02B5\u02BF\u02B3\u02B3\u02BA\u02B8 = this.mainCanvas.GetComponent<CanvasScaler>().referenceResolution;
			this.\u02B7\u02BE\u02BF\u02B6\u02BA\u02B9\u02BE\u02C0\u02C1\u02BE\u02C0 = this.mainCanvas.GetComponent<RectTransform>();
			this.\u02B4\u02B7\u02B4\u02B2\u02B9\u02BB\u02B5\u02B3\u02B3\u02BE\u02B4 = this.\u02B2\u02B2\u02B2\u02BF\u02B6\u02C1\u02C0\u02B9\u02B5\u02BF\u02B5.GetComponent<LayoutElement>().minHeight;
			new List<GameObject>();
			for (int i = 0; i < this.\u02C1\u02B3\u02B2\u02BD\u02B7\u02BE\u02B8\u02C0\u02B8\u02B3\u02B2; i++)
			{
				global::UnityEngine.Object.Instantiate<GameObject>(this.\u02B2\u02B2\u02B2\u02BF\u02B6\u02C1\u02C0\u02B9\u02B5\u02BF\u02B5, this.\u02B6\u02BB\u02B8\u02B9\u02BE\u02B4\u02B7\u02BC\u02B3\u02B9\u02B9.transform);
			}
			this.\u02B3\u02B9\u02BF\u02BC\u02B6\u02BC\u02B6\u02BA\u02BA\u02B9\u02C1 = true;
		}
	}

	// Token: 0x06000B56 RID: 2902 RVA: 0x000651BC File Offset: 0x000633BC
	public void \u02BF\u02BD\u02BE\u02B7\u02C1\u02C0\u02BA\u02B3\u02BD\u02B8\u02B9()
	{
		List<SongSelectPanel> list = new List<SongSelectPanel>(this.\u02B6\u02BB\u02B8\u02B9\u02BE\u02B4\u02B7\u02BC\u02B3\u02B9\u02B9.transform.childCount);
		List<TextMeshProUGUI> list2 = new List<TextMeshProUGUI>(list.Count);
		List<TextMeshProUGUI> list3 = new List<TextMeshProUGUI>(list.Count);
		List<TextMeshProUGUI> list4 = new List<TextMeshProUGUI>(list.Count);
		List<TextMeshProUGUI> list5 = new List<TextMeshProUGUI>(list.Count);
		List<ScrollingText> list6 = new List<ScrollingText>(list.Count);
		List<ScrollingText> list7 = new List<ScrollingText>(list.Count);
		List<Image> list8 = new List<Image>(list.Count);
		List<Image> list9 = new List<Image>(list.Count);
		List<Image> list10 = new List<Image>(list.Count);
		float num = 1099f;
		foreach (object obj in this.\u02B6\u02BB\u02B8\u02B9\u02BE\u02B4\u02B7\u02BC\u02B3\u02B9\u02B9.transform)
		{
			Transform transform = (Transform)obj;
			if (transform.gameObject.activeSelf)
			{
				TextMeshProUGUI[] componentsInChildren = transform.gameObject.GetComponentsInChildren<TextMeshProUGUI>();
				Image[] componentsInChildren2 = transform.gameObject.GetComponentsInChildren<Image>();
				list.Add(transform.gameObject.GetComponentInChildren<SongSelectPanel>());
				list2.Add(componentsInChildren[0]);
				list6.Add(componentsInChildren[0].GetComponent<ScrollingText>());
				list3.Add(componentsInChildren[1]);
				list7.Add(componentsInChildren[1].GetComponent<ScrollingText>());
				list5.Add(componentsInChildren[4]);
				list4.Add(componentsInChildren[7]);
				list8.Add(componentsInChildren2[1]);
				list9.Add(componentsInChildren2[7]);
				list10.Add(componentsInChildren2[4]);
				if ((transform as RectTransform).anchoredPosition.y < num)
				{
					num = (transform as RectTransform).anchoredPosition.y;
				}
			}
		}
		this.\u02BD\u02B9\u02BC\u02C0\u02BE\u02BD\u02C0\u02B6\u02BD\u02B7\u02B3.\u02C0\u02B7\u02BA\u02BF\u02BB\u02B6\u02B6\u02B4\u02B6\u02BD\u02B6 = list.ToArray();
		this.\u02BD\u02B9\u02BC\u02C0\u02BE\u02BD\u02C0\u02B6\u02BD\u02B7\u02B3.\u02B5\u02B6\u02BF\u02C1\u02B5\u02BD\u02BB\u02B6\u02C1\u02B7\u02C1(list3.ToArray(), list4.ToArray(), list6.ToArray(), list7.ToArray(), list9.ToArray(), list5.ToArray(), list10.ToArray());
		this.\u02BD\u02B9\u02BC\u02C0\u02BE\u02BD\u02C0\u02B6\u02BD\u02B7\u02B3.\u02C1\u02BB\u02B8\u02B9\u02C1\u02BD\u02BF\u02BB\u02B4\u02BF\u02BD(list2.ToArray());
		this.\u02BD\u02B9\u02BC\u02C0\u02BE\u02BD\u02C0\u02B6\u02BD\u02B7\u02B3.\u02B7\u02BA\u02B3\u02B2\u02B7\u02B8\u02BB\u02BA\u02BE\u02C0\u02B2 = list8.ToArray();
		this.\u02BF\u02B2\u02BF\u02C0\u02BA\u02BB\u02B2\u02C0\u02B3\u02BA\u02BD.sizeDelta = new Vector2(this.\u02BF\u02B2\u02BF\u02C0\u02BA\u02BB\u02B2\u02C0\u02B3\u02BA\u02BD.sizeDelta.x, Mathf.Abs(num) + 718f);
	}

	// Token: 0x06000B57 RID: 2903 RVA: 0x0006541C File Offset: 0x0006361C
	public void \u02B7\u02C1\u02B3\u02B7\u02B4\u02B7\u02BA\u02B4\u02BF\u02BA\u02B7()
	{
		List<SongSelectPanel> list = new List<SongSelectPanel>(this.\u02B6\u02BB\u02B8\u02B9\u02BE\u02B4\u02B7\u02BC\u02B3\u02B9\u02B9.transform.childCount);
		List<TextMeshProUGUI> list2 = new List<TextMeshProUGUI>(list.Count);
		List<TextMeshProUGUI> list3 = new List<TextMeshProUGUI>(list.Count);
		List<TextMeshProUGUI> list4 = new List<TextMeshProUGUI>(list.Count);
		List<TextMeshProUGUI> list5 = new List<TextMeshProUGUI>(list.Count);
		List<ScrollingText> list6 = new List<ScrollingText>(list.Count);
		List<ScrollingText> list7 = new List<ScrollingText>(list.Count);
		List<Image> list8 = new List<Image>(list.Count);
		List<Image> list9 = new List<Image>(list.Count);
		List<Image> list10 = new List<Image>(list.Count);
		float num = 1782f;
		foreach (object obj in this.\u02B6\u02BB\u02B8\u02B9\u02BE\u02B4\u02B7\u02BC\u02B3\u02B9\u02B9.transform)
		{
			Transform transform = (Transform)obj;
			if (transform.gameObject.activeSelf)
			{
				TextMeshProUGUI[] componentsInChildren = transform.gameObject.GetComponentsInChildren<TextMeshProUGUI>();
				Image[] componentsInChildren2 = transform.gameObject.GetComponentsInChildren<Image>();
				list.Add(transform.gameObject.GetComponentInChildren<SongSelectPanel>());
				list2.Add(componentsInChildren[0]);
				list6.Add(componentsInChildren[0].GetComponent<ScrollingText>());
				list3.Add(componentsInChildren[1]);
				list7.Add(componentsInChildren[0].GetComponent<ScrollingText>());
				list5.Add(componentsInChildren[8]);
				list4.Add(componentsInChildren[8]);
				list8.Add(componentsInChildren2[1]);
				list9.Add(componentsInChildren2[6]);
				list10.Add(componentsInChildren2[6]);
				if ((transform as RectTransform).anchoredPosition.y < num)
				{
					num = (transform as RectTransform).anchoredPosition.y;
				}
			}
		}
		this.\u02BD\u02B9\u02BC\u02C0\u02BE\u02BD\u02C0\u02B6\u02BD\u02B7\u02B3.\u02C0\u02B7\u02BA\u02BF\u02BB\u02B6\u02B6\u02B4\u02B6\u02BD\u02B6 = list.ToArray();
		this.\u02BD\u02B9\u02BC\u02C0\u02BE\u02BD\u02C0\u02B6\u02BD\u02B7\u02B3.\u02B5\u02B6\u02BF\u02C1\u02B5\u02BD\u02BB\u02B6\u02C1\u02B7\u02C1(list3.ToArray(), list4.ToArray(), list6.ToArray(), list7.ToArray(), list9.ToArray(), list5.ToArray(), list10.ToArray());
		this.\u02BD\u02B9\u02BC\u02C0\u02BE\u02BD\u02C0\u02B6\u02BD\u02B7\u02B3.\u02C1\u02BB\u02B8\u02B9\u02C1\u02BD\u02BF\u02BB\u02B4\u02BF\u02BD(list2.ToArray());
		this.\u02BD\u02B9\u02BC\u02C0\u02BE\u02BD\u02C0\u02B6\u02BD\u02B7\u02B3.\u02B7\u02BA\u02B3\u02B2\u02B7\u02B8\u02BB\u02BA\u02BE\u02C0\u02B2 = list8.ToArray();
		this.\u02BF\u02B2\u02BF\u02C0\u02BA\u02BB\u02B2\u02C0\u02B3\u02BA\u02BD.sizeDelta = new Vector2(this.\u02BF\u02B2\u02BF\u02C0\u02BA\u02BB\u02B2\u02C0\u02B3\u02BA\u02BD.sizeDelta.x, Mathf.Abs(num) + 1219f);
	}

	// Token: 0x06000B59 RID: 2905 RVA: 0x0006567C File Offset: 0x0006387C
	public void \u02C1\u02BD\u02B6\u02B7\u02BA\u02BF\u02B5\u02BD\u02BD\u02B4\u02B7()
	{
		if (!this.\u02B3\u02B9\u02BF\u02BC\u02B6\u02BC\u02B6\u02BA\u02BA\u02B9\u02C1)
		{
			this.\u02BF\u02B2\u02B6\u02BD\u02C0\u02B5\u02BF\u02B3\u02B3\u02BA\u02B8 = this.mainCanvas.GetComponent<CanvasScaler>().referenceResolution;
			this.\u02B7\u02BE\u02BF\u02B6\u02BA\u02B9\u02BE\u02C0\u02C1\u02BE\u02C0 = this.mainCanvas.GetComponent<RectTransform>();
			this.\u02B4\u02B7\u02B4\u02B2\u02B9\u02BB\u02B5\u02B3\u02B3\u02BE\u02B4 = this.\u02B2\u02B2\u02B2\u02BF\u02B6\u02C1\u02C0\u02B9\u02B5\u02BF\u02B5.GetComponent<LayoutElement>().minHeight;
			new List<GameObject>();
			for (int i = 0; i < this.\u02C1\u02B3\u02B2\u02BD\u02B7\u02BE\u02B8\u02C0\u02B8\u02B3\u02B2; i++)
			{
				global::UnityEngine.Object.Instantiate<GameObject>(this.\u02B2\u02B2\u02B2\u02BF\u02B6\u02C1\u02C0\u02B9\u02B5\u02BF\u02B5, this.\u02B6\u02BB\u02B8\u02B9\u02BE\u02B4\u02B7\u02BC\u02B3\u02B9\u02B9.transform);
			}
			this.\u02B3\u02B9\u02BF\u02BC\u02B6\u02BC\u02B6\u02BA\u02BA\u02B9\u02C1 = false;
		}
	}

	// Token: 0x06000B5A RID: 2906 RVA: 0x0000BA5B File Offset: 0x00009C5B
	public bool \u02C0\u02B3\u02B8\u02B3\u02B7\u02BA\u02B7\u02BF\u02BB\u02BD\u02B7()
	{
		if (!this.\u02B3\u02B9\u02BF\u02BC\u02B6\u02BC\u02B6\u02BA\u02BA\u02B9\u02C1)
		{
			this.\u02B4\u02C0\u02C1\u02B5\u02BE\u02B4\u02B8\u02BC\u02B6\u02C0\u02B4();
		}
		return false;
	}

	// Token: 0x06000B5B RID: 2907 RVA: 0x00065704 File Offset: 0x00063904
	public void \u02C1\u02BE\u02B6\u02B4\u02C1\u02BE\u02B9\u02BC\u02BF\u02BA\u02B3()
	{
		List<SongSelectPanel> list = new List<SongSelectPanel>(this.\u02B6\u02BB\u02B8\u02B9\u02BE\u02B4\u02B7\u02BC\u02B3\u02B9\u02B9.transform.childCount);
		List<TextMeshProUGUI> list2 = new List<TextMeshProUGUI>(list.Count);
		List<TextMeshProUGUI> list3 = new List<TextMeshProUGUI>(list.Count);
		List<TextMeshProUGUI> list4 = new List<TextMeshProUGUI>(list.Count);
		List<TextMeshProUGUI> list5 = new List<TextMeshProUGUI>(list.Count);
		List<ScrollingText> list6 = new List<ScrollingText>(list.Count);
		List<ScrollingText> list7 = new List<ScrollingText>(list.Count);
		List<Image> list8 = new List<Image>(list.Count);
		List<Image> list9 = new List<Image>(list.Count);
		List<Image> list10 = new List<Image>(list.Count);
		float num = 527f;
		foreach (object obj in this.\u02B6\u02BB\u02B8\u02B9\u02BE\u02B4\u02B7\u02BC\u02B3\u02B9\u02B9.transform)
		{
			Transform transform = (Transform)obj;
			if (transform.gameObject.activeSelf)
			{
				TextMeshProUGUI[] componentsInChildren = transform.gameObject.GetComponentsInChildren<TextMeshProUGUI>();
				Image[] componentsInChildren2 = transform.gameObject.GetComponentsInChildren<Image>();
				list.Add(transform.gameObject.GetComponentInChildren<SongSelectPanel>());
				list2.Add(componentsInChildren[0]);
				list6.Add(componentsInChildren[1].GetComponent<ScrollingText>());
				list3.Add(componentsInChildren[0]);
				list7.Add(componentsInChildren[1].GetComponent<ScrollingText>());
				list5.Add(componentsInChildren[5]);
				list4.Add(componentsInChildren[8]);
				list8.Add(componentsInChildren2[1]);
				list9.Add(componentsInChildren2[8]);
				list10.Add(componentsInChildren2[1]);
				if ((transform as RectTransform).anchoredPosition.y < num)
				{
					num = (transform as RectTransform).anchoredPosition.y;
				}
			}
		}
		this.\u02BD\u02B9\u02BC\u02C0\u02BE\u02BD\u02C0\u02B6\u02BD\u02B7\u02B3.\u02C0\u02B7\u02BA\u02BF\u02BB\u02B6\u02B6\u02B4\u02B6\u02BD\u02B6 = list.ToArray();
		this.\u02BD\u02B9\u02BC\u02C0\u02BE\u02BD\u02C0\u02B6\u02BD\u02B7\u02B3.\u02B5\u02B6\u02BF\u02C1\u02B5\u02BD\u02BB\u02B6\u02C1\u02B7\u02C1(list3.ToArray(), list4.ToArray(), list6.ToArray(), list7.ToArray(), list9.ToArray(), list5.ToArray(), list10.ToArray());
		this.\u02BD\u02B9\u02BC\u02C0\u02BE\u02BD\u02C0\u02B6\u02BD\u02B7\u02B3.\u02C1\u02BB\u02B8\u02B9\u02C1\u02BD\u02BF\u02BB\u02B4\u02BF\u02BD(list2.ToArray());
		this.\u02BD\u02B9\u02BC\u02C0\u02BE\u02BD\u02C0\u02B6\u02BD\u02B7\u02B3.\u02B7\u02BA\u02B3\u02B2\u02B7\u02B8\u02BB\u02BA\u02BE\u02C0\u02B2 = list8.ToArray();
		this.\u02BF\u02B2\u02BF\u02C0\u02BA\u02BB\u02B2\u02C0\u02B3\u02BA\u02BD.sizeDelta = new Vector2(this.\u02BF\u02B2\u02BF\u02C0\u02BA\u02BB\u02B2\u02C0\u02B3\u02BA\u02BD.sizeDelta.x, Mathf.Abs(num) + 889f);
	}

	// Token: 0x06000B5C RID: 2908 RVA: 0x0000BA5B File Offset: 0x00009C5B
	public bool \u02B8\u02B2\u02BC\u02BE\u02BB\u02C0\u02B4\u02B9\u02C0\u02B6\u02BB()
	{
		if (!this.\u02B3\u02B9\u02BF\u02BC\u02B6\u02BC\u02B6\u02BA\u02BA\u02B9\u02C1)
		{
			this.\u02B4\u02C0\u02C1\u02B5\u02BE\u02B4\u02B8\u02BC\u02B6\u02C0\u02B4();
		}
		return false;
	}

	// Token: 0x06000B5D RID: 2909 RVA: 0x00065964 File Offset: 0x00063B64
	public void \u02B6\u02C1\u02BF\u02BB\u02BD\u02BE\u02B9\u02BE\u02B6\u02B4\u02BF()
	{
		if (!this.\u02B3\u02B9\u02BF\u02BC\u02B6\u02BC\u02B6\u02BA\u02BA\u02B9\u02C1)
		{
			this.\u02BF\u02B2\u02B6\u02BD\u02C0\u02B5\u02BF\u02B3\u02B3\u02BA\u02B8 = this.mainCanvas.GetComponent<CanvasScaler>().referenceResolution;
			this.\u02B7\u02BE\u02BF\u02B6\u02BA\u02B9\u02BE\u02C0\u02C1\u02BE\u02C0 = this.mainCanvas.GetComponent<RectTransform>();
			this.\u02B4\u02B7\u02B4\u02B2\u02B9\u02BB\u02B5\u02B3\u02B3\u02BE\u02B4 = this.\u02B2\u02B2\u02B2\u02BF\u02B6\u02C1\u02C0\u02B9\u02B5\u02BF\u02B5.GetComponent<LayoutElement>().minHeight;
			new List<GameObject>();
			for (int i = 0; i < this.\u02C1\u02B3\u02B2\u02BD\u02B7\u02BE\u02B8\u02C0\u02B8\u02B3\u02B2; i += 0)
			{
				global::UnityEngine.Object.Instantiate<GameObject>(this.\u02B2\u02B2\u02B2\u02BF\u02B6\u02C1\u02C0\u02B9\u02B5\u02BF\u02B5, this.\u02B6\u02BB\u02B8\u02B9\u02BE\u02B4\u02B7\u02BC\u02B3\u02B9\u02B9.transform);
			}
			this.\u02B3\u02B9\u02BF\u02BC\u02B6\u02BC\u02B6\u02BA\u02BA\u02B9\u02C1 = true;
		}
	}

	// Token: 0x06000B5E RID: 2910 RVA: 0x00065964 File Offset: 0x00063B64
	public void \u02B3\u02C0\u02B8\u02BA\u02BA\u02B6\u02B7\u02B8\u02B2\u02B3\u02B4()
	{
		if (!this.\u02B3\u02B9\u02BF\u02BC\u02B6\u02BC\u02B6\u02BA\u02BA\u02B9\u02C1)
		{
			this.\u02BF\u02B2\u02B6\u02BD\u02C0\u02B5\u02BF\u02B3\u02B3\u02BA\u02B8 = this.mainCanvas.GetComponent<CanvasScaler>().referenceResolution;
			this.\u02B7\u02BE\u02BF\u02B6\u02BA\u02B9\u02BE\u02C0\u02C1\u02BE\u02C0 = this.mainCanvas.GetComponent<RectTransform>();
			this.\u02B4\u02B7\u02B4\u02B2\u02B9\u02BB\u02B5\u02B3\u02B3\u02BE\u02B4 = this.\u02B2\u02B2\u02B2\u02BF\u02B6\u02C1\u02C0\u02B9\u02B5\u02BF\u02B5.GetComponent<LayoutElement>().minHeight;
			new List<GameObject>();
			for (int i = 0; i < this.\u02C1\u02B3\u02B2\u02BD\u02B7\u02BE\u02B8\u02C0\u02B8\u02B3\u02B2; i += 0)
			{
				global::UnityEngine.Object.Instantiate<GameObject>(this.\u02B2\u02B2\u02B2\u02BF\u02B6\u02C1\u02C0\u02B9\u02B5\u02BF\u02B5, this.\u02B6\u02BB\u02B8\u02B9\u02BE\u02B4\u02B7\u02BC\u02B3\u02B9\u02B9.transform);
			}
			this.\u02B3\u02B9\u02BF\u02BC\u02B6\u02BC\u02B6\u02BA\u02BA\u02B9\u02C1 = true;
		}
	}

	// Token: 0x06000B5F RID: 2911 RVA: 0x0000BA6C File Offset: 0x00009C6C
	public bool \u02B9\u02BF\u02B2\u02BC\u02B3\u02C0\u02B6\u02B3\u02B2\u02B3\u02C1()
	{
		if (!this.\u02B3\u02B9\u02BF\u02BC\u02B6\u02BC\u02B6\u02BA\u02BA\u02B9\u02C1)
		{
			this.\u02BC\u02B3\u02B9\u02BA\u02BA\u02C0\u02B9\u02B8\u02BB\u02BD\u02B6();
		}
		return false;
	}

	// Token: 0x06000B60 RID: 2912 RVA: 0x000659EC File Offset: 0x00063BEC
	public void \u02BA\u02B5\u02B3\u02BD\u02C1\u02BA\u02C1\u02B8\u02BB\u02B3\u02BD()
	{
		List<SongSelectPanel> list = new List<SongSelectPanel>(this.\u02B6\u02BB\u02B8\u02B9\u02BE\u02B4\u02B7\u02BC\u02B3\u02B9\u02B9.transform.childCount);
		List<TextMeshProUGUI> list2 = new List<TextMeshProUGUI>(list.Count);
		List<TextMeshProUGUI> list3 = new List<TextMeshProUGUI>(list.Count);
		List<TextMeshProUGUI> list4 = new List<TextMeshProUGUI>(list.Count);
		List<TextMeshProUGUI> list5 = new List<TextMeshProUGUI>(list.Count);
		List<ScrollingText> list6 = new List<ScrollingText>(list.Count);
		List<ScrollingText> list7 = new List<ScrollingText>(list.Count);
		List<Image> list8 = new List<Image>(list.Count);
		List<Image> list9 = new List<Image>(list.Count);
		List<Image> list10 = new List<Image>(list.Count);
		float num = -789f;
		foreach (object obj in this.\u02B6\u02BB\u02B8\u02B9\u02BE\u02B4\u02B7\u02BC\u02B3\u02B9\u02B9.transform)
		{
			Transform transform = (Transform)obj;
			if (transform.gameObject.activeSelf)
			{
				TextMeshProUGUI[] componentsInChildren = transform.gameObject.GetComponentsInChildren<TextMeshProUGUI>();
				Image[] componentsInChildren2 = transform.gameObject.GetComponentsInChildren<Image>();
				list.Add(transform.gameObject.GetComponentInChildren<SongSelectPanel>());
				list2.Add(componentsInChildren[0]);
				list6.Add(componentsInChildren[0].GetComponent<ScrollingText>());
				list3.Add(componentsInChildren[1]);
				list7.Add(componentsInChildren[1].GetComponent<ScrollingText>());
				list5.Add(componentsInChildren[2]);
				list4.Add(componentsInChildren[3]);
				list8.Add(componentsInChildren2[0]);
				list9.Add(componentsInChildren2[2]);
				list10.Add(componentsInChildren2[3]);
				if ((transform as RectTransform).anchoredPosition.y < num)
				{
					num = (transform as RectTransform).anchoredPosition.y;
				}
			}
		}
		this.\u02BD\u02B9\u02BC\u02C0\u02BE\u02BD\u02C0\u02B6\u02BD\u02B7\u02B3.\u02C0\u02B7\u02BA\u02BF\u02BB\u02B6\u02B6\u02B4\u02B6\u02BD\u02B6 = list.ToArray();
		this.\u02BD\u02B9\u02BC\u02C0\u02BE\u02BD\u02C0\u02B6\u02BD\u02B7\u02B3.\u02B5\u02B6\u02BF\u02C1\u02B5\u02BD\u02BB\u02B6\u02C1\u02B7\u02C1(list3.ToArray(), list4.ToArray(), list6.ToArray(), list7.ToArray(), list9.ToArray(), list5.ToArray(), list10.ToArray());
		this.\u02BD\u02B9\u02BC\u02C0\u02BE\u02BD\u02C0\u02B6\u02BD\u02B7\u02B3.\u02C1\u02BB\u02B8\u02B9\u02C1\u02BD\u02BF\u02BB\u02B4\u02BF\u02BD(list2.ToArray());
		this.\u02BD\u02B9\u02BC\u02C0\u02BE\u02BD\u02C0\u02B6\u02BD\u02B7\u02B3.\u02B7\u02BA\u02B3\u02B2\u02B7\u02B8\u02BB\u02BA\u02BE\u02C0\u02B2 = list8.ToArray();
		this.\u02BF\u02B2\u02BF\u02C0\u02BA\u02BB\u02B2\u02C0\u02B3\u02BA\u02BD.sizeDelta = new Vector2(this.\u02BF\u02B2\u02BF\u02C0\u02BA\u02BB\u02B2\u02C0\u02B3\u02BA\u02BD.sizeDelta.x, Mathf.Abs(num) + 11f);
	}

	// Token: 0x06000B61 RID: 2913 RVA: 0x00065C4C File Offset: 0x00063E4C
	public void \u02BC\u02B3\u02B9\u02BA\u02BA\u02C0\u02B9\u02B8\u02BB\u02BD\u02B6()
	{
		if (!this.\u02B3\u02B9\u02BF\u02BC\u02B6\u02BC\u02B6\u02BA\u02BA\u02B9\u02C1)
		{
			this.\u02BF\u02B2\u02B6\u02BD\u02C0\u02B5\u02BF\u02B3\u02B3\u02BA\u02B8 = this.mainCanvas.GetComponent<CanvasScaler>().referenceResolution;
			this.\u02B7\u02BE\u02BF\u02B6\u02BA\u02B9\u02BE\u02C0\u02C1\u02BE\u02C0 = this.mainCanvas.GetComponent<RectTransform>();
			this.\u02B4\u02B7\u02B4\u02B2\u02B9\u02BB\u02B5\u02B3\u02B3\u02BE\u02B4 = this.\u02B2\u02B2\u02B2\u02BF\u02B6\u02C1\u02C0\u02B9\u02B5\u02BF\u02B5.GetComponent<LayoutElement>().minHeight;
			new List<GameObject>();
			for (int i = 1; i < this.\u02C1\u02B3\u02B2\u02BD\u02B7\u02BE\u02B8\u02C0\u02B8\u02B3\u02B2; i += 0)
			{
				global::UnityEngine.Object.Instantiate<GameObject>(this.\u02B2\u02B2\u02B2\u02BF\u02B6\u02C1\u02C0\u02B9\u02B5\u02BF\u02B5, this.\u02B6\u02BB\u02B8\u02B9\u02BE\u02B4\u02B7\u02BC\u02B3\u02B9\u02B9.transform);
			}
			this.\u02B3\u02B9\u02BF\u02BC\u02B6\u02BC\u02B6\u02BA\u02BA\u02B9\u02C1 = true;
		}
	}

	// Token: 0x06000B62 RID: 2914 RVA: 0x00065CD4 File Offset: 0x00063ED4
	public void \u02B8\u02BC\u02C0\u02C0\u02B3\u02BF\u02B8\u02B8\u02BB\u02B3\u02BA()
	{
		List<SongSelectPanel> list = new List<SongSelectPanel>(this.\u02B6\u02BB\u02B8\u02B9\u02BE\u02B4\u02B7\u02BC\u02B3\u02B9\u02B9.transform.childCount);
		List<TextMeshProUGUI> list2 = new List<TextMeshProUGUI>(list.Count);
		List<TextMeshProUGUI> list3 = new List<TextMeshProUGUI>(list.Count);
		List<TextMeshProUGUI> list4 = new List<TextMeshProUGUI>(list.Count);
		List<TextMeshProUGUI> list5 = new List<TextMeshProUGUI>(list.Count);
		List<ScrollingText> list6 = new List<ScrollingText>(list.Count);
		List<ScrollingText> list7 = new List<ScrollingText>(list.Count);
		List<Image> list8 = new List<Image>(list.Count);
		List<Image> list9 = new List<Image>(list.Count);
		List<Image> list10 = new List<Image>(list.Count);
		float num = 1189f;
		foreach (object obj in this.\u02B6\u02BB\u02B8\u02B9\u02BE\u02B4\u02B7\u02BC\u02B3\u02B9\u02B9.transform)
		{
			Transform transform = (Transform)obj;
			if (transform.gameObject.activeSelf)
			{
				TextMeshProUGUI[] componentsInChildren = transform.gameObject.GetComponentsInChildren<TextMeshProUGUI>();
				Image[] componentsInChildren2 = transform.gameObject.GetComponentsInChildren<Image>();
				list.Add(transform.gameObject.GetComponentInChildren<SongSelectPanel>());
				list2.Add(componentsInChildren[1]);
				list6.Add(componentsInChildren[0].GetComponent<ScrollingText>());
				list3.Add(componentsInChildren[1]);
				list7.Add(componentsInChildren[0].GetComponent<ScrollingText>());
				list5.Add(componentsInChildren[2]);
				list4.Add(componentsInChildren[5]);
				list8.Add(componentsInChildren2[1]);
				list9.Add(componentsInChildren2[0]);
				list10.Add(componentsInChildren2[7]);
				if ((transform as RectTransform).anchoredPosition.y < num)
				{
					num = (transform as RectTransform).anchoredPosition.y;
				}
			}
		}
		this.\u02BD\u02B9\u02BC\u02C0\u02BE\u02BD\u02C0\u02B6\u02BD\u02B7\u02B3.\u02C0\u02B7\u02BA\u02BF\u02BB\u02B6\u02B6\u02B4\u02B6\u02BD\u02B6 = list.ToArray();
		this.\u02BD\u02B9\u02BC\u02C0\u02BE\u02BD\u02C0\u02B6\u02BD\u02B7\u02B3.\u02B5\u02B6\u02BF\u02C1\u02B5\u02BD\u02BB\u02B6\u02C1\u02B7\u02C1(list3.ToArray(), list4.ToArray(), list6.ToArray(), list7.ToArray(), list9.ToArray(), list5.ToArray(), list10.ToArray());
		this.\u02BD\u02B9\u02BC\u02C0\u02BE\u02BD\u02C0\u02B6\u02BD\u02B7\u02B3.\u02C1\u02BB\u02B8\u02B9\u02C1\u02BD\u02BF\u02BB\u02B4\u02BF\u02BD(list2.ToArray());
		this.\u02BD\u02B9\u02BC\u02C0\u02BE\u02BD\u02C0\u02B6\u02BD\u02B7\u02B3.\u02B7\u02BA\u02B3\u02B2\u02B7\u02B8\u02BB\u02BA\u02BE\u02C0\u02B2 = list8.ToArray();
		this.\u02BF\u02B2\u02BF\u02C0\u02BA\u02BB\u02B2\u02C0\u02B3\u02BA\u02BD.sizeDelta = new Vector2(this.\u02BF\u02B2\u02BF\u02C0\u02BA\u02BB\u02B2\u02C0\u02B3\u02BA\u02BD.sizeDelta.x, Mathf.Abs(num) + 647f);
	}

	// Token: 0x06000B63 RID: 2915 RVA: 0x0000BA7D File Offset: 0x00009C7D
	public bool \u02BA\u02C0\u02B9\u02B5\u02BA\u02BE\u02B8\u02C0\u02BA\u02BC\u02B5()
	{
		if (!this.\u02B3\u02B9\u02BF\u02BC\u02B6\u02BC\u02B6\u02BA\u02BA\u02B9\u02C1)
		{
			this.\u02B4\u02C0\u02C1\u02B5\u02BE\u02B4\u02B8\u02BC\u02B6\u02C0\u02B4();
		}
		return true;
	}

	// Token: 0x06000B64 RID: 2916 RVA: 0x00065964 File Offset: 0x00063B64
	public void \u02C0\u02B8\u02C0\u02B2\u02B5\u02BB\u02BF\u02B9\u02B9\u02C1\u02BB()
	{
		if (!this.\u02B3\u02B9\u02BF\u02BC\u02B6\u02BC\u02B6\u02BA\u02BA\u02B9\u02C1)
		{
			this.\u02BF\u02B2\u02B6\u02BD\u02C0\u02B5\u02BF\u02B3\u02B3\u02BA\u02B8 = this.mainCanvas.GetComponent<CanvasScaler>().referenceResolution;
			this.\u02B7\u02BE\u02BF\u02B6\u02BA\u02B9\u02BE\u02C0\u02C1\u02BE\u02C0 = this.mainCanvas.GetComponent<RectTransform>();
			this.\u02B4\u02B7\u02B4\u02B2\u02B9\u02BB\u02B5\u02B3\u02B3\u02BE\u02B4 = this.\u02B2\u02B2\u02B2\u02BF\u02B6\u02C1\u02C0\u02B9\u02B5\u02BF\u02B5.GetComponent<LayoutElement>().minHeight;
			new List<GameObject>();
			for (int i = 0; i < this.\u02C1\u02B3\u02B2\u02BD\u02B7\u02BE\u02B8\u02C0\u02B8\u02B3\u02B2; i += 0)
			{
				global::UnityEngine.Object.Instantiate<GameObject>(this.\u02B2\u02B2\u02B2\u02BF\u02B6\u02C1\u02C0\u02B9\u02B5\u02BF\u02B5, this.\u02B6\u02BB\u02B8\u02B9\u02BE\u02B4\u02B7\u02BC\u02B3\u02B9\u02B9.transform);
			}
			this.\u02B3\u02B9\u02BF\u02BC\u02B6\u02BC\u02B6\u02BA\u02BA\u02B9\u02C1 = true;
		}
	}

	// Token: 0x06000B65 RID: 2917 RVA: 0x00065F34 File Offset: 0x00064134
	public void \u02B4\u02C0\u02C1\u02B5\u02BE\u02B4\u02B8\u02BC\u02B6\u02C0\u02B4()
	{
		if (!this.\u02B3\u02B9\u02BF\u02BC\u02B6\u02BC\u02B6\u02BA\u02BA\u02B9\u02C1)
		{
			this.\u02BF\u02B2\u02B6\u02BD\u02C0\u02B5\u02BF\u02B3\u02B3\u02BA\u02B8 = this.mainCanvas.GetComponent<CanvasScaler>().referenceResolution;
			this.\u02B7\u02BE\u02BF\u02B6\u02BA\u02B9\u02BE\u02C0\u02C1\u02BE\u02C0 = this.mainCanvas.GetComponent<RectTransform>();
			this.\u02B4\u02B7\u02B4\u02B2\u02B9\u02BB\u02B5\u02B3\u02B3\u02BE\u02B4 = this.\u02B2\u02B2\u02B2\u02BF\u02B6\u02C1\u02C0\u02B9\u02B5\u02BF\u02B5.GetComponent<LayoutElement>().minHeight;
			new List<GameObject>();
			for (int i = 1; i < this.\u02C1\u02B3\u02B2\u02BD\u02B7\u02BE\u02B8\u02C0\u02B8\u02B3\u02B2; i++)
			{
				global::UnityEngine.Object.Instantiate<GameObject>(this.\u02B2\u02B2\u02B2\u02BF\u02B6\u02C1\u02C0\u02B9\u02B5\u02BF\u02B5, this.\u02B6\u02BB\u02B8\u02B9\u02BE\u02B4\u02B7\u02BC\u02B3\u02B9\u02B9.transform);
			}
			this.\u02B3\u02B9\u02BF\u02BC\u02B6\u02BC\u02B6\u02BA\u02BA\u02B9\u02C1 = false;
		}
	}

	// Token: 0x06000B66 RID: 2918 RVA: 0x00065FBC File Offset: 0x000641BC
	public void \u02BD\u02BF\u02C0\u02B2\u02BF\u02BD\u02B3\u02B6\u02B3\u02B5\u02BE()
	{
		List<SongSelectPanel> list = new List<SongSelectPanel>(this.\u02B6\u02BB\u02B8\u02B9\u02BE\u02B4\u02B7\u02BC\u02B3\u02B9\u02B9.transform.childCount);
		List<TextMeshProUGUI> list2 = new List<TextMeshProUGUI>(list.Count);
		List<TextMeshProUGUI> list3 = new List<TextMeshProUGUI>(list.Count);
		List<TextMeshProUGUI> list4 = new List<TextMeshProUGUI>(list.Count);
		List<TextMeshProUGUI> list5 = new List<TextMeshProUGUI>(list.Count);
		List<ScrollingText> list6 = new List<ScrollingText>(list.Count);
		List<ScrollingText> list7 = new List<ScrollingText>(list.Count);
		List<Image> list8 = new List<Image>(list.Count);
		List<Image> list9 = new List<Image>(list.Count);
		List<Image> list10 = new List<Image>(list.Count);
		float num = 490f;
		foreach (object obj in this.\u02B6\u02BB\u02B8\u02B9\u02BE\u02B4\u02B7\u02BC\u02B3\u02B9\u02B9.transform)
		{
			Transform transform = (Transform)obj;
			if (transform.gameObject.activeSelf)
			{
				TextMeshProUGUI[] componentsInChildren = transform.gameObject.GetComponentsInChildren<TextMeshProUGUI>();
				Image[] componentsInChildren2 = transform.gameObject.GetComponentsInChildren<Image>();
				list.Add(transform.gameObject.GetComponentInChildren<SongSelectPanel>());
				list2.Add(componentsInChildren[1]);
				list6.Add(componentsInChildren[0].GetComponent<ScrollingText>());
				list3.Add(componentsInChildren[1]);
				list7.Add(componentsInChildren[0].GetComponent<ScrollingText>());
				list5.Add(componentsInChildren[4]);
				list4.Add(componentsInChildren[1]);
				list8.Add(componentsInChildren2[0]);
				list9.Add(componentsInChildren2[4]);
				list10.Add(componentsInChildren2[7]);
				if ((transform as RectTransform).anchoredPosition.y < num)
				{
					num = (transform as RectTransform).anchoredPosition.y;
				}
			}
		}
		this.\u02BD\u02B9\u02BC\u02C0\u02BE\u02BD\u02C0\u02B6\u02BD\u02B7\u02B3.\u02C0\u02B7\u02BA\u02BF\u02BB\u02B6\u02B6\u02B4\u02B6\u02BD\u02B6 = list.ToArray();
		this.\u02BD\u02B9\u02BC\u02C0\u02BE\u02BD\u02C0\u02B6\u02BD\u02B7\u02B3.\u02B5\u02B6\u02BF\u02C1\u02B5\u02BD\u02BB\u02B6\u02C1\u02B7\u02C1(list3.ToArray(), list4.ToArray(), list6.ToArray(), list7.ToArray(), list9.ToArray(), list5.ToArray(), list10.ToArray());
		this.\u02BD\u02B9\u02BC\u02C0\u02BE\u02BD\u02C0\u02B6\u02BD\u02B7\u02B3.\u02C1\u02BB\u02B8\u02B9\u02C1\u02BD\u02BF\u02BB\u02B4\u02BF\u02BD(list2.ToArray());
		this.\u02BD\u02B9\u02BC\u02C0\u02BE\u02BD\u02C0\u02B6\u02BD\u02B7\u02B3.\u02B7\u02BA\u02B3\u02B2\u02B7\u02B8\u02BB\u02BA\u02BE\u02C0\u02B2 = list8.ToArray();
		this.\u02BF\u02B2\u02BF\u02C0\u02BA\u02BB\u02B2\u02C0\u02B3\u02BA\u02BD.sizeDelta = new Vector2(this.\u02BF\u02B2\u02BF\u02C0\u02BA\u02BB\u02B2\u02C0\u02B3\u02BA\u02BD.sizeDelta.x, Mathf.Abs(num) + 1552f);
	}

	// Token: 0x06000B67 RID: 2919 RVA: 0x0006621C File Offset: 0x0006441C
	public void \u02B8\u02BE\u02B6\u02B3\u02B5\u02B7\u02BF\u02B2\u02BF\u02BC\u02BC()
	{
		List<SongSelectPanel> list = new List<SongSelectPanel>(this.\u02B6\u02BB\u02B8\u02B9\u02BE\u02B4\u02B7\u02BC\u02B3\u02B9\u02B9.transform.childCount);
		List<TextMeshProUGUI> list2 = new List<TextMeshProUGUI>(list.Count);
		List<TextMeshProUGUI> list3 = new List<TextMeshProUGUI>(list.Count);
		List<TextMeshProUGUI> list4 = new List<TextMeshProUGUI>(list.Count);
		List<TextMeshProUGUI> list5 = new List<TextMeshProUGUI>(list.Count);
		List<ScrollingText> list6 = new List<ScrollingText>(list.Count);
		List<ScrollingText> list7 = new List<ScrollingText>(list.Count);
		List<Image> list8 = new List<Image>(list.Count);
		List<Image> list9 = new List<Image>(list.Count);
		List<Image> list10 = new List<Image>(list.Count);
		float num = 1217f;
		foreach (object obj in this.\u02B6\u02BB\u02B8\u02B9\u02BE\u02B4\u02B7\u02BC\u02B3\u02B9\u02B9.transform)
		{
			Transform transform = (Transform)obj;
			if (transform.gameObject.activeSelf)
			{
				TextMeshProUGUI[] componentsInChildren = transform.gameObject.GetComponentsInChildren<TextMeshProUGUI>();
				Image[] componentsInChildren2 = transform.gameObject.GetComponentsInChildren<Image>();
				list.Add(transform.gameObject.GetComponentInChildren<SongSelectPanel>());
				list2.Add(componentsInChildren[0]);
				list6.Add(componentsInChildren[1].GetComponent<ScrollingText>());
				list3.Add(componentsInChildren[0]);
				list7.Add(componentsInChildren[0].GetComponent<ScrollingText>());
				list5.Add(componentsInChildren[2]);
				list4.Add(componentsInChildren[2]);
				list8.Add(componentsInChildren2[1]);
				list9.Add(componentsInChildren2[3]);
				list10.Add(componentsInChildren2[3]);
				if ((transform as RectTransform).anchoredPosition.y < num)
				{
					num = (transform as RectTransform).anchoredPosition.y;
				}
			}
		}
		this.\u02BD\u02B9\u02BC\u02C0\u02BE\u02BD\u02C0\u02B6\u02BD\u02B7\u02B3.\u02C0\u02B7\u02BA\u02BF\u02BB\u02B6\u02B6\u02B4\u02B6\u02BD\u02B6 = list.ToArray();
		this.\u02BD\u02B9\u02BC\u02C0\u02BE\u02BD\u02C0\u02B6\u02BD\u02B7\u02B3.\u02B5\u02B6\u02BF\u02C1\u02B5\u02BD\u02BB\u02B6\u02C1\u02B7\u02C1(list3.ToArray(), list4.ToArray(), list6.ToArray(), list7.ToArray(), list9.ToArray(), list5.ToArray(), list10.ToArray());
		this.\u02BD\u02B9\u02BC\u02C0\u02BE\u02BD\u02C0\u02B6\u02BD\u02B7\u02B3.\u02C1\u02BB\u02B8\u02B9\u02C1\u02BD\u02BF\u02BB\u02B4\u02BF\u02BD(list2.ToArray());
		this.\u02BD\u02B9\u02BC\u02C0\u02BE\u02BD\u02C0\u02B6\u02BD\u02B7\u02B3.\u02B7\u02BA\u02B3\u02B2\u02B7\u02B8\u02BB\u02BA\u02BE\u02C0\u02B2 = list8.ToArray();
		this.\u02BF\u02B2\u02BF\u02C0\u02BA\u02BB\u02B2\u02C0\u02B3\u02BA\u02BD.sizeDelta = new Vector2(this.\u02BF\u02B2\u02BF\u02C0\u02BA\u02BB\u02B2\u02C0\u02B3\u02BA\u02BD.sizeDelta.x, Mathf.Abs(num) + 714f);
	}

	// Token: 0x0400082A RID: 2090
	public GameObject \u02B2\u02B2\u02B2\u02BF\u02B6\u02C1\u02C0\u02B9\u02B5\u02BF\u02B5;

	// Token: 0x0400082B RID: 2091
	public GameObject \u02B6\u02BB\u02B8\u02B9\u02BE\u02B4\u02B7\u02BC\u02B3\u02B9\u02B9;

	// Token: 0x0400082C RID: 2092
	public SongSelect \u02BD\u02B9\u02BC\u02C0\u02BE\u02BD\u02C0\u02B6\u02BD\u02B7\u02B3;

	// Token: 0x0400082D RID: 2093
	public int \u02C1\u02B3\u02B2\u02BD\u02B7\u02BE\u02B8\u02C0\u02B8\u02B3\u02B2 = 15;

	// Token: 0x0400082E RID: 2094
	private RectTransform \u02B7\u02BE\u02BF\u02B6\u02BA\u02B9\u02BE\u02C0\u02C1\u02BE\u02C0;

	// Token: 0x0400082F RID: 2095
	private float \u02B4\u02B7\u02B4\u02B2\u02B9\u02BB\u02B5\u02B3\u02B3\u02BE\u02B4;

	// Token: 0x04000830 RID: 2096
	private Vector2 \u02BF\u02B2\u02B6\u02BD\u02C0\u02B5\u02BF\u02B3\u02B3\u02BA\u02B8;

	// Token: 0x04000831 RID: 2097
	private bool \u02B3\u02B9\u02BF\u02BC\u02B6\u02BC\u02B6\u02BA\u02BA\u02B9\u02C1;

	// Token: 0x04000832 RID: 2098
	public List<GameObject> \u02B5\u02B5\u02BB\u02BC\u02B2\u02BD\u02B4\u02BD\u02B7\u02B5\u02B2;

	// Token: 0x04000833 RID: 2099
	public RectTransform \u02BD\u02B5\u02BC\u02BE\u02B8\u02B2\u02B6\u02B4\u02B8\u02B3\u02B2;

	// Token: 0x04000834 RID: 2100
	public RectTransform \u02BF\u02B2\u02BF\u02C0\u02BA\u02BB\u02B2\u02C0\u02B3\u02BA\u02BD;

	// Token: 0x04000835 RID: 2101
	[SerializeField]
	private Canvas mainCanvas;
}
