using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopHandler : MonoBehaviour
{
	public static ShopHandler Instance;
	public List<Product> BuyProducts = new List<Product>();

	private void Awake()
	{
		Instance = this;
	}
	public void BuyProduct(Product product)
	{
		if (MoneyHandler.Instance.PutMoneyToBank(product.Price))
		{
			product.isBuy = true;
			AddProduct(product);
			PlayerPrefs.SetInt("product_" + product.Name, 1);
		}
	}

	public void AddProduct(Product product)
	{
		BuyProducts.Add(product);
	}
}
