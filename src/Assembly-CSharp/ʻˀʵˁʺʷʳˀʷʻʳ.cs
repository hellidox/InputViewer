using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Melanchall.DryWetMidi.Smf;
using UnityEngine;

public static class \u02BB\u02C0\u02B5\u02C1\u02BA\u02B7\u02B3\u02C0\u02B7\u02BB\u02B3
{
	private static string \u02C0\u02BF\u02B7\u02B9\u02B5\u02B2\u02B5\u02B8\u02BC\u02B3\u02BE(EventsCollection \u02BB\u02BF\u02BF\u02B4\u02B3\u02BE\u02C0\u02BB\u02C0\u02BA\u02B2)
	{
		for (int i = 0; i < \u02BB\u02BF\u02BF\u02B4\u02B3\u02BE\u02C0\u02BB\u02C0\u02BA\u02B2.Count; i++)
		{
			SequenceTrackNameEvent sequenceTrackNameEvent = \u02BB\u02BF\u02BF\u02B4\u02B3\u02BE\u02C0\u02BB\u02C0\u02BA\u02B2[i] as SequenceTrackNameEvent;
			if (sequenceTrackNameEvent != null)
			{
				string text = sequenceTrackNameEvent.Text.ToLowerInvariant();
				if (text.Contains("part") || text == "t1 gems" || text == "events" || text == "beat")
				{
					return text;
				}
			}
		}
		return "";
	}

	private static \u02B7\u02BD\u02BB\u02BB\u02BF\u02B5\u02C0\u02C1\u02BD\u02B3\u02B6 \u02B8\u02B3\u02BA\u02BD\u02B8\u02C0\u02B2\u02B4\u02B8\u02BE\u02C1(MidiFile \u02BA\u02B7\u02B8\u02BC\u02B2\u02C1\u02BF\u02BF\u02C0\u02BE\u02B9, bool \u02B2\u02BB\u02B5\u02B5\u02C0\u02C1\u02B8\u02BA\u02B7\u02C0\u02B9)
	{
		\u02B7\u02BD\u02BB\u02BB\u02BF\u02B5\u02C0\u02C1\u02BD\u02B3\u02B6 u02B7_u02BD_u02BB_u02BB_u02BF_u02B5_u02C0_u02C1_u02BD_u02B3_u02B = new \u02B7\u02BD\u02BB\u02BB\u02BF\u02B5\u02C0\u02C1\u02BD\u02B3\u02B6();
		\u02BB\u02C0\u02B5\u02C1\u02BA\u02B7\u02B3\u02C0\u02B7\u02BB\u02B3.\u02B8\u02B3\u02B9\u02BD\u02BC\u02BD\u02B5\u02C0\u02BD\u02BC\u02BA = \u02B2\u02BB\u02B5\u02B5\u02C0\u02C1\u02B8\u02BA\u02B7\u02C0\u02B9;
		IEnumerable<TrackChunk> trackChunks = \u02BA\u02B7\u02B8\u02BC\u02B2\u02C1\u02BF\u02BF\u02C0\u02BE\u02B9.GetTrackChunks();
		u02B7_u02BD_u02BB_u02BB_u02BF_u02B5_u02C0_u02C1_u02BD_u02B3_u02B.\u02C0\u02B3\u02C1\u02BB\u02B5\u02BA\u02BB\u02B3\u02C1\u02B8\u02BD = (float)((TicksPerQuarterNoteTimeDivision)\u02BA\u02B7\u02B8\u02BC\u02B2\u02C1\u02BF\u02BF\u02C0\u02BE\u02B9.TimeDivision).TicksPerQuarterNote;
		u02B7_u02BD_u02BB_u02BB_u02BF_u02B5_u02C0_u02C1_u02BD_u02B3_u02B.\u02C0\u02BB\u02BA\u02B7\u02BE\u02BF\u02BF\u02BB\u02BC\u02B2\u02BF = u02B7_u02BD_u02BB_u02BB_u02BF_u02B5_u02C0_u02C1_u02BD_u02B3_u02B.\u02C0\u02B3\u02C1\u02BB\u02B5\u02BA\u02BB\u02B3\u02C1\u02B8\u02BD * SettingsController.\u02B3\u02B7\u02B4\u02BA\u02B3\u02B9\u02B7\u02BE\u02B2\u02B7\u02BE.GetFloatPercent;
		\u02BB\u02C0\u02B5\u02C1\u02BA\u02B7\u02B3\u02C0\u02B7\u02BB\u02B3.\u02B8\u02C1\u02BF\u02BF\u02BE\u02BE\u02B7\u02B6\u02BB\u02BB\u02B7(trackChunks.First<TrackChunk>().Events, u02B7_u02BD_u02BB_u02BB_u02BF_u02B5_u02C0_u02C1_u02BD_u02B3_u02B);
		foreach (TrackChunk trackChunk in trackChunks.Skip(1))
		{
			string text = \u02BB\u02C0\u02B5\u02C1\u02BA\u02B7\u02B3\u02C0\u02B7\u02BB\u02B3.\u02C0\u02BF\u02B7\u02B9\u02B5\u02B2\u02B5\u02B8\u02BC\u02B3\u02BE(trackChunk.Events);
			uint num = PrivateImplementationDetails.ComputeStringHash(text);
			if (num <= 2134366526U)
			{
				if (num <= 583162216U)
				{
					if (num != 316203908U)
					{
						if (num != 395196942U)
						{
							if (num != 583162216U)
							{
								continue;
							}
							if (!(text == "part keys"))
							{
								continue;
							}
							\u02BB\u02C0\u02B5\u02C1\u02BA\u02B7\u02B3\u02C0\u02B7\u02BB\u02B3.\u02BA\u02B4\u02B8\u02B6\u02BC\u02BA\u02C0\u02B6\u02B9\u02B6\u02BE(trackChunk.Events, u02B7_u02BD_u02BB_u02BB_u02BF_u02B5_u02C0_u02C1_u02BD_u02B3_u02B, \u02B7\u02BD\u02BB\u02BB\u02BF\u02B5\u02C0\u02C1\u02BD\u02B3\u02B6.\u02BC\u02C0\u02BC\u02B3\u02B4\u02C1\u02B3\u02BE\u02B2\u02C1\u02BE.Keys);
							continue;
						}
						else
						{
							if (!(text == "part guitar coop ghl"))
							{
								continue;
							}
							\u02BB\u02C0\u02B5\u02C1\u02BA\u02B7\u02B3\u02C0\u02B7\u02BB\u02B3.\u02BA\u02B4\u02B8\u02B6\u02BC\u02BA\u02C0\u02B6\u02B9\u02B6\u02BE(trackChunk.Events, u02B7_u02BD_u02BB_u02BB_u02BF_u02B5_u02C0_u02C1_u02BD_u02B3_u02B, \u02B7\u02BD\u02BB\u02BB\u02BF\u02B5\u02C0\u02C1\u02BD\u02B3\u02B6.\u02BC\u02C0\u02BC\u02B3\u02B4\u02C1\u02B3\u02BE\u02B2\u02C1\u02BE.GHLGuitarCoop);
							continue;
						}
					}
					else
					{
						if (!(text == "events"))
						{
							continue;
						}
						\u02BB\u02C0\u02B5\u02C1\u02BA\u02B7\u02B3\u02C0\u02B7\u02BB\u02B3.\u02B2\u02BC\u02B5\u02C1\u02C1\u02B2\u02B3\u02BB\u02C1\u02B7\u02BB(trackChunk.Events, u02B7_u02BD_u02BB_u02BB_u02BF_u02B5_u02C0_u02C1_u02BD_u02B3_u02B);
						continue;
					}
				}
				else if (num <= 1314878412U)
				{
					if (num != 969470554U)
					{
						if (num != 1314878412U)
						{
							continue;
						}
						if (!(text == "part rhythm"))
						{
							continue;
						}
						\u02BB\u02C0\u02B5\u02C1\u02BA\u02B7\u02B3\u02C0\u02B7\u02BB\u02B3.\u02BA\u02B4\u02B8\u02B6\u02BC\u02BA\u02C0\u02B6\u02B9\u02B6\u02BE(trackChunk.Events, u02B7_u02BD_u02BB_u02BB_u02BF_u02B5_u02C0_u02C1_u02BD_u02B3_u02B, \u02B7\u02BD\u02BB\u02BB\u02BF\u02B5\u02C0\u02C1\u02BD\u02B3\u02B6.\u02BC\u02C0\u02BC\u02B3\u02B4\u02C1\u02B3\u02BE\u02B2\u02C1\u02BE.Rhythm);
						continue;
					}
					else
					{
						if (!(text == "part vocals"))
						{
							continue;
						}
						\u02BB\u02C0\u02B5\u02C1\u02BA\u02B7\u02B3\u02C0\u02B7\u02BB\u02B3.\u02B6\u02B7\u02B5\u02BD\u02BB\u02B6\u02BD\u02BE\u02B7\u02BE\u02B7(trackChunk.Events, u02B7_u02BD_u02BB_u02BB_u02BF_u02B5_u02C0_u02C1_u02BD_u02B3_u02B);
						continue;
					}
				}
				else if (num != 1456160580U)
				{
					if (num != 2134366526U)
					{
						continue;
					}
					if (!(text == "t1 gems"))
					{
						continue;
					}
				}
				else
				{
					if (!(text == "part drum"))
					{
						continue;
					}
					goto IL_0341;
				}
			}
			else if (num <= 2594645819U)
			{
				if (num <= 2387209770U)
				{
					if (num != 2329120099U)
					{
						if (num != 2387209770U)
						{
							continue;
						}
						if (!(text == "part bass ghl"))
						{
							continue;
						}
						\u02BB\u02C0\u02B5\u02C1\u02BA\u02B7\u02B3\u02C0\u02B7\u02BB\u02B3.\u02BA\u02B4\u02B8\u02B6\u02BC\u02BA\u02C0\u02B6\u02B9\u02B6\u02BE(trackChunk.Events, u02B7_u02BD_u02BB_u02BB_u02BF_u02B5_u02C0_u02C1_u02BD_u02B3_u02B, \u02B7\u02BD\u02BB\u02BB\u02BF\u02B5\u02C0\u02C1\u02BD\u02B3\u02B6.\u02BC\u02C0\u02BC\u02B3\u02B4\u02C1\u02B3\u02BE\u02B2\u02C1\u02BE.GHLBass);
						continue;
					}
					else
					{
						if (!(text == "part guitar coop"))
						{
							continue;
						}
						\u02BB\u02C0\u02B5\u02C1\u02BA\u02B7\u02B3\u02C0\u02B7\u02BB\u02B3.\u02BA\u02B4\u02B8\u02B6\u02BC\u02BA\u02C0\u02B6\u02B9\u02B6\u02BE(trackChunk.Events, u02B7_u02BD_u02BB_u02BB_u02BF_u02B5_u02C0_u02C1_u02BD_u02B3_u02B, \u02B7\u02BD\u02BB\u02BB\u02BF\u02B5\u02C0\u02C1\u02BD\u02B3\u02B6.\u02BC\u02C0\u02BC\u02B3\u02B4\u02C1\u02B3\u02BE\u02B2\u02C1\u02BE.GuitarCoop);
						continue;
					}
				}
				else if (num != 2421315013U)
				{
					if (num != 2594645819U)
					{
						continue;
					}
					if (!(text == "part guitar ghl"))
					{
						continue;
					}
					\u02BB\u02C0\u02B5\u02C1\u02BA\u02B7\u02B3\u02C0\u02B7\u02BB\u02B3.\u02BA\u02B4\u02B8\u02B6\u02BC\u02BA\u02C0\u02B6\u02B9\u02B6\u02BE(trackChunk.Events, u02B7_u02BD_u02BB_u02BB_u02BF_u02B5_u02C0_u02C1_u02BD_u02B3_u02B, \u02B7\u02BD\u02BB\u02BB\u02BF\u02B5\u02C0\u02C1\u02BD\u02B3\u02B6.\u02BC\u02C0\u02BC\u02B3\u02B4\u02C1\u02B3\u02BE\u02B2\u02C1\u02BE.GHLGuitar);
					continue;
				}
				else
				{
					if (!(text == "beat"))
					{
						continue;
					}
					continue;
				}
			}
			else if (num <= 3639903125U)
			{
				if (num != 3225037695U)
				{
					if (num != 3639903125U)
					{
						continue;
					}
					if (!(text == "part drums"))
					{
						continue;
					}
					goto IL_0341;
				}
				else
				{
					if (!(text == "part bass"))
					{
						continue;
					}
					\u02BB\u02C0\u02B5\u02C1\u02BA\u02B7\u02B3\u02C0\u02B7\u02BB\u02B3.\u02BA\u02B4\u02B8\u02B6\u02BC\u02BA\u02C0\u02B6\u02B9\u02B6\u02BE(trackChunk.Events, u02B7_u02BD_u02BB_u02BB_u02BF_u02B5_u02C0_u02C1_u02BD_u02B3_u02B, \u02B7\u02BD\u02BB\u02BB\u02BF\u02B5\u02C0\u02C1\u02BD\u02B3\u02B6.\u02BC\u02C0\u02BC\u02B3\u02B4\u02C1\u02B3\u02BE\u02B2\u02C1\u02BE.Bass);
					continue;
				}
			}
			else if (num != 3641264310U)
			{
				if (num != 4054283357U)
				{
					continue;
				}
				if (!(text == "part rhythm ghl"))
				{
					continue;
				}
				\u02BB\u02C0\u02B5\u02C1\u02BA\u02B7\u02B3\u02C0\u02B7\u02BB\u02B3.\u02BA\u02B4\u02B8\u02B6\u02BC\u02BA\u02C0\u02B6\u02B9\u02B6\u02BE(trackChunk.Events, u02B7_u02BD_u02BB_u02BB_u02BF_u02B5_u02C0_u02C1_u02BD_u02B3_u02B, \u02B7\u02BD\u02BB\u02BB\u02BF\u02B5\u02C0\u02C1\u02BD\u02B3\u02B6.\u02BC\u02C0\u02BC\u02B3\u02B4\u02C1\u02B3\u02BE\u02B2\u02C1\u02BE.GHLRhythm);
				continue;
			}
			else if (!(text == "part guitar"))
			{
				continue;
			}
			\u02BB\u02C0\u02B5\u02C1\u02BA\u02B7\u02B3\u02C0\u02B7\u02BB\u02B3.\u02BA\u02B4\u02B8\u02B6\u02BC\u02BA\u02C0\u02B6\u02B9\u02B6\u02BE(trackChunk.Events, u02B7_u02BD_u02BB_u02BB_u02BF_u02B5_u02C0_u02C1_u02BD_u02B3_u02B, \u02B7\u02BD\u02BB\u02BB\u02BF\u02B5\u02C0\u02C1\u02BD\u02B3\u02B6.\u02BC\u02C0\u02BC\u02B3\u02B4\u02C1\u02B3\u02BE\u02B2\u02C1\u02BE.Guitar);
			continue;
			IL_0341:
			\u02BB\u02C0\u02B5\u02C1\u02BA\u02B7\u02B3\u02C0\u02B7\u02BB\u02B3.\u02B5\u02BD\u02B3\u02B7\u02BF\u02BE\u02B4\u02BB\u02B8\u02BF\u02BE(trackChunk.Events, u02B7_u02BD_u02BB_u02BB_u02BF_u02B5_u02C0_u02C1_u02BD_u02B3_u02B, \u02B7\u02BD\u02BB\u02BB\u02BF\u02B5\u02C0\u02C1\u02BD\u02B3\u02B6.\u02BC\u02C0\u02BC\u02B3\u02B4\u02C1\u02B3\u02BE\u02B2\u02C1\u02BE.Drums);
		}
		if (!\u02BB\u02C0\u02B5\u02C1\u02BA\u02B7\u02B3\u02C0\u02B7\u02BB\u02B3.\u02B8\u02B3\u02B9\u02BD\u02BC\u02BD\u02B5\u02C0\u02BD\u02BC\u02BA)
		{
			u02B7_u02BD_u02BB_u02BB_u02BF_u02B5_u02C0_u02C1_u02BD_u02B3_u02B.\u02BD\u02B3\u02B6\u02B2\u02BE\u02B5\u02B4\u02BB\u02BD\u02BB\u02BA();
			u02B7_u02BD_u02BB_u02BB_u02BF_u02B5_u02C0_u02C1_u02BD_u02B3_u02B.\u02B5\u02B9\u02C1\u02C0\u02B7\u02BD\u02BE\u02B2\u02C1\u02B2\u02B6.\u02B4\u02C0\u02B2\u02B8\u02B7\u02B6\u02C1\u02C0\u02BA\u02B6\u02B2(u02B7_u02BD_u02BB_u02BB_u02BF_u02B5_u02C0_u02C1_u02BD_u02B3_u02B);
		}
		return u02B7_u02BD_u02BB_u02BB_u02BF_u02B5_u02C0_u02C1_u02BD_u02B3_u02B;
	}

