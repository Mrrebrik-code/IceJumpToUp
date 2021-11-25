using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RewardMoneyButton : MonoBehaviour
{
	private Button _button;
	private void Start()
	{
		_button = GetComponent<Button>();
		_button.onClick.AddListener(RewardMoney);
	}
	private void RewardMoney()
	{
		MoneyHandler.Instance.AddMoneyToBank(10);
	}
}
