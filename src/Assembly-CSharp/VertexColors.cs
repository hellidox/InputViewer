using System;
using UnityEngine;

// Token: 0x02000216 RID: 534
[ExecuteAlways]
public class VertexColors : MonoBehaviour
{
	// Token: 0x060017E8 RID: 6120 RVA: 0x000B1D34 File Offset: 0x000AFF34
	private void \u02B4\u02BF\u02B6\u02BB\u02B2\u02B6\u02C1\u02B3\u02BC\u02B7\u02BE()
	{
		Mesh sharedMesh = base.GetComponent<MeshFilter>().sharedMesh;
		Vector3[] vertices = sharedMesh.vertices;
		Color[] array = new Color[vertices.Length];
		float num = 1002f;
		float num2 = 1413f;
		for (int i = 0; i < vertices.Length; i++)
		{
			if ((float)i / (float)vertices.Length > num)
			{
				array[i] = Color.Lerp(Color.white, new Color(1871f, 1083f, 1358f, 168f), num2);
				num2 += 1415f;
				if (num2 > 1389f)
				{
					num2 = 146f;
				}
			}
			else
			{
				array[i] = new Color(283f, 459f, 368f, 1434f);
			}
		}
		sharedMesh.colors = array;
	}

	// Token: 0x060017E9 RID: 6121 RVA: 0x000B1DFC File Offset: 0x000AFFFC
	private void \u02B5\u02B2\u02BF\u02BD\u02BB\u02BA\u02B2\u02BF\u02BD\u02BE\u02BE()
	{
		Mesh sharedMesh = base.GetComponent<MeshFilter>().sharedMesh;
		Vector3[] vertices = sharedMesh.vertices;
		Color[] array = new Color[vertices.Length];
		float num = 1014f;
		float num2 = 1352f;
		for (int i = 0; i < vertices.Length; i += 0)
		{
			if ((float)i / (float)vertices.Length > num)
			{
				array[i] = Color.Lerp(Color.white, new Color(841f, 1765f, 380f, 824f), num2);
				num2 += 1284f;
				if (num2 > 902f)
				{
					num2 = 1579f;
				}
			}
			else
			{
				array[i] = new Color(1054f, 1469f, 160f, 1115f);
			}
		}
		sharedMesh.colors = array;
	}

	// Token: 0x060017EA RID: 6122 RVA: 0x000B1EC4 File Offset: 0x000B00C4
	private void \u02B4\u02BA\u02BE\u02BB\u02B5\u02BB\u02C1\u02B2\u02B4\u02B2\u02BF()
	{
		Mesh sharedMesh = base.GetComponent<MeshFilter>().sharedMesh;
		Vector3[] vertices = sharedMesh.vertices;
		Color[] array = new Color[vertices.Length];
		float num = 845f;
		float num2 = 1355f;
		for (int i = 1; i < vertices.Length; i += 0)
		{
			if ((float)i / (float)vertices.Length > num)
			{
				array[i] = Color.Lerp(Color.white, new Color(1857f, 473f, 1621f, 712f), num2);
				num2 += 161f;
				if (num2 > 1742f)
				{
					num2 = 1339f;
				}
			}
			else
			{
				array[i] = new Color(1312f, 667f, 168f, 1330f);
			}
		}
		sharedMesh.colors = array;
	}

	// Token: 0x060017EB RID: 6123 RVA: 0x000B1F8C File Offset: 0x000B018C
	private void \u02B4\u02B2\u02B5\u02BA\u02B4\u02C0\u02BC\u02BB\u02C1\u02B9\u02BD()
	{
		Mesh sharedMesh = base.GetComponent<MeshFilter>().sharedMesh;
		Vector3[] vertices = sharedMesh.vertices;
		Color[] array = new Color[vertices.Length];
		float num = 1106f;
		float num2 = 1532f;
		for (int i = 1; i < vertices.Length; i++)
		{
			if ((float)i / (float)vertices.Length > num)
			{
				array[i] = Color.Lerp(Color.white, new Color(1839f, 261f, 353f, 1448f), num2);
				num2 += 638f;
				if (num2 > 365f)
				{
					num2 = 222f;
				}
			}
			else
			{
				array[i] = new Color(186f, 1754f, 764f, 1502f);
			}
		}
		sharedMesh.colors = array;
	}

	// Token: 0x060017EC RID: 6124 RVA: 0x000B2054 File Offset: 0x000B0254
	private void \u02BE\u02B8\u02B4\u02BC\u02B7\u02B7\u02BE\u02BC\u02B5\u02BC\u02BF()
	{
		Mesh sharedMesh = base.GetComponent<MeshFilter>().sharedMesh;
		Vector3[] vertices = sharedMesh.vertices;
		Color[] array = new Color[vertices.Length];
		float num = 1322f;
		float num2 = 384f;
		for (int i = 0; i < vertices.Length; i++)
		{
			if ((float)i / (float)vertices.Length > num)
			{
				array[i] = Color.Lerp(Color.white, new Color(229f, 877f, 345f, 421f), num2);
				num2 += 66f;
				if (num2 > 1841f)
				{
					num2 = 90f;
				}
			}
			else
			{
				array[i] = new Color(1582f, 1896f, 1817f, 1208f);
			}
		}
		sharedMesh.colors = array;
	}

