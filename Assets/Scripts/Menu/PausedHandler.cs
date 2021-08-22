using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PausedHandler : MonoBehaviour
{
	private const string _sceneGame = "_Game";
	private const string _sceneMenu = "_Menu";

	[SerializeField] private GameObject _pausedPanel;
	public void ResetGame()
	{
		GameHandler.Instance.Restart();
		ScoreHanlder.Instance.Restart();
		GameHandler.Instance.StartGame();
	}

	public void ExitGame()
	{
		SceneManager.LoadScene(_sceneMenu);
		Time.timeScale = 1f;
	}

	public void PusedGame(bool active = false)
	{
		_pausedPanel.SetActive(active);
		Time.timeScale = Convert.ToInt32(!active);
	}
}
