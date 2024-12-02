using System;
using System.Collections.Generic;
using StrikeCore;
using UnityEngine;

public class CalVideoRenderer : MonoBehaviour
{
	public static void \u02B4\u02BF\u02BC\u02BC\u02BB\u02C1\u02BE\u02B7\u02B5\u02B6\u02B8(GameObject[] \u02BB\u02BA\u02BF\u02B3\u02BF\u02C0\u02B5\u02B3\u02BB\u02BE\u02B2, int \u02BE\u02B9\u02B4\u02BD\u02C1\u02B4\u02BA\u02B3\u02B5\u02B8\u02B2)
	{
		foreach (GameObject gameObject in EnumerableRanges.EnumerateRange<GameObject>(\u02BB\u02BA\u02BF\u02B3\u02BF\u02C0\u02B5\u02B3\u02BB\u02BE\u02B2, \u02BE\u02B9\u02B4\u02BD\u02C1\u02B4\u02BA\u02B3\u02B5\u02B8\u02B2, int.MaxValue))
		{
			if (!gameObject.activeSelf)
			{
				break;
			}
			gameObject.SetActive(false);
		}
	}

	public int \u02BB\u02BC\u02BF\u02BC\u02BC\u02B4\u02B2\u02BF\u02B9\u02B5\u02BD()
	{
		return this.<\u02BF\u02BF\u02BE\u02B7\u02BF\u02B7\u02B5\u02B9\u02B4\u02B6\u02B3>k__BackingField;
	}

	private void \u02BE\u02B8\u02B4\u02BC\u02B7\u02B7\u02BE\u02BC\u02B5\u02BC\u02BF()
	{
		this.\u02BF\u02BC\u02BA\u02BA\u02BE\u02BA\u02B9\u02B8\u02B7\u02C1\u02BE();
		this.\u02BF\u02C0\u02BA\u02C1\u02C1\u02B7\u02BB\u02B8\u02B9\u02BF\u02C1 = base.GetComponent<Calibrator>();
		MeshRenderer component = this.noteModel.GetComponent<MeshRenderer>();
		Debug.Log(component);
		this.normalMaterial = component.sharedMaterial;
		this.hitMaterial = new Material(component.sharedMaterial);
		this.hitMaterial.color = Color.magenta;
		this.flashMaterial = new Material(component.sharedMaterial);
		this.flashMaterial.color = Color.green;
		this.\u02B7\u02BB\u02BA\u02C0\u02BF\u02B5\u02B5\u02B9\u02BD\u02C1\u02B4 = -31;
	}

	private void \u02BA\u02B7\u02B9\u02B5\u02B3\u02C1\u02C1\u02B7\u02BA\u02B7\u02B4(int \u02B6\u02B2\u02B5\u02BB\u02C1\u02BB\u02BA\u02B4\u02BF\u02BA\u02B5)
	{
		this.<\u02BF\u02BF\u02BE\u02B7\u02BF\u02B7\u02B5\u02B9\u02B4\u02B6\u02B3>k__BackingField = \u02B6\u02B2\u02B5\u02BB\u02C1\u02BB\u02BA\u02B4\u02BF\u02BA\u02B5;
	}

