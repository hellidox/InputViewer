using System;
using System.Collections.Generic;
using UnityEngine;

public class LatencySpreadDisplay : MonoBehaviour
{
	private void \u02B8\u02BF\u02B8\u02B6\u02C0\u02C0\u02C1\u02BE\u02BC\u02B4\u02BC()
	{
		this.\u02BF\u02B9\u02C1\u02BE\u02B4\u02BE\u02BE\u02B7\u02C1\u02B8\u02B3 = new List<GameObject>();
	}

	public void \u02BF\u02B7\u02BC\u02C1\u02B8\u02BD\u02BA\u02BC\u02BD\u02BD\u02BC()
	{
		foreach (GameObject gameObject in this.\u02BF\u02B9\u02C1\u02BE\u02B4\u02BE\u02BE\u02B7\u02C1\u02B8\u02B3)
		{
			global::UnityEngine.Object.Destroy(gameObject);
		}
		this.\u02BF\u02B9\u02C1\u02BE\u02B4\u02BE\u02BE\u02B7\u02C1\u02B8\u02B3.Clear();
	}

	public void \u02BA\u02C1\u02BF\u02B6\u02B6\u02B4\u02B9\u02BD\u02B7\u02BF\u02C1(float \u02B2\u02B6\u02B9\u02B8\u02BF\u02BD\u02BF\u02BA\u02B9\u02C1\u02B5)
	{
		GameObject gameObject = global::UnityEngine.Object.Instantiate<GameObject>(this.samplePrefab);
		gameObject.transform.SetParent(base.transform);
		gameObject.transform.localPosition = new Vector2(\u02B2\u02B6\u02B9\u02B8\u02BF\u02BD\u02BF\u02BA\u02B9\u02C1\u02B5 * this.\u02B5\u02B9\u02B6\u02BB\u02B3\u02B3\u02B8\u02BB\u02B8\u02BF\u02B6, 271f);
		this.\u02BF\u02B9\u02C1\u02BE\u02B4\u02BE\u02BE\u02B7\u02C1\u02B8\u02B3.Add(gameObject);
	}

	public void \u02C1\u02B5\u02B5\u02B7\u02BE\u02B6\u02C0\u02B4\u02B9\u02BC\u02BA()
	{
		foreach (GameObject gameObject in this.\u02BF\u02B9\u02C1\u02BE\u02B4\u02BE\u02BE\u02B7\u02C1\u02B8\u02B3)
		{
			global::UnityEngine.Object.Destroy(gameObject);
		}
		this.\u02BF\u02B9\u02C1\u02BE\u02B4\u02BE\u02BE\u02B7\u02C1\u02B8\u02B3.Clear();
	}

	private void Awake()
	{
		this.\u02BF\u02B9\u02C1\u02BE\u02B4\u02BE\u02BE\u02B7\u02C1\u02B8\u02B3 = new List<GameObject>();
	}

	public void \u02BE\u02C1\u02B9\u02B7\u02B9\u02B2\u02B2\u02BF\u02C0\u02BC\u02B9()
	{
		foreach (GameObject gameObject in this.\u02BF\u02B9\u02C1\u02BE\u02B4\u02BE\u02BE\u02B7\u02C1\u02B8\u02B3)
		{
			global::UnityEngine.Object.Destroy(gameObject);
		}
		this.\u02BF\u02B9\u02C1\u02BE\u02B4\u02BE\u02BE\u02B7\u02C1\u02B8\u02B3.Clear();
	}

	public void \u02BC\u02BB\u02BA\u02B3\u02C1\u02BC\u02BD\u02B8\u02C0\u02B7\u02B6(float \u02B2\u02B6\u02B9\u02B8\u02BF\u02BD\u02BF\u02BA\u02B9\u02C1\u02B5)
	{
		GameObject gameObject = global::UnityEngine.Object.Instantiate<GameObject>(this.samplePrefab);
		gameObject.transform.SetParent(base.transform);
		gameObject.transform.localPosition = new Vector2(\u02B2\u02B6\u02B9\u02B8\u02BF\u02BD\u02BF\u02BA\u02B9\u02C1\u02B5 * this.\u02B5\u02B9\u02B6\u02BB\u02B3\u02B3\u02B8\u02BB\u02B8\u02BF\u02B6, 60f);
		this.\u02BF\u02B9\u02C1\u02BE\u02B4\u02BE\u02BE\u02B7\u02C1\u02B8\u02B3.Add(gameObject);
	}

