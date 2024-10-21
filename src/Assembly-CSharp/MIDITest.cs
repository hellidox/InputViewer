using System;
using System.IO;
using Melanchall.DryWetMidi.Smf;
using UnityEngine;

// Token: 0x0200012A RID: 298
public class MIDITest : MonoBehaviour
{
	// Token: 0x06000CDA RID: 3290 RVA: 0x0000C988 File Offset: 0x0000AB88
	private void \u02BB\u02BC\u02BD\u02B9\u02B3\u02B3\u02BE\u02B4\u02B8\u02B2\u02B2()
	{
		if (Input.GetKeyDown(KeyCode.Slash))
		{
			MidiFile.Read(Path.Combine(this.songDirectory, "No"), null);
		}
	}

	// Token: 0x06000CDB RID: 3291 RVA: 0x0000C9AA File Offset: 0x0000ABAA
	private void \u02C0\u02B5\u02BC\u02B3\u02B3\u02B7\u02B9\u02B2\u02C0\u02BC\u02BB()
	{
		if (Input.GetKeyDown((KeyCode)(-119)))
		{
			MidiFile.Read(Path.Combine(this.songDirectory, "Intensity - 6 Fret Guitar Coop"), null);
		}
	}

	// Token: 0x06000CDC RID: 3292 RVA: 0x0000C9CC File Offset: 0x0000ABCC
	private void \u02B2\u02B6\u02C1\u02B8\u02B3\u02B5\u02B7\u02B5\u02B6\u02B9\u02C0()
	{
		if (Input.GetKeyDown(KeyCode.Alpha7))
		{
			MidiFile.Read(Path.Combine(this.songDirectory, "song"), null);
		}
	}

	// Token: 0x06000CDD RID: 3293 RVA: 0x0000C9EE File Offset: 0x0000ABEE
	private void \u02BD\u02C1\u02B7\u02B8\u02B3\u02B5\u02BC\u02B9\u02BC\u02B3\u02B7()
	{
		if (Input.GetKeyDown((KeyCode)(-84)))
		{
			MidiFile.Read(Path.Combine(this.songDirectory, "Yes"), null);
		}
	}

	// Token: 0x06000CDE RID: 3294 RVA: 0x0000CA10 File Offset: 0x0000AC10
	private void \u02C0\u02BE\u02B7\u02BF\u02B9\u02BB\u02C1\u02B2\u02B9\u02B7\u02B5()
	{
		if (Input.GetKeyDown((KeyCode)(-120)))
		{
			MidiFile.Read(Path.Combine(this.songDirectory, "Rhythm Guitar"), null);
		}
	}

	// Token: 0x06000CDF RID: 3295 RVA: 0x0000CA32 File Offset: 0x0000AC32
	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.A))
		{
			MidiFile.Read(Path.Combine(this.songDirectory, "notes.mid"), null);
		}
	}

	// Token: 0x06000CE0 RID: 3296 RVA: 0x0000CA54 File Offset: 0x0000AC54
	private void \u02BB\u02BF\u02BA\u02BC\u02B8\u02B7\u02B4\u02B5\u02B7\u02B9\u02C1()
	{
		if (Input.GetKeyDown((KeyCode)(-18)))
		{
			MidiFile.Read(Path.Combine(this.songDirectory, "Updated latency {0} for {1}"), null);
		}
	}

	// Token: 0x06000CE1 RID: 3297 RVA: 0x0000CA76 File Offset: 0x0000AC76
	private void \u02BC\u02B6\u02B8\u02BA\u02B2\u02B4\u02B7\u02B3\u02C0\u02B8\u02B7()
	{
		if (Input.GetKeyDown(KeyCode.D))
		{
			MidiFile.Read(Path.Combine(this.songDirectory, "groupNotesMissed"), null);
		}
	}

	// Token: 0x06000CE2 RID: 3298 RVA: 0x0000CA98 File Offset: 0x0000AC98
	private void \u02B3\u02B2\u02BB\u02B3\u02B2\u02C1\u02C1\u02B3\u02B8\u02C1\u02B5()
	{
		if (Input.GetKeyDown((KeyCode)(-56)))
		{
			MidiFile.Read(Path.Combine(this.songDirectory, "Unable to read from local icon cache."), null);
		}
	}

	// Token: 0x06000CE3 RID: 3299 RVA: 0x0000CABA File Offset: 0x0000ACBA
	private void \u02B9\u02B5\u02B2\u02BB\u02B5\u02B3\u02B9\u02BC\u02BF\u02B5\u02BA()
	{
		if (Input.GetKeyDown((KeyCode)(-93)))
		{
			MidiFile.Read(Path.Combine(this.songDirectory, "Clear Setlist"), null);
		}
	}

	// Token: 0x06000CE4 RID: 3300 RVA: 0x0000CADC File Offset: 0x0000ACDC
	private void \u02C1\u02B8\u02B5\u02BD\u02BD\u02C0\u02BB\u02B4\u02BD\u02B8\u02B3()
	{
		if (Input.GetKeyDown((KeyCode)(-84)))
		{
			MidiFile.Read(Path.Combine(this.songDirectory, "Scan Songs"), null);
		}
	}

	// Token: 0x06000CE5 RID: 3301 RVA: 0x0000CAFE File Offset: 0x0000ACFE
	private void \u02BE\u02B2\u02B3\u02BB\u02BE\u02BB\u02B7\u02BF\u02B5\u02B7\u02B8()
	{
		if (Input.GetKeyDown((KeyCode)(-88)))
		{
			MidiFile.Read(Path.Combine(this.songDirectory, "*"), null);
		}
	}

	// Token: 0x06000CE7 RID: 3303 RVA: 0x0000CB20 File Offset: 0x0000AD20
	private void \u02B4\u02B6\u02BD\u02B5\u02C0\u02B6\u02BA\u02C1\u02C0\u02BC\u02BB()
	{
		if (Input.GetKeyDown((KeyCode)(-56)))
		{
			MidiFile.Read(Path.Combine(this.songDirectory, "Album"), null);
		}
	}

	// Token: 0x06000CE8 RID: 3304 RVA: 0x0000CB42 File Offset: 0x0000AD42
	private void \u02BD\u02B8\u02BD\u02B5\u02B6\u02B3\u02BF\u02B3\u02C1\u02B8\u02C1()
	{
		if (Input.GetKeyDown(KeyCode.G))
		{
			MidiFile.Read(Path.Combine(this.songDirectory, "song"), null);
		}
	}

	// Token: 0x04000908 RID: 2312
	[SerializeField]
	private string songDirectory;
}