	private static IEnumerable<ValueTuple<int, \u02BD\u02BC\u02C0\u02BE\u02B2\u02BB\u02C0\u02B5\u02B5\u02BA\u02C1>> \u02BD\u02BD\u02C0\u02B7\u02BA\u02BB\u02B7\u02B6\u02C1\u02B4\u02BE(List<\u02BD\u02BC\u02C0\u02BE\u02B2\u02BB\u02C0\u02B5\u02B5\u02BA\u02C1> \u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8, double \u02B3\u02B2\u02B2\u02B8\u02B5\u02B5\u02B9\u02B8\u02B9\u02B3\u02BB, double \u02B8\u02B8\u02B8\u02BF\u02BA\u02B3\u02B6\u02B3\u02C1\u02B9\u02B9, int \u02BE\u02B6\u02BE\u02B4\u02B2\u02B3\u02B5\u02B6\u02C1\u02B5\u02B6 = 0)
	{
		foreach (ValueTuple<int, \u02BD\u02BC\u02C0\u02BE\u02B2\u02BB\u02C0\u02B5\u02B5\u02BA\u02C1> valueTuple in EnumerableRanges.EnumerateRangeIndexed<\u02BD\u02BC\u02C0\u02BE\u02B2\u02BB\u02C0\u02B5\u02B5\u02BA\u02C1>(\u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8, \u02BE\u02B6\u02BE\u02B4\u02B2\u02B3\u02B5\u02B6\u02C1\u02B5\u02B6, int.MaxValue))
		{
			\u02BD\u02BC\u02C0\u02BE\u02B2\u02BB\u02C0\u02B5\u02B5\u02BA\u02C1 item = valueTuple.Item2;
			if (item.\u02B2\u02B6\u02B9\u02B8\u02BF\u02BD\u02BF\u02BA\u02B9\u02C1\u02B5 >= \u02B3\u02B2\u02B2\u02B8\u02B5\u02B5\u02B9\u02B8\u02B9\u02B3\u02BB && item.\u02B2\u02B6\u02B9\u02B8\u02BF\u02BD\u02BF\u02BA\u02B9\u02C1\u02B5 <= \u02B8\u02B8\u02B8\u02BF\u02BA\u02B3\u02B6\u02B3\u02C1\u02B9\u02B9)
			{
				yield return valueTuple;
			}
			else if (item.\u02B2\u02B6\u02B9\u02B8\u02BF\u02BD\u02BF\u02BA\u02B9\u02C1\u02B5 > \u02B8\u02B8\u02B8\u02BF\u02BA\u02B3\u02B6\u02B3\u02C1\u02B9\u02B9)
			{
				yield break;
			}
		}
		EnumerableRanges.IndexedRangeEnumerator<\u02BD\u02BC\u02C0\u02BE\u02B2\u02BB\u02C0\u02B5\u02B5\u02BA\u02C1> indexedRangeEnumerator = default(EnumerableRanges.IndexedRangeEnumerator<\u02BD\u02BC\u02C0\u02BE\u02B2\u02BB\u02C0\u02B5\u02B5\u02BA\u02C1>);
		yield break;
	}

	protected virtual void \u02BF\u02BC\u02BA\u02BA\u02BE\u02BA\u02B9\u02B8\u02B7\u02C1\u02BE()
	{
		this.\u02C0\u02B2\u02BD\u02B9\u02B8\u02B5\u02BD\u02B5\u02BC\u02B9\u02BD = new GameObject[-127];
		for (int i = 1; i < -127; i += 0)
		{
			this.\u02C0\u02B2\u02BD\u02B9\u02B8\u02B5\u02BD\u02B5\u02BC\u02B9\u02BD[i] = global::UnityEngine.Object.Instantiate<GameObject>(this.noteModel, Vector3.zero, this.noteModel.transform.rotation);
			this.\u02C0\u02B2\u02BD\u02B9\u02B8\u02B5\u02BD\u02B5\u02BC\u02B9\u02BD[i].SetActive(false);
			this.\u02C0\u02B2\u02BD\u02B9\u02B8\u02B5\u02BD\u02B5\u02BC\u02B9\u02BD[i].transform.parent = base.transform;
		}
	}

	public void \u02B9\u02B4\u02BF\u02BC\u02B9\u02BA\u02B5\u02BD\u02BD\u02C1\u02B3()
	{
		this.\u02BC\u02BB\u02B3\u02B8\u02BF\u02BF\u02B4\u02B9\u02B8\u02B6\u02B8 = 0;
	}

