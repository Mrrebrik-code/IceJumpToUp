using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ADController : MonoBehaviour
{
	public static ADController Instance;
	public bool IsContinue;
	[SerializeField] private RewardPopup _rewardPopupMoney;
	[SerializeField] private RewardPopup _rewardPopupContinue;

	private bool _isRewardSuccessful = false;
	private string _currentRewarded;
	private void Awake()
	{
		if (Instance == null) Instance = this;
		else Destroy(gameObject);

		DontDestroyOnLoad(gameObject);
	}
	private void Start()
	{
		YandexSDK.instance.onRewardedAdReward += OnRewardSuccessfulHandler;
		YandexSDK.instance.onRewardedAdClosed += OnRewardCloseHandler;
	}

	private void OnRewardCloseHandler(int status)
	{

		switch (_currentRewarded)
		{
			case "money":
				MoneyHandler.Instance.AddMoneyToBank(10);
				break;
			case "continue":
				IsContinue = true;
				PausedHandler.Instance.ResetGame();
				break;
		}
		_isRewardSuccessful = false;
	}

	private void OnRewardSuccessfulHandler(string reward)
	{
		_currentRewarded = reward;
		_isRewardSuccessful = true;
	}

	public void ShowInterstitial()
	{
#if Yandex
		YandexSDK.instance.ShowInterstitial();
#endif
	}

	public void ShowReward(string reward)
	{
		YandexSDK.instance.ShowRewarded(reward);
	}

	public void OpenRewardPopupMoney()
	{
		_isRewardSuccessful = false;
		Instantiate(_rewardPopupMoney, FindObjectOfType<Canvas>().transform);
	}
	public void OpenRewardPopupContinue()
	{
		_isRewardSuccessful = false;
		Instantiate(_rewardPopupContinue, FindObjectOfType<Canvas>().transform);
	}
}
