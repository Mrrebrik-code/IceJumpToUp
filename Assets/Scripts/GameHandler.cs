using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameHandler : MonoBehaviour
{
	public static GameHandler Instance;
	[SerializeField] private int _poolCount = 2;
	[SerializeField] private bool _autoExpand = false;
	[SerializeField] private List<Level> _levelVariantPrefab;
	[SerializeField] private Transform _gameTransform;

	private List<MonoPool<Level>> _pools;

	[SerializeField] private Player _player;

	private void Start()
	{
		Instance = this;
		_pools = new List<MonoPool<Level>>();
		for (int i = 0; i < _poolCount; i++)
		{
			var pool = new MonoPool<Level>(_levelVariantPrefab[i], _poolCount, _gameTransform);
			_pools.Add(pool);
			_pools[i].IsAutoExpand = _autoExpand;
		}
		CreateLevel();


		_player.gameObject.SetActive(true);
	}

	[SerializeField] private Level _destroyLevel;
	public void CreateLevel()
	{
		foreach (var pool in _pools)
		{
			if (pool.HasFreeElement(element: out var element))
			{
				var level = element;
				if(_destroyLevel != null)
				{
					level.transform.position = new Vector3(_destroyLevel.PointUp.position.x, _destroyLevel.PointUp.position.y + 3, _destroyLevel.PointUp.position.z);
				}
				//_destroyLevel = level;
	/*			foreach (var poolBusyElement in _pools)
				{
					if(poolBusyElement.HasBusyElement(element: out var elementBusy))
					{
						_destroyLevel = elementBusy;
						level.transform.position = new Vector3(elementBusy.PointUp.position.x, elementBusy.PointUp.position.y + 3, elementBusy.PointUp.position.z);
						//elementBusy.gameObject.SetActive(false);
					}
				}*/
				level.gameObject.SetActive(true);
				break;
			}
		}
		/*var level = _pools[Random.Range(0, _pools.Count)].GetFreeElement();
		level.gameObject.SetActive(true);*/


	}

	public void DestroyLevel()
	{
		if(_destroyLevel != null)
		{
			_destroyLevel.gameObject.SetActive(false);
			foreach (var poolBusyElement in _pools)
			{
				if (poolBusyElement.HasBusyElement(element: out var elementBusy))
				{
					_destroyLevel = elementBusy;
					//elementBusy.gameObject.SetActive(false);
				}
			}
		}
		else
		{
			foreach (var poolBusyElement in _pools)
			{
				if (poolBusyElement.HasBusyElement(element: out var elementBusy))
				{
					_destroyLevel = elementBusy;
					//elementBusy.gameObject.SetActive(false);
				}
			}
		}
		
	}

}
