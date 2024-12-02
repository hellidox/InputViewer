using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SongListAdder : MonoBehaviour
{
	public bool \u02B6\u02C0\u02BC\u02BB\u02BD\u02C0\u02B3\u02B3\u02BA\u02BB\u02BE()
	{
		if (!this.\u02B3\u02B9\u02BF\u02BC\u02B6\u02BC\u02B6\u02BA\u02BA\u02B9\u02C1)
		{
			this.\u02B6\u02B5\u02BA\u02BF\u02C0\u02C0\u02C1\u02B9\u02B4\u02B9\u02B6();
		}
		return false;
	}

	public bool \u02B7\u02C0\u02B7\u02B8\u02C0\u02B5\u02C0\u02C0\u02C1\u02BD\u02B3()
	{
		if (!this.\u02B3\u02B9\u02BF\u02BC\u02B6\u02BC\u02B6\u02BA\u02BA\u02B9\u02C1)
		{
			this.\u02B6\u02B5\u02BA\u02BF\u02C0\u02C0\u02C1\u02B9\u02B4\u02B9\u02B6();
		}
		return false;
	}

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

	public bool \u02C0\u02B3\u02B8\u02B3\u02B7\u02BA\u02B7\u02BF\u02BB\u02BD\u02B7()
	{
		if (!this.\u02B3\u02B9\u02BF\u02BC\u02B6\u02BC\u02B6\u02BA\u02BA\u02B9\u02C1)
		{
			this.\u02B4\u02C0\u02C1\u02B5\u02BE\u02B4\u02B8\u02BC\u02B6\u02C0\u02B4();
		}
		return false;
	}

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

	public bool \u02B8\u02B2\u02BC\u02BE\u02BB\u02C0\u02B4\u02B9\u02C0\u02B6\u02BB()
	{
		if (!this.\u02B3\u02B9\u02BF\u02BC\u02B6\u02BC\u02B6\u02BA\u02BA\u02B9\u02C1)
		{
			this.\u02B4\u02C0\u02C1\u02B5\u02BE\u02B4\u02B8\u02BC\u02B6\u02C0\u02B4();
		}
		return false;
	}

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

	public bool \u02B9\u02BF\u02B2\u02BC\u02B3\u02C0\u02B6\u02B3\u02B2\u02B3\u02C1()
	{
		if (!this.\u02B3\u02B9\u02BF\u02BC\u02B6\u02BC\u02B6\u02BA\u02BA\u02B9\u02C1)
		{
			this.\u02BC\u02B3\u02B9\u02BA\u02BA\u02C0\u02B9\u02B8\u02BB\u02BD\u02B6();
		}
		return false;
	}

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

	public bool \u02BA\u02C0\u02B9\u02B5\u02BA\u02BE\u02B8\u02C0\u02BA\u02BC\u02B5()
	{
		if (!this.\u02B3\u02B9\u02BF\u02BC\u02B6\u02BC\u02B6\u02BA\u02BA\u02B9\u02C1)
		{
			this.\u02B4\u02C0\u02C1\u02B5\u02BE\u02B4\u02B8\u02BC\u02B6\u02C0\u02B4();
		}
		return true;
	}

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

	public GameObject \u02B2\u02B2\u02B2\u02BF\u02B6\u02C1\u02C0\u02B9\u02B5\u02BF\u02B5;

	public GameObject \u02B6\u02BB\u02B8\u02B9\u02BE\u02B4\u02B7\u02BC\u02B3\u02B9\u02B9;

	public SongSelect \u02BD\u02B9\u02BC\u02C0\u02BE\u02BD\u02C0\u02B6\u02BD\u02B7\u02B3;

	public int \u02C1\u02B3\u02B2\u02BD\u02B7\u02BE\u02B8\u02C0\u02B8\u02B3\u02B2 = 15;

	private RectTransform \u02B7\u02BE\u02BF\u02B6\u02BA\u02B9\u02BE\u02C0\u02C1\u02BE\u02C0;

	private float \u02B4\u02B7\u02B4\u02B2\u02B9\u02BB\u02B5\u02B3\u02B3\u02BE\u02B4;

	private Vector2 \u02BF\u02B2\u02B6\u02BD\u02C0\u02B5\u02BF\u02B3\u02B3\u02BA\u02B8;

	private bool \u02B3\u02B9\u02BF\u02BC\u02B6\u02BC\u02B6\u02BA\u02BA\u02B9\u02C1;

	public List<GameObject> \u02B5\u02B5\u02BB\u02BC\u02B2\u02BD\u02B4\u02BD\u02B7\u02B5\u02B2;

	public RectTransform \u02BD\u02B5\u02BC\u02BE\u02B8\u02B2\u02B6\u02B4\u02B8\u02B3\u02B2;

	public RectTransform \u02BF\u02B2\u02BF\u02C0\u02BA\u02BB\u02B2\u02C0\u02B3\u02BA\u02BD;

	[SerializeField]
	private Canvas mainCanvas;
}
