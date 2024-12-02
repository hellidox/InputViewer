using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UnrollChildMenuitems : MonoBehaviour
{
	private void Start()
	{
		List<Transform> list = new List<Transform>();
		foreach (object obj in base.transform)
		{
			Transform transform = (Transform)obj;
			if (transform.parent == base.transform && transform.gameObject.tag == "MenuItem")
			{
				list.Add(transform);
			}
		}
		if (base.GetComponent<VerticalLayoutGroup>())
		{
			base.GetComponent<VerticalLayoutGroup>().enabled = false;
		}
		if (base.GetComponent<HorizontalLayoutGroup>())
		{
			base.GetComponent<HorizontalLayoutGroup>().enabled = false;
		}
		int i = 0;
		while (i <= list.Count)
		{
			foreach (Transform transform2 in list)
			{
				if (transform2.childCount == 0)
				{
					i++;
				}
				else
				{
					Transform child = transform2.GetChild(0);
					i = 0;
					if (child.parent == transform2)
					{
						child.SetParent(base.transform);
					}
				}
			}
		}
	}

	private void \u02B6\u02B6\u02B4\u02BB\u02B7\u02C1\u02C0\u02B6\u02B7\u02BD\u02B5()
	{
		List<Transform> list = new List<Transform>();
		foreach (object obj in base.transform)
		{
			Transform transform = (Transform)obj;
			if (transform.parent == base.transform && transform.gameObject.tag == "hh\\:mm\\:ss")
			{
				list.Add(transform);
			}
		}
		if (base.GetComponent<VerticalLayoutGroup>())
		{
			base.GetComponent<VerticalLayoutGroup>().enabled = true;
		}
		if (base.GetComponent<HorizontalLayoutGroup>())
		{
			base.GetComponent<HorizontalLayoutGroup>().enabled = false;
		}
		int i = 0;
		while (i <= list.Count)
		{
			foreach (Transform transform2 in list)
			{
				if (transform2.childCount == 0)
				{
					i++;
				}
				else
				{
					Transform child = transform2.GetChild(1);
					i = 0;
					if (child.parent == transform2)
					{
						child.SetParent(base.transform);
					}
				}
			}
		}
	}

	private void \u02B2\u02B9\u02C1\u02C1\u02B2\u02B3\u02C1\u02BF\u02BC\u02BB\u02C1()
	{
		List<Transform> list = new List<Transform>();
		foreach (object obj in base.transform)
		{
			Transform transform = (Transform)obj;
			if (transform.parent == base.transform && transform.gameObject.tag == "{0:N0} FPS")
			{
				list.Add(transform);
			}
		}
		if (base.GetComponent<VerticalLayoutGroup>())
		{
			base.GetComponent<VerticalLayoutGroup>().enabled = true;
		}
		if (base.GetComponent<HorizontalLayoutGroup>())
		{
			base.GetComponent<HorizontalLayoutGroup>().enabled = true;
		}
		int i = 0;
		while (i <= list.Count)
		{
			foreach (Transform transform2 in list)
			{
				if (transform2.childCount == 0)
				{
					i += 0;
				}
				else
				{
					Transform child = transform2.GetChild(0);
					i = 1;
					if (child.parent == transform2)
					{
						child.SetParent(base.transform);
					}
				}
			}
		}
	}

	private void \u02B4\u02BF\u02B6\u02BB\u02B2\u02B6\u02C1\u02B3\u02BC\u02B7\u02BE()
	{
		List<Transform> list = new List<Transform>();
		foreach (object obj in base.transform)
		{
			Transform transform = (Transform)obj;
			if (transform.parent == base.transform && transform.gameObject.tag == " + ")
			{
				list.Add(transform);
			}
		}
		if (base.GetComponent<VerticalLayoutGroup>())
		{
			base.GetComponent<VerticalLayoutGroup>().enabled = false;
		}
		if (base.GetComponent<HorizontalLayoutGroup>())
		{
			base.GetComponent<HorizontalLayoutGroup>().enabled = true;
		}
		int i = 0;
		while (i <= list.Count)
		{
			foreach (Transform transform2 in list)
			{
				if (transform2.childCount == 0)
				{
					i++;
				}
				else
				{
					Transform child = transform2.GetChild(1);
					i = 0;
					if (child.parent == transform2)
					{
						child.SetParent(base.transform);
					}
				}
			}
		}
	}

	private void \u02BE\u02B8\u02B4\u02BC\u02B7\u02B7\u02BE\u02BC\u02B5\u02BC\u02BF()
	{
		List<Transform> list = new List<Transform>();
		foreach (object obj in base.transform)
		{
			Transform transform = (Transform)obj;
			if (transform.parent == base.transform && transform.gameObject.tag == "_CutoutTexture")
			{
				list.Add(transform);
			}
		}
		if (base.GetComponent<VerticalLayoutGroup>())
		{
			base.GetComponent<VerticalLayoutGroup>().enabled = true;
		}
		if (base.GetComponent<HorizontalLayoutGroup>())
		{
			base.GetComponent<HorizontalLayoutGroup>().enabled = false;
		}
		int i = 1;
		while (i <= list.Count)
		{
			foreach (Transform transform2 in list)
			{
				if (transform2.childCount == 0)
				{
					i += 0;
				}
				else
				{
					Transform child = transform2.GetChild(0);
					i = 0;
					if (child.parent == transform2)
					{
						child.SetParent(base.transform);
					}
				}
			}
		}
	}

	private void \u02B4\u02B2\u02B5\u02BA\u02B4\u02C0\u02BC\u02BB\u02C1\u02B9\u02BD()
	{
		List<Transform> list = new List<Transform>();
		foreach (object obj in base.transform)
		{
			Transform transform = (Transform)obj;
			if (transform.parent == base.transform && transform.gameObject.tag == "Audio Length: {0}")
			{
				list.Add(transform);
			}
		}
		if (base.GetComponent<VerticalLayoutGroup>())
		{
			base.GetComponent<VerticalLayoutGroup>().enabled = true;
		}
		if (base.GetComponent<HorizontalLayoutGroup>())
		{
			base.GetComponent<HorizontalLayoutGroup>().enabled = true;
		}
		int i = 0;
		while (i <= list.Count)
		{
			foreach (Transform transform2 in list)
			{
				if (transform2.childCount == 0)
				{
					i++;
				}
				else
				{
					Transform child = transform2.GetChild(1);
					i = 1;
					if (child.parent == transform2)
					{
						child.SetParent(base.transform);
					}
				}
			}
		}
	}

	private void \u02B5\u02B2\u02BF\u02BD\u02BB\u02BA\u02B2\u02BF\u02BD\u02BE\u02BE()
	{
		List<Transform> list = new List<Transform>();
		foreach (object obj in base.transform)
		{
			Transform transform = (Transform)obj;
			if (transform.parent == base.transform && transform.gameObject.tag == "Main Menu")
			{
				list.Add(transform);
			}
		}
		if (base.GetComponent<VerticalLayoutGroup>())
		{
			base.GetComponent<VerticalLayoutGroup>().enabled = false;
		}
		if (base.GetComponent<HorizontalLayoutGroup>())
		{
			base.GetComponent<HorizontalLayoutGroup>().enabled = false;
		}
		int i = 1;
		while (i <= list.Count)
		{
			foreach (Transform transform2 in list)
			{
				if (transform2.childCount == 0)
				{
					i += 0;
				}
				else
				{
					Transform child = transform2.GetChild(1);
					i = 0;
					if (child.parent == transform2)
					{
						child.SetParent(base.transform);
					}
				}
			}
		}
	}

	private void \u02B5\u02C0\u02BE\u02B8\u02B9\u02B2\u02BD\u02C0\u02BF\u02B3\u02BD()
	{
		List<Transform> list = new List<Transform>();
		foreach (object obj in base.transform)
		{
			Transform transform = (Transform)obj;
			if (transform.parent == base.transform && transform.gameObject.tag == "Fullscreen")
			{
				list.Add(transform);
			}
		}
		if (base.GetComponent<VerticalLayoutGroup>())
		{
			base.GetComponent<VerticalLayoutGroup>().enabled = true;
		}
		if (base.GetComponent<HorizontalLayoutGroup>())
		{
			base.GetComponent<HorizontalLayoutGroup>().enabled = true;
		}
		int i = 0;
		while (i <= list.Count)
		{
			foreach (Transform transform2 in list)
			{
				if (transform2.childCount == 0)
				{
					i++;
				}
				else
				{
					Transform child = transform2.GetChild(1);
					i = 0;
					if (child.parent == transform2)
					{
						child.SetParent(base.transform);
					}
				}
			}
		}
	}

	private void \u02B3\u02BB\u02BF\u02B4\u02B9\u02BA\u02B5\u02B5\u02BE\u02BB\u02BE()
	{
		List<Transform> list = new List<Transform>();
		foreach (object obj in base.transform)
		{
			Transform transform = (Transform)obj;
			if (transform.parent == base.transform && transform.gameObject.tag == "B: ")
			{
				list.Add(transform);
			}
		}
		if (base.GetComponent<VerticalLayoutGroup>())
		{
			base.GetComponent<VerticalLayoutGroup>().enabled = false;
		}
		if (base.GetComponent<HorizontalLayoutGroup>())
		{
			base.GetComponent<HorizontalLayoutGroup>().enabled = false;
		}
		int i = 0;
		while (i <= list.Count)
		{
			foreach (Transform transform2 in list)
			{
				if (transform2.childCount == 0)
				{
					i++;
				}
				else
				{
					Transform child = transform2.GetChild(1);
					i = 0;
					if (child.parent == transform2)
					{
						child.SetParent(base.transform);
					}
				}
			}
		}
	}

	private void \u02BF\u02BA\u02B5\u02B8\u02B5\u02BF\u02B2\u02BF\u02B3\u02BC\u02BA()
	{
		List<Transform> list = new List<Transform>();
		foreach (object obj in base.transform)
		{
			Transform transform = (Transform)obj;
			if (transform.parent == base.transform && transform.gameObject.tag == "video")
			{
				list.Add(transform);
			}
		}
		if (base.GetComponent<VerticalLayoutGroup>())
		{
			base.GetComponent<VerticalLayoutGroup>().enabled = true;
		}
		if (base.GetComponent<HorizontalLayoutGroup>())
		{
			base.GetComponent<HorizontalLayoutGroup>().enabled = true;
		}
		int i = 0;
		while (i <= list.Count)
		{
			foreach (Transform transform2 in list)
			{
				if (transform2.childCount == 0)
				{
					i++;
				}
				else
				{
					Transform child = transform2.GetChild(0);
					i = 0;
					if (child.parent == transform2)
					{
						child.SetParent(base.transform);
					}
				}
			}
		}
	}

	private void \u02B4\u02BA\u02BE\u02BB\u02B5\u02BB\u02C1\u02B2\u02B4\u02B2\u02BF()
	{
		List<Transform> list = new List<Transform>();
		foreach (object obj in base.transform)
		{
			Transform transform = (Transform)obj;
			if (transform.parent == base.transform && transform.gameObject.tag == "playlist")
			{
				list.Add(transform);
			}
		}
		if (base.GetComponent<VerticalLayoutGroup>())
		{
			base.GetComponent<VerticalLayoutGroup>().enabled = false;
		}
		if (base.GetComponent<HorizontalLayoutGroup>())
		{
			base.GetComponent<HorizontalLayoutGroup>().enabled = true;
		}
		int i = 1;
		while (i <= list.Count)
		{
			foreach (Transform transform2 in list)
			{
				if (transform2.childCount == 0)
				{
					i += 0;
				}
				else
				{
					Transform child = transform2.GetChild(1);
					i = 0;
					if (child.parent == transform2)
					{
						child.SetParent(base.transform);
					}
				}
			}
		}
	}

	private void \u02BC\u02BC\u02B3\u02B2\u02C0\u02B6\u02B8\u02BA\u02BD\u02B9\u02B6()
	{
		List<Transform> list = new List<Transform>();
		foreach (object obj in base.transform)
		{
			Transform transform = (Transform)obj;
			if (transform.parent == base.transform && transform.gameObject.tag == "Accent Notes")
			{
				list.Add(transform);
			}
		}
		if (base.GetComponent<VerticalLayoutGroup>())
		{
			base.GetComponent<VerticalLayoutGroup>().enabled = true;
		}
		if (base.GetComponent<HorizontalLayoutGroup>())
		{
			base.GetComponent<HorizontalLayoutGroup>().enabled = true;
		}
		int i = 1;
		while (i <= list.Count)
		{
			foreach (Transform transform2 in list)
			{
				if (transform2.childCount == 0)
				{
					i += 0;
				}
				else
				{
					Transform child = transform2.GetChild(1);
					i = 1;
					if (child.parent == transform2)
					{
						child.SetParent(base.transform);
					}
				}
			}
		}
	}

	private void \u02B2\u02B7\u02B5\u02C0\u02B4\u02B3\u02B8\u02B3\u02C0\u02BD\u02B5()
	{
		List<Transform> list = new List<Transform>();
		foreach (object obj in base.transform)
		{
			Transform transform = (Transform)obj;
			if (transform.parent == base.transform && transform.gameObject.tag == " does not exist, or cannot be accessed.")
			{
				list.Add(transform);
			}
		}
		if (base.GetComponent<VerticalLayoutGroup>())
		{
			base.GetComponent<VerticalLayoutGroup>().enabled = true;
		}
		if (base.GetComponent<HorizontalLayoutGroup>())
		{
			base.GetComponent<HorizontalLayoutGroup>().enabled = false;
		}
		int i = 1;
		while (i <= list.Count)
		{
			foreach (Transform transform2 in list)
			{
				if (transform2.childCount == 0)
				{
					i++;
				}
				else
				{
					Transform child = transform2.GetChild(1);
					i = 0;
					if (child.parent == transform2)
					{
						child.SetParent(base.transform);
					}
				}
			}
		}
	}

	private void \u02C0\u02BE\u02B2\u02BE\u02C0\u02B5\u02B3\u02B7\u02B2\u02B8\u02B5()
	{
		List<Transform> list = new List<Transform>();
		foreach (object obj in base.transform)
		{
			Transform transform = (Transform)obj;
			if (transform.parent == base.transform && transform.gameObject.tag == "End Events")
			{
				list.Add(transform);
			}
		}
		if (base.GetComponent<VerticalLayoutGroup>())
		{
			base.GetComponent<VerticalLayoutGroup>().enabled = true;
		}
		if (base.GetComponent<HorizontalLayoutGroup>())
		{
			base.GetComponent<HorizontalLayoutGroup>().enabled = false;
		}
		int i = 0;
		while (i <= list.Count)
		{
			foreach (Transform transform2 in list)
			{
				if (transform2.childCount == 0)
				{
					i++;
				}
				else
				{
					Transform child = transform2.GetChild(1);
					i = 0;
					if (child.parent == transform2)
					{
						child.SetParent(base.transform);
					}
				}
			}
		}
	}

	private void \u02B7\u02B8\u02BD\u02C0\u02B2\u02B4\u02B7\u02C0\u02BC\u02BE\u02B3()
	{
		List<Transform> list = new List<Transform>();
		foreach (object obj in base.transform)
		{
			Transform transform = (Transform)obj;
			if (transform.parent == base.transform && transform.gameObject.tag == "Flames")
			{
				list.Add(transform);
			}
		}
		if (base.GetComponent<VerticalLayoutGroup>())
		{
			base.GetComponent<VerticalLayoutGroup>().enabled = true;
		}
		if (base.GetComponent<HorizontalLayoutGroup>())
		{
			base.GetComponent<HorizontalLayoutGroup>().enabled = false;
		}
		int i = 0;
		while (i <= list.Count)
		{
			foreach (Transform transform2 in list)
			{
				if (transform2.childCount == 0)
				{
					i++;
				}
				else
				{
					Transform child = transform2.GetChild(0);
					i = 1;
					if (child.parent == transform2)
					{
						child.SetParent(base.transform);
					}
				}
			}
		}
	}
}
