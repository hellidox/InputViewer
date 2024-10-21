using System;
using System.IO;
using System.Linq;
using StrikeCore;
using UnityEngine;

// Token: 0x0200005B RID: 91
public static class SettingsController
{
	// Token: 0x060003A3 RID: 931 RVA: 0x00007DAB File Offset: 0x00005FAB
	public static string \u02BE\u02BF\u02BE\u02BB\u02B3\u02B8\u02B9\u02BD\u02B9\u02B4\u02BC()
	{
		return Path.Combine(__FIXME_clon_util.GetDocumentsClonFolder(), "settings.ini");
	}

	// Token: 0x060003A4 RID: 932 RVA: 0x0002BEC4 File Offset: 0x0002A0C4
	[SettingsInit]
	[Preserve]
	public static void \u02BA\u02B7\u02BB\u02B2\u02B4\u02BA\u02B7\u02BA\u02BA\u02B6\u02B4()
	{
		string[] array = \u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02B2\u02BE\u02BF\u02BD\u02BB\u02B7\u02C0\u02BD\u02B4\u02BE\u02BA.\u02B6\u02BB\u02BC\u02BD\u02C1\u02B3\u02B9\u02B3\u02B3\u02BC\u02B3.Keys.ToArray<string>();
		string text = Settings.RegisterConfigFileName("settings", SettingsController.\u02BE\u02BF\u02BE\u02BB\u02B3\u02B8\u02B9\u02BD\u02B9\u02B4\u02BC());
		SectionKey sectionKey = Settings.RegisterSection(text, "offsets");
		SectionKey sectionKey2 = Settings.RegisterSection(text, "video");
		SectionKey sectionKey3 = Settings.RegisterSection(text, "streamer");
		SectionKey sectionKey4 = Settings.RegisterSection(text, "volume");
		SectionKey sectionKey5 = Settings.RegisterSection(text, "audio");
		SectionKey sectionKey6 = Settings.RegisterSection(text, "custom");
		SectionKey sectionKey7 = Settings.RegisterSection(text, "game");
		SectionKey sectionKey8 = Settings.RegisterSection(text, "online");
		SectionKey sectionKey9 = Settings.RegisterSection(text, "directories");
		SectionKey sectionKey10 = Settings.RegisterSection(text, "servers");
		SectionKey sectionKey11 = Settings.RegisterSection(text, "teststuff");
		SettingsController.\u02B7\u02B2\u02BB\u02BA\u02BD\u02B3\u02BA\u02BA\u02BE\u02B9\u02B4 = new GameSetting(sectionKey, "audio", 0, -2000, 2000, 1);
		SettingsController.\u02BE\u02C0\u02BA\u02B7\u02B9\u02C0\u02B6\u02BE\u02C1\u02B8\u02BB = new GameSetting(sectionKey, "video", 0, -2000, 2000, 1);
		SettingsController.\u02B3\u02B2\u02BD\u02C1\u02B2\u02B4\u02B5\u02B3\u02C1\u02B2\u02B6 = new GameSetting(sectionKey2, "vsync", Application.platform == RuntimePlatform.OSXEditor || Application.platform == RuntimePlatform.OSXPlayer);
		SettingsController.fpsCap = new GameSetting(sectionKey2, "framerate", Screen.currentResolution.refreshRate * 2, 10, 2010, 10);
		SettingsController.msaaLevel = new GameSetting(sectionKey2, "msaa", 2, 0, 8, 2);
		SettingsController.\u02C1\u02BF\u02B3\u02BF\u02C1\u02BC\u02BC\u02BA\u02BF\u02BD\u02BE = new GameSetting(sectionKey2, "particles", true);
		SettingsController.\u02C0\u02B6\u02BC\u02BF\u02BF\u02C0\u02BF\u02BC\u02B4\u02B3\u02BC = new GameSetting(sectionKey2, "flames", true);
		SettingsController.\u02BC\u02B6\u02BD\u02B5\u02B4\u02C0\u02B2\u02B8\u02B7\u02BC\u02B6 = new GameSetting(sectionKey2, "note_animation", 20, 1, 60, 1);
		SettingsController.\u02B4\u02B5\u02BE\u02B6\u02BC\u02B7\u02BB\u02B5\u02B7\u02BF\u02C0 = new GameSetting(sectionKey2, "star_animation", 20, 1, 60, 1);
		SettingsController.\u02B8\u02B3\u02B7\u02C0\u02B5\u02BA\u02BC\u02BA\u02BE\u02BA\u02B3 = new GameSetting(sectionKey2, "debug_fps", false);
		SettingsController.\u02BD\u02BF\u02B7\u02B9\u02B6\u02B8\u02BB\u02BA\u02B7\u02B8\u02B3 = new GameSetting(sectionKey2, "fullscreen", (Application.platform == RuntimePlatform.WindowsPlayer || Application.platform == RuntimePlatform.WindowsEditor) ? 2 : 1, 0, (Application.platform == RuntimePlatform.WindowsPlayer || Application.platform == RuntimePlatform.WindowsEditor) ? 2 : 1, 1);
		SettingsController.\u02C1\u02B3\u02BA\u02B9\u02B4\u02B3\u02BB\u02B6\u02BC\u02BC\u02BB = new GameSetting(sectionKey2, "highway_sp", true);
		SettingsController.\u02C1\u02B6\u02B5\u02C1\u02B7\u02BE\u02B5\u02B9\u02B9\u02BB\u02C1 = new GameSetting(sectionKey2, "highway_lightning", true);
		SettingsController.\u02C1\u02BF\u02BC\u02B4\u02BE\u02B7\u02BD\u02BC\u02B5\u02BC\u02B7 = new GameSetting(sectionKey2, "note_sp_colors", true);
		SettingsController.\u02B3\u02B9\u02C1\u02BF\u02B2\u02B2\u02B6\u02BF\u02B4\u02B4\u02B2 = new GameSetting(sectionKey2, "song_display", true);
		SettingsController.\u02BB\u02B5\u02BA\u02B6\u02BE\u02BA\u02B6\u02BD\u02B3\u02B9\u02BF = new GameSetting(sectionKey2, "graphicsapi", 0, 0, __FIXME_clon_util.\u02C0\u02B4\u02B9\u02C0\u02BE\u02B5\u02BA\u02B6\u02B8\u02B6\u02BD((ushort)__FIXME_clon_util.SupportedGraphicsAPIs()) - 1, 1);
		SettingsController.\u02BC\u02BA\u02BE\u02BB\u02B7\u02BE\u02BD\u02BE\u02BC\u02B2\u02B7 = new GameSetting(sectionKey3, "highway_placement", 0, -5, 5, 1);
		SettingsController.\u02BA\u02BF\u02BF\u02B7\u02B4\u02B6\u02BD\u02BC\u02BE\u02B5\u02BA = new GameSetting(sectionKey3, "song_export", false);
		SettingsController.\u02BF\u02BC\u02B2\u02B5\u02C0\u02B5\u02B4\u02C0\u02B3\u02B3\u02BF = new \u02B7\u02BF\u02C0\u02B9\u02B4\u02BB\u02B6\u02BB\u02BC\u02C1\u02C1(sectionKey3, "hud_position", new Vector3(0.08f, -1.38f, 0f));
		SettingsController.\u02BC\u02B4\u02B2\u02B2\u02B6\u02B3\u02BB\u02B8\u02B2\u02C1\u02B3 = new StringGameSetting(sectionKey3, "custom_song_export", "%s%n%a%n%c");
		SettingsController.\u02B7\u02B9\u02B4\u02C1\u02B9\u02BC\u02B8\u02BD\u02BE\u02B5\u02B8 = new GameSetting(sectionKey2, "menu_background", 1, 0, 14, 1);
		SettingsController.\u02BC\u02B3\u02B6\u02BB\u02BA\u02B8\u02B8\u02BE\u02BF\u02B2\u02B7 = new GameSetting[]
		{
			new GameSetting(sectionKey4, "guitar", 100, 0, 100, 5),
			new GameSetting(sectionKey4, "bass", 100, 0, 100, 5),
			new GameSetting(sectionKey4, "rhythm", 100, 0, 100, 5),
			new GameSetting(sectionKey4, "vocals", 100, 0, 100, 5),
			null,
			null,
			new GameSetting(sectionKey4, "drums", 100, 0, 100, 5),
			null,
			null,
			null,
			null,
			new GameSetting(sectionKey4, "keys", 100, 0, 100, 5),
			new GameSetting(sectionKey4, "song", 100, 0, 100, 5),
			new GameSetting(sectionKey4, "crowd", 100, 0, 100, 5)
		};
		SettingsController.\u02BC\u02B3\u02B6\u02BB\u02BA\u02B8\u02B8\u02BE\u02BF\u02B2\u02B7[4] = (SettingsController.\u02BC\u02B3\u02B6\u02BB\u02BA\u02B8\u02B8\u02BE\u02BF\u02B2\u02B7[5] = SettingsController.\u02BC\u02B3\u02B6\u02BB\u02BA\u02B8\u02B8\u02BE\u02BF\u02B2\u02B7[3]);
		SettingsController.\u02BC\u02B3\u02B6\u02BB\u02BA\u02B8\u02B8\u02BE\u02BF\u02B2\u02B7[7] = (SettingsController.\u02BC\u02B3\u02B6\u02BB\u02BA\u02B8\u02B8\u02BE\u02BF\u02B2\u02B7[8] = (SettingsController.\u02BC\u02B3\u02B6\u02BB\u02BA\u02B8\u02B8\u02BE\u02BF\u02B2\u02B7[9] = (SettingsController.\u02BC\u02B3\u02B6\u02BB\u02BA\u02B8\u02B8\u02BE\u02BF\u02B2\u02B7[10] = SettingsController.\u02BC\u02B3\u02B6\u02BB\u02BA\u02B8\u02B8\u02BE\u02BF\u02B2\u02B7[6])));
		SettingsController.\u02C1\u02C1\u02B3\u02BD\u02B7\u02C1\u02B9\u02BB\u02B5\u02B4\u02BB = new GameSetting(sectionKey4, "sounds", 50, 0, 100, 5);
		SettingsController.\u02C1\u02BD\u02C0\u02B7\u02B3\u02C0\u02B7\u02B2\u02BF\u02BC\u02B7 = new GameSetting(sectionKey4, "freestyle_drums", 100, 0, 100, 5);
		SettingsController.\u02B3\u02B2\u02B5\u02B8\u02B8\u02BD\u02BF\u02B6\u02B3\u02C1\u02BF = new GameSetting(sectionKey4, "menu_volume", 50, 0, 100, 5);
		SettingsController.\u02B8\u02B7\u02BF\u02B4\u02B3\u02BB\u02B6\u02BB\u02B7\u02B2\u02BD = new GameSetting(sectionKey4, "preview_volume", 50, 0, 100, 5);
		SettingsController.\u02B8\u02C1\u02B8\u02BC\u02B9\u02B2\u02BB\u02BB\u02B8\u02BD\u02B5 = new GameSetting(sectionKey4, "master_volume", 50, 0, 100, 5);
		SettingsController.\u02B9\u02B3\u02BD\u02B5\u02BB\u02C1\u02BE\u02B2\u02B3\u02B3\u02BB = new GameSetting(sectionKey4, "mute_volume", 50, 0, 100, 5);
		SettingsController.\u02B8\u02BD\u02BF\u02B7\u02BF\u02B7\u02BC\u02C1\u02B2\u02C0\u02BB = new GameSetting(sectionKey4, "device", -1, -1, 100, 0);
		SettingsController.\u02BE\u02BE\u02C0\u02BA\u02B8\u02B3\u02B4\u02C0\u02BD\u02B7\u02B8 = new GameSetting(sectionKey4, "backend", 0, 0, 1, 1);
		SettingsController.\u02BD\u02BA\u02B3\u02B7\u02C0\u02C1\u02BB\u02B4\u02B9\u02BB\u02B3 = new GameSetting(sectionKey4, "latency_mode", 1, 0, 2, 1);
		SettingsController.\u02BF\u02BD\u02B2\u02BE\u02BC\u02B5\u02B6\u02B5\u02B6\u02B9\u02BD = new GameSetting(sectionKey5, "whammy_sfx", true);
		SettingsController.\u02B3\u02B2\u02B9\u02C0\u02B3\u02BC\u02B4\u02BD\u02B3\u02C1\u02BC = new GameSetting(sectionKey6, "background_image", -2, -2, int.MaxValue, 1);
		SettingsController.\u02B7\u02B9\u02BF\u02BD\u02B9\u02B5\u02C0\u02BA\u02BC\u02BD\u02BE = new GameSetting(sectionKey6, "background_video", -2, -2, int.MaxValue, 1);
		SettingsController.\u02B7\u02BE\u02C1\u02BD\u02BD\u02C0\u02B4\u02BA\u02BC\u02B6\u02B9 = new GameSetting(sectionKey6, "song_backgrounds", false);
		SettingsController.\u02BE\u02B6\u02BA\u02C0\u02B9\u02B6\u02B2\u02BB\u02B3\u02B3\u02BA = new GameSetting(sectionKey6, "song_videos", false);
		SettingsController.\u02C1\u02BF\u02C0\u02BF\u02B8\u02B8\u02C0\u02C0\u02B3\u02B3\u02BB = new GameSetting(sectionKey6, "song_highway", false);
		SettingsController.\u02BC\u02BA\u02BE\u02B9\u02B5\u02BD\u02C1\u02B8\u02B7\u02C0\u02B8 = new GameSetting(sectionKey7, "poll_rate", 2000, 2000, 2000, 1);
		SettingsController.\u02B5\u02B7\u02B2\u02BB\u02BE\u02B8\u02BC\u02BA\u02B6\u02B5\u02C1 = new GameSetting(sectionKey7, "doublestrumprevention", 5, 0, 100, 1);
		SettingsController.\u02BB\u02C0\u02B7\u02B8\u02B3\u02BE\u02B7\u02BB\u02BA\u02B8\u02BA = new GameSetting(sectionKey7, "no_fail", true);
		SettingsController.\u02B3\u02BD\u02BB\u02B7\u02B5\u02B7\u02BD\u02B4\u02B4\u02BD\u02B3 = new GameSetting(sectionKey7, "pause_on_focus_lost", true);
		SettingsController.\u02BF\u02BF\u02BB\u02BF\u02B2\u02BE\u02B5\u02BD\u02C0\u02B4\u02B9 = new GameSetting(sectionKey7, "highway_shake", true);
		SettingsController.\u02B9\u02BD\u02B9\u02B4\u02B9\u02BB\u02B3\u02BA\u02BF\u02C0\u02B5 = new GameSetting(sectionKey7, "sort_filter", 0, 0, \u02BE\u02B2\u02BD\u02BB\u02BA\u02B6\u02BA\u02BA\u02B7\u02BF\u02BA.\u02B4\u02B2\u02BB\u02B2\u02BD\u02BA\u02C0\u02B2\u02B5\u02BC\u02B8.Length - 1, 1);
		SettingsController.\u02B3\u02B8\u02B6\u02C1\u02B2\u02B2\u02B5\u02C1\u02B6\u02B5\u02C0 = new GameSetting(sectionKey7, "gem_size", 100, -300, 300, 5);
		SettingsController.\u02BE\u02B7\u02B8\u02B7\u02B3\u02B5\u02BF\u02BD\u02B6\u02B2\u02B5 = new GameSetting(sectionKey7, "full_playlist", false);
		SettingsController.\u02BF\u02C0\u02B4\u02B3\u02BB\u02B8\u02BA\u02BE\u02B3\u02B5\u02B2 = new GameSetting(sectionKey7, "allow_duplicate_songs", false);
		SettingsController.\u02B6\u02BB\u02B2\u02B6\u02B7\u02BF\u02B6\u02B8\u02B8\u02B2\u02B2 = new GameSetting(sectionKey7, "drum_pad_scrolling", true);
		SettingsController.\u02B8\u02B6\u02B5\u02BB\u02C0\u02BA\u02B7\u02B4\u02B9\u02B8\u02BA = new GameSetting(sectionKey7, "mute_on_miss", true);
		SettingsController.\u02B7\u02BD\u02BC\u02BE\u02B3\u02B2\u02C0\u02BA\u02B7\u02C1\u02B2 = new GameSetting(sectionKey7, "show_hit_window", false);
		SettingsController.\u02B7\u02B2\u02C1\u02BA\u02BE\u02BC\u02B2\u02BB\u02BC\u02B2\u02B9 = new GameSetting(sectionKey7, "show_bot_score", true);
		SettingsController.\u02BD\u02B3\u02B7\u02B5\u02B5\u02BD\u02B5\u02B8\u02BD\u02C1\u02C1 = new GameSetting(sectionKey7, "enable_lyrics", true);
		SettingsController.\u02B2\u02C1\u02BD\u02C1\u02B4\u02B4\u02B2\u02BA\u02B6\u02B8\u02B4 = new GameSetting(sectionKey7, "enable_lyrics_bg", true);
		SettingsController.\u02BD\u02C1\u02B5\u02B3\u02BA\u02BC\u02B9\u02B8\u02B7\u02B8\u02C0 = new GameSetting(sectionKey7, "enable_cursor", true);
		SettingsController.\u02B7\u02B3\u02BF\u02BF\u02B4\u02B8\u02C0\u02BB\u02BB\u02BF\u02BE = new GameSetting(sectionKey7, "language", 0, 0, array.Length - 1, 1);
		SettingsController.\u02B3\u02B7\u02B4\u02BA\u02B3\u02B9\u02B7\u02BE\u02B2\u02B7\u02BE = new GameSetting(Settings.NoSection, "song_speed", 100, 10, 5000, 5);
		SettingsController.\u02B8\u02BB\u02B9\u02B5\u02B3\u02B7\u02B9\u02BE\u02BC\u02BA\u02B9 = new StringGameSetting(sectionKey7, "cache_file", "songcache.bin");
		SettingsController.\u02B7\u02B2\u02BA\u02B5\u02BC\u02C0\u02B8\u02C0\u02BC\u02BD\u02B9 = new GameSetting(sectionKey7, "practice_sp", true);
		SettingsController.\u02C0\u02BB\u02C1\u02BB\u02B8\u02BC\u02BB\u02C1\u02BA\u02C0\u02BF = new GameSetting(sectionKey7, "practice_delay", 2000, 500, 5000, 100);
		SettingsController.\u02B6\u02C0\u02BC\u02BE\u02B2\u02B6\u02B8\u02B9\u02B2\u02B9\u02B2 = new GameSetting(sectionKey7, "measure_countdown", true);
		SettingsController.\u02B8\u02B5\u02BB\u02BB\u02BF\u02BD\u02B9\u02B9\u02B7\u02B2\u02C0 = new GameSetting(sectionKey7, "auto_screenshot", false);
		SettingsController.\u02B5\u02B9\u02BB\u02BB\u02BA\u02B3\u02B9\u02B2\u02B5\u02BD\u02BB = new GameSetting(sectionKey7, "default_search_by_current_sort", false);
		SettingsController.\u02B3\u02B6\u02BB\u02BF\u02BD\u02BF\u02C0\u02B3\u02C1\u02BB\u02B8 = new GameSetting(sectionKey11, "sustaindropleniency", 5, 0, 100, 1);
		SettingsController.\u02B8\u02C1\u02B3\u02C0\u02B7\u02B6\u02BE\u02B4\u02B4\u02BF\u02B3 = new GameSetting(sectionKey8, "showremotenames", true);
		SettingsController.\u02BE\u02B2\u02B6\u02B7\u02B3\u02BB\u02B2\u02B8\u02BC\u02B7\u02BF = new GameSetting(sectionKey8, "highwayplacement", true);
		SettingsController.\u02BA\u02BE\u02B7\u02B7\u02BE\u02B4\u02BE\u02C1\u02B6\u02BD\u02B7 = new GameSetting(sectionKey8, "only_show_local_players", false);
		SettingsController.\u02BB\u02B7\u02BC\u02C1\u02B5\u02B5\u02B3\u02B4\u02BF\u02B9\u02BB = new GameSetting(sectionKey8, "force_remote_righty", false);
		SettingsController.\u02B2\u02BB\u02BF\u02BC\u02B9\u02BF\u02B2\u02BA\u02B4\u02BC\u02B4 = new StringArrayGameSetting(sectionKey9, "path", new string[1]);
		SettingsController.\u02B4\u02B3\u02B3\u02B7\u02C1\u02BE\u02BC\u02B9\u02B4\u02BC\u02BB = new StringArrayGameSetting(sectionKey10, "server", new string[1]);
		\u02BD\u02B5\u02B7\u02C0\u02BF\u02BA\u02B5\u02B9\u02BD\u02B6\u02C0.\u02C1\u02B9\u02B7\u02BA\u02BB\u02C1\u02B9\u02B8\u02BB\u02B8\u02B6.\u02B8\u02C0\u02B9\u02B9\u02B4\u02B7\u02BD\u02BE\u02B7\u02BC\u02B2(array[SettingsController.\u02B7\u02B3\u02BF\u02BF\u02B4\u02B8\u02C0\u02BB\u02BB\u02BF\u02BE.CurrentValue]);
	}

