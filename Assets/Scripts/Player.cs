using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
	public static Player Instance;
	private Rigidbody2D _rigidbody2D;
	[SerializeField] private float _jumpRorce;
	[SerializeField] private float _countTorque;
	[SerializeField] private GroundChecker _groundChecker;

	private void Start()
	{
		Instance = this;
		_rigidbody2D = GetComponent<Rigidbody2D>();
	}
	public void Jump()
	{
		if (_groundChecker.IsGround)
		{
			_rigidbody2D.AddForce(Vector3.up * _jumpRorce, ForceMode2D.Impulse);
			_rigidbody2D.AddTorque(_countTorque);
		}
		
	}
}
