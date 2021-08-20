using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayScroreHolder : MonoBehaviour
{
	[SerializeField] private Text _textScore;

	private void Start()
	{
		ScoreHanlder.Instance.OnScroreUpdateAction += UpdateDisplayScore;
	}

	private void UpdateDisplayScore(int score)
	{
		_textScore.text = score.ToString();
	}
}
