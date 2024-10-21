using System;
using System.IO;

// Token: 0x0200036F RID: 879
public class PlayerStatsData
{
	// Token: 0x06002038 RID: 8248 RVA: 0x000D79F4 File Offset: 0x000D5BF4
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

	// Token: 0x0400193D RID: 6461
	public PlayerStatsData.Instrument chartInstrument;

	// Token: 0x0400193E RID: 6462
	public PlayerStatsData.Difficulty difficulty;

	// Token: 0x0400193F RID: 6463
	public string profileName;

	// Token: 0x04001940 RID: 6464
	public bool isGamepadMode;

	// Token: 0x04001941 RID: 6465
	public PlayerStatsData.PlayerModfiers modifers;

	// Token: 0x04001942 RID: 6466
	public bool isNetworkPlayer;

	// Token: 0x04001943 RID: 6467
	public bool isLeftyFlip;

	// Token: 0x04001944 RID: 6468
	public bool isNoFail;

	// Token: 0x04001945 RID: 6469
	public float videoCalibration;

	// Token: 0x04001946 RID: 6470
	public float audioCalibration;

	// Token: 0x04001947 RID: 6471
	public PlayerStatsData.ControllerType controllerType;

	// Token: 0x04001948 RID: 6472
	public int playerScore;

	// Token: 0x04001949 RID: 6473
	public int baseScore;

	// Token: 0x0400194A RID: 6474
	public int soloBonusTotal;

	// Token: 0x0400194B RID: 6475
	public int notesHit;

	// Token: 0x0400194C RID: 6476
	public int totalNotes;

	// Token: 0x0400194D RID: 6477
	public int maxStreak;

	// Token: 0x0400194E RID: 6478
	public int spPhrasesEarned;

	// Token: 0x0400194F RID: 6479
	public int spPhrasesTotal;

	// Token: 0x04001950 RID: 6480
	public bool isFC;

	// Token: 0x04001951 RID: 6481
	public int ione;

	// Token: 0x04001952 RID: 6482
	public int itwo;

	// Token: 0x04001953 RID: 6483
	public int ithree;

	// Token: 0x04001954 RID: 6484
	public int ifour;

	// Token: 0x04001955 RID: 6485
	public bool boolone;

	// Token: 0x02000370 RID: 880
	[Flags]
	public enum PlayerModfiers
	{
		// Token: 0x04001957 RID: 6487
		None = 1,
		// Token: 0x04001958 RID: 6488
		AllStrums = 2,
		// Token: 0x04001959 RID: 6489
		AllHOPOs = 4,
		// Token: 0x0400195A RID: 6490
		AllTaps = 8,
		// Token: 0x0400195B RID: 6491
		AllOpens = 16,
		// Token: 0x0400195C RID: 6492
		MirrorMode = 32,
		// Token: 0x0400195D RID: 6493
		Shuffle = 64,
		// Token: 0x0400195E RID: 6494
		HOPOsToTaps = 128,
		// Token: 0x0400195F RID: 6495
		LightsOut = 256,
		// Token: 0x04001960 RID: 6496
		ModFull = 512,
		// Token: 0x04001961 RID: 6497
		ModLite = 1024,
		// Token: 0x04001962 RID: 6498
		ModPrep = 2048
	}

	// Token: 0x02000371 RID: 881
	public enum ControllerType
	{
		// Token: 0x04001964 RID: 6500
		FiveFretGuitar = 1,
		// Token: 0x04001965 RID: 6501
		SixFretGuitar,
		// Token: 0x04001966 RID: 6502
		Drums
	}

	// Token: 0x02000372 RID: 882
	public enum Instrument
	{
		// Token: 0x04001968 RID: 6504
		None = -1,
		// Token: 0x04001969 RID: 6505
		Guitar,
		// Token: 0x0400196A RID: 6506
		Bass,
		// Token: 0x0400196B RID: 6507
		Rhythm,
		// Token: 0x0400196C RID: 6508
		GuitarCoop,
		// Token: 0x0400196D RID: 6509
		GHLGuitar,
		// Token: 0x0400196E RID: 6510
		GHLBass,
		// Token: 0x0400196F RID: 6511
		Drums,
		// Token: 0x04001970 RID: 6512
		Keys,
		// Token: 0x04001971 RID: 6513
		Band,
		// Token: 0x04001972 RID: 6514
		ProDrums
	}

	// Token: 0x02000373 RID: 883
	public enum Difficulty
	{
		// Token: 0x04001974 RID: 6516
		Easy,
		// Token: 0x04001975 RID: 6517
		Medium,
		// Token: 0x04001976 RID: 6518
		Hard,
		// Token: 0x04001977 RID: 6519
		Expert
	}
}
