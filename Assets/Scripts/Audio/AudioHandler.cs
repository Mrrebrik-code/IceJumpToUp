using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum TypeSound : int
{
	Start,
	Stakan1,
	Stakan2,
	Ice,
	Tap
}
public class AudioHandler : MonoBehaviour
{
	public static AudioHandler Instance;
	[SerializeField] private AudioSource _soundSource;
	[SerializeField] private AudioSource _musicSource;
	[SerializeField] private AudioClip[] _sounds;

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

	public void PlaySound(TypeSound sound)
	{
		AudioClip clip = _sounds[(int)sound];
		_soundSource.PlayOneShot(clip);
	}
}
