using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UIRewardButton : MonoBehaviour
{
	[SerializeField] private TypeReward _type;
	private Button _settingsButton;
	private void Start()
	{
		_settingsButton = GetComponent<Button>();

		switch (_type)
		{
			case TypeReward.Money:
				_settingsButton.onClick.AddListener(ADController.Instance.OpenRewardPopupMoney);
				break;
			case TypeReward.Continue:
				_settingsButton.onClick.AddListener(ADController.Instance.OpenRewardPopupContinue);
				break;
		}
		
	}
}