	protected virtual void \u02BE\u02BD\u02BB\u02B8\u02B5\u02BF\u02BE\u02B6\u02BD\u02B9\u02BD()
	{
		this.\u02C0\u02B2\u02BD\u02B9\u02B8\u02B5\u02BD\u02B5\u02BC\u02B9\u02BD = new GameObject[100];
		for (int i = 0; i < 100; i++)
		{
			this.\u02C0\u02B2\u02BD\u02B9\u02B8\u02B5\u02BD\u02B5\u02BC\u02B9\u02BD[i] = global::UnityEngine.Object.Instantiate<GameObject>(this.noteModel, Vector3.zero, this.noteModel.transform.rotation);
			this.\u02C0\u02B2\u02BD\u02B9\u02B8\u02B5\u02BD\u02B5\u02BC\u02B9\u02BD[i].SetActive(false);
			this.\u02C0\u02B2\u02BD\u02B9\u02B8\u02B5\u02BD\u02B5\u02BC\u02B9\u02BD[i].transform.parent = base.transform;
		}
	}

	private void \u02B3\u02BB\u02BF\u02B4\u02B9\u02BA\u02B5\u02B5\u02BE\u02BB\u02BE()
	{
		this.\u02BF\u02BC\u02BA\u02BA\u02BE\u02BA\u02B9\u02B8\u02B7\u02C1\u02BE();
		this.\u02BF\u02C0\u02BA\u02C1\u02C1\u02B7\u02BB\u02B8\u02B9\u02BF\u02C1 = base.GetComponent<Calibrator>();
		MeshRenderer component = this.noteModel.GetComponent<MeshRenderer>();
		Debug.Log(component);
		this.normalMaterial = component.sharedMaterial;
		this.hitMaterial = new Material(component.sharedMaterial);
		this.hitMaterial.color = Color.magenta;
		this.flashMaterial = new Material(component.sharedMaterial);
		this.flashMaterial.color = Color.green;
		this.\u02B7\u02BB\u02BA\u02C0\u02BF\u02B5\u02B5\u02B9\u02BD\u02C1\u02B4 = 39;
	}

	public static void \u02B2\u02B3\u02C0\u02B9\u02BA\u02BE\u02B3\u02C1\u02BB\u02B8\u02B5(GameObject[] \u02BB\u02BA\u02BF\u02B3\u02BF\u02C0\u02B5\u02B3\u02BB\u02BE\u02B2, int \u02BE\u02B9\u02B4\u02BD\u02C1\u02B4\u02BA\u02B3\u02B5\u02B8\u02B2)
	{
		foreach (GameObject gameObject in EnumerableRanges.EnumerateRange<GameObject>(\u02BB\u02BA\u02BF\u02B3\u02BF\u02C0\u02B5\u02B3\u02BB\u02BE\u02B2, \u02BE\u02B9\u02B4\u02BD\u02C1\u02B4\u02BA\u02B3\u02B5\u02B8\u02B2, -177))
		{
			if (!gameObject.activeSelf)
			{
				break;
			}
			gameObject.SetActive(false);
		}
	}

	public void Reset()
	{
		this.\u02BC\u02BB\u02B3\u02B8\u02BF\u02BF\u02B4\u02B9\u02B8\u02B6\u02B8 = 0;
	}

	private void \u02B5\u02B2\u02BF\u02BD\u02BB\u02BA\u02B2\u02BF\u02BD\u02BE\u02BE()
	{
		this.\u02BE\u02BD\u02BB\u02B8\u02B5\u02BF\u02BE\u02B6\u02BD\u02B9\u02BD();
		this.\u02BF\u02C0\u02BA\u02C1\u02C1\u02B7\u02BB\u02B8\u02B9\u02BF\u02C1 = base.GetComponent<Calibrator>();
		MeshRenderer component = this.noteModel.GetComponent<MeshRenderer>();
		Debug.Log(component);
		this.normalMaterial = component.sharedMaterial;
		this.hitMaterial = new Material(component.sharedMaterial);
		this.hitMaterial.color = Color.magenta;
		this.flashMaterial = new Material(component.sharedMaterial);
		this.flashMaterial.color = Color.green;
		this.\u02B7\u02BB\u02BA\u02C0\u02BF\u02B5\u02B5\u02B9\u02BD\u02C1\u02B4 = 99;
	}

