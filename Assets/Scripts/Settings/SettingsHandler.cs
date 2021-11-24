using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsHandler : MonoBehaviour
{
	[SerializeField] private Settings _settings; 

	public void OpenSettings()
	{
		Instantiate(_settings, FindObjectOfType<Canvas>().transform);
	}
}