	public static \u02B7\u02BD\u02BB\u02BB\u02BF\u02B5\u02C0\u02C1\u02BD\u02B3\u02B6 \u02BB\u02B5\u02C0\u02B8\u02B2\u02B6\u02C0\u02C1\u02B2\u02B5\u02C1(string \u02B5\u02BF\u02B4\u02C1\u02BE\u02B7\u02C0\u02B9\u02C1\u02B8\u02BC, bool \u02B2\u02BB\u02B5\u02B5\u02C0\u02C1\u02B8\u02BA\u02B7\u02C0\u02B9)
	{
		byte[] array = \u02C1\u02B4\u02BB\u02B9\u02B5\u02B6\u02B2\u02BA\u02B8\u02C1\u02BE.\u02C1\u02B9\u02B7\u02BC\u02B4\u02BF\u02B6\u02B4\u02B9\u02BD\u02BD(Path.Combine(\u02B5\u02BF\u02B4\u02C1\u02BE\u02B7\u02C0\u02B9\u02C1\u02B8\u02BC, "notes.mid"));
		MidiFile midiFile;
		try
		{
			midiFile = MidiFile.Read(array, null);
		}
		catch (SystemException ex)
		{
			Debug.LogException(ex);
			return null;
		}
		return \u02BB\u02C0\u02B5\u02C1\u02BA\u02B7\u02B3\u02C0\u02B7\u02BB\u02B3.\u02B8\u02B3\u02BA\u02BD\u02B8\u02C0\u02B2\u02B4\u02B8\u02BE\u02C1(midiFile, \u02B2\u02BB\u02B5\u02B5\u02C0\u02C1\u02B8\u02BA\u02B7\u02C0\u02B9);
	}

	public static \u02B7\u02BD\u02BB\u02BB\u02BF\u02B5\u02C0\u02C1\u02BD\u02B3\u02B6 \u02BB\u02B5\u02C0\u02B8\u02B2\u02B6\u02C0\u02C1\u02B2\u02B5\u02C1(byte[] \u02B5\u02B2\u02BE\u02B9\u02B9\u02C1\u02BF\u02B5\u02BA\u02C0\u02B8, bool \u02B2\u02BB\u02B5\u02B5\u02C0\u02C1\u02B8\u02BA\u02B7\u02C0\u02B9)
	{
		MidiFile midiFile;
		try
		{
			midiFile = MidiFile.Read(\u02B5\u02B2\u02BE\u02B9\u02B9\u02C1\u02BF\u02B5\u02BA\u02C0\u02B8, null);
		}
		catch (SystemException ex)
		{
			Debug.LogException(ex);
			return null;
		}
		return \u02BB\u02C0\u02B5\u02C1\u02BA\u02B7\u02B3\u02C0\u02B7\u02BB\u02B3.\u02B8\u02B3\u02BA\u02BD\u02B8\u02C0\u02B2\u02B4\u02B8\u02BE\u02C1(midiFile, \u02B2\u02BB\u02B5\u02B5\u02C0\u02C1\u02B8\u02BA\u02B7\u02C0\u02B9);
	}

	private static void \u02B6\u02B7\u02B5\u02BD\u02BB\u02B6\u02BD\u02BE\u02B7\u02BE\u02B7(EventsCollection \u02BB\u02BF\u02BF\u02B4\u02B3\u02BE\u02C0\u02BB\u02C0\u02BA\u02B2, \u02B7\u02BD\u02BB\u02BB\u02BF\u02B5\u02C0\u02C1\u02BD\u02B3\u02B6 \u02B4\u02BC\u02BF\u02BC\u02BA\u02B9\u02B8\u02B2\u02BD\u02BE\u02BD)
	{
		NoteOnEvent noteOnEvent = null;
		bool flag = false;
		bool flag2 = false;
		bool flag3 = false;
		int num = 0;
		int i = 0;
		while (i < \u02BB\u02BF\u02BF\u02B4\u02B3\u02BE\u02C0\u02BB\u02C0\u02BA\u02B2.Count)
		{
			if (\u02BB\u02BF\u02BF\u02B4\u02B3\u02BE\u02C0\u02BB\u02C0\u02BA\u02B2[i].AbsoluteTime != \u02BB\u02BF\u02BF\u02B4\u02B3\u02BE\u02C0\u02BB\u02C0\u02BA\u02B2[num].AbsoluteTime)
			{
				num = i;
			}
			NoteOnEvent noteOnEvent2 = \u02BB\u02BF\u02BF\u02B4\u02B3\u02BE\u02C0\u02BB\u02C0\u02BA\u02B2[i] as NoteOnEvent;
			if (noteOnEvent2 != null && noteOnEvent2.OffEvent != null)
			{
				if (noteOnEvent2.NoteNumber == 105 || noteOnEvent2.NoteNumber == 106)
				{
					if (noteOnEvent != null && noteOnEvent.AbsoluteTime == noteOnEvent2.AbsoluteTime)
					{
						if (noteOnEvent.NoteNumber == 106)
						{
							noteOnEvent = noteOnEvent2;
						}
					}
					else
					{
						noteOnEvent = noteOnEvent2;
						flag = false;
						\u02B4\u02BC\u02BF\u02BC\u02BA\u02B9\u02B8\u02B2\u02BD\u02BE\u02BD.\u02BF\u02B8\u02BE\u02BE\u02BA\u02B8\u02B6\u02B2\u02B4\u02B7\u02B5.Add(new \u02BD\u02B5\u02B3\u02BB\u02B4\u02B8\u02BF\u02B9\u02B3\u02BC\u02B5(\u02BD\u02B5\u02B3\u02BB\u02B4\u02B8\u02BF\u02B9\u02B3\u02BC\u02B5.\u02BD\u02BD\u02B3\u02BE\u02BF\u02C0\u02B9\u02BF\u02BB\u02B7\u02BE.PhraseStart, (uint)noteOnEvent2.AbsoluteTime, string.Empty));
						if (!flag3)
						{
							long num2 = 0L;
							long num3 = 0L;
							for (int j = num; j < \u02BB\u02BF\u02BF\u02B4\u02B3\u02BE\u02C0\u02BB\u02C0\u02BA\u02B2.Count; j++)
							{
								long absoluteTime = \u02BB\u02BF\u02BF\u02B4\u02B3\u02BE\u02C0\u02BB\u02C0\u02BA\u02B2[j].AbsoluteTime;
								if (absoluteTime > num2 && absoluteTime > num3 && num3 > num2)
								{
									\u02B4\u02BC\u02BF\u02BC\u02BA\u02B9\u02B8\u02B2\u02BD\u02BE\u02BD.\u02BA\u02BC\u02B8\u02B7\u02B9\u02B7\u02BE\u02B4\u02B4\u02B5\u02BA();
									flag3 = true;
									break;
								}
								BaseTextEvent baseTextEvent = \u02BB\u02BF\u02BF\u02B4\u02B3\u02BE\u02C0\u02BB\u02C0\u02BA\u02B2[j] as BaseTextEvent;
								if (baseTextEvent != null && baseTextEvent.Text != null && baseTextEvent.Text[0] != '[')
								{
									num3 = baseTextEvent.AbsoluteTime;
								}
								else
								{
									NoteOnEvent noteOnEvent3 = \u02BB\u02BF\u02BF\u02B4\u02B3\u02BE\u02C0\u02BB\u02C0\u02BA\u02B2[j] as NoteOnEvent;
									if (noteOnEvent3 != null && noteOnEvent3.NoteNumber >= 36 && noteOnEvent3.NoteNumber <= 84)
									{
										num2 = noteOnEvent3.AbsoluteTime;
										break;
									}
								}
							}
							goto IL_0290;
						}
						goto IL_0290;
					}
				}
				else
				{
					if (flag2 && noteOnEvent2.NoteNumber >= 36 && noteOnEvent2.NoteNumber <= 84)
					{
						int num4 = num;
						while (\u02BB\u02BF\u02BF\u02B4\u02B3\u02BE\u02C0\u02BB\u02C0\u02BA\u02B2[num4].AbsoluteTime == noteOnEvent2.AbsoluteTime)
						{
							BaseTextEvent baseTextEvent2 = \u02BB\u02BF\u02BF\u02B4\u02B3\u02BE\u02C0\u02BB\u02C0\u02BA\u02B2[num4] as BaseTextEvent;
							if (baseTextEvent2 != null && baseTextEvent2.Text != null && baseTextEvent2.Text[0] != '[')
							{
								\u02B4\u02BC\u02BF\u02BC\u02BA\u02B9\u02B8\u02B2\u02BD\u02BE\u02BD.\u02BF\u02B8\u02BE\u02BE\u02BA\u02B8\u02B6\u02B2\u02B4\u02B7\u02B5.Add(new \u02BD\u02B5\u02B3\u02BB\u02B4\u02B8\u02BF\u02B9\u02B3\u02BC\u02B5(\u02BD\u02B5\u02B3\u02BB\u02B4\u02B8\u02BF\u02B9\u02B3\u02BC\u02B5.\u02BD\u02BD\u02B3\u02BE\u02BF\u02C0\u02B9\u02BF\u02BB\u02B7\u02BE.LyricText, (uint)baseTextEvent2.AbsoluteTime, baseTextEvent2.Text));
								break;
							}
							num4++;
						}
						goto IL_0290;
					}
					goto IL_0290;
				}
			}
			else
			{
				if (flag2)
				{
					goto IL_0290;
				}
				BaseTextEvent baseTextEvent3 = \u02BB\u02BF\u02BF\u02B4\u02B3\u02BE\u02C0\u02BB\u02C0\u02BA\u02B2[i] as BaseTextEvent;
				if (baseTextEvent3 != null && baseTextEvent3.Text != null && baseTextEvent3.Text[0] != '[')
				{
					\u02B4\u02BC\u02BF\u02BC\u02BA\u02B9\u02B8\u02B2\u02BD\u02BE\u02BD.\u02BF\u02B8\u02BE\u02BE\u02BA\u02B8\u02B6\u02B2\u02B4\u02B7\u02B5.Add(new \u02BD\u02B5\u02B3\u02BB\u02B4\u02B8\u02BF\u02B9\u02B3\u02BC\u02B5(\u02BD\u02B5\u02B3\u02BB\u02B4\u02B8\u02BF\u02B9\u02B3\u02BC\u02B5.\u02BD\u02BD\u02B3\u02BE\u02BF\u02C0\u02B9\u02BF\u02BB\u02B7\u02BE.LyricText, (uint)baseTextEvent3.AbsoluteTime, baseTextEvent3.Text));
					goto IL_0290;
				}
				goto IL_0290;
			}
			IL_02EA:
			i++;
			continue;
			IL_0290:
			if (noteOnEvent != null && noteOnEvent.OffEvent != null && (i == \u02BB\u02BF\u02BF\u02B4\u02B3\u02BE\u02C0\u02BB\u02C0\u02BA\u02B2.Count - 1 || \u02BB\u02BF\u02BF\u02B4\u02B3\u02BE\u02C0\u02BB\u02C0\u02BA\u02B2[i + 1].AbsoluteTime >= noteOnEvent.OffEvent.AbsoluteTime) && !flag)
			{
				flag = true;
				\u02B4\u02BC\u02BF\u02BC\u02BA\u02B9\u02B8\u02B2\u02BD\u02BE\u02BD.\u02BF\u02B8\u02BE\u02BE\u02BA\u02B8\u02B6\u02B2\u02B4\u02B7\u02B5.Add(new \u02BD\u02B5\u02B3\u02BB\u02B4\u02B8\u02BF\u02B9\u02B3\u02BC\u02B5(\u02BD\u02B5\u02B3\u02BB\u02B4\u02B8\u02BF\u02B9\u02B3\u02BC\u02B5.\u02BD\u02BD\u02B3\u02BE\u02BF\u02C0\u02B9\u02BF\u02BB\u02B7\u02BE.PhraseEnd, (uint)noteOnEvent.OffEvent.AbsoluteTime, string.Empty));
				goto IL_02EA;
			}
			goto IL_02EA;
		}
	}

	private static void \u02B8\u02C1\u02BF\u02BF\u02BE\u02BE\u02B7\u02B6\u02BB\u02BB\u02B7(EventsCollection \u02BB\u02BF\u02BF\u02B4\u02B3\u02BE\u02C0\u02BB\u02C0\u02BA\u02B2, \u02B7\u02BD\u02BB\u02BB\u02BF\u02B5\u02C0\u02C1\u02BD\u02B3\u02B6 \u02B4\u02BC\u02BF\u02BC\u02BA\u02B9\u02B8\u02B2\u02BD\u02BE\u02BD)
	{
		if (!\u02BB\u02C0\u02B5\u02C1\u02BA\u02B7\u02B3\u02C0\u02B7\u02BB\u02B3.\u02B8\u02B3\u02B9\u02BD\u02BC\u02BD\u02B5\u02C0\u02BD\u02BC\u02BA)
		{
			foreach (MidiEvent midiEvent in \u02BB\u02BF\u02BF\u02B4\u02B3\u02BE\u02C0\u02BB\u02C0\u02BA\u02B2)
			{
				long absoluteTime = midiEvent.AbsoluteTime;
				TimeSignatureEvent timeSignatureEvent = midiEvent as TimeSignatureEvent;
				if (timeSignatureEvent != null)
				{
					\u02B4\u02BC\u02BF\u02BC\u02BA\u02B9\u02B8\u02B2\u02BD\u02BE\u02BD.\u02BC\u02BA\u02BE\u02BC\u02C1\u02BC\u02B9\u02C1\u02C1\u02B7\u02BB(new \u02C0\u02B8\u02BC\u02B9\u02BD\u02BA\u02B8\u02C0\u02B7\u02BD\u02B5((uint)absoluteTime, (uint)timeSignatureEvent.Numerator, (uint)timeSignatureEvent.Denominator));
				}
				else
				{
					SetTempoEvent setTempoEvent = midiEvent as SetTempoEvent;
					if (setTempoEvent != null)
					{
						\u02B4\u02BC\u02BF\u02BC\u02BA\u02B9\u02B8\u02B2\u02BD\u02BE\u02BD.\u02BC\u02BA\u02BE\u02BC\u02C1\u02BC\u02B9\u02C1\u02C1\u02B7\u02BB(new \u02BC\u02B9\u02B5\u02C1\u02B8\u02B3\u02BE\u02BA\u02C1\u02B3\u02BD((uint)absoluteTime, (uint)(60000000.0 / (double)setTempoEvent.MicrosecondsPerQuarterNote * 1000.0)));
					}
					else
					{
						TextEvent textEvent = midiEvent as TextEvent;
						if (textEvent != null)
						{
							\u02B4\u02BC\u02BF\u02BC\u02BA\u02B9\u02B8\u02B2\u02BD\u02BE\u02BD.\u02BF\u02B4\u02C1\u02BC\u02BC\u02B2\u02BC\u02BB\u02BA\u02B2\u02B6 = textEvent.Text;
						}
					}
				}
			}
		}
	}