	public void \u02B6\u02BE\u02B4\u02C1\u02BC\u02B3\u02C1\u02BD\u02B7\u02C1\u02B9()
	{
		float num = (float)this.\u02BF\u02C0\u02BA\u02C1\u02C1\u02B7\u02BB\u02B8\u02B9\u02BF\u02C1.\u02B5\u02C1\u02C0\u02C0\u02B5\u02B4\u02BF\u02B9\u02B3\u02B2\u02BE().\u02B2\u02B6\u02B9\u02B8\u02BF\u02BD\u02BF\u02BA\u02B9\u02C1\u02B5 - this.\u02BF\u02C0\u02BA\u02C1\u02C1\u02B7\u02BB\u02B8\u02B9\u02BF\u02C1.\u02B2\u02BB\u02BA\u02B9\u02BA\u02B2\u02B7\u02BE\u02BB\u02BA\u02B9;
		if (num < 0f)
		{
			this.strikelineRenderer.material = this.flashMaterial;
		}
		if (num < -0.2f)
		{
			this.strikelineRenderer.material = this.normalMaterial;
		}
		float num2 = __FIXME_clon_util.\u02C1\u02BA\u02B7\u02C1\u02BB\u02B9\u02B9\u02BB\u02BC\u02B9\u02B8(this.boardNearPos, (double)this.\u02BF\u02C0\u02BA\u02C1\u02C1\u02B7\u02BB\u02B8\u02B9\u02BF\u02C1.\u02B2\u02BB\u02BA\u02B9\u02BA\u02B2\u02B7\u02BE\u02BB\u02BA\u02B9, 0f, (float)this.\u02B7\u02BB\u02BA\u02C0\u02BF\u02B5\u02B5\u02B9\u02BD\u02C1\u02B4);
		float num3 = __FIXME_clon_util.\u02C1\u02BA\u02B7\u02C1\u02BB\u02B9\u02B9\u02BB\u02BC\u02B9\u02B8(this.boardFarPos, (double)this.\u02BF\u02C0\u02BA\u02C1\u02C1\u02B7\u02BB\u02B8\u02B9\u02BF\u02C1.\u02B2\u02BB\u02BA\u02B9\u02BA\u02B2\u02B7\u02BE\u02BB\u02BA\u02B9, 0f, (float)this.\u02B7\u02BB\u02BA\u02C0\u02BF\u02B5\u02B5\u02B9\u02BD\u02C1\u02B4);
		bool flag = false;
		int num4 = 0;
		foreach (ValueTuple<int, \u02BD\u02BC\u02C0\u02BE\u02B2\u02BB\u02C0\u02B5\u02B5\u02BA\u02C1> valueTuple in CalVideoRenderer.\u02BD\u02BD\u02C0\u02B7\u02BA\u02BB\u02B7\u02B6\u02C1\u02B4\u02BE(this.\u02BF\u02C0\u02BA\u02C1\u02C1\u02B7\u02BB\u02B8\u02B9\u02BF\u02C1.\u02B8\u02C1\u02B7\u02B6\u02C0\u02BD\u02BD\u02B2\u02B6\u02BA\u02B9, (double)num2, (double)num3, this.\u02BC\u02BB\u02B3\u02B8\u02BF\u02BF\u02B4\u02B9\u02B8\u02B6\u02B8))
		{
			if (!flag)
			{
				flag = true;
				this.\u02BC\u02BB\u02B3\u02B8\u02BF\u02BF\u02B4\u02B9\u02B8\u02B6\u02B8 = valueTuple.Item1;
			}
			\u02BD\u02BC\u02C0\u02BE\u02B2\u02BB\u02C0\u02B5\u02B5\u02BA\u02C1 item = valueTuple.Item2;
			float num5 = __FIXME_clon_util.\u02B5\u02B9\u02C1\u02BB\u02B6\u02B3\u02BA\u02BE\u02B9\u02B5\u02BF(item.\u02B2\u02B6\u02B9\u02B8\u02BF\u02BD\u02BF\u02BA\u02B9\u02C1\u02B5, (double)this.\u02BF\u02C0\u02BA\u02C1\u02C1\u02B7\u02BB\u02B8\u02B9\u02BF\u02C1.\u02B2\u02BB\u02BA\u02B9\u02BA\u02B2\u02B7\u02BE\u02BB\u02BA\u02B9, 0f, (float)this.\u02B7\u02BB\u02BA\u02C0\u02BF\u02B5\u02B5\u02B9\u02BD\u02C1\u02B4);
			GameObject gameObject = this.\u02C0\u02B2\u02BD\u02B9\u02B8\u02B5\u02BD\u02B5\u02BC\u02B9\u02BD[num4];
			gameObject.SetActive(true);
			gameObject.transform.position = new Vector3(0f, 0f, num5);
			MeshRenderer component = gameObject.GetComponent<MeshRenderer>();
			if (item.\u02BF\u02BF\u02B7\u02BE\u02B9\u02BC\u02B8\u02B7\u02C0\u02BC\u02B4)
			{
				component.material = this.hitMaterial;
			}
			else
			{
				component.material = this.normalMaterial;
			}
			num4++;
		}
		CalVideoRenderer.\u02B4\u02BF\u02BC\u02BC\u02BB\u02C1\u02BE\u02B7\u02B5\u02B6\u02B8(this.\u02C0\u02B2\u02BD\u02B9\u02B8\u02B5\u02BD\u02B5\u02BC\u02B9\u02BD, num4);
	}

