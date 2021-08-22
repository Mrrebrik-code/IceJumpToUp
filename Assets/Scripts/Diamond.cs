using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diamond : MonoBehaviour
{
	[SerializeField] private int _countMoneyAdd;

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.GetComponent<Player>())
		{
			MoneyHandler.Instance.AddMoneyToBank(_countMoneyAdd);
		}
	}
}