	private static void \u02B2\u02BC\u02B5\u02C1\u02C1\u02B2\u02B3\u02BB\u02C1\u02B7\u02BB(EventsCollection \u02BB\u02BF\u02BF\u02B4\u02B3\u02BE\u02C0\u02BB\u02C0\u02BA\u02B2, \u02B7\u02BD\u02BB\u02BB\u02BF\u02B5\u02C0\u02C1\u02BD\u02B3\u02B6 \u02B4\u02BC\u02BF\u02BC\u02BA\u02B9\u02B8\u02B2\u02BD\u02BE\u02BD)
	{
		for (int i = 0; i < \u02BB\u02BF\u02BF\u02B4\u02B3\u02BE\u02C0\u02BB\u02C0\u02BA\u02B2.Count; i++)
		{
			TextEvent textEvent = \u02BB\u02BF\u02BF\u02B4\u02B3\u02BE\u02C0\u02BB\u02C0\u02BA\u02B2[i] as TextEvent;
			if (textEvent != null && textEvent.Text != null)
			{
				if (textEvent.Text.Contains("[section ") && !textEvent.Text.Contains("_ENDOFSONG"))
				{
					string text = textEvent.Text.Substring(9, textEvent.Text.Length - 10);
					string text2;
					if (\u02BD\u02BF\u02BF\u02BF\u02B3\u02C1\u02BC\u02B4\u02B4\u02B6\u02BA.\u02BB\u02C0\u02B8\u02B4\u02B5\u02B7\u02B7\u02BE\u02B3\u02B9\u02C0.TryGetValue(text, out text2))
					{
						\u02B4\u02BC\u02BF\u02BC\u02BA\u02B9\u02B8\u02B2\u02BD\u02BE\u02BD.\u02BC\u02BA\u02BE\u02BC\u02C1\u02BC\u02B9\u02C1\u02C1\u02B7\u02BB(new \u02B8\u02BB\u02B2\u02B5\u02C1\u02C1\u02BB\u02B7\u02B3\u02B4\u02B6(text2, (uint)textEvent.AbsoluteTime));
					}
					else
					{
						\u02B4\u02BC\u02BF\u02BC\u02BA\u02B9\u02B8\u02B2\u02BD\u02BE\u02BD.\u02BC\u02BA\u02BE\u02BC\u02C1\u02BC\u02B9\u02C1\u02C1\u02B7\u02BB(new \u02B8\u02BB\u02B2\u02B5\u02C1\u02C1\u02BB\u02B7\u02B3\u02B4\u02B6(text.Replace('_', ' '), (uint)textEvent.AbsoluteTime));
					}
				}
				else if (textEvent.Text.Contains("[prc_"))
				{
					string text3 = textEvent.Text.Substring(5, textEvent.Text.Length - 6);
					string text4;
					if (\u02BD\u02BF\u02BF\u02BF\u02B3\u02C1\u02BC\u02B4\u02B4\u02B6\u02BA.\u02BB\u02C0\u02B8\u02B4\u02B5\u02B7\u02B7\u02BE\u02B3\u02B9\u02C0.TryGetValue(text3, out text4))
					{
						\u02B4\u02BC\u02BF\u02BC\u02BA\u02B9\u02B8\u02B2\u02BD\u02BE\u02BD.\u02BC\u02BA\u02BE\u02BC\u02C1\u02BC\u02B9\u02C1\u02C1\u02B7\u02BB(new \u02B8\u02BB\u02B2\u02B5\u02C1\u02C1\u02BB\u02B7\u02B3\u02B4\u02B6(text4, (uint)textEvent.AbsoluteTime));
					}
					else
					{
						\u02B4\u02BC\u02BF\u02BC\u02BA\u02B9\u02B8\u02B2\u02BD\u02BE\u02BD.\u02BC\u02BA\u02BE\u02BC\u02C1\u02BC\u02B9\u02C1\u02C1\u02B7\u02BB(new \u02B8\u02BB\u02B2\u02B5\u02C1\u02C1\u02BB\u02B7\u02B3\u02B4\u02B6(text3.Replace('_', ' '), (uint)textEvent.AbsoluteTime));
					}
				}
				else if (textEvent.Text.Equals("[end]"))
				{
					\u02B4\u02BC\u02BF\u02BC\u02BA\u02B9\u02B8\u02B2\u02BD\u02BE\u02BD.\u02C1\u02B6\u02B2\u02BE\u02B9\u02BB\u02BF\u02BE\u02C1\u02BE\u02BE((uint)textEvent.AbsoluteTime);
				}
				else if (textEvent.Text.Equals("[coda]"))
				{
					\u02B4\u02BC\u02BF\u02BC\u02BA\u02B9\u02B8\u02B2\u02BD\u02BE\u02BD.\u02BE\u02B9\u02B7\u02C0\u02BC\u02BC\u02C1\u02BD\u02BC\u02BD\u02BE = new \u02BB\u02C0\u02C1\u02B8\u02BE\u02B2\u02B9\u02B2\u02B6\u02B8\u02B4((uint)textEvent.AbsoluteTime, "coda");
				}
			}
		}
	}