	// Token: 0x0400026B RID: 619
	public static bool \u02BB\u02B7\u02BA\u02BC\u02B2\u02B8\u02B9\u02BC\u02C0\u02B5\u02B6;

	// Token: 0x0400026C RID: 620
	public static GameSetting \u02B3\u02B8\u02B6\u02C1\u02B2\u02B2\u02B5\u02C1\u02B6\u02B5\u02C0;

	// Token: 0x0400026D RID: 621
	public static GameSetting \u02B3\u02B7\u02B4\u02BA\u02B3\u02B9\u02B7\u02BE\u02B2\u02B7\u02BE;

	// Token: 0x0400026E RID: 622
	public static GameSetting \u02B7\u02B2\u02BB\u02BA\u02BD\u02B3\u02BA\u02BA\u02BE\u02B9\u02B4;

	// Token: 0x0400026F RID: 623
	public static GameSetting \u02BE\u02C0\u02BA\u02B7\u02B9\u02C0\u02B6\u02BE\u02C1\u02B8\u02BB;

	// Token: 0x04000270 RID: 624
	public static GameSetting fpsCap;

	// Token: 0x04000271 RID: 625
	public static GameSetting \u02BC\u02BA\u02BE\u02BB\u02B7\u02BE\u02BD\u02BE\u02BC\u02B2\u02B7;