	public void \u02BC\u02BF\u02C1\u02BA\u02BE\u02BC\u02BD\u02BE\u02B3\u02BB\u02C1(float \u02B2\u02B6\u02B9\u02B8\u02BF\u02BD\u02BF\u02BA\u02B9\u02C1\u02B5)
	{
		GameObject gameObject = global::UnityEngine.Object.Instantiate<GameObject>(this.samplePrefab);
		gameObject.transform.SetParent(base.transform);
		gameObject.transform.localPosition = new Vector2(\u02B2\u02B6\u02B9\u02B8\u02BF\u02BD\u02BF\u02BA\u02B9\u02C1\u02B5 * this.\u02B5\u02B9\u02B6\u02BB\u02B3\u02B3\u02B8\u02BB\u02B8\u02BF\u02B6, 0f);
		this.\u02BF\u02B9\u02C1\u02BE\u02B4\u02BE\u02BE\u02B7\u02C1\u02B8\u02B3.Add(gameObject);
	}

	public void \u02B8\u02B5\u02BA\u02BE\u02BD\u02BF\u02BD\u02B6\u02B6\u02B8\u02C1(float \u02B2\u02B6\u02B9\u02B8\u02BF\u02BD\u02BF\u02BA\u02B9\u02C1\u02B5)
	{
		GameObject gameObject = global::UnityEngine.Object.Instantiate<GameObject>(this.samplePrefab);
		gameObject.transform.SetParent(base.transform);
		gameObject.transform.localPosition = new Vector2(\u02B2\u02B6\u02B9\u02B8\u02BF\u02BD\u02BF\u02BA\u02B9\u02C1\u02B5 * this.\u02B5\u02B9\u02B6\u02BB\u02B3\u02B3\u02B8\u02BB\u02B8\u02BF\u02B6, 734f);
		this.\u02BF\u02B9\u02C1\u02BE\u02B4\u02BE\u02BE\u02B7\u02C1\u02B8\u02B3.Add(gameObject);
	}

	public void \u02B7\u02B6\u02B8\u02BD\u02BD\u02BA\u02B8\u02B3\u02BB\u02B3\u02B6()
	{
		foreach (GameObject gameObject in this.\u02BF\u02B9\u02C1\u02BE\u02B4\u02BE\u02BE\u02B7\u02C1\u02B8\u02B3)
		{
			global::UnityEngine.Object.Destroy(gameObject);
		}
		this.\u02BF\u02B9\u02C1\u02BE\u02B4\u02BE\u02BE\u02B7\u02C1\u02B8\u02B3.Clear();
	}

	public void \u02B4\u02B2\u02B2\u02BF\u02B5\u02BE\u02B7\u02BF\u02B6\u02B3\u02BB()
	{
		foreach (GameObject gameObject in this.\u02BF\u02B9\u02C1\u02BE\u02B4\u02BE\u02BE\u02B7\u02C1\u02B8\u02B3)
		{
			global::UnityEngine.Object.Destroy(gameObject);
		}
		this.\u02BF\u02B9\u02C1\u02BE\u02B4\u02BE\u02BE\u02B7\u02C1\u02B8\u02B3.Clear();
	}

	public void \u02C1\u02C1\u02BA\u02BC\u02BE\u02B6\u02BB\u02B2\u02BC\u02C1\u02BD()
	{
		foreach (GameObject gameObject in this.\u02BF\u02B9\u02C1\u02BE\u02B4\u02BE\u02BE\u02B7\u02C1\u02B8\u02B3)
		{
			global::UnityEngine.Object.Destroy(gameObject);
		}
		this.\u02BF\u02B9\u02C1\u02BE\u02B4\u02BE\u02BE\u02B7\u02C1\u02B8\u02B3.Clear();
	}

	private void \u02B5\u02BD\u02BD\u02BE\u02B9\u02BD\u02B2\u02C1\u02C1\u02B3\u02B6()
	{
		this.\u02BF\u02B9\u02C1\u02BE\u02B4\u02BE\u02BE\u02B7\u02C1\u02B8\u02B3 = new List<GameObject>();
	}

	public void \u02B4\u02BD\u02B3\u02B2\u02B8\u02B6\u02C1\u02B3\u02B4\u02BD\u02BB(float \u02B2\u02B6\u02B9\u02B8\u02BF\u02BD\u02BF\u02BA\u02B9\u02C1\u02B5)
	{
		GameObject gameObject = global::UnityEngine.Object.Instantiate<GameObject>(this.samplePrefab);
		gameObject.transform.SetParent(base.transform);
		gameObject.transform.localPosition = new Vector2(\u02B2\u02B6\u02B9\u02B8\u02BF\u02BD\u02BF\u02BA\u02B9\u02C1\u02B5 * this.\u02B5\u02B9\u02B6\u02BB\u02B3\u02B3\u02B8\u02BB\u02B8\u02BF\u02B6, 1384f);
		this.\u02BF\u02B9\u02C1\u02BE\u02B4\u02BE\u02BE\u02B7\u02C1\u02B8\u02B3.Add(gameObject);
	}

	public void \u02B5\u02B7\u02B8\u02BF\u02BD\u02B3\u02B5\u02B9\u02BA\u02B8\u02B7()
	{
		foreach (GameObject gameObject in this.\u02BF\u02B9\u02C1\u02BE\u02B4\u02BE\u02BE\u02B7\u02C1\u02B8\u02B3)
		{
			global::UnityEngine.Object.Destroy(gameObject);
		}
		this.\u02BF\u02B9\u02C1\u02BE\u02B4\u02BE\u02BE\u02B7\u02C1\u02B8\u02B3.Clear();
	}

