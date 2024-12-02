using System;
using UnityEngine;

public class DrumEndOfSongOptionsMenu : BaseMenu
{
	protected override void Start()
	{
		if (GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BC\u02B6\u02BA\u02BF\u02B2\u02C1\u02B3\u02B5\u02B2\u02B5\u02B6)
		{
			this.menuStrings = this.setlistStrings;
		}
		else if (this.endOfSong.\u02B7\u02B4\u02B9\u02BD\u02C0\u02BA\u02B5\u02BF\u02BA\u02B3\u02B8)
		{
			this.menuStrings = this.practiceStrings;
		}
		else
		{
			this.menuStrings = this.quickplayStrings;
		}
		base.Start();
	}

	public virtual void \u02B3\u02B5\u02B3\u02BA\u02C1\u02BC\u02B4\u02BA\u02B8\u02BB\u02BD()
	{
		string text = base.\u02B2\u02BF\u02BF\u02BE\u02BD\u02B8\u02BE\u02C0\u02B3\u02B3\u02C0;
		if (text == "GameColors_")
		{
			this.endOfSong.\u02C0\u02B2\u02C0\u02BD\u02BF\u02BD\u02B2\u02BD\u02BE\u02C1\u02B6();
			return;
		}
		if (text == "%")
		{
			this.endOfSong.\u02BD\u02B7\u02BE\u02B5\u02B8\u02BC\u02BE\u02BA\u02BD\u02B8\u02BB();
			return;
		}
		if (text == "Drunk Mode")
		{
			this.endOfSong.\u02BE\u02B8\u02B5\u02B8\u02BC\u02BD\u02B6\u02BA\u02B8\u02BB\u02B8();
			return;
		}
		if (!(text == "midi_export"))
		{
			return;
		}
		this.endOfSong.\u02C0\u02BB\u02B9\u02B3\u02B5\u02B3\u02BD\u02B7\u02B5\u02C1\u02C1();
	}

	public virtual void \u02B3\u02C1\u02B8\u02BA\u02B2\u02B8\u02B5\u02B6\u02B2\u02B5\u02BA()
	{
		string text = base.\u02BC\u02B4\u02C0\u02BC\u02BE\u02BD\u02B8\u02B9\u02BF\u02BA\u02B7();
		if (text == "ENHANCED_OPENS")
		{
			this.endOfSong.\u02C0\u02B2\u02C0\u02BD\u02BF\u02BD\u02B2\u02BD\u02BE\u02C1\u02B6();
			return;
		}
		if (text == "Precision Mode")
		{
			this.endOfSong.\u02B7\u02B2\u02BA\u02B8\u02B9\u02BF\u02B2\u02C0\u02BE\u02B3\u02B3();
			return;
		}
		if (text == "Surfer")
		{
			this.endOfSong.\u02BE\u02B5\u02BE\u02B9\u02B6\u02C0\u02BF\u02BB\u02C0\u02B3\u02BD();
			return;
		}
		if (!(text == "Kick / Open Notes"))
		{
			return;
		}
		this.endOfSong.\u02C0\u02BB\u02B9\u02B3\u02B5\u02B3\u02BD\u02B7\u02B5\u02C1\u02C1();
	}

	protected virtual void \u02BE\u02B8\u02B4\u02BC\u02B7\u02B7\u02BE\u02BC\u02B5\u02BC\u02BF()
	{
		if (GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BC\u02B6\u02BA\u02BF\u02B2\u02C1\u02B3\u02B5\u02B2\u02B5\u02B6)
		{
			this.menuStrings = this.setlistStrings;
		}
		else if (this.endOfSong.\u02B8\u02BA\u02BF\u02B6\u02B7\u02BF\u02BA\u02B4\u02B7\u02B9\u02B3())
		{
			this.menuStrings = this.practiceStrings;
		}
		else
		{
			this.menuStrings = this.quickplayStrings;
		}
		base.Start();
	}

