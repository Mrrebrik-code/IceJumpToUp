using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Product : MonoBehaviour
{
	[SerializeField] private string _nameSkin;
	[SerializeField] private int _price;
	[SerializeField] private Skin _skin;


	public string Name { get { return _nameSkin; } }
	public int Price { get{ return _price; } }
	public Skin Skin{ get{ return _skin; } }

	public bool isBuy = false;

	[SerializeField] private Text _textPrice;
	[SerializeField] private Image _spriteSkin;

	[SerializeField] private GameObject _buyButton;
	[SerializeField] private SelectedSkinButton _selectedButton;


	private void Awake()
	{
		_spriteSkin.sprite = _skin.SpriteSkin;
		_textPrice.text = _price.ToString();
		_selectedButton.OnSelectedSkinAction += OnSelectedSkin;
		CheckBuyProduct();
	}

	private void CheckBuyProduct()
	{
		if(PlayerPrefs.HasKey("product_" + _nameSkin))
		{
			isBuy = true;
			_buyButton.SetActive(false);
			_selectedButton.gameObject.SetActive(true);
		}
		else
		{
			isBuy = false;
			_buyButton.SetActive(true);
			_selectedButton.gameObject.SetActive(false);
		}
	}

	private void OnSelectedSkin()
	{
		GameHandler.Instance.SkinPlayer = _skin;
	}
}