using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RewardPopup : MonoBehaviour
{
	[SerializeField] private string _rewardName;
	public void OnHide()
	{
		if (_rewardName == "continue")
		{
			PausedHandler.Instance.ResetGame();
		}
		DestroyImmediate(gameObject);
	}
	public void OnReward()
	{
#if Yandex
		ADController.Instance.ShowReward(_rewardName);
#else
		if(_rewardName == "money")
		{
			MoneyHandler.Instance.AddMoneyToBank(10);
		}
		else
		{
			ADController.Instance.IsContinue = true;
			PausedHandler.Instance.ResetGame();
		}

#endif
		DestroyImmediate(gameObject);
	}
}
