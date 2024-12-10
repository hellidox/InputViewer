using System;
using System.IO;
using System.Linq;
using StrikeCore;
using UnityEngine;

public static class SettingsController
{
	public static string \u02BE\u02BF\u02BE\u02BB\u02B3\u02B8\u02B9\u02BD\u02B9\u02B4\u02BC()
	{
		return Path.Combine(Helper.GetDocumentsClonFolder(), "settings.ini");
	}

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
		SettingsController.\u02BB\u02B5\u02BA\u02B6\u02BE\u02BA\u02B6\u02BD\u02B3\u02B9\u02BF = new GameSetting(sectionKey2, "graphicsapi", 0, 0, Helper.\u02C0\u02B4\u02B9\u02C0\u02BE\u02B5\u02BA\u02B6\u02B8\u02B6\u02BD((ushort)Helper.SupportedGraphicsAPIs()) - 1, 1);
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

	public static bool \u02BB\u02B7\u02BA\u02BC\u02B2\u02B8\u02B9\u02BC\u02C0\u02B5\u02B6;

	public static GameSetting \u02B3\u02B8\u02B6\u02C1\u02B2\u02B2\u02B5\u02C1\u02B6\u02B5\u02C0;

	public static GameSetting \u02B3\u02B7\u02B4\u02BA\u02B3\u02B9\u02B7\u02BE\u02B2\u02B7\u02BE;

	public static GameSetting \u02B7\u02B2\u02BB\u02BA\u02BD\u02B3\u02BA\u02BA\u02BE\u02B9\u02B4;

	public static GameSetting \u02BE\u02C0\u02BA\u02B7\u02B9\u02C0\u02B6\u02BE\u02C1\u02B8\u02BB;

	public static GameSetting fpsCap;

	public static GameSetting \u02BC\u02BA\u02BE\u02BB\u02B7\u02BE\u02BD\u02BE\u02BC\u02B2\u02B7;

	public static GameSetting \u02B9\u02BD\u02B9\u02B4\u02B9\u02BB\u02B3\u02BA\u02BF\u02C0\u02B5;

	public static GameSetting \u02B8\u02BD\u02BF\u02B7\u02BF\u02B7\u02BC\u02C1\u02B2\u02C0\u02BB;

	public static GameSetting \u02BD\u02BA\u02B3\u02B7\u02C0\u02C1\u02BB\u02B4\u02B9\u02BB\u02B3;

	public static GameSetting \u02BE\u02BE\u02C0\u02BA\u02B8\u02B3\u02B4\u02C0\u02BD\u02B7\u02B8;

	public static GameSetting[] \u02BC\u02B3\u02B6\u02BB\u02BA\u02B8\u02B8\u02BE\u02BF\u02B2\u02B7;

	public static GameSetting \u02C1\u02C1\u02B3\u02BD\u02B7\u02C1\u02B9\u02BB\u02B5\u02B4\u02BB;

	public static GameSetting \u02C1\u02BD\u02C0\u02B7\u02B3\u02C0\u02B7\u02B2\u02BF\u02BC\u02B7;

	public static GameSetting \u02B3\u02B2\u02B5\u02B8\u02B8\u02BD\u02BF\u02B6\u02B3\u02C1\u02BF;

	public static GameSetting \u02B8\u02B7\u02BF\u02B4\u02B3\u02BB\u02B6\u02BB\u02B7\u02B2\u02BD;

	public static GameSetting \u02B8\u02C1\u02B8\u02BC\u02B9\u02B2\u02BB\u02BB\u02B8\u02BD\u02B5;

	public static GameSetting \u02B9\u02B3\u02BD\u02B5\u02BB\u02C1\u02BE\u02B2\u02B3\u02B3\u02BB;

	public static GameSetting \u02BF\u02BD\u02B2\u02BE\u02BC\u02B5\u02B6\u02B5\u02B6\u02B9\u02BD;

	public static GameSetting \u02BC\u02BA\u02BE\u02B9\u02B5\u02BD\u02C1\u02B8\u02B7\u02C0\u02B8;

