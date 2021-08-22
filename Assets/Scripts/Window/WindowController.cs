using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindowController : MonoBehaviour
{
	[SerializeField] private Window _window;

	private void Start()
	{
		WindowHandler.Instance.SetWindow(_window);
	}
	private void OnEnable()
	{
		WindowHandler.Instance.SetWindow(_window);
	}
}
