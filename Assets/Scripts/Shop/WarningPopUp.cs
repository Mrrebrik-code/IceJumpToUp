using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarningPopUp : MonoBehaviour
{
	public void OnHide()
	{
		StartCoroutine(Delay());
	}
	IEnumerator Delay()
	{
		yield return new WaitForSeconds(0.1f);
		DestroyImmediate(gameObject);
	}
}