	public static GameSetting \u02B3\u02B2\u02B9\u02C0\u02B3\u02BC\u02B4\u02BD\u02B3\u02C1\u02BC;

	public static GameSetting \u02B7\u02BE\u02C1\u02BD\u02BD\u02C0\u02B4\u02BA\u02BC\u02B6\u02B9;

	public static GameSetting \u02B7\u02B9\u02BF\u02BD\u02B9\u02B5\u02C0\u02BA\u02BC\u02BD\u02BE;

	public static GameSetting \u02BA\u02BF\u02BF\u02B7\u02B4\u02B6\u02BD\u02BC\u02BE\u02B5\u02BA;

	public static GameSetting \u02BB\u02C0\u02B7\u02B8\u02B3\u02BE\u02B7\u02BB\u02BA\u02B8\u02BA;

	public static GameSetting \u02C1\u02BF\u02B3\u02BF\u02C1\u02BC\u02BC\u02BA\u02BF\u02BD\u02BE;

	public static GameSetting \u02C0\u02B6\u02BC\u02BF\u02BF\u02C0\u02BF\u02BC\u02B4\u02B3\u02BC;

	public static GameSetting \u02B3\u02B2\u02BD\u02C1\u02B2\u02B4\u02B5\u02B3\u02C1\u02B2\u02B6;

	public static GameSetting msaaLevel;

	public static GameSetting \u02BB\u02B5\u02BA\u02B6\u02BE\u02BA\u02B6\u02BD\u02B3\u02B9\u02BF;

	public static GameSetting \u02B7\u02B2\u02BA\u02B5\u02BC\u02C0\u02B8\u02C0\u02BC\u02BD\u02B9;

	public static GameSetting \u02B6\u02C0\u02BC\u02BE\u02B2\u02B6\u02B8\u02B9\u02B2\u02B9\u02B2;

	public static GameSetting \u02B8\u02B5\u02BB\u02BB\u02BF\u02BD\u02B9\u02B9\u02B7\u02B2\u02C0;

	public static GameSetting \u02B5\u02B9\u02BB\u02BB\u02BA\u02B3\u02B9\u02B2\u02B5\u02BD\u02BB;

	public static GameSetting \u02B6\u02BB\u02B2\u02B6\u02B7\u02BF\u02B6\u02B8\u02B8\u02B2\u02B2;

	public static GameSetting \u02BE\u02B7\u02B8\u02B7\u02B3\u02B5\u02BF\u02BD\u02B6\u02B2\u02B5;

	public static GameSetting \u02B3\u02BD\u02BB\u02B7\u02B5\u02B7\u02BD\u02B4\u02B4\u02BD\u02B3;

	public static GameSetting \u02BF\u02BF\u02BB\u02BF\u02B2\u02BE\u02B5\u02BD\u02C0\u02B4\u02B9;

	public static GameSetting \u02B8\u02B6\u02B5\u02BB\u02C0\u02BA\u02B7\u02B4\u02B9\u02B8\u02BA;

	public static GameSetting \u02BD\u02BF\u02B7\u02B9\u02B6\u02B8\u02BB\u02BA\u02B7\u02B8\u02B3;

	public static GameSetting \u02B8\u02B3\u02B7\u02C0\u02B5\u02BA\u02BC\u02BA\u02BE\u02BA\u02B3;

	public static GameSetting \u02B7\u02BD\u02BC\u02BE\u02B3\u02B2\u02C0\u02BA\u02B7\u02C1\u02B2;

	public static GameSetting \u02C1\u02B3\u02BA\u02B9\u02B4\u02B3\u02BB\u02B6\u02BC\u02BC\u02BB;

	public static GameSetting \u02C1\u02B6\u02B5\u02C1\u02B7\u02BE\u02B5\u02B9\u02B9\u02BB\u02C1;

	public static GameSetting \u02C1\u02BF\u02BC\u02B4\u02BE\u02B7\u02BD\u02BC\u02B5\u02BC\u02B7;

