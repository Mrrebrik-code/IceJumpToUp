using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CameraHandler : MonoBehaviour
{
	[SerializeField] private GameObject LockMoveToObject;
	[SerializeField] private float _speedMove = 0.2f;
	[SerializeField] private float _height = 0f;

	private void LateUpdate()
	{
		transform.DOMove(new Vector3(0, LockMoveToObject.transform.position.y + _height, -10f), _speedMove);
	}
}
