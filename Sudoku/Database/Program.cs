using System;
using System.Xml;
using Database.Context;
using Database.Services;
using Microsoft.EntityFrameworkCore;

namespace Database
{
	class Program
	{
		static void Main(string[] args)
		{
			Queries queries = new Queries();

			foreach (var product in queries.ProductsBeginsWithC())
			{
				Console.WriteLine($"ID : {product.ProductId}\nProduct Name: {product.ProductName}");
			}

			Console.WriteLine(new string('-', 45));

			var productWithSmallesPrice = queries.ProductHasSmallesPrize();

			Console.WriteLine
				($"ID : {productWithSmallesPrice.ProductId}\n" +
				 $"Product Name: {productWithSmallesPrice.ProductName}\n" +
				 $"Product Price: {productWithSmallesPrice.Price}");

			Console.WriteLine(new string('-', 45));

			Console.WriteLine($"Total price of products in USA : {queries.TotalProductCostInUSA()}");

			Console.WriteLine(new string('-', 45));

			foreach (var supplier in queries.SuppliersWhoSuppliesCondiments())
			{
				Console.WriteLine($"ID : {supplier.SupplierId}\n" +
				                  $"Supplier Name: {supplier.SupplierName}\n");
			}

			Console.WriteLine(new string('-', 45));
		}
	}
}