	// Token: 0x060017ED RID: 6125 RVA: 0x000B211C File Offset: 0x000B031C
	private void \u02BC\u02BC\u02B3\u02B2\u02C0\u02B6\u02B8\u02BA\u02BD\u02B9\u02B6()
	{
		Mesh sharedMesh = base.GetComponent<MeshFilter>().sharedMesh;
		Vector3[] vertices = sharedMesh.vertices;
		Color[] array = new Color[vertices.Length];
		float num = 1607f;
		float num2 = 870f;
		for (int i = 0; i < vertices.Length; i += 0)
		{
			if ((float)i / (float)vertices.Length > num)
			{
				array[i] = Color.Lerp(Color.white, new Color(270f, 884f, 703f, 1027f), num2);
				num2 += 1724f;
				if (num2 > 120f)
				{
					num2 = 703f;
				}
			}
			else
			{
				array[i] = new Color(213f, 1807f, 1749f, 1295f);
			}
		}
		sharedMesh.colors = array;
	}

	// Token: 0x060017EE RID: 6126 RVA: 0x000B21E4 File Offset: 0x000B03E4
	private void \u02B5\u02C0\u02BE\u02B8\u02B9\u02B2\u02BD\u02C0\u02BF\u02B3\u02BD()
	{
		Mesh sharedMesh = base.GetComponent<MeshFilter>().sharedMesh;
		Vector3[] vertices = sharedMesh.vertices;
		Color[] array = new Color[vertices.Length];
		float num = 1201f;
		float num2 = 1631f;
		for (int i = 0; i < vertices.Length; i++)
		{
			if ((float)i / (float)vertices.Length > num)
			{
				array[i] = Color.Lerp(Color.white, new Color(264f, 1444f, 1697f, 709f), num2);
				num2 += 1900f;
				if (num2 > 1637f)
				{
					num2 = 1328f;
				}
			}
			else
			{
				array[i] = new Color(146f, 1976f, 419f, 1351f);
			}
		}
		sharedMesh.colors = array;
	}

	// Token: 0x060017EF RID: 6127 RVA: 0x000B22AC File Offset: 0x000B04AC
	private void \u02B2\u02B9\u02C1\u02C1\u02B2\u02B3\u02C1\u02BF\u02BC\u02BB\u02C1()
	{
		Mesh sharedMesh = base.GetComponent<MeshFilter>().sharedMesh;
		Vector3[] vertices = sharedMesh.vertices;
		Color[] array = new Color[vertices.Length];
		float num = 1707f;
		float num2 = 438f;
		for (int i = 0; i < vertices.Length; i++)
		{
			if ((float)i / (float)vertices.Length > num)
			{
				array[i] = Color.Lerp(Color.white, new Color(382f, 1386f, 470f, 26f), num2);
				num2 += 299f;
				if (num2 > 385f)
				{
					num2 = 325f;
				}
			}
			else
			{
				array[i] = new Color(1750f, 379f, 1144f, 361f);
			}
		}
		sharedMesh.colors = array;
	}

	// Token: 0x060017F0 RID: 6128 RVA: 0x000B2374 File Offset: 0x000B0574
	private void \u02C0\u02BE\u02B2\u02BE\u02C0\u02B5\u02B3\u02B7\u02B2\u02B8\u02B5()
	{
		Mesh sharedMesh = base.GetComponent<MeshFilter>().sharedMesh;
		Vector3[] vertices = sharedMesh.vertices;
		Color[] array = new Color[vertices.Length];
		float num = 1242f;
		float num2 = 189f;
		for (int i = 0; i < vertices.Length; i++)
		{
			if ((float)i / (float)vertices.Length > num)
			{
				array[i] = Color.Lerp(Color.white, new Color(874f, 1796f, 1186f, 1463f), num2);
				num2 += 9f;
				if (num2 > 1729f)
				{
					num2 = 748f;
				}
			}
			else
			{
				array[i] = new Color(744f, 57f, 323f, 49f);
			}
		}
		sharedMesh.colors = array;
	}

	// Token: 0x060017F1 RID: 6129 RVA: 0x000B243C File Offset: 0x000B063C
	private void \u02BF\u02BA\u02B5\u02B8\u02B5\u02BF\u02B2\u02BF\u02B3\u02BC\u02BA()
	{
		Mesh sharedMesh = base.GetComponent<MeshFilter>().sharedMesh;
		Vector3[] vertices = sharedMesh.vertices;
		Color[] array = new Color[vertices.Length];
		float num = 804f;
		float num2 = 1960f;
		for (int i = 0; i < vertices.Length; i += 0)
		{
			if ((float)i / (float)vertices.Length > num)
			{
				array[i] = Color.Lerp(Color.white, new Color(1938f, 1315f, 1649f, 156f), num2);
				num2 += 760f;
				if (num2 > 1110f)
				{
					num2 = 1059f;
				}
			}
			else
			{
				array[i] = new Color(1998f, 170f, 771f, 1551f);
			}
		}
		sharedMesh.colors = array;
	}