	private static void \u02BA\u02B4\u02B8\u02B6\u02BC\u02BA\u02C0\u02B6\u02B9\u02B6\u02BE(EventsCollection \u02BB\u02BF\u02BF\u02B4\u02B3\u02BE\u02C0\u02BB\u02C0\u02BA\u02B2, \u02B7\u02BD\u02BB\u02BB\u02BF\u02B5\u02C0\u02C1\u02BD\u02B3\u02B6 \u02B4\u02BC\u02BF\u02BC\u02BA\u02B9\u02B8\u02B2\u02BD\u02BE\u02BD, \u02B7\u02BD\u02BB\u02BB\u02BF\u02B5\u02C0\u02C1\u02BD\u02B3\u02B6.\u02BC\u02C0\u02BC\u02B3\u02B4\u02C1\u02B3\u02BE\u02B2\u02C1\u02BE \u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF)
	{
		List<NoteOnEvent> list = null;
		List<NoteOnEvent> list2 = null;
		List<SysExEvent> list3 = null;
		List<int> list4 = null;
		bool flag = false;
		if (\u02BB\u02C0\u02B5\u02C1\u02BA\u02B7\u02B3\u02C0\u02B7\u02BB\u02B3.\u02B8\u02B3\u02B9\u02BD\u02BC\u02BD\u02B5\u02C0\u02BD\u02BC\u02BA)
		{
			list4 = new List<int>(10);
		}
		else
		{
			list = new List<NoteOnEvent>(500);
			list3 = new List<SysExEvent>(500);
			list2 = new List<NoteOnEvent>(500);
		}
		\u02B7\u02BD\u02BB\u02BB\u02BF\u02B5\u02C0\u02C1\u02BD\u02B3\u02B6.\u02BA\u02BF\u02B9\u02B7\u02B4\u02B7\u02B4\u02BD\u02BF\u02B4\u02B7[] array = Enum.GetValues(typeof(\u02B7\u02BD\u02BB\u02BB\u02BF\u02B5\u02C0\u02C1\u02BD\u02B3\u02B6.\u02BA\u02BF\u02B9\u02B7\u02B4\u02B7\u02B4\u02BD\u02BF\u02B4\u02B7)) as \u02B7\u02BD\u02BB\u02BB\u02BF\u02B5\u02C0\u02C1\u02BD\u02B3\u02B6.\u02BA\u02BF\u02B9\u02B7\u02B4\u02B7\u02B4\u02BD\u02BF\u02B4\u02B7[];
		byte b = 0;
		if (!\u02BB\u02C0\u02B5\u02C1\u02BA\u02B7\u02B3\u02C0\u02B7\u02BB\u02B3.\u02B8\u02B3\u02B9\u02BD\u02BC\u02BD\u02B5\u02C0\u02BD\u02BC\u02BA)
		{
			b = \u02BB\u02C0\u02B5\u02C1\u02BA\u02B7\u02B3\u02C0\u02B7\u02BB\u02B3.\u02B4\u02B4\u02BE\u02B7\u02B6\u02B6\u02B8\u02B2\u02C0\u02B6\u02C1(\u02BB\u02BF\u02BF\u02B4\u02B3\u02BE\u02C0\u02BB\u02C0\u02BA\u02B2);
		}
		foreach (MidiEvent midiEvent in \u02BB\u02BF\u02BF\u02B4\u02B3\u02BE\u02C0\u02BB\u02C0\u02BA\u02B2)
		{
			NoteOnEvent noteOnEvent = midiEvent as NoteOnEvent;
			if (noteOnEvent != null && noteOnEvent.OffEvent != null)
			{
				uint num = (uint)noteOnEvent.AbsoluteTime;
				uint num2 = (uint)(noteOnEvent.OffEvent.AbsoluteTime - (long)((ulong)num));
				if (!\u02BB\u02C0\u02B5\u02C1\u02BA\u02B7\u02B3\u02C0\u02B7\u02BB\u02B3.\u02B8\u02B3\u02B9\u02BD\u02BC\u02BD\u02B5\u02C0\u02BD\u02BC\u02BA)
				{
					if (noteOnEvent.NoteNumber == b)
					{
						foreach (\u02B7\u02BD\u02BB\u02BB\u02BF\u02B5\u02C0\u02C1\u02BD\u02B3\u02B6.\u02BA\u02BF\u02B9\u02B7\u02B4\u02B7\u02B4\u02BD\u02BF\u02B4\u02B7 u02BA_u02BF_u02B9_u02B7_u02B4_u02B7_u02B4_u02BD_u02BF_u02B4_u02B in array)
						{
							\u02B4\u02BC\u02BF\u02BC\u02BA\u02B9\u02B8\u02B2\u02BD\u02BE\u02BD.\u02B8\u02C1\u02B8\u02C1\u02C0\u02B8\u02B5\u02B4\u02B6\u02BC\u02B7(\u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF, u02BA_u02BF_u02B9_u02B7_u02B4_u02B7_u02B4_u02BD_u02BF_u02B4_u02B).\u02BC\u02BA\u02BE\u02BC\u02C1\u02BC\u02B9\u02C1\u02C1\u02B7\u02BB(new \u02BC\u02BD\u02B3\u02B5\u02B4\u02B7\u02BE\u02BC\u02BD\u02C1\u02B7(num, num2));
						}
						continue;
					}
					if (noteOnEvent.NoteNumber == 103)
					{
						foreach (\u02B7\u02BD\u02BB\u02BB\u02BF\u02B5\u02C0\u02C1\u02BD\u02B3\u02B6.\u02BA\u02BF\u02B9\u02B7\u02B4\u02B7\u02B4\u02BD\u02BF\u02B4\u02B7 u02BA_u02BF_u02B9_u02B7_u02B4_u02B7_u02B4_u02BD_u02BF_u02B4_u02B2 in array)
						{
							float num3 = \u02B4\u02BC\u02BF\u02BC\u02BA\u02B9\u02B8\u02B2\u02BD\u02BE\u02BD.\u02B9\u02B4\u02B6\u02B8\u02BE\u02B2\u02B6\u02C0\u02BC\u02BA\u02B7((uint)noteOnEvent.AbsoluteTime);
							float num4 = \u02B4\u02BC\u02BF\u02BC\u02BA\u02B9\u02B8\u02B2\u02BD\u02BE\u02BD.\u02B8\u02B3\u02BE\u02B8\u02BC\u02B9\u02BD\u02BE\u02BF\u02B8\u02B5((uint)noteOnEvent.AbsoluteTime, (uint)noteOnEvent.OffEvent.AbsoluteTime);
							\u02B2\u02BF\u02C1\u02B4\u02B3\u02BD\u02B7\u02BF\u02B3\u02BF\u02C0 u02B2_u02BF_u02C1_u02B4_u02B3_u02BD_u02B7_u02BF_u02B3_u02BF_u02C = new \u02B2\u02BF\u02C1\u02B4\u02B3\u02BD\u02B7\u02BF\u02B3\u02BF\u02C0
							{
								\u02B2\u02B8\u02BA\u02BA\u02BC\u02B7\u02B5\u02B5\u02B6\u02B5\u02C1 = num3,
								\u02BB\u02BE\u02BA\u02B8\u02BE\u02B9\u02BF\u02B3\u02B4\u02B8\u02BD = num4,
								\u02B5\u02BF\u02B5\u02B2\u02BD\u02BD\u02BD\u02B5\u02B8\u02C0\u02BE = (uint)noteOnEvent.AbsoluteTime,
								\u02B7\u02B3\u02BD\u02B5\u02B3\u02B4\u02BC\u02B2\u02B4\u02C1\u02B2 = (int)(noteOnEvent.OffEvent.AbsoluteTime - noteOnEvent.AbsoluteTime),
								\u02BB\u02BB\u02B7\u02C0\u02B7\u02BA\u02B8\u02B4\u02B5\u02B8\u02B5 = (uint)noteOnEvent.OffEvent.AbsoluteTime
							};
							\u02B4\u02BC\u02BF\u02BC\u02BA\u02B9\u02B8\u02B2\u02BD\u02BE\u02BD.\u02B8\u02C1\u02B8\u02C1\u02C0\u02B8\u02B5\u02B4\u02B6\u02BC\u02B7(\u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF, u02BA_u02BF_u02B9_u02B7_u02B4_u02B7_u02B4_u02BD_u02BF_u02B4_u02B2).\u02B3\u02B3\u02B4\u02BA\u02B9\u02B7\u02BA\u02B6\u02B4\u02C0\u02BD.Add(u02B2_u02BF_u02C1_u02B4_u02B3_u02BD_u02B7_u02BF_u02B3_u02BF_u02C);
						}
						continue;
					}
					if (104 == noteOnEvent.NoteNumber)
					{
						list2.Add(noteOnEvent);
						continue;
					}
					if (\u02B7\u02B9\u02BF\u02B4\u02BF\u02BF\u02C1\u02B3\u02B3\u02B8\u02B3.\u02B5\u02BD\u02B5\u02B4\u02B7\u02C0\u02BF\u02B8\u02BE\u02BF\u02B9(noteOnEvent.NoteNumber))
					{
						list.Add(noteOnEvent);
						continue;
					}
				}
				\u02B7\u02BD\u02BB\u02BB\u02BF\u02B5\u02C0\u02C1\u02BD\u02B3\u02B6.\u02BA\u02BF\u02B9\u02B7\u02B4\u02B7\u02B4\u02BD\u02BF\u02B4\u02B7? u02BA_u02BF_u02B9_u02B7_u02B4_u02B7_u02B4_u02BD_u02BF_u02B4_u02B3 = \u02B7\u02B9\u02BF\u02B4\u02BF\u02BF\u02C1\u02B3\u02B3\u02B8\u02B3.\u02BC\u02B4\u02B7\u02BD\u02C0\u02BA\u02BB\u02B9\u02BF\u02BA\u02B2((int)noteOnEvent.NoteNumber);
				if (u02BA_u02BF_u02B9_u02B7_u02B4_u02B7_u02B4_u02BD_u02BF_u02B4_u02B3 == null)
				{
					continue;
				}
				\u02B7\u02BD\u02BB\u02BB\u02BF\u02B5\u02C0\u02C1\u02BD\u02B3\u02B6.\u02BA\u02BF\u02B9\u02B7\u02B4\u02B7\u02B4\u02BD\u02BF\u02B4\u02B7 value = u02BA_u02BF_u02B9_u02B7_u02B4_u02B7_u02B4_u02BD_u02BF_u02B4_u02B3.Value;
				if (\u02BB\u02C0\u02B5\u02C1\u02BA\u02B7\u02B3\u02C0\u02B7\u02BB\u02B3.\u02B8\u02B3\u02B9\u02BD\u02BC\u02BD\u02B5\u02C0\u02BD\u02BC\u02BA && list4.Contains((int)value))
				{
					continue;
				}
				\u02BF\u02BF\u02BB\u02BC\u02B5\u02B9\u02B6\u02C1\u02BB\u02B3\u02BD.\u02C1\u02B2\u02B5\u02BE\u02C0\u02C0\u02C1\u02B2\u02B3\u02BE\u02BA u02C1_u02B2_u02B5_u02BE_u02C0_u02C0_u02C1_u02B2_u02B3_u02BE_u02BA;
				if (\u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF - \u02B7\u02BD\u02BB\u02BB\u02BF\u02B5\u02C0\u02C1\u02BD\u02B3\u02B6.\u02BC\u02C0\u02BC\u02B3\u02B4\u02C1\u02B3\u02BE\u02B2\u02C1\u02BE.GHLGuitar <= 1 || \u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF - \u02B7\u02BD\u02BB\u02BB\u02BF\u02B5\u02C0\u02C1\u02BD\u02B3\u02B6.\u02BC\u02C0\u02BC\u02B3\u02B4\u02C1\u02B3\u02BE\u02B2\u02C1\u02BE.GHLRhythm <= 1)
				{
					u02C1_u02B2_u02B5_u02BE_u02C0_u02C0_u02C1_u02B2_u02B3_u02BE_u02BA = \u02B7\u02B9\u02BF\u02B4\u02BF\u02BF\u02C1\u02B3\u02B3\u02B8\u02B3.\u02BB\u02B3\u02BC\u02B5\u02B7\u02B9\u02B5\u02C1\u02BA\u02BF\u02BC(noteOnEvent.NoteNumber);
				}
				else
				{
					u02C1_u02B2_u02B5_u02BE_u02C0_u02C0_u02C1_u02B2_u02B3_u02BE_u02BA = \u02B7\u02B9\u02BF\u02B4\u02BF\u02BF\u02C1\u02B3\u02B3\u02B8\u02B3.\u02BD\u02BF\u02B3\u02B5\u02BE\u02B2\u02BA\u02B7\u02BB\u02B4\u02BC(noteOnEvent.NoteNumber);
					if (!flag && u02C1_u02B2_u02B5_u02BE_u02C0_u02C0_u02C1_u02B2_u02B3_u02BE_u02BA == \u02BF\u02BF\u02BB\u02BC\u02B5\u02B9\u02B6\u02C1\u02BB\u02B3\u02BD.\u02C1\u02B2\u02B5\u02BE\u02C0\u02C0\u02C1\u02B2\u02B3\u02BE\u02BA.OPEN)
					{
						u02C1_u02B2_u02B5_u02BE_u02C0_u02C0_u02C1_u02B2_u02B3_u02BE_u02BA = \u02BF\u02BF\u02BB\u02BC\u02B5\u02B9\u02B6\u02C1\u02BB\u02B3\u02BD.\u02C1\u02B2\u02B5\u02BE\u02C0\u02C0\u02C1\u02B2\u02B3\u02BE\u02BA.NONE;
					}
				}
				if (u02C1_u02B2_u02B5_u02BE_u02C0_u02C0_u02C1_u02B2_u02B3_u02BE_u02BA == \u02BF\u02BF\u02BB\u02BC\u02B5\u02B9\u02B6\u02C1\u02BB\u02B3\u02BD.\u02C1\u02B2\u02B5\u02BE\u02C0\u02C0\u02C1\u02B2\u02B3\u02BE\u02BA.NONE)
				{
					continue;
				}
				\u02BF\u02BF\u02BB\u02BC\u02B5\u02B9\u02B6\u02C1\u02BB\u02B3\u02BD.\u02C1\u02B2\u02B5\u02BE\u02C0\u02C0\u02C1\u02B2\u02B3\u02BE\u02BA u02C1_u02B2_u02B5_u02BE_u02C0_u02C0_u02C1_u02B2_u02B3_u02BE_u02BA2 = u02C1_u02B2_u02B5_u02BE_u02C0_u02C0_u02C1_u02B2_u02B3_u02BE_u02BA;
				\u02B4\u02BC\u02BF\u02BC\u02BA\u02B9\u02B8\u02B2\u02BD\u02BE\u02BD.\u02B8\u02C1\u02B8\u02C1\u02C0\u02B8\u02B5\u02B4\u02B6\u02BC\u02B7(\u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF, value).\u02BC\u02BA\u02BE\u02BC\u02C1\u02BC\u02B9\u02C1\u02C1\u02B7\u02BB(new \u02BF\u02BF\u02BB\u02BC\u02B5\u02B9\u02B6\u02C1\u02BB\u02B3\u02BD(num, u02C1_u02B2_u02B5_u02BE_u02C0_u02C0_u02C1_u02B2_u02B3_u02BE_u02BA2, num2, \u02BF\u02BF\u02BB\u02BC\u02B5\u02B9\u02B6\u02C1\u02BB\u02B3\u02BD.\u02B7\u02BB\u02B5\u02BF\u02BA\u02BC\u02B9\u02B5\u02C0\u02B2\u02BC.NONE));
				if (\u02BB\u02C0\u02B5\u02C1\u02BA\u02B7\u02B3\u02C0\u02B7\u02BB\u02B3.\u02B8\u02B3\u02B9\u02BD\u02BC\u02BD\u02B5\u02C0\u02BD\u02BC\u02BA)
				{
					list4.Add((int)value);
					continue;
				}
			}
			if (!\u02BB\u02C0\u02B5\u02C1\u02BA\u02B7\u02B3\u02C0\u02B7\u02BB\u02B3.\u02B8\u02B3\u02B9\u02BD\u02BC\u02BD\u02B5\u02C0\u02BD\u02BC\u02BA)
			{
				TextEvent textEvent = midiEvent as TextEvent;
				if (textEvent != null && (textEvent.Text == "ENHANCED_OPENS" || textEvent.Text == "[ENHANCED_OPENS]"))
				{
					flag = true;
				}
				TextEvent textEvent2 = midiEvent as TextEvent;
				if (textEvent2 != null)
				{
					\u02B4\u02BC\u02BF\u02BC\u02BA\u02B9\u02B8\u02B2\u02BD\u02BE\u02BD.\u02B8\u02C1\u02B8\u02C1\u02C0\u02B8\u02B5\u02B4\u02B6\u02BC\u02B7(\u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF, \u02B7\u02BD\u02BB\u02BB\u02BF\u02B5\u02C0\u02C1\u02BD\u02B3\u02B6.\u02BA\u02BF\u02B9\u02B7\u02B4\u02B7\u02B4\u02BD\u02BF\u02B4\u02B7.Expert).\u02BD\u02B3\u02B3\u02C1\u02B8\u02B9\u02BB\u02BF\u02C1\u02C0\u02B9(textEvent2);
				}
				SysExEvent sysExEvent = midiEvent as SysExEvent;
				if (sysExEvent != null)
				{
					list3.Add(sysExEvent);
				}
			}
		}
		if (!\u02BB\u02C0\u02B5\u02C1\u02BA\u02B7\u02B3\u02C0\u02B7\u02BB\u02B3.\u02B8\u02B3\u02B9\u02BD\u02BC\u02BD\u02B5\u02C0\u02BD\u02BC\u02BA)
		{
			\u02C0\u02BA\u02B7\u02BA\u02B5\u02BE\u02BC\u02BF\u02B9\u02BC\u02B8[] array3 = new \u02C0\u02BA\u02B7\u02BA\u02B5\u02BE\u02BC\u02BF\u02B9\u02BC\u02B8[array.Length];
			int num5 = 0;
			foreach (\u02B7\u02BD\u02BB\u02BB\u02BF\u02B5\u02C0\u02C1\u02BD\u02B3\u02B6.\u02BA\u02BF\u02B9\u02B7\u02B4\u02B7\u02B4\u02BD\u02BF\u02B4\u02B7 u02BA_u02BF_u02B9_u02B7_u02B4_u02B7_u02B4_u02BD_u02BF_u02B4_u02B4 in array)
			{
				array3[num5++] = \u02B4\u02BC\u02BF\u02BC\u02BA\u02B9\u02B8\u02B2\u02BD\u02BE\u02BD.\u02B8\u02C1\u02B8\u02C1\u02C0\u02B8\u02B5\u02B4\u02B6\u02BC\u02B7(\u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF, u02BA_u02BF_u02B9_u02B7_u02B4_u02B7_u02B4_u02BD_u02BF_u02B4_u02B4);
			}
			for (int j = 0; j < list3.Count; j++)
			{
				SysExEvent sysExEvent2 = list3[j];
				\u02B2\u02BB\u02BD\u02C0\u02B7\u02BB\u02B2\u02B4\u02B6\u02B2\u02C1.\u02B3\u02B4\u02BE\u02BF\u02B9\u02BF\u02B4\u02C0\u02BD\u02BA\u02BA u02B3_u02B4_u02BE_u02BF_u02B9_u02BF_u02B4_u02C0_u02BD_u02BA_u02BA = \u02B2\u02BB\u02BD\u02C0\u02B7\u02BB\u02B2\u02B4\u02B6\u02B2\u02C1.\u02B5\u02BC\u02B4\u02B8\u02B6\u02B2\u02BE\u02C0\u02B2\u02BF\u02BC(sysExEvent2.Data);
				if (u02B3_u02B4_u02BE_u02BF_u02B9_u02BF_u02B4_u02C0_u02BD_u02BA_u02BA.\u02C1\u02BA\u02BF\u02BE\u02B6\u02BB\u02BD\u02B6\u02B2\u02B9\u02B7 && u02B3_u02B4_u02BE_u02BF_u02B9_u02BF_u02B4_u02C0_u02BD_u02BA_u02BA.\u02BF\u02B8\u02BD\u02BA\u02BE\u02BD\u02B4\u02BB\u02BC\u02B2\u02BE == 255 && u02B3_u02B4_u02BE_u02BF_u02B9_u02BF_u02B4_u02C0_u02BD_u02BA_u02BA.\u02BF\u02B9\u02B3\u02BC\u02BA\u02B2\u02B4\u02B4\u02BC\u02B3\u02B8 == 4 && u02B3_u02B4_u02BE_u02BF_u02B9_u02BF_u02B4_u02C0_u02BD_u02BA_u02BA.\u02C0\u02BA\u02B8\u02B9\u02B4\u02B8\u02BE\u02BA\u02BE\u02B6\u02B7 == 1)
				{
					uint num6 = (uint)sysExEvent2.AbsoluteTime;
					uint num7 = 0U;
					for (int k = j; k < list3.Count; k++)
					{
						SysExEvent sysExEvent3 = list3[k];
						\u02B2\u02BB\u02BD\u02C0\u02B7\u02BB\u02B2\u02B4\u02B6\u02B2\u02C1.\u02B3\u02B4\u02BE\u02BF\u02B9\u02BF\u02B4\u02C0\u02BD\u02BA\u02BA u02B3_u02B4_u02BE_u02BF_u02B9_u02BF_u02B4_u02C0_u02BD_u02BA_u02BA2 = \u02B2\u02BB\u02BD\u02C0\u02B7\u02BB\u02B2\u02B4\u02B6\u02B2\u02C1.\u02B5\u02BC\u02B4\u02B8\u02B6\u02B2\u02BE\u02C0\u02B2\u02BF\u02BC(sysExEvent3.Data);
						if (u02B3_u02B4_u02BE_u02BF_u02B9_u02BF_u02B4_u02C0_u02BD_u02BA_u02BA2.\u02C1\u02BA\u02BF\u02BE\u02B6\u02BB\u02BD\u02B6\u02B2\u02B9\u02B7 && u02B3_u02B4_u02BE_u02BF_u02B9_u02BF_u02B4_u02C0_u02BD_u02BA_u02BA.\u02BF\u02B8\u02BD\u02BA\u02BE\u02BD\u02B4\u02BB\u02BC\u02B2\u02BE == u02B3_u02B4_u02BE_u02BF_u02B9_u02BF_u02B4_u02C0_u02BD_u02BA_u02BA2.\u02BF\u02B8\u02BD\u02BA\u02BE\u02BD\u02B4\u02BB\u02BC\u02B2\u02BE && u02B3_u02B4_u02BE_u02BF_u02B9_u02BF_u02B4_u02C0_u02BD_u02BA_u02BA.\u02BF\u02B9\u02B3\u02BC\u02BA\u02B2\u02B4\u02B4\u02BC\u02B3\u02B8 == u02B3_u02B4_u02BE_u02BF_u02B9_u02BF_u02B4_u02C0_u02BD_u02BA_u02BA2.\u02BF\u02B9\u02B3\u02BC\u02BA\u02B2\u02B4\u02B4\u02BC\u02B3\u02B8 && u02B3_u02B4_u02BE_u02BF_u02B9_u02BF_u02B4_u02C0_u02BD_u02BA_u02BA2.\u02C0\u02BA\u02B8\u02B9\u02B4\u02B8\u02BE\u02BA\u02BE\u02B6\u02B7 == 0)
						{
							num7 = (uint)(sysExEvent3.AbsoluteTime - (long)((ulong)num6));
							break;
						}
					}
					foreach (\u02C0\u02BA\u02B7\u02BA\u02B5\u02BE\u02BC\u02BF\u02B9\u02BC\u02B8 u02C0_u02BA_u02B7_u02BA_u02B5_u02BE_u02BC_u02BF_u02B9_u02BC_u02B in array3)
					{
						ValueTuple<int, int> valueTuple = \u02BC\u02BA\u02C0\u02B2\u02BA\u02C0\u02BC\u02C1\u02BD\u02B8\u02B8.\u02BE\u02C1\u02B2\u02BB\u02B9\u02BD\u02B6\u02B9\u02B6\u02B2\u02B9<\u02BF\u02BF\u02BB\u02BC\u02B5\u02B9\u02B6\u02C1\u02BB\u02B3\u02BD>(u02C0_u02BA_u02B7_u02BA_u02B5_u02BE_u02BC_u02BF_u02B9_u02BC_u02B.\u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8, num6, num6 + num7);
						for (int l = valueTuple.Item1; l < valueTuple.Item2; l++)
						{
							u02C0_u02BA_u02B7_u02BA_u02B5_u02BE_u02BC_u02BF_u02B9_u02BC_u02B.\u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8[l].\u02B7\u02B2\u02B5\u02BB\u02B9\u02C1\u02BA\u02B4\u02B3\u02C0\u02C0(\u02BF\u02BF\u02BB\u02BC\u02B5\u02B9\u02B6\u02C1\u02BB\u02B3\u02BD.\u02B8\u02C1\u02B3\u02B7\u02BC\u02BF\u02BC\u02BC\u02BF\u02C1\u02BA.Tap);
						}
					}
				}
				else if (u02B3_u02B4_u02BE_u02BF_u02B9_u02BF_u02B4_u02C0_u02BD_u02BA_u02BA.\u02C1\u02BA\u02BF\u02BE\u02B6\u02BB\u02BD\u02B6\u02B2\u02B9\u02B7 && u02B3_u02B4_u02BE_u02BF_u02B9_u02BF_u02B4_u02C0_u02BD_u02BA_u02BA.\u02BF\u02B8\u02BD\u02BA\u02BE\u02BD\u02B4\u02BB\u02BC\u02B2\u02BE != 255 && u02B3_u02B4_u02BE_u02BF_u02B9_u02BF_u02B4_u02C0_u02BD_u02BA_u02BA.\u02BF\u02B9\u02B3\u02BC\u02BA\u02B2\u02B4\u02B4\u02BC\u02B3\u02B8 == 1 && u02B3_u02B4_u02BE_u02BF_u02B9_u02BF_u02B4_u02C0_u02BD_u02BA_u02BA.\u02C0\u02BA\u02B8\u02B9\u02B4\u02B8\u02BE\u02BA\u02BE\u02B6\u02B7 == 1)
				{
					uint num8 = (uint)sysExEvent2.AbsoluteTime;
					\u02B7\u02BD\u02BB\u02BB\u02BF\u02B5\u02C0\u02C1\u02BD\u02B3\u02B6.\u02BA\u02BF\u02B9\u02B7\u02B4\u02B7\u02B4\u02BD\u02BF\u02B4\u02B7 u02BA_u02BF_u02B9_u02B7_u02B4_u02B7_u02B4_u02BD_u02BF_u02B4_u02B5;
					switch (u02B3_u02B4_u02BE_u02BF_u02B9_u02BF_u02B4_u02C0_u02BD_u02BA_u02BA.\u02BF\u02B8\u02BD\u02BA\u02BE\u02BD\u02B4\u02BB\u02BC\u02B2\u02BE)
					{
					case 0:
						u02BA_u02BF_u02B9_u02B7_u02B4_u02B7_u02B4_u02BD_u02BF_u02B4_u02B5 = \u02B7\u02BD\u02BB\u02BB\u02BF\u02B5\u02C0\u02C1\u02BD\u02B3\u02B6.\u02BA\u02BF\u02B9\u02B7\u02B4\u02B7\u02B4\u02BD\u02BF\u02B4\u02B7.Easy;
						break;
					case 1:
						u02BA_u02BF_u02B9_u02B7_u02B4_u02B7_u02B4_u02BD_u02BF_u02B4_u02B5 = \u02B7\u02BD\u02BB\u02BB\u02BF\u02B5\u02C0\u02C1\u02BD\u02B3\u02B6.\u02BA\u02BF\u02B9\u02B7\u02B4\u02B7\u02B4\u02BD\u02BF\u02B4\u02B7.Medium;
						break;
					case 2:
						u02BA_u02BF_u02B9_u02B7_u02B4_u02B7_u02B4_u02BD_u02BF_u02B4_u02B5 = \u02B7\u02BD\u02BB\u02BB\u02BF\u02B5\u02C0\u02C1\u02BD\u02B3\u02B6.\u02BA\u02BF\u02B9\u02B7\u02B4\u02B7\u02B4\u02BD\u02BF\u02B4\u02B7.Hard;
						break;
					case 3:
						u02BA_u02BF_u02B9_u02B7_u02B4_u02B7_u02B4_u02BD_u02BF_u02B4_u02B5 = \u02B7\u02BD\u02BB\u02BB\u02BF\u02B5\u02C0\u02C1\u02BD\u02B3\u02B6.\u02BA\u02BF\u02B9\u02B7\u02B4\u02B7\u02B4\u02BD\u02BF\u02B4\u02B7.Expert;
						break;
					default:
						goto IL_0627;
					}
					uint num9 = 0U;
					for (int m = j; m < list3.Count; m++)
					{
						SysExEvent sysExEvent4 = list3[m];
						if (sysExEvent4 != null)
						{
							\u02B2\u02BB\u02BD\u02C0\u02B7\u02BB\u02B2\u02B4\u02B6\u02B2\u02C1.\u02B3\u02B4\u02BE\u02BF\u02B9\u02BF\u02B4\u02C0\u02BD\u02BA\u02BA u02B3_u02B4_u02BE_u02BF_u02B9_u02BF_u02B4_u02C0_u02BD_u02BA_u02BA3 = \u02B2\u02BB\u02BD\u02C0\u02B7\u02BB\u02B2\u02B4\u02B6\u02B2\u02C1.\u02B5\u02BC\u02B4\u02B8\u02B6\u02B2\u02BE\u02C0\u02B2\u02BF\u02BC(sysExEvent4.Data);
							if (u02B3_u02B4_u02BE_u02BF_u02B9_u02BF_u02B4_u02C0_u02BD_u02BA_u02BA3.\u02C1\u02BA\u02BF\u02BE\u02B6\u02BB\u02BD\u02B6\u02B2\u02B9\u02B7 && u02B3_u02B4_u02BE_u02BF_u02B9_u02BF_u02B4_u02C0_u02BD_u02BA_u02BA.\u02BF\u02B8\u02BD\u02BA\u02BE\u02BD\u02B4\u02BB\u02BC\u02B2\u02BE == u02B3_u02B4_u02BE_u02BF_u02B9_u02BF_u02B4_u02C0_u02BD_u02BA_u02BA3.\u02BF\u02B8\u02BD\u02BA\u02BE\u02BD\u02B4\u02BB\u02BC\u02B2\u02BE && u02B3_u02B4_u02BE_u02BF_u02B9_u02BF_u02B4_u02C0_u02BD_u02BA_u02BA.\u02BF\u02B9\u02B3\u02BC\u02BA\u02B2\u02B4\u02B4\u02BC\u02B3\u02B8 == u02B3_u02B4_u02BE_u02BF_u02B9_u02BF_u02B4_u02C0_u02BD_u02BA_u02BA3.\u02BF\u02B9\u02B3\u02BC\u02BA\u02B2\u02B4\u02B4\u02BC\u02B3\u02B8 && u02B3_u02B4_u02BE_u02BF_u02B9_u02BF_u02B4_u02C0_u02BD_u02BA_u02BA3.\u02C0\u02BA\u02B8\u02B9\u02B4\u02B8\u02BE\u02BA\u02BE\u02B6\u02B7 == 0)
							{
								num9 = (uint)(sysExEvent4.AbsoluteTime - (long)((ulong)num8));
								if (num9 > 0U)
								{
									num9 -= 1U;
									break;
								}
								break;
							}
						}
					}
					List<\u02BF\u02BF\u02BB\u02BC\u02B5\u02B9\u02B6\u02C1\u02BB\u02B3\u02BD> list5 = \u02B4\u02BC\u02BF\u02BC\u02BA\u02B9\u02B8\u02B2\u02BD\u02BE\u02BD.\u02B8\u02C1\u02B8\u02C1\u02C0\u02B8\u02B5\u02B4\u02B6\u02BC\u02B7(\u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF, u02BA_u02BF_u02B9_u02B7_u02B4_u02B7_u02B4_u02BD_u02BF_u02B4_u02B5).\u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8;
					ValueTuple<int, int> valueTuple2 = \u02BC\u02BA\u02C0\u02B2\u02BA\u02C0\u02BC\u02C1\u02BD\u02B8\u02B8.\u02BE\u02C1\u02B2\u02BB\u02B9\u02BD\u02B6\u02B9\u02B6\u02B2\u02B9<\u02BF\u02BF\u02BB\u02BC\u02B5\u02B9\u02B6\u02C1\u02BB\u02B3\u02BD>(list5, num8, num8 + num9);
					for (int n = valueTuple2.Item1; n < valueTuple2.Item2; n++)
					{
						list5[n].\u02BD\u02BA\u02BC\u02B8\u02B2\u02B7\u02B8\u02B8\u02BA\u02BA\u02BF = \u02BF\u02BF\u02BB\u02BC\u02B5\u02B9\u02B6\u02C1\u02BB\u02B3\u02BD.\u02C1\u02B2\u02B5\u02BE\u02C0\u02C0\u02C1\u02B2\u02B3\u02BE\u02BA.OPEN;
					}
				}
				IL_0627:;
			}
			for (int num10 = 0; num10 < list2.Count; num10++)
			{
				uint num11 = (uint)list2[num10].AbsoluteTime;
				uint num12 = (uint)list2[num10].OffEvent.AbsoluteTime;
				if (num12 - num11 != 0U)
				{
					num12 -= 1U;
				}
				foreach (\u02C0\u02BA\u02B7\u02BA\u02B5\u02BE\u02BC\u02BF\u02B9\u02BC\u02B8 u02C0_u02BA_u02B7_u02BA_u02B5_u02BE_u02BC_u02BF_u02B9_u02BC_u02B2 in array3)
				{
					ValueTuple<int, int> valueTuple3 = \u02BC\u02BA\u02C0\u02B2\u02BA\u02C0\u02BC\u02C1\u02BD\u02B8\u02B8.\u02BE\u02C1\u02B2\u02BB\u02B9\u02BD\u02B6\u02B9\u02B6\u02B2\u02B9<\u02BF\u02BF\u02BB\u02BC\u02B5\u02B9\u02B6\u02C1\u02BB\u02B3\u02BD>(u02C0_u02BA_u02B7_u02BA_u02B5_u02BE_u02BC_u02BF_u02B9_u02BC_u02B2.\u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8, num11, num12);
					for (int num13 = valueTuple3.Item1; num13 < valueTuple3.Item2; num13++)
					{
						u02C0_u02BA_u02B7_u02BA_u02B5_u02BE_u02BC_u02BF_u02B9_u02BC_u02B2.\u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8[num13].\u02B7\u02B2\u02B5\u02BB\u02B9\u02C1\u02BA\u02B4\u02B3\u02C0\u02C0(\u02BF\u02BF\u02BB\u02BC\u02B5\u02B9\u02B6\u02C1\u02BB\u02B3\u02BD.\u02B8\u02C1\u02B3\u02B7\u02BC\u02BF\u02BC\u02BC\u02BF\u02C1\u02BA.Tap);
					}
				}
			}
			for (int num14 = 0; num14 < list.Count; num14++)
			{
				uint num15 = (uint)list[num14].AbsoluteTime;
				uint num16 = (uint)list[num14].OffEvent.AbsoluteTime;
				if (num16 - num15 != 0U)
				{
					num16 -= 1U;
				}
				\u02B7\u02BD\u02BB\u02BB\u02BF\u02B5\u02C0\u02C1\u02BD\u02B3\u02B6.\u02BA\u02BF\u02B9\u02B7\u02B4\u02B7\u02B4\u02BD\u02BF\u02B4\u02B7? u02BA_u02BF_u02B9_u02B7_u02B4_u02B7_u02B4_u02BD_u02BF_u02B4_u02B6 = \u02B7\u02B9\u02BF\u02B4\u02BF\u02BF\u02C1\u02B3\u02B3\u02B8\u02B3.\u02BC\u02B4\u02B7\u02BD\u02C0\u02BA\u02BB\u02B9\u02BF\u02BA\u02B2((int)list[num14].NoteNumber);
				if (u02BA_u02BF_u02B9_u02B7_u02B4_u02B7_u02B4_u02BD_u02BF_u02B4_u02B6 != null)
				{
					\u02C0\u02BA\u02B7\u02BA\u02B5\u02BE\u02BC\u02BF\u02B9\u02BC\u02B8 u02C0_u02BA_u02B7_u02BA_u02B5_u02BE_u02BC_u02BF_u02B9_u02BC_u02B3 = \u02B4\u02BC\u02BF\u02BC\u02BA\u02B9\u02B8\u02B2\u02BD\u02BE\u02BD.\u02B8\u02C1\u02B8\u02C1\u02C0\u02B8\u02B5\u02B4\u02B6\u02BC\u02B7(\u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF, u02BA_u02BF_u02B9_u02B7_u02B4_u02B7_u02B4_u02BD_u02BF_u02B4_u02B6.Value);
					ValueTuple<int, int> valueTuple4 = \u02BC\u02BA\u02C0\u02B2\u02BA\u02C0\u02BC\u02C1\u02BD\u02B8\u02B8.\u02BE\u02C1\u02B2\u02BB\u02B9\u02BD\u02B6\u02B9\u02B6\u02B2\u02B9<\u02BF\u02BF\u02BB\u02BC\u02B5\u02B9\u02B6\u02C1\u02BB\u02B3\u02BD>(u02C0_u02BA_u02B7_u02BA_u02B5_u02BE_u02BC_u02BF_u02B9_u02BC_u02B3.\u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8, num15, num16);
					for (int num17 = valueTuple4.Item1; num17 < valueTuple4.Item2; num17++)
					{
						if ((u02C0_u02BA_u02B7_u02BA_u02B5_u02BE_u02BC_u02BF_u02B9_u02BC_u02B3.\u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8[num17].\u02C0\u02B7\u02C1\u02B5\u02B9\u02B3\u02BF\u02B5\u02BC\u02B9\u02C0 & \u02BF\u02BF\u02BB\u02BC\u02B5\u02B9\u02B6\u02C1\u02BB\u02B3\u02BD.\u02B7\u02BB\u02B5\u02BF\u02BA\u02BC\u02B9\u02B5\u02C0\u02B2\u02BC.TAP) == \u02BF\u02BF\u02BB\u02BC\u02B5\u02B9\u02B6\u02C1\u02BB\u02B3\u02BD.\u02B7\u02BB\u02B5\u02BF\u02BA\u02BC\u02B9\u02B5\u02C0\u02B2\u02BC.NONE)
						{
							if (list[num14].NoteNumber % 2 != 0)
							{
								u02C0_u02BA_u02B7_u02BA_u02B5_u02BE_u02BC_u02BF_u02B9_u02BC_u02B3.\u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8[num17].\u02B7\u02B2\u02B5\u02BB\u02B9\u02C1\u02BA\u02B4\u02B3\u02C0\u02C0(\u02BF\u02BF\u02BB\u02BC\u02B5\u02B9\u02B6\u02C1\u02BB\u02B3\u02BD.\u02B8\u02C1\u02B3\u02B7\u02BC\u02BF\u02BC\u02BC\u02BF\u02C1\u02BA.Hopo);
							}
							else
							{
								u02C0_u02BA_u02B7_u02BA_u02B5_u02BE_u02BC_u02BF_u02B9_u02BC_u02B3.\u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8[num17].\u02B7\u02B2\u02B5\u02BB\u02B9\u02C1\u02BA\u02B4\u02B3\u02C0\u02C0(\u02BF\u02BF\u02BB\u02BC\u02B5\u02B9\u02B6\u02C1\u02BB\u02B3\u02BD.\u02B8\u02C1\u02B3\u02B7\u02BC\u02BF\u02BC\u02BC\u02BF\u02C1\u02BA.Strum);
							}
						}
					}
				}
			}
		}
	}