	public static void \u02C0\u02B3\u02B3\u02B2\u02B9\u02B2\u02BE\u02BA\u02C1\u02B8\u02B8(GameObject[] \u02BB\u02BA\u02BF\u02B3\u02BF\u02C0\u02B5\u02B3\u02BB\u02BE\u02B2, int \u02BE\u02B9\u02B4\u02BD\u02C1\u02B4\u02BA\u02B3\u02B5\u02B8\u02B2)
	{
		foreach (GameObject gameObject in EnumerableRanges.EnumerateRange<GameObject>(\u02BB\u02BA\u02BF\u02B3\u02BF\u02C0\u02B5\u02B3\u02BB\u02BE\u02B2, \u02BE\u02B9\u02B4\u02BD\u02C1\u02B4\u02BA\u02B3\u02B5\u02B8\u02B2, 58))
		{
			if (!gameObject.activeSelf)
			{
				break;
			}
			gameObject.SetActive(true);
		}
	}

	public int \u02B8\u02BC\u02BC\u02BB\u02C1\u02BD\u02B7\u02B8\u02BC\u02BB\u02BC()
	{
		return this.<\u02BF\u02BF\u02BE\u02B7\u02BF\u02B7\u02B5\u02B9\u02B4\u02B6\u02B3>k__BackingField;
	}

	private void Start()
	{
		this.\u02BE\u02BD\u02BB\u02B8\u02B5\u02BF\u02BE\u02B6\u02BD\u02B9\u02BD();
		this.\u02BF\u02C0\u02BA\u02C1\u02C1\u02B7\u02BB\u02B8\u02B9\u02BF\u02C1 = base.GetComponent<Calibrator>();
		MeshRenderer component = this.noteModel.GetComponent<MeshRenderer>();
		Debug.Log(component);
		this.normalMaterial = component.sharedMaterial;
		this.hitMaterial = new Material(component.sharedMaterial);
		this.hitMaterial.color = Color.magenta;
		this.flashMaterial = new Material(component.sharedMaterial);
		this.flashMaterial.color = Color.green;
		this.\u02B7\u02BB\u02BA\u02C0\u02BF\u02B5\u02B5\u02B9\u02BD\u02C1\u02B4 = 42;
	}

