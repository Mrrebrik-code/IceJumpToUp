using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopHandler : MonoBehaviour
{
	public List<Product> BuyProducts = new List<Product>();
	public void BuyProduct(Product product)
	{
		if (MoneyHandler.Instance.PutMoneyToBank(product.Price))
		{
			product.isBuy = true;
			AddProduct(product);
		}
	}

	public void AddProduct(Product product)
	{
		BuyProducts.Add(product);
	}
}
