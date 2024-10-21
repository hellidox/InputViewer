using System;
using System.Collections.Generic;
using StrikeCore;
using UnityEngine;

// Token: 0x0200003C RID: 60
public class CalVideoRenderer : MonoBehaviour
{
	// Token: 0x0600022F RID: 559 RVA: 0x000240B8 File Offset: 0x000222B8
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

	// Token: 0x06000231 RID: 561 RVA: 0x0000709C File Offset: 0x0000529C
	public int \u02BB\u02BC\u02BF\u02BC\u02BC\u02B4\u02B2\u02BF\u02B9\u02B5\u02BD()
	{
		return this.<\u02BF\u02BF\u02BE\u02B7\u02BF\u02B7\u02B5\u02B9\u02B4\u02B6\u02B3>k__BackingField;
	}

	// Token: 0x06000232 RID: 562 RVA: 0x000240FC File Offset: 0x000222FC
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

	// Token: 0x06000233 RID: 563 RVA: 0x000070A4 File Offset: 0x000052A4
	private void \u02BA\u02B7\u02B9\u02B5\u02B3\u02C1\u02C1\u02B7\u02BA\u02B7\u02B4(int \u02B6\u02B2\u02B5\u02BB\u02C1\u02BB\u02BA\u02B4\u02BF\u02BA\u02B5)
	{
		this.<\u02BF\u02BF\u02BE\u02B7\u02BF\u02B7\u02B5\u02B9\u02B4\u02B6\u02B3>k__BackingField = \u02B6\u02B2\u02B5\u02BB\u02C1\u02BB\u02BA\u02B4\u02BF\u02BA\u02B5;
	}

	// Token: 0x06000234 RID: 564 RVA: 0x000070AD File Offset: 0x000052AD
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

	// Token: 0x06000235 RID: 565 RVA: 0x00024184 File Offset: 0x00022384
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

	// Token: 0x06000236 RID: 566 RVA: 0x000070D2 File Offset: 0x000052D2
	public void \u02B9\u02B4\u02BF\u02BC\u02B9\u02BA\u02B5\u02BD\u02BD\u02C1\u02B3()
	{
		this.\u02BC\u02BB\u02B3\u02B8\u02BF\u02BF\u02B4\u02B9\u02B8\u02B6\u02B8 = 0;
	}

	// Token: 0x06000237 RID: 567 RVA: 0x000241FC File Offset: 0x000223FC
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

	// Token: 0x06000238 RID: 568 RVA: 0x00024274 File Offset: 0x00022474
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

	// Token: 0x06000239 RID: 569 RVA: 0x000242FC File Offset: 0x000224FC
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

	// Token: 0x0600023A RID: 570 RVA: 0x000070D2 File Offset: 0x000052D2
	public void Reset()
	{
		this.\u02BC\u02BB\u02B3\u02B8\u02BF\u02BF\u02B4\u02B9\u02B8\u02B6\u02B8 = 0;
	}

	// Token: 0x0600023B RID: 571 RVA: 0x00024340 File Offset: 0x00022540
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

	// Token: 0x0600023C RID: 572 RVA: 0x000243C8 File Offset: 0x000225C8
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

	// Token: 0x0600023D RID: 573 RVA: 0x0002456C File Offset: 0x0002276C
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

	// Token: 0x0600023E RID: 574 RVA: 0x0000709C File Offset: 0x0000529C
	public int \u02B8\u02BC\u02BC\u02BB\u02C1\u02BD\u02B7\u02B8\u02BC\u02BB\u02BC()
	{
		return this.<\u02BF\u02BF\u02BE\u02B7\u02BF\u02B7\u02B5\u02B9\u02B4\u02B6\u02B3>k__BackingField;
	}

	// Token: 0x0600023F RID: 575 RVA: 0x000245B0 File Offset: 0x000227B0
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

	// Token: 0x06000240 RID: 576 RVA: 0x000070DB File Offset: 0x000052DB
	public void \u02BE\u02B7\u02B4\u02BC\u02C1\u02B3\u02BB\u02B2\u02B4\u02BF\u02B2()
	{
		this.\u02BC\u02BB\u02B3\u02B8\u02BF\u02BF\u02B4\u02B9\u02B8\u02B6\u02B8 = 1;
	}

	// Token: 0x1700001C RID: 28
	// (get) Token: 0x06000241 RID: 577 RVA: 0x0000709C File Offset: 0x0000529C
	// (set) Token: 0x06000244 RID: 580 RVA: 0x000070A4 File Offset: 0x000052A4
	public int \u02BC\u02BB\u02B3\u02B8\u02BF\u02BF\u02B4\u02B9\u02B8\u02B6\u02B8 { get; private set; }

	// Token: 0x06000242 RID: 578 RVA: 0x00024638 File Offset: 0x00022838
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

	// Token: 0x06000243 RID: 579 RVA: 0x000246C0 File Offset: 0x000228C0
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

	// Token: 0x0400014F RID: 335
	[SerializeField]
	private GameObject noteModel;

	// Token: 0x04000150 RID: 336
	[SerializeField]
	private MeshRenderer strikelineRenderer;

	// Token: 0x04000151 RID: 337
	[SerializeField]
	private float boardFarPos;

	// Token: 0x04000152 RID: 338
	[SerializeField]
	private float boardNearPos;

	// Token: 0x04000153 RID: 339
	[SerializeField]
	private Material hitMaterial;

	// Token: 0x04000154 RID: 340
	[SerializeField]
	private Material normalMaterial;

	// Token: 0x04000155 RID: 341
	[SerializeField]
	private Material flashMaterial;

	// Token: 0x04000156 RID: 342
	private int \u02B7\u02BB\u02BA\u02C0\u02BF\u02B5\u02B5\u02B9\u02BD\u02C1\u02B4;

	// Token: 0x04000157 RID: 343
	private const int \u02B5\u02BB\u02B2\u02BA\u02B5\u02B6\u02B2\u02B2\u02BC\u02BD\u02B7 = 100;

	// Token: 0x04000159 RID: 345
	private GameObject[] \u02C0\u02B2\u02BD\u02B9\u02B8\u02B5\u02BD\u02B5\u02BC\u02B9\u02BD;

	// Token: 0x0400015A RID: 346
	private Calibrator \u02BF\u02C0\u02BA\u02C1\u02C1\u02B7\u02BB\u02B8\u02B9\u02BF\u02C1;
}
