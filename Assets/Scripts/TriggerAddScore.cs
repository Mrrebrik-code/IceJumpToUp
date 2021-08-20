using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerAddScore : MonoBehaviour
{
	private bool isAdd = true;
	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.GetComponent<Player>() && isAdd)
		{
			ScoreHanlder.Instance.AddScore();
			isAdd = false;	
		}
	}
}