	public void \u02BF\u02B9\u02B2\u02B3\u02B9\u02BA\u02BB\u02B2\u02BE\u02B9\u02BD()
	{
		this.\u02B5\u02B6\u02B8\u02BC\u02BF\u02BF\u02BC\u02B5\u02C0\u02BB\u02C0(0, false);
		base.gameObject.SetActive(false);
	}

	protected virtual void \u02B7\u02B8\u02BD\u02C0\u02B2\u02B4\u02B7\u02C0\u02BC\u02BE\u02B3()
	{
		if (GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BC\u02B6\u02BA\u02BF\u02B2\u02C1\u02B3\u02B5\u02B2\u02B5\u02B6)
		{
			this.menuStrings = this.setlistStrings;
		}
		else if (this.endOfSong.\u02B7\u02B4\u02B9\u02BD\u02C0\u02BA\u02B5\u02BF\u02BA\u02B3\u02B8)
		{
			this.menuStrings = this.practiceStrings;
		}
		else
		{
			this.menuStrings = this.quickplayStrings;
		}
		base.Start();
	}

	public override void \u02B5\u02C1\u02BA\u02BB\u02B2\u02B9\u02C1\u02BB\u02B9\u02BA\u02B3()
	{
		string text = base.\u02B2\u02BF\u02BF\u02BE\u02BD\u02B8\u02BE\u02C0\u02B3\u02B3\u02C0;
		if (text == "Replay")
		{
			this.endOfSong.\u02C0\u02B2\u02C0\u02BD\u02BF\u02BD\u02B2\u02BD\u02BE\u02C1\u02B6();
			return;
		}
		if (text == "Practice")
		{
			this.endOfSong.\u02B7\u02B2\u02BA\u02B8\u02B9\u02BF\u02B2\u02C0\u02BE\u02B3\u02B3();
			return;
		}
		if (text == "Random Song")
		{
			this.endOfSong.\u02B6\u02B9\u02B4\u02B2\u02B4\u02BB\u02BF\u02B7\u02BC\u02BD\u02C1();
			return;
		}
		if (!(text == "Save Screenshot"))
		{
			return;
		}
		this.endOfSong.\u02C0\u02BB\u02B9\u02B3\u02B5\u02B3\u02BD\u02B7\u02B5\u02C1\u02C1();
	}

	public virtual void \u02B2\u02BA\u02B2\u02BC\u02B6\u02B4\u02BB\u02B6\u02B8\u02BE\u02B3()
	{
		string text = base.\u02BC\u02B4\u02C0\u02BC\u02BE\u02BD\u02B8\u02B9\u02BF\u02BA\u02B7();
		if (text == "Bad Argument")
		{
			this.endOfSong.\u02C0\u02B2\u02C0\u02BD\u02BF\u02BD\u02B2\u02BD\u02BE\u02C1\u02B6();
			return;
		}
		if (text == "Accents Hit")
		{
			this.endOfSong.\u02BD\u02BC\u02BF\u02C1\u02BF\u02B6\u02C1\u02C0\u02C1\u02BE\u02C1();
			return;
		}
		if (text == "Background Video")
		{
			this.endOfSong.\u02B6\u02B9\u02B4\u02B2\u02B4\u02BB\u02BF\u02B7\u02BC\u02BD\u02C1();
			return;
		}
		if (!(text == "measure_countdown"))
		{
			return;
		}
		this.endOfSong.\u02C0\u02BB\u02B9\u02B3\u02B5\u02B3\u02BD\u02B7\u02B5\u02C1\u02C1();
	}

	public void \u02C0\u02B7\u02B3\u02B8\u02B2\u02B9\u02B2\u02BC\u02BE\u02B8\u02BD()
	{
		this.\u02B5\u02B6\u02B8\u02BC\u02BF\u02BF\u02BC\u02B5\u02C0\u02BB\u02C0(0, true);
		base.gameObject.SetActive(true);
	}

