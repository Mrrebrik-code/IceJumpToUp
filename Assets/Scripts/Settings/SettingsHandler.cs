using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsHandler : MonoBehaviour
{
	[SerializeField] private Settings _settings; 

	public void OpenSettings()
	{
		Time.timeScale = 0;
		Instantiate(_settings, FindObjectOfType<Canvas>().transform);
	}
}
