using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerAddScore : MonoBehaviour
{
	private bool _isAdd = true;
	private bool _isPlayerEnter = false;
	private Player _player;
	private void Update()
	{
		if (_isPlayerEnter && _player != null)
		{
			_player.transform.position = new Vector3(transform.position.x, _player.transform.position.y, _player.transform.position.z);
		}
	}
	private void OnTriggerEnter2D(Collider2D collision)
	{
		_isPlayerEnter = true;
		if(_player == null)
		{
			_player = collision.GetComponent<Player>();
		}
		if (collision.GetComponent<Player>() && _isAdd)
		{
			ScoreHanlder.Instance.AddScore();
			_isAdd = false;
		}
	}

	private void OnTriggerExit2D()
	{
		_isPlayerEnter = false;
	}
}
