using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyHandler : MonoBehaviour
{
	public static MoneyHandler Instance;
	private int _money;

	private void Awake()
	{
		if(Instance == null)
		{
			Instance = this;
		}
		else
		{
			Destroy(gameObject);
		}
		DontDestroyOnLoad(gameObject);

		if (PlayerPrefs.HasKey("money"))
		{
			_money = PlayerPrefs.GetInt("money");
		}
	}

	public void AddMoneyToBank(int count)
	{
		_money += count;
		PlayerPrefs.SetInt("money", _money);
	}

	public void PutMoneyToBank(int count)
	{
		_money -= count;
		PlayerPrefs.SetInt("money", _money);
	}
}
