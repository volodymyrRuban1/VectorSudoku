using Database.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Database
{
	public static class SeedData
	{

		public static void Seed(this ModelBuilder builder)
		{
			SeedDbWithCategories(builder.Entity<Category>());
			SeedDbWithProducts(builder.Entity<Product>());
			SeedDbWithSuppliers(builder.Entity<Supplier>());
		}
		public static void SeedDbWithCategories(EntityTypeBuilder<Category> builder)
		{
			builder.HasData(
				new Category()
				{
					CategoryId = 1,
					CategoryName = "Beverages",
					Description = "Soft drinks, coffees, teas, beers, and ales"
				},
				new Category()
				{
					CategoryId = 2,
					CategoryName = "Condiments",
					Description = "Sweet and savory sauces, relishes, spreads, and seasonings"
				},
				new Category()
				{
					CategoryId = 3,
					CategoryName = "Confections",
					Description = "Desserts, candies, and sweet breads"
				},
				new Category()
				{
					CategoryId = 4,
					CategoryName = "Dairy Products",
					Description = "Cheeses"
				},
				new Category()
				{
					CategoryId = 5,
					CategoryName = "Grains/Cereals",
					Description = "Breads, crackers, pasta, and cereal"
				}
			);

		}

		public static void SeedDbWithSuppliers(EntityTypeBuilder<Supplier> builder)
		{
			builder.HasData
			(
				new Supplier()
				{
					SupplierId = 1,
					SupplierName = "Exotic Liquid",
					City = "London",
					Country = "UK"
				},
				new Supplier()
				{
					SupplierId = 2,
					SupplierName = "New Orleans Cajun Delights",
					City = "New Orleans",
					Country = "USA"
				},
				new Supplier()
				{
					SupplierId = 3,
					SupplierName = "Grandma Kelly’s Homestead",
					City = "Ann Arbor",
					Country = "USA"
				},
				new Supplier()
				{
					SupplierId = 4,
					SupplierName = "Tokyo Traders",
					City = "Tokyo",
					Country = "Japan"
				},
				new Supplier()
				{
					SupplierId = 5,
					SupplierName = "Cooperativa de Quesos ‘Las Cabras’",
					City = "Oviedo",
					Country = "Spain"
				}

			);
		}

		public static void SeedDbWithProducts(EntityTypeBuilder<Product> builder)
		{
			builder.HasData
			(
				new Product()
				{
					ProductId = 1,
					ProductName = "Chais",
					SupplierId = 1,
					CategoryId = 1,
					Price = 18.00m
				},
				new Product()
				{
					ProductId = 2,
					ProductName = "Chang",
					SupplierId = 1,
					CategoryId = 1,
					Price = 19.00m
				},
				new Product()
				{
					ProductId = 3,
					ProductName = "Aniseed ",
					SupplierId = 1,
					CategoryId = 2,
					Price = 10.00m
				},
				new Product()
				{
					ProductId = 4,
					ProductName = "Chef Anton’s Cajun Seasoning",
					SupplierId = 2,
					CategoryId = 2,
					Price = 22.00m
				},
				new Product()
				{
					ProductId = 5,
					ProductName = "Chef Anton’s Gumbo Mix",
					SupplierId = 2,
					CategoryId = 2,
					Price = 21.35m
				}
			);
		}


	}
}