	private static bool \u02BC\u02BD\u02BD\u02BF\u02B5\u02BB\u02B6\u02BB\u02BA\u02B4\u02BB(EventsCollection \u02BB\u02BF\u02BF\u02B4\u02B3\u02BE\u02C0\u02BB\u02C0\u02BA\u02B2)
	{
		int num = 0;
		foreach (MidiEvent midiEvent in \u02BB\u02BF\u02BF\u02B4\u02B3\u02BE\u02C0\u02BB\u02C0\u02BA\u02B2)
		{
			NoteOnEvent noteOnEvent = midiEvent as NoteOnEvent;
			if (noteOnEvent != null && noteOnEvent.OffEvent != null)
			{
				if (noteOnEvent.NoteNumber == 103)
				{
					num++;
				}
				else if (noteOnEvent.NoteNumber == 116)
				{
					num = 0;
					break;
				}
			}
		}
		return num >= 2;
	}

	private static void \u02BD\u02B3\u02B3\u02C1\u02B8\u02B9\u02BB\u02BF\u02C1\u02C0\u02B9(this \u02C0\u02BA\u02B7\u02BA\u02B5\u02BE\u02BC\u02BF\u02B9\u02BC\u02B8 \u02B4\u02C1\u02B6\u02B3\u02B3\u02B9\u02BD\u02B4\u02B3\u02BD\u02B5, TextEvent \u02BB\u02B2\u02BD\u02B9\u02B9\u02B6\u02C0\u02B5\u02B8\u02BA\u02BF)
	{
		if (!string.IsNullOrEmpty(\u02BB\u02B2\u02BD\u02B9\u02B9\u02B6\u02C0\u02B5\u02B8\u02BA\u02BF.Text))
		{
			uint num = (uint)\u02BB\u02B2\u02BD\u02B9\u02B9\u02B6\u02C0\u02B5\u02B8\u02BA\u02BF.AbsoluteTime;
			string text = \u02BB\u02B2\u02BD\u02B9\u02B9\u02B6\u02C0\u02B5\u02B8\u02BA\u02BF.Text.Trim(\u02BB\u02C0\u02B5\u02C1\u02BA\u02B7\u02B3\u02C0\u02B7\u02BB\u02B3.\u02BE\u02B4\u02B2\u02B7\u02B8\u02B3\u02B7\u02BC\u02BD\u02C1\u02B6);
			\u02B4\u02C1\u02B6\u02B3\u02B3\u02B9\u02BD\u02B4\u02B3\u02BD\u02B5.\u02BC\u02BA\u02BE\u02BC\u02C1\u02BC\u02B9\u02C1\u02C1\u02B7\u02BB(new \u02BB\u02C0\u02C1\u02B8\u02BE\u02B2\u02B9\u02B2\u02B6\u02B8\u02B4(num, text));
		}
	}

