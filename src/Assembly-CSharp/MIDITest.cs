using System;
using System.IO;
using Melanchall.DryWetMidi.Smf;
using UnityEngine;

public class MIDITest : MonoBehaviour
{
	private void \u02BB\u02BC\u02BD\u02B9\u02B3\u02B3\u02BE\u02B4\u02B8\u02B2\u02B2()
	{
		if (Input.GetKeyDown(KeyCode.Slash))
		{
			MidiFile.Read(Path.Combine(this.songDirectory, "No"), null);
		}
	}

	private void \u02C0\u02B5\u02BC\u02B3\u02B3\u02B7\u02B9\u02B2\u02C0\u02BC\u02BB()
	{
		if (Input.GetKeyDown((KeyCode)(-119)))
		{
			MidiFile.Read(Path.Combine(this.songDirectory, "Intensity - 6 Fret Guitar Coop"), null);
		}
	}

	private void \u02B2\u02B6\u02C1\u02B8\u02B3\u02B5\u02B7\u02B5\u02B6\u02B9\u02C0()
	{
		if (Input.GetKeyDown(KeyCode.Alpha7))
		{
			MidiFile.Read(Path.Combine(this.songDirectory, "song"), null);
		}
	}

	private void \u02BD\u02C1\u02B7\u02B8\u02B3\u02B5\u02BC\u02B9\u02BC\u02B3\u02B7()
	{
		if (Input.GetKeyDown((KeyCode)(-84)))
		{
			MidiFile.Read(Path.Combine(this.songDirectory, "Yes"), null);
		}
	}

	private void \u02C0\u02BE\u02B7\u02BF\u02B9\u02BB\u02C1\u02B2\u02B9\u02B7\u02B5()
	{
		if (Input.GetKeyDown((KeyCode)(-120)))
		{
			MidiFile.Read(Path.Combine(this.songDirectory, "Rhythm Guitar"), null);
		}
	}

	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.A))
		{
			MidiFile.Read(Path.Combine(this.songDirectory, "notes.mid"), null);
		}
	}

	private void \u02BB\u02BF\u02BA\u02BC\u02B8\u02B7\u02B4\u02B5\u02B7\u02B9\u02C1()
	{
		if (Input.GetKeyDown((KeyCode)(-18)))
		{
			MidiFile.Read(Path.Combine(this.songDirectory, "Updated latency {0} for {1}"), null);
		}
	}

	private void \u02BC\u02B6\u02B8\u02BA\u02B2\u02B4\u02B7\u02B3\u02C0\u02B8\u02B7()
	{
		if (Input.GetKeyDown(KeyCode.D))
		{
			MidiFile.Read(Path.Combine(this.songDirectory, "groupNotesMissed"), null);
		}
	}

	private void \u02B3\u02B2\u02BB\u02B3\u02B2\u02C1\u02C1\u02B3\u02B8\u02C1\u02B5()
	{
		if (Input.GetKeyDown((KeyCode)(-56)))
		{
			MidiFile.Read(Path.Combine(this.songDirectory, "Unable to read from local icon cache."), null);
		}
	}

	private void \u02B9\u02B5\u02B2\u02BB\u02B5\u02B3\u02B9\u02BC\u02BF\u02B5\u02BA()
	{
		if (Input.GetKeyDown((KeyCode)(-93)))
		{
			MidiFile.Read(Path.Combine(this.songDirectory, "Clear Setlist"), null);
		}
	}

	private void \u02C1\u02B8\u02B5\u02BD\u02BD\u02C0\u02BB\u02B4\u02BD\u02B8\u02B3()
	{
		if (Input.GetKeyDown((KeyCode)(-84)))
		{
			MidiFile.Read(Path.Combine(this.songDirectory, "Scan Songs"), null);
		}
	}

	private void \u02BE\u02B2\u02B3\u02BB\u02BE\u02BB\u02B7\u02BF\u02B5\u02B7\u02B8()
	{
		if (Input.GetKeyDown((KeyCode)(-88)))
		{
			MidiFile.Read(Path.Combine(this.songDirectory, "*"), null);
		}
	}

	private void \u02B4\u02B6\u02BD\u02B5\u02C0\u02B6\u02BA\u02C1\u02C0\u02BC\u02BB()
	{
		if (Input.GetKeyDown((KeyCode)(-56)))
		{
			MidiFile.Read(Path.Combine(this.songDirectory, "Album"), null);
		}
	}

	private void \u02BD\u02B8\u02BD\u02B5\u02B6\u02B3\u02BF\u02B3\u02C1\u02B8\u02C1()
	{
		if (Input.GetKeyDown(KeyCode.G))
		{
			MidiFile.Read(Path.Combine(this.songDirectory, "song"), null);
		}
	}

	[SerializeField]
	private string songDirectory;
}
