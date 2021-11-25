using System.Collections;
using UnityEngine;


public class TriggerAddScore : MonoBehaviour
{
	private bool _isAdd = true;
	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.GetComponent<Player>() && _isAdd)
		{
			StartCoroutine(Delay());
			ScoreHanlder.Instance.AddScore();
			_isAdd = false;
		}
	}
	private void OnEnable()
	{
		_isAdd = true;
	}
	private IEnumerator Delay()
	{
		yield return new WaitForSeconds(0.5f);
		AudioHandler.Instance.PlaySound(TypeSound.Ice);
	}
}
