using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectedSkinButton : MonoBehaviour
{
	public Action OnSelectedSkinAction;
	[SerializeField] private Image _buttonImage;
	[SerializeField] private Color _selected;
	[SerializeField] private Color _unSelected;
	public void SelectedSkinToPlayer()
	{
		OnSelectedSkinAction?.Invoke();
	}

	public void Selected(bool select)
	{
		if (select) _buttonImage.color = _selected;
		else _buttonImage.color = _unSelected;
	}
}
