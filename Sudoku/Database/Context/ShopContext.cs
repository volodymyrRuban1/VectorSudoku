using System.Threading.Tasks;
using Database.Entities;
using Microsoft.EntityFrameworkCore;

namespace Database.Context
{
	public class ShopContext : DbContext
	{
		public DbSet<Product> Products { get; set; }
		public DbSet<Category> Categories { get; set; }
		public DbSet<Supplier> Suppliers { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Server =.; Database = MyShop; Trusted_Connection = True;");
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Seed();
		}
	}
}