	private static byte \u02B4\u02B4\u02BE\u02B7\u02B6\u02B6\u02B8\u02B2\u02C0\u02B6\u02C1(EventsCollection \u02BB\u02BF\u02BF\u02B4\u02B3\u02BE\u02C0\u02BB\u02C0\u02BA\u02B2)
	{
		int u02B7_u02BE_u02C0_u02BA_u02C0_u02B8_u02BC_u02BF_u02BF_u02B3_u02BF = GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B8\u02B2\u02B9\u02B4\u02B2\u02B7\u02B4\u02B3\u02B9\u02B6\u02BF.\u02B7\u02BE\u02C0\u02BA\u02C0\u02B8\u02BC\u02BF\u02BF\u02B3\u02BF;
		if (u02B7_u02BE_u02C0_u02BA_u02C0_u02B8_u02BC_u02BF_u02BF_u02B3_u02BF == 103 || u02B7_u02BE_u02C0_u02BA_u02C0_u02B8_u02BC_u02BF_u02BF_u02B3_u02BF == 116)
		{
			return (byte)GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02B8\u02B2\u02B9\u02B4\u02B2\u02B7\u02B4\u02B3\u02B9\u02B6\u02BF.\u02B7\u02BE\u02C0\u02BA\u02C0\u02B8\u02BC\u02BF\u02BF\u02B3\u02BF;
		}
		if (!\u02BB\u02C0\u02B5\u02C1\u02BA\u02B7\u02B3\u02C0\u02B7\u02BB\u02B3.\u02BC\u02BD\u02BD\u02BF\u02B5\u02BB\u02B6\u02BB\u02BA\u02B4\u02BB(\u02BB\u02BF\u02BF\u02B4\u02B3\u02BE\u02C0\u02BB\u02C0\u02BA\u02B2))
		{
			return 116;
		}
		return 103;
	}