	public void \u02BE\u02B7\u02B4\u02BC\u02C1\u02B3\u02BB\u02B2\u02B4\u02BF\u02B2()
	{
		this.\u02BC\u02BB\u02B3\u02B8\u02BF\u02BF\u02B4\u02B9\u02B8\u02B6\u02B8 = 1;
	}

	public int \u02BC\u02BB\u02B3\u02B8\u02BF\u02BF\u02B4\u02B9\u02B8\u02B6\u02B8 { get; private set; }

	private void \u02B5\u02C0\u02BE\u02B8\u02B9\u02B2\u02BD\u02C0\u02BF\u02B3\u02BD()
	{
		this.\u02BE\u02BD\u02BB\u02B8\u02B5\u02BF\u02BE\u02B6\u02BD\u02B9\u02BD();
		this.\u02BF\u02C0\u02BA\u02C1\u02C1\u02B7\u02BB\u02B8\u02B9\u02BF\u02C1 = base.GetComponent<Calibrator>();
		MeshRenderer component = this.noteModel.GetComponent<MeshRenderer>();
		Debug.Log(component);
		this.normalMaterial = component.sharedMaterial;
		this.hitMaterial = new Material(component.sharedMaterial);
		this.hitMaterial.color = Color.magenta;
		this.flashMaterial = new Material(component.sharedMaterial);
		this.flashMaterial.color = Color.green;
		this.\u02B7\u02BB\u02BA\u02C0\u02BF\u02B5\u02B5\u02B9\u02BD\u02C1\u02B4 = -128;
	}

	private void \u02B2\u02B7\u02B5\u02C0\u02B4\u02B3\u02B8\u02B3\u02C0\u02BD\u02B5()
	{
		this.\u02BF\u02BC\u02BA\u02BA\u02BE\u02BA\u02B9\u02B8\u02B7\u02C1\u02BE();
		this.\u02BF\u02C0\u02BA\u02C1\u02C1\u02B7\u02BB\u02B8\u02B9\u02BF\u02C1 = base.GetComponent<Calibrator>();
		MeshRenderer component = this.noteModel.GetComponent<MeshRenderer>();
		Debug.Log(component);
		this.normalMaterial = component.sharedMaterial;
		this.hitMaterial = new Material(component.sharedMaterial);
		this.hitMaterial.color = Color.magenta;
		this.flashMaterial = new Material(component.sharedMaterial);
		this.flashMaterial.color = Color.green;
		this.\u02B7\u02BB\u02BA\u02C0\u02BF\u02B5\u02B5\u02B9\u02BD\u02C1\u02B4 = 93;
	}

	[SerializeField]
	private GameObject noteModel;

	[SerializeField]
	private MeshRenderer strikelineRenderer;

	[SerializeField]
	private float boardFarPos;

	[SerializeField]
	private float boardNearPos;

	[SerializeField]
	private Material hitMaterial;

	[SerializeField]
	private Material normalMaterial;

	[SerializeField]
	private Material flashMaterial;

	private int \u02B7\u02BB\u02BA\u02C0\u02BF\u02B5\u02B5\u02B9\u02BD\u02C1\u02B4;

	private const int \u02B5\u02BB\u02B2\u02BA\u02B5\u02B6\u02B2\u02B2\u02BC\u02BD\u02B7 = 100;

	private GameObject[] \u02C0\u02B2\u02BD\u02B9\u02B8\u02B5\u02BD\u02B5\u02BC\u02B9\u02BD;

	private Calibrator \u02BF\u02C0\u02BA\u02C1\u02C1\u02B7\u02BB\u02B8\u02B9\u02BF\u02C1;
}
