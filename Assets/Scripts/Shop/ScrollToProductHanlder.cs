using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollToProductHanlder : MonoBehaviour
{
	//Core
	private const string _pathToProductSkin = "ScriptableObjects/Products";

	[Header("__________________________________Product__________________________________")]
	[SerializeField] private Product _product;
	[SerializeField] private Skin[] _skins;
	[SerializeField] private List<Product> _products;

	[Space]

	[Header("__________________________________Content__________________________________")]
	[SerializeField] private Transform _content;

	private void Start()
	{
		LoadSkinsToResources();
		InitProducts();
	}

	private bool LoadSkinsToResources()
	{
		_skins = Resources.LoadAll<Skin>(_pathToProductSkin);
		if(_skins != null)
		{
			return true;
		}
		else
		{
			throw new System.Exception($"Not search product to path: {_pathToProductSkin}");
		}
	}

	private void InitProducts()
	{
		for (int i = 0; i < _skins.Length; i++)
		{
			_products.Add(Instantiate(_product, _content));
			_products[i].Skin = _skins[i];
		}
	}
}
