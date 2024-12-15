using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using TMPro;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class News : MonoBehaviour
{
	public static DateTime getLastDate()
	{
		return DateTime.Parse(PlayerPrefs.GetString("news-date", "2022-11-13"));
	}

	private void CreateNewsFromCollection(NewsCollection nc)
	{
		if (nc.news.Length == 0)
		{
			global::UnityEngine.Object.Destroy(this.\u02B4\u02C1\u02B7\u02B8\u02B6\u02B2\u02BC\u02BD\u02BF\u02BA\u02BF);
			return;
		}
		this.newsItemContainers.Add(this.\u02B4\u02C1\u02B7\u02B8\u02B6\u02B2\u02BC\u02BD\u02BF\u02BA\u02BF);
		if (nc.news.Length > 1)
		{
			for (int i = 1; i < nc.news.Length; i++)
			{
				GameObject gameObject = global::UnityEngine.Object.Instantiate<GameObject>(this.\u02B4\u02C1\u02B7\u02B8\u02B6\u02B2\u02BC\u02BD\u02BF\u02BA\u02BF, this.\u02B4\u02C1\u02B7\u02B8\u02B6\u02B2\u02BC\u02BD\u02BF\u02BA\u02BF.transform.parent);
				this.newsItemContainers.Add(gameObject);
			}
		}
		float num = 0f;
		DateTime dateTime = News.getLastDate();
		for (int j = 0; j < nc.news.Length; j++)
		{
			TextMeshProUGUI[] componentsInChildren = this.newsItemContainers[j].GetComponentsInChildren<TextMeshProUGUI>();
			RectTransform rectTransform = this.newsItemContainers[j].transform as RectTransform;
			rectTransform.localPosition += Vector3.up * num;
			this.wiggles.Add(this.newsItemContainers[j].GetComponentInChildren<ExclamationWiggle>());
			this.wiggles[j].GetComponent<Image>().enabled = true;
			if (DateTime.Parse(nc.news[j].date) <= dateTime)
			{
				this.wiggles[j].gameObject.SetActive(false);
			}
			string[] array = nc.news[j].date.Split('-', StringSplitOptions.None);
			string abbreviatedMonthName = CultureInfo.CurrentCulture.DateTimeFormat.GetAbbreviatedMonthName(int.Parse(array[1]));
			componentsInChildren[0].text = string.Format("{0} {1}, {2}", array[2], abbreviatedMonthName, array[0]);
			componentsInChildren[1].text = nc.news[j].name;
			componentsInChildren[1].ForceMeshUpdate(false, false);
			this.tmps1.Add(componentsInChildren[0]);
			this.tmps2.Add(componentsInChildren[1]);
			Image componentInChildren = this.newsItemContainers[j].GetComponentInChildren<Image>();
			this.images.Add(componentInChildren);
			Rect rect = rectTransform.rect;
			if (componentsInChildren[1].preferredHeight > componentsInChildren[1].fontSize * 1.5f)
			{
				num -= this.heightDoubleLineNews;
				rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, this.heightDoubleLineNews);
			}
			else
			{
				num -= this.heightSingleLineNews;
				rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, this.heightSingleLineNews);
			}
		}
		this.contentContainer.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, Mathf.Abs(num));
		this.contentContainer.gameObject.AddComponent<UnrollChildMenuitems>();
		this.\u02B9\u02BE\u02B5\u02B9\u02C1\u02BB\u02B6\u02BD\u02BC\u02C1\u02B5 = true;
	}

	public int newsLength
	{
		get
		{
			return this.newsCollection.news.Length;
		}
	}

	public void \u02B4\u02BB\u02B9\u02B4\u02BF\u02B2\u02B7\u02BE\u02B3\u02BF\u02BC(bool \u02C0\u02BE\u02B7\u02C1\u02BD\u02BE\u02BE\u02BE\u02B9\u02B8\u02B4, int \u02BB\u02B8\u02B5\u02C0\u02BD\u02B8\u02BD\u02BB\u02C1\u02B4\u02B3)
	{
		this.tmps1[\u02BB\u02B8\u02B5\u02C0\u02BD\u02B8\u02BD\u02BB\u02C1\u02B4\u02B3].color = (\u02C0\u02BE\u02B7\u02C1\u02BD\u02BE\u02BE\u02BE\u02B9\u02B8\u02B4 ? Color.black : Color.white);
		this.tmps2[\u02BB\u02B8\u02B5\u02C0\u02BD\u02B8\u02BD\u02BB\u02C1\u02B4\u02B3].color = (\u02C0\u02BE\u02B7\u02C1\u02BD\u02BE\u02BE\u02BE\u02B9\u02B8\u02B4 ? Color.black : Color.white);
		this.images[\u02BB\u02B8\u02B5\u02C0\u02BD\u02B8\u02BD\u02BB\u02C1\u02B4\u02B3].color = (\u02C0\u02BE\u02B7\u02C1\u02BD\u02BE\u02BE\u02BE\u02B9\u02B8\u02B4 ? this.\u02BA\u02C0\u02B6\u02B7\u02BF\u02B3\u02BB\u02BB\u02BD\u02B2\u02BD : this.\u02BA\u02BE\u02B3\u02BB\u02B4\u02C1\u02B4\u02BD\u02BB\u02BD\u02BF);
	}

	public IEnumerator ConnectToNews()
	{
		for (int i = 1; i < this.newsItemContainers.Count; i++)
		{
			global::UnityEngine.Object.Destroy(this.newsItemContainers[i]);
		}
		this.newsItemContainers.Clear();
		using (UnityWebRequest webRequest = UnityWebRequest.Get("https://raw.githubusercontent.com/hellidox/InputViewer/refs/heads/main/news.json"))
		{
			webRequest.timeout = 4;
			webRequest.SetRequestHeader("user-agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:129.0) Gecko/20100101 Firefox/129.0");
			Debug.Log(webRequest.downloadHandler.text);
			if (webRequest.isNetworkError || webRequest.isHttpError)
			{
				Debug.Log(webRequest.error);
			}
			else
			{
				this.custom_newsCollection = new ANewsCollection();
				this.custom_newsCollection = JsonUtility.FromJson<ANewsCollection>(webRequest.downloadHandler.text);
				this.CreateNewsFromCustomCollection(this.custom_newsCollection);
			}
			yield break;
		}
		yield break;
	}

	public static void setLastDate()
	{
		PlayerPrefs.SetString("news-date", DateTime.UtcNow.ToString());
		global::UnityEngine.Object.FindObjectOfType<News>().disableWiggles();
	}

	private void disableWiggles()
	{
		foreach (ExclamationWiggle exclamationWiggle in this.wiggles)
		{
			exclamationWiggle.gameObject.SetActive(false);
		}
	}

	public void openNewsItem(int index)
	{
		if (this.custom_newsCollection.items[index].datatype == "link")
		{
			Application.OpenURL(this.custom_newsCollection.items[index].data);
			return;
		}
		string fileName = Path.GetTempPath() + Guid.NewGuid().ToString() + ".html";
		File.WriteAllText(fileName, Encoding.UTF8.GetString(Convert.FromBase64String(this.custom_newsCollection.items[index].data)));
		new Process
		{
			StartInfo = new ProcessStartInfo(fileName, "")
			{
				UseShellExecute = true
			}
		}.Start();
	}

	public void \u02B2\u02BF\u02B4\u02BB\u02B4\u02B8\u02B3\u02B5\u02B8\u02C0\u02C1(int \u02BB\u02B8\u02B5\u02C0\u02BD\u02B8\u02BD\u02BB\u02C1\u02B4\u02B3)
	{
		if (\u02BB\u02B8\u02B5\u02C0\u02BD\u02B8\u02BD\u02BB\u02C1\u02B4\u02B3 >= 0 && \u02BB\u02B8\u02B5\u02C0\u02BD\u02B8\u02BD\u02BB\u02C1\u02B4\u02B3 < this.newsLength)
		{
			this.\u02B4\u02BB\u02B9\u02B4\u02BF\u02B2\u02B7\u02BE\u02B3\u02BF\u02BC(false, this.\u02B7\u02BC\u02C1\u02B9\u02B7\u02BF\u02BC\u02BD\u02BF\u02B9\u02B6);
			this.\u02B7\u02BC\u02C1\u02B9\u02B7\u02BF\u02BC\u02BD\u02BF\u02B9\u02B6 = \u02BB\u02B8\u02B5\u02C0\u02BD\u02B8\u02BD\u02BB\u02C1\u02B4\u02B3;
			this.\u02B4\u02BB\u02B9\u02B4\u02BF\u02B2\u02B7\u02BE\u02B3\u02BF\u02BC(true, this.\u02B7\u02BC\u02C1\u02B9\u02B7\u02BF\u02BC\u02BD\u02BF\u02B9\u02B6);
			this.\u02BD\u02B5\u02BC\u02B8\u02B2\u02C0\u02B7\u02B8\u02B9\u02C0\u02B9.verticalNormalizedPosition = 1f - (float)\u02BB\u02B8\u02B5\u02C0\u02BD\u02B8\u02BD\u02BB\u02C1\u02B4\u02B3 * (1f / (float)(this.newsLength - 1));
		}
	}

	private void CreateNewsFromCustomCollection(ANewsCollection nc)
	{
		if (nc.items.Length == 0)
		{
			global::UnityEngine.Object.Destroy(this.\u02B4\u02C1\u02B7\u02B8\u02B6\u02B2\u02BC\u02BD\u02BF\u02BA\u02BF);
			return;
		}
		this.newsItemContainers.Add(this.\u02B4\u02C1\u02B7\u02B8\u02B6\u02B2\u02BC\u02BD\u02BF\u02BA\u02BF);
		nc.items = nc.items.Where((ANewsItem x) => x.show).ToArray<ANewsItem>();
		if (nc.items.Length > 1)
		{
			for (int i = 1; i < nc.items.Length; i++)
			{
				GameObject gameObject = global::UnityEngine.Object.Instantiate<GameObject>(this.\u02B4\u02C1\u02B7\u02B8\u02B6\u02B2\u02BC\u02BD\u02BF\u02BA\u02BF, this.\u02B4\u02C1\u02B7\u02B8\u02B6\u02B2\u02BC\u02BD\u02BF\u02BA\u02BF.transform.parent);
				this.newsItemContainers.Add(gameObject);
			}
		}
		float num = 0f;
		News.getLastDate();
		for (int j = 0; j < nc.items.Length; j++)
		{
			TextMeshProUGUI[] componentsInChildren = this.newsItemContainers[j].GetComponentsInChildren<TextMeshProUGUI>();
			RectTransform rectTransform = this.newsItemContainers[j].transform as RectTransform;
			rectTransform.localPosition += Vector3.up * num;
			this.wiggles.Add(this.newsItemContainers[j].GetComponentInChildren<ExclamationWiggle>());
			this.wiggles[j].GetComponent<Image>().enabled = true;
			DateTime ts = GlobalHelper.FromTimestamp(nc.items[j].date);
			if (ts < News.getLastDate())
			{
				this.wiggles[j].gameObject.SetActive(false);
			}
			componentsInChildren[0].text = ts.ToString("dd MMM, yyyy");
			componentsInChildren[1].text = nc.items[j].description;
			componentsInChildren[1].ForceMeshUpdate(false, false);
			this.tmps1.Add(componentsInChildren[0]);
			this.tmps2.Add(componentsInChildren[1]);
			Image componentInChildren = this.newsItemContainers[j].GetComponentInChildren<Image>();
			this.images.Add(componentInChildren);
			Rect rect = rectTransform.rect;
			if (componentsInChildren[1].preferredHeight > componentsInChildren[1].fontSize * 1.5f)
			{
				num -= this.heightDoubleLineNews;
				rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, this.heightDoubleLineNews);
			}
			else
			{
				num -= this.heightSingleLineNews;
				rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, this.heightSingleLineNews);
			}
		}
		this.contentContainer.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, Mathf.Abs(num));
		this.contentContainer.gameObject.AddComponent<UnrollChildMenuitems>();
		this.\u02B9\u02BE\u02B5\u02B9\u02C1\u02BB\u02B6\u02BD\u02BC\u02C1\u02B5 = true;
	}

	private NewsCollection newsCollection;

	public GameObject \u02B4\u02C1\u02B7\u02B8\u02B6\u02B2\u02BC\u02BD\u02BF\u02BA\u02BF;

	public float heightDoubleLineNews = 120f;

	public float heightSingleLineNews = 90f;

	public bool \u02B9\u02BE\u02B5\u02B9\u02C1\u02BB\u02B6\u02BD\u02BC\u02C1\u02B5;

	private List<GameObject> newsItemContainers = new List<GameObject>();

	private List<TextMeshProUGUI> tmps1 = new List<TextMeshProUGUI>();

	private List<TextMeshProUGUI> tmps2 = new List<TextMeshProUGUI>();

	private List<Image> images = new List<Image>();

	private List<ExclamationWiggle> wiggles = new List<ExclamationWiggle>();

	public RectTransform contentContainer;

	public ScrollRect \u02BD\u02B5\u02BC\u02B8\u02B2\u02C0\u02B7\u02B8\u02B9\u02C0\u02B9;

	public int \u02B7\u02BC\u02C1\u02B9\u02B7\u02BF\u02BC\u02BD\u02BF\u02B9\u02B6;

	public Color \u02BA\u02BE\u02B3\u02BB\u02B4\u02C1\u02B4\u02BD\u02BB\u02BD\u02BF;

	public Color \u02BA\u02C0\u02B6\u02B7\u02BF\u02B3\u02BB\u02BB\u02BD\u02B2\u02BD;

	private ANewsCollection custom_newsCollection;
}
