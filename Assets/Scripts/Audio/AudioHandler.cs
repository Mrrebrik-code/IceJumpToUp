using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioHandler : MonoBehaviour
{
	public static AudioHandler Instance;
	[SerializeField] private AudioSource _soundSource;
	[SerializeField] private AudioSource _musicSource;


	private void Awake()
	{
		if(Instance == null)
		{
			Instance = this;
			DontDestroyOnLoad(gameObject);
		}
		else
		{
			Destroy(gameObject);
		}
	}

	public void SetSoundValue(float value)
	{
		_soundSource.volume = value;
	}

	public void SetMusicValue(float value)
	{
		_musicSource.volume = value;
	}

	public void PlaySound(AudioClip sound)
	{
		_soundSource.PlayOneShot(sound);
	}
}