	protected virtual void \u02B2\u02BB\u02B6\u02B5\u02B9\u02B8\u02B2\u02B3\u02BF\u02C1\u02BF()
	{
		if (GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BC\u02B6\u02BA\u02BF\u02B2\u02C1\u02B3\u02B5\u02B2\u02B5\u02B6)
		{
			this.menuStrings = this.setlistStrings;
		}
		else if (this.endOfSong.\u02B8\u02BA\u02BF\u02B6\u02B7\u02BF\u02BA\u02B4\u02B7\u02B9\u02B3())
		{
			this.menuStrings = this.practiceStrings;
		}
		else
		{
			this.menuStrings = this.quickplayStrings;
		}
		base.Start();
	}

	protected virtual void \u02BF\u02BA\u02B5\u02B8\u02B5\u02BF\u02B2\u02BF\u02B3\u02BC\u02BA()
	{
		if (GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BC\u02B6\u02BA\u02BF\u02B2\u02C1\u02B3\u02B5\u02B2\u02B5\u02B6)
		{
			this.menuStrings = this.setlistStrings;
		}
		else if (this.endOfSong.\u02B7\u02B4\u02B9\u02BD\u02C0\u02BA\u02B5\u02BF\u02BA\u02B3\u02B8)
		{
			this.menuStrings = this.practiceStrings;
		}
		else
		{
			this.menuStrings = this.quickplayStrings;
		}
		base.Start();
	}

	public virtual void \u02C0\u02BF\u02BD\u02BA\u02B8\u02BB\u02B7\u02B5\u02BA\u02BB\u02BD()
	{
		string text = base.\u02BC\u02B4\u02C0\u02BC\u02BE\u02BD\u02B8\u02B9\u02BF\u02BA\u02B7();
		if (text == " (")
		{
			this.endOfSong.\u02C0\u02B2\u02C0\u02BD\u02BF\u02BD\u02B2\u02BD\u02BE\u02C1\u02B6();
			return;
		}
		if (text == "Show Bot Score")
		{
			this.endOfSong.\u02BD\u02BC\u02BF\u02C1\u02BF\u02B6\u02C1\u02C0\u02C1\u02BE\u02C1();
			return;
		}
		if (text == "")
		{
			this.endOfSong.\u02B6\u02B9\u02B4\u02B2\u02B4\u02BB\u02BF\u02B7\u02BC\u02BD\u02C1();
			return;
		}
		if (!(text == "Intensity - Lead Guitar"))
		{
			return;
		}
		this.endOfSong.\u02C0\u02BB\u02B9\u02B3\u02B5\u02B3\u02BD\u02B7\u02B5\u02C1\u02C1();
	}

	public virtual void \u02B6\u02B6\u02B6\u02BC\u02B7\u02B9\u02B7\u02BC\u02B4\u02B6\u02B3()
	{
		string text = base.\u02B2\u02BF\u02BF\u02BE\u02BD\u02B8\u02BE\u02C0\u02B3\u02B3\u02C0;
		if (text == "{0} {1} {2}")
		{
			this.endOfSong.\u02C0\u02B2\u02C0\u02BD\u02BF\u02BD\u02B2\u02BD\u02BE\u02C1\u02B6();
			return;
		}
		if (text == "hh\\:mm\\:ss")
		{
			this.endOfSong.\u02BD\u02B7\u02BE\u02B5\u02B8\u02BC\u02BE\u02BA\u02BD\u02B8\u02BB();
			return;
		}
		if (text == "GameColors_")
		{
			this.endOfSong.\u02B6\u02B9\u02B4\u02B2\u02B4\u02BB\u02BF\u02B7\u02BC\u02BD\u02C1();
			return;
		}
		if (!(text == "Languages/"))
		{
			return;
		}
		this.endOfSong.\u02C0\u02BB\u02B9\u02B3\u02B5\u02B3\u02BD\u02B7\u02B5\u02C1\u02C1();
	}

