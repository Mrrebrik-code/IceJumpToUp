using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
	public int Id;
	public Transform PointUp;
	public Transform PointDown;
	public GameObject TriggerEnd;
	public GameObject Diamond;


	private void OnEnable()
	{
		Diamond.SetActive(true);
	}
}
