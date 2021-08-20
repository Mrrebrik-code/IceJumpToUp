using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraHandler : MonoBehaviour
{
	[SerializeField] private GameObject LockMoveToObject;

	private void LateUpdate()
	{
		transform.position = new Vector3(0, LockMoveToObject.transform.position.y, -10f);
	}
}
