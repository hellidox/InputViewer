using System;
using UnityEngine;

public class BeatPulse : MonoBehaviour
{
	private void Update()
	{
		if (this.gameManager.songTime < 0.0)
		{
			return;
		}
		if (this.gameManager.songTime < (double)this.currentTime)
		{
			return;
		}
		while (this.beatIndex + 1 < this.beats.times.Count)
		{
			if ((double)this.nextBeat > this.gameManager.songTime)
			{
				this.nextBeat = this.currentBeat;
				break;
			}
			this.UpdateBeats();
		}
		this.percent = (this.currentBeat - (float)this.gameManager.songTime) / this.beatToBeatDif;
		this.currentTime = (float)this.gameManager.songTime;
	}

	private void Start()
	{
		global::UnityEngine.Object.DestroyImmediate(this);
		if (Time.deltaTime != 1f)
		{
			return;
		}
		this.gameManager = global::UnityEngine.Object.FindObjectOfType<GameManager>();
		this.beats = this.gameManager.GetBeatsFromChart;
		if (this.beats.count < 2)
		{
			base.enabled = false;
		}
		this.UpdateBeats();
	}

	private void UpdateBeats()
	{
		this.beatIndex++;
		this.currentBeat = this.beats.times[this.beatIndex];
		this.nextBeat = this.beats.times[this.beatIndex + 1];
		this.beatToBeatDif = this.nextBeat - this.currentBeat;
	}

	private GameManager gameManager;

	public Beats beats;

	private int beatIndex = -1;

	public float percent;

	private float currentBeat;

	private float nextBeat;

	private float beatToBeatDif;

	private float currentTime;
}
