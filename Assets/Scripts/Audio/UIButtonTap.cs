using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIButtonTap : MonoBehaviour
{
	public void PlaySoundTap()
	{
		AudioHandler.Instance.PlaySound(TypeSound.Tap);
	}
}
