using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameHandler : MonoBehaviour
{
	[SerializeField] private List<GameObject> Carts = new List<GameObject>();
	[SerializeField] private Transform LevelContent;
	public List<GameObject> CartsLevel = new List<GameObject>();
	[SerializeField] Player player;
	[SerializeField] Player playerObj;
	private void Start()
	{
		GenerationLevel(10);
		playerObj = Instantiate(player, LevelContent);
	}

	private void GenerationLevel(int level)
	{
		
	}
}
