using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PausedHandler : MonoBehaviour
{
	public static PausedHandler Instance;
	private const string _sceneGame = "_Game";
	private const string _sceneMenu = "_Menu";

	[SerializeField] private GameObject _pausedPanel;
	[SerializeField] private GameObject _endPanel;

	private void Awake()
	{
		Instance = this;
	}
	public void ResetGame()
	{
		Time.timeScale = 1f;
		GameHandler.Instance.Restart();

		if(ADController.Instance.IsContinue == false) ScoreHanlder.Instance.Restart();

		GameHandler.Instance.StartGame();
		ADController.Instance.ShowInterstitial();
	}

	public void ExitGame()
	{
		SceneManager.LoadScene(_sceneMenu);
		Time.timeScale = 1f;
		ADController.Instance.ShowInterstitial();
	}

	public void PusedGame(bool active = false)
	{
		_pausedPanel.SetActive(active);
		Time.timeScale = Convert.ToInt32(!active);
		ADController.Instance.ShowInterstitial();
	}

	public void EndLevel()
	{
		_endPanel.SetActive(true);
	}
}
