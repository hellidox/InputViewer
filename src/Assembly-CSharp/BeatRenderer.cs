using System;
using UnityEngine;

[RequireComponent(typeof(BasePlayer))]
public class BeatRenderer : MonoBehaviour, \u02B6\u02BB\u02BD\u02BB\u02BA\u02B6\u02B9\u02C0\u02B8\u02B4\u02BC
{
	public void RenderBeats()
	{
		int i = 0;
		while (i < this.maxBeatPool)
		{
			int num = this.\u02B2\u02B9\u02B2\u02C1\u02C1\u02BA\u02C1\u02C1\u02B2\u02BD\u02B5 + i;
			if (num <= this.\u02BE\u02B9\u02BD\u02BB\u02B5\u02BD\u02BF\u02C0\u02B3\u02BB\u02B4)
			{
				double num2 = (double)this.beats.times[num] - this.gameManager.songTime;
				float num3 = (float)((double)this.\u02BA\u02BF\u02B4\u02B8\u02B8\u02B4\u02BA\u02C0\u02B5\u02BB\u02BD + num2 * (double)this.noteSpeed) + this.\u02B9\u02BA\u02B9\u02B7\u02BC\u02BA\u02B2\u02BB\u02BC\u02C0\u02B8;
				if (num3 <= this.\u02B7\u02B5\u02B5\u02C1\u02B7\u02B5\u02BE\u02BA\u02BF\u02BE\u02C0)
				{
					if (num3 <= this.\u02BB\u02C0\u02BF\u02C0\u02B4\u02B9\u02B4\u02B7\u02B5\u02BF\u02BE)
					{
						this.\u02B2\u02B9\u02B2\u02C1\u02C1\u02BA\u02C1\u02C1\u02B2\u02BD\u02B5++;
						continue;
					}
					this.beatObjects[i].SetActive(true);
					this.beatTransforms[i].localScale = new Vector3(this.beatWidth, this.\u02B5\u02BB\u02B2\u02BA\u02BD\u02BB\u02B8\u02B2\u02C1\u02B2\u02BA(this.beats.BeatTypes[num]));
					this.beatTransforms[i].localPosition = new Vector3(0f, 0f, num3);
					Color color;
					if (this.beats.BeatTypes[num] == BeatStyle.MEASURE)
					{
						color = this.\u02B5\u02BD\u02B6\u02BA\u02B7\u02C0\u02B5\u02B3\u02B5\u02BE\u02BD;
					}
					else if (this.beats.BeatTypes[num] == BeatStyle.BEAT_WEAK)
					{
						color = this.\u02B8\u02C0\u02B4\u02BF\u02BD\u02BA\u02B8\u02BF\u02C0\u02BC\u02BE;
					}
					else
					{
						color = this.\u02BE\u02B2\u02B3\u02BD\u02C1\u02BF\u02C0\u02BA\u02B3\u02B9\u02C0;
					}
					this.beatRenderers[i].color = color;
					i++;
					continue;
				}
			}
			IL_014D:
			while (i < this.beatObjects.Length && this.beatObjects[i].activeSelf)
			{
				this.beatObjects[i].SetActive(false);
				i++;
			}
			return;
		}
		goto IL_014D;
	}

	public \u02B7\u02C0\u02B7\u02C0\u02B9\u02C0\u02BC\u02B3\u02BB\u02B7\u02B3 \u02B7\u02C0\u02B7\u02C0\u02B9\u02C0\u02BC\u02B3\u02BB\u02B7\u02B3
	{
		get
		{
			return \u02B7\u02C0\u02B7\u02C0\u02B9\u02C0\u02BC\u02B3\u02BB\u02B7\u02B3.Highway;
		}
	}

	public \u02B7\u02C0\u02B7\u02C0\u02B9\u02C0\u02BC\u02B3\u02BB\u02B7\u02B3 \u02B7\u02B3\u02B9\u02B9\u02BF\u02C0\u02B7\u02B5\u02C0\u02C0\u02B9()
	{
		return \u02B7\u02C0\u02B7\u02C0\u02B9\u02C0\u02BC\u02B3\u02BB\u02B7\u02B3.Notes;
	}

	public void \u02BF\u02B2\u02B6\u02B6\u02BD\u02C0\u02BE\u02B6\u02B6\u02BA\u02B8(float \u02B3\u02BD\u02BE\u02BB\u02BB\u02B9\u02B2\u02B9\u02BC\u02BB\u02BF, float \u02C1\u02B8\u02B7\u02B5\u02B2\u02BA\u02BC\u02B2\u02B7\u02B2\u02BC, float \u02B2\u02BA\u02BD\u02B8\u02C1\u02B3\u02B8\u02BF\u02B5\u02B9\u02BA, float \u02B3\u02BD\u02B6\u02B8\u02B3\u02BE\u02B3\u02C0\u02B3\u02C1\u02B4)
	{
		this.\u02B7\u02B5\u02B5\u02C1\u02B7\u02B5\u02BE\u02BA\u02BF\u02BE\u02C0 = \u02C1\u02B8\u02B7\u02B5\u02B2\u02BA\u02BC\u02B2\u02B7\u02B2\u02BC;
		this.\u02BB\u02C0\u02BF\u02C0\u02B4\u02B9\u02B4\u02B7\u02B5\u02BF\u02BE = \u02B3\u02BD\u02BE\u02BB\u02BB\u02B9\u02B2\u02B9\u02BC\u02BB\u02BF;
	}