	// Token: 0x04000272 RID: 626
	public static GameSetting \u02B9\u02BD\u02B9\u02B4\u02B9\u02BB\u02B3\u02BA\u02BF\u02C0\u02B5;

	// Token: 0x04000273 RID: 627
	public static GameSetting \u02B8\u02BD\u02BF\u02B7\u02BF\u02B7\u02BC\u02C1\u02B2\u02C0\u02BB;

	// Token: 0x04000274 RID: 628
	public static GameSetting \u02BD\u02BA\u02B3\u02B7\u02C0\u02C1\u02BB\u02B4\u02B9\u02BB\u02B3;

	// Token: 0x04000275 RID: 629
	public static GameSetting \u02BE\u02BE\u02C0\u02BA\u02B8\u02B3\u02B4\u02C0\u02BD\u02B7\u02B8;

	// Token: 0x04000276 RID: 630
	public static GameSetting[] \u02BC\u02B3\u02B6\u02BB\u02BA\u02B8\u02B8\u02BE\u02BF\u02B2\u02B7;

	// Token: 0x04000277 RID: 631
	public static GameSetting \u02C1\u02C1\u02B3\u02BD\u02B7\u02C1\u02B9\u02BB\u02B5\u02B4\u02BB;

	// Token: 0x04000278 RID: 632
	public static GameSetting \u02C1\u02BD\u02C0\u02B7\u02B3\u02C0\u02B7\u02B2\u02BF\u02BC\u02B7;