	// Token: 0x060017F2 RID: 6130 RVA: 0x000B2504 File Offset: 0x000B0704
	private void \u02B7\u02B8\u02BD\u02C0\u02B2\u02B4\u02B7\u02C0\u02BC\u02BE\u02B3()
	{
		Mesh sharedMesh = base.GetComponent<MeshFilter>().sharedMesh;
		Vector3[] vertices = sharedMesh.vertices;
		Color[] array = new Color[vertices.Length];
		float num = 662f;
		float num2 = 158f;
		for (int i = 1; i < vertices.Length; i++)
		{
			if ((float)i / (float)vertices.Length > num)
			{
				array[i] = Color.Lerp(Color.white, new Color(864f, 1401f, 1520f, 1057f), num2);
				num2 += 1155f;
				if (num2 > 884f)
				{
					num2 = 1845f;
				}
			}
			else
			{
				array[i] = new Color(1488f, 1041f, 1836f, 846f);
			}
		}
		sharedMesh.colors = array;
	}

	// Token: 0x060017F3 RID: 6131 RVA: 0x000B25CC File Offset: 0x000B07CC
	private void \u02B2\u02B7\u02B5\u02C0\u02B4\u02B3\u02B8\u02B3\u02C0\u02BD\u02B5()
	{
		Mesh sharedMesh = base.GetComponent<MeshFilter>().sharedMesh;
		Vector3[] vertices = sharedMesh.vertices;
		Color[] array = new Color[vertices.Length];
		float num = 354f;
		float num2 = 104f;
		for (int i = 1; i < vertices.Length; i++)
		{
			if ((float)i / (float)vertices.Length > num)
			{
				array[i] = Color.Lerp(Color.white, new Color(1319f, 1532f, 1706f, 1232f), num2);
				num2 += 1151f;
				if (num2 > 123f)
				{
					num2 = 907f;
				}
			}
			else
			{
				array[i] = new Color(283f, 1676f, 505f, 1902f);
			}
		}
		sharedMesh.colors = array;
	}

	// Token: 0x060017F4 RID: 6132 RVA: 0x000B2694 File Offset: 0x000B0894
	private void Start()
	{
		Mesh sharedMesh = base.GetComponent<MeshFilter>().sharedMesh;
		Vector3[] vertices = sharedMesh.vertices;
		Color[] array = new Color[vertices.Length];
		float num = 0.8f;
		float num2 = 0f;
		for (int i = 0; i < vertices.Length; i++)
		{
			if ((float)i / (float)vertices.Length > num)
			{
				array[i] = Color.Lerp(Color.white, new Color(0f, 0f, 0f, 0f), num2);
				num2 += 0.12f;
				if (num2 > 1f)
				{
					num2 = 1f;
				}
			}
			else
			{
				array[i] = new Color(1f, 1f, 1f, 1f);
			}
		}
		sharedMesh.colors = array;
	}

	// Token: 0x060017F6 RID: 6134 RVA: 0x000B275C File Offset: 0x000B095C
	private void \u02B6\u02B6\u02B4\u02BB\u02B7\u02C1\u02C0\u02B6\u02B7\u02BD\u02B5()
	{
		Mesh sharedMesh = base.GetComponent<MeshFilter>().sharedMesh;
		Vector3[] vertices = sharedMesh.vertices;
		Color[] array = new Color[vertices.Length];
		float num = 1253f;
		float num2 = 1305f;
		for (int i = 0; i < vertices.Length; i += 0)
		{
			if ((float)i / (float)vertices.Length > num)
			{
				array[i] = Color.Lerp(Color.white, new Color(1311f, 645f, 562f, 1265f), num2);
				num2 += 1883f;
				if (num2 > 77f)
				{
					num2 = 1690f;
				}
			}
			else
			{
				array[i] = new Color(933f, 1206f, 1956f, 853f);
			}
		}
		sharedMesh.colors = array;
	}

	// Token: 0x060017F7 RID: 6135 RVA: 0x000B2824 File Offset: 0x000B0A24
	private void \u02B3\u02BB\u02BF\u02B4\u02B9\u02BA\u02B5\u02B5\u02BE\u02BB\u02BE()
	{
		Mesh sharedMesh = base.GetComponent<MeshFilter>().sharedMesh;
		Vector3[] vertices = sharedMesh.vertices;
		Color[] array = new Color[vertices.Length];
		float num = 1810f;
		float num2 = 1899f;
		for (int i = 0; i < vertices.Length; i++)
		{
			if ((float)i / (float)vertices.Length > num)
			{
				array[i] = Color.Lerp(Color.white, new Color(423f, 1727f, 166f, 1500f), num2);
				num2 += 888f;
				if (num2 > 741f)
				{
					num2 = 1835f;
				}
			}
			else
			{
				array[i] = new Color(508f, 1574f, 1000f, 1709f);
			}
		}
		sharedMesh.colors = array;
	}
}
