using System;
using UnityEngine;

public class ScoreHanlder : MonoBehaviour
{
	public static ScoreHanlder Instance;
	public Action<int> OnScroreUpdateAction;
	public Action<int> OnDiamondUpdateAction;

	private int _score;
	private int _diamondCount;
	private void Awake()
	{
		_score = default;
		_diamondCount = default;
		if (Instance == null)
		{
			Instance = this;
		}
		else
		{
			Destroy(gameObject);
		}

	}
	public void AddScore()
	{
		_score++;
		OnScroreUpdateAction?.Invoke(_score);
	}

	public void AddDiamond()
	{
		_diamondCount++;
		OnDiamondUpdateAction?.Invoke(_diamondCount);
	}
}