	// Token: 0x04000279 RID: 633
	public static GameSetting \u02B3\u02B2\u02B5\u02B8\u02B8\u02BD\u02BF\u02B6\u02B3\u02C1\u02BF;

	// Token: 0x0400027A RID: 634
	public static GameSetting \u02B8\u02B7\u02BF\u02B4\u02B3\u02BB\u02B6\u02BB\u02B7\u02B2\u02BD;

	// Token: 0x0400027B RID: 635
	public static GameSetting \u02B8\u02C1\u02B8\u02BC\u02B9\u02B2\u02BB\u02BB\u02B8\u02BD\u02B5;

	// Token: 0x0400027C RID: 636
	public static GameSetting \u02B9\u02B3\u02BD\u02B5\u02BB\u02C1\u02BE\u02B2\u02B3\u02B3\u02BB;

	// Token: 0x0400027D RID: 637
	public static GameSetting \u02BF\u02BD\u02B2\u02BE\u02BC\u02B5\u02B6\u02B5\u02B6\u02B9\u02BD;

	// Token: 0x0400027E RID: 638
	public static GameSetting \u02BC\u02BA\u02BE\u02B9\u02B5\u02BD\u02C1\u02B8\u02B7\u02C0\u02B8;

	// Token: 0x0400027F RID: 639
	public static GameSetting \u02B3\u02B2\u02B9\u02C0\u02B3\u02BC\u02B4\u02BD\u02B3\u02C1\u02BC;

