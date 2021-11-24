using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIButtonSettings : MonoBehaviour
{
	[SerializeField] private Button _settingsButton;
	private void Start()
	{
		_settingsButton.onClick.AddListener(GameHandler.Instance.GetComponent<SettingsHandler>().OpenSettings);
	}
}