	public void \u02B3\u02B5\u02BC\u02B6\u02B3\u02BB\u02C1\u02BB\u02C1\u02BF\u02BC()
	{
		foreach (GameObject gameObject in this.\u02BF\u02B9\u02C1\u02BE\u02B4\u02BE\u02BE\u02B7\u02C1\u02B8\u02B3)
		{
			global::UnityEngine.Object.Destroy(gameObject);
		}
		this.\u02BF\u02B9\u02C1\u02BE\u02B4\u02BE\u02BE\u02B7\u02C1\u02B8\u02B3.Clear();
	}

	public void \u02BA\u02B9\u02BA\u02C1\u02B7\u02BA\u02B2\u02B4\u02B5\u02B6\u02B4(float \u02B2\u02B6\u02B9\u02B8\u02BF\u02BD\u02BF\u02BA\u02B9\u02C1\u02B5)
	{
		GameObject gameObject = global::UnityEngine.Object.Instantiate<GameObject>(this.samplePrefab);
		gameObject.transform.SetParent(base.transform);
		gameObject.transform.localPosition = new Vector2(\u02B2\u02B6\u02B9\u02B8\u02BF\u02BD\u02BF\u02BA\u02B9\u02C1\u02B5 * this.\u02B5\u02B9\u02B6\u02BB\u02B3\u02B3\u02B8\u02BB\u02B8\u02BF\u02B6, 1396f);
		this.\u02BF\u02B9\u02C1\u02BE\u02B4\u02BE\u02BE\u02B7\u02C1\u02B8\u02B3.Add(gameObject);
	}

	public void \u02B7\u02C0\u02BB\u02B5\u02B8\u02BB\u02C0\u02BC\u02B5\u02BF\u02B4(float \u02B2\u02B6\u02B9\u02B8\u02BF\u02BD\u02BF\u02BA\u02B9\u02C1\u02B5)
	{
		GameObject gameObject = global::UnityEngine.Object.Instantiate<GameObject>(this.samplePrefab);
		gameObject.transform.SetParent(base.transform);
		gameObject.transform.localPosition = new Vector2(\u02B2\u02B6\u02B9\u02B8\u02BF\u02BD\u02BF\u02BA\u02B9\u02C1\u02B5 * this.\u02B5\u02B9\u02B6\u02BB\u02B3\u02B3\u02B8\u02BB\u02B8\u02BF\u02B6, 875f);
		this.\u02BF\u02B9\u02C1\u02BE\u02B4\u02BE\u02BE\u02B7\u02C1\u02B8\u02B3.Add(gameObject);
	}

	private void \u02B9\u02BD\u02B5\u02C1\u02B6\u02B6\u02BD\u02B9\u02BC\u02C1\u02B3()
	{
		this.\u02BF\u02B9\u02C1\u02BE\u02B4\u02BE\u02BE\u02B7\u02C1\u02B8\u02B3 = new List<GameObject>();
	}

	private void \u02BF\u02BC\u02B9\u02BE\u02B7\u02BD\u02C1\u02BE\u02BD\u02BD\u02B5()
	{
		this.\u02BF\u02B9\u02C1\u02BE\u02B4\u02BE\u02BE\u02B7\u02C1\u02B8\u02B3 = new List<GameObject>();
	}

	private void \u02B3\u02B8\u02C1\u02BE\u02B7\u02C0\u02B8\u02B8\u02B3\u02B3\u02B7()
	{
		this.\u02BF\u02B9\u02C1\u02BE\u02B4\u02BE\u02BE\u02B7\u02C1\u02B8\u02B3 = new List<GameObject>();
	}

	public void \u02B9\u02BD\u02B2\u02B6\u02B5\u02B2\u02C1\u02B4\u02B7\u02B5\u02B3()
	{
		foreach (GameObject gameObject in this.\u02BF\u02B9\u02C1\u02BE\u02B4\u02BE\u02BE\u02B7\u02C1\u02B8\u02B3)
		{
			global::UnityEngine.Object.Destroy(gameObject);
		}
		this.\u02BF\u02B9\u02C1\u02BE\u02B4\u02BE\u02BE\u02B7\u02C1\u02B8\u02B3.Clear();
	}

	[SerializeField]
	private GameObject samplePrefab;

	[SerializeField]
	private float maxTime = 1f;

	private List<GameObject> \u02BF\u02B9\u02C1\u02BE\u02B4\u02BE\u02BE\u02B7\u02C1\u02B8\u02B3;

	private float \u02B5\u02B9\u02B6\u02BB\u02B3\u02B3\u02B8\u02BB\u02B8\u02BF\u02B6 = 128f;
}