	// Token: 0x04000280 RID: 640
	public static GameSetting \u02B7\u02BE\u02C1\u02BD\u02BD\u02C0\u02B4\u02BA\u02BC\u02B6\u02B9;

	// Token: 0x04000281 RID: 641
	public static GameSetting \u02B7\u02B9\u02BF\u02BD\u02B9\u02B5\u02C0\u02BA\u02BC\u02BD\u02BE;

	// Token: 0x04000282 RID: 642
	public static GameSetting \u02BA\u02BF\u02BF\u02B7\u02B4\u02B6\u02BD\u02BC\u02BE\u02B5\u02BA;

	// Token: 0x04000283 RID: 643
	public static GameSetting \u02BB\u02C0\u02B7\u02B8\u02B3\u02BE\u02B7\u02BB\u02BA\u02B8\u02BA;

	// Token: 0x04000284 RID: 644
	public static GameSetting \u02C1\u02BF\u02B3\u02BF\u02C1\u02BC\u02BC\u02BA\u02BF\u02BD\u02BE;

	// Token: 0x04000285 RID: 645
	public static GameSetting \u02C0\u02B6\u02BC\u02BF\u02BF\u02C0\u02BF\u02BC\u02B4\u02B3\u02BC;

	// Token: 0x04000286 RID: 646
	public static GameSetting \u02B3\u02B2\u02BD\u02C1\u02B2\u02B4\u02B5\u02B3\u02C1\u02B2\u02B6;

