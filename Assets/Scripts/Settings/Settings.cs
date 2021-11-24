using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Settings : MonoBehaviour
{
	private float _valueSound;
	private float _valueMusic;

	[SerializeField] private Slider _sliderSounds;
	[SerializeField] private Slider _sliderMusics;

	public void ChangeSoundValue()
	{
		_valueSound = _sliderSounds.value;
		AudioHandler.Instance.SetSoundValue(_valueSound);
	}
	public void ChangeMusicValue()
	{
		_valueMusic = _sliderMusics.value;
		AudioHandler.Instance.SetMusicValue(_valueMusic);
	}

	public void OnEnable()
	{
		if (PlayerPrefs.HasKey("music"))
		{
			_valueMusic = PlayerPrefs.GetFloat("music");
			_sliderMusics.value = _valueMusic;
		}
		else
		{
			_valueMusic = 1;
		}
		if (PlayerPrefs.HasKey("sound"))
		{
			_valueSound = PlayerPrefs.GetFloat("sound");
			_sliderSounds.value = _valueSound;
		}
		else
		{
			_valueSound = 1;
		}

		AudioHandler.Instance.SetSoundValue(_valueSound);
		AudioHandler.Instance.SetMusicValue(_valueMusic);
	}

	public void Save()
	{
		PlayerPrefs.SetFloat("music", _valueMusic);
		PlayerPrefs.SetFloat("sound", _valueSound);
		StartCoroutine(Delay());
	}
	IEnumerator Delay()
	{
		yield return new WaitForSeconds(0.1f);
		DestroyImmediate(gameObject);
	}
}
