using System;
using System.IO;

public class PlayerStatsData
{
	public void Deserialize(BinaryReader reader)
	{
		this.chartInstrument = (PlayerStatsData.Instrument)reader.ReadInt32();
		this.difficulty = (PlayerStatsData.Difficulty)reader.ReadInt32();
		this.profileName = reader.ReadString();
		this.isGamepadMode = reader.ReadBoolean();
		this.modifers = (PlayerStatsData.PlayerModfiers)reader.ReadInt32();
		this.isNetworkPlayer = reader.ReadBoolean();
		this.isLeftyFlip = reader.ReadBoolean();
		this.isNoFail = reader.ReadBoolean();
		this.videoCalibration = reader.ReadSingle();
		this.audioCalibration = reader.ReadSingle();
		this.controllerType = (PlayerStatsData.ControllerType)reader.ReadInt32();
		this.playerScore = reader.ReadInt32();
		this.baseScore = reader.ReadInt32();
		this.soloBonusTotal = reader.ReadInt32();
		this.notesHit = reader.ReadInt32();
		this.totalNotes = reader.ReadInt32();
		this.maxStreak = reader.ReadInt32();
		this.spPhrasesEarned = reader.ReadInt32();
		this.spPhrasesTotal = reader.ReadInt32();
		this.isFC = reader.ReadBoolean();
		this.ione = reader.ReadInt32();
		this.itwo = reader.ReadInt32();
		this.ithree = reader.ReadInt32();
		this.ifour = reader.ReadInt32();
		this.boolone = reader.ReadBoolean();
	}

	public PlayerStatsData.Instrument chartInstrument;

	public PlayerStatsData.Difficulty difficulty;

	public string profileName;

	public bool isGamepadMode;

	public PlayerStatsData.PlayerModfiers modifers;

	public bool isNetworkPlayer;

	public bool isLeftyFlip;

	public bool isNoFail;

	public float videoCalibration;

	public float audioCalibration;

	public PlayerStatsData.ControllerType controllerType;

	public int playerScore;

	public int baseScore;

	public int soloBonusTotal;

	public int notesHit;

	public int totalNotes;

	public int maxStreak;

	public int spPhrasesEarned;

	public int spPhrasesTotal;

	public bool isFC;

	public int ione;

	public int itwo;

	public int ithree;

	public int ifour;

	public bool boolone;

	[Flags]
	public enum PlayerModfiers
	{
		None = 1,
		AllStrums = 2,
		AllHOPOs = 4,
		AllTaps = 8,
		AllOpens = 16,
		MirrorMode = 32,
		Shuffle = 64,
		HOPOsToTaps = 128,
		LightsOut = 256,
		ModFull = 512,
		ModLite = 1024,
		ModPrep = 2048
	}

	public enum ControllerType
	{
		FiveFretGuitar = 1,
		SixFretGuitar,
		Drums
	}

	public enum Instrument
	{
		None = -1,
		Guitar,
		Bass,
		Rhythm,
		GuitarCoop,
		GHLGuitar,
		GHLBass,
		Drums,
		Keys,
		Band,
		ProDrums
	}

	public enum Difficulty
	{
		Easy,
		Medium,
		Hard,
		Expert
	}
}