	public static GameSetting \u02BE\u02B6\u02BA\u02C0\u02B9\u02B6\u02B2\u02BB\u02B3\u02B3\u02BA;

	public static GameSetting \u02B3\u02B9\u02C1\u02BF\u02B2\u02B2\u02B6\u02BF\u02B4\u02B4\u02B2;

	public static GameSetting \u02C1\u02BF\u02C0\u02BF\u02B8\u02B8\u02C0\u02C0\u02B3\u02B3\u02BB;

	public static GameSetting \u02B7\u02B9\u02B4\u02C1\u02B9\u02BC\u02B8\u02BD\u02BE\u02B5\u02B8;

	public static GameSetting \u02BC\u02B6\u02BD\u02B5\u02B4\u02C0\u02B2\u02B8\u02B7\u02BC\u02B6;

	public static GameSetting \u02B4\u02B5\u02BE\u02B6\u02BC\u02B7\u02BB\u02B5\u02B7\u02BF\u02C0;

	public static GameSetting \u02B7\u02B2\u02C1\u02BA\u02BE\u02BC\u02B2\u02BB\u02BC\u02B2\u02B9;

	public static GameSetting \u02B7\u02B3\u02BF\u02BF\u02B4\u02B8\u02C0\u02BB\u02BB\u02BF\u02BE;

	public static GameSetting \u02BF\u02C0\u02B4\u02B3\u02BB\u02B8\u02BA\u02BE\u02B3\u02B5\u02B2;

	public static GameSetting \u02BD\u02C1\u02B5\u02B3\u02BA\u02BC\u02B9\u02B8\u02B7\u02B8\u02C0;

	public static GameSetting \u02BD\u02B3\u02B7\u02B5\u02B5\u02BD\u02B5\u02B8\u02BD\u02C1\u02C1;

	public static GameSetting \u02B2\u02C1\u02BD\u02C1\u02B4\u02B4\u02B2\u02BA\u02B6\u02B8\u02B4;

	public static GameSetting \u02C0\u02BB\u02C1\u02BB\u02B8\u02BC\u02BB\u02C1\u02BA\u02C0\u02BF;

	public static GameSetting \u02B5\u02B7\u02B2\u02BB\u02BE\u02B8\u02BC\u02BA\u02B6\u02B5\u02C1;

	public static GameSetting \u02B3\u02B6\u02BB\u02BF\u02BD\u02BF\u02C0\u02B3\u02C1\u02BB\u02B8;

	public static StringArrayGameSetting \u02B2\u02BB\u02BF\u02BC\u02B9\u02BF\u02B2\u02BA\u02B4\u02BC\u02B4;

	public static StringArrayGameSetting \u02B4\u02B3\u02B3\u02B7\u02C1\u02BE\u02BC\u02B9\u02B4\u02BC\u02BB;

	public static \u02B7\u02BF\u02C0\u02B9\u02B4\u02BB\u02B6\u02BB\u02BC\u02C1\u02C1 \u02BF\u02BC\u02B2\u02B5\u02C0\u02B5\u02B4\u02C0\u02B3\u02B3\u02BF;

	public static StringGameSetting \u02BC\u02B4\u02B2\u02B2\u02B6\u02B3\u02BB\u02B8\u02B2\u02C1\u02B3;

	public static StringGameSetting \u02B8\u02BB\u02B9\u02B5\u02B3\u02B7\u02B9\u02BE\u02BC\u02BA\u02B9;

	public static GameSetting \u02B8\u02C1\u02B3\u02C0\u02B7\u02B6\u02BE\u02B4\u02B4\u02BF\u02B3;

	public static GameSetting \u02BE\u02B2\u02B6\u02B7\u02B3\u02BB\u02B2\u02B8\u02BC\u02B7\u02BF;

	public static GameSetting \u02BA\u02BE\u02B7\u02B7\u02BE\u02B4\u02BE\u02C1\u02B6\u02BD\u02B7;

	public static GameSetting \u02BB\u02B7\u02BC\u02C1\u02B5\u02B5\u02B3\u02B4\u02BF\u02B9\u02BB;
}
