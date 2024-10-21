using System;
using System.Collections.Generic;
using System.IO;
using StrikeCore;
using UnityEngine;

// Token: 0x02000376 RID: 886
public class ScreenshotReader
{
	// Token: 0x0600203A RID: 8250 RVA: 0x000D7B30 File Offset: 0x000D5D30
	public void WriteDataToFile(BinaryReader reader)
	{
		string text = Path.Combine(Application.persistentDataPath, "screenshotInfo.txt");
		int num = reader.ReadInt32();
		if (num != this.formatVersion)
		{
			Debug.LogError(string.Format("Format version mismatch! Expected: 6. Got: {0}", num));
		}
		this.gameVersion = reader.ReadString();
		this.chartMD5hash = reader.ReadString();
		this.songName = reader.ReadString();
		this.artistName = reader.ReadString();
		this.charterName = reader.ReadString();
		this.gameMode = (GameMode)reader.ReadInt32();
		this.songSpeed = reader.ReadInt32();
		this.scoreTimestamp = DateTime.SpecifyKind(DateTime.FromBinary(reader.ReadInt64()), DateTimeKind.Utc);
		this.bandScore = reader.ReadInt32();
		this.bandStars = reader.ReadInt32();
		this.playerCount = reader.ReadInt32();
		for (int i = 0; i < this.playerCount; i++)
		{
			PlayerStatsData playerStatsData = new PlayerStatsData();
			playerStatsData.Deserialize(reader);
			this.playerData.Add(playerStatsData);
		}
		string text2 = string.Format("Game Version:      {10}{9}Chart MD5:         {0}{9}Song Name:         {1}{9}Artist Name:       {2}{9}Charter Name:      {3}{9}Song Speed:        {4}%{9}Time:              {5:r}{9}Band Score:        {6:000000000}{9}Band Stars:        {7}{9}Player Count:      {8}{9}----------------{9}", new object[]
		{
			this.chartMD5hash,
			this.songName,
			this.artistName,
			this.charterName,
			this.songSpeed + 100,
			this.scoreTimestamp,
			this.bandScore,
			this.bandStars,
			this.playerCount,
			Environment.NewLine,
			this.gameVersion
		});
		int num2 = 0;
		foreach (PlayerStatsData playerStatsData2 in this.playerData)
		{
			num2++;
			text2 += string.Format("Player {20} stats:{21}Instrument:        {0}{21}Difficulty:        {1}{21}Player Name:       {2}{21}Gamepad Mode:      {3}{21}Modifiers:         {4}{21}Is Local Player:   {5}{21}Lefty Flip:        {6}{21}No Fail:           {7}{21}Video offset:      {8}ms{21}Audio offset:      {9}ms{21}Controller:        {10}{21}Player Score:      {11:000000000}{21}Note Score:        {12:000000000}{21}Solo Bonus:        {13:000000000}{21}Notes hit:         {14}/{15}{21}Max combo:         {16:000000000}{21}Star Power earned: {17}/{18}{21}FC:                {19}{21}{22}{21}{23}{21}{24}{21}{25}{21}{26}{21}----------------{21}", new object[]
			{
				playerStatsData2.chartInstrument,
				playerStatsData2.difficulty,
				playerStatsData2.profileName,
				playerStatsData2.isGamepadMode,
				playerStatsData2.modifers,
				!playerStatsData2.isNetworkPlayer,
				playerStatsData2.isLeftyFlip,
				playerStatsData2.isNoFail,
				playerStatsData2.videoCalibration * 1000f,
				playerStatsData2.audioCalibration * 1000f,
				playerStatsData2.controllerType,
				playerStatsData2.playerScore,
				playerStatsData2.baseScore,
				playerStatsData2.soloBonusTotal,
				playerStatsData2.notesHit,
				playerStatsData2.totalNotes,
				playerStatsData2.maxStreak,
				playerStatsData2.spPhrasesEarned,
				playerStatsData2.spPhrasesTotal,
				playerStatsData2.isFC,
				num2,
				Environment.NewLine,
				playerStatsData2.ione,
				playerStatsData2.itwo,
				playerStatsData2.ithree,
				playerStatsData2.ifour,
				playerStatsData2.boolone
			});
		}
		File.WriteAllText(text, text2);
	}

	// Token: 0x0600203B RID: 8251 RVA: 0x00018CD9 File Offset: 0x00016ED9
	public ScreenshotReader()
	{
		this.formatVersion = 6;
		this.playerData = new List<PlayerStatsData>(4);
	}

