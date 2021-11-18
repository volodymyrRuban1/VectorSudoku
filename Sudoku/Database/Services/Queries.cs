using System.Linq;
using Database.Context;
using Database.Entities;

namespace Database.Services
{
	public class Queries
	{
		private readonly ShopContext _context;

		public Queries()
		{
			_context = new ShopContext();
		}

		// ●	Select product with product name that begins with ‘C’.
		public IQueryable<Product> ProductsBeginsWithC()
		{
			return _context.Products.Where(product => product.ProductName.StartsWith("C"));
		}

		// ●	Select product with the smallest price.
		public Product ProductHasSmallesPrize()
		{
			return _context.Products
				.FirstOrDefault(product => product.Price == _context.Products
					.Min(p => p.Price));
		}

		// ●	Select cost of all products from the USA.
		public decimal TotalProductCostInUSA()
		{
			return _context.Products.Where(product => product.Supplier.Country == "USA")
				.Sum(product => product.Price);
		}

		// ●	Select suppliers that supply Condiments.
		public IQueryable<Supplier> SuppliersWhoSuppliesCondiments()
		{
			return _context.Products
				.Where(product => product.Category.CategoryName == "Condiments")
				.Select(product => product.Supplier);
		}

	}
}