	private static void \u02B5\u02BD\u02B3\u02B7\u02BF\u02BE\u02B4\u02BB\u02B8\u02BF\u02BE(EventsCollection \u02BB\u02BF\u02BF\u02B4\u02B3\u02BE\u02C0\u02BB\u02C0\u02BA\u02B2, \u02B7\u02BD\u02BB\u02BB\u02BF\u02B5\u02C0\u02C1\u02BD\u02B3\u02B6 \u02B4\u02BC\u02BF\u02BC\u02BA\u02B9\u02B8\u02B2\u02BD\u02BE\u02BD, \u02B7\u02BD\u02BB\u02BB\u02BF\u02B5\u02C0\u02C1\u02BD\u02B3\u02B6.\u02BC\u02C0\u02BC\u02B3\u02B4\u02C1\u02B3\u02BE\u02B2\u02C1\u02BE \u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF)
	{
		List<int> list = null;
		List<TextEvent> list2 = null;
		bool flag = false;
		bool flag2 = false;
		bool flag3 = false;
		int num = 0;
		if (\u02BB\u02C0\u02B5\u02C1\u02BA\u02B7\u02B3\u02C0\u02B7\u02BB\u02B3.\u02B8\u02B3\u02B9\u02BD\u02BC\u02BD\u02B5\u02C0\u02BD\u02BC\u02BA)
		{
			num = Enum.GetValues(typeof(\u02B7\u02BD\u02BB\u02BB\u02BF\u02B5\u02C0\u02C1\u02BD\u02B3\u02B6.\u02BA\u02BF\u02B9\u02B7\u02B4\u02B7\u02B4\u02BD\u02BF\u02B4\u02B7)).Length;
			list = new List<int>(10);
		}
		\u02B7\u02BD\u02BB\u02BB\u02BF\u02B5\u02C0\u02C1\u02BD\u02B3\u02B6.\u02BA\u02BF\u02B9\u02B7\u02B4\u02B7\u02B4\u02BD\u02BF\u02B4\u02B7[] array = Enum.GetValues(typeof(\u02B7\u02BD\u02BB\u02BB\u02BF\u02B5\u02C0\u02C1\u02BD\u02B3\u02B6.\u02BA\u02BF\u02B9\u02B7\u02B4\u02B7\u02B4\u02BD\u02BF\u02B4\u02B7)) as \u02B7\u02BD\u02BB\u02BB\u02BF\u02B5\u02C0\u02C1\u02BD\u02B3\u02B6.\u02BA\u02BF\u02B9\u02B7\u02B4\u02B7\u02B4\u02BD\u02BF\u02B4\u02B7[];
		List<NoteOnEvent> list3 = null;
		List<NoteOnEvent> list4 = null;
		List<Tuple<NoteOnEvent, bool>> list5 = null;
		if (!\u02BB\u02C0\u02B5\u02C1\u02BA\u02B7\u02B3\u02C0\u02B7\u02BB\u02B3.\u02B8\u02B3\u02B9\u02BD\u02BC\u02BD\u02B5\u02C0\u02BD\u02BC\u02BA)
		{
			list3 = new List<NoteOnEvent>(500);
			list2 = new List<TextEvent>(500);
			list4 = new List<NoteOnEvent>(500);
			list5 = new List<Tuple<NoteOnEvent, bool>>(500);
		}
		foreach (MidiEvent midiEvent in \u02BB\u02BF\u02BF\u02B4\u02B3\u02BE\u02C0\u02BB\u02C0\u02BA\u02B2)
		{
			NoteOnEvent noteOnEvent = midiEvent as NoteOnEvent;
			if (noteOnEvent != null && noteOnEvent.OffEvent != null)
			{
				uint num2 = (uint)noteOnEvent.AbsoluteTime;
				uint num3 = (uint)(noteOnEvent.OffEvent.AbsoluteTime - (long)((ulong)num2));
				if (!\u02BB\u02C0\u02B5\u02C1\u02BA\u02B7\u02B3\u02C0\u02B7\u02BB\u02B3.\u02B8\u02B3\u02B9\u02BD\u02BC\u02BD\u02B5\u02C0\u02BD\u02BC\u02BA)
				{
					if (noteOnEvent.NoteNumber == 116)
					{
						foreach (\u02B7\u02BD\u02BB\u02BB\u02BF\u02B5\u02C0\u02C1\u02BD\u02B3\u02B6.\u02BA\u02BF\u02B9\u02B7\u02B4\u02B7\u02B4\u02BD\u02BF\u02B4\u02B7 u02BA_u02BF_u02B9_u02B7_u02B4_u02B7_u02B4_u02BD_u02BF_u02B4_u02B in array)
						{
							\u02B4\u02BC\u02BF\u02BC\u02BA\u02B9\u02B8\u02B2\u02BD\u02BE\u02BD.\u02B8\u02C1\u02B8\u02C1\u02C0\u02B8\u02B5\u02B4\u02B6\u02BC\u02B7(\u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF, u02BA_u02BF_u02B9_u02B7_u02B4_u02B7_u02B4_u02BD_u02BF_u02B4_u02B).\u02BC\u02BA\u02BE\u02BC\u02C1\u02BC\u02B9\u02C1\u02C1\u02B7\u02BB(new \u02BC\u02BD\u02B3\u02B5\u02B4\u02B7\u02BE\u02BC\u02BD\u02C1\u02B7(num2, num3));
						}
						continue;
					}
					if (noteOnEvent.NoteNumber == 120)
					{
						foreach (\u02B7\u02BD\u02BB\u02BB\u02BF\u02B5\u02C0\u02C1\u02BD\u02B3\u02B6.\u02BA\u02BF\u02B9\u02B7\u02B4\u02B7\u02B4\u02BD\u02BF\u02B4\u02B7 u02BA_u02BF_u02B9_u02B7_u02B4_u02B7_u02B4_u02BD_u02BF_u02B4_u02B2 in array)
						{
							\u02B4\u02BC\u02BF\u02BC\u02BA\u02B9\u02B8\u02B2\u02BD\u02BE\u02BD.\u02B8\u02C1\u02B8\u02C1\u02C0\u02B8\u02B5\u02B4\u02B6\u02BC\u02B7(\u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF, u02BA_u02BF_u02B9_u02B7_u02B4_u02B7_u02B4_u02BD_u02BF_u02B4_u02B2).\u02BC\u02BA\u02BE\u02BC\u02C1\u02BC\u02B9\u02C1\u02C1\u02B7\u02BB(new \u02B3\u02B9\u02BA\u02C1\u02B2\u02B5\u02B3\u02C0\u02B8\u02BF\u02B6(num2, num3));
						}
					}
					if (noteOnEvent.NoteNumber == 109)
					{
						list4.Add(midiEvent as NoteOnEvent);
					}
					if (noteOnEvent.NoteNumber >= 110 && noteOnEvent.NoteNumber <= 112)
					{
						list3.Add(midiEvent as NoteOnEvent);
					}
					if (noteOnEvent.NoteNumber == 126)
					{
						list5.Add(new Tuple<NoteOnEvent, bool>(midiEvent as NoteOnEvent, false));
					}
					if (noteOnEvent.NoteNumber == 127)
					{
						list5.Add(new Tuple<NoteOnEvent, bool>(midiEvent as NoteOnEvent, true));
					}
					if (noteOnEvent.NoteNumber == 103)
					{
						foreach (\u02B7\u02BD\u02BB\u02BB\u02BF\u02B5\u02C0\u02C1\u02BD\u02B3\u02B6.\u02BA\u02BF\u02B9\u02B7\u02B4\u02B7\u02B4\u02BD\u02BF\u02B4\u02B7 u02BA_u02BF_u02B9_u02B7_u02B4_u02B7_u02B4_u02BD_u02BF_u02B4_u02B3 in array)
						{
							float num4 = \u02B4\u02BC\u02BF\u02BC\u02BA\u02B9\u02B8\u02B2\u02BD\u02BE\u02BD.\u02B9\u02B4\u02B6\u02B8\u02BE\u02B2\u02B6\u02C0\u02BC\u02BA\u02B7((uint)noteOnEvent.AbsoluteTime);
							float num5 = \u02B4\u02BC\u02BF\u02BC\u02BA\u02B9\u02B8\u02B2\u02BD\u02BE\u02BD.\u02B8\u02B3\u02BE\u02B8\u02BC\u02B9\u02BD\u02BE\u02BF\u02B8\u02B5((uint)noteOnEvent.AbsoluteTime, (uint)noteOnEvent.OffEvent.AbsoluteTime);
							\u02B2\u02BF\u02C1\u02B4\u02B3\u02BD\u02B7\u02BF\u02B3\u02BF\u02C0 u02B2_u02BF_u02C1_u02B4_u02B3_u02BD_u02B7_u02BF_u02B3_u02BF_u02C = new \u02B2\u02BF\u02C1\u02B4\u02B3\u02BD\u02B7\u02BF\u02B3\u02BF\u02C0
							{
								\u02B2\u02B8\u02BA\u02BA\u02BC\u02B7\u02B5\u02B5\u02B6\u02B5\u02C1 = num4,
								\u02BB\u02BE\u02BA\u02B8\u02BE\u02B9\u02BF\u02B3\u02B4\u02B8\u02BD = num5,
								\u02B5\u02BF\u02B5\u02B2\u02BD\u02BD\u02BD\u02B5\u02B8\u02C0\u02BE = (uint)noteOnEvent.AbsoluteTime,
								\u02B7\u02B3\u02BD\u02B5\u02B3\u02B4\u02BC\u02B2\u02B4\u02C1\u02B2 = (int)(noteOnEvent.OffEvent.AbsoluteTime - noteOnEvent.AbsoluteTime),
								\u02BB\u02BB\u02B7\u02C0\u02B7\u02BA\u02B8\u02B4\u02B5\u02B8\u02B5 = (uint)noteOnEvent.OffEvent.AbsoluteTime
							};
							\u02B4\u02BC\u02BF\u02BC\u02BA\u02B9\u02B8\u02B2\u02BD\u02BE\u02BD.\u02B8\u02C1\u02B8\u02C1\u02C0\u02B8\u02B5\u02B4\u02B6\u02BC\u02B7(\u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF, u02BA_u02BF_u02B9_u02B7_u02B4_u02B7_u02B4_u02BD_u02BF_u02B4_u02B3).\u02B3\u02B3\u02B4\u02BA\u02B9\u02B7\u02BA\u02B6\u02B4\u02C0\u02BD.Add(u02B2_u02BF_u02C1_u02B4_u02B3_u02BD_u02B7_u02BF_u02B3_u02BF_u02C);
						}
						continue;
					}
				}
				else
				{
					if (!flag && noteOnEvent.NoteNumber >= 110 && noteOnEvent.NoteNumber <= 112)
					{
						flag = true;
						foreach (\u02B7\u02BD\u02BB\u02BB\u02BF\u02B5\u02C0\u02C1\u02BD\u02B3\u02B6.\u02BA\u02BF\u02B9\u02B7\u02B4\u02B7\u02B4\u02BD\u02BF\u02B4\u02B7 u02BA_u02BF_u02B9_u02B7_u02B4_u02B7_u02B4_u02BD_u02BF_u02B4_u02B4 in array)
						{
							\u02B4\u02BC\u02BF\u02BC\u02BA\u02B9\u02B8\u02B2\u02BD\u02BE\u02BD.\u02B8\u02C1\u02B8\u02C1\u02C0\u02B8\u02B5\u02B4\u02B6\u02BC\u02B7(\u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF, u02BA_u02BF_u02B9_u02B7_u02B4_u02B7_u02B4_u02BD_u02BF_u02B4_u02B4).\u02BC\u02C1\u02B6\u02BB\u02B8\u02B5\u02BC\u02B9\u02B8\u02BF\u02BA = true;
						}
					}
					if (!flag2 && noteOnEvent.NoteNumber == 101)
					{
						flag2 = true;
						foreach (\u02B7\u02BD\u02BB\u02BB\u02BF\u02B5\u02C0\u02C1\u02BD\u02B3\u02B6.\u02BA\u02BF\u02B9\u02B7\u02B4\u02B7\u02B4\u02BD\u02BF\u02B4\u02B7 u02BA_u02BF_u02B9_u02B7_u02B4_u02B7_u02B4_u02BD_u02BF_u02B4_u02B5 in array)
						{
							\u02B4\u02BC\u02BF\u02BC\u02BA\u02B9\u02B8\u02B2\u02BD\u02BE\u02BD.\u02B8\u02C1\u02B8\u02C1\u02C0\u02B8\u02B5\u02B4\u02B6\u02BC\u02B7(\u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF, u02BA_u02BF_u02B9_u02B7_u02B4_u02B7_u02B4_u02BD_u02BF_u02B4_u02B5).\u02BD\u02BB\u02C0\u02B8\u02BF\u02B6\u02B2\u02B7\u02BE\u02C0\u02B4 = true;
						}
					}
				}
				\u02B7\u02BD\u02BB\u02BB\u02BF\u02B5\u02C0\u02C1\u02BD\u02B3\u02B6.\u02BA\u02BF\u02B9\u02B7\u02B4\u02B7\u02B4\u02BD\u02BF\u02B4\u02B7? u02BA_u02BF_u02B9_u02B7_u02B4_u02B7_u02B4_u02BD_u02BF_u02B4_u02B6 = \u02B7\u02B9\u02BF\u02B4\u02BF\u02BF\u02C1\u02B3\u02B3\u02B8\u02B3.\u02BC\u02B4\u02B7\u02BD\u02C0\u02BA\u02BB\u02B9\u02BF\u02BA\u02B2((int)noteOnEvent.NoteNumber);
				if (u02BA_u02BF_u02B9_u02B7_u02B4_u02B7_u02B4_u02BD_u02BF_u02B4_u02B6 == null)
				{
					continue;
				}
				\u02B7\u02BD\u02BB\u02BB\u02BF\u02B5\u02C0\u02C1\u02BD\u02B3\u02B6.\u02BA\u02BF\u02B9\u02B7\u02B4\u02B7\u02B4\u02BD\u02BF\u02B4\u02B7 value = u02BA_u02BF_u02B9_u02B7_u02B4_u02B7_u02B4_u02BD_u02BF_u02B4_u02B6.Value;
				if (\u02BB\u02C0\u02B5\u02C1\u02BA\u02B7\u02B3\u02C0\u02B7\u02BB\u02B3.\u02B8\u02B3\u02B9\u02BD\u02BC\u02BD\u02B5\u02C0\u02BD\u02BC\u02BA && list.Contains((int)value))
				{
					if (list.Count == num && flag)
					{
						break;
					}
					continue;
				}
				else
				{
					\u02BF\u02BF\u02BB\u02BC\u02B5\u02B9\u02B6\u02C1\u02BB\u02B3\u02BD.\u02C1\u02B2\u02B5\u02BE\u02C0\u02C0\u02C1\u02B2\u02B3\u02BE\u02BA u02C1_u02B2_u02B5_u02BE_u02C0_u02C0_u02C1_u02B2_u02B3_u02BE_u02BA = \u02B7\u02B9\u02BF\u02B4\u02BF\u02BF\u02C1\u02B3\u02B3\u02B8\u02B3.\u02B8\u02B4\u02B6\u02B3\u02BB\u02C1\u02B6\u02C0\u02BB\u02B8\u02C0(noteOnEvent.NoteNumber);
					if (u02C1_u02B2_u02B5_u02BE_u02C0_u02C0_u02C1_u02B2_u02B3_u02BE_u02BA == \u02BF\u02BF\u02BB\u02BC\u02B5\u02B9\u02B6\u02C1\u02BB\u02B3\u02BD.\u02C1\u02B2\u02B5\u02BE\u02C0\u02C0\u02C1\u02B2\u02B3\u02BE\u02BA.NONE)
					{
						continue;
					}
					\u02BF\u02BF\u02BB\u02BC\u02B5\u02B9\u02B6\u02C1\u02BB\u02B3\u02BD.\u02B7\u02BB\u02B5\u02BF\u02BA\u02BC\u02B9\u02B5\u02C0\u02B2\u02BC u02B7_u02BB_u02B5_u02BF_u02BA_u02BC_u02B9_u02B5_u02C0_u02B2_u02BC = \u02BF\u02BF\u02BB\u02BC\u02B5\u02B9\u02B6\u02C1\u02BB\u02B3\u02BD.\u02B7\u02BB\u02B5\u02BF\u02BA\u02BC\u02B9\u02B5\u02C0\u02B2\u02BC.NONE;
					if (flag3)
					{
						if (noteOnEvent.Velocity == 1)
						{
							u02B7_u02BB_u02B5_u02BF_u02BA_u02BC_u02B9_u02B5_u02C0_u02B2_u02BC |= \u02BF\u02BF\u02BB\u02BC\u02B5\u02B9\u02B6\u02C1\u02BB\u02B3\u02BD.\u02B7\u02BB\u02B5\u02BF\u02BA\u02BC\u02B9\u02B5\u02C0\u02B2\u02BC.GHOST;
						}
						else if (noteOnEvent.Velocity == 127)
						{
							u02B7_u02BB_u02B5_u02BF_u02BA_u02BC_u02B9_u02B5_u02C0_u02B2_u02BC |= \u02BF\u02BF\u02BB\u02BC\u02B5\u02B9\u02B6\u02C1\u02BB\u02B3\u02BD.\u02B7\u02BB\u02B5\u02BF\u02BA\u02BC\u02B9\u02B5\u02C0\u02B2\u02BC.ACCENT;
						}
					}
					if (u02C1_u02B2_u02B5_u02BE_u02C0_u02C0_u02C1_u02B2_u02B3_u02BE_u02BA != \u02BF\u02BF\u02BB\u02BC\u02B5\u02B9\u02B6\u02C1\u02BB\u02B3\u02BD.\u02C1\u02B2\u02B5\u02BE\u02C0\u02C0\u02C1\u02B2\u02B3\u02BE\u02BA.KICK_ORANGE && u02C1_u02B2_u02B5_u02BE_u02C0_u02C0_u02C1_u02B2_u02B3_u02BE_u02BA != \u02BF\u02BF\u02BB\u02BC\u02B5\u02B9\u02B6\u02C1\u02BB\u02B3\u02BD.\u02C1\u02B2\u02B5\u02BE\u02C0\u02C0\u02C1\u02B2\u02B3\u02BE\u02BA.DOUBLEKICK_ORANGE)
					{
						u02B7_u02BB_u02B5_u02BF_u02BA_u02BC_u02B9_u02B5_u02C0_u02B2_u02BC |= \u02BF\u02BF\u02BB\u02BC\u02B5\u02B9\u02B6\u02C1\u02BB\u02B3\u02BD.\u02B7\u02BB\u02B5\u02BF\u02BA\u02BC\u02B9\u02B5\u02C0\u02B2\u02BC.CYMBAL;
					}
					\u02B4\u02BC\u02BF\u02BC\u02BA\u02B9\u02B8\u02B2\u02BD\u02BE\u02BD.\u02B8\u02C1\u02B8\u02C1\u02C0\u02B8\u02B5\u02B4\u02B6\u02BC\u02B7(\u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF, value).\u02BC\u02BA\u02BE\u02BC\u02C1\u02BC\u02B9\u02C1\u02C1\u02B7\u02BB(new \u02BF\u02BF\u02BB\u02BC\u02B5\u02B9\u02B6\u02C1\u02BB\u02B3\u02BD(num2, u02C1_u02B2_u02B5_u02BE_u02C0_u02C0_u02C1_u02B2_u02B3_u02BE_u02BA, num3, u02B7_u02BB_u02B5_u02BF_u02BA_u02BC_u02B9_u02B5_u02C0_u02B2_u02BC));
					if (\u02BB\u02C0\u02B5\u02C1\u02BA\u02B7\u02B3\u02C0\u02B7\u02BB\u02B3.\u02B8\u02B3\u02B9\u02BD\u02BC\u02BD\u02B5\u02C0\u02BD\u02BC\u02BA)
					{
						list.Add((int)value);
						continue;
					}
				}
			}
			if (!\u02BB\u02C0\u02B5\u02C1\u02BA\u02B7\u02B3\u02C0\u02B7\u02BB\u02B3.\u02B8\u02B3\u02B9\u02BD\u02BC\u02BD\u02B5\u02C0\u02BD\u02BC\u02BA)
			{
				TextEvent textEvent = midiEvent as TextEvent;
				if (textEvent != null)
				{
					if (textEvent.Text.Length > 5 && textEvent.Text.StartsWith("[mix "))
					{
						list2.Add(textEvent);
					}
					if (textEvent.Text == "ENABLE_CHART_DYNAMICS" || textEvent.Text == "[ENABLE_CHART_DYNAMICS]")
					{
						flag3 = true;
					}
				}
				TextEvent textEvent2 = midiEvent as TextEvent;
				if (textEvent2 != null)
				{
					\u02B4\u02BC\u02BF\u02BC\u02BA\u02B9\u02B8\u02B2\u02BD\u02BE\u02BD.\u02B8\u02C1\u02B8\u02C1\u02C0\u02B8\u02B5\u02B4\u02B6\u02BC\u02B7(\u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF, \u02B7\u02BD\u02BB\u02BB\u02BF\u02B5\u02C0\u02C1\u02BD\u02B3\u02B6.\u02BA\u02BF\u02B9\u02B7\u02B4\u02B7\u02B4\u02BD\u02BF\u02B4\u02B7.Expert).\u02BD\u02B3\u02B3\u02C1\u02B8\u02B9\u02BB\u02BF\u02C1\u02C0\u02B9(textEvent2);
				}
			}
		}
		if (!\u02BB\u02C0\u02B5\u02C1\u02BA\u02B7\u02B3\u02C0\u02B7\u02BB\u02B3.\u02B8\u02B3\u02B9\u02BD\u02BC\u02BD\u02B5\u02C0\u02BD\u02BC\u02BA)
		{
			\u02C0\u02BA\u02B7\u02BA\u02B5\u02BE\u02BC\u02BF\u02B9\u02BC\u02B8[] array3 = new \u02C0\u02BA\u02B7\u02BA\u02B5\u02BE\u02BC\u02BF\u02B9\u02BC\u02B8[array.Length];
			int num6 = 0;
			foreach (\u02B7\u02BD\u02BB\u02BB\u02BF\u02B5\u02C0\u02C1\u02BD\u02B3\u02B6.\u02BA\u02BF\u02B9\u02B7\u02B4\u02B7\u02B4\u02BD\u02BF\u02B4\u02B7 u02BA_u02BF_u02B9_u02B7_u02B4_u02B7_u02B4_u02BD_u02BF_u02B4_u02B7 in array)
			{
				array3[num6++] = \u02B4\u02BC\u02BF\u02BC\u02BA\u02B9\u02B8\u02B2\u02BD\u02BE\u02BD.\u02B8\u02C1\u02B8\u02C1\u02C0\u02B8\u02B5\u02B4\u02B6\u02BC\u02B7(\u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF, u02BA_u02BF_u02B9_u02B7_u02B4_u02B7_u02B4_u02BD_u02BF_u02B4_u02B7);
			}
			for (int j = 0; j < list3.Count; j++)
			{
				uint num7 = (uint)list3[j].AbsoluteTime;
				uint num8 = (uint)list3[j].OffEvent.AbsoluteTime;
				if (num8 - num7 != 0U)
				{
					num8 -= 1U;
				}
				foreach (\u02C0\u02BA\u02B7\u02BA\u02B5\u02BE\u02BC\u02BF\u02B9\u02BC\u02B8 u02C0_u02BA_u02B7_u02BA_u02B5_u02BE_u02BC_u02BF_u02B9_u02BC_u02B in array3)
				{
					ValueTuple<int, int> valueTuple = \u02BC\u02BA\u02C0\u02B2\u02BA\u02C0\u02BC\u02C1\u02BD\u02B8\u02B8.\u02BE\u02C1\u02B2\u02BB\u02B9\u02BD\u02B6\u02B9\u02B6\u02B2\u02B9<\u02BF\u02BF\u02BB\u02BC\u02B5\u02B9\u02B6\u02C1\u02BB\u02B3\u02BD>(u02C0_u02BA_u02B7_u02BA_u02B5_u02BE_u02BC_u02BF_u02B9_u02BC_u02B.\u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8, num7, num8);
					for (int k = valueTuple.Item1; k < valueTuple.Item2; k++)
					{
						switch (u02C0_u02BA_u02B7_u02BA_u02B5_u02BE_u02BC_u02BF_u02B9_u02BC_u02B.\u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8[k].\u02BD\u02BA\u02BC\u02B8\u02B2\u02B7\u02B8\u02B8\u02BA\u02BA\u02BF)
						{
						case \u02BF\u02BF\u02BB\u02BC\u02B5\u02B9\u02B6\u02C1\u02BB\u02B3\u02BD.\u02C1\u02B2\u02B5\u02BE\u02C0\u02C0\u02C1\u02B2\u02B3\u02BE\u02BA.CYM_YELLOW:
							if (list3[j].NoteNumber == 110)
							{
								u02C0_u02BA_u02B7_u02BA_u02B5_u02BE_u02BC_u02BF_u02B9_u02BC_u02B.\u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8[k].\u02BD\u02BA\u02BC\u02B8\u02B2\u02B7\u02B8\u02B8\u02BA\u02BA\u02BF = \u02BF\u02BF\u02BB\u02BC\u02B5\u02B9\u02B6\u02C1\u02BB\u02B3\u02BD.\u02C1\u02B2\u02B5\u02BE\u02C0\u02C0\u02C1\u02B2\u02B3\u02BE\u02BA.TOM_YELLOW;
								u02C0_u02BA_u02B7_u02BA_u02B5_u02BE_u02BC_u02BF_u02B9_u02BC_u02B.\u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8[k].\u02C0\u02B7\u02C1\u02B5\u02B9\u02B3\u02BF\u02B5\u02BC\u02B9\u02C0 ^= \u02BF\u02BF\u02BB\u02BC\u02B5\u02B9\u02B6\u02C1\u02BB\u02B3\u02BD.\u02B7\u02BB\u02B5\u02BF\u02BA\u02BC\u02B9\u02B5\u02C0\u02B2\u02BC.CYMBAL;
								u02C0_u02BA_u02B7_u02BA_u02B5_u02BE_u02BC_u02BF_u02B9_u02BC_u02B.\u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8[k].\u02C0\u02B7\u02C1\u02B5\u02B9\u02B3\u02BF\u02B5\u02BC\u02B9\u02C0 |= \u02BF\u02BF\u02BB\u02BC\u02B5\u02B9\u02B6\u02C1\u02BB\u02B3\u02BD.\u02B7\u02BB\u02B5\u02BF\u02BA\u02BC\u02B9\u02B5\u02C0\u02B2\u02BC.TOM;
							}
							break;
						case \u02BF\u02BF\u02BB\u02BC\u02B5\u02B9\u02B6\u02C1\u02BB\u02B3\u02BD.\u02C1\u02B2\u02B5\u02BE\u02C0\u02C0\u02C1\u02B2\u02B3\u02BE\u02BA.CYM_BLUE:
							if (list3[j].NoteNumber == 111)
							{
								u02C0_u02BA_u02B7_u02BA_u02B5_u02BE_u02BC_u02BF_u02B9_u02BC_u02B.\u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8[k].\u02BD\u02BA\u02BC\u02B8\u02B2\u02B7\u02B8\u02B8\u02BA\u02BA\u02BF = \u02BF\u02BF\u02BB\u02BC\u02B5\u02B9\u02B6\u02C1\u02BB\u02B3\u02BD.\u02C1\u02B2\u02B5\u02BE\u02C0\u02C0\u02C1\u02B2\u02B3\u02BE\u02BA.TOM_BLUE;
								u02C0_u02BA_u02B7_u02BA_u02B5_u02BE_u02BC_u02BF_u02B9_u02BC_u02B.\u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8[k].\u02C0\u02B7\u02C1\u02B5\u02B9\u02B3\u02BF\u02B5\u02BC\u02B9\u02C0 ^= \u02BF\u02BF\u02BB\u02BC\u02B5\u02B9\u02B6\u02C1\u02BB\u02B3\u02BD.\u02B7\u02BB\u02B5\u02BF\u02BA\u02BC\u02B9\u02B5\u02C0\u02B2\u02BC.CYMBAL;
								u02C0_u02BA_u02B7_u02BA_u02B5_u02BE_u02BC_u02BF_u02B9_u02BC_u02B.\u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8[k].\u02C0\u02B7\u02C1\u02B5\u02B9\u02B3\u02BF\u02B5\u02BC\u02B9\u02C0 |= \u02BF\u02BF\u02BB\u02BC\u02B5\u02B9\u02B6\u02C1\u02BB\u02B3\u02BD.\u02B7\u02BB\u02B5\u02BF\u02BA\u02BC\u02B9\u02B5\u02C0\u02B2\u02BC.TOM;
							}
							break;
						case \u02BF\u02BF\u02BB\u02BC\u02B5\u02B9\u02B6\u02C1\u02BB\u02B3\u02BD.\u02C1\u02B2\u02B5\u02BE\u02C0\u02C0\u02C1\u02B2\u02B3\u02BE\u02BA.CYM_GREEN:
							if (list3[j].NoteNumber == 112)
							{
								u02C0_u02BA_u02B7_u02BA_u02B5_u02BE_u02BC_u02BF_u02B9_u02BC_u02B.\u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8[k].\u02BD\u02BA\u02BC\u02B8\u02B2\u02B7\u02B8\u02B8\u02BA\u02BA\u02BF = \u02BF\u02BF\u02BB\u02BC\u02B5\u02B9\u02B6\u02C1\u02BB\u02B3\u02BD.\u02C1\u02B2\u02B5\u02BE\u02C0\u02C0\u02C1\u02B2\u02B3\u02BE\u02BA.TOM_GREEN;
								u02C0_u02BA_u02B7_u02BA_u02B5_u02BE_u02BC_u02BF_u02B9_u02BC_u02B.\u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8[k].\u02C0\u02B7\u02C1\u02B5\u02B9\u02B3\u02BF\u02B5\u02BC\u02B9\u02C0 ^= \u02BF\u02BF\u02BB\u02BC\u02B5\u02B9\u02B6\u02C1\u02BB\u02B3\u02BD.\u02B7\u02BB\u02B5\u02BF\u02BA\u02BC\u02B9\u02B5\u02C0\u02B2\u02BC.CYMBAL;
								u02C0_u02BA_u02B7_u02BA_u02B5_u02BE_u02BC_u02BF_u02B9_u02BC_u02B.\u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8[k].\u02C0\u02B7\u02C1\u02B5\u02B9\u02B3\u02BF\u02B5\u02BC\u02B9\u02C0 |= \u02BF\u02BF\u02BB\u02BC\u02B5\u02B9\u02B6\u02C1\u02BB\u02B3\u02BD.\u02B7\u02BB\u02B5\u02BF\u02BA\u02BC\u02B9\u02B5\u02C0\u02B2\u02BC.TOM;
							}
							break;
						}
					}
				}
			}
			for (int l = 0; l < list5.Count; l++)
			{
				NoteOnEvent noteOnEvent2;
				bool flag4;
				list5[l].Deconstruct(out noteOnEvent2, out flag4);
				NoteOnEvent noteOnEvent3 = noteOnEvent2;
				bool flag5 = flag4;
				uint num9 = (uint)noteOnEvent3.AbsoluteTime;
				uint num10 = (uint)noteOnEvent3.OffEvent.AbsoluteTime;
				if (num9 > num10)
				{
					break;
				}
				\u02C0\u02BA\u02B7\u02BA\u02B5\u02BE\u02BC\u02BF\u02B9\u02BC\u02B8 u02C0_u02BA_u02B7_u02BA_u02B5_u02BE_u02BC_u02BF_u02B9_u02BC_u02B2 = \u02B4\u02BC\u02BF\u02BC\u02BA\u02B9\u02B8\u02B2\u02BD\u02BE\u02BD.\u02B8\u02C1\u02B8\u02C1\u02C0\u02B8\u02B5\u02B4\u02B6\u02BC\u02B7(\u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF, \u02B7\u02BD\u02BB\u02BB\u02BF\u02B5\u02C0\u02C1\u02BD\u02B3\u02B6.\u02BA\u02BF\u02B9\u02B7\u02B4\u02B7\u02B4\u02BD\u02BF\u02B4\u02B7.Expert);
				ValueTuple<int, int> valueTuple2 = \u02BC\u02BA\u02C0\u02B2\u02BA\u02C0\u02BC\u02C1\u02BD\u02B8\u02B8.\u02BE\u02C1\u02B2\u02BB\u02B9\u02BD\u02B6\u02B9\u02B6\u02B2\u02B9<\u02BF\u02BF\u02BB\u02BC\u02B5\u02B9\u02B6\u02C1\u02BB\u02B3\u02BD>(u02C0_u02BA_u02B7_u02BA_u02B5_u02BE_u02BC_u02BF_u02B9_u02BC_u02B2.\u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8, num9, num10);
				if (valueTuple2.Item1 == -1 || valueTuple2.Item2 == -1)
				{
					break;
				}
				bool flag6 = false;
				if (!flag5)
				{
					for (int m = valueTuple2.Item1; m < valueTuple2.Item2; m++)
					{
						if (u02C0_u02BA_u02B7_u02BA_u02B5_u02BE_u02BC_u02BF_u02B9_u02BC_u02B2.\u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8[m].\u02BD\u02BA\u02BC\u02B8\u02B2\u02B7\u02B8\u02B8\u02BA\u02BA\u02BF != \u02BF\u02BF\u02BB\u02BC\u02B5\u02B9\u02B6\u02C1\u02BB\u02B3\u02BD.\u02C1\u02B2\u02B5\u02BE\u02C0\u02C0\u02C1\u02B2\u02B3\u02BE\u02BA.KICK_ORANGE && u02C0_u02BA_u02B7_u02BA_u02B5_u02BE_u02BC_u02BF_u02B9_u02BC_u02B2.\u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8[m].\u02BD\u02BA\u02BC\u02B8\u02B2\u02B7\u02B8\u02B8\u02BA\u02BA\u02BF != \u02BF\u02BF\u02BB\u02BC\u02B5\u02B9\u02B6\u02C1\u02BB\u02B3\u02BD.\u02C1\u02B2\u02B5\u02BE\u02C0\u02C0\u02C1\u02B2\u02B3\u02BE\u02BA.DOUBLEKICK_ORANGE)
						{
							flag6 = true;
							break;
						}
					}
				}
				else
				{
					int num11 = 0;
					\u02BF\u02BF\u02BB\u02BC\u02B5\u02B9\u02B6\u02C1\u02BB\u02B3\u02BD.\u02C1\u02B2\u02B5\u02BE\u02C0\u02C0\u02C1\u02B2\u02B3\u02BE\u02BA u02C1_u02B2_u02B5_u02BE_u02C0_u02C0_u02C1_u02B2_u02B3_u02BE_u02BA2 = \u02BF\u02BF\u02BB\u02BC\u02B5\u02B9\u02B6\u02C1\u02BB\u02B3\u02BD.\u02C1\u02B2\u02B5\u02BE\u02C0\u02C0\u02C1\u02B2\u02B3\u02BE\u02BA.GREEN;
					for (int n = valueTuple2.Item1; n < valueTuple2.Item2; n++)
					{
						if (u02C0_u02BA_u02B7_u02BA_u02B5_u02BE_u02BC_u02BF_u02B9_u02BC_u02B2.\u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8[n].\u02BD\u02BA\u02BC\u02B8\u02B2\u02B7\u02B8\u02B8\u02BA\u02BA\u02BF != \u02BF\u02BF\u02BB\u02BC\u02B5\u02B9\u02B6\u02C1\u02BB\u02B3\u02BD.\u02C1\u02B2\u02B5\u02BE\u02C0\u02C0\u02C1\u02B2\u02B3\u02BE\u02BA.KICK_ORANGE && u02C0_u02BA_u02B7_u02BA_u02B5_u02BE_u02BC_u02BF_u02B9_u02BC_u02B2.\u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8[n].\u02BD\u02BA\u02BC\u02B8\u02B2\u02B7\u02B8\u02B8\u02BA\u02BA\u02BF != \u02BF\u02BF\u02BB\u02BC\u02B5\u02B9\u02B6\u02C1\u02BB\u02B3\u02BD.\u02C1\u02B2\u02B5\u02BE\u02C0\u02C0\u02C1\u02B2\u02B3\u02BE\u02BA.DOUBLEKICK_ORANGE)
						{
							num11++;
							if (num11 == 1)
							{
								u02C1_u02B2_u02B5_u02BE_u02C0_u02C0_u02C1_u02B2_u02B3_u02BE_u02BA2 = u02C0_u02BA_u02B7_u02BA_u02B5_u02BE_u02BC_u02BF_u02B9_u02BC_u02B2.\u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8[n].\u02BD\u02BA\u02BC\u02B8\u02B2\u02B7\u02B8\u02B8\u02BA\u02BA\u02BF;
							}
							else if (num11 == 2)
							{
								if (u02C0_u02BA_u02B7_u02BA_u02B5_u02BE_u02BC_u02BF_u02B9_u02BC_u02B2.\u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8[n].\u02BD\u02BA\u02BC\u02B8\u02B2\u02B7\u02B8\u02B8\u02BA\u02BA\u02BF != u02C1_u02B2_u02B5_u02BE_u02C0_u02C0_u02C1_u02B2_u02B3_u02BE_u02BA2)
								{
									flag6 = true;
									break;
								}
								break;
							}
						}
					}
				}
				if (!flag6)
				{
					break;
				}
				\u02B5\u02B7\u02B8\u02B7\u02BE\u02BB\u02C0\u02B9\u02BC\u02B2\u02C0 u02B5_u02B7_u02B8_u02B7_u02BE_u02BB_u02C0_u02B9_u02BC_u02B2_u02C = new \u02B5\u02B7\u02B8\u02B7\u02BE\u02BB\u02C0\u02B9\u02BC\u02B2\u02C0(num9, num10 - num9, flag5);
				\u02B4\u02BC\u02BF\u02BC\u02BA\u02B9\u02B8\u02B2\u02BD\u02BE\u02BD.\u02B8\u02C1\u02B8\u02C1\u02C0\u02B8\u02B5\u02B4\u02B6\u02BC\u02B7(\u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF, \u02B7\u02BD\u02BB\u02BB\u02BF\u02B5\u02C0\u02C1\u02BD\u02B3\u02B6.\u02BA\u02BF\u02B9\u02B7\u02B4\u02B7\u02B4\u02BD\u02BF\u02B4\u02B7.Expert).\u02BC\u02BA\u02BE\u02BC\u02C1\u02BC\u02B9\u02C1\u02C1\u02B7\u02BB(u02B5_u02B7_u02B8_u02B7_u02BE_u02BB_u02C0_u02B9_u02BC_u02B2_u02C);
			}
			for (int num12 = 0; num12 < list4.Count; num12++)
			{
				uint num13 = (uint)list4[num12].AbsoluteTime;
				uint num14 = (uint)list4[num12].OffEvent.AbsoluteTime;
				if (num13 > num14)
				{
					break;
				}
				\u02C0\u02BA\u02B7\u02BA\u02B5\u02BE\u02BC\u02BF\u02B9\u02BC\u02B8 u02C0_u02BA_u02B7_u02BA_u02B5_u02BE_u02BC_u02BF_u02B9_u02BC_u02B3 = \u02B4\u02BC\u02BF\u02BC\u02BA\u02B9\u02B8\u02B2\u02BD\u02BE\u02BD.\u02B8\u02C1\u02B8\u02C1\u02C0\u02B8\u02B5\u02B4\u02B6\u02BC\u02B7(\u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF, \u02B7\u02BD\u02BB\u02BB\u02BF\u02B5\u02C0\u02C1\u02BD\u02B3\u02B6.\u02BA\u02BF\u02B9\u02B7\u02B4\u02B7\u02B4\u02BD\u02BF\u02B4\u02B7.Expert);
				ValueTuple<int, int> valueTuple3 = \u02BC\u02BA\u02C0\u02B2\u02BA\u02C0\u02BC\u02C1\u02BD\u02B8\u02B8.\u02BE\u02C1\u02B2\u02BB\u02B9\u02BD\u02B6\u02B9\u02B6\u02B2\u02B9<\u02BF\u02BF\u02BB\u02BC\u02B5\u02B9\u02B6\u02C1\u02BB\u02B3\u02BD>(u02C0_u02BA_u02B7_u02BA_u02B5_u02BE_u02BC_u02BF_u02B9_u02BC_u02B3.\u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8, num13, num14);
				for (int num15 = valueTuple3.Item1; num15 < valueTuple3.Item2; num15++)
				{
					u02C0_u02BA_u02B7_u02BA_u02B5_u02BE_u02BC_u02BF_u02B9_u02BC_u02B3.\u02B2\u02BF\u02BA\u02BE\u02BB\u02B5\u02C1\u02BD\u02BB\u02B4\u02B8[num15].\u02C0\u02B7\u02C1\u02B5\u02B9\u02B3\u02BF\u02B5\u02BC\u02B9\u02C0 |= \u02BF\u02BF\u02BB\u02BC\u02B5\u02B9\u02B6\u02C1\u02BB\u02B3\u02BD.\u02B7\u02BB\u02B5\u02BF\u02BA\u02BC\u02B9\u02B5\u02C0\u02B2\u02BC.FLAM;
				}
			}
			for (int num16 = 0; num16 < list2.Count; num16++)
			{
				string[] array5 = list2[num16].Text.Substring(1, list2[num16].Text.Length - 2).Split(new char[] { ' ' });
				if (array5.Length == 3)
				{
					string text = array5[0];
					int num17 = int.Parse(array5[1]);
					\u02B7\u02BD\u02BB\u02BB\u02BF\u02B5\u02C0\u02C1\u02BD\u02B3\u02B6.\u02BA\u02BF\u02B9\u02B7\u02B4\u02B7\u02B4\u02BD\u02BF\u02B4\u02B7 u02BA_u02BF_u02B9_u02B7_u02B4_u02B7_u02B4_u02BD_u02BF_u02B4_u02B8 = \u02B6\u02C0\u02B5\u02C1\u02B9\u02BF\u02C0\u02B6\u02BF\u02B2\u02BE.\u02BB\u02C1\u02C1\u02BF\u02B6\u02B7\u02B4\u02C0\u02B5\u02BB\u02BA(num17);
					string text2 = array5[2];
					if (text2.Substring(0, 5) == "drums" && text == "mix")
					{
						\u02B4\u02BC\u02BF\u02BC\u02BA\u02B9\u02B8\u02B2\u02BD\u02BE\u02BD.\u02B8\u02C1\u02B8\u02C1\u02C0\u02B8\u02B5\u02B4\u02B6\u02BC\u02B7(\u02B7\u02BB\u02BA\u02BC\u02B4\u02B6\u02B4\u02B3\u02BD\u02BA\u02BF, u02BA_u02BF_u02B9_u02B7_u02B4_u02B7_u02B4_u02BD_u02BF_u02B4_u02B8).\u02BC\u02BA\u02BE\u02BC\u02C1\u02BC\u02B9\u02C1\u02C1\u02B7\u02BB(new \u02BE\u02BD\u02BB\u02BC\u02C0\u02B6\u02B4\u02BA\u02BF\u02B9\u02BE(num17, text2, (uint)list2[num16].AbsoluteTime));
					}
				}
			}
		}
	}

	private static bool \u02B8\u02B3\u02B9\u02BD\u02BC\u02BD\u02B5\u02C0\u02BD\u02BC\u02BA = false;

	private static readonly char[] \u02BE\u02B4\u02B2\u02B7\u02B8\u02B3\u02B7\u02BC\u02BD\u02C1\u02B6 = new char[] { '[', ']' };
}