	// Token: 0x0600203C RID: 8252 RVA: 0x000D7EE0 File Offset: 0x000D60E0
	public string ParseData(BinaryReader reader)
	{
		int num = reader.ReadInt32();
		if (num != this.formatVersion)
		{
			Debug.LogError(string.Format("Format version mismatch! Expected: 6. Got: {0}", num));
		}
		this.gameVersion = reader.ReadString();
		this.chartMD5hash = reader.ReadString();
		this.songName = reader.ReadString();
		this.artistName = reader.ReadString();
		this.charterName = reader.ReadString();
		this.gameMode = (GameMode)reader.ReadInt32();
		this.songSpeed = reader.ReadInt32();
		this.scoreTimestamp = DateTime.SpecifyKind(DateTime.FromBinary(reader.ReadInt64()), DateTimeKind.Utc);
		this.bandScore = reader.ReadInt32();
		this.bandStars = reader.ReadInt32();
		this.playerCount = reader.ReadInt32();
		for (int i = 0; i < this.playerCount; i++)
		{
			PlayerStatsData playerStatsData = new PlayerStatsData();
			playerStatsData.Deserialize(reader);
			this.playerData.Add(playerStatsData);
		}
		string text = string.Format("Game Version:      {10}{9}Chart MD5:         {0}{9}Song Name:         {1}{9}Artist Name:       {2}{9}Charter Name:      {3}{9}Song Speed:        {4}%{9}Time:              {5:r}{9}Band Score:        {6:000000000}{9}Band Stars:        {7}{9}Player Count:      {8}{9}----------------{9}", new object[]
		{
			this.chartMD5hash,
			this.songName,
			this.artistName,
			this.charterName,
			this.songSpeed + 100,
			this.scoreTimestamp,
			this.bandScore,
			this.bandStars,
			this.playerCount,
			Environment.NewLine,
			this.gameVersion
		});
		int num2 = 0;
		foreach (PlayerStatsData playerStatsData2 in this.playerData)
		{
			num2++;
			text += string.Format("Player {20} stats:{21}Instrument:        {0}{21}Difficulty:        {1}{21}Player Name:       {2}{21}Gamepad Mode:      {3}{21}Modifiers:         {4}{21}Is Local Player:   {5}{21}Lefty Flip:        {6}{21}No Fail:           {7}{21}Video offset:      {8}ms{21}Audio offset:      {9}ms{21}Controller:        {10}{21}Player Score:      {11:000000000}{21}Note Score:        {12:000000000}{21}Solo Bonus:        {13:000000000}{21}Notes hit:         {14}/{15}{21}Max combo:         {16:000000000}{21}Star Power earned: {17}/{18}{21}FC:                {19}{21}{22}{21}{23}{21}{24}{21}{25}{21}{26}{21}----------------{21}", new object[]
			{
				playerStatsData2.chartInstrument,
				playerStatsData2.difficulty,
				playerStatsData2.profileName,
				playerStatsData2.isGamepadMode,
				playerStatsData2.modifers,
				!playerStatsData2.isNetworkPlayer,
				playerStatsData2.isLeftyFlip,
				playerStatsData2.isNoFail,
				playerStatsData2.videoCalibration * 1000f,
				playerStatsData2.audioCalibration * 1000f,
				playerStatsData2.controllerType,
				playerStatsData2.playerScore,
				playerStatsData2.baseScore,
				playerStatsData2.soloBonusTotal,
				playerStatsData2.notesHit,
				playerStatsData2.totalNotes,
				playerStatsData2.maxStreak,
				playerStatsData2.spPhrasesEarned,
				playerStatsData2.spPhrasesTotal,
				playerStatsData2.isFC,
				num2,
				Environment.NewLine,
				playerStatsData2.ione,
				playerStatsData2.itwo,
				playerStatsData2.ithree,
				playerStatsData2.ifour,
				playerStatsData2.boolone
			});
		}
		return text;
	}

	// Token: 0x0400198D RID: 6541
	private int formatVersion;

	// Token: 0x0400198E RID: 6542
	private string chartMD5hash;

	// Token: 0x0400198F RID: 6543
	private string songName;

	// Token: 0x04001990 RID: 6544
	private string artistName;

	// Token: 0x04001991 RID: 6545
	private string charterName;

	// Token: 0x04001992 RID: 6546
	private int songSpeed;

	// Token: 0x04001993 RID: 6547
	private DateTime scoreTimestamp;

	// Token: 0x04001994 RID: 6548
	private int bandScore;

	// Token: 0x04001995 RID: 6549
	private int bandStars;

	// Token: 0x04001996 RID: 6550
	private int playerCount;

	// Token: 0x04001997 RID: 6551
	private List<PlayerStatsData> playerData;

	// Token: 0x04001998 RID: 6552
	private string outputPath;

	// Token: 0x04001999 RID: 6553
	public string lastScreenshot;

	// Token: 0x0400199A RID: 6554
	public string gameVersion;

	// Token: 0x0400199B RID: 6555
	public GameMode gameMode;
}