	private void \u02BE\u02C0\u02BC\u02B6\u02B5\u02BB\u02C0\u02B4\u02C0\u02B7\u02BC()
	{
		this.basePlayer = base.GetComponent<BasePlayer>();
		if (this.basePlayer.\u02C0\u02B6\u02B5\u02BE\u02BB\u02B9\u02B2\u02BF\u02C0\u02BB\u02C0 == null || this.basePlayer.\u02C0\u02B6\u02B5\u02BE\u02BB\u02B9\u02B2\u02BF\u02C0\u02BB\u02C0.Count == 0)
		{
			this.\u02BE\u02B9\u02BD\u02BB\u02B5\u02BD\u02BF\u02C0\u02B3\u02BB\u02B4 = -1;
			return;
		}
		float num = 0f;
		foreach (Note note in this.basePlayer.\u02C0\u02B6\u02B5\u02BE\u02BB\u02B9\u02B2\u02BF\u02C0\u02BB\u02C0)
		{
			if (note.\u02B2\u02B8\u02B7\u02BD\u02B5\u02B7\u02B6\u02B2\u02BF\u02BD\u02C0 > num)
			{
				num = note.\u02B2\u02B8\u02B7\u02BD\u02B5\u02B7\u02B6\u02B2\u02BF\u02BD\u02C0;
			}
		}
		this.\u02BE\u02B9\u02BD\u02BB\u02B5\u02BD\u02BF\u02C0\u02B3\u02BB\u02B4 = this.beats.count - 1;
		while (this.\u02BE\u02B9\u02BD\u02BB\u02B5\u02BD\u02BF\u02C0\u02B3\u02BB\u02B4 > 0 && num <= this.beats.times[this.\u02BE\u02B9\u02BD\u02BB\u02B5\u02BD\u02BF\u02C0\u02B3\u02BB\u02B4])
		{
			this.\u02BE\u02B9\u02BD\u02BB\u02B5\u02BD\u02BF\u02C0\u02B3\u02BB\u02B4--;
		}
		if (this.\u02BE\u02B9\u02BD\u02BB\u02B5\u02BD\u02BF\u02C0\u02B3\u02BB\u02B4 < this.beats.count - 1)
		{
			this.\u02BE\u02B9\u02BD\u02BB\u02B5\u02BD\u02BF\u02C0\u02B3\u02BB\u02B4++;
		}
	}

	public void Update()
	{
		this.RenderBeats();
		if ((double)this.beats.times[this.beatIdx] < this.gameManager._songTime)
		{
			GlobalVariables.lastBeat = this.beats.times[this.beatIdx];
			if (this.beatIdx + 1 < this.beats.times.Count)
			{
				this.beatIdx++;
			}
		}
	}

	public void Reset()
	{
		if (!base.enabled)
		{
			return;
		}
		this.\u02B2\u02B9\u02B2\u02C1\u02C1\u02BA\u02C1\u02C1\u02B2\u02BD\u02B5 = 0;
		this.\u02BE\u02C0\u02BC\u02B6\u02B5\u02BB\u02C0\u02B4\u02C0\u02B7\u02BC();
	}

	private void FillBeatPoll()
	{
		this.beatObjects = new GameObject[this.maxBeatPool];
		this.beatTransforms = new Transform[this.maxBeatPool];
		this.beatRenderers = new SpriteRenderer[this.maxBeatPool];
		GameObject gameObject = Resources.Load("Prefabs/Gameplay/Notes/Beatline") as GameObject;
		for (int i = 0; i < this.maxBeatPool; i++)
		{
			this.beatObjects[i] = global::UnityEngine.Object.Instantiate<GameObject>(gameObject, Vector3.zero, gameObject.transform.rotation);
			this.beatObjects[i].SetActive(false);
			this.beatObjects[i].transform.parent = base.transform;
			this.beatObjects[i].transform.localScale = new Vector3(this.beatWidth, 1f);
			this.beatTransforms[i] = this.beatObjects[i].transform;
			this.beatRenderers[i] = this.beatObjects[i].GetComponent<SpriteRenderer>();
		}
	}

	public void Start()
	{
		this.\u02BB\u02B6\u02BD\u02BA\u02BC\u02B2\u02B8\u02BB\u02C0\u02BD\u02BE = base.GetComponent<TrackFadeManager>();
		this.basePlayer = base.gameObject.GetComponent<BasePlayer>();
		if (this.basePlayer.player.playerProfile.HasModChartModifier)
		{
			base.enabled = false;
		}
		this.gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
		this.noteSpeed = (float)this.basePlayer.player.playerProfile.noteSpeed.CurrentValue;
		this.beats = this.gameManager.GetBeatsFromChart;
		this.\u02BE\u02C0\u02BC\u02B6\u02B5\u02BB\u02C0\u02B4\u02C0\u02B7\u02BC();
		this.FillBeatPoll();
		this.\u02BB\u02B6\u02BD\u02BA\u02BC\u02B2\u02B8\u02BB\u02C0\u02BD\u02BE.\u02B2\u02B7\u02BE\u02B2\u02C1\u02B4\u02B6\u02B7\u02BE\u02BD\u02B8(this);
	}