	public virtual void \u02BA\u02B7\u02B3\u02B3\u02B7\u02BD\u02BD\u02BA\u02C0\u02BE\u02BE()
	{
		string text = base.\u02BC\u02B4\u02C0\u02BC\u02BE\u02BD\u02B8\u02B9\u02BF\u02BA\u02B7();
		if (text == "songBuiltIn")
		{
			this.endOfSong.\u02C0\u02B2\u02C0\u02BD\u02BF\u02BD\u02B2\u02BD\u02BE\u02C1\u02B6();
			return;
		}
		if (text == "Color Profile")
		{
			this.endOfSong.\u02BD\u02BC\u02BF\u02C1\u02BF\u02B6\u02C1\u02C0\u02C1\u02BE\u02C1();
			return;
		}
		if (text == "Text resource in language file '{0}' c")
		{
			this.endOfSong.\u02B6\u02B9\u02B4\u02B2\u02B4\u02BB\u02BF\u02B7\u02BC\u02BD\u02C1();
			return;
		}
		if (!(text == ""))
		{
			return;
		}
		this.endOfSong.\u02C0\u02BB\u02B9\u02B3\u02B5\u02B3\u02BD\u02B7\u02B5\u02C1\u02C1();
	}

	public virtual void \u02BA\u02C1\u02C1\u02B5\u02B4\u02B2\u02C1\u02C1\u02BB\u02B6\u02BF()
	{
		base.gameObject.SetActive(false);
	}

	protected virtual void \u02B3\u02BB\u02BF\u02B4\u02B9\u02BA\u02B5\u02B5\u02BE\u02BB\u02BE()
	{
		if (GlobalVariables.\u02B7\u02B2\u02BA\u02B7\u02BB\u02B3\u02BE\u02B6\u02C1\u02C0\u02B7.\u02BC\u02B6\u02BA\u02BF\u02B2\u02C1\u02B3\u02B5\u02B2\u02B5\u02B6)
		{
			this.menuStrings = this.setlistStrings;
		}
		else if (this.endOfSong.\u02B7\u02B4\u02B9\u02BD\u02C0\u02BA\u02B5\u02BF\u02BA\u02B3\u02B8)
		{
			this.menuStrings = this.practiceStrings;
		}
		else
		{
			this.menuStrings = this.quickplayStrings;
		}
		base.Start();
	}

	public override void \u02B3\u02BC\u02BA\u02C0\u02C0\u02B8\u02B2\u02B4\u02B3\u02C1\u02B8()
	{
		base.gameObject.SetActive(false);
	}

	public virtual void \u02C0\u02BE\u02B9\u02B5\u02B6\u02C1\u02B5\u02C0\u02BE\u02B8\u02C1()
	{
		string text = base.\u02BC\u02B4\u02C0\u02BC\u02BE\u02BD\u02B8\u02B9\u02BF\u02BA\u02B7();
		if (text == "ERROR: Song length is 0 ignoring playback request.")
		{
			this.endOfSong.\u02C0\u02B2\u02C0\u02BD\u02BF\u02BD\u02B2\u02BD\u02BE\u02C1\u02B6();
			return;
		}
		if (text == "<b>{0}</b>")
		{
			this.endOfSong.\u02B7\u02B2\u02BA\u02B8\u02B9\u02BF\u02B2\u02C0\u02BE\u02B3\u02B3();
			return;
		}
		if (text == "settings")
		{
			this.endOfSong.\u02BE\u02B5\u02BE\u02B9\u02B6\u02C0\u02BF\u02BB\u02C0\u02B3\u02BD();
			return;
		}
		if (!(text == "VOLUME"))
		{
			return;
		}
		this.endOfSong.\u02C0\u02BB\u02B9\u02B3\u02B5\u02B3\u02BD\u02B7\u02B5\u02C1\u02C1();
	}

	public virtual void \u02B8\u02B3\u02B9\u02BD\u02BF\u02BE\u02BE\u02B2\u02BB\u02BE\u02C0()
	{
		base.gameObject.SetActive(true);
	}

	[SerializeField]
	private EndOfSong endOfSong;

	[SerializeField]
	private string[] quickplayStrings;

	[SerializeField]
	private string[] practiceStrings;

	[SerializeField]
	private string[] setlistStrings;

	[SerializeField]
	private string[] setlistEndStrings;
}