	// Token: 0x04000287 RID: 647
	public static GameSetting msaaLevel;

	// Token: 0x04000288 RID: 648
	public static GameSetting \u02BB\u02B5\u02BA\u02B6\u02BE\u02BA\u02B6\u02BD\u02B3\u02B9\u02BF;

	// Token: 0x04000289 RID: 649
	public static GameSetting \u02B7\u02B2\u02BA\u02B5\u02BC\u02C0\u02B8\u02C0\u02BC\u02BD\u02B9;

	// Token: 0x0400028A RID: 650
	public static GameSetting \u02B6\u02C0\u02BC\u02BE\u02B2\u02B6\u02B8\u02B9\u02B2\u02B9\u02B2;

	// Token: 0x0400028B RID: 651
	public static GameSetting \u02B8\u02B5\u02BB\u02BB\u02BF\u02BD\u02B9\u02B9\u02B7\u02B2\u02C0;

	// Token: 0x0400028C RID: 652
	public static GameSetting \u02B5\u02B9\u02BB\u02BB\u02BA\u02B3\u02B9\u02B2\u02B5\u02BD\u02BB;

	// Token: 0x0400028D RID: 653
	public static GameSetting \u02B6\u02BB\u02B2\u02B6\u02B7\u02BF\u02B6\u02B8\u02B8\u02B2\u02B2;

