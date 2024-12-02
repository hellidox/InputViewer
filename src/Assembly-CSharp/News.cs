using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using TMPro;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class News : MonoBehaviour
{
	private void \u02C1\u02C1\u02BB\u02B3\u02B4\u02B8\u02B2\u02BA\u02BE\u02B7\u02B7()
	{
		foreach (ExclamationWiggle exclamationWiggle in this.\u02BB\u02BE\u02BF\u02B3\u02C0\u02B7\u02B2\u02BA\u02C1\u02B3\u02B5)
		{
			exclamationWiggle.gameObject.SetActive(false);
		}
	}

	public static void \u02B5\u02B5\u02B8\u02C1\u02B5\u02B8\u02BE\u02BD\u02BA\u02BB\u02B3()
	{
		PlayerPrefs.SetString("All HOPO's", DateTime.UtcNow.ToString());
		global::UnityEngine.Object.FindObjectOfType<News>().\u02B4\u02B6\u02BE\u02B7\u02BF\u02BF\u02BA\u02B4\u02B7\u02B8\u02B6();
	}

	private void \u02B2\u02B2\u02BF\u02B2\u02BC\u02B6\u02BA\u02B8\u02BF\u02B7\u02BA(NewsCollection \u02C0\u02B7\u02B8\u02BA\u02B5\u02BF\u02C0\u02B9\u02BB\u02BE\u02BD)
	{
		if (\u02C0\u02B7\u02B8\u02BA\u02B5\u02BF\u02C0\u02B9\u02BB\u02BE\u02BD.news.Length == 0)
		{
			global::UnityEngine.Object.Destroy(this.\u02B4\u02C1\u02B7\u02B8\u02B6\u02B2\u02BC\u02BD\u02BF\u02BA\u02BF);
			return;
		}
		this.\u02B3\u02BC\u02BA\u02B8\u02B2\u02BE\u02B9\u02BE\u02B7\u02B8\u02B8.Add(this.\u02B4\u02C1\u02B7\u02B8\u02B6\u02B2\u02BC\u02BD\u02BF\u02BA\u02BF);
		if (\u02C0\u02B7\u02B8\u02BA\u02B5\u02BF\u02C0\u02B9\u02BB\u02BE\u02BD.news.Length > 0)
		{
			for (int i = 0; i < \u02C0\u02B7\u02B8\u02BA\u02B5\u02BF\u02C0\u02B9\u02BB\u02BE\u02BD.news.Length; i++)
			{
				GameObject gameObject = global::UnityEngine.Object.Instantiate<GameObject>(this.\u02B4\u02C1\u02B7\u02B8\u02B6\u02B2\u02BC\u02BD\u02BF\u02BA\u02BF, this.\u02B4\u02C1\u02B7\u02B8\u02B6\u02B2\u02BC\u02BD\u02BF\u02BA\u02BF.transform.parent);
				this.\u02B3\u02BC\u02BA\u02B8\u02B2\u02BE\u02B9\u02BE\u02B7\u02B8\u02B8.Add(gameObject);
			}
		}
		float num = 1621f;
		DateTime dateTime = News.\u02B4\u02BC\u02B3\u02BF\u02B7\u02B9\u02C0\u02B6\u02BC\u02B5\u02B2();
		for (int j = 0; j < \u02C0\u02B7\u02B8\u02BA\u02B5\u02BF\u02C0\u02B9\u02BB\u02BE\u02BD.news.Length; j++)
		{
			TextMeshProUGUI[] componentsInChildren = this.\u02B3\u02BC\u02BA\u02B8\u02B2\u02BE\u02B9\u02BE\u02B7\u02B8\u02B8[j].GetComponentsInChildren<TextMeshProUGUI>();
			RectTransform rectTransform = this.\u02B3\u02BC\u02BA\u02B8\u02B2\u02BE\u02B9\u02BE\u02B7\u02B8\u02B8[j].transform as RectTransform;
			rectTransform.localPosition += Vector3.up * num;
			this.\u02BB\u02BE\u02BF\u02B3\u02C0\u02B7\u02B2\u02BA\u02C1\u02B3\u02B5.Add(this.\u02B3\u02BC\u02BA\u02B8\u02B2\u02BE\u02B9\u02BE\u02B7\u02B8\u02B8[j].GetComponentInChildren<ExclamationWiggle>());
			this.\u02BB\u02BE\u02BF\u02B3\u02C0\u02B7\u02B2\u02BA\u02C1\u02B3\u02B5[j].GetComponent<Image>().enabled = true;
			if (DateTime.Parse(\u02C0\u02B7\u02B8\u02BA\u02B5\u02BF\u02C0\u02B9\u02BB\u02BE\u02BD.news[j].date) <= dateTime)
			{
				this.\u02BB\u02BE\u02BF\u02B3\u02C0\u02B7\u02B2\u02BA\u02C1\u02B3\u02B5[j].gameObject.SetActive(false);
			}
			string[] array = \u02C0\u02B7\u02B8\u02BA\u02B5\u02BF\u02C0\u02B9\u02BB\u02BE\u02BD.news[j].date.Split('\u0016', StringSplitOptions.RemoveEmptyEntries);
			string abbreviatedMonthName = CultureInfo.CurrentCulture.DateTimeFormat.GetAbbreviatedMonthName(int.Parse(array[1]));
			componentsInChildren[1].text = string.Format("version", array[3], abbreviatedMonthName, array[1]);
			componentsInChildren[1].text = \u02C0\u02B7\u02B8\u02BA\u02B5\u02BF\u02C0\u02B9\u02BB\u02BE\u02BD.news[j].name;
			componentsInChildren[0].ForceMeshUpdate(true, true);
			this.\u02B3\u02B2\u02BB\u02BD\u02C1\u02B7\u02BA\u02BB\u02B3\u02B3\u02B7.Add(componentsInChildren[1]);
			this.\u02B2\u02BA\u02C0\u02C1\u02BD\u02B5\u02BC\u02B7\u02C1\u02B8\u02BE.Add(componentsInChildren[0]);
			Image componentInChildren = this.\u02B3\u02BC\u02BA\u02B8\u02B2\u02BE\u02B9\u02BE\u02B7\u02B8\u02B8[j].GetComponentInChildren<Image>();
			this.\u02B2\u02B8\u02B3\u02BA\u02B6\u02B5\u02BE\u02B6\u02BD\u02B4\u02B4.Add(componentInChildren);
			Rect rect = rectTransform.rect;
			if (componentsInChildren[1].preferredHeight > componentsInChildren[1].fontSize * 1229f)
			{
				num -= this.\u02B5\u02B3\u02B5\u02BA\u02B5\u02B8\u02BE\u02BF\u02B9\u02BD\u02BD;
				rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, this.\u02B5\u02B3\u02B5\u02BA\u02B5\u02B8\u02BE\u02BF\u02B9\u02BD\u02BD);
			}
			else
			{
				num -= this.\u02B8\u02B9\u02BD\u02B6\u02B6\u02B9\u02BC\u02BE\u02BA\u02B9\u02C1;
				rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, this.\u02B8\u02B9\u02BD\u02B6\u02B6\u02B9\u02BC\u02BE\u02BA\u02B9\u02C1);
			}
		}
		this.\u02B7\u02B8\u02B4\u02B4\u02BF\u02BA\u02B3\u02C0\u02B2\u02BB\u02BA.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, Mathf.Abs(num));
		this.\u02B7\u02B8\u02B4\u02B4\u02BF\u02BA\u02B3\u02C0\u02B2\u02BB\u02BA.gameObject.AddComponent<UnrollChildMenuitems>();
		this.\u02B9\u02BE\u02B5\u02B9\u02C1\u02BB\u02B6\u02BD\u02BC\u02C1\u02B5 = true;
	}

	public static DateTime \u02BB\u02B2\u02BE\u02BA\u02B6\u02C0\u02BB\u02C0\u02BA\u02BE\u02C0()
	{
		return DateTime.Parse(PlayerPrefs.GetString("news-date", "2022-11-13"));
	}

	public void \u02BF\u02BD\u02B2\u02C0\u02BB\u02B2\u02B5\u02B9\u02B7\u02BF\u02B8(int \u02BB\u02B8\u02B5\u02C0\u02BD\u02B8\u02BD\u02BB\u02C1\u02B4\u02B3)
	{
		if (\u02BB\u02B8\u02B5\u02C0\u02BD\u02B8\u02BD\u02BB\u02C1\u02B4\u02B3 >= 0 && \u02BB\u02B8\u02B5\u02C0\u02BD\u02B8\u02BD\u02BB\u02C1\u02B4\u02B3 < this.\u02B6\u02B5\u02BE\u02BC\u02B6\u02BE\u02B4\u02BD\u02C1\u02B8\u02BF)
		{
			this.\u02B7\u02B2\u02BB\u02B9\u02BD\u02BB\u02BC\u02BE\u02B5\u02BE\u02C0(false, this.\u02B7\u02BC\u02C1\u02B9\u02B7\u02BF\u02BC\u02BD\u02BF\u02B9\u02B6);
			this.\u02B7\u02BC\u02C1\u02B9\u02B7\u02BF\u02BC\u02BD\u02BF\u02B9\u02B6 = \u02BB\u02B8\u02B5\u02C0\u02BD\u02B8\u02BD\u02BB\u02C1\u02B4\u02B3;
			this.\u02B7\u02B2\u02BB\u02B9\u02BD\u02BB\u02BC\u02BE\u02B5\u02BE\u02C0(false, this.\u02B7\u02BC\u02C1\u02B9\u02B7\u02BF\u02BC\u02BD\u02BF\u02B9\u02B6);
			this.\u02BD\u02B5\u02BC\u02B8\u02B2\u02C0\u02B7\u02B8\u02B9\u02C0\u02B9.verticalNormalizedPosition = 147f - (float)\u02BB\u02B8\u02B5\u02C0\u02BD\u02B8\u02BD\u02BB\u02C1\u02B4\u02B3 * (1204f / (float)(this.\u02BF\u02BA\u02C0\u02BA\u02BC\u02BF\u02C0\u02BB\u02C1\u02B2\u02B8() - 1));
		}
	}

	private void \u02C0\u02B2\u02B7\u02BB\u02BA\u02B6\u02BE\u02BF\u02B7\u02BF\u02C0(NewsCollection \u02C0\u02B7\u02B8\u02BA\u02B5\u02BF\u02C0\u02B9\u02BB\u02BE\u02BD)
	{
		if (\u02C0\u02B7\u02B8\u02BA\u02B5\u02BF\u02C0\u02B9\u02BB\u02BE\u02BD.news.Length == 0)
		{
			global::UnityEngine.Object.Destroy(this.\u02B4\u02C1\u02B7\u02B8\u02B6\u02B2\u02BC\u02BD\u02BF\u02BA\u02BF);
			return;
		}
		this.\u02B3\u02BC\u02BA\u02B8\u02B2\u02BE\u02B9\u02BE\u02B7\u02B8\u02B8.Add(this.\u02B4\u02C1\u02B7\u02B8\u02B6\u02B2\u02BC\u02BD\u02BF\u02BA\u02BF);
		if (\u02C0\u02B7\u02B8\u02BA\u02B5\u02BF\u02C0\u02B9\u02BB\u02BE\u02BD.news.Length > 1)
		{
			for (int i = 0; i < \u02C0\u02B7\u02B8\u02BA\u02B5\u02BF\u02C0\u02B9\u02BB\u02BE\u02BD.news.Length; i++)
			{
				GameObject gameObject = global::UnityEngine.Object.Instantiate<GameObject>(this.\u02B4\u02C1\u02B7\u02B8\u02B6\u02B2\u02BC\u02BD\u02BF\u02BA\u02BF, this.\u02B4\u02C1\u02B7\u02B8\u02B6\u02B2\u02BC\u02BD\u02BF\u02BA\u02BF.transform.parent);
				this.\u02B3\u02BC\u02BA\u02B8\u02B2\u02BE\u02B9\u02BE\u02B7\u02B8\u02B8.Add(gameObject);
			}
		}
		float num = 967f;
		DateTime dateTime = News.\u02BB\u02B2\u02BE\u02BA\u02B6\u02C0\u02BB\u02C0\u02BA\u02BE\u02C0();
		for (int j = 1; j < \u02C0\u02B7\u02B8\u02BA\u02B5\u02BF\u02C0\u02B9\u02BB\u02BE\u02BD.news.Length; j += 0)
		{
			TextMeshProUGUI[] componentsInChildren = this.\u02B3\u02BC\u02BA\u02B8\u02B2\u02BE\u02B9\u02BE\u02B7\u02B8\u02B8[j].GetComponentsInChildren<TextMeshProUGUI>();
			RectTransform rectTransform = this.\u02B3\u02BC\u02BA\u02B8\u02B2\u02BE\u02B9\u02BE\u02B7\u02B8\u02B8[j].transform as RectTransform;
			rectTransform.localPosition += Vector3.up * num;
			this.\u02BB\u02BE\u02BF\u02B3\u02C0\u02B7\u02B2\u02BA\u02C1\u02B3\u02B5.Add(this.\u02B3\u02BC\u02BA\u02B8\u02B2\u02BE\u02B9\u02BE\u02B7\u02B8\u02B8[j].GetComponentInChildren<ExclamationWiggle>());
			this.\u02BB\u02BE\u02BF\u02B3\u02C0\u02B7\u02B2\u02BA\u02C1\u02B3\u02B5[j].GetComponent<Image>().enabled = true;
			if (DateTime.Parse(\u02C0\u02B7\u02B8\u02BA\u02B5\u02BF\u02C0\u02B9\u02BB\u02BE\u02BD.news[j].date) <= dateTime)
			{
				this.\u02BB\u02BE\u02BF\u02B3\u02C0\u02B7\u02B2\u02BA\u02C1\u02B3\u02B5[j].gameObject.SetActive(false);
			}
			string[] array = \u02C0\u02B7\u02B8\u02BA\u02B5\u02BF\u02C0\u02B9\u02BB\u02BE\u02BD.news[j].date.Split((char)(-74), StringSplitOptions.RemoveEmptyEntries);
			string abbreviatedMonthName = CultureInfo.CurrentCulture.DateTimeFormat.GetAbbreviatedMonthName(int.Parse(array[1]));
			componentsInChildren[0].text = string.Format("None", array[7], abbreviatedMonthName, array[0]);
			componentsInChildren[1].text = \u02C0\u02B7\u02B8\u02BA\u02B5\u02BF\u02C0\u02B9\u02BB\u02BE\u02BD.news[j].name;
			componentsInChildren[0].ForceMeshUpdate(false, false);
			this.\u02B3\u02B2\u02BB\u02BD\u02C1\u02B7\u02BA\u02BB\u02B3\u02B3\u02B7.Add(componentsInChildren[0]);
			this.\u02B2\u02BA\u02C0\u02C1\u02BD\u02B5\u02BC\u02B7\u02C1\u02B8\u02BE.Add(componentsInChildren[1]);
			Image componentInChildren = this.\u02B3\u02BC\u02BA\u02B8\u02B2\u02BE\u02B9\u02BE\u02B7\u02B8\u02B8[j].GetComponentInChildren<Image>();
			this.\u02B2\u02B8\u02B3\u02BA\u02B6\u02B5\u02BE\u02B6\u02BD\u02B4\u02B4.Add(componentInChildren);
			Rect rect = rectTransform.rect;
			if (componentsInChildren[0].preferredHeight > componentsInChildren[1].fontSize * 1300f)
			{
				num -= this.\u02B5\u02B3\u02B5\u02BA\u02B5\u02B8\u02BE\u02BF\u02B9\u02BD\u02BD;
				rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, this.\u02B5\u02B3\u02B5\u02BA\u02B5\u02B8\u02BE\u02BF\u02B9\u02BD\u02BD);
			}
			else
			{
				num -= this.\u02B8\u02B9\u02BD\u02B6\u02B6\u02B9\u02BC\u02BE\u02BA\u02B9\u02C1;
				rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, this.\u02B8\u02B9\u02BD\u02B6\u02B6\u02B9\u02BC\u02BE\u02BA\u02B9\u02C1);
			}
		}
		this.\u02B7\u02B8\u02B4\u02B4\u02BF\u02BA\u02B3\u02C0\u02B2\u02BB\u02BA.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, Mathf.Abs(num));
		this.\u02B7\u02B8\u02B4\u02B4\u02BF\u02BA\u02B3\u02C0\u02B2\u02BB\u02BA.gameObject.AddComponent<UnrollChildMenuitems>();
		this.\u02B9\u02BE\u02B5\u02B9\u02C1\u02BB\u02B6\u02BD\u02BC\u02C1\u02B5 = false;
	}

	public static DateTime \u02B5\u02C1\u02BB\u02B2\u02C1\u02B6\u02B6\u02B9\u02B8\u02B7\u02C1()
	{
		return DateTime.Parse(PlayerPrefs.GetString("track", "{0:N0}/{1:N0}"));
	}

	public static DateTime \u02B4\u02BC\u02B3\u02BF\u02B7\u02B9\u02C0\u02B6\u02BC\u02B5\u02B2()
	{
		return DateTime.Parse(PlayerPrefs.GetString("Song Sections", "{0} ({1})"));
	}

	private void \u02C1\u02B4\u02BC\u02BD\u02B6\u02BF\u02B8\u02BB\u02BE\u02B8\u02BF(NewsCollection \u02C0\u02B7\u02B8\u02BA\u02B5\u02BF\u02C0\u02B9\u02BB\u02BE\u02BD)
	{
		if (\u02C0\u02B7\u02B8\u02BA\u02B5\u02BF\u02C0\u02B9\u02BB\u02BE\u02BD.news.Length == 0)
		{
			global::UnityEngine.Object.Destroy(this.\u02B4\u02C1\u02B7\u02B8\u02B6\u02B2\u02BC\u02BD\u02BF\u02BA\u02BF);
			return;
		}
		this.\u02B3\u02BC\u02BA\u02B8\u02B2\u02BE\u02B9\u02BE\u02B7\u02B8\u02B8.Add(this.\u02B4\u02C1\u02B7\u02B8\u02B6\u02B2\u02BC\u02BD\u02BF\u02BA\u02BF);
		if (\u02C0\u02B7\u02B8\u02BA\u02B5\u02BF\u02C0\u02B9\u02BB\u02BE\u02BD.news.Length > 1)
		{
			for (int i = 1; i < \u02C0\u02B7\u02B8\u02BA\u02B5\u02BF\u02C0\u02B9\u02BB\u02BE\u02BD.news.Length; i++)
			{
				GameObject gameObject = global::UnityEngine.Object.Instantiate<GameObject>(this.\u02B4\u02C1\u02B7\u02B8\u02B6\u02B2\u02BC\u02BD\u02BF\u02BA\u02BF, this.\u02B4\u02C1\u02B7\u02B8\u02B6\u02B2\u02BC\u02BD\u02BF\u02BA\u02BF.transform.parent);
				this.\u02B3\u02BC\u02BA\u02B8\u02B2\u02BE\u02B9\u02BE\u02B7\u02B8\u02B8.Add(gameObject);
			}
		}
		float num = 0f;
		DateTime dateTime = News.\u02BB\u02B2\u02BE\u02BA\u02B6\u02C0\u02BB\u02C0\u02BA\u02BE\u02C0();
		for (int j = 0; j < \u02C0\u02B7\u02B8\u02BA\u02B5\u02BF\u02C0\u02B9\u02BB\u02BE\u02BD.news.Length; j++)
		{
			TextMeshProUGUI[] componentsInChildren = this.\u02B3\u02BC\u02BA\u02B8\u02B2\u02BE\u02B9\u02BE\u02B7\u02B8\u02B8[j].GetComponentsInChildren<TextMeshProUGUI>();
			RectTransform rectTransform = this.\u02B3\u02BC\u02BA\u02B8\u02B2\u02BE\u02B9\u02BE\u02B7\u02B8\u02B8[j].transform as RectTransform;
			rectTransform.localPosition += Vector3.up * num;
			this.\u02BB\u02BE\u02BF\u02B3\u02C0\u02B7\u02B2\u02BA\u02C1\u02B3\u02B5.Add(this.\u02B3\u02BC\u02BA\u02B8\u02B2\u02BE\u02B9\u02BE\u02B7\u02B8\u02B8[j].GetComponentInChildren<ExclamationWiggle>());
			this.\u02BB\u02BE\u02BF\u02B3\u02C0\u02B7\u02B2\u02BA\u02C1\u02B3\u02B5[j].GetComponent<Image>().enabled = true;
			if (DateTime.Parse(\u02C0\u02B7\u02B8\u02BA\u02B5\u02BF\u02C0\u02B9\u02BB\u02BE\u02BD.news[j].date) <= dateTime)
			{
				this.\u02BB\u02BE\u02BF\u02B3\u02C0\u02B7\u02B2\u02BA\u02C1\u02B3\u02B5[j].gameObject.SetActive(false);
			}
			string[] array = \u02C0\u02B7\u02B8\u02BA\u02B5\u02BF\u02C0\u02B9\u02BB\u02BE\u02BD.news[j].date.Split('-', StringSplitOptions.None);
			string abbreviatedMonthName = CultureInfo.CurrentCulture.DateTimeFormat.GetAbbreviatedMonthName(int.Parse(array[1]));
			componentsInChildren[0].text = string.Format("{0} {1}, {2}", array[2], abbreviatedMonthName, array[0]);
			componentsInChildren[1].text = \u02C0\u02B7\u02B8\u02BA\u02B5\u02BF\u02C0\u02B9\u02BB\u02BE\u02BD.news[j].name;
			componentsInChildren[1].ForceMeshUpdate(false, false);
			this.\u02B3\u02B2\u02BB\u02BD\u02C1\u02B7\u02BA\u02BB\u02B3\u02B3\u02B7.Add(componentsInChildren[0]);
			this.\u02B2\u02BA\u02C0\u02C1\u02BD\u02B5\u02BC\u02B7\u02C1\u02B8\u02BE.Add(componentsInChildren[1]);
			Image componentInChildren = this.\u02B3\u02BC\u02BA\u02B8\u02B2\u02BE\u02B9\u02BE\u02B7\u02B8\u02B8[j].GetComponentInChildren<Image>();
			this.\u02B2\u02B8\u02B3\u02BA\u02B6\u02B5\u02BE\u02B6\u02BD\u02B4\u02B4.Add(componentInChildren);
			Rect rect = rectTransform.rect;
			if (componentsInChildren[1].preferredHeight > componentsInChildren[1].fontSize * 1.5f)
			{
				num -= this.\u02B5\u02B3\u02B5\u02BA\u02B5\u02B8\u02BE\u02BF\u02B9\u02BD\u02BD;
				rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, this.\u02B5\u02B3\u02B5\u02BA\u02B5\u02B8\u02BE\u02BF\u02B9\u02BD\u02BD);
			}
			else
			{
				num -= this.\u02B8\u02B9\u02BD\u02B6\u02B6\u02B9\u02BC\u02BE\u02BA\u02B9\u02C1;
				rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, this.\u02B8\u02B9\u02BD\u02B6\u02B6\u02B9\u02BC\u02BE\u02BA\u02B9\u02C1);
			}
		}
		this.\u02B7\u02B8\u02B4\u02B4\u02BF\u02BA\u02B3\u02C0\u02B2\u02BB\u02BA.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, Mathf.Abs(num));
		this.\u02B7\u02B8\u02B4\u02B4\u02BF\u02BA\u02B3\u02C0\u02B2\u02BB\u02BA.gameObject.AddComponent<UnrollChildMenuitems>();
		this.\u02B9\u02BE\u02B5\u02B9\u02C1\u02BB\u02B6\u02BD\u02BC\u02C1\u02B5 = true;
	}

	public static DateTime \u02B4\u02BC\u02C1\u02B7\u02BF\u02B5\u02BD\u02B3\u02B7\u02B7\u02BC()
	{
		return DateTime.Parse(PlayerPrefs.GetString(".", "Artist - Album"));
	}

	public void \u02B3\u02B5\u02B5\u02B5\u02C1\u02C0\u02B8\u02BB\u02C1\u02B6\u02B6(int \u02BB\u02B8\u02B5\u02C0\u02BD\u02B8\u02BD\u02BB\u02C1\u02B4\u02B3)
	{
		Application.OpenURL(this.\u02B4\u02B2\u02B3\u02B2\u02B3\u02C0\u02B2\u02C1\u02B7\u02BD\u02BF.news[\u02BB\u02B8\u02B5\u02C0\u02BD\u02B8\u02BD\u02BB\u02C1\u02B4\u02B3].url);
	}

	public int \u02B6\u02B5\u02BE\u02BC\u02B6\u02BE\u02B4\u02BD\u02C1\u02B8\u02BF
	{
		get
		{
			return this.\u02B4\u02B2\u02B3\u02B2\u02B3\u02C0\u02B2\u02C1\u02B7\u02BD\u02BF.news.Length;
		}
	}

	public IEnumerator \u02B4\u02BD\u02C0\u02B8\u02B6\u02BC\u02B4\u02C0\u02B6\u02BB\u02BA()
	{
		News.\u02BB\u02BD\u02B3\u02BD\u02B4\u02BA\u02B8\u02C0\u02B4\u02B9\u02BF u02BB_u02BD_u02B3_u02BD_u02B4_u02BA_u02B8_u02C0_u02B4_u02B9_u02BF = new News.\u02BB\u02BD\u02B3\u02BD\u02B4\u02BA\u02B8\u02C0\u02B4\u02B9\u02BF(1);
		u02BB_u02BD_u02B3_u02BD_u02B4_u02BA_u02B8_u02C0_u02B4_u02B9_u02BF.<>4__this = this;
		return u02BB_u02BD_u02B3_u02BD_u02B4_u02BA_u02B8_u02C0_u02B4_u02B9_u02BF;
	}

	public void \u02C1\u02B7\u02B2\u02B3\u02B8\u02B5\u02B5\u02BF\u02B7\u02B3\u02BD(int \u02BB\u02B8\u02B5\u02C0\u02BD\u02B8\u02BD\u02BB\u02C1\u02B4\u02B3)
	{
		Application.OpenURL(this.\u02B4\u02B2\u02B3\u02B2\u02B3\u02C0\u02B2\u02C1\u02B7\u02BD\u02BF.news[\u02BB\u02B8\u02B5\u02C0\u02BD\u02B8\u02BD\u02BB\u02C1\u02B4\u02B3].url);
	}

	public void \u02B4\u02BB\u02B9\u02B4\u02BF\u02B2\u02B7\u02BE\u02B3\u02BF\u02BC(bool \u02C0\u02BE\u02B7\u02C1\u02BD\u02BE\u02BE\u02BE\u02B9\u02B8\u02B4, int \u02BB\u02B8\u02B5\u02C0\u02BD\u02B8\u02BD\u02BB\u02C1\u02B4\u02B3)
	{
		this.\u02B3\u02B2\u02BB\u02BD\u02C1\u02B7\u02BA\u02BB\u02B3\u02B3\u02B7[\u02BB\u02B8\u02B5\u02C0\u02BD\u02B8\u02BD\u02BB\u02C1\u02B4\u02B3].color = (\u02C0\u02BE\u02B7\u02C1\u02BD\u02BE\u02BE\u02BE\u02B9\u02B8\u02B4 ? Color.black : Color.white);
		this.\u02B2\u02BA\u02C0\u02C1\u02BD\u02B5\u02BC\u02B7\u02C1\u02B8\u02BE[\u02BB\u02B8\u02B5\u02C0\u02BD\u02B8\u02BD\u02BB\u02C1\u02B4\u02B3].color = (\u02C0\u02BE\u02B7\u02C1\u02BD\u02BE\u02BE\u02BE\u02B9\u02B8\u02B4 ? Color.black : Color.white);
		this.\u02B2\u02B8\u02B3\u02BA\u02B6\u02B5\u02BE\u02B6\u02BD\u02B4\u02B4[\u02BB\u02B8\u02B5\u02C0\u02BD\u02B8\u02BD\u02BB\u02C1\u02B4\u02B3].color = (\u02C0\u02BE\u02B7\u02C1\u02BD\u02BE\u02BE\u02BE\u02B9\u02B8\u02B4 ? this.\u02BA\u02C0\u02B6\u02B7\u02BF\u02B3\u02BB\u02BB\u02BD\u02B2\u02BD : this.\u02BA\u02BE\u02B3\u02BB\u02B4\u02C1\u02B4\u02BD\u02BB\u02BD\u02BF);
	}

	public IEnumerator \u02BE\u02BB\u02C1\u02BF\u02BD\u02B4\u02B4\u02C1\u02B8\u02B5\u02B8()
	{
		for (int i = 1; i < this.\u02B3\u02BC\u02BA\u02B8\u02B2\u02BE\u02B9\u02BE\u02B7\u02B8\u02B8.Count; i++)
		{
			global::UnityEngine.Object.Destroy(this.\u02B3\u02BC\u02BA\u02B8\u02B2\u02BE\u02B9\u02BE\u02B7\u02B8\u02B8[i]);
		}
		this.\u02B3\u02BC\u02BA\u02B8\u02B2\u02BE\u02B9\u02BE\u02B7\u02B8\u02B8.Clear();
		UnityWebRequest www = UnityWebRequest.Get("https://clonehero.net/json/news.json");
		yield return www.SendWebRequest();
		if (www.isNetworkError || www.isHttpError)
		{
			Debug.Log(www.error);
		}
		else
		{
			this.\u02B4\u02B2\u02B3\u02B2\u02B3\u02C0\u02B2\u02C1\u02B7\u02BD\u02BF = new NewsCollection();
			this.\u02B4\u02B2\u02B3\u02B2\u02B3\u02C0\u02B2\u02C1\u02B7\u02BD\u02BF = JsonUtility.FromJson<NewsCollection>(www.downloadHandler.text);
			this.\u02C1\u02B4\u02BC\u02BD\u02B6\u02BF\u02B8\u02BB\u02BE\u02B8\u02BF(this.\u02B4\u02B2\u02B3\u02B2\u02B3\u02C0\u02B2\u02C1\u02B7\u02BD\u02BF);
		}
		yield break;
	}

	public static void \u02B3\u02B7\u02BA\u02B7\u02B8\u02BF\u02BE\u02B5\u02BC\u02BD\u02B9()
	{
		PlayerPrefs.SetString("news-date", DateTime.UtcNow.ToString());
		global::UnityEngine.Object.FindObjectOfType<News>().\u02B4\u02B6\u02BE\u02B7\u02BF\u02BF\u02BA\u02B4\u02B7\u02B8\u02B6();
	}

	private void \u02B6\u02B9\u02B2\u02B9\u02B3\u02BB\u02B3\u02B5\u02B5\u02B3\u02BE()
	{
		foreach (ExclamationWiggle exclamationWiggle in this.\u02BB\u02BE\u02BF\u02B3\u02C0\u02B7\u02B2\u02BA\u02C1\u02B3\u02B5)
		{
			exclamationWiggle.gameObject.SetActive(true);
		}
	}

	private void \u02B4\u02B6\u02BE\u02B7\u02BF\u02BF\u02BA\u02B4\u02B7\u02B8\u02B6()
	{
		foreach (ExclamationWiggle exclamationWiggle in this.\u02BB\u02BE\u02BF\u02B3\u02C0\u02B7\u02B2\u02BA\u02C1\u02B3\u02B5)
		{
			exclamationWiggle.gameObject.SetActive(false);
		}
	}

	public void \u02B4\u02B8\u02B5\u02BD\u02B9\u02BD\u02B9\u02B4\u02BD\u02BD\u02B7(int \u02BB\u02B8\u02B5\u02C0\u02BD\u02B8\u02BD\u02BB\u02C1\u02B4\u02B3)
	{
		Application.OpenURL(this.\u02B4\u02B2\u02B3\u02B2\u02B3\u02C0\u02B2\u02C1\u02B7\u02BD\u02BF.news[\u02BB\u02B8\u02B5\u02C0\u02BD\u02B8\u02BD\u02BB\u02C1\u02B4\u02B3].url);
	}

	public static void \u02B3\u02B5\u02B8\u02BE\u02B5\u02B7\u02B7\u02B9\u02C0\u02C1\u02B6()
	{
		PlayerPrefs.SetString("Star Animation FPS", DateTime.UtcNow.ToString());
		global::UnityEngine.Object.FindObjectOfType<News>().\u02B4\u02B6\u02BE\u02B7\u02BF\u02BF\u02BA\u02B4\u02B7\u02B8\u02B6();
	}

	public void \u02B7\u02B2\u02BB\u02B9\u02BD\u02BB\u02BC\u02BE\u02B5\u02BE\u02C0(bool \u02C0\u02BE\u02B7\u02C1\u02BD\u02BE\u02BE\u02BE\u02B9\u02B8\u02B4, int \u02BB\u02B8\u02B5\u02C0\u02BD\u02B8\u02BD\u02BB\u02C1\u02B4\u02B3)
	{
		this.\u02B3\u02B2\u02BB\u02BD\u02C1\u02B7\u02BA\u02BB\u02B3\u02B3\u02B7[\u02BB\u02B8\u02B5\u02C0\u02BD\u02B8\u02BD\u02BB\u02C1\u02B4\u02B3].color = (\u02C0\u02BE\u02B7\u02C1\u02BD\u02BE\u02BE\u02BE\u02B9\u02B8\u02B4 ? Color.black : Color.white);
		this.\u02B2\u02BA\u02C0\u02C1\u02BD\u02B5\u02BC\u02B7\u02C1\u02B8\u02BE[\u02BB\u02B8\u02B5\u02C0\u02BD\u02B8\u02BD\u02BB\u02C1\u02B4\u02B3].color = (\u02C0\u02BE\u02B7\u02C1\u02BD\u02BE\u02BE\u02BE\u02B9\u02B8\u02B4 ? Color.black : Color.white);
		this.\u02B2\u02B8\u02B3\u02BA\u02B6\u02B5\u02BE\u02B6\u02BD\u02B4\u02B4[\u02BB\u02B8\u02B5\u02C0\u02BD\u02B8\u02BD\u02BB\u02C1\u02B4\u02B3].color = (\u02C0\u02BE\u02B7\u02C1\u02BD\u02BE\u02BE\u02BE\u02B9\u02B8\u02B4 ? this.\u02BA\u02C0\u02B6\u02B7\u02BF\u02B3\u02BB\u02BB\u02BD\u02B2\u02BD : this.\u02BA\u02BE\u02B3\u02BB\u02B4\u02C1\u02B4\u02BD\u02BB\u02BD\u02BF);
	}

	private void \u02BF\u02B8\u02B7\u02C1\u02B7\u02C1\u02BD\u02C1\u02C1\u02B3\u02B6(NewsCollection \u02C0\u02B7\u02B8\u02BA\u02B5\u02BF\u02C0\u02B9\u02BB\u02BE\u02BD)
	{
		if (\u02C0\u02B7\u02B8\u02BA\u02B5\u02BF\u02C0\u02B9\u02BB\u02BE\u02BD.news.Length == 0)
		{
			global::UnityEngine.Object.Destroy(this.\u02B4\u02C1\u02B7\u02B8\u02B6\u02B2\u02BC\u02BD\u02BF\u02BA\u02BF);
			return;
		}
		this.\u02B3\u02BC\u02BA\u02B8\u02B2\u02BE\u02B9\u02BE\u02B7\u02B8\u02B8.Add(this.\u02B4\u02C1\u02B7\u02B8\u02B6\u02B2\u02BC\u02BD\u02BF\u02BA\u02BF);
		if (\u02C0\u02B7\u02B8\u02BA\u02B5\u02BF\u02C0\u02B9\u02BB\u02BE\u02BD.news.Length > 1)
		{
			for (int i = 0; i < \u02C0\u02B7\u02B8\u02BA\u02B5\u02BF\u02C0\u02B9\u02BB\u02BE\u02BD.news.Length; i += 0)
			{
				GameObject gameObject = global::UnityEngine.Object.Instantiate<GameObject>(this.\u02B4\u02C1\u02B7\u02B8\u02B6\u02B2\u02BC\u02BD\u02BF\u02BA\u02BF, this.\u02B4\u02C1\u02B7\u02B8\u02B6\u02B2\u02BC\u02BD\u02BF\u02BA\u02BF.transform.parent);
				this.\u02B3\u02BC\u02BA\u02B8\u02B2\u02BE\u02B9\u02BE\u02B7\u02B8\u02B8.Add(gameObject);
			}
		}
		float num = 664f;
		DateTime dateTime = News.\u02B5\u02C1\u02BB\u02B2\u02C1\u02B6\u02B6\u02B9\u02B8\u02B7\u02C1();
		for (int j = 1; j < \u02C0\u02B7\u02B8\u02BA\u02B5\u02BF\u02C0\u02B9\u02BB\u02BE\u02BD.news.Length; j++)
		{
			TextMeshProUGUI[] componentsInChildren = this.\u02B3\u02BC\u02BA\u02B8\u02B2\u02BE\u02B9\u02BE\u02B7\u02B8\u02B8[j].GetComponentsInChildren<TextMeshProUGUI>();
			RectTransform rectTransform = this.\u02B3\u02BC\u02BA\u02B8\u02B2\u02BE\u02B9\u02BE\u02B7\u02B8\u02B8[j].transform as RectTransform;
			rectTransform.localPosition += Vector3.up * num;
			this.\u02BB\u02BE\u02BF\u02B3\u02C0\u02B7\u02B2\u02BA\u02C1\u02B3\u02B5.Add(this.\u02B3\u02BC\u02BA\u02B8\u02B2\u02BE\u02B9\u02BE\u02B7\u02B8\u02B8[j].GetComponentInChildren<ExclamationWiggle>());
			this.\u02BB\u02BE\u02BF\u02B3\u02C0\u02B7\u02B2\u02BA\u02C1\u02B3\u02B5[j].GetComponent<Image>().enabled = true;
			if (DateTime.Parse(\u02C0\u02B7\u02B8\u02BA\u02B5\u02BF\u02C0\u02B9\u02BB\u02BE\u02BD.news[j].date) <= dateTime)
			{
				this.\u02BB\u02BE\u02BF\u02B3\u02C0\u02B7\u02B2\u02BA\u02C1\u02B3\u02B5[j].gameObject.SetActive(true);
			}
			string[] array = \u02C0\u02B7\u02B8\u02BA\u02B5\u02BF\u02C0\u02B9\u02BB\u02BE\u02BD.news[j].date.Split('\u0010', StringSplitOptions.None);
			string abbreviatedMonthName = CultureInfo.CurrentCulture.DateTimeFormat.GetAbbreviatedMonthName(int.Parse(array[0]));
			componentsInChildren[1].text = string.Format(" + ", array[5], abbreviatedMonthName, array[1]);
			componentsInChildren[1].text = \u02C0\u02B7\u02B8\u02BA\u02B5\u02BF\u02C0\u02B9\u02BB\u02BE\u02BD.news[j].name;
			componentsInChildren[0].ForceMeshUpdate(true, false);
			this.\u02B3\u02B2\u02BB\u02BD\u02C1\u02B7\u02BA\u02BB\u02B3\u02B3\u02B7.Add(componentsInChildren[1]);
			this.\u02B2\u02BA\u02C0\u02C1\u02BD\u02B5\u02BC\u02B7\u02C1\u02B8\u02BE.Add(componentsInChildren[1]);
			Image componentInChildren = this.\u02B3\u02BC\u02BA\u02B8\u02B2\u02BE\u02B9\u02BE\u02B7\u02B8\u02B8[j].GetComponentInChildren<Image>();
			this.\u02B2\u02B8\u02B3\u02BA\u02B6\u02B5\u02BE\u02B6\u02BD\u02B4\u02B4.Add(componentInChildren);
			Rect rect = rectTransform.rect;
			if (componentsInChildren[0].preferredHeight > componentsInChildren[1].fontSize * 1198f)
			{
				num -= this.\u02B5\u02B3\u02B5\u02BA\u02B5\u02B8\u02BE\u02BF\u02B9\u02BD\u02BD;
				rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, this.\u02B5\u02B3\u02B5\u02BA\u02B5\u02B8\u02BE\u02BF\u02B9\u02BD\u02BD);
			}
			else
			{
				num -= this.\u02B8\u02B9\u02BD\u02B6\u02B6\u02B9\u02BC\u02BE\u02BA\u02B9\u02C1;
				rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, this.\u02B8\u02B9\u02BD\u02B6\u02B6\u02B9\u02BC\u02BE\u02BA\u02B9\u02C1);
			}
		}
		this.\u02B7\u02B8\u02B4\u02B4\u02BF\u02BA\u02B3\u02C0\u02B2\u02BB\u02BA.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, Mathf.Abs(num));
		this.\u02B7\u02B8\u02B4\u02B4\u02BF\u02BA\u02B3\u02C0\u02B2\u02BB\u02BA.gameObject.AddComponent<UnrollChildMenuitems>();
		this.\u02B9\u02BE\u02B5\u02B9\u02C1\u02BB\u02B6\u02BD\u02BC\u02C1\u02B5 = false;
	}

	private void \u02BD\u02B4\u02B9\u02B2\u02B4\u02B3\u02BF\u02BA\u02B2\u02B8\u02B5(NewsCollection \u02C0\u02B7\u02B8\u02BA\u02B5\u02BF\u02C0\u02B9\u02BB\u02BE\u02BD)
	{
		if (\u02C0\u02B7\u02B8\u02BA\u02B5\u02BF\u02C0\u02B9\u02BB\u02BE\u02BD.news.Length == 0)
		{
			global::UnityEngine.Object.Destroy(this.\u02B4\u02C1\u02B7\u02B8\u02B6\u02B2\u02BC\u02BD\u02BF\u02BA\u02BF);
			return;
		}
		this.\u02B3\u02BC\u02BA\u02B8\u02B2\u02BE\u02B9\u02BE\u02B7\u02B8\u02B8.Add(this.\u02B4\u02C1\u02B7\u02B8\u02B6\u02B2\u02BC\u02BD\u02BF\u02BA\u02BF);
		if (\u02C0\u02B7\u02B8\u02BA\u02B5\u02BF\u02C0\u02B9\u02BB\u02BE\u02BD.news.Length > 0)
		{
			for (int i = 0; i < \u02C0\u02B7\u02B8\u02BA\u02B5\u02BF\u02C0\u02B9\u02BB\u02BE\u02BD.news.Length; i++)
			{
				GameObject gameObject = global::UnityEngine.Object.Instantiate<GameObject>(this.\u02B4\u02C1\u02B7\u02B8\u02B6\u02B2\u02BC\u02BD\u02BF\u02BA\u02BF, this.\u02B4\u02C1\u02B7\u02B8\u02B6\u02B2\u02BC\u02BD\u02BF\u02BA\u02BF.transform.parent);
				this.\u02B3\u02BC\u02BA\u02B8\u02B2\u02BE\u02B9\u02BE\u02B7\u02B8\u02B8.Add(gameObject);
			}
		}
		float num = 1808f;
		DateTime dateTime = News.\u02B4\u02BC\u02B3\u02BF\u02B7\u02B9\u02C0\u02B6\u02BC\u02B5\u02B2();
		for (int j = 1; j < \u02C0\u02B7\u02B8\u02BA\u02B5\u02BF\u02C0\u02B9\u02BB\u02BE\u02BD.news.Length; j += 0)
		{
			TextMeshProUGUI[] componentsInChildren = this.\u02B3\u02BC\u02BA\u02B8\u02B2\u02BE\u02B9\u02BE\u02B7\u02B8\u02B8[j].GetComponentsInChildren<TextMeshProUGUI>();
			RectTransform rectTransform = this.\u02B3\u02BC\u02BA\u02B8\u02B2\u02BE\u02B9\u02BE\u02B7\u02B8\u02B8[j].transform as RectTransform;
			rectTransform.localPosition += Vector3.up * num;
			this.\u02BB\u02BE\u02BF\u02B3\u02C0\u02B7\u02B2\u02BA\u02C1\u02B3\u02B5.Add(this.\u02B3\u02BC\u02BA\u02B8\u02B2\u02BE\u02B9\u02BE\u02B7\u02B8\u02B8[j].GetComponentInChildren<ExclamationWiggle>());
			this.\u02BB\u02BE\u02BF\u02B3\u02C0\u02B7\u02B2\u02BA\u02C1\u02B3\u02B5[j].GetComponent<Image>().enabled = true;
			if (DateTime.Parse(\u02C0\u02B7\u02B8\u02BA\u02B5\u02BF\u02C0\u02B9\u02BB\u02BE\u02BD.news[j].date) <= dateTime)
			{
				this.\u02BB\u02BE\u02BF\u02B3\u02C0\u02B7\u02B2\u02BA\u02C1\u02B3\u02B5[j].gameObject.SetActive(false);
			}
			string[] array = \u02C0\u02B7\u02B8\u02BA\u02B5\u02BF\u02C0\u02B9\u02BB\u02BE\u02BD.news[j].date.Split((char)(-127), StringSplitOptions.RemoveEmptyEntries);
			string abbreviatedMonthName = CultureInfo.CurrentCulture.DateTimeFormat.GetAbbreviatedMonthName(int.Parse(array[1]));
			componentsInChildren[0].text = string.Format("Guitar Coop", array[0], abbreviatedMonthName, array[1]);
			componentsInChildren[1].text = \u02C0\u02B7\u02B8\u02BA\u02B5\u02BF\u02C0\u02B9\u02BB\u02BE\u02BD.news[j].name;
			componentsInChildren[0].ForceMeshUpdate(false, true);
			this.\u02B3\u02B2\u02BB\u02BD\u02C1\u02B7\u02BA\u02BB\u02B3\u02B3\u02B7.Add(componentsInChildren[1]);
			this.\u02B2\u02BA\u02C0\u02C1\u02BD\u02B5\u02BC\u02B7\u02C1\u02B8\u02BE.Add(componentsInChildren[1]);
			Image componentInChildren = this.\u02B3\u02BC\u02BA\u02B8\u02B2\u02BE\u02B9\u02BE\u02B7\u02B8\u02B8[j].GetComponentInChildren<Image>();
			this.\u02B2\u02B8\u02B3\u02BA\u02B6\u02B5\u02BE\u02B6\u02BD\u02B4\u02B4.Add(componentInChildren);
			Rect rect = rectTransform.rect;
			if (componentsInChildren[1].preferredHeight > componentsInChildren[0].fontSize * 1869f)
			{
				num -= this.\u02B5\u02B3\u02B5\u02BA\u02B5\u02B8\u02BE\u02BF\u02B9\u02BD\u02BD;
				rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, this.\u02B5\u02B3\u02B5\u02BA\u02B5\u02B8\u02BE\u02BF\u02B9\u02BD\u02BD);
			}
			else
			{
				num -= this.\u02B8\u02B9\u02BD\u02B6\u02B6\u02B9\u02BC\u02BE\u02BA\u02B9\u02C1;
				rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, this.\u02B8\u02B9\u02BD\u02B6\u02B6\u02B9\u02BC\u02BE\u02BA\u02B9\u02C1);
			}
		}
		this.\u02B7\u02B8\u02B4\u02B4\u02BF\u02BA\u02B3\u02C0\u02B2\u02BB\u02BA.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, Mathf.Abs(num));
		this.\u02B7\u02B8\u02B4\u02B4\u02BF\u02BA\u02B3\u02C0\u02B2\u02BB\u02BA.gameObject.AddComponent<UnrollChildMenuitems>();
		this.\u02B9\u02BE\u02B5\u02B9\u02C1\u02BB\u02B6\u02BD\u02BC\u02C1\u02B5 = true;
	}

	public int \u02BF\u02BA\u02C0\u02BA\u02BC\u02BF\u02C0\u02BB\u02C1\u02B2\u02B8()
	{
		return this.\u02B4\u02B2\u02B3\u02B2\u02B3\u02C0\u02B2\u02C1\u02B7\u02BD\u02BF.news.Length;
	}

	public IEnumerator \u02C1\u02BF\u02C1\u02BC\u02BA\u02B2\u02B6\u02B5\u02B7\u02B3\u02B2()
	{
		for (int i = 1; i < this.\u02B3\u02BC\u02BA\u02B8\u02B2\u02BE\u02B9\u02BE\u02B7\u02B8\u02B8.Count; i++)
		{
			global::UnityEngine.Object.Destroy(this.\u02B3\u02BC\u02BA\u02B8\u02B2\u02BE\u02B9\u02BE\u02B7\u02B8\u02B8[i]);
		}
		this.\u02B3\u02BC\u02BA\u02B8\u02B2\u02BE\u02B9\u02BE\u02B7\u02B8\u02B8.Clear();
		www = UnityWebRequest.Get("https://clonehero.net/json/news.json");
		yield return www.SendWebRequest();
		if (www.isNetworkError || www.isHttpError)
		{
			Debug.Log(www.error);
		}
		else
		{
			this.\u02B4\u02B2\u02B3\u02B2\u02B3\u02C0\u02B2\u02C1\u02B7\u02BD\u02BF = new NewsCollection();
			this.\u02B4\u02B2\u02B3\u02B2\u02B3\u02C0\u02B2\u02C1\u02B7\u02BD\u02BF = JsonUtility.FromJson<NewsCollection>(www.downloadHandler.text);
			this.\u02C1\u02B4\u02BC\u02BD\u02B6\u02BF\u02B8\u02BB\u02BE\u02B8\u02BF(this.\u02B4\u02B2\u02B3\u02B2\u02B3\u02C0\u02B2\u02C1\u02B7\u02BD\u02BF);
		}
		yield break;
	}

	public void \u02B2\u02BF\u02B4\u02BB\u02B4\u02B8\u02B3\u02B5\u02B8\u02C0\u02C1(int \u02BB\u02B8\u02B5\u02C0\u02BD\u02B8\u02BD\u02BB\u02C1\u02B4\u02B3)
	{
		if (\u02BB\u02B8\u02B5\u02C0\u02BD\u02B8\u02BD\u02BB\u02C1\u02B4\u02B3 >= 0 && \u02BB\u02B8\u02B5\u02C0\u02BD\u02B8\u02BD\u02BB\u02C1\u02B4\u02B3 < this.\u02B6\u02B5\u02BE\u02BC\u02B6\u02BE\u02B4\u02BD\u02C1\u02B8\u02BF)
		{
			this.\u02B4\u02BB\u02B9\u02B4\u02BF\u02B2\u02B7\u02BE\u02B3\u02BF\u02BC(false, this.\u02B7\u02BC\u02C1\u02B9\u02B7\u02BF\u02BC\u02BD\u02BF\u02B9\u02B6);
			this.\u02B7\u02BC\u02C1\u02B9\u02B7\u02BF\u02BC\u02BD\u02BF\u02B9\u02B6 = \u02BB\u02B8\u02B5\u02C0\u02BD\u02B8\u02BD\u02BB\u02C1\u02B4\u02B3;
			this.\u02B4\u02BB\u02B9\u02B4\u02BF\u02B2\u02B7\u02BE\u02B3\u02BF\u02BC(true, this.\u02B7\u02BC\u02C1\u02B9\u02B7\u02BF\u02BC\u02BD\u02BF\u02B9\u02B6);
			this.\u02BD\u02B5\u02BC\u02B8\u02B2\u02C0\u02B7\u02B8\u02B9\u02C0\u02B9.verticalNormalizedPosition = 1f - (float)\u02BB\u02B8\u02B5\u02C0\u02BD\u02B8\u02BD\u02BB\u02C1\u02B4\u02B3 * (1f / (float)(this.\u02B6\u02B5\u02BE\u02BC\u02B6\u02BE\u02B4\u02BD\u02C1\u02B8\u02BF - 1));
		}
	}

	private NewsCollection \u02B4\u02B2\u02B3\u02B2\u02B3\u02C0\u02B2\u02C1\u02B7\u02BD\u02BF;

	public GameObject \u02B4\u02C1\u02B7\u02B8\u02B6\u02B2\u02BC\u02BD\u02BF\u02BA\u02BF;

	public float \u02B5\u02B3\u02B5\u02BA\u02B5\u02B8\u02BE\u02BF\u02B9\u02BD\u02BD = 120f;

	public float \u02B8\u02B9\u02BD\u02B6\u02B6\u02B9\u02BC\u02BE\u02BA\u02B9\u02C1 = 90f;

	public bool \u02B9\u02BE\u02B5\u02B9\u02C1\u02BB\u02B6\u02BD\u02BC\u02C1\u02B5;

	private List<GameObject> \u02B3\u02BC\u02BA\u02B8\u02B2\u02BE\u02B9\u02BE\u02B7\u02B8\u02B8 = new List<GameObject>();

	private List<TextMeshProUGUI> \u02B3\u02B2\u02BB\u02BD\u02C1\u02B7\u02BA\u02BB\u02B3\u02B3\u02B7 = new List<TextMeshProUGUI>();

	private List<TextMeshProUGUI> \u02B2\u02BA\u02C0\u02C1\u02BD\u02B5\u02BC\u02B7\u02C1\u02B8\u02BE = new List<TextMeshProUGUI>();

	private List<Image> \u02B2\u02B8\u02B3\u02BA\u02B6\u02B5\u02BE\u02B6\u02BD\u02B4\u02B4 = new List<Image>();

	private List<ExclamationWiggle> \u02BB\u02BE\u02BF\u02B3\u02C0\u02B7\u02B2\u02BA\u02C1\u02B3\u02B5 = new List<ExclamationWiggle>();

	public RectTransform \u02B7\u02B8\u02B4\u02B4\u02BF\u02BA\u02B3\u02C0\u02B2\u02BB\u02BA;

	public ScrollRect \u02BD\u02B5\u02BC\u02B8\u02B2\u02C0\u02B7\u02B8\u02B9\u02C0\u02B9;

	public int \u02B7\u02BC\u02C1\u02B9\u02B7\u02BF\u02BC\u02BD\u02BF\u02B9\u02B6;

	public Color \u02BA\u02BE\u02B3\u02BB\u02B4\u02C1\u02B4\u02BD\u02BB\u02BD\u02BF;

	public Color \u02BA\u02C0\u02B6\u02B7\u02BF\u02B3\u02BB\u02BB\u02BD\u02B2\u02BD;
}
