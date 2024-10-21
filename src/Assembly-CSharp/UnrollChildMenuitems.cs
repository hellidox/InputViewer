using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x0200021D RID: 541
public class UnrollChildMenuitems : MonoBehaviour
{
	// Token: 0x0600186D RID: 6253 RVA: 0x000B4190 File Offset: 0x000B2390
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

	// Token: 0x0600186E RID: 6254 RVA: 0x000B42CC File Offset: 0x000B24CC
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

	// Token: 0x0600186F RID: 6255 RVA: 0x000B4408 File Offset: 0x000B2608
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

	// Token: 0x06001870 RID: 6256 RVA: 0x000B4544 File Offset: 0x000B2744
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

	// Token: 0x06001871 RID: 6257 RVA: 0x000B4680 File Offset: 0x000B2880
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

	// Token: 0x06001872 RID: 6258 RVA: 0x000B47BC File Offset: 0x000B29BC
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

	// Token: 0x06001873 RID: 6259 RVA: 0x000B48F8 File Offset: 0x000B2AF8
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

	// Token: 0x06001874 RID: 6260 RVA: 0x000B4A34 File Offset: 0x000B2C34
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

	// Token: 0x06001875 RID: 6261 RVA: 0x000B4B70 File Offset: 0x000B2D70
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

	// Token: 0x06001876 RID: 6262 RVA: 0x000B4CAC File Offset: 0x000B2EAC
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

	// Token: 0x06001877 RID: 6263 RVA: 0x000B4DE8 File Offset: 0x000B2FE8
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

	// Token: 0x06001878 RID: 6264 RVA: 0x000B4F24 File Offset: 0x000B3124
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

	// Token: 0x06001879 RID: 6265 RVA: 0x000B5060 File Offset: 0x000B3260
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

	// Token: 0x0600187A RID: 6266 RVA: 0x000B519C File Offset: 0x000B339C
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

	// Token: 0x0600187B RID: 6267 RVA: 0x000B52D8 File Offset: 0x000B34D8
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