	// Token: 0x0400028E RID: 654
	public static GameSetting \u02BE\u02B7\u02B8\u02B7\u02B3\u02B5\u02BF\u02BD\u02B6\u02B2\u02B5;

	// Token: 0x0400028F RID: 655
	public static GameSetting \u02B3\u02BD\u02BB\u02B7\u02B5\u02B7\u02BD\u02B4\u02B4\u02BD\u02B3;

	// Token: 0x04000290 RID: 656
	public static GameSetting \u02BF\u02BF\u02BB\u02BF\u02B2\u02BE\u02B5\u02BD\u02C0\u02B4\u02B9;

	// Token: 0x04000291 RID: 657
	public static GameSetting \u02B8\u02B6\u02B5\u02BB\u02C0\u02BA\u02B7\u02B4\u02B9\u02B8\u02BA;

	// Token: 0x04000292 RID: 658
	public static GameSetting \u02BD\u02BF\u02B7\u02B9\u02B6\u02B8\u02BB\u02BA\u02B7\u02B8\u02B3;

	// Token: 0x04000293 RID: 659
	public static GameSetting \u02B8\u02B3\u02B7\u02C0\u02B5\u02BA\u02BC\u02BA\u02BE\u02BA\u02B3;

	// Token: 0x04000294 RID: 660
	public static GameSetting \u02B7\u02BD\u02BC\u02BE\u02B3\u02B2\u02C0\u02BA\u02B7\u02C1\u02B2;

	// Token: 0x04000295 RID: 661
	public static GameSetting \u02C1\u02B3\u02BA\u02B9\u02B4\u02B3\u02BB\u02B6\u02BC\u02BC\u02BB;

	// Token: 0x04000296 RID: 662
	public static GameSetting \u02C1\u02B6\u02B5\u02C1\u02B7\u02BE\u02B5\u02B9\u02B9\u02BB\u02C1;

	// Token: 0x04000297 RID: 663
	public static GameSetting \u02C1\u02BF\u02BC\u02B4\u02BE\u02B7\u02BD\u02BC\u02B5\u02BC\u02B7;

	// Token: 0x04000298 RID: 664
	public static GameSetting \u02BE\u02B6\u02BA\u02C0\u02B9\u02B6\u02B2\u02BB\u02B3\u02B3\u02BA;

	// Token: 0x04000299 RID: 665
	public static GameSetting \u02B3\u02B9\u02C1\u02BF\u02B2\u02B2\u02B6\u02BF\u02B4\u02B4\u02B2;

	// Token: 0x0400029A RID: 666
	public static GameSetting \u02C1\u02BF\u02C0\u02BF\u02B8\u02B8\u02C0\u02C0\u02B3\u02B3\u02BB;