	public void OnDisable()
	{
		if (this.beatObjects == null)
		{
			return;
		}
		GameObject[] array = this.beatObjects;
		for (int i = 0; i < array.Length; i++)
		{
			array[i].SetActive(false);
		}
	}

	private float \u02B5\u02BB\u02B2\u02BA\u02BD\u02BB\u02B8\u02B2\u02C1\u02B2\u02BA(BeatStyle \u02B7\u02BF\u02B6\u02B4\u02BA\u02BF\u02C0\u02BB\u02BA\u02B4\u02B4)
	{
		if (\u02B7\u02BF\u02B6\u02B4\u02BA\u02BF\u02C0\u02BB\u02BA\u02B4\u02B4 == BeatStyle.BEAT_STRONG)
		{
			return 1.1f * this.beatWidth;
		}
		if (\u02B7\u02BF\u02B6\u02B4\u02BA\u02BF\u02C0\u02BB\u02BA\u02B4\u02B4 == BeatStyle.BEAT_WEAK)
		{
			return 0.55f * this.beatWidth;
		}
		if (\u02B7\u02BF\u02B6\u02B4\u02BA\u02BF\u02C0\u02BB\u02BA\u02B4\u02B4 == BeatStyle.MEASURE)
		{
			return 2.2f * this.beatWidth;
		}
		return 1f;
	}

	\u02B7\u02C0\u02B7\u02C0\u02B9\u02C0\u02BC\u02B3\u02BB\u02B7\u02B3 \u02B6\u02BB\u02BD\u02BB\u02BA\u02B6\u02B9\u02C0\u02B8\u02B4\u02BC.\u02BA\u02BA\u02B7\u02B9\u02B9\u02B5\u02C1\u02C1\u02B2\u02B7\u02BA()
	{
		return this.\u02B7\u02C0\u02B7\u02C0\u02B9\u02C0\u02BC\u02B3\u02BB\u02B7\u02B3;
	}

	private GameManager gameManager;

	private Beats beats;

	protected int maxBeatPool = 200;

	protected int \u02B2\u02B9\u02B2\u02C1\u02C1\u02BA\u02C1\u02C1\u02B2\u02BD\u02B5;

	protected Transform[] beatTransforms;

	protected SpriteRenderer[] beatRenderers;

	protected GameObject[] beatObjects;

	private float \u02B7\u02B5\u02B5\u02C1\u02B7\u02B5\u02BE\u02BA\u02BF\u02BE\u02C0;

	private float \u02BB\u02C0\u02BF\u02C0\u02B4\u02B9\u02B4\u02B7\u02B5\u02BF\u02BE;

	public float \u02BA\u02BF\u02B4\u02B8\u02B8\u02B4\u02BA\u02C0\u02B5\u02BB\u02BD;

	private float noteSpeed;

	private const float \u02B7\u02BD\u02BA\u02BE\u02BE\u02B9\u02BF\u02B2\u02B5\u02B6\u02B6 = 2.2f;

	private const float \u02B6\u02B9\u02B8\u02B7\u02BC\u02BC\u02B5\u02B3\u02C0\u02BA\u02B5 = 1.1f;

	private const float \u02B2\u02BD\u02B8\u02B2\u02B3\u02C0\u02B3\u02B2\u02B6\u02BE\u02BB = 0.55f;

	public float beatWidth = 1f;

	public float \u02B9\u02BA\u02B9\u02B7\u02BC\u02BA\u02B2\u02BB\u02BC\u02C0\u02B8 = 0.0125f;

	private int \u02BE\u02B9\u02BD\u02BB\u02B5\u02BD\u02BF\u02C0\u02B3\u02BB\u02B4;

	private TrackFadeManager \u02BB\u02B6\u02BD\u02BA\u02BC\u02B2\u02B8\u02BB\u02C0\u02BD\u02BE;

	private BasePlayer basePlayer;

	private readonly Color \u02B5\u02BD\u02B6\u02BA\u02B7\u02C0\u02B5\u02B3\u02B5\u02BE\u02BD = new Color(1f, 1f, 1f, 1f);

	private readonly Color \u02BE\u02B2\u02B3\u02BD\u02C1\u02BF\u02C0\u02BA\u02B3\u02B9\u02C0 = new Color(1f, 1f, 1f, 0.7f);

	private readonly Color \u02B8\u02C0\u02B4\u02BF\u02BD\u02BA\u02B8\u02BF\u02C0\u02BC\u02BE = new Color(1f, 1f, 1f, 0.4f);

	private int beatIdx;
}
