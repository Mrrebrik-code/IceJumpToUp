using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreHanlder : MonoBehaviour
{
	public static ScoreHanlder Instance;
	public Action<int> OnScroreUpdateAction;

	private int _score;
	private void Awake()
	{
		if(Instance == null)
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
}