	// Token: 0x0400029B RID: 667
	public static GameSetting \u02B7\u02B9\u02B4\u02C1\u02B9\u02BC\u02B8\u02BD\u02BE\u02B5\u02B8;

	// Token: 0x0400029C RID: 668
	public static GameSetting \u02BC\u02B6\u02BD\u02B5\u02B4\u02C0\u02B2\u02B8\u02B7\u02BC\u02B6;

	// Token: 0x0400029D RID: 669
	public static GameSetting \u02B4\u02B5\u02BE\u02B6\u02BC\u02B7\u02BB\u02B5\u02B7\u02BF\u02C0;

	// Token: 0x0400029E RID: 670
	public static GameSetting \u02B7\u02B2\u02C1\u02BA\u02BE\u02BC\u02B2\u02BB\u02BC\u02B2\u02B9;

	// Token: 0x0400029F RID: 671
	public static GameSetting \u02B7\u02B3\u02BF\u02BF\u02B4\u02B8\u02C0\u02BB\u02BB\u02BF\u02BE;

	// Token: 0x040002A0 RID: 672
	public static GameSetting \u02BF\u02C0\u02B4\u02B3\u02BB\u02B8\u02BA\u02BE\u02B3\u02B5\u02B2;

	// Token: 0x040002A1 RID: 673
	public static GameSetting \u02BD\u02C1\u02B5\u02B3\u02BA\u02BC\u02B9\u02B8\u02B7\u02B8\u02C0;

	// Token: 0x040002A2 RID: 674
	public static GameSetting \u02BD\u02B3\u02B7\u02B5\u02B5\u02BD\u02B5\u02B8\u02BD\u02C1\u02C1;

	// Token: 0x040002A3 RID: 675
	public static GameSetting \u02B2\u02C1\u02BD\u02C1\u02B4\u02B4\u02B2\u02BA\u02B6\u02B8\u02B4;

	// Token: 0x040002A4 RID: 676
	public static GameSetting \u02C0\u02BB\u02C1\u02BB\u02B8\u02BC\u02BB\u02C1\u02BA\u02C0\u02BF;

	// Token: 0x040002A5 RID: 677
	public static GameSetting \u02B5\u02B7\u02B2\u02BB\u02BE\u02B8\u02BC\u02BA\u02B6\u02B5\u02C1;

	// Token: 0x040002A6 RID: 678
	public static GameSetting \u02B3\u02B6\u02BB\u02BF\u02BD\u02BF\u02C0\u02B3\u02C1\u02BB\u02B8;

	// Token: 0x040002A7 RID: 679
	public static StringArrayGameSetting \u02B2\u02BB\u02BF\u02BC\u02B9\u02BF\u02B2\u02BA\u02B4\u02BC\u02B4;

	// Token: 0x040002A8 RID: 680
	public static StringArrayGameSetting \u02B4\u02B3\u02B3\u02B7\u02C1\u02BE\u02BC\u02B9\u02B4\u02BC\u02BB;

	// Token: 0x040002A9 RID: 681
	public static \u02B7\u02BF\u02C0\u02B9\u02B4\u02BB\u02B6\u02BB\u02BC\u02C1\u02C1 \u02BF\u02BC\u02B2\u02B5\u02C0\u02B5\u02B4\u02C0\u02B3\u02B3\u02BF;

	// Token: 0x040002AA RID: 682
	public static StringGameSetting \u02BC\u02B4\u02B2\u02B2\u02B6\u02B3\u02BB\u02B8\u02B2\u02C1\u02B3;

	// Token: 0x040002AB RID: 683
	public static StringGameSetting \u02B8\u02BB\u02B9\u02B5\u02B3\u02B7\u02B9\u02BE\u02BC\u02BA\u02B9;

	// Token: 0x040002AC RID: 684
	public static GameSetting \u02B8\u02C1\u02B3\u02C0\u02B7\u02B6\u02BE\u02B4\u02B4\u02BF\u02B3;

	// Token: 0x040002AD RID: 685
	public static GameSetting \u02BE\u02B2\u02B6\u02B7\u02B3\u02BB\u02B2\u02B8\u02BC\u02B7\u02BF;

	// Token: 0x040002AE RID: 686
	public static GameSetting \u02BA\u02BE\u02B7\u02B7\u02BE\u02B4\u02BE\u02C1\u02B6\u02BD\u02B7;

	// Token: 0x040002AF RID: 687
	public static GameSetting \u02BB\u02B7\u02BC\u02C1\u02B5\u02B5\u02B3\u02B4\u02BF\u02B9\u02BB;
}
